Imports System.Configuration
Imports MySqlConnector
Public Class UserWithdraw
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
        Me.Hide()

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

    Private Sub UserWithdraw_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim accountNumber As String = UserSession.AccountNumber
        Dim accountBalance As Decimal = UserSession.AccountBalance
        Dim accountName As String = UserSession.AccountName

        AccName.Text = accountName
        AccNumber.Text = accountNumber
        AccBalance.Text = accountBalance
    End Sub

    Private Sub LogoutBtn_Click(sender As Object, e As EventArgs) Handles LogoutBtn.Click
        Dim success As Boolean = dbHelper.LogoutUser()

        MessageBox.Show("Logout Successful")

        Dim login = New Login
        login.Show()

        Me.Hide()
    End Sub

    Private Sub DepositBtn_Click(sender As Object, e As EventArgs) Handles DepositBtn.Click
        Dim depositAmount As Decimal

        If Not Decimal.TryParse(Amount.Text.Trim(), depositAmount) Then
            MessageBox.Show("Please enter a valid amount.")
            Return
        End If

        If depositAmount <= 0 Then
            MessageBox.Show("Deposit amount must be greater than 0.")
            Return
        End If

        Try
            Using conn As New MySqlConnection(ConfigurationManager.ConnectionStrings("MyDbConnection").ConnectionString)
                conn.Open()

                ' Update account balance in the database
                Dim updateQuery As String = "UPDATE users SET account_balance = account_balance + @amount WHERE id = @userId"
                Using cmd As New MySqlCommand(updateQuery, conn)
                    cmd.Parameters.AddWithValue("@amount", depositAmount)
                    cmd.Parameters.AddWithValue("@userId", UserSession.LoggedInUserId)
                    cmd.ExecuteNonQuery()
                End Using

                ' Insert transaction record
                Dim insertQuery As String = "INSERT INTO transactions (user_id, transaction_info, amount, taccount_number, taccount_name, created_at) " &
                                        "VALUES (@userId, 'deposit', @amount, @accNum, @accName, NOW())"
                Using insertCmd As New MySqlCommand(insertQuery, conn)
                    insertCmd.Parameters.AddWithValue("@userId", UserSession.LoggedInUserId)
                    insertCmd.Parameters.AddWithValue("@amount", depositAmount)
                    insertCmd.Parameters.AddWithValue("@accNum", UserSession.AccountNumber)
                    insertCmd.Parameters.AddWithValue("@accName", UserSession.AccountName)
                    insertCmd.ExecuteNonQuery()
                End Using


                ' Update session and UI
                UserSession.AccountBalance += depositAmount
                AccBalance.Text = UserSession.AccountBalance.ToString("F2")

                MessageBox.Show("Deposit successful.")

            End Using

        Catch ex As Exception
            MessageBox.Show("Error during deposit: " & ex.Message)
        End Try
    End Sub

    Private Sub WithdrawBtn_Click(sender As Object, e As EventArgs) Handles WithdrawBtn.Click
        Dim withdrawAmount As Decimal

        If Not Decimal.TryParse(Amount.Text.Trim(), withdrawAmount) Then
            MessageBox.Show("Please enter a valid amount.")
            Return
        End If

        If withdrawAmount <= 0 Then
            MessageBox.Show("Withdraw amount must be greater than 0.")
            Return
        End If

        If withdrawAmount > UserSession.AccountBalance Then
            MessageBox.Show("Insufficient account balance.")
            Return
        End If

        Try
            Using conn As New MySqlConnection(ConfigurationManager.ConnectionStrings("MyDbConnection").ConnectionString)
                conn.Open()

                ' Deduct from user balance
                Dim updateQuery As String = "UPDATE users SET account_balance = account_balance - @amount WHERE id = @userId"
                Using cmd As New MySqlCommand(updateQuery, conn)
                    cmd.Parameters.AddWithValue("@amount", withdrawAmount)
                    cmd.Parameters.AddWithValue("@userId", UserSession.LoggedInUserId)
                    cmd.ExecuteNonQuery()
                End Using

                ' Insert transaction
                Dim insertQuery As String = "INSERT INTO transactions (user_id, transaction_info, amount, taccount_number, taccount_name, created_at) " &
                                        "VALUES (@userId, 'withdraw', @amount, @accNum, @accName, NOW())"
                Using insertCmd As New MySqlCommand(insertQuery, conn)
                    insertCmd.Parameters.AddWithValue("@userId", UserSession.LoggedInUserId)
                    insertCmd.Parameters.AddWithValue("@amount", withdrawAmount)
                    insertCmd.Parameters.AddWithValue("@accNum", UserSession.AccountNumber)
                    insertCmd.Parameters.AddWithValue("@accName", UserSession.AccountName)
                    insertCmd.ExecuteNonQuery()
                End Using

                ' Update session and UI
                UserSession.AccountBalance -= withdrawAmount
                AccBalance.Text = UserSession.AccountBalance.ToString("F2")

                MessageBox.Show("Withdrawal successful.")

            End Using

        Catch ex As Exception
            MessageBox.Show("Error withdrawing funds: " & ex.Message)
        End Try
    End Sub
End Class