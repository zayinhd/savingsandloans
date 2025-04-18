<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UserHistory
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
        LogoutBtn = New Label()
        Withdraw = New Label()
        Transfers = New Label()
        Loan = New Label()
        Account = New Label()
        Panel2 = New Panel()
        Label4 = New Label()
        Panel3 = New Panel()
        Label1 = New Label()
        Label8 = New Label()
        Panel1 = New Panel()
        LogOut = New Label()
        History = New Label()
        SearchBtn = New Button()
        ClearAllBtn = New Button()
        HistoryGrid = New DataGridView()
        DeleteBtn = New Button()
        SearchBox = New TextBox()
        LoanHistoryGrid = New DataGridView()
        Label2 = New Label()
        Panel2.SuspendLayout()
        Panel3.SuspendLayout()
        Panel1.SuspendLayout()
        CType(HistoryGrid, ComponentModel.ISupportInitialize).BeginInit()
        CType(LoanHistoryGrid, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' LogoutBtn
        ' 
        LogoutBtn.Anchor = AnchorStyles.None
        LogoutBtn.AutoSize = True
        LogoutBtn.BackColor = Color.White
        LogoutBtn.Font = New Font("Segoe UI", 15F)
        LogoutBtn.ForeColor = Color.Teal
        LogoutBtn.Location = New Point(7, 577)
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
        Withdraw.Location = New Point(29, 247)
        Withdraw.Name = "Withdraw"
        Withdraw.Size = New Size(97, 28)
        Withdraw.TabIndex = 46
        Withdraw.Text = "Withdraw"
        ' 
        ' Transfers
        ' 
        Transfers.AutoSize = True
        Transfers.Font = New Font("Segoe UI", 15F)
        Transfers.Location = New Point(29, 198)
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
        Loan.Location = New Point(29, 152)
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
        Panel3.TabIndex = 58
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 15F)
        Label1.Location = New Point(38, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(75, 28)
        Label1.TabIndex = 41
        Label1.Text = "History"
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
        Panel1.Controls.Add(LogOut)
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
        Panel1.TabIndex = 57
        ' 
        ' LogOut
        ' 
        LogOut.Anchor = AnchorStyles.None
        LogOut.AutoSize = True
        LogOut.BackColor = Color.White
        LogOut.Font = New Font("Segoe UI", 15F)
        LogOut.ForeColor = Color.Teal
        LogOut.Location = New Point(29, 413)
        LogOut.Name = "LogOut"
        LogOut.Size = New Size(75, 28)
        LogOut.TabIndex = 50
        LogOut.Text = "Logout"
        ' 
        ' History
        ' 
        History.AutoSize = True
        History.BackColor = Color.White
        History.Font = New Font("Segoe UI", 15F)
        History.ForeColor = Color.Teal
        History.Location = New Point(29, 293)
        History.Name = "History"
        History.Size = New Size(75, 28)
        History.TabIndex = 49
        History.Text = "History"
        ' 
        ' SearchBtn
        ' 
        SearchBtn.BackColor = Color.Teal
        SearchBtn.Location = New Point(270, 105)
        SearchBtn.Name = "SearchBtn"
        SearchBtn.Size = New Size(107, 37)
        SearchBtn.TabIndex = 86
        SearchBtn.Text = "Search"
        SearchBtn.UseVisualStyleBackColor = False
        ' 
        ' ClearAllBtn
        ' 
        ClearAllBtn.BackColor = Color.Red
        ClearAllBtn.Location = New Point(590, 105)
        ClearAllBtn.Name = "ClearAllBtn"
        ClearAllBtn.Size = New Size(107, 37)
        ClearAllBtn.TabIndex = 85
        ClearAllBtn.Text = "ClearAll"
        ClearAllBtn.UseVisualStyleBackColor = False
        ' 
        ' HistoryGrid
        ' 
        HistoryGrid.BackgroundColor = Color.White
        HistoryGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        HistoryGrid.Location = New Point(258, 163)
        HistoryGrid.Name = "HistoryGrid"
        HistoryGrid.Size = New Size(459, 112)
        HistoryGrid.TabIndex = 84
        ' 
        ' DeleteBtn
        ' 
        DeleteBtn.BackColor = Color.FromArgb(CByte(192), CByte(0), CByte(0))
        DeleteBtn.Location = New Point(433, 105)
        DeleteBtn.Name = "DeleteBtn"
        DeleteBtn.Size = New Size(107, 37)
        DeleteBtn.TabIndex = 87
        DeleteBtn.Text = "Delete"
        DeleteBtn.UseVisualStyleBackColor = False
        ' 
        ' SearchBox
        ' 
        SearchBox.Location = New Point(312, 76)
        SearchBox.Name = "SearchBox"
        SearchBox.Size = New Size(342, 23)
        SearchBox.TabIndex = 88
        ' 
        ' LoanHistoryGrid
        ' 
        LoanHistoryGrid.BackgroundColor = Color.White
        LoanHistoryGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        LoanHistoryGrid.Location = New Point(258, 329)
        LoanHistoryGrid.Name = "LoanHistoryGrid"
        LoanHistoryGrid.Size = New Size(459, 112)
        LoanHistoryGrid.TabIndex = 89
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Teal
        Label2.Font = New Font("Segoe UI", 15F)
        Label2.ForeColor = Color.White
        Label2.Location = New Point(433, 293)
        Label2.Name = "Label2"
        Label2.Size = New Size(117, 28)
        Label2.TabIndex = 51
        Label2.Text = "LoanHistory"
        ' 
        ' UserHistory
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Label2)
        Controls.Add(LoanHistoryGrid)
        Controls.Add(SearchBox)
        Controls.Add(DeleteBtn)
        Controls.Add(SearchBtn)
        Controls.Add(ClearAllBtn)
        Controls.Add(HistoryGrid)
        Controls.Add(Panel3)
        Controls.Add(Panel1)
        ForeColor = Color.White
        FormBorderStyle = FormBorderStyle.None
        Name = "UserHistory"
        StartPosition = FormStartPosition.CenterScreen
        Text = "UserHistory"
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(HistoryGrid, ComponentModel.ISupportInitialize).EndInit()
        CType(LoanHistoryGrid, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents LogoutBtn As Label
    Friend WithEvents Withdraw As Label
    Friend WithEvents Transfers As Label
    Friend WithEvents Loan As Label
    Friend WithEvents Account As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents History As Label
    Friend WithEvents LogOut As Label
    Friend WithEvents SearchBtn As Button
    Friend WithEvents ClearAllBtn As Button
    Friend WithEvents HistoryGrid As DataGridView
    Friend WithEvents DeleteBtn As Button
    Friend WithEvents SearchBox As TextBox
    Friend WithEvents LoanHistoryGrid As DataGridView
    Friend WithEvents Label2 As Label
End Class
