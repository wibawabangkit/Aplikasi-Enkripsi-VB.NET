<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Caesar
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
        Me.btndeskripsi = New System.Windows.Forms.Button()
        Me.plain = New System.Windows.Forms.TextBox()
        Me.chiper = New System.Windows.Forms.TextBox()
        Me.btnenkripsi = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btndeskripsi
        '
        Me.btndeskripsi.Location = New System.Drawing.Point(492, 156)
        Me.btndeskripsi.Name = "btndeskripsi"
        Me.btndeskripsi.Size = New System.Drawing.Size(75, 23)
        Me.btndeskripsi.TabIndex = 0
        Me.btndeskripsi.Text = "Deskripsi"
        Me.btndeskripsi.UseVisualStyleBackColor = True
        '
        'plain
        '
        Me.plain.Location = New System.Drawing.Point(129, 51)
        Me.plain.Name = "plain"
        Me.plain.Size = New System.Drawing.Size(535, 20)
        Me.plain.TabIndex = 1
        '
        'chiper
        '
        Me.chiper.Location = New System.Drawing.Point(129, 95)
        Me.chiper.Name = "chiper"
        Me.chiper.Size = New System.Drawing.Size(535, 20)
        Me.chiper.TabIndex = 2
        '
        'btnenkripsi
        '
        Me.btnenkripsi.Location = New System.Drawing.Point(196, 156)
        Me.btnenkripsi.Name = "btnenkripsi"
        Me.btnenkripsi.Size = New System.Drawing.Size(75, 23)
        Me.btnenkripsi.TabIndex = 3
        Me.btnenkripsi.Text = "Enkripsi"
        Me.btnenkripsi.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(23, 58)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(54, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Plain Text"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(23, 98)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Chiper Text"
        '
        'Kryptografi1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(694, 196)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnenkripsi)
        Me.Controls.Add(Me.chiper)
        Me.Controls.Add(Me.plain)
        Me.Controls.Add(Me.btndeskripsi)
        Me.Name = "Kryptografi1"
        Me.Text = "Kryptografi1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btndeskripsi As Button
    Friend WithEvents plain As TextBox
    Friend WithEvents chiper As TextBox
    Friend WithEvents btnenkripsi As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
End Class
