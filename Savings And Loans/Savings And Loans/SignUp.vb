Public Class SignUp
    Dim dbHelper As New DatabaseHelper()

    Private Sub SignupBtn_Click(sender As Object, e As EventArgs) Handles SignupBtn.Click

        ' Check for missing credentials
        If Firstname.Text = "" Or Lastname.Text = "" Or Username.Text = "" Or Email.Text = "" Or RePassword.Text = "" Then
            MsgBox("Missing credentials")

        Else
            Try
                Dim success As Boolean = dbHelper.RegisterUser(Username.Text.Trim(), RePassword.Text.Trim(), Firstname.Text.Trim(), Lastname.Text.Trim(), Email.Text.Trim(), DateOfBirth.Value.Date())
                If success Then
                    MsgBox("Account created successfully!")

                    Dim login = New Login
                    login.Show()

                    Me.Hide()
                Else
                    MsgBox("Failed to create user account.")
                End If
            Catch ex As Exception
                MsgBox("An error occurred: " & ex.Message)
            End Try
        End If

    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click
        Application.Exit()
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Dim login = New Login()
        login.Show()

        Me.Hide()
    End Sub


End Class
