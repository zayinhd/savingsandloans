<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UserLoan
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
        Label1 = New Label()
        GroupBox1 = New GroupBox()
        LoanBalancee = New Label()
        Label6 = New Label()
        Label2 = New Label()
        RequestBtn = New Button()
        RequestedAmountt = New TextBox()
        PayLoanBtn = New Button()
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
        Panel3.SuspendLayout()
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
        Panel1.TabIndex = 43
        ' 
        ' History
        ' 
        History.AutoSize = True
        History.BackColor = Color.Teal
        History.Font = New Font("Segoe UI", 15F)
        History.ForeColor = Color.White
        History.Location = New Point(29, 307)
        History.Name = "History"
        History.Size = New Size(75, 28)
        History.TabIndex = 50
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
        LogoutBtn.TabIndex = 48
        LogoutBtn.Text = "Logout"
        ' 
        ' Withdraw
        ' 
        Withdraw.AutoSize = True
        Withdraw.BackColor = Color.Teal
        Withdraw.Font = New Font("Segoe UI", 15F)
        Withdraw.ForeColor = Color.White
        Withdraw.Location = New Point(29, 263)
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
        Loan.BackColor = Color.White
        Loan.Font = New Font("Segoe UI", 15F)
        Loan.ForeColor = Color.Teal
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
        Panel3.Controls.Add(Label1)
        Panel3.Controls.Add(Label8)
        Panel3.Dock = DockStyle.Top
        Panel3.Location = New Point(157, 0)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(643, 54)
        Panel3.TabIndex = 44
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
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(LoanBalancee)
        GroupBox1.Controls.Add(Label6)
        GroupBox1.Font = New Font("Segoe UI", 20F)
        GroupBox1.ForeColor = Color.Teal
        GroupBox1.Location = New Point(184, 122)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(594, 169)
        GroupBox1.TabIndex = 53
        GroupBox1.TabStop = False
        GroupBox1.Text = "I owe"
        ' 
        ' LoanBalancee
        ' 
        LoanBalancee.Anchor = AnchorStyles.None
        LoanBalancee.AutoSize = True
        LoanBalancee.BackColor = Color.Teal
        LoanBalancee.Font = New Font("Segoe UI", 30F)
        LoanBalancee.ForeColor = Color.White
        LoanBalancee.Location = New Point(305, 72)
        LoanBalancee.Name = "LoanBalancee"
        LoanBalancee.Size = New Size(98, 54)
        LoanBalancee.TabIndex = 51
        LoanBalancee.Text = "0.00"
        ' 
        ' Label6
        ' 
        Label6.Anchor = AnchorStyles.None
        Label6.AutoSize = True
        Label6.BackColor = Color.White
        Label6.Font = New Font("Segoe UI", 15F)
        Label6.ForeColor = Color.Teal
        Label6.Location = New Point(98, 88)
        Label6.Name = "Label6"
        Label6.Size = New Size(125, 28)
        Label6.TabIndex = 49
        Label6.Text = "Loan Balance"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 12F)
        Label2.ForeColor = Color.Teal
        Label2.Location = New Point(331, 336)
        Label2.Name = "Label2"
        Label2.Size = New Size(66, 21)
        Label2.TabIndex = 54
        Label2.Text = "Amount"
        ' 
        ' RequestBtn
        ' 
        RequestBtn.BackColor = Color.Teal
        RequestBtn.Location = New Point(417, 386)
        RequestBtn.Name = "RequestBtn"
        RequestBtn.Size = New Size(107, 37)
        RequestBtn.TabIndex = 56
        RequestBtn.Text = "Request Loan"
        RequestBtn.UseVisualStyleBackColor = False
        ' 
        ' RequestedAmountt
        ' 
        RequestedAmountt.ForeColor = Color.Teal
        RequestedAmountt.Location = New Point(463, 336)
        RequestedAmountt.Name = "RequestedAmountt"
        RequestedAmountt.Size = New Size(97, 23)
        RequestedAmountt.TabIndex = 55
        ' 
        ' PayLoanBtn
        ' 
        PayLoanBtn.BackColor = Color.Teal
        PayLoanBtn.Location = New Point(561, 386)
        PayLoanBtn.Name = "PayLoanBtn"
        PayLoanBtn.Size = New Size(107, 37)
        PayLoanBtn.TabIndex = 57
        PayLoanBtn.Text = "Pay Loan"
        PayLoanBtn.UseVisualStyleBackColor = False
        ' 
        ' UserLoan
        ' 
        AllowDrop = True
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(PayLoanBtn)
        Controls.Add(RequestBtn)
        Controls.Add(RequestedAmountt)
        Controls.Add(Label2)
        Controls.Add(GroupBox1)
        Controls.Add(Panel3)
        Controls.Add(Panel1)
        ForeColor = Color.White
        FormBorderStyle = FormBorderStyle.None
        Name = "UserLoan"
        StartPosition = FormStartPosition.CenterScreen
        Text = "UserLoan"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label8 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Transfers As Label
    Friend WithEvents Loan As Label
    Friend WithEvents Account As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents LoanBalancee As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Firstname As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents RequestBtn As Button
    Friend WithEvents RequestedAmountt As TextBox
    Friend WithEvents Withdraw As Label
    Friend WithEvents LogoutBtn As Label
    Friend WithEvents History As Label
    Friend WithEvents PayLoanBtn As Button
End Class
