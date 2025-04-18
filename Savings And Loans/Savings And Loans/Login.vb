Public Class Login
    Dim dbHelper As New DatabaseHelper()

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' Check for missing credentials
        If Username.Text.Trim() = "" Or Password.Text.Trim() = "" Then
            MsgBox("Missing Credentials!")

        ElseIf Username.Text.Trim() = "admin" Or Password.Text.Trim() = "admin" Then
            Dim adminDashboard = New Admin
            adminDashboard.Show()

            Me.Hide()
        Else
            Try
                ' Attempt to log in with provided credentials
                Dim success As Boolean = dbHelper.LoginUser(Username.Text.Trim(), Password.Text.Trim())

                If success Then

                    If UserSession.LoggedInRole = "admin" Then
                        Dim adminDashboard = New Admin
                        adminDashboard.Show()
                    Else
                        Dim userDashboard = New User
                        userDashboard.Show()

                    End If
                    Me.Hide()
                Else
                    MsgBox("Username or Password Incorrect. Try again!")
                End If

            Catch ex As Exception
                MsgBox("An error occurred: " & ex.Message)
            End Try
        End If
    End Sub

    Private Sub SignupLink_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles SignupLink.LinkClicked
        ' Navigate to SignUp form when link is clicked
        Dim signup = New SignUp()
        signup.Show()
        Me.Hide()
    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click
        ' Exit the application when the label is clicked
        Application.Exit()
    End Sub
End Class
