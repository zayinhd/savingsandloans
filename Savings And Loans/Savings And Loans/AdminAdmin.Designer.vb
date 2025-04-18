<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AdminAdmin
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
        Loans = New Label()
        Label4 = New Label()
        Label8 = New Label()
        Panel1 = New Panel()
        Transactions = New Label()
        LogoutBtn = New Label()
        Admins = New Label()
        Users = New Label()
        Panel3 = New Panel()
        Label7 = New Label()
        Label1 = New Label()
        Panel2 = New Panel()
        BackgroundWorker1 = New ComponentModel.BackgroundWorker()
        AdminGrid = New DataGridView()
        DateOfBirth = New DateTimePicker()
        Role = New ComboBox()
        SearchBtn = New Button()
        Id = New TextBox()
        Label16 = New Label()
        Label17 = New Label()
        Label18 = New Label()
        FullName = New TextBox()
        Label14 = New Label()
        AccountNumber = New TextBox()
        Label13 = New Label()
        AccountName = New TextBox()
        Label12 = New Label()
        Password = New TextBox()
        Label11 = New Label()
        Email = New TextBox()
        Label10 = New Label()
        Username = New TextBox()
        Label9 = New Label()
        LastName = New TextBox()
        Label6 = New Label()
        FirstName = New TextBox()
        Label5 = New Label()
        EditBtn = New Button()
        DeleteBtn = New Button()
        SaveBtn = New Button()
        AddBtn = New Button()
        Panel1.SuspendLayout()
        Panel3.SuspendLayout()
        Panel2.SuspendLayout()
        CType(AdminGrid, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Loans
        ' 
        Loans.AutoSize = True
        Loans.BackColor = Color.Teal
        Loans.Font = New Font("Segoe UI", 15F)
        Loans.ForeColor = Color.White
        Loans.Location = New Point(29, 174)
        Loans.Name = "Loans"
        Loans.Size = New Size(62, 28)
        Loans.TabIndex = 44
        Loans.Text = "Loans"
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
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.BackColor = Color.Red
        Label8.Font = New Font("Segoe UI", 12F)
        Label8.Location = New Point(769, 9)
        Label8.Name = "Label8"
        Label8.Size = New Size(19, 21)
        Label8.TabIndex = 40
        Label8.Text = "X"
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.Teal
        Panel1.Controls.Add(Transactions)
        Panel1.Controls.Add(LogoutBtn)
        Panel1.Controls.Add(Loans)
        Panel1.Controls.Add(Admins)
        Panel1.Controls.Add(Users)
        Panel1.Location = New Point(0, 55)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(157, 395)
        Panel1.TabIndex = 49
        ' 
        ' Transactions
        ' 
        Transactions.AutoSize = True
        Transactions.BackColor = Color.Teal
        Transactions.Font = New Font("Segoe UI", 15F)
        Transactions.ForeColor = Color.White
        Transactions.Location = New Point(29, 216)
        Transactions.Name = "Transactions"
        Transactions.Size = New Size(118, 28)
        Transactions.TabIndex = 74
        Transactions.Text = "Transactions"
        ' 
        ' LogoutBtn
        ' 
        LogoutBtn.Anchor = AnchorStyles.None
        LogoutBtn.AutoSize = True
        LogoutBtn.BackColor = Color.White
        LogoutBtn.Font = New Font("Segoe UI", 15F)
        LogoutBtn.ForeColor = Color.Teal
        LogoutBtn.Location = New Point(29, 355)
        LogoutBtn.Name = "LogoutBtn"
        LogoutBtn.Size = New Size(75, 28)
        LogoutBtn.TabIndex = 72
        LogoutBtn.Text = "Logout"
        ' 
        ' Admins
        ' 
        Admins.AutoSize = True
        Admins.BackColor = Color.White
        Admins.Font = New Font("Segoe UI", 15F)
        Admins.ForeColor = Color.Teal
        Admins.Location = New Point(29, 117)
        Admins.Name = "Admins"
        Admins.Size = New Size(78, 28)
        Admins.TabIndex = 43
        Admins.Text = "Admins"
        ' 
        ' Users
        ' 
        Users.AutoSize = True
        Users.BackColor = Color.Teal
        Users.Font = New Font("Segoe UI", 15F)
        Users.ForeColor = Color.White
        Users.Location = New Point(29, 61)
        Users.Name = "Users"
        Users.Size = New Size(59, 28)
        Users.TabIndex = 42
        Users.Text = "Users"
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = Color.Teal
        Panel3.Controls.Add(Label7)
        Panel3.Controls.Add(Label1)
        Panel3.Controls.Add(Label8)
        Panel3.Location = New Point(157, 0)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(643, 54)
        Panel3.TabIndex = 50
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.BackColor = Color.Red
        Label7.Font = New Font("Segoe UI", 12F)
        Label7.Location = New Point(612, 9)
        Label7.Name = "Label7"
        Label7.Size = New Size(19, 21)
        Label7.TabIndex = 42
        Label7.Text = "X"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 15F)
        Label1.Location = New Point(36, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(154, 28)
        Label1.TabIndex = 41
        Label1.Text = "Admin - Admins"
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.SteelBlue
        Panel2.Controls.Add(Label4)
        Panel2.Dock = DockStyle.Top
        Panel2.ForeColor = Color.White
        Panel2.Location = New Point(0, 0)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(800, 54)
        Panel2.TabIndex = 48
        ' 
        ' AdminGrid
        ' 
        AdminGrid.BackgroundColor = Color.White
        AdminGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        AdminGrid.Location = New Point(217, 292)
        AdminGrid.Name = "AdminGrid"
        AdminGrid.Size = New Size(539, 146)
        AdminGrid.TabIndex = 52
        ' 
        ' DateOfBirth
        ' 
        DateOfBirth.Location = New Point(654, 164)
        DateOfBirth.Name = "DateOfBirth"
        DateOfBirth.Size = New Size(102, 23)
        DateOfBirth.TabIndex = 113
        ' 
        ' Role
        ' 
        Role.FormattingEnabled = True
        Role.Location = New Point(654, 130)
        Role.Name = "Role"
        Role.Size = New Size(102, 23)
        Role.TabIndex = 112
        ' 
        ' SearchBtn
        ' 
        SearchBtn.BackColor = Color.Teal
        SearchBtn.Location = New Point(551, 69)
        SearchBtn.Name = "SearchBtn"
        SearchBtn.Size = New Size(107, 37)
        SearchBtn.TabIndex = 111
        SearchBtn.Text = "Search"
        SearchBtn.UseVisualStyleBackColor = False
        ' 
        ' Id
        ' 
        Id.ForeColor = Color.Teal
        Id.Location = New Point(654, 206)
        Id.Name = "Id"
        Id.Size = New Size(102, 23)
        Id.TabIndex = 110
        ' 
        ' Label16
        ' 
        Label16.AutoSize = True
        Label16.Font = New Font("Segoe UI", 8F)
        Label16.ForeColor = Color.Teal
        Label16.Location = New Point(587, 210)
        Label16.Name = "Label16"
        Label16.Size = New Size(21, 13)
        Label16.TabIndex = 109
        Label16.Text = "I.D"
        ' 
        ' Label17
        ' 
        Label17.AutoSize = True
        Label17.Font = New Font("Segoe UI", 8F)
        Label17.ForeColor = Color.Teal
        Label17.Location = New Point(587, 171)
        Label17.Name = "Label17"
        Label17.Size = New Size(54, 13)
        Label17.TabIndex = 108
        Label17.Text = "D.O.Birth"
        ' 
        ' Label18
        ' 
        Label18.AutoSize = True
        Label18.Font = New Font("Segoe UI", 8F)
        Label18.ForeColor = Color.Teal
        Label18.Location = New Point(587, 134)
        Label18.Name = "Label18"
        Label18.Size = New Size(30, 13)
        Label18.TabIndex = 107
        Label18.Text = "Role"
        ' 
        ' FullName
        ' 
        FullName.ForeColor = Color.Teal
        FullName.Location = New Point(457, 246)
        FullName.Name = "FullName"
        FullName.Size = New Size(102, 23)
        FullName.TabIndex = 106
        ' 
        ' Label14
        ' 
        Label14.AutoSize = True
        Label14.Font = New Font("Segoe UI", 8F)
        Label14.ForeColor = Color.Teal
        Label14.Location = New Point(390, 250)
        Label14.Name = "Label14"
        Label14.Size = New Size(58, 13)
        Label14.TabIndex = 105
        Label14.Text = "Full Name"
        ' 
        ' AccountNumber
        ' 
        AccountNumber.ForeColor = Color.Teal
        AccountNumber.Location = New Point(457, 206)
        AccountNumber.Name = "AccountNumber"
        AccountNumber.Size = New Size(102, 23)
        AccountNumber.TabIndex = 104
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.Font = New Font("Segoe UI", 8F)
        Label13.ForeColor = Color.Teal
        Label13.Location = New Point(390, 210)
        Label13.Name = "Label13"
        Label13.Size = New Size(71, 13)
        Label13.TabIndex = 103
        Label13.Text = "Acc. Number"
        ' 
        ' AccountName
        ' 
        AccountName.ForeColor = Color.Teal
        AccountName.Location = New Point(457, 167)
        AccountName.Name = "AccountName"
        AccountName.Size = New Size(102, 23)
        AccountName.TabIndex = 102
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Font = New Font("Segoe UI", 8F)
        Label12.ForeColor = Color.Teal
        Label12.Location = New Point(390, 171)
        Label12.Name = "Label12"
        Label12.Size = New Size(59, 13)
        Label12.TabIndex = 101
        Label12.Text = "Acc. Name"
        ' 
        ' Password
        ' 
        Password.ForeColor = Color.Teal
        Password.Location = New Point(457, 130)
        Password.Name = "Password"
        Password.Size = New Size(102, 23)
        Password.TabIndex = 100
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Font = New Font("Segoe UI", 8F)
        Label11.ForeColor = Color.Teal
        Label11.Location = New Point(390, 134)
        Label11.Name = "Label11"
        Label11.Size = New Size(56, 13)
        Label11.TabIndex = 99
        Label11.Text = "Password"
        ' 
        ' Email
        ' 
        Email.ForeColor = Color.Teal
        Email.Location = New Point(255, 246)
        Email.Name = "Email"
        Email.Size = New Size(102, 23)
        Email.TabIndex = 98
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Segoe UI", 8F)
        Label10.ForeColor = Color.Teal
        Label10.Location = New Point(188, 250)
        Label10.Name = "Label10"
        Label10.Size = New Size(34, 13)
        Label10.TabIndex = 97
        Label10.Text = "Email"
        ' 
        ' Username
        ' 
        Username.ForeColor = Color.Teal
        Username.Location = New Point(255, 206)
        Username.Name = "Username"
        Username.Size = New Size(102, 23)
        Username.TabIndex = 96
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Segoe UI", 8F)
        Label9.ForeColor = Color.Teal
        Label9.Location = New Point(188, 210)
        Label9.Name = "Label9"
        Label9.Size = New Size(58, 13)
        Label9.TabIndex = 95
        Label9.Text = "Username"
        ' 
        ' LastName
        ' 
        LastName.ForeColor = Color.Teal
        LastName.Location = New Point(255, 167)
        LastName.Name = "LastName"
        LastName.Size = New Size(102, 23)
        LastName.TabIndex = 94
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 8F)
        Label6.ForeColor = Color.Teal
        Label6.Location = New Point(188, 171)
        Label6.Name = "Label6"
        Label6.Size = New Size(59, 13)
        Label6.TabIndex = 93
        Label6.Text = "Last Name"
        ' 
        ' FirstName
        ' 
        FirstName.ForeColor = Color.Teal
        FirstName.Location = New Point(255, 130)
        FirstName.Name = "FirstName"
        FirstName.Size = New Size(102, 23)
        FirstName.TabIndex = 92
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 8F)
        Label5.ForeColor = Color.Teal
        Label5.Location = New Point(188, 134)
        Label5.Name = "Label5"
        Label5.Size = New Size(61, 13)
        Label5.TabIndex = 91
        Label5.Text = "First Name"
        ' 
        ' EditBtn
        ' 
        EditBtn.BackColor = Color.Teal
        EditBtn.Location = New Point(311, 69)
        EditBtn.Name = "EditBtn"
        EditBtn.Size = New Size(107, 37)
        EditBtn.TabIndex = 90
        EditBtn.Text = "Edit"
        EditBtn.UseVisualStyleBackColor = False
        ' 
        ' DeleteBtn
        ' 
        DeleteBtn.BackColor = Color.Red
        DeleteBtn.Location = New Point(676, 69)
        DeleteBtn.Name = "DeleteBtn"
        DeleteBtn.Size = New Size(107, 37)
        DeleteBtn.TabIndex = 89
        DeleteBtn.Text = "Delete"
        DeleteBtn.UseVisualStyleBackColor = False
        ' 
        ' SaveBtn
        ' 
        SaveBtn.BackColor = Color.Teal
        SaveBtn.Location = New Point(433, 69)
        SaveBtn.Name = "SaveBtn"
        SaveBtn.Size = New Size(107, 37)
        SaveBtn.TabIndex = 88
        SaveBtn.Text = "Save"
        SaveBtn.UseVisualStyleBackColor = False
        ' 
        ' AddBtn
        ' 
        AddBtn.BackColor = Color.Teal
        AddBtn.Location = New Point(188, 69)
        AddBtn.Name = "AddBtn"
        AddBtn.Size = New Size(107, 37)
        AddBtn.TabIndex = 87
        AddBtn.Text = "Add"
        AddBtn.UseVisualStyleBackColor = False
        ' 
        ' AdminAdmin
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(DateOfBirth)
        Controls.Add(Role)
        Controls.Add(SearchBtn)
        Controls.Add(Id)
        Controls.Add(Label16)
        Controls.Add(Label17)
        Controls.Add(Label18)
        Controls.Add(FullName)
        Controls.Add(Label14)
        Controls.Add(AccountNumber)
        Controls.Add(Label13)
        Controls.Add(AccountName)
        Controls.Add(Label12)
        Controls.Add(Password)
        Controls.Add(Label11)
        Controls.Add(Email)
        Controls.Add(Label10)
        Controls.Add(Username)
        Controls.Add(Label9)
        Controls.Add(LastName)
        Controls.Add(Label6)
        Controls.Add(FirstName)
        Controls.Add(Label5)
        Controls.Add(EditBtn)
        Controls.Add(DeleteBtn)
        Controls.Add(SaveBtn)
        Controls.Add(AddBtn)
        Controls.Add(AdminGrid)
        Controls.Add(Panel1)
        Controls.Add(Panel3)
        Controls.Add(Panel2)
        ForeColor = Color.White
        FormBorderStyle = FormBorderStyle.None
        Name = "AdminAdmin"
        StartPosition = FormStartPosition.CenterScreen
        Text = "AdminAdmin"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        CType(AdminGrid, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Loans As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Admins As Label
    Friend WithEvents Users As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label7 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents LogoutBtn As Label
    Friend WithEvents Transactions As Label
    Friend WithEvents AdminGrid As DataGridView
    Friend WithEvents DateOfBirth As DateTimePicker
    Friend WithEvents Role As ComboBox
    Friend WithEvents SearchBtn As Button
    Friend WithEvents Id As TextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents FullName As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents AccountNumber As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents AccountName As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Password As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Email As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Username As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents LastName As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents FirstName As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents EditBtn As Button
    Friend WithEvents DeleteBtn As Button
    Friend WithEvents SaveBtn As Button
    Friend WithEvents AddBtn As Button
End Class
