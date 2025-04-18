Imports System.Configuration
Imports MySqlConnector
Public Class UserHistory

    Dim dbHelper As New DatabaseHelper()
    Private connectionString As String = ConfigurationManager.ConnectionStrings("MyDbConnection").ConnectionString

    Private Sub UserHistory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        With HistoryGrid
            .EnableHeadersVisualStyles = False
            .BackgroundColor = Color.White
            .DefaultCellStyle.BackColor = Color.White
            .DefaultCellStyle.ForeColor = Color.Teal
            .DefaultCellStyle.SelectionBackColor = Color.Teal
            .DefaultCellStyle.SelectionForeColor = Color.White
            .ColumnHeadersDefaultCellStyle.BackColor = Color.Teal
            .ColumnHeadersDefaultCellStyle.ForeColor = Color.White
        End With

        ' Set style for LoanHistoryGrid
        With LoanHistoryGrid
            .EnableHeadersVisualStyles = False
            .BackgroundColor = Color.White
            .DefaultCellStyle.BackColor = Color.White
            .DefaultCellStyle.ForeColor = Color.Teal
            .DefaultCellStyle.SelectionBackColor = Color.Teal
            .DefaultCellStyle.SelectionForeColor = Color.White
            .ColumnHeadersDefaultCellStyle.BackColor = Color.Teal
            .ColumnHeadersDefaultCellStyle.ForeColor = Color.White
        End With

        LoadLoanHistory()
        LoadTransactionHistory()
    End Sub

    Private Sub LoadLoanHistory()
        Try
            Using conn As New MySqlConnection(connectionString)
                conn.Open()

                Dim query As String = "SELECT id, loan_amount, status, created_at FROM loans WHERE user_id = @userId ORDER BY created_at DESC"
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@userId", UserSession.LoggedInUserId)

                    Dim dt As New DataTable()
                    dt.Load(cmd.ExecuteReader())
                    LoanHistoryGrid.DataSource = dt
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error loading loan history: " & ex.Message)
        End Try
    End Sub

    Private Sub LoadTransactionHistory()
        Try
            Using conn As New MySqlConnection(ConfigurationManager.ConnectionStrings("MyDbConnection").ConnectionString)
                conn.Open()

                Dim query As String = "SELECT id, transaction_info, amount, created_at FROM transactions WHERE user_id = @userId ORDER BY created_at DESC"
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@userId", UserSession.LoggedInUserId)

                    Dim adapter As New MySqlDataAdapter(cmd)
                    Dim dt As New DataTable()
                    adapter.Fill(dt)

                    HistoryGrid.DataSource = dt
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error loading transaction history: " & ex.Message)
        End Try
    End Sub


    Private Sub LogOut_Click(sender As Object, e As EventArgs) Handles LogOut.Click
        Dim success As Boolean = dbHelper.LogoutUser()

        MessageBox.Show("Logout Successful")

        Dim login = New Login
        login.Show()

        Me.Hide()
    End Sub

    Private Sub Loan_Click(sender As Object, e As EventArgs) Handles Loan.Click
        Dim loan = New UserLoan
        loan.Show()
        Me.Hide()

    End Sub

    Private Sub Transfers_Click(sender As Object, e As EventArgs) Handles Transfers.Click
        Dim transfers = New UserTransfers
        transfers.Show()
        Me.Hide()

    End Sub

    Private Sub Account_Click(sender As Object, e As EventArgs) Handles Account.Click
        Dim account = New User
        account.Show()
        Hide()
    End Sub

    Private Sub Withdraw_Click(sender As Object, e As EventArgs) Handles Withdraw.Click
        Dim withdraw = New UserWithdraw
        withdraw.Show()
        Me.Hide()
    End Sub

    Private Sub History_Click(sender As Object, e As EventArgs) Handles History.Click
        Dim history = New UserHistory
        history.Show()
        Me.Hide()
    End Sub
    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click
        Application.Exit()
    End Sub

    Private Sub ClearAllBtn_Click(sender As Object, e As EventArgs) Handles ClearAllBtn.Click
        Dim confirmResult As DialogResult = MessageBox.Show("Are you sure you want to clear all your loan history?", "Confirm Delete", MessageBoxButtons.YesNo)

        If confirmResult = DialogResult.Yes Then
            Try
                Using conn As New MySqlConnection(connectionString)
                    conn.Open()

                    Dim deleteQuery As String = "DELETE FROM loans WHERE user_id = @userId"
                    Using cmd As New MySqlCommand(deleteQuery, conn)
                        cmd.Parameters.AddWithValue("@userId", UserSession.LoggedInUserId)
                        cmd.ExecuteNonQuery()
                    End Using

                    MessageBox.Show("All loan history cleared.")
                    LoadLoanHistory() ' refresh grid
                End Using
            Catch ex As Exception
                MessageBox.Show("Error clearing history: " & ex.Message)
            End Try
        End If
    End Sub


    Private Sub DeleteBtn_Click(sender As Object, e As EventArgs) Handles DeleteBtn.Click
        If LoanHistoryGrid.SelectedRows.Count = 0 Then
            MessageBox.Show("Please select a row to delete.")
            Return
        End If

        Dim selectedId As Integer = Convert.ToInt32(LoanHistoryGrid.SelectedRows(0).Cells("id").Value)

        Try
            Using conn As New MySqlConnection(connectionString)
                conn.Open()

                Dim deleteQuery As String = "DELETE FROM loans WHERE id = @id AND user_id = @userId"
                Using cmd As New MySqlCommand(deleteQuery, conn)
                    cmd.Parameters.AddWithValue("@id", selectedId)
                    cmd.Parameters.AddWithValue("@userId", UserSession.LoggedInUserId)
                    cmd.ExecuteNonQuery()
                End Using

                MessageBox.Show("Loan record deleted.")
                LoadLoanHistory() ' refresh grid
            End Using
        Catch ex As Exception
            MessageBox.Show("Error deleting record: " & ex.Message)
        End Try
    End Sub


    Private Sub SearchBtn_Click(sender As Object, e As EventArgs) Handles SearchBtn.Click
        Dim keyword As String = SearchBox.Text.Trim()

        Try
            Using conn As New MySqlConnection(connectionString)
                conn.Open()

                Dim query As String = "SELECT * FROM loans WHERE user_id = @userId AND (loan_amount LIKE @kw OR status LIKE @kw)"
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@userId", UserSession.LoggedInUserId)
                    cmd.Parameters.AddWithValue("@kw", "%" & keyword & "%")

                    Dim dt As New DataTable()
                    dt.Load(cmd.ExecuteReader())
                    LoanHistoryGrid.DataSource = dt
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error searching: " & ex.Message)
        End Try
    End Sub


    Private Sub HistoryGrid_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles HistoryGrid.CellContentClick
        If e.RowIndex >= 0 Then
            Try
                Dim selectedRow As DataGridViewRow = HistoryGrid.Rows(e.RowIndex)
                Dim transactionType As String = selectedRow.Cells("transaction_info").Value.ToString()
                Dim amount As Decimal = Convert.ToDecimal(selectedRow.Cells("amount").Value)

                MessageBox.Show($"Transaction: {transactionType}" & vbCrLf &
                            $"Amount: {amount.ToString("F2")}")
            Catch ex As Exception
                MessageBox.Show("Error reading transaction details: " & ex.Message)
            End Try
        End If
    End Sub



    Private Sub LoanHistoryGrid_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles LoanHistoryGrid.CellContentClick
        If e.RowIndex >= 0 Then
            Dim selectedRow As DataGridViewRow = LoanHistoryGrid.Rows(e.RowIndex)
            Dim loanId As Integer = Convert.ToInt32(selectedRow.Cells("id").Value)
            Dim loanAmount As Decimal = Convert.ToDecimal(selectedRow.Cells("loan_amount").Value)
            Dim loanStatus As String = selectedRow.Cells("status").Value.ToString()

            ' Example: Show details in a message box
            MessageBox.Show($"Loan ID: {loanId}" & vbCrLf &
                            $"Amount: {loanAmount}" & vbCrLf &
                            $"Status: {loanStatus}")
        End If
    End Sub

End Class