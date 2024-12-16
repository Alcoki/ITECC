Imports MySql.Data.MySqlClient

Public Class Form2
    ' Connection string
    Dim connString As String = "Server=127.0.0.1;Database=ltodatabase;Uid=root;Pwd=;"

    ' Form Load Event to load data into DataGridView
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Fill DataGridView with customer data
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

    ' Insert Button - Add new record
    Private Sub btnInsert_Click(sender As Object, e As EventArgs) Handles btnInsert.Click
        ' Gather data from form fields
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

        ' Insert query
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
                ' Refresh DataGridView to show the new data
                Form2_Load(Nothing, Nothing)
            Catch ex As Exception
                MessageBox.Show("Error inserting data: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using
    End Sub

    ' Edit Button - Modify existing record
    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        ' Get the selected customer ID from DataGridView
        If DataGridView1.SelectedRows.Count > 0 Then
            Dim customerID As Integer = Convert.ToInt32(DataGridView1.SelectedRows(0).Cells("CustomerID").Value)

            ' Gather updated data from form fields
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

            ' Update query
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
                    ' Refresh DataGridView to show the updated data
                    Form2_Load(Nothing, Nothing)
                Catch ex As Exception
                    MessageBox.Show("Error updating data: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End Using
        End If
    End Sub

    ' Delete Button - Remove selected customer record
    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If DataGridView1.SelectedRows.Count > 0 Then
            Dim customerID As Integer = Convert.ToInt32(DataGridView1.SelectedRows(0).Cells("CustomerID").Value)

            ' Delete query
            Dim query As String = "DELETE FROM customer_table WHERE CustomerID = @CustomerID"

            Using conn As New MySqlConnection(connString)
                Try
                    conn.Open()
                    Dim cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@CustomerID", customerID)
                    cmd.ExecuteNonQuery()

                    MessageBox.Show("Customer deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    ' Refresh DataGridView to show the remaining data
                    Form2_Load(Nothing, Nothing)
                Catch ex As Exception
                    MessageBox.Show("Error deleting data: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End Using
        End If
    End Sub

    ' Clear Button - Reset all fields
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
