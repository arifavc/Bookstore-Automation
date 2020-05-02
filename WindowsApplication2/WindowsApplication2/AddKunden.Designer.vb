<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddKunden
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AddKunden))
        Me.Label5 = New MaterialSkin.Controls.MaterialLabel()
        Me.Label4 = New MaterialSkin.Controls.MaterialLabel()
        Me.Label3 = New MaterialSkin.Controls.MaterialLabel()
        Me.Label2 = New MaterialSkin.Controls.MaterialLabel()
        Me.Label1 = New MaterialSkin.Controls.MaterialLabel()
        Me.TextBox5 = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.TextBox4 = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.TextBox3 = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.TextBox2 = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.TextBox1 = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.Button2 = New MaterialSkin.Controls.MaterialFlatButton()
        Me.Button1 = New MaterialSkin.Controls.MaterialFlatButton()
        Me.TextBox6 = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.MaterialLabel1 = New MaterialSkin.Controls.MaterialLabel()
        Me.TextBox7 = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.TextBox8 = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.MaterialLabel2 = New MaterialSkin.Controls.MaterialLabel()
        Me.MaterialLabel3 = New MaterialSkin.Controls.MaterialLabel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Depth = 0
        Me.Label5.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(28, 246)
        Me.Label5.MouseState = MaterialSkin.MouseState.HOVER
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(53, 19)
        Me.Label5.TabIndex = 33
        Me.Label5.Text = "Straße"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Depth = 0
        Me.Label4.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(28, 207)
        Me.Label4.MouseState = MaterialSkin.MouseState.HOVER
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(29, 19)
        Me.Label4.TabIndex = 32
        Me.Label4.Text = "Ort"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Depth = 0
        Me.Label3.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(28, 167)
        Me.Label3.MouseState = MaterialSkin.MouseState.HOVER
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(81, 19)
        Me.Label3.TabIndex = 31
        Me.Label3.Text = "Nachname"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Depth = 0
        Me.Label2.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(28, 127)
        Me.Label2.MouseState = MaterialSkin.MouseState.HOVER
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(70, 19)
        Me.Label2.TabIndex = 30
        Me.Label2.Text = "Vorname"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Depth = 0
        Me.Label1.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(28, 91)
        Me.Label1.MouseState = MaterialSkin.MouseState.HOVER
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 19)
        Me.Label1.TabIndex = 29
        Me.Label1.Text = "KundenID"
        '
        'TextBox5
        '
        Me.TextBox5.Depth = 0
        Me.TextBox5.Hint = ""
        Me.TextBox5.Location = New System.Drawing.Point(117, 244)
        Me.TextBox5.MouseState = MaterialSkin.MouseState.HOVER
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TextBox5.SelectedText = ""
        Me.TextBox5.SelectionLength = 0
        Me.TextBox5.SelectionStart = 0
        Me.TextBox5.Size = New System.Drawing.Size(121, 23)
        Me.TextBox5.TabIndex = 26
        Me.TextBox5.UseSystemPasswordChar = False
        '
        'TextBox4
        '
        Me.TextBox4.Depth = 0
        Me.TextBox4.Hint = ""
        Me.TextBox4.Location = New System.Drawing.Point(117, 203)
        Me.TextBox4.MouseState = MaterialSkin.MouseState.HOVER
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TextBox4.SelectedText = ""
        Me.TextBox4.SelectionLength = 0
        Me.TextBox4.SelectionStart = 0
        Me.TextBox4.Size = New System.Drawing.Size(121, 23)
        Me.TextBox4.TabIndex = 25
        Me.TextBox4.UseSystemPasswordChar = False
        '
        'TextBox3
        '
        Me.TextBox3.Depth = 0
        Me.TextBox3.Hint = ""
        Me.TextBox3.Location = New System.Drawing.Point(117, 165)
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
        'TextBox2
        '
        Me.TextBox2.Depth = 0
        Me.TextBox2.Hint = ""
        Me.TextBox2.Location = New System.Drawing.Point(117, 125)
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
        'TextBox1
        '
        Me.TextBox1.Depth = 0
        Me.TextBox1.Hint = ""
        Me.TextBox1.Location = New System.Drawing.Point(117, 89)
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
        'Button2
        '
        Me.Button2.AutoSize = True
        Me.Button2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Button2.Depth = 0
        Me.Button2.Location = New System.Drawing.Point(266, 209)
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
        Me.Button1.Location = New System.Drawing.Point(266, 162)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.Button1.MouseState = MaterialSkin.MouseState.HOVER
        Me.Button1.Name = "Button1"
        Me.Button1.Primary = False
        Me.Button1.Size = New System.Drawing.Size(30, 36)
        Me.Button1.TabIndex = 20
        Me.Button1.Text = "OK"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TextBox6
        '
        Me.TextBox6.Depth = 0
        Me.TextBox6.Hint = ""
        Me.TextBox6.Location = New System.Drawing.Point(117, 281)
        Me.TextBox6.MouseState = MaterialSkin.MouseState.HOVER
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TextBox6.SelectedText = ""
        Me.TextBox6.SelectionLength = 0
        Me.TextBox6.SelectionStart = 0
        Me.TextBox6.Size = New System.Drawing.Size(121, 23)
        Me.TextBox6.TabIndex = 26
        Me.TextBox6.UseSystemPasswordChar = False
        '
        'MaterialLabel1
        '
        Me.MaterialLabel1.AutoSize = True
        Me.MaterialLabel1.Depth = 0
        Me.MaterialLabel1.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.MaterialLabel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialLabel1.Location = New System.Drawing.Point(28, 284)
        Me.MaterialLabel1.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel1.Name = "MaterialLabel1"
        Me.MaterialLabel1.Size = New System.Drawing.Size(35, 19)
        Me.MaterialLabel1.TabIndex = 33
        Me.MaterialLabel1.Text = "PLZ"
        '
        'TextBox7
        '
        Me.TextBox7.Depth = 0
        Me.TextBox7.Hint = ""
        Me.TextBox7.Location = New System.Drawing.Point(117, 317)
        Me.TextBox7.MouseState = MaterialSkin.MouseState.HOVER
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TextBox7.SelectedText = ""
        Me.TextBox7.SelectionLength = 0
        Me.TextBox7.SelectionStart = 0
        Me.TextBox7.Size = New System.Drawing.Size(121, 23)
        Me.TextBox7.TabIndex = 26
        Me.TextBox7.UseSystemPasswordChar = False
        '
        'TextBox8
        '
        Me.TextBox8.Depth = 0
        Me.TextBox8.Hint = ""
        Me.TextBox8.Location = New System.Drawing.Point(117, 354)
        Me.TextBox8.MouseState = MaterialSkin.MouseState.HOVER
        Me.TextBox8.Name = "TextBox8"
        Me.TextBox8.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TextBox8.SelectedText = ""
        Me.TextBox8.SelectionLength = 0
        Me.TextBox8.SelectionStart = 0
        Me.TextBox8.Size = New System.Drawing.Size(121, 23)
        Me.TextBox8.TabIndex = 26
        Me.TextBox8.UseSystemPasswordChar = False
        '
        'MaterialLabel2
        '
        Me.MaterialLabel2.AutoSize = True
        Me.MaterialLabel2.Depth = 0
        Me.MaterialLabel2.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.MaterialLabel2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialLabel2.Location = New System.Drawing.Point(28, 355)
        Me.MaterialLabel2.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel2.Name = "MaterialLabel2"
        Me.MaterialLabel2.Size = New System.Drawing.Size(60, 19)
        Me.MaterialLabel2.TabIndex = 33
        Me.MaterialLabel2.Text = "Telefon"
        '
        'MaterialLabel3
        '
        Me.MaterialLabel3.AutoSize = True
        Me.MaterialLabel3.Depth = 0
        Me.MaterialLabel3.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.MaterialLabel3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialLabel3.Location = New System.Drawing.Point(28, 321)
        Me.MaterialLabel3.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel3.Name = "MaterialLabel3"
        Me.MaterialLabel3.Size = New System.Drawing.Size(47, 19)
        Me.MaterialLabel3.TabIndex = 33
        Me.MaterialLabel3.Text = "Email"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(266, 91)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(100, 50)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 34
        Me.PictureBox1.TabStop = False
        '
        'AddKunden
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(383, 419)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.MaterialLabel3)
        Me.Controls.Add(Me.MaterialLabel2)
        Me.Controls.Add(Me.MaterialLabel1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TextBox8)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TextBox6)
        Me.Controls.Add(Me.TextBox7)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBox5)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Name = "AddKunden"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "AddKunden"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label5 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents Label4 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents Label3 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents Label2 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents Label1 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents TextBox5 As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents TextBox4 As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents TextBox3 As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents TextBox2 As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents TextBox1 As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents Button2 As MaterialSkin.Controls.MaterialFlatButton
    Friend WithEvents Button1 As MaterialSkin.Controls.MaterialFlatButton
    Friend WithEvents TextBox6 As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents MaterialLabel1 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents TextBox7 As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents TextBox8 As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents MaterialLabel2 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents MaterialLabel3 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents PictureBox1 As PictureBox
End Class
