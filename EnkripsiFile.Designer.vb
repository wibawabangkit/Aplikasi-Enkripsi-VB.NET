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
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnChangeEncrypt = New System.Windows.Forms.Button()
        Me.txtDestinationEncrypt = New System.Windows.Forms.TextBox()
        Me.btnEncrypt = New System.Windows.Forms.Button()
        Me.txtConPassEncrypt = New System.Windows.Forms.TextBox()
        Me.txtPassEncrypt = New System.Windows.Forms.TextBox()
        Me.btnBrowseEncrypt = New System.Windows.Forms.Button()
        Me.txtFileToEncrypt = New System.Windows.Forms.TextBox()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.btnChangeDecrypt = New System.Windows.Forms.Button()
        Me.txtDestinationDecrypt = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnDecrypt = New System.Windows.Forms.Button()
        Me.txtConPassDecrypt = New System.Windows.Forms.TextBox()
        Me.txtPassDecrypt = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.btnBrowseDecrypt = New System.Windows.Forms.Button()
        Me.txtFileToDecrypt = New System.Windows.Forms.TextBox()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(384, 144)
        Me.TabControl1.TabIndex = 1
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.SystemColors.Control
        Me.TabPage1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.TabPage1.Controls.Add(Me.Label3)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Controls.Add(Me.Label4)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Controls.Add(Me.btnChangeEncrypt)
        Me.TabPage1.Controls.Add(Me.txtDestinationEncrypt)
        Me.TabPage1.Controls.Add(Me.btnEncrypt)
        Me.TabPage1.Controls.Add(Me.txtConPassEncrypt)
        Me.TabPage1.Controls.Add(Me.txtPassEncrypt)
        Me.TabPage1.Controls.Add(Me.btnBrowseEncrypt)
        Me.TabPage1.Controls.Add(Me.txtFileToEncrypt)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Size = New System.Drawing.Size(376, 118)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Encrypt File"
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(-6, 92)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(104, 16)
        Me.Label3.TabIndex = 23
        Me.Label3.Text = "Confirm password:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(8, 68)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(88, 16)
        Me.Label2.TabIndex = 22
        Me.Label2.Text = "Type password:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(10, 34)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(88, 16)
        Me.Label4.TabIndex = 21
        Me.Label4.Text = "File destination:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(18, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 16)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "File to decrypt:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnChangeEncrypt
        '
        Me.btnChangeEncrypt.Enabled = False
        Me.btnChangeEncrypt.Location = New System.Drawing.Point(296, 32)
        Me.btnChangeEncrypt.Name = "btnChangeEncrypt"
        Me.btnChangeEncrypt.Size = New System.Drawing.Size(72, 21)
        Me.btnChangeEncrypt.TabIndex = 11
        Me.btnChangeEncrypt.Text = "Target"
        '
        'txtDestinationEncrypt
        '
        Me.txtDestinationEncrypt.Location = New System.Drawing.Point(104, 32)
        Me.txtDestinationEncrypt.Name = "txtDestinationEncrypt"
        Me.txtDestinationEncrypt.ReadOnly = True
        Me.txtDestinationEncrypt.Size = New System.Drawing.Size(184, 20)
        Me.txtDestinationEncrypt.TabIndex = 10
        '
        'btnEncrypt
        '
        Me.btnEncrypt.Enabled = False
        Me.btnEncrypt.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEncrypt.Location = New System.Drawing.Point(296, 72)
        Me.btnEncrypt.Name = "btnEncrypt"
        Me.btnEncrypt.Size = New System.Drawing.Size(72, 32)
        Me.btnEncrypt.TabIndex = 8
        Me.btnEncrypt.Text = "Enkripsi"
        '
        'txtConPassEncrypt
        '
        Me.txtConPassEncrypt.Location = New System.Drawing.Point(104, 88)
        Me.txtConPassEncrypt.Name = "txtConPassEncrypt"
        Me.txtConPassEncrypt.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtConPassEncrypt.Size = New System.Drawing.Size(184, 20)
        Me.txtConPassEncrypt.TabIndex = 7
        '
        'txtPassEncrypt
        '
        Me.txtPassEncrypt.Location = New System.Drawing.Point(104, 64)
        Me.txtPassEncrypt.Name = "txtPassEncrypt"
        Me.txtPassEncrypt.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPassEncrypt.Size = New System.Drawing.Size(184, 20)
        Me.txtPassEncrypt.TabIndex = 6
        '
        'btnBrowseEncrypt
        '
        Me.btnBrowseEncrypt.Location = New System.Drawing.Point(296, 8)
        Me.btnBrowseEncrypt.Name = "btnBrowseEncrypt"
        Me.btnBrowseEncrypt.Size = New System.Drawing.Size(72, 21)
        Me.btnBrowseEncrypt.TabIndex = 2
        Me.btnBrowseEncrypt.Text = "Cari"
        '
        'txtFileToEncrypt
        '
        Me.txtFileToEncrypt.Location = New System.Drawing.Point(104, 8)
        Me.txtFileToEncrypt.Name = "txtFileToEncrypt"
        Me.txtFileToEncrypt.ReadOnly = True
        Me.txtFileToEncrypt.Size = New System.Drawing.Size(184, 20)
        Me.txtFileToEncrypt.TabIndex = 1
        Me.txtFileToEncrypt.Text = "Carilah File Yang Akan di Enkripsi"
        '
        'TabPage2
        '
        Me.TabPage2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.TabPage2.Controls.Add(Me.btnChangeDecrypt)
        Me.TabPage2.Controls.Add(Me.txtDestinationDecrypt)
        Me.TabPage2.Controls.Add(Me.Label5)
        Me.TabPage2.Controls.Add(Me.btnDecrypt)
        Me.TabPage2.Controls.Add(Me.txtConPassDecrypt)
        Me.TabPage2.Controls.Add(Me.txtPassDecrypt)
        Me.TabPage2.Controls.Add(Me.Label6)
        Me.TabPage2.Controls.Add(Me.Label7)
        Me.TabPage2.Controls.Add(Me.Label8)
        Me.TabPage2.Controls.Add(Me.btnBrowseDecrypt)
        Me.TabPage2.Controls.Add(Me.txtFileToDecrypt)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Size = New System.Drawing.Size(376, 118)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Decrypt File"
        '
        'btnChangeDecrypt
        '
        Me.btnChangeDecrypt.Enabled = False
        Me.btnChangeDecrypt.Location = New System.Drawing.Point(296, 32)
        Me.btnChangeDecrypt.Name = "btnChangeDecrypt"
        Me.btnChangeDecrypt.Size = New System.Drawing.Size(72, 21)
        Me.btnChangeDecrypt.TabIndex = 22
        Me.btnChangeDecrypt.Text = "Target"
        '
        'txtDestinationDecrypt
        '
        Me.txtDestinationDecrypt.Location = New System.Drawing.Point(104, 32)
        Me.txtDestinationDecrypt.Name = "txtDestinationDecrypt"
        Me.txtDestinationDecrypt.ReadOnly = True
        Me.txtDestinationDecrypt.Size = New System.Drawing.Size(184, 20)
        Me.txtDestinationDecrypt.TabIndex = 21
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(8, 32)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(88, 16)
        Me.Label5.TabIndex = 20
        Me.Label5.Text = "File destination:"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnDecrypt
        '
        Me.btnDecrypt.Enabled = False
        Me.btnDecrypt.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDecrypt.Location = New System.Drawing.Point(296, 72)
        Me.btnDecrypt.Name = "btnDecrypt"
        Me.btnDecrypt.Size = New System.Drawing.Size(72, 32)
        Me.btnDecrypt.TabIndex = 19
        Me.btnDecrypt.Text = "Dekripsi"
        '
        'txtConPassDecrypt
        '
        Me.txtConPassDecrypt.Location = New System.Drawing.Point(104, 88)
        Me.txtConPassDecrypt.Name = "txtConPassDecrypt"
        Me.txtConPassDecrypt.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtConPassDecrypt.Size = New System.Drawing.Size(184, 20)
        Me.txtConPassDecrypt.TabIndex = 18
        '
        'txtPassDecrypt
        '
        Me.txtPassDecrypt.Location = New System.Drawing.Point(104, 64)
        Me.txtPassDecrypt.Name = "txtPassDecrypt"
        Me.txtPassDecrypt.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPassDecrypt.Size = New System.Drawing.Size(184, 20)
        Me.txtPassDecrypt.TabIndex = 17
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(16, 8)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(80, 16)
        Me.Label6.TabIndex = 16
        Me.Label6.Text = "File to decrypt:"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(-8, 88)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(104, 16)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "Confirm password:"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label8
        '
        Me.Label8.Location = New System.Drawing.Point(8, 64)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(88, 16)
        Me.Label8.TabIndex = 14
        Me.Label8.Text = "Type password:"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnBrowseDecrypt
        '
        Me.btnBrowseDecrypt.Location = New System.Drawing.Point(296, 8)
        Me.btnBrowseDecrypt.Name = "btnBrowseDecrypt"
        Me.btnBrowseDecrypt.Size = New System.Drawing.Size(72, 21)
        Me.btnBrowseDecrypt.TabIndex = 13
        Me.btnBrowseDecrypt.Text = "Cari"
        '
        'txtFileToDecrypt
        '
        Me.txtFileToDecrypt.Location = New System.Drawing.Point(104, 8)
        Me.txtFileToDecrypt.Name = "txtFileToDecrypt"
        Me.txtFileToDecrypt.ReadOnly = True
        Me.txtFileToDecrypt.Size = New System.Drawing.Size(184, 20)
        Me.txtFileToDecrypt.TabIndex = 12
        Me.txtFileToDecrypt.Text = "Carilah File Yang Akan di Dekripsi"
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(386, 147)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "Form2"
        Me.Text = "Encrypt / Decrypt File"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btnChangeEncrypt As Button
    Friend WithEvents txtDestinationEncrypt As TextBox
    Friend WithEvents btnEncrypt As Button
    Friend WithEvents txtConPassEncrypt As TextBox
    Friend WithEvents txtPassEncrypt As TextBox
    Friend WithEvents btnBrowseEncrypt As Button
    Friend WithEvents txtFileToEncrypt As TextBox
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents btnChangeDecrypt As Button
    Friend WithEvents txtDestinationDecrypt As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents btnDecrypt As Button
    Friend WithEvents txtConPassDecrypt As TextBox
    Friend WithEvents txtPassDecrypt As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents btnBrowseDecrypt As Button
    Friend WithEvents txtFileToDecrypt As TextBox
End Class
