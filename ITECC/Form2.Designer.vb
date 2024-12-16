<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        txtLastName = New TextBox()
        txtFirstName = New TextBox()
        txtMiddleName = New TextBox()
        txtNationality = New TextBox()
        cmbSex = New ComboBox()
        dtpDateOfBirth = New DateTimePicker()
        txtAddress = New TextBox()
        btnInsert = New Button()
        btnEdit = New Button()
        btnDelete = New Button()
        btnClear = New Button()
        DataGridView1 = New DataGridView()
        txtLicenseNo = New TextBox()
        dtpExpirationDate = New DateTimePicker()
        rbtnActive = New RadioButton()
        rbtnExpired = New RadioButton()
        label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        Label7 = New Label()
        Label8 = New Label()
        Label9 = New Label()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' txtLastName
        ' 
        txtLastName.Location = New Point(123, 46)
        txtLastName.Name = "txtLastName"
        txtLastName.Size = New Size(200, 23)
        txtLastName.TabIndex = 0
        ' 
        ' txtFirstName
        ' 
        txtFirstName.Location = New Point(123, 75)
        txtFirstName.Name = "txtFirstName"
        txtFirstName.Size = New Size(200, 23)
        txtFirstName.TabIndex = 1
        ' 
        ' txtMiddleName
        ' 
        txtMiddleName.Location = New Point(123, 104)
        txtMiddleName.Name = "txtMiddleName"
        txtMiddleName.Size = New Size(200, 23)
        txtMiddleName.TabIndex = 2
        ' 
        ' txtNationality
        ' 
        txtNationality.Location = New Point(123, 133)
        txtNationality.Name = "txtNationality"
        txtNationality.Size = New Size(200, 23)
        txtNationality.TabIndex = 3
        ' 
        ' cmbSex
        ' 
        cmbSex.FormattingEnabled = True
        cmbSex.Items.AddRange(New Object() {"Male", "Female"})
        cmbSex.Location = New Point(123, 162)
        cmbSex.Name = "cmbSex"
        cmbSex.Size = New Size(200, 23)
        cmbSex.TabIndex = 4
        ' 
        ' dtpDateOfBirth
        ' 
        dtpDateOfBirth.Location = New Point(123, 191)
        dtpDateOfBirth.Name = "dtpDateOfBirth"
        dtpDateOfBirth.Size = New Size(200, 23)
        dtpDateOfBirth.TabIndex = 5
        ' 
        ' txtAddress
        ' 
        txtAddress.Location = New Point(123, 278)
        txtAddress.Name = "txtAddress"
        txtAddress.Size = New Size(200, 23)
        txtAddress.TabIndex = 6
        ' 
        ' btnInsert
        ' 
        btnInsert.Location = New Point(305, 319)
        btnInsert.Name = "btnInsert"
        btnInsert.Size = New Size(118, 23)
        btnInsert.TabIndex = 7
        btnInsert.Text = "Insert"
        btnInsert.UseVisualStyleBackColor = True
        ' 
        ' btnEdit
        ' 
        btnEdit.Location = New Point(429, 319)
        btnEdit.Name = "btnEdit"
        btnEdit.Size = New Size(118, 23)
        btnEdit.TabIndex = 8
        btnEdit.Text = "Edit"
        btnEdit.UseVisualStyleBackColor = True
        ' 
        ' btnDelete
        ' 
        btnDelete.Location = New Point(677, 319)
        btnDelete.Name = "btnDelete"
        btnDelete.Size = New Size(118, 23)
        btnDelete.TabIndex = 9
        btnDelete.Text = "Delete"
        btnDelete.UseVisualStyleBackColor = True
        ' 
        ' btnClear
        ' 
        btnClear.Location = New Point(553, 319)
        btnClear.Name = "btnClear"
        btnClear.Size = New Size(118, 23)
        btnClear.TabIndex = 10
        btnClear.Text = "Clear"
        btnClear.UseVisualStyleBackColor = True
        ' 
        ' DataGridView1
        ' 
        DataGridView1.BackgroundColor = SystemColors.ControlLight
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(329, 46)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.Size = New Size(474, 267)
        DataGridView1.TabIndex = 11
        ' 
        ' txtLicenseNo
        ' 
        txtLicenseNo.Location = New Point(123, 220)
        txtLicenseNo.Name = "txtLicenseNo"
        txtLicenseNo.Size = New Size(200, 23)
        txtLicenseNo.TabIndex = 12
        ' 
        ' dtpExpirationDate
        ' 
        dtpExpirationDate.Location = New Point(123, 249)
        dtpExpirationDate.Name = "dtpExpirationDate"
        dtpExpirationDate.Size = New Size(200, 23)
        dtpExpirationDate.TabIndex = 13
        ' 
        ' rbtnActive
        ' 
        rbtnActive.AutoSize = True
        rbtnActive.BackColor = Color.Transparent
        rbtnActive.Location = New Point(112, 307)
        rbtnActive.Name = "rbtnActive"
        rbtnActive.Size = New Size(58, 19)
        rbtnActive.TabIndex = 14
        rbtnActive.TabStop = True
        rbtnActive.Text = "Active"
        rbtnActive.UseVisualStyleBackColor = False
        ' 
        ' rbtnExpired
        ' 
        rbtnExpired.AutoSize = True
        rbtnExpired.BackColor = Color.Transparent
        rbtnExpired.Location = New Point(176, 307)
        rbtnExpired.Name = "rbtnExpired"
        rbtnExpired.Size = New Size(64, 19)
        rbtnExpired.TabIndex = 15
        rbtnExpired.TabStop = True
        rbtnExpired.Text = "Expired"
        rbtnExpired.UseVisualStyleBackColor = False
        ' 
        ' label1
        ' 
        label1.AutoSize = True
        label1.BackColor = Color.Transparent
        label1.Font = New Font("Lucida Console", 9F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        label1.Location = New Point(44, 52)
        label1.Name = "label1"
        label1.Size = New Size(77, 12)
        label1.TabIndex = 16
        label1.Text = "LastName:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Lucida Console", 9F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(32, 81)
        Label2.Name = "Label2"
        Label2.Size = New Size(85, 12)
        Label2.TabIndex = 17
        Label2.Text = "FirstName:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.Font = New Font("Lucida Console", 9F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(24, 110)
        Label3.Name = "Label3"
        Label3.Size = New Size(93, 12)
        Label3.TabIndex = 18
        Label3.Text = "MiddleName:"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.Transparent
        Label4.Font = New Font("Lucida Console", 9F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(16, 139)
        Label4.Name = "Label4"
        Label4.Size = New Size(101, 12)
        Label4.TabIndex = 19
        Label4.Text = "Nationality:"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = Color.Transparent
        Label5.Font = New Font("Lucida Console", 9F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(80, 168)
        Label5.Name = "Label5"
        Label5.Size = New Size(37, 12)
        Label5.TabIndex = 20
        Label5.Text = "Sex:"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.BackColor = Color.Transparent
        Label6.Font = New Font("Lucida Console", 9F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label6.Location = New Point(0, 200)
        Label6.Name = "Label6"
        Label6.Size = New Size(117, 12)
        Label6.TabIndex = 21
        Label6.Text = "Date of Birth:"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.BackColor = Color.Transparent
        Label7.Font = New Font("Lucida Console", 9F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label7.Location = New Point(48, 226)
        Label7.Name = "Label7"
        Label7.Size = New Size(69, 12)
        Label7.TabIndex = 22
        Label7.Text = "Address:"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.BackColor = Color.Transparent
        Label8.Font = New Font("Lucida Console", 9F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label8.Location = New Point(24, 258)
        Label8.Name = "Label8"
        Label8.Size = New Size(93, 12)
        Label8.TabIndex = 23
        Label8.Text = "Expiration:"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.BackColor = Color.Transparent
        Label9.Font = New Font("Lucida Console", 9F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label9.Location = New Point(8, 284)
        Label9.Name = "Label9"
        Label9.Size = New Size(109, 12)
        Label9.TabIndex = 24
        Label9.Text = "License No. :"
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources.LTOBACKGROUND_FORM2
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(800, 450)
        Controls.Add(Label9)
        Controls.Add(Label8)
        Controls.Add(Label7)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(label1)
        Controls.Add(rbtnExpired)
        Controls.Add(rbtnActive)
        Controls.Add(dtpExpirationDate)
        Controls.Add(txtLicenseNo)
        Controls.Add(DataGridView1)
        Controls.Add(btnClear)
        Controls.Add(btnDelete)
        Controls.Add(btnEdit)
        Controls.Add(btnInsert)
        Controls.Add(txtAddress)
        Controls.Add(dtpDateOfBirth)
        Controls.Add(cmbSex)
        Controls.Add(txtNationality)
        Controls.Add(txtMiddleName)
        Controls.Add(txtFirstName)
        Controls.Add(txtLastName)
        DoubleBuffered = True
        Name = "Form2"
        Text = "Form2"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txtLastName As TextBox
    Friend WithEvents txtFirstName As TextBox
    Friend WithEvents txtMiddleName As TextBox
    Friend WithEvents txtNationality As TextBox
    Friend WithEvents cmbSex As ComboBox
    Friend WithEvents dtpDateOfBirth As DateTimePicker
    Friend WithEvents txtAddress As TextBox
    Friend WithEvents btnInsert As Button
    Friend WithEvents btnEdit As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents txtLicenseNo As TextBox
    Friend WithEvents dtpExpirationDate As DateTimePicker
    Friend WithEvents rbtnActive As RadioButton
    Friend WithEvents rbtnExpired As RadioButton
    Friend WithEvents label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
End Class
