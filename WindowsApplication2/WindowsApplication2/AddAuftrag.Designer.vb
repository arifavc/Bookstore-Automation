<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddAuftrag
    Inherits MaterialSkin.Controls.MaterialForm
    'Form, bileşen listesini temizlemeyi bırakmayı geçersiz kılar.
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

    'Windows Form Tasarımcısı tarafından gerektirilir
    Private components As System.ComponentModel.IContainer

    'NOT: Aşağıdaki yordam Windows Form Tasarımcısı için gereklidir
    'Windows Form Tasarımcısı kullanılarak değiştirilebilir.  
    'Kod düzenleyicisini kullanarak değiştirmeyin.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Button2 = New MaterialSkin.Controls.MaterialFlatButton()
        Me.Button1 = New MaterialSkin.Controls.MaterialFlatButton()
        Me.TextBox1 = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.TextBox2 = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.TextBox3 = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.Label1 = New MaterialSkin.Controls.MaterialLabel()
        Me.Label2 = New MaterialSkin.Controls.MaterialLabel()
        Me.Label3 = New MaterialSkin.Controls.MaterialLabel()
        Me.Label4 = New MaterialSkin.Controls.MaterialLabel()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.SuspendLayout()
        '
        'Button2
        '
        Me.Button2.AutoSize = True
        Me.Button2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Button2.Depth = 0
        Me.Button2.Location = New System.Drawing.Point(287, 160)
        Me.Button2.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.Button2.MouseState = MaterialSkin.MouseState.HOVER
        Me.Button2.Name = "Button2"
        Me.Button2.Primary = False
        Me.Button2.Size = New System.Drawing.Size(64, 36)
        Me.Button2.TabIndex = 21
        Me.Button2.Text = "Cancel"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.AutoSize = True
        Me.Button1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Button1.Depth = 0
        Me.Button1.Location = New System.Drawing.Point(287, 112)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.Button1.MouseState = MaterialSkin.MouseState.HOVER
        Me.Button1.Name = "Button1"
        Me.Button1.Primary = False
        Me.Button1.Size = New System.Drawing.Size(30, 36)
        Me.Button1.TabIndex = 20
        Me.Button1.Text = "OK"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Depth = 0
        Me.TextBox1.Hint = ""
        Me.TextBox1.Location = New System.Drawing.Point(120, 91)
        Me.TextBox1.MouseState = MaterialSkin.MouseState.HOVER
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TextBox1.SelectedText = ""
        Me.TextBox1.SelectionLength = 0
        Me.TextBox1.SelectionStart = 0
        Me.TextBox1.Size = New System.Drawing.Size(121, 23)
        Me.TextBox1.TabIndex = 22
        Me.TextBox1.UseSystemPasswordChar = False
        '
        'TextBox2
        '
        Me.TextBox2.Depth = 0
        Me.TextBox2.Hint = ""
        Me.TextBox2.Location = New System.Drawing.Point(120, 127)
        Me.TextBox2.MouseState = MaterialSkin.MouseState.HOVER
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TextBox2.SelectedText = ""
        Me.TextBox2.SelectionLength = 0
        Me.TextBox2.SelectionStart = 0
        Me.TextBox2.Size = New System.Drawing.Size(121, 23)
        Me.TextBox2.TabIndex = 23
        Me.TextBox2.UseSystemPasswordChar = False
        '
        'TextBox3
        '
        Me.TextBox3.Depth = 0
        Me.TextBox3.Hint = ""
        Me.TextBox3.Location = New System.Drawing.Point(120, 167)
        Me.TextBox3.MouseState = MaterialSkin.MouseState.HOVER
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TextBox3.SelectedText = ""
        Me.TextBox3.SelectionLength = 0
        Me.TextBox3.SelectionStart = 0
        Me.TextBox3.Size = New System.Drawing.Size(121, 23)
        Me.TextBox3.TabIndex = 24
        Me.TextBox3.UseSystemPasswordChar = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Depth = 0
        Me.Label1.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(49, 93)
        Me.Label1.MouseState = MaterialSkin.MouseState.HOVER
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 19)
        Me.Label1.TabIndex = 29
        Me.Label1.Text = "AuftragID"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Depth = 0
        Me.Label2.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(49, 129)
        Me.Label2.MouseState = MaterialSkin.MouseState.HOVER
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(39, 19)
        Me.Label2.TabIndex = 30
        Me.Label2.Text = "Titel"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Depth = 0
        Me.Label3.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(49, 169)
        Me.Label3.MouseState = MaterialSkin.MouseState.HOVER
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(43, 19)
        Me.Label3.TabIndex = 31
        Me.Label3.Text = "Preis"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Depth = 0
        Me.Label4.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(49, 209)
        Me.Label4.MouseState = MaterialSkin.MouseState.HOVER
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(53, 19)
        Me.Label4.TabIndex = 32
        Me.Label4.Text = "Datum"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.Location = New System.Drawing.Point(117, 211)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(124, 20)
        Me.DateTimePicker1.TabIndex = 33
        '
        'AddAuftrag
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(419, 401)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Name = "AddAuftrag"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "AddAuftrag"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button2 As MaterialSkin.Controls.MaterialFlatButton
    Friend WithEvents Button1 As MaterialSkin.Controls.MaterialFlatButton
    Friend WithEvents TextBox1 As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents TextBox2 As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents TextBox3 As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents Label1 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents Label2 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents Label3 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents Label4 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents DateTimePicker1 As DateTimePicker
End Class
