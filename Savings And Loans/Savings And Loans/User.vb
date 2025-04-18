Imports System.IO
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel
Imports System.Configuration
Imports MySqlConnector
Public Class User

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
        Hide()
    End Sub
    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click
        Application.Exit()
    End Sub


    Private Sub LoanAmount_Click(sender As Object, e As EventArgs) Handles LoanBalancee.Click
        Dim loan = New UserLoan
        loan.Show()
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

    Private Sub SaveProfileImageToDatabase()
        If PictureBox1.Image IsNot Nothing Then
            Using ms As New MemoryStream()
                PictureBox1.Image.Save(ms, PictureBox1.Image.RawFormat)
                Dim imageBytes() As Byte = ms.ToArray()

                Using conn As New MySqlConnection(connectionString)
                    conn.Open()
                    Dim query As String = "UPDATE Users SET ProfileImage = @img WHERE id = @id"
                    Using cmd As New MySqlCommand(query, conn)
                        cmd.Parameters.AddWithValue("@img", imageBytes)
                        cmd.Parameters.AddWithValue("@id", UserSession.LoggedInUserId)
                        cmd.ExecuteNonQuery()
                    End Using
                End Using
            End Using
        End If
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
            Try
                PictureBox1.Image = Image.FromFile(OpenFileDialog1.FileName)
                PictureBox1.SizeMode = PictureBoxSizeMode.Zoom

                SaveProfileImageToDatabase()

            Catch ex As Exception
                MessageBox.Show("Invalid image file selected.")
            End Try
        End If
    End Sub

    Private Sub User_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim userId As Int32 = UserSession.LoggedInUserId
        Dim name As String = UserSession.FirstName
        Dim accountNumber As String = UserSession.AccountNumber
        Dim accountBalance As Decimal = UserSession.AccountBalance
        Dim accountName As String = UserSession.AccountName

        Dim loanBalance As Decimal = UserSession.LoanBalance


        WelcomeMsg.Text = "Welcome, " + name
        AccNumber.Text = accountNumber
        AccName.Text = accountName
        AccBalance.Text = accountBalance
        LoanBalancee.Text = loanBalance

        If UserSession.ProfileImage IsNot Nothing Then
            PictureBox1.Image = UserSession.ProfileImage
            PictureBox1.SizeMode = PictureBoxSizeMode.Zoom

        End If

    End Sub

    Private Sub LogoutBtn_Click(sender As Object, e As EventArgs) Handles LogoutBtn.Click
        Dim success As Boolean = dbHelper.LogoutUser()

        MessageBox.Show("Logout Successful")

        Dim login = New Login
        login.Show()

        Me.Hide()
    End Sub


End Class