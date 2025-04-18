<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class User
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Label8 = New Label()
        Panel1 = New Panel()
        History = New Label()
        LogoutBtn = New Label()
        Withdraw = New Label()
        Transfers = New Label()
        Loan = New Label()
        Account = New Label()
        Panel2 = New Panel()
        Label4 = New Label()
        Panel3 = New Panel()
        WelcomeMsg = New Label()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        PictureBox1 = New PictureBox()
        Label5 = New Label()
        AccName = New Label()
        AccNumber = New Label()
        AccBalance = New Label()
        OpenFileDialog1 = New OpenFileDialog()
        Label6 = New Label()
        LoanBalancee = New Label()
        GroupBox1 = New GroupBox()
        Label7 = New Label()
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
        Panel3.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.BackColor = Color.Red
        Label8.Font = New Font("Segoe UI", 12F)
        Label8.Location = New Point(612, 9)
        Label8.Name = "Label8"
        Label8.Size = New Size(19, 21)
        Label8.TabIndex = 40
        Label8.Text = "X"
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.Teal
        Panel1.Controls.Add(History)
        Panel1.Controls.Add(LogoutBtn)
        Panel1.Controls.Add(Withdraw)
        Panel1.Controls.Add(Transfers)
        Panel1.Controls.Add(Loan)
        Panel1.Controls.Add(Account)
        Panel1.Controls.Add(Panel2)
        Panel1.Dock = DockStyle.Left
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(157, 450)
        Panel1.TabIndex = 41
        ' 
        ' History
        ' 
        History.AutoSize = True
        History.BackColor = Color.Teal
        History.Font = New Font("Segoe UI", 15F)
        History.ForeColor = Color.White
        History.Location = New Point(29, 305)
        History.Name = "History"
        History.Size = New Size(75, 28)
        History.TabIndex = 51
        History.Text = "History"
        ' 
        ' LogoutBtn
        ' 
        LogoutBtn.Anchor = AnchorStyles.None
        LogoutBtn.AutoSize = True
        LogoutBtn.BackColor = Color.White
        LogoutBtn.Font = New Font("Segoe UI", 15F)
        LogoutBtn.ForeColor = Color.Teal
        LogoutBtn.Location = New Point(29, 402)
        LogoutBtn.Name = "LogoutBtn"
        LogoutBtn.Size = New Size(75, 28)
        LogoutBtn.TabIndex = 47
        LogoutBtn.Text = "Logout"
        ' 
        ' Withdraw
        ' 
        Withdraw.AutoSize = True
        Withdraw.BackColor = Color.Teal
        Withdraw.Font = New Font("Segoe UI", 15F)
        Withdraw.ForeColor = Color.White
        Withdraw.Location = New Point(29, 261)
        Withdraw.Name = "Withdraw"
        Withdraw.Size = New Size(97, 28)
        Withdraw.TabIndex = 46
        Withdraw.Text = "Withdraw"
        ' 
        ' Transfers
        ' 
        Transfers.AutoSize = True
        Transfers.Font = New Font("Segoe UI", 15F)
        Transfers.Location = New Point(29, 214)
        Transfers.Name = "Transfers"
        Transfers.Size = New Size(87, 28)
        Transfers.TabIndex = 44
        Transfers.Text = "Transfers"
        ' 
        ' Loan
        ' 
        Loan.AutoSize = True
        Loan.Font = New Font("Segoe UI", 15F)
        Loan.Location = New Point(29, 159)
        Loan.Name = "Loan"
        Loan.Size = New Size(54, 28)
        Loan.TabIndex = 43
        Loan.Text = "Loan"
        ' 
        ' Account
        ' 
        Account.Anchor = AnchorStyles.None
        Account.AutoSize = True
        Account.BackColor = Color.White
        Account.Font = New Font("Segoe UI", 15F)
        Account.ForeColor = Color.Teal
        Account.Location = New Point(29, 105)
        Account.Name = "Account"
        Account.Size = New Size(84, 28)
        Account.TabIndex = 42
        Account.Text = "Account"
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.SteelBlue
        Panel2.Controls.Add(Label4)
        Panel2.Dock = DockStyle.Top
        Panel2.Location = New Point(0, 0)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(157, 54)
        Panel2.TabIndex = 42
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.Teal
        Label4.Font = New Font("Segoe UI", 20F)
        Label4.ForeColor = Color.White
        Label4.Location = New Point(48, 9)
        Label4.Name = "Label4"
        Label4.Size = New Size(44, 37)
        Label4.TabIndex = 29
        Label4.Text = "SL"
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = Color.Teal
        Panel3.Controls.Add(WelcomeMsg)
        Panel3.Controls.Add(Label1)
        Panel3.Controls.Add(Label8)
        Panel3.Dock = DockStyle.Top
        Panel3.Location = New Point(157, 0)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(643, 54)
        Panel3.TabIndex = 42
        ' 
        ' WelcomeMsg
        ' 
        WelcomeMsg.Anchor = AnchorStyles.None
        WelcomeMsg.AutoSize = True
        WelcomeMsg.BackColor = Color.White
        WelcomeMsg.Font = New Font("Segoe UI", 15F)
        WelcomeMsg.ForeColor = Color.Teal
        WelcomeMsg.Location = New Point(217, 9)
        WelcomeMsg.Name = "WelcomeMsg"
        WelcomeMsg.Size = New Size(93, 28)
        WelcomeMsg.TabIndex = 48
        WelcomeMsg.Text = "Welcome"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 15F)
        Label1.Location = New Point(38, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(51, 28)
        Label1.TabIndex = 41
        Label1.Text = "User"
        ' 
        ' Label2
        ' 
        Label2.Anchor = AnchorStyles.None
        Label2.AutoSize = True
        Label2.BackColor = Color.White
        Label2.Font = New Font("Segoe UI", 15F)
        Label2.ForeColor = Color.Teal
        Label2.Location = New Point(195, 82)
        Label2.Name = "Label2"
        Label2.Size = New Size(141, 28)
        Label2.TabIndex = 43
        Label2.Text = "Account Name"
        ' 
        ' Label3
        ' 
        Label3.Anchor = AnchorStyles.None
        Label3.AutoSize = True
        Label3.BackColor = Color.White
        Label3.Font = New Font("Segoe UI", 15F)
        Label3.ForeColor = Color.Teal
        Label3.Location = New Point(195, 129)
        Label3.Name = "Label3"
        Label3.Size = New Size(161, 28)
        Label3.TabIndex = 44
        Label3.Text = "Account Number"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = Color.Teal
        PictureBox1.BorderStyle = BorderStyle.FixedSingle
        PictureBox1.Location = New Point(621, 82)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(153, 105)
        PictureBox1.TabIndex = 45
        PictureBox1.TabStop = False
        ' 
        ' Label5
        ' 
        Label5.Anchor = AnchorStyles.None
        Label5.AutoSize = True
        Label5.BackColor = Color.White
        Label5.Font = New Font("Segoe UI", 15F)
        Label5.ForeColor = Color.Teal
        Label5.Location = New Point(195, 179)
        Label5.Name = "Label5"
        Label5.Size = New Size(155, 28)
        Label5.TabIndex = 46
        Label5.Text = "Account Balance"
        ' 
        ' AccName
        ' 
        AccName.Anchor = AnchorStyles.None
        AccName.AutoSize = True
        AccName.BackColor = Color.Teal
        AccName.Font = New Font("Segoe UI", 15F)
        AccName.ForeColor = Color.White
        AccName.Location = New Point(374, 82)
        AccName.Name = "AccName"
        AccName.Size = New Size(95, 28)
        AccName.TabIndex = 45
        AccName.Text = "AccName"
        ' 
        ' AccNumber
        ' 
        AccNumber.Anchor = AnchorStyles.None
        AccNumber.AutoSize = True
        AccNumber.BackColor = Color.Teal
        AccNumber.Font = New Font("Segoe UI", 15F)
        AccNumber.ForeColor = Color.White
        AccNumber.Location = New Point(374, 129)
        AccNumber.Name = "AccNumber"
        AccNumber.Size = New Size(133, 28)
        AccNumber.TabIndex = 47
        AccNumber.Text = "73476876838"
        ' 
        ' AccBalance
        ' 
        AccBalance.Anchor = AnchorStyles.None
        AccBalance.AutoSize = True
        AccBalance.BackColor = Color.Teal
        AccBalance.Font = New Font("Segoe UI", 24F)
        AccBalance.ForeColor = Color.White
        AccBalance.Location = New Point(425, 173)
        AccBalance.Name = "AccBalance"
        AccBalance.Size = New Size(112, 45)
        AccBalance.TabIndex = 48
        AccBalance.Text = "260.00"
        ' 
        ' OpenFileDialog1
        ' 
        OpenFileDialog1.FileName = "OpenFileDialog1"
        ' 
        ' Label6
        ' 
        Label6.Anchor = AnchorStyles.None
        Label6.AutoSize = True
        Label6.BackColor = Color.White
        Label6.Font = New Font("Segoe UI", 15F)
        Label6.ForeColor = Color.Teal
        Label6.Location = New Point(13, 74)
        Label6.Name = "Label6"
        Label6.Size = New Size(125, 28)
        Label6.TabIndex = 49
        Label6.Text = "Loan Balance"
        ' 
        ' LoanBalancee
        ' 
        LoanBalancee.Anchor = AnchorStyles.None
        LoanBalancee.AutoSize = True
        LoanBalancee.BackColor = Color.Teal
        LoanBalancee.Font = New Font("Segoe UI", 30F)
        LoanBalancee.ForeColor = Color.White
        LoanBalancee.Location = New Point(192, 54)
        LoanBalancee.Name = "LoanBalancee"
        LoanBalancee.Size = New Size(98, 54)
        LoanBalancee.TabIndex = 51
        LoanBalancee.Text = "0.00"
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(LoanBalancee)
        GroupBox1.Controls.Add(Label6)
        GroupBox1.Font = New Font("Segoe UI", 20F)
        GroupBox1.ForeColor = Color.Teal
        GroupBox1.Location = New Point(182, 261)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(594, 169)
        GroupBox1.TabIndex = 52
        GroupBox1.TabStop = False
        GroupBox1.Text = "I owe"
        ' 
        ' Label7
        ' 
        Label7.Anchor = AnchorStyles.None
        Label7.AutoSize = True
        Label7.BackColor = Color.Teal
        Label7.Font = New Font("Segoe UI", 20F)
        Label7.ForeColor = Color.White
        Label7.Location = New Point(356, 179)
        Label7.Name = "Label7"
        Label7.Size = New Size(63, 37)
        Label7.TabIndex = 53
        Label7.Text = "Ghc"
        ' 
        ' User
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(800, 450)
        Controls.Add(Label7)
        Controls.Add(GroupBox1)
        Controls.Add(AccBalance)
        Controls.Add(AccNumber)
        Controls.Add(AccName)
        Controls.Add(Label5)
        Controls.Add(PictureBox1)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Panel3)
        Controls.Add(Panel1)
        ForeColor = Color.White
        FormBorderStyle = FormBorderStyle.None
        Name = "User"
        StartPosition = FormStartPosition.CenterScreen
        Text = "User"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label8 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Transfers As Label
    Friend WithEvents Loan As Label
    Friend WithEvents Account As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label5 As Label
    Friend WithEvents AccName As Label
    Friend WithEvents AccNumber As Label
    Friend WithEvents AccBalance As Label
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents Label6 As Label
    Friend WithEvents LoanBalancee As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Withdraw As Label
    Friend WithEvents LogoutBtn As Label
    Friend WithEvents WelcomeMsg As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents History As Label
End Class
