Imports System.Configuration
Imports MySqlConnector
Public Class AdminTransactions
    Dim dbHelper As New DatabaseHelper()
    Private connectionString As String = ConfigurationManager.ConnectionStrings("MyDbConnection").ConnectionString

    Private Sub AdminTransactions_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Optionally call a method here to load the transactions first
        LoadTransactions()

        ' Style all rows initially
        For Each row As DataGridViewRow In TransactionsGrid.Rows
            row.DefaultCellStyle.BackColor = Color.White
            row.DefaultCellStyle.ForeColor = Color.Teal
        Next
    End Sub

    Private Sub LoadTransactions()
        Try
            Using conn As New MySqlConnection(connectionString)
                conn.Open()
                Dim query As String = "SELECT id, user_id, transaction_info, amount, taccount_number, taccount_name, created_at FROM transactions"
                Using cmd As New MySqlCommand(query, conn)
                    Using adapter As New MySqlDataAdapter(cmd)
                        Dim table As New DataTable()
                        adapter.Fill(table)
                        TransactionsGrid.DataSource = table

                        ' Apply styling after loading
                        For Each row As DataGridViewRow In TransactionsGrid.Rows
                            row.DefaultCellStyle.BackColor = Color.White
                            row.DefaultCellStyle.ForeColor = Color.Teal
                        Next
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error loading transactions: " & ex.Message)
        End Try
    End Sub

    Private Sub Users_Click(sender As Object, e As EventArgs) Handles Users.Click
        Dim users = New Admin
        users.Show()

        Me.Hide()
    End Sub

    Private Sub Adminn_Click(sender As Object, e As EventArgs) Handles Admins.Click
        Dim admin = New AdminAdmin
        admin.Show()

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

    Private Sub LogoutBtn_Click(sender As Object, e As EventArgs) Handles LogoutBtn.Click
        Dim success As Boolean = dbHelper.LogoutUser()

        MessageBox.Show("Logout Successful")

        Dim login = New Login
        login.Show()

        Me.Hide()
    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click
        Application.Exit()
    End Sub

    Private Sub TransactionsGrid_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles TransactionsGrid.CellClick
        If e.RowIndex >= 0 Then
            ' Reset all rows
            For Each row As DataGridViewRow In TransactionsGrid.Rows
                row.DefaultCellStyle.BackColor = Color.White
                row.DefaultCellStyle.ForeColor = Color.Teal
            Next

            ' Highlight selected row
            With TransactionsGrid.Rows(e.RowIndex).DefaultCellStyle
                .BackColor = Color.Teal
                .ForeColor = Color.White
            End With
        End If
    End Sub

    Private Sub SearchBtn_Click(sender As Object, e As EventArgs) Handles SearchBtn.Click
        Dim keyword As String = SearchBox.Text.Trim()

        If keyword = "" Then
            MessageBox.Show("Please enter a search term.")
            Return
        End If

        Try
            Using conn As New MySqlConnection(connectionString)
                conn.Open()
                Dim query As String = "SELECT * FROM transactions WHERE taccount_number LIKE @keyword OR taccount_name LIKE @keyword"
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@keyword", "%" & keyword & "%")
                    Dim adapter As New MySqlDataAdapter(cmd)
                    Dim table As New DataTable()
                    adapter.Fill(table)
                    TransactionsGrid.DataSource = table
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error during search: " & ex.Message)
        End Try
    End Sub


    Private Sub DeleteBtn_Click(sender As Object, e As EventArgs) Handles DeleteBtn.Click
        If TransactionsGrid.SelectedRows.Count = 0 Then
            MessageBox.Show("Please select a transaction to delete.")
            Return
        End If

        Dim transactionId As Integer = Convert.ToInt32(TransactionsGrid.SelectedRows(0).Cells("id").Value)

        Try
            Using conn As New MySqlConnection(connectionString)
                conn.Open()
                Dim deleteQuery As String = "DELETE FROM transactions WHERE id = @id"
                Using cmd As New MySqlCommand(deleteQuery, conn)
                    cmd.Parameters.AddWithValue("@id", transactionId)
                    cmd.ExecuteNonQuery()
                End Using
            End Using

            MessageBox.Show("Transaction deleted successfully.")
            LoadAllTransactions()
        Catch ex As Exception
            MessageBox.Show("Error deleting transaction: " & ex.Message)
        End Try
    End Sub


    Private Sub ClearAllBtn_Click(sender As Object, e As EventArgs) Handles ClearAllBtn.Click
        Dim confirm = MessageBox.Show("Are you sure you want to delete ALL transactions?", "Confirm", MessageBoxButtons.YesNo)
        If confirm = DialogResult.No Then Exit Sub

        Try
            Using conn As New MySqlConnection(connectionString)
                conn.Open()
                Dim clearQuery As String = "DELETE FROM transactions"
                Using cmd As New MySqlCommand(clearQuery, conn)
                    cmd.ExecuteNonQuery()
                End Using
            End Using

            MessageBox.Show("All transactions cleared.")
            LoadAllTransactions()
        Catch ex As Exception
            MessageBox.Show("Error clearing transactions: " & ex.Message)
        End Try
    End Sub


    Private Sub LoadAllTransactions()
        Try
            Using conn As New MySqlConnection(connectionString)
                conn.Open()
                Dim query As String = "SELECT * FROM transactions"
                Using cmd As New MySqlCommand(query, conn)
                    Dim adapter As New MySqlDataAdapter(cmd)
                    Dim table As New DataTable()
                    adapter.Fill(table)
                    TransactionsGrid.DataSource = table
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error loading transactions: " & ex.Message)
        End Try
    End Sub


End Class