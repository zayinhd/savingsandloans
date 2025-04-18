<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Login
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Label1 = New Label()
        Label6 = New Label()
        Username = New TextBox()
        Password = New TextBox()
        Label2 = New Label()
        BackgroundWorker1 = New ComponentModel.BackgroundWorker()
        Label3 = New Label()
        Button1 = New Button()
        SignupLink = New LinkLabel()
        Panel1 = New Panel()
        Label5 = New Label()
        Label4 = New Label()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 12F)
        Label1.Location = New Point(28, 126)
        Label1.Name = "Label1"
        Label1.Size = New Size(81, 21)
        Label1.TabIndex = 0
        Label1.Text = "Username"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 12F)
        Label6.Location = New Point(28, 165)
        Label6.Name = "Label6"
        Label6.Size = New Size(76, 21)
        Label6.TabIndex = 5
        Label6.Text = "Password"
        ' 
        ' Username
        ' 
        Username.Location = New Point(125, 126)
        Username.Name = "Username"
        Username.Size = New Size(144, 23)
        Username.TabIndex = 15
        ' 
        ' Password
        ' 
        Password.Location = New Point(125, 165)
        Password.Name = "Password"
        Password.PasswordChar = "●"c
        Password.Size = New Size(144, 23)
        Password.TabIndex = 19
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 18F)
        Label2.Location = New Point(57, 19)
        Label2.Name = "Label2"
        Label2.Size = New Size(210, 32)
        Label2.TabIndex = 20
        Label2.Text = "Savings and Loans"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 12F)
        Label3.Location = New Point(43, 254)
        Label3.Name = "Label3"
        Label3.Size = New Size(200, 21)
        Label3.TabIndex = 21
        Label3.Text = "Don't have an account yet? "
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.Green
        Button1.Location = New Point(154, 203)
        Button1.Name = "Button1"
        Button1.Size = New Size(75, 27)
        Button1.TabIndex = 22
        Button1.Text = "Login"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' SignupLink
        ' 
        SignupLink.AutoSize = True
        SignupLink.Font = New Font("Segoe UI", 12F)
        SignupLink.LinkColor = Color.White
        SignupLink.Location = New Point(233, 254)
        SignupLink.Name = "SignupLink"
        SignupLink.Size = New Size(65, 21)
        SignupLink.TabIndex = 24
        SignupLink.TabStop = True
        SignupLink.Text = "Sign Up"
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.White
        Panel1.Controls.Add(Label5)
        Panel1.Controls.Add(Label4)
        Panel1.Dock = DockStyle.Right
        Panel1.Location = New Point(331, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(247, 391)
        Panel1.TabIndex = 25
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = Color.Red
        Label5.Font = New Font("Segoe UI", 12F)
        Label5.Location = New Point(216, 9)
        Label5.Name = "Label5"
        Label5.Size = New Size(19, 21)
        Label5.TabIndex = 26
        Label5.Text = "X"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.Teal
        Label4.Font = New Font("Segoe UI", 30F)
        Label4.ForeColor = Color.White
        Label4.Location = New Point(93, 165)
        Label4.Name = "Label4"
        Label4.Size = New Size(63, 54)
        Label4.TabIndex = 29
        Label4.Text = "SL"
        ' 
        ' Login
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Teal
        ClientSize = New Size(578, 391)
        Controls.Add(Panel1)
        Controls.Add(SignupLink)
        Controls.Add(Button1)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Password)
        Controls.Add(Username)
        Controls.Add(Label6)
        Controls.Add(Label1)
        ForeColor = Color.Cornsilk
        FormBorderStyle = FormBorderStyle.None
        Name = "Login"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Savings and Loans"
        TopMost = True
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Username As TextBox
    Friend WithEvents Password As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents Label3 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents SignupLink As LinkLabel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label

End Class
