﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AdminTransactions
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
        ClearAllBtn = New Button()
        TransactionsGrid = New DataGridView()
        DeleteBtn = New Button()
        Label4 = New Label()
        Label8 = New Label()
        Panel1 = New Panel()
        LogoutBtn = New Label()
        Transactions = New Label()
        Loans = New Label()
        Admins = New Label()
        Users = New Label()
        Panel3 = New Panel()
        Label7 = New Label()
        Label1 = New Label()
        Panel2 = New Panel()
        BackgroundWorker1 = New ComponentModel.BackgroundWorker()
        SearchBtn = New Button()
        SearchBox = New TextBox()
        CType(TransactionsGrid, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        Panel3.SuspendLayout()
        Panel2.SuspendLayout()
        SuspendLayout()
        ' 
        ' ClearAllBtn
        ' 
        ClearAllBtn.BackColor = Color.Red
        ClearAllBtn.Location = New Point(551, 95)
        ClearAllBtn.Name = "ClearAllBtn"
        ClearAllBtn.Size = New Size(107, 37)
        ClearAllBtn.TabIndex = 67
        ClearAllBtn.Text = "ClearAll"
        ClearAllBtn.UseVisualStyleBackColor = False
        ' 
        ' TransactionsGrid
        ' 
        TransactionsGrid.BackgroundColor = Color.White
        TransactionsGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        TransactionsGrid.Location = New Point(193, 153)
        TransactionsGrid.Name = "TransactionsGrid"
        TransactionsGrid.Size = New Size(584, 285)
        TransactionsGrid.TabIndex = 66
        ' 
        ' DeleteBtn
        ' 
        DeleteBtn.BackColor = Color.DarkRed
        DeleteBtn.Location = New Point(405, 95)
        DeleteBtn.Name = "DeleteBtn"
        DeleteBtn.Size = New Size(107, 37)
        DeleteBtn.TabIndex = 65
        DeleteBtn.Text = "Delete"
        DeleteBtn.UseVisualStyleBackColor = False
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
        Panel1.Controls.Add(LogoutBtn)
        Panel1.Controls.Add(Transactions)
        Panel1.Controls.Add(Loans)
        Panel1.Controls.Add(Admins)
        Panel1.Controls.Add(Users)
        Panel1.Location = New Point(0, 55)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(157, 395)
        Panel1.TabIndex = 63
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
        ' Transactions
        ' 
        Transactions.AutoSize = True
        Transactions.BackColor = Color.White
        Transactions.Font = New Font("Segoe UI", 15F)
        Transactions.ForeColor = Color.Teal
        Transactions.Location = New Point(29, 229)
        Transactions.Name = "Transactions"
        Transactions.Size = New Size(118, 28)
        Transactions.TabIndex = 45
        Transactions.Text = "Transactions"
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
        Panel3.TabIndex = 64
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
        Label1.Size = New Size(194, 28)
        Label1.TabIndex = 41
        Label1.Text = "Admin - Transactions"
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
        Panel2.TabIndex = 62
        ' 
        ' SearchBtn
        ' 
        SearchBtn.BackColor = Color.Teal
        SearchBtn.Location = New Point(248, 95)
        SearchBtn.Name = "SearchBtn"
        SearchBtn.Size = New Size(107, 37)
        SearchBtn.TabIndex = 68
        SearchBtn.Text = "Search"
        SearchBtn.UseVisualStyleBackColor = False
        ' 
        ' SearchBox
        ' 
        SearchBox.Location = New Point(324, 66)
        SearchBox.Name = "SearchBox"
        SearchBox.Size = New Size(249, 23)
        SearchBox.TabIndex = 69
        ' 
        ' AdminTransactions
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(SearchBox)
        Controls.Add(SearchBtn)
        Controls.Add(ClearAllBtn)
        Controls.Add(TransactionsGrid)
        Controls.Add(DeleteBtn)
        Controls.Add(Panel1)
        Controls.Add(Panel3)
        Controls.Add(Panel2)
        ForeColor = Color.White
        FormBorderStyle = FormBorderStyle.None
        Name = "AdminTransactions"
        StartPosition = FormStartPosition.CenterScreen
        Text = "AdminTransactions"
        CType(TransactionsGrid, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents ClearAllBtn As Button
    Friend WithEvents TransactionsGrid As DataGridView
    Friend WithEvents DeleteBtn As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Transactions As Label
    Friend WithEvents Loans As Label
    Friend WithEvents Admins As Label
    Friend WithEvents Users As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label7 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents SearchBtn As Button
    Friend WithEvents LogoutBtn As Label
    Friend WithEvents SearchBox As TextBox
End Class
