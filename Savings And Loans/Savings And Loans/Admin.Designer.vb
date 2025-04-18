<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Admin
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
        Transactions = New Label()
        LogoutBtn = New Label()
        Loans = New Label()
        Admins = New Label()
        Users = New Label()
        Panel2 = New Panel()
        Label4 = New Label()
        Panel3 = New Panel()
        Label7 = New Label()
        Label1 = New Label()
        BackgroundWorker1 = New ComponentModel.BackgroundWorker()
        AddBtn = New Button()
        UsersGrid = New DataGridView()
        SaveBtn = New Button()
        DeleteBtn = New Button()
        EditBtn = New Button()
        FirstName = New TextBox()
        Label5 = New Label()
        LastName = New TextBox()
        Label6 = New Label()
        Username = New TextBox()
        Label9 = New Label()
        Email = New TextBox()
        Label10 = New Label()
        Password = New TextBox()
        Label11 = New Label()
        AccountName = New TextBox()
        Label12 = New Label()
        AccountNumber = New TextBox()
        Label13 = New Label()
        FullName = New TextBox()
        Label14 = New Label()
        Id = New TextBox()
        Label16 = New Label()
        Label17 = New Label()
        Label18 = New Label()
        SearchBtn = New Button()
        Role = New ComboBox()
        DateOfBirth = New DateTimePicker()
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
        Panel3.SuspendLayout()
        CType(UsersGrid, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
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
        Panel1.TabIndex = 43
        ' 
        ' Transactions
        ' 
        Transactions.AutoSize = True
        Transactions.BackColor = Color.Teal
        Transactions.Font = New Font("Segoe UI", 15F)
        Transactions.ForeColor = Color.White
        Transactions.Location = New Point(29, 220)
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
        ' Admins
        ' 
        Admins.AutoSize = True
        Admins.Font = New Font("Segoe UI", 15F)
        Admins.Location = New Point(29, 117)
        Admins.Name = "Admins"
        Admins.Size = New Size(78, 28)
        Admins.TabIndex = 43
        Admins.Text = "Admins"
        ' 
        ' Users
        ' 
        Users.AutoSize = True
        Users.BackColor = Color.White
        Users.Font = New Font("Segoe UI", 15F)
        Users.ForeColor = Color.Teal
        Users.Location = New Point(29, 61)
        Users.Name = "Users"
        Users.Size = New Size(59, 28)
        Users.TabIndex = 42
        Users.Text = "Users"
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
        Panel3.Controls.Add(Label7)
        Panel3.Controls.Add(Label1)
        Panel3.Controls.Add(Label8)
        Panel3.Location = New Point(157, 0)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(643, 54)
        Panel3.TabIndex = 44
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
        Label1.Size = New Size(135, 28)
        Label1.TabIndex = 41
        Label1.Text = "Admin - Users"
        ' 
        ' AddBtn
        ' 
        AddBtn.BackColor = Color.Teal
        AddBtn.Location = New Point(193, 70)
        AddBtn.Name = "AddBtn"
        AddBtn.Size = New Size(107, 37)
        AddBtn.TabIndex = 43
        AddBtn.Text = "Add"
        AddBtn.UseVisualStyleBackColor = False
        ' 
        ' UsersGrid
        ' 
        UsersGrid.BackgroundColor = Color.White
        UsersGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        UsersGrid.Location = New Point(193, 293)
        UsersGrid.Name = "UsersGrid"
        UsersGrid.Size = New Size(584, 145)
        UsersGrid.TabIndex = 45
        ' 
        ' SaveBtn
        ' 
        SaveBtn.BackColor = Color.Teal
        SaveBtn.Location = New Point(438, 70)
        SaveBtn.Name = "SaveBtn"
        SaveBtn.Size = New Size(107, 37)
        SaveBtn.TabIndex = 46
        SaveBtn.Text = "Save"
        SaveBtn.UseVisualStyleBackColor = False
        ' 
        ' DeleteBtn
        ' 
        DeleteBtn.BackColor = Color.Red
        DeleteBtn.Location = New Point(681, 70)
        DeleteBtn.Name = "DeleteBtn"
        DeleteBtn.Size = New Size(107, 37)
        DeleteBtn.TabIndex = 48
        DeleteBtn.Text = "Delete"
        DeleteBtn.UseVisualStyleBackColor = False
        ' 
        ' EditBtn
        ' 
        EditBtn.BackColor = Color.Teal
        EditBtn.Location = New Point(316, 70)
        EditBtn.Name = "EditBtn"
        EditBtn.Size = New Size(107, 37)
        EditBtn.TabIndex = 49
        EditBtn.Text = "Edit"
        EditBtn.UseVisualStyleBackColor = False
        ' 
        ' FirstName
        ' 
        FirstName.ForeColor = Color.Teal
        FirstName.Location = New Point(260, 131)
        FirstName.Name = "FirstName"
        FirstName.Size = New Size(102, 23)
        FirstName.TabIndex = 60
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 8F)
        Label5.ForeColor = Color.Teal
        Label5.Location = New Point(193, 135)
        Label5.Name = "Label5"
        Label5.Size = New Size(61, 13)
        Label5.TabIndex = 59
        Label5.Text = "First Name"
        ' 
        ' LastName
        ' 
        LastName.ForeColor = Color.Teal
        LastName.Location = New Point(260, 168)
        LastName.Name = "LastName"
        LastName.Size = New Size(102, 23)
        LastName.TabIndex = 62
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 8F)
        Label6.ForeColor = Color.Teal
        Label6.Location = New Point(193, 172)
        Label6.Name = "Label6"
        Label6.Size = New Size(59, 13)
        Label6.TabIndex = 61
        Label6.Text = "Last Name"
        ' 
        ' Username
        ' 
        Username.ForeColor = Color.Teal
        Username.Location = New Point(260, 207)
        Username.Name = "Username"
        Username.Size = New Size(102, 23)
        Username.TabIndex = 64
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Segoe UI", 8F)
        Label9.ForeColor = Color.Teal
        Label9.Location = New Point(193, 211)
        Label9.Name = "Label9"
        Label9.Size = New Size(58, 13)
        Label9.TabIndex = 63
        Label9.Text = "Username"
        ' 
        ' Email
        ' 
        Email.ForeColor = Color.Teal
        Email.Location = New Point(260, 247)
        Email.Name = "Email"
        Email.Size = New Size(102, 23)
        Email.TabIndex = 66
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Segoe UI", 8F)
        Label10.ForeColor = Color.Teal
        Label10.Location = New Point(193, 251)
        Label10.Name = "Label10"
        Label10.Size = New Size(34, 13)
        Label10.TabIndex = 65
        Label10.Text = "Email"
        ' 
        ' Password
        ' 
        Password.ForeColor = Color.Teal
        Password.Location = New Point(462, 131)
        Password.Name = "Password"
        Password.Size = New Size(102, 23)
        Password.TabIndex = 68
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Font = New Font("Segoe UI", 8F)
        Label11.ForeColor = Color.Teal
        Label11.Location = New Point(395, 135)
        Label11.Name = "Label11"
        Label11.Size = New Size(56, 13)
        Label11.TabIndex = 67
        Label11.Text = "Password"
        ' 
        ' AccountName
        ' 
        AccountName.ForeColor = Color.Teal
        AccountName.Location = New Point(462, 168)
        AccountName.Name = "AccountName"
        AccountName.Size = New Size(102, 23)
        AccountName.TabIndex = 70
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Font = New Font("Segoe UI", 8F)
        Label12.ForeColor = Color.Teal
        Label12.Location = New Point(395, 172)
        Label12.Name = "Label12"
        Label12.Size = New Size(59, 13)
        Label12.TabIndex = 69
        Label12.Text = "Acc. Name"
        ' 
        ' AccountNumber
        ' 
        AccountNumber.ForeColor = Color.Teal
        AccountNumber.Location = New Point(462, 207)
        AccountNumber.Name = "AccountNumber"
        AccountNumber.Size = New Size(102, 23)
        AccountNumber.TabIndex = 72
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.Font = New Font("Segoe UI", 8F)
        Label13.ForeColor = Color.Teal
        Label13.Location = New Point(395, 211)
        Label13.Name = "Label13"
        Label13.Size = New Size(71, 13)
        Label13.TabIndex = 71
        Label13.Text = "Acc. Number"
        ' 
        ' FullName
        ' 
        FullName.ForeColor = Color.Teal
        FullName.Location = New Point(462, 247)
        FullName.Name = "FullName"
        FullName.Size = New Size(102, 23)
        FullName.TabIndex = 74
        ' 
        ' Label14
        ' 
        Label14.AutoSize = True
        Label14.Font = New Font("Segoe UI", 8F)
        Label14.ForeColor = Color.Teal
        Label14.Location = New Point(395, 251)
        Label14.Name = "Label14"
        Label14.Size = New Size(58, 13)
        Label14.TabIndex = 73
        Label14.Text = "Full Name"
        ' 
        ' Id
        ' 
        Id.ForeColor = Color.Teal
        Id.Location = New Point(659, 207)
        Id.Name = "Id"
        Id.Size = New Size(102, 23)
        Id.TabIndex = 80
        ' 
        ' Label16
        ' 
        Label16.AutoSize = True
        Label16.Font = New Font("Segoe UI", 8F)
        Label16.ForeColor = Color.Teal
        Label16.Location = New Point(592, 211)
        Label16.Name = "Label16"
        Label16.Size = New Size(21, 13)
        Label16.TabIndex = 79
        Label16.Text = "I.D"
        ' 
        ' Label17
        ' 
        Label17.AutoSize = True
        Label17.Font = New Font("Segoe UI", 8F)
        Label17.ForeColor = Color.Teal
        Label17.Location = New Point(592, 172)
        Label17.Name = "Label17"
        Label17.Size = New Size(54, 13)
        Label17.TabIndex = 77
        Label17.Text = "D.O.Birth"
        ' 
        ' Label18
        ' 
        Label18.AutoSize = True
        Label18.Font = New Font("Segoe UI", 8F)
        Label18.ForeColor = Color.Teal
        Label18.Location = New Point(592, 135)
        Label18.Name = "Label18"
        Label18.Size = New Size(30, 13)
        Label18.TabIndex = 75
        Label18.Text = "Role"
        ' 
        ' SearchBtn
        ' 
        SearchBtn.BackColor = Color.Teal
        SearchBtn.Location = New Point(556, 70)
        SearchBtn.Name = "SearchBtn"
        SearchBtn.Size = New Size(107, 37)
        SearchBtn.TabIndex = 83
        SearchBtn.Text = "Search"
        SearchBtn.UseVisualStyleBackColor = False
        ' 
        ' Role
        ' 
        Role.FormattingEnabled = True
        Role.Location = New Point(659, 131)
        Role.Name = "Role"
        Role.Size = New Size(102, 23)
        Role.TabIndex = 84
        ' 
        ' DateOfBirth
        ' 
        DateOfBirth.Location = New Point(659, 165)
        DateOfBirth.Name = "DateOfBirth"
        DateOfBirth.Size = New Size(102, 23)
        DateOfBirth.TabIndex = 86
        ' 
        ' Admin
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
        Controls.Add(UsersGrid)
        Controls.Add(AddBtn)
        Controls.Add(Panel1)
        Controls.Add(Panel3)
        Controls.Add(Panel2)
        ForeColor = Color.White
        FormBorderStyle = FormBorderStyle.None
        Name = "Admin"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Admin"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        CType(UsersGrid, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label8 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Loans As Label
    Friend WithEvents Admins As Label
    Friend WithEvents Users As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents AddBtn As Button
    Friend WithEvents UsersGrid As DataGridView
    Friend WithEvents SaveBtn As Button
    Friend WithEvents DeleteBtn As Button
    Friend WithEvents EditBtn As Button
    Friend WithEvents FirstName As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents LastName As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Username As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Email As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Password As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents AccountName As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents AccountNumber As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents FullName As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents Id As TextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents SearchBtn As Button
    Friend WithEvents Role As ComboBox
    Friend WithEvents DateOfBirth As DateTimePicker
    Friend WithEvents LogoutBtn As Label
    Friend WithEvents Transactions As Label
End Class
