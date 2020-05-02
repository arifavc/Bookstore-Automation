<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form4
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
        Me.components = New System.ComponentModel.Container()
        Me.Label1 = New MaterialSkin.Controls.MaterialLabel()
        Me.Label2 = New MaterialSkin.Controls.MaterialLabel()
        Me.TextBox1 = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.TextBox2 = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.Button1 = New MaterialSkin.Controls.MaterialFlatButton()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Label3 = New MaterialSkin.Controls.MaterialLabel()
        Me.MaterialLabel1 = New MaterialSkin.Controls.MaterialLabel()
        Me.RadioButton1 = New MaterialSkin.Controls.MaterialRadioButton()
        Me.RadioButton2 = New MaterialSkin.Controls.MaterialRadioButton()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Depth = 0
        Me.Label1.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(44, 117)
        Me.Label1.MouseState = MaterialSkin.MouseState.HOVER
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(77, 19)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Username"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Depth = 0
        Me.Label2.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(43, 151)
        Me.Label2.MouseState = MaterialSkin.MouseState.HOVER
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(75, 19)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Password"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TextBox1
        '
        Me.TextBox1.Depth = 0
        Me.TextBox1.Hint = ""
        Me.TextBox1.Location = New System.Drawing.Point(144, 112)
        Me.TextBox1.MouseState = MaterialSkin.MouseState.HOVER
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TextBox1.SelectedText = ""
        Me.TextBox1.SelectionLength = 0
        Me.TextBox1.SelectionStart = 0
        Me.TextBox1.Size = New System.Drawing.Size(139, 23)
        Me.TextBox1.TabIndex = 1
        Me.TextBox1.UseSystemPasswordChar = False
        '
        'TextBox2
        '
        Me.TextBox2.Depth = 0
        Me.TextBox2.Hint = ""
        Me.TextBox2.Location = New System.Drawing.Point(144, 147)
        Me.TextBox2.MouseState = MaterialSkin.MouseState.HOVER
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TextBox2.SelectedText = ""
        Me.TextBox2.SelectionLength = 0
        Me.TextBox2.SelectionStart = 0
        Me.TextBox2.Size = New System.Drawing.Size(139, 23)
        Me.TextBox2.TabIndex = 2
        Me.TextBox2.UseSystemPasswordChar = False
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(80, 267)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(230, 29)
        Me.ProgressBar1.TabIndex = 3
        '
        'Button1
        '
        Me.Button1.AutoSize = True
        Me.Button1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Button1.Depth = 0
        Me.Button1.Location = New System.Drawing.Point(306, 124)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.Button1.MouseState = MaterialSkin.MouseState.HOVER
        Me.Button1.Name = "Button1"
        Me.Button1.Primary = False
        Me.Button1.Size = New System.Drawing.Size(52, 36)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "LOGIN"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Depth = 0
        Me.Label3.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(173, 241)
        Me.Label3.MouseState = MaterialSkin.MouseState.HOVER
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(53, 19)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Label3"
        '
        'MaterialLabel1
        '
        Me.MaterialLabel1.AutoSize = True
        Me.MaterialLabel1.Depth = 0
        Me.MaterialLabel1.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.MaterialLabel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialLabel1.Location = New System.Drawing.Point(43, 197)
        Me.MaterialLabel1.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel1.Name = "MaterialLabel1"
        Me.MaterialLabel1.Size = New System.Drawing.Size(67, 19)
        Me.MaterialLabel1.TabIndex = 6
        Me.MaterialLabel1.Text = "Thema : "
        '
        'RadioButton1
        '
        Me.RadioButton1.Depth = 0
        Me.RadioButton1.Font = New System.Drawing.Font("Roboto", 10.0!)
        Me.RadioButton1.Location = New System.Drawing.Point(120, 192)
        Me.RadioButton1.Margin = New System.Windows.Forms.Padding(0)
        Me.RadioButton1.MouseLocation = New System.Drawing.Point(-1, -1)
        Me.RadioButton1.MouseState = MaterialSkin.MouseState.HOVER
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Ripple = True
        Me.RadioButton1.Size = New System.Drawing.Size(106, 30)
        Me.RadioButton1.TabIndex = 7
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "Dark"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'RadioButton2
        '
        Me.RadioButton2.Depth = 0
        Me.RadioButton2.Font = New System.Drawing.Font("Roboto", 10.0!)
        Me.RadioButton2.Location = New System.Drawing.Point(243, 192)
        Me.RadioButton2.Margin = New System.Windows.Forms.Padding(0)
        Me.RadioButton2.MouseLocation = New System.Drawing.Point(-1, -1)
        Me.RadioButton2.MouseState = MaterialSkin.MouseState.HOVER
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Ripple = True
        Me.RadioButton2.Size = New System.Drawing.Size(106, 30)
        Me.RadioButton2.TabIndex = 7
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Text = "Light"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'Form4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(415, 308)
        Me.Controls.Add(Me.RadioButton2)
        Me.Controls.Add(Me.RadioButton1)
        Me.Controls.Add(Me.MaterialLabel1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form4"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents Label2 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents TextBox1 As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents TextBox2 As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents Button1 As MaterialSkin.Controls.MaterialFlatButton
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Label3 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents MaterialLabel1 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents RadioButton1 As MaterialSkin.Controls.MaterialRadioButton
    Friend WithEvents RadioButton2 As MaterialSkin.Controls.MaterialRadioButton
End Class
