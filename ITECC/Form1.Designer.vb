<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        txtEmail = New TextBox()
        txtPassword = New TextBox()
        btnLogin = New Button()
        SuspendLayout()
        ' 
        ' txtEmail
        ' 
        txtEmail.Location = New Point(331, 305)
        txtEmail.Multiline = True
        txtEmail.Name = "txtEmail"
        txtEmail.Size = New Size(155, 23)
        txtEmail.TabIndex = 0
        ' 
        ' txtPassword
        ' 
        txtPassword.Location = New Point(331, 334)
        txtPassword.Multiline = True
        txtPassword.Name = "txtPassword"
        txtPassword.PasswordChar = "*"c
        txtPassword.Size = New Size(155, 26)
        txtPassword.TabIndex = 1
        ' 
        ' btnLogin
        ' 
        btnLogin.BackColor = Color.Blue
        btnLogin.Font = New Font("Segoe UI Emoji", 15.75F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        btnLogin.ForeColor = Color.White
        btnLogin.Location = New Point(303, 401)
        btnLogin.Name = "btnLogin"
        btnLogin.Size = New Size(192, 37)
        btnLogin.TabIndex = 2
        btnLogin.Text = "Sign in"
        btnLogin.UseVisualStyleBackColor = False
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 17F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources.FORM1
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(800, 510)
        Controls.Add(btnLogin)
        Controls.Add(txtPassword)
        Controls.Add(txtEmail)
        DoubleBuffered = True
        Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txtEmail As TextBox
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents btnLogin As Button

End Class
