Imports System.Configuration
Imports MySqlConnector

Public Class Admin
    Dim dbHelper As New DatabaseHelper()
    Dim connectionString As String = ConfigurationManager.ConnectionStrings("MyDbConnection").ConnectionString

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click
        Application.Exit()
    End Sub

    Private Sub Role_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Role.SelectedIndexChanged
        Dim selectedRole As String = Role.SelectedItem.ToString()
        ' No need to set Role.Text, as SelectedItem already gives the selected role.
    End Sub

    Private Sub UsersGrid_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles UsersGrid.CellClick
        For Each row As DataGridViewRow In UsersGrid.Rows
            row.DefaultCellStyle.BackColor = Color.White
            row.DefaultCellStyle.ForeColor = Color.Black
        Next

        If e.RowIndex >= 0 Then
            UsersGrid.Rows(e.RowIndex).DefaultCellStyle.BackColor = Color.Teal
            UsersGrid.Rows(e.RowIndex).DefaultCellStyle.ForeColor = Color.White
        End If
    End Sub

    Public Sub LoadCustomers()
        Try
            Using conn As New MySqlConnection(connectionString)
                conn.Open()
                Dim query As String = "SELECT * FROM Users WHERE Role = 'customer'"
                Dim adapter As New MySqlDataAdapter(query, conn)
                Dim table As New DataTable()
                adapter.Fill(table)
                UsersGrid.DataSource = table
                UsersGrid.RowsDefaultCellStyle.ForeColor = Color.Teal
                UsersGrid.RowsDefaultCellStyle.BackColor = Color.White
            End Using
        Catch ex As Exception
            MessageBox.Show("Error loading customers: " & ex.Message)
        End Try
    End Sub

    Private Sub Admin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Role.Items.Clear()
        Role.Items.Add("admin")
        Role.Items.Add("customer")
        Role.SelectedIndex = 1
        LoadCustomers()
    End Sub

    Private Sub Users_Click(sender As Object, e As EventArgs) Handles Users.Click
        Dim users = New Admin
        users.Show()
        Me.Hide()
    End Sub

    Private Sub Adminn_Click(sender As Object, e As EventArgs) Handles Admins.Click
        Dim admin = New AdminAdmin
        admin.Show()
        Me.Hide()
    End Sub

    Private Sub Loans_Click(sender As Object, e As EventArgs) Handles Loans.Click
        Dim loans = New AdminLoan
        loans.Show()
        Me.Hide()
    End Sub

    Private Sub Transactions_Click(sender As Object, e As EventArgs) Handles Transactions.Click
        Dim transactions = New AdminTransactions
        transactions.Show()
        Me.Hide()
    End Sub

    Private Sub LogoutBtn_Click(sender As Object, e As EventArgs) Handles LogoutBtn.Click
        Dim success As Boolean = dbHelper.LogoutUser()
        MessageBox.Show("Logout Successful")
        Dim login = New Login
        login.Show()
        Me.Hide()
    End Sub

    Private Sub DeleteBtn_Click(sender As Object, e As EventArgs) Handles DeleteBtn.Click
        Try
            Using conn As New MySqlConnection(connectionString)
                conn.Open()
                Dim query As String = "DELETE FROM users WHERE id=@id"
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@id", Id.Text.Trim())
                    cmd.ExecuteNonQuery()
                    MessageBox.Show("User deleted successfully.")
                    LoadCustomers() ' Refresh the user grid after deletion
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Failed to delete user: " & ex.Message)
        End Try
    End Sub

    Private Sub SearchBtn_Click(sender As Object, e As EventArgs) Handles SearchBtn.Click
        Try
            Using conn As New MySqlConnection(connectionString)
                conn.Open()
                Dim query As String = "SELECT * FROM users WHERE id = @id OR username = @username or firstname = @firstname or lastname = @lastname or account_name = @accountname or account_number = @accountnumber"
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@id", Id.Text.Trim())
                    cmd.Parameters.AddWithValue("@username", Username.Text.Trim())
                    cmd.Parameters.AddWithValue("@firstname", FirstName.Text.Trim())
                    cmd.Parameters.AddWithValue("@lastname", LastName.Text.Trim())
                    cmd.Parameters.AddWithValue("@accountname", AccountName.Text.Trim())
                    cmd.Parameters.AddWithValue("@accountnumber", AccountNumber.Text.Trim())


                    Dim reader As MySqlDataReader = cmd.ExecuteReader()

                    If reader.Read() Then
                        FirstName.Text = reader("FirstName").ToString()
                        LastName.Text = reader("LastName").ToString()
                        Email.Text = reader("Email").ToString()
                        Username.Text = reader("Username").ToString()
                        Password.Text = reader("Password").ToString()
                        Role.Text = reader("Role").ToString()
                        DateOfBirth.Text = reader("Date_of_birth").ToString()
                    Else
                        MessageBox.Show("User not found.")
                    End If
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Search failed: " & ex.Message)
        End Try
    End Sub

    Private Sub SaveBtn_Click(sender As Object, e As EventArgs) Handles SaveBtn.Click
        If Id.Text = "" Then
            AddBtn_Click(sender, e)
        Else
            EditBtn_Click(sender, e)
        End If
    End Sub

    Private Sub EditBtn_Click(sender As Object, e As EventArgs) Handles EditBtn.Click
        Try
            Using conn As New MySqlConnection(connectionString)
                conn.Open()
                Dim query As String = "UPDATE users SET FirstName=@FirstName, LastName=@LastName, Email=@Email, Username=@Username, Password=@Password, Role=@Role, Date_of_birth=@DOB WHERE id=@id"
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@FirstName", FirstName.Text.Trim())
                    cmd.Parameters.AddWithValue("@LastName", LastName.Text.Trim())
                    cmd.Parameters.AddWithValue("@Email", Email.Text.Trim())
                    cmd.Parameters.AddWithValue("@Username", Username.Text.Trim())
                    cmd.Parameters.AddWithValue("@Password", Password.Text.Trim()) ' Hash this value before saving
                    cmd.Parameters.AddWithValue("@Role", Role.Text.Trim())
                    cmd.Parameters.AddWithValue("@DOB", DateOfBirth.Text.Trim())
                    cmd.Parameters.AddWithValue("@id", Id.Text.Trim())
                    cmd.ExecuteNonQuery()
                    MessageBox.Show("User updated successfully.")
                    LoadCustomers() ' Reload the customers list after update
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Failed to update user: " & ex.Message)
        End Try
    End Sub

    Public Function GenerateAccountNumber() As String
        Dim rand As New Random()
        Dim accountNumber As String
        Dim exists As Boolean

        Using conn As New MySqlConnection(connectionString)
            conn.Open()

            Do
                Dim branchCode As String = "456"
                Dim accountType As String = "10"
                Dim customerId As String = rand.Next(100000, 999999).ToString()
                accountNumber = branchCode & accountType & customerId

                ' Check if it already exists
                Dim checkQuery As String = "SELECT COUNT(*) FROM Users WHERE Account_Number = @accountNumber"
                Using cmd As New MySqlCommand(checkQuery, conn)
                    cmd.Parameters.AddWithValue("@accountNumber", accountNumber)
                    exists = Convert.ToInt32(cmd.ExecuteScalar()) > 0
                End Using
            Loop While exists

        End Using

        Return accountNumber
    End Function
    Private Sub AddBtn_Click(sender As Object, e As EventArgs) Handles AddBtn.Click
        Try
            ' Parse the DateOfBirth value from the TextBox to a DateTime object
            Dim dob As DateTime
            If DateTime.TryParse(DateOfBirth.Text.Trim(), dob) Then
                ' Proceed with insertion if the date is valid
                Using conn As New MySqlConnection(connectionString)
                    conn.Open()
                    Dim query As String = "INSERT INTO users (FirstName, LastName, Email, Username, Password, Role, Date_of_birth, Account_number, Account_name) 
                                       VALUES (@FirstName, @LastName, @Email, @Username, @Password, @Role, @DOB, @accountnumber, @accountname)"
                    Using cmd As New MySqlCommand(query, conn)
                        cmd.Parameters.AddWithValue("@FirstName", FirstName.Text.Trim())
                        cmd.Parameters.AddWithValue("@LastName", LastName.Text.Trim())
                        cmd.Parameters.AddWithValue("@Email", Email.Text.Trim())
                        cmd.Parameters.AddWithValue("@Username", Username.Text.Trim())
                        cmd.Parameters.AddWithValue("@Password", Password.Text.Trim()) ' Hash this value before saving
                        cmd.Parameters.AddWithValue("@Role", Role.Text.Trim())
                        cmd.Parameters.AddWithValue("@DOB", dob)
                        cmd.Parameters.AddWithValue("@accountnumber", GenerateAccountNumber())
                        cmd.Parameters.AddWithValue("@accountname", FirstName.Text.Trim() + " " + LastName.Text.Trim())

                        cmd.ExecuteNonQuery()
                        MessageBox.Show("User added successfully.")
                        LoadCustomers() ' Reload the customers list after addition
                    End Using
                End Using
            Else
                MessageBox.Show("Invalid date format. Please enter a valid date.")
            End If
        Catch ex As Exception
            MessageBox.Show("Failed to add user: " & ex.Message)
        End Try
    End Sub

End Class
