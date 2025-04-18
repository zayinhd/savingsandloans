Imports System.Configuration
Imports MySqlConnector
Public Class AdminLoan


    Dim dbHelper As New DatabaseHelper()
    Private connectionString As String = ConfigurationManager.ConnectionStrings("MyDbConnection").ConnectionString

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click
        Application.Exit()

    End Sub

    Private Sub LoadPendingLoans()
        Try
            Using conn As New MySqlConnection(connectionString)
                conn.Open()

                Dim query As String = "SELECT loans.id, CONCAT(users.FirstName, ' ', users.LastName) AS FullName, 
                                      loans.loan_amount, loans.status, loans.laccount_number 
                               FROM loans 
                               INNER JOIN users ON loans.user_id = users.id 
                               WHERE loans.status = 'pending'"

                Dim adapter As New MySqlDataAdapter(query, conn)
                Dim dt As New DataTable()
                adapter.Fill(dt)

                LoansGrid.DataSource = dt

                ' Apply default colors AFTER data is loaded
                For Each row As DataGridViewRow In LoansGrid.Rows
                    row.DefaultCellStyle.BackColor = Color.White
                    row.DefaultCellStyle.ForeColor = Color.Teal
                Next

            End Using
        Catch ex As Exception
            MessageBox.Show("Error loading loans: " & ex.Message)
        End Try
    End Sub



    Dim selectedLoanId As Integer = -1

    Private Sub LoansGrid_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles LoansGrid.CellClick
        If e.RowIndex >= 0 Then
            ' Reset all rows to default styling
            For Each row As DataGridViewRow In LoansGrid.Rows
                row.DefaultCellStyle.BackColor = Color.White
                row.DefaultCellStyle.ForeColor = Color.Teal
            Next

            ' Highlight the selected row
            With LoansGrid.Rows(e.RowIndex).DefaultCellStyle
                .BackColor = Color.Teal
                .ForeColor = Color.White
            End With

            ' Store selected loan ID
            selectedLoanId = Convert.ToInt32(LoansGrid.Rows(e.RowIndex).Cells("id").Value)
        End If
    End Sub



    Private Sub AdminLoan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadPendingLoans()

        For Each row As DataGridViewRow In LoansGrid.Rows
            row.DefaultCellStyle.BackColor = Color.White
            row.DefaultCellStyle.ForeColor = Color.Teal
        Next

    End Sub

    Private Sub UpdateLoanStatus(newStatus As String)
        Try
            Using conn As New MySqlConnection(connectionString)
                conn.Open()

                Dim query As String = "UPDATE loans SET status = @status WHERE id = @id"
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@status", newStatus)
                    cmd.Parameters.AddWithValue("@id", selectedLoanId)
                    cmd.ExecuteNonQuery()
                End Using
            End Using

            MessageBox.Show("Loan status updated to " & newStatus & ".")
            LoadPendingLoans()
            selectedLoanId = -1

        Catch ex As Exception
            MessageBox.Show("Error updating loan status: " & ex.Message)
        End Try
    End Sub

    Private Sub AcceptBtn_Click(sender As Object, e As EventArgs) Handles AcceptBtn.Click
        If selectedLoanId <> -1 Then

            Try
                Using conn As New MySqlConnection(connectionString)
                    conn.Open()

                    ' Step 1: Get user_id and loan_amount for the selected loan
                    Dim userId As Integer = -1
                    Dim loanAmount As Decimal = 0D

                    Dim getLoanQuery As String = "SELECT user_id, loan_amount FROM loans WHERE id = @loanId"
                    Using getLoanCmd As New MySqlCommand(getLoanQuery, conn)
                        getLoanCmd.Parameters.AddWithValue("@loanId", selectedLoanId)
                        Using reader As MySqlDataReader = getLoanCmd.ExecuteReader()
                            If reader.Read() Then
                                userId = Convert.ToInt32(reader("user_id"))
                                loanAmount = Convert.ToDecimal(reader("loan_amount"))
                            Else
                                MessageBox.Show("Loan not found for selected ID.")
                                Exit Sub
                            End If
                        End Using
                    End Using

                    ' Step 2: Update user loan_balance
                    If userId <> -1 Then
                        Dim updateUserQuery As String = "UPDATE users SET loan_balance = loan_balance + @loanAmount WHERE id = @userId"
                        Using updateCmd As New MySqlCommand(updateUserQuery, conn)
                            updateCmd.Parameters.AddWithValue("@loanAmount", loanAmount)
                            updateCmd.Parameters.AddWithValue("@userId", userId)

                            Dim rowsAffected As Integer = updateCmd.ExecuteNonQuery()

                            If rowsAffected > 0 Then
                                MessageBox.Show("Loan balance updated successfully.")
                            Else
                                MessageBox.Show("Loan balance update failed. User may not exist.")
                            End If
                        End Using
                    End If

                End Using
            Catch ex As Exception
                MessageBox.Show("Error: " & ex.Message)
            End Try
            UpdateLoanStatus("approved")

        Else
            MessageBox.Show("Please select a loan to approve.")
        End If
    End Sub



    Private Sub RejectBtn_Click(sender As Object, e As EventArgs) Handles RejectBtn.Click
        If selectedLoanId <> -1 Then
            UpdateLoanStatus("rejected")
        Else
            MessageBox.Show("Please select a loan to reject.")
        End If
    End Sub

    Private Sub LogoutBtn_Click(sender As Object, e As EventArgs) Handles LogoutBtn.Click
        Dim success As Boolean = dbHelper.LogoutUser()

        MessageBox.Show("Logout Successful")

        Dim login = New Login
        login.Show()

        Me.Hide()
    End Sub

    Private Sub Users_Click(sender As Object, e As EventArgs) Handles Users.Click
        Dim users = New Admin
        users.Show()
        Me.Hide()
    End Sub

    Private Sub Admins_Click(sender As Object, e As EventArgs) Handles Admins.Click
        Dim admins = New AdminAdmin
        admins.Show()
        Me.Hide()
    End Sub

    Private Sub Loans_Click(sender As Object, e As EventArgs) Handles Loans.Click
        Dim loans = New AdminLoan
        loans.Show()
        Me.Hide()
    End Sub

    Private Sub Transactions_Click(sender As Object, e As EventArgs) Handles Transactions.Click
        Dim transactions = New AdminTransactions
        transactions.Show()
        Me.Hide()
    End Sub


End Class