<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AddAutor
    Inherits MaterialSkin.Controls.MaterialForm

    'Form, bileşen listesini temizlemeyi bırakmayı geçersiz kılar.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Label2 = New MaterialSkin.Controls.MaterialLabel()
        Me.Label1 = New MaterialSkin.Controls.MaterialLabel()
        Me.TextBox2 = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.TextBox1 = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.Button2 = New MaterialSkin.Controls.MaterialFlatButton()
        Me.Button1 = New MaterialSkin.Controls.MaterialFlatButton()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Depth = 0
        Me.Label2.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(23, 135)
        Me.Label2.MouseState = MaterialSkin.MouseState.HOVER
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(86, 19)
        Me.Label2.TabIndex = 36
        Me.Label2.Text = "AutorName"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Depth = 0
        Me.Label1.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(49, 101)
        Me.Label1.MouseState = MaterialSkin.MouseState.HOVER
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(60, 19)
        Me.Label1.TabIndex = 35
        Me.Label1.Text = "AutorID"
        '
        'TextBox2
        '
        Me.TextBox2.Depth = 0
        Me.TextBox2.Hint = ""
        Me.TextBox2.Location = New System.Drawing.Point(120, 135)
        Me.TextBox2.MouseState = MaterialSkin.MouseState.HOVER
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TextBox2.SelectedText = ""
        Me.TextBox2.SelectionLength = 0
        Me.TextBox2.SelectionStart = 0
        Me.TextBox2.Size = New System.Drawing.Size(121, 23)
        Me.TextBox2.TabIndex = 34
        Me.TextBox2.UseSystemPasswordChar = False
        '
        'TextBox1
        '
        Me.TextBox1.Depth = 0
        Me.TextBox1.Hint = ""
        Me.TextBox1.Location = New System.Drawing.Point(120, 99)
        Me.TextBox1.MouseState = MaterialSkin.MouseState.HOVER
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TextBox1.SelectedText = ""
        Me.TextBox1.SelectionLength = 0
        Me.TextBox1.SelectionStart = 0
        Me.TextBox1.Size = New System.Drawing.Size(121, 23)
        Me.TextBox1.TabIndex = 33
        Me.TextBox1.UseSystemPasswordChar = False
        '
        'Button2
        '
        Me.Button2.AutoSize = True
        Me.Button2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Button2.Depth = 0
        Me.Button2.Location = New System.Drawing.Point(133, 196)
        Me.Button2.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.Button2.MouseState = MaterialSkin.MouseState.HOVER
        Me.Button2.Name = "Button2"
        Me.Button2.Primary = False
        Me.Button2.Size = New System.Drawing.Size(64, 36)
        Me.Button2.TabIndex = 32
        Me.Button2.Text = "Cancel"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.AutoSize = True
        Me.Button1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Button1.Depth = 0
        Me.Button1.Location = New System.Drawing.Point(71, 196)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.Button1.MouseState = MaterialSkin.MouseState.HOVER
        Me.Button1.Name = "Button1"
        Me.Button1.Primary = False
        Me.Button1.Size = New System.Drawing.Size(30, 36)
        Me.Button1.TabIndex = 31
        Me.Button1.Text = "OK"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'AddAutor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(301, 254)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Name = "AddAutor"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "AddAutor"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label2 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents Label1 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents TextBox2 As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents TextBox1 As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents Button2 As MaterialSkin.Controls.MaterialFlatButton
    Friend WithEvents Button1 As MaterialSkin.Controls.MaterialFlatButton
End Class
