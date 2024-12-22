Imports MySql.Data.MySqlClient

Public Class Form2
    Dim connString As String = "Server=127.0.0.1;Database=ltodatabase;Uid=root;Pwd=;"

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim query As String = "SELECT * FROM customer_table"

        Using conn As New MySqlConnection(connString)
            Try
                conn.Open()
                Dim cmd As New MySqlCommand(query, conn)
                Dim adapter As New MySqlDataAdapter(cmd)
                Dim dt As New DataTable()
                adapter.Fill(dt)
                DataGridView1.DataSource = dt
            Catch ex As Exception
                MessageBox.Show("Error loading data: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using
    End Sub


    Private Sub btnInsert_Click(sender As Object, e As EventArgs) Handles btnInsert.Click
        Dim lastName As String = txtLastName.Text
        Dim firstName As String = txtFirstName.Text
        Dim middleName As String = txtMiddleName.Text
        Dim nationality As String = txtNationality.Text
        Dim sex As String = cmbSex.SelectedItem.ToString()
        Dim dateOfBirth As Date = dtpDateOfBirth.Value
        Dim address As String = txtAddress.Text
        Dim licenseNo As String = txtLicenseNo.Text
        Dim expirationDate As Date = dtpExpirationDate.Value
        Dim status As Boolean = If(rbtnActive.Checked, True, False)

        Dim query As String = "INSERT INTO customer_table (LastName, FirstName, MiddleName, Nationality, Sex, DateOfBirth, Address, LicenseNo, ExpirationDate, Status) " &
                              "VALUES (@LastName, @FirstName, @MiddleName, @Nationality, @Sex, @DateOfBirth, @Address, @LicenseNo, @ExpirationDate, @Status)"

        Using conn As New MySqlConnection(connString)
            Try
                conn.Open()
                Dim cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@LastName", lastName)
                cmd.Parameters.AddWithValue("@FirstName", firstName)
                cmd.Parameters.AddWithValue("@MiddleName", middleName)
                cmd.Parameters.AddWithValue("@Nationality", nationality)
                cmd.Parameters.AddWithValue("@Sex", sex)
                cmd.Parameters.AddWithValue("@DateOfBirth", dateOfBirth)
                cmd.Parameters.AddWithValue("@Address", address)
                cmd.Parameters.AddWithValue("@LicenseNo", licenseNo)
                cmd.Parameters.AddWithValue("@ExpirationDate", expirationDate)
                cmd.Parameters.AddWithValue("@Status", status)
                cmd.ExecuteNonQuery()

                MessageBox.Show("Customer added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Form2_Load(Nothing, Nothing)
            Catch ex As Exception
                MessageBox.Show("Error inserting data: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using
    End Sub


    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click

        If DataGridView1.SelectedRows.Count > 0 Then
            Dim customerID As Integer = Convert.ToInt32(DataGridView1.SelectedRows(0).Cells("CustomerID").Value)

            Dim lastName As String = txtLastName.Text
            Dim firstName As String = txtFirstName.Text
            Dim middleName As String = txtMiddleName.Text
            Dim nationality As String = txtNationality.Text
            Dim sex As String = cmbSex.SelectedItem.ToString()
            Dim dateOfBirth As Date = dtpDateOfBirth.Value
            Dim address As String = txtAddress.Text
            Dim licenseNo As String = txtLicenseNo.Text
            Dim expirationDate As Date = dtpExpirationDate.Value
            Dim status As Boolean = If(rbtnActive.Checked, True, False)

            Dim query As String = "UPDATE customer_table SET LastName = @LastName, FirstName = @FirstName, MiddleName = @MiddleName, " &
                                  "Nationality = @Nationality, Sex = @Sex, DateOfBirth = @DateOfBirth, Address = @Address, LicenseNo = @LicenseNo, " &
                                  "ExpirationDate = @ExpirationDate, Status = @Status WHERE CustomerID = @CustomerID"

            Using conn As New MySqlConnection(connString)
                Try
                    conn.Open()
                    Dim cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@CustomerID", customerID)
                    cmd.Parameters.AddWithValue("@LastName", lastName)
                    cmd.Parameters.AddWithValue("@FirstName", firstName)
                    cmd.Parameters.AddWithValue("@MiddleName", middleName)
                    cmd.Parameters.AddWithValue("@Nationality", nationality)
                    cmd.Parameters.AddWithValue("@Sex", sex)
                    cmd.Parameters.AddWithValue("@DateOfBirth", dateOfBirth)
                    cmd.Parameters.AddWithValue("@Address", address)
                    cmd.Parameters.AddWithValue("@LicenseNo", licenseNo)
                    cmd.Parameters.AddWithValue("@ExpirationDate", expirationDate)
                    cmd.Parameters.AddWithValue("@Status", status)
                    cmd.ExecuteNonQuery()

                    MessageBox.Show("Customer updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

                    Form2_Load(Nothing, Nothing)
                Catch ex As Exception
                    MessageBox.Show("Error updating data: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End Using
        End If
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If DataGridView1.SelectedRows.Count > 0 Then
            Dim customerID As Integer = Convert.ToInt32(DataGridView1.SelectedRows(0).Cells("CustomerID").Value)

            Dim query As String = "DELETE FROM customer_table WHERE CustomerID = @CustomerID"

            Using conn As New MySqlConnection(connString)
                Try
                    conn.Open()
                    Dim cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@CustomerID", customerID)
                    cmd.ExecuteNonQuery()

                    MessageBox.Show("Customer deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

                    Form2_Load(Nothing, Nothing)
                Catch ex As Exception
                    MessageBox.Show("Error deleting data: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End Using
        End If
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtLastName.Clear()
        txtFirstName.Clear()
        txtMiddleName.Clear()
        txtNationality.Clear()
        cmbSex.SelectedIndex = -1
        dtpDateOfBirth.Value = Date.Now
        txtAddress.Clear()
        txtLicenseNo.Clear()
        dtpExpirationDate.Value = Date.Now
        rbtnActive.Checked = False
        rbtnExpired.Checked = False
    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click

    End Sub

    Private Sub Label9_Click(sender As Object, e As EventArgs) Handles Label9.Click

    End Sub
End Class
