<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UserWithdraw
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
        Amount = New TextBox()
        Label9 = New Label()
        WithdrawBtn = New Button()
        Label1 = New Label()
        Label4 = New Label()
        Withdraw = New Label()
        Transfers = New Label()
        Loan = New Label()
        Account = New Label()
        Panel2 = New Panel()
        Panel3 = New Panel()
        Label8 = New Label()
        Panel1 = New Panel()
        History = New Label()
        LogoutBtn = New Label()
        AccBalance = New Label()
        AccNumber = New Label()
        AccName = New Label()
        Label5 = New Label()
        Label2 = New Label()
        Label6 = New Label()
        DepositBtn = New Button()
        Panel2.SuspendLayout()
        Panel3.SuspendLayout()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Amount
        ' 
        Amount.ForeColor = Color.Teal
        Amount.Location = New Point(404, 319)
        Amount.Name = "Amount"
        Amount.Size = New Size(144, 23)
        Amount.TabIndex = 64
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Segoe UI", 12F)
        Label9.ForeColor = Color.Teal
        Label9.Location = New Point(320, 319)
        Label9.Name = "Label9"
        Label9.Size = New Size(66, 21)
        Label9.TabIndex = 63
        Label9.Text = "Amount"
        ' 
        ' WithdrawBtn
        ' 
        WithdrawBtn.BackColor = Color.Teal
        WithdrawBtn.Location = New Point(335, 370)
        WithdrawBtn.Name = "WithdrawBtn"
        WithdrawBtn.Size = New Size(107, 37)
        WithdrawBtn.TabIndex = 60
        WithdrawBtn.Text = "Withdraw"
        WithdrawBtn.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 15F)
        Label1.Location = New Point(35, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(51, 28)
        Label1.TabIndex = 41
        Label1.Text = "User"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.Teal
        Label4.Font = New Font("Segoe UI", 20F)
        Label4.ForeColor = Color.White
        Label4.Location = New Point(45, 9)
        Label4.Name = "Label4"
        Label4.Size = New Size(44, 37)
        Label4.TabIndex = 29
        Label4.Text = "SL"
        ' 
        ' Withdraw
        ' 
        Withdraw.AutoSize = True
        Withdraw.BackColor = Color.White
        Withdraw.Font = New Font("Segoe UI", 15F)
        Withdraw.ForeColor = Color.Teal
        Withdraw.Location = New Point(29, 266)
        Withdraw.Name = "Withdraw"
        Withdraw.Size = New Size(97, 28)
        Withdraw.TabIndex = 45
        Withdraw.Text = "Withdraw"
        ' 
        ' Transfers
        ' 
        Transfers.AutoSize = True
        Transfers.BackColor = Color.Teal
        Transfers.Font = New Font("Segoe UI", 15F)
        Transfers.ForeColor = Color.White
        Transfers.Location = New Point(29, 214)
        Transfers.Name = "Transfers"
        Transfers.Size = New Size(87, 28)
        Transfers.TabIndex = 44
        Transfers.Text = "Transfers"
        ' 
        ' Loan
        ' 
        Loan.AutoSize = True
        Loan.BackColor = Color.Teal
        Loan.Font = New Font("Segoe UI", 15F)
        Loan.ForeColor = Color.White
        Loan.Location = New Point(29, 159)
        Loan.Name = "Loan"
        Loan.Size = New Size(54, 28)
        Loan.TabIndex = 43
        Loan.Text = "Loan"
        ' 
        ' Account
        ' 
        Account.AutoSize = True
        Account.BackColor = Color.Teal
        Account.Font = New Font("Segoe UI", 15F)
        Account.ForeColor = Color.White
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
        ' Panel3
        ' 
        Panel3.BackColor = Color.Teal
        Panel3.Controls.Add(Label1)
        Panel3.Controls.Add(Label8)
        Panel3.Dock = DockStyle.Top
        Panel3.Location = New Point(157, 0)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(643, 54)
        Panel3.TabIndex = 59
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.BackColor = Color.Red
        Label8.Font = New Font("Segoe UI", 12F)
        Label8.Location = New Point(609, 9)
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
        Panel1.TabIndex = 58
        ' 
        ' History
        ' 
        History.AutoSize = True
        History.BackColor = Color.Teal
        History.Font = New Font("Segoe UI", 15F)
        History.ForeColor = Color.White
        History.Location = New Point(29, 314)
        History.Name = "History"
        History.Size = New Size(75, 28)
        History.TabIndex = 72
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
        LogoutBtn.TabIndex = 71
        LogoutBtn.Text = "Logout"
        ' 
        ' AccBalance
        ' 
        AccBalance.Anchor = AnchorStyles.None
        AccBalance.AutoSize = True
        AccBalance.BackColor = Color.Teal
        AccBalance.Font = New Font("Segoe UI", 30F)
        AccBalance.ForeColor = Color.White
        AccBalance.Location = New Point(427, 214)
        AccBalance.Name = "AccBalance"
        AccBalance.Size = New Size(221, 54)
        AccBalance.TabIndex = 70
        AccBalance.Text = "Ghc 260.00"
        ' 
        ' AccNumber
        ' 
        AccNumber.Anchor = AnchorStyles.None
        AccNumber.AutoSize = True
        AccNumber.BackColor = Color.Teal
        AccNumber.Font = New Font("Segoe UI", 15F)
        AccNumber.ForeColor = Color.White
        AccNumber.Location = New Point(427, 164)
        AccNumber.Name = "AccNumber"
        AccNumber.Size = New Size(133, 28)
        AccNumber.TabIndex = 69
        AccNumber.Text = "73476876838"
        ' 
        ' AccName
        ' 
        AccName.Anchor = AnchorStyles.None
        AccName.AutoSize = True
        AccName.BackColor = Color.Teal
        AccName.Font = New Font("Segoe UI", 15F)
        AccName.ForeColor = Color.White
        AccName.Location = New Point(427, 117)
        AccName.Name = "AccName"
        AccName.Size = New Size(95, 28)
        AccName.TabIndex = 67
        AccName.Text = "AccName"
        ' 
        ' Label5
        ' 
        Label5.Anchor = AnchorStyles.None
        Label5.AutoSize = True
        Label5.BackColor = Color.White
        Label5.Font = New Font("Segoe UI", 15F)
        Label5.ForeColor = Color.Teal
        Label5.Location = New Point(248, 214)
        Label5.Name = "Label5"
        Label5.Size = New Size(155, 28)
        Label5.TabIndex = 68
        Label5.Text = "Account Balance"
        ' 
        ' Label2
        ' 
        Label2.Anchor = AnchorStyles.None
        Label2.AutoSize = True
        Label2.BackColor = Color.White
        Label2.Font = New Font("Segoe UI", 15F)
        Label2.ForeColor = Color.Teal
        Label2.Location = New Point(248, 164)
        Label2.Name = "Label2"
        Label2.Size = New Size(161, 28)
        Label2.TabIndex = 66
        Label2.Text = "Account Number"
        ' 
        ' Label6
        ' 
        Label6.Anchor = AnchorStyles.None
        Label6.AutoSize = True
        Label6.BackColor = Color.White
        Label6.Font = New Font("Segoe UI", 15F)
        Label6.ForeColor = Color.Teal
        Label6.Location = New Point(248, 117)
        Label6.Name = "Label6"
        Label6.Size = New Size(141, 28)
        Label6.TabIndex = 65
        Label6.Text = "Account Name"
        ' 
        ' DepositBtn
        ' 
        DepositBtn.BackColor = Color.Teal
        DepositBtn.Location = New Point(473, 370)
        DepositBtn.Name = "DepositBtn"
        DepositBtn.Size = New Size(107, 37)
        DepositBtn.TabIndex = 72
        DepositBtn.Text = "Deposit"
        DepositBtn.UseVisualStyleBackColor = False
        ' 
        ' UserWithdraw
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(DepositBtn)
        Controls.Add(AccBalance)
        Controls.Add(AccNumber)
        Controls.Add(AccName)
        Controls.Add(Label5)
        Controls.Add(Label2)
        Controls.Add(Label6)
        Controls.Add(Amount)
        Controls.Add(Label9)
        Controls.Add(WithdrawBtn)
        Controls.Add(Panel3)
        Controls.Add(Panel1)
        ForeColor = Color.White
        FormBorderStyle = FormBorderStyle.None
        Name = "UserWithdraw"
        StartPosition = FormStartPosition.CenterScreen
        Text = "UserWithdraw"
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Amount As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents WithdrawBtn As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Withdraw As Label
    Friend WithEvents Transfers As Label
    Friend WithEvents Loan As Label
    Friend WithEvents Account As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label8 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents AccBalance As Label
    Friend WithEvents AccNumber As Label
    Friend WithEvents AccName As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents LogoutBtn As Label
    Friend WithEvents DepositBtn As Button
    Friend WithEvents History As Label
End Class
