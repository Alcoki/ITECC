Imports MySql.Data.MySqlClient
Public Class Form1
    Dim connString As String = "Server=127.0.0.1;Database=ltodatabase;Uid=root;Pwd=;"

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click

        If String.IsNullOrEmpty(txtEmail.Text) Or String.IsNullOrEmpty(txtPassword.Text) Then
            MessageBox.Show("Please enter both email and password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim query As String = "SELECT * FROM account_table WHERE Email = @Email AND Password = @Password"


        Using conn As New MySqlConnection(connString)
            Try

                conn.Open()

                Dim cmd As New MySqlCommand(query, conn)

                cmd.Parameters.AddWithValue("@Email", txtEmail.Text)
                cmd.Parameters.AddWithValue("@Password", txtPassword.Text)

                Dim reader As MySqlDataReader = cmd.ExecuteReader()

                If reader.HasRows Then
                    Form2.Show()
                    Me.Hide()  
                Else
                    MessageBox.Show("Invalid email or password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If

            Catch ex As Exception
                MessageBox.Show("Error connecting to database: " & ex.Message, "Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                conn.Close()
            End Try
        End Using
    End Sub
End Class
