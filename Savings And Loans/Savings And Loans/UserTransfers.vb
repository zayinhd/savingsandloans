Imports System.Configuration
Imports MySqlConnector
Public Class UserTransfers
    Dim dbHelper As New DatabaseHelper()
    Private connectionString As String = ConfigurationManager.ConnectionStrings("MyDbConnection").ConnectionString

    Private Sub Loan_Click(sender As Object, e As EventArgs) Handles Loan.Click
        Dim loan = New UserLoan
        loan.Show()
        Me.Hide()

    End Sub

    Private Sub Transfers_Click(sender As Object, e As EventArgs) Handles Transfers.Click
        Dim transfers = New UserTransfers
        transfers.Show()
        Hide()

    End Sub


    Private Sub Account_Click(sender As Object, e As EventArgs) Handles Account.Click
        Dim account = New User
        account.Show()
        Me.Hide()
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

    Private Sub LogoutBtn_Click(sender As Object, e As EventArgs) Handles LogoutBtn.Click
        Dim success As Boolean = dbHelper.LogoutUser()

        MessageBox.Show("Logout Successful")

        Dim login = New Login
        login.Show()

        Me.Hide()
    End Sub

    Private Sub UserTransfers_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub TransferBtn_Click(sender As Object, e As EventArgs) Handles TransferBtn.Click
        Try
            Dim transferAmount As Decimal = Convert.ToDecimal(TAmount.Text.Trim())
            Dim recipientAccNum As String = TAccountNumber.Text.Trim()
            Dim recipientAccName As String = TAccountName.Text.Trim()

            Using conn As New MySqlConnection(connectionString)
                conn.Open()

                ' Get current user balance
                Dim getBalanceCmd As New MySqlCommand("SELECT account_balance FROM users WHERE id = @userId", conn)
                getBalanceCmd.Parameters.AddWithValue("@userId", UserSession.LoggedInUserId)

                Dim currentBalance As Decimal = Convert.ToDecimal(getBalanceCmd.ExecuteScalar())

                ' Check if user has enough balance
                If currentBalance < transferAmount Then
                    MessageBox.Show("Insufficient balance.")
                    Return
                End If

                ' Start transaction
                Dim transaction As MySqlTransaction = conn.BeginTransaction()

                ' Deduct from sender's account
                Dim deductCmd As New MySqlCommand("UPDATE users SET account_balance = account_balance - @amount WHERE id = @userId", conn, transaction)
                deductCmd.Parameters.AddWithValue("@amount", transferAmount)
                deductCmd.Parameters.AddWithValue("@userId", UserSession.LoggedInUserId)
                deductCmd.ExecuteNonQuery()

                ' Add to recipient's account
                Dim creditCmd As New MySqlCommand("UPDATE users SET account_balance = account_balance + @amount WHERE account_number = @recipientAccNum", conn, transaction)
                creditCmd.Parameters.AddWithValue("@amount", transferAmount)
                creditCmd.Parameters.AddWithValue("@recipientAccNum", recipientAccNum)
                creditCmd.ExecuteNonQuery()

                ' Record transaction
                Dim insertTransactionCmd As New MySqlCommand("INSERT INTO transactions (user_id, transaction_info, amount, taccount_number, taccount_name, created_at)
                                                          VALUES (@userId, @info, @amount, @taccount_number, @taccount_name, @createdAt)", conn, transaction)
                insertTransactionCmd.Parameters.AddWithValue("@userId", UserSession.LoggedInUserId)
                insertTransactionCmd.Parameters.AddWithValue("@info", "Transfer")
                insertTransactionCmd.Parameters.AddWithValue("@amount", transferAmount)
                insertTransactionCmd.Parameters.AddWithValue("@taccount_number", recipientAccNum)
                insertTransactionCmd.Parameters.AddWithValue("@taccount_name", recipientAccName)
                insertTransactionCmd.Parameters.AddWithValue("@createdAt", DateTime.Now)
                insertTransactionCmd.ExecuteNonQuery()

                ' Commit changes
                transaction.Commit()

                ' Optional: Update session balance
                UserSession.AccountBalance = currentBalance - transferAmount

                MessageBox.Show("Transfer successful. New balance: ₵" & UserSession.AccountBalance.ToString("F2"))
            End Using
        Catch ex As Exception
            MessageBox.Show("Transfer failed: " & ex.Message)
        End Try
    End Sub


End Class