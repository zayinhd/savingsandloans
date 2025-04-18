Imports MySqlConnector
Imports System.Configuration
Imports System.IO

Public Class DatabaseHelper
    Private connectionString As String = ConfigurationManager.ConnectionStrings("MyDbConnection").ConnectionString

    ' Generate account number
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

    ' ✅ Register a new user
    Public Function RegisterUser(username As String, password As String, firstname As String, lastname As String, email As String, dateOfBirth As Date) As Boolean
        Try
            Using conn As New MySqlConnection(connectionString)
                conn.Open()
                Dim query As String = "INSERT INTO Users (Username, Password, Firstname, Lastname, Email,Date_Of_Birth, Role, Account_Number, Account_Name) VALUES (@username, @password, @firstname, @lastname, @email, @dateofbirth, @role, @accountnumber, @accountname)"
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@username", username)
                    cmd.Parameters.AddWithValue("@password", password)
                    cmd.Parameters.AddWithValue("@firstname", firstname)
                    cmd.Parameters.AddWithValue("@lastname", lastname)
                    cmd.Parameters.AddWithValue("@email", email)
                    cmd.Parameters.AddWithValue("@dateofbirth", dateOfBirth)
                    cmd.Parameters.AddWithValue("@role", "customer")
                    cmd.Parameters.AddWithValue("@accountnumber", GenerateAccountNumber())
                    cmd.Parameters.AddWithValue("@accountname", firstname + " " + lastname)

                    Return cmd.ExecuteNonQuery() > 0
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Registration Error: " & ex.Message)
            Return False
        End Try
    End Function


    ' ✅ Login user
    Public Function LoginUser(username As String, password As String) As Boolean
        Try
            Using conn As New MySqlConnection(connectionString)
                conn.Open()
                Dim query As String = "SELECT * FROM Users WHERE Username = @username AND Password = @password"
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@username", username)
                    cmd.Parameters.AddWithValue("@password", password)

                    Using reader As MySqlDataReader = cmd.ExecuteReader()
                        If reader.Read() Then
                            ' Store info into session
                            UserSession.LoggedInUserId = Convert.ToInt32(reader("id"))
                            UserSession.LoggedInRole = reader("Role").ToString()
                            UserSession.AccountNumber = reader("Account_Number").ToString()
                            UserSession.FirstName = reader("Firstname").ToString()
                            UserSession.LastName = reader("Lastname").ToString()
                            UserSession.AccountBalance = Convert.ToDecimal(reader("Account_Balance"))
                            UserSession.LoanBalance = Convert.ToDecimal(reader("Loan_Balance"))
                            UserSession.AccountName = reader("Account_Name").ToString()

                            ' Other session fields...
                            If Not IsDBNull(reader("ProfileImage")) Then
                                    Dim imgBytes() As Byte = CType(reader("ProfileImage"), Byte())
                                    Using ms As New MemoryStream(imgBytes)
                                        UserSession.ProfileImage = Image.FromStream(ms)
                                    End Using
                                End If
                            Return True
                        Else
                            Return False
                        End If
                    End Using
                End Using
            End Using



        Catch ex As Exception
            MessageBox.Show("Login Error: " & ex.Message)
            Return False
        End Try
    End Function

    Public Function LogoutUser() As Boolean
        Try

            ' Store info into session
            UserSession.LoggedInUserId = 0
            UserSession.LoggedInRole = ""
            UserSession.AccountNumber = ""
            UserSession.AccountName = ""
            UserSession.AccountBalance = 0.00
            UserSession.LoanBalance = 0.00
            UserSession.FirstName = ""
            UserSession.LastName = ""
            UserSession.ProfileImage = Nothing

            Return True

        Catch ex As Exception
            MessageBox.Show("Logout Error: " & ex.Message)
            Return False
        End Try
    End Function

End Class

