<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UserTransfers
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
        TransferBtn = New Button()
        TAccountNumber = New TextBox()
        Label10 = New Label()
        TAmount = New TextBox()
        Label9 = New Label()
        TAccountName = New TextBox()
        Label2 = New Label()
        DateOfTransfer = New DateTimePicker()
        Label200 = New Label()
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
        Panel3.SuspendLayout()
        SuspendLayout()
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
        Panel1.TabIndex = 45
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
        LogoutBtn.TabIndex = 48
        LogoutBtn.Text = "Logout"
        ' 
        ' Withdraw
        ' 
        Withdraw.AutoSize = True
        Withdraw.BackColor = Color.Teal
        Withdraw.Font = New Font("Segoe UI", 15F)
        Withdraw.ForeColor = Color.White
        Withdraw.Location = New Point(29, 266)
        Withdraw.Name = "Withdraw"
        Withdraw.Size = New Size(97, 28)
        Withdraw.TabIndex = 45
        Withdraw.Text = "Withdraw"
        ' 
        ' Transfers
        ' 
        Transfers.AutoSize = True
        Transfers.BackColor = Color.White
        Transfers.Font = New Font("Segoe UI", 15F)
        Transfers.ForeColor = Color.Teal
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
        ' Panel3
        ' 
        Panel3.BackColor = Color.Teal
        Panel3.Controls.Add(Label1)
        Panel3.Controls.Add(Label8)
        Panel3.Dock = DockStyle.Top
        Panel3.Location = New Point(157, 0)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(643, 54)
        Panel3.TabIndex = 46
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
        ' TransferBtn
        ' 
        TransferBtn.BackColor = Color.Teal
        TransferBtn.Location = New Point(382, 283)
        TransferBtn.Name = "TransferBtn"
        TransferBtn.Size = New Size(107, 37)
        TransferBtn.TabIndex = 47
        TransferBtn.Text = "Transfer"
        TransferBtn.UseVisualStyleBackColor = False
        ' 
        ' TAccountNumber
        ' 
        TAccountNumber.ForeColor = Color.Teal
        TAccountNumber.Location = New Point(401, 148)
        TAccountNumber.Name = "TAccountNumber"
        TAccountNumber.Size = New Size(144, 23)
        TAccountNumber.TabIndex = 55
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Segoe UI", 12F)
        Label10.ForeColor = Color.Teal
        Label10.Location = New Point(243, 148)
        Label10.Name = "Label10"
        Label10.Size = New Size(128, 21)
        Label10.TabIndex = 54
        Label10.Text = "Account Number"
        ' 
        ' TAmount
        ' 
        TAmount.ForeColor = Color.Teal
        TAmount.Location = New Point(401, 186)
        TAmount.Name = "TAmount"
        TAmount.Size = New Size(144, 23)
        TAmount.TabIndex = 53
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Segoe UI", 12F)
        Label9.ForeColor = Color.Teal
        Label9.Location = New Point(243, 186)
        Label9.Name = "Label9"
        Label9.Size = New Size(66, 21)
        Label9.TabIndex = 52
        Label9.Text = "Amount"
        ' 
        ' TAccountName
        ' 
        TAccountName.ForeColor = Color.Teal
        TAccountName.Location = New Point(401, 105)
        TAccountName.Name = "TAccountName"
        TAccountName.Size = New Size(144, 23)
        TAccountName.TabIndex = 50
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 12F)
        Label2.ForeColor = Color.Teal
        Label2.Location = New Point(243, 105)
        Label2.Name = "Label2"
        Label2.Size = New Size(112, 21)
        Label2.TabIndex = 48
        Label2.Text = "Account Name"
        ' 
        ' DateOfTransfer
        ' 
        DateOfTransfer.Cursor = Cursors.No
        DateOfTransfer.Location = New Point(401, 226)
        DateOfTransfer.Name = "DateOfTransfer"
        DateOfTransfer.Size = New Size(144, 23)
        DateOfTransfer.TabIndex = 57
        ' 
        ' Label200
        ' 
        Label200.AutoSize = True
        Label200.Cursor = Cursors.No
        Label200.Font = New Font("Segoe UI", 12F)
        Label200.ForeColor = Color.Teal
        Label200.Location = New Point(243, 228)
        Label200.Name = "Label200"
        Label200.Size = New Size(123, 21)
        Label200.TabIndex = 56
        Label200.Text = "Date Of Transfer"
        ' 
        ' UserTransfers
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(DateOfTransfer)
        Controls.Add(Label200)
        Controls.Add(TAccountNumber)
        Controls.Add(Label10)
        Controls.Add(TAmount)
        Controls.Add(Label9)
        Controls.Add(TAccountName)
        Controls.Add(Label2)
        Controls.Add(TransferBtn)
        Controls.Add(Panel3)
        Controls.Add(Panel1)
        ForeColor = Color.White
        FormBorderStyle = FormBorderStyle.None
        Name = "UserTransfers"
        StartPosition = FormStartPosition.CenterScreen
        Text = "UserTransfers"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
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
    Friend WithEvents TransferBtn As Button
    Friend WithEvents TAccountNumber As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents TAmount As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents TAccountName As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents DateOfTransfer As DateTimePicker
    Friend WithEvents Label200 As Label
    Friend WithEvents Withdraw As Label
    Friend WithEvents LogoutBtn As Label
    Friend WithEvents History As Label
End Class
