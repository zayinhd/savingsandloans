Imports System.Configuration
Imports MySqlConnector
Public Class UserLoan
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

    Private Sub LogoutBtn_Click(sender As Object, e As EventArgs) Handles LogoutBtn.Click
        Dim success As Boolean = dbHelper.LogoutUser()

        MessageBox.Show("Logout Successful")

        Dim login = New Login
        login.Show()

        Me.Hide()
    End Sub

    Private Sub UserLoan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim loanBalance As Decimal = UserSession.LoanBalance

        LoanBalancee.Text = loanBalance
    End Sub

    Private Sub RequestBtn_Click(sender As Object, e As EventArgs) Handles RequestBtn.Click

        Dim requestedAmount As Decimal
        If Decimal.TryParse(RequestedAmountt.Text.Trim(), requestedAmount) Then
            Dim interestRate As Decimal = 0.15D
            Dim totalLoanAmount As Decimal = requestedAmount + (requestedAmount * interestRate)


            Try
                Using conn As New MySqlConnection(connectionString)
                    conn.Open()

                    Dim query As String = "INSERT INTO loans (user_id, loan_amount, status, laccount_number, laccount_name) " &
                                          "VALUES (@user_id, @loan_amount, @status, @laccount_number, @laccount_name)"

                    Using cmd As New MySqlCommand(query, conn)
                        cmd.Parameters.AddWithValue("@user_id", UserSession.LoggedInUserId)
                        cmd.Parameters.AddWithValue("@loan_amount", totalLoanAmount)
                        cmd.Parameters.AddWithValue("@status", "pending")
                        cmd.Parameters.AddWithValue("@laccount_number", UserSession.AccountNumber)
                        cmd.Parameters.AddWithValue("@laccount_name", UserSession.FirstName & " " & UserSession.LastName)


                        cmd.ExecuteNonQuery()
                        MessageBox.Show("Loan request submitted successfully.")
                    End Using
                End Using

            Catch ex As Exception
                MessageBox.Show("Error submitting loan request: " & ex.Message)
            End Try

        Else
            MessageBox.Show("Please enter a valid amount.")
        End If
    End Sub

    Private Sub PayLoanBtn_Click(sender As Object, e As EventArgs) Handles PayLoanBtn.Click
        Dim paymentAmount As Decimal

        ' Step 1: Validate user input
        If Not Decimal.TryParse(RequestedAmountt.Text.Trim(), paymentAmount) Then
            MessageBox.Show("Please enter a valid amount.")
            Return
        End If

        If paymentAmount <= 0 Then
            MessageBox.Show("Payment amount must be greater than 0.")
            Return
        End If

        Try
            Using conn As New MySqlConnection(connectionString)
                conn.Open()

                ' Step 2: Check user balance
                Dim accountBalance As Decimal
                Dim balanceQuery As String = "SELECT account_balance FROM users WHERE id = @userId"
                Using balanceCmd As New MySqlCommand(balanceQuery, conn)
                    balanceCmd.Parameters.AddWithValue("@userId", UserSession.LoggedInUserId)
                    accountBalance = Convert.ToDecimal(balanceCmd.ExecuteScalar())
                End Using

                If accountBalance < paymentAmount Then
                    MessageBox.Show("Insufficient account balance.")
                    Return
                End If

                ' Step 3: Check user loan balance
                If UserSession.LoanBalance <= 0 Then
                    MessageBox.Show("You don't have any outstanding loan to pay.")
                    Return
                End If

                If paymentAmount > UserSession.LoanBalance Then
                    MessageBox.Show("Payment exceeds your outstanding loan balance.")
                    Return
                End If

                ' Step 4: Deduct from user account and loan balance
                Dim updateUserQuery As String = "UPDATE users SET account_balance = account_balance - @amount, loan_balance = loan_balance - @amount WHERE id = @userId"
                Using updateUserCmd As New MySqlCommand(updateUserQuery, conn)
                    updateUserCmd.Parameters.AddWithValue("@amount", paymentAmount)
                    updateUserCmd.Parameters.AddWithValue("@userId", UserSession.LoggedInUserId)
                    updateUserCmd.ExecuteNonQuery()
                End Using

                ' Step 5: Update in session
                UserSession.AccountBalance -= paymentAmount
                UserSession.LoanBalance -= paymentAmount


                LoanBalancee.Text = UserSession.LoanBalance.ToString("F2")

                MessageBox.Show("Payment successful.")

            End Using

        Catch ex As Exception
            MessageBox.Show("Error processing loan payment: " & ex.Message)
        End Try
    End Sub

End Class