Imports MySql.Data.MySqlClient
Public Class Form1
    ' Connection string for MySQL
    Dim connString As String = "Server=127.0.0.1;Database=ltodatabase;Uid=root;Pwd=;"

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        ' Check if email or password is empty
        If String.IsNullOrEmpty(txtEmail.Text) Or String.IsNullOrEmpty(txtPassword.Text) Then
            MessageBox.Show("Please enter both email and password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' SQL query to check for matching email and password
        Dim query As String = "SELECT * FROM account_table WHERE Email = @Email AND Password = @Password"

        ' Create a new MySQL connection
        Using conn As New MySqlConnection(connString)
            Try
                ' Open the connection
                conn.Open()

                ' Create a new MySQL command with the query and connection
                Dim cmd As New MySqlCommand(query, conn)

                ' Add parameters to prevent SQL injection
                cmd.Parameters.AddWithValue("@Email", txtEmail.Text)
                cmd.Parameters.AddWithValue("@Password", txtPassword.Text)

                ' Execute the query and check if any rows are returned
                Dim reader As MySqlDataReader = cmd.ExecuteReader()

                If reader.HasRows Then
                    ' Login successful, open Form2
                    Form2.Show()
                    Me.Hide()  ' Hide the login form
                Else
                    ' Login failed, show error message
                    MessageBox.Show("Invalid email or password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If

            Catch ex As Exception
                ' Handle any connection errors
                MessageBox.Show("Error connecting to database: " & ex.Message, "Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                ' Ensure the connection is closed
                conn.Close()
            End Try
        End Using
    End Sub
End Class
