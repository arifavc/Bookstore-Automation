<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form3
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
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.KundenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VerlagToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AuftragToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BuchlistToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AutorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MaterialLabel3 = New MaterialSkin.Controls.MaterialLabel()
        Me.MaterialLabel2 = New MaterialSkin.Controls.MaterialLabel()
        Me.MaterialLabel1 = New MaterialSkin.Controls.MaterialLabel()
        Me.Label5 = New MaterialSkin.Controls.MaterialLabel()
        Me.Label4 = New MaterialSkin.Controls.MaterialLabel()
        Me.Label3 = New MaterialSkin.Controls.MaterialLabel()
        Me.TextBox8 = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.Label2 = New MaterialSkin.Controls.MaterialLabel()
        Me.TextBox6 = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.TextBox7 = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.Label1 = New MaterialSkin.Controls.MaterialLabel()
        Me.TextBox5 = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.TextBox4 = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.TextBox3 = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.TextBox2 = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.TextBox1 = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.Panel1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(676, 71)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 9
        Me.Button2.Text = "Insert"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(579, 71)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 8
        Me.Button1.Text = "Refresh"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.MaterialLabel3)
        Me.Panel1.Controls.Add(Me.MaterialLabel2)
        Me.Panel1.Controls.Add(Me.MaterialLabel1)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Button3)
        Me.Panel1.Controls.Add(Me.Button5)
        Me.Panel1.Controls.Add(Me.Button4)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.TextBox8)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.TextBox6)
        Me.Panel1.Controls.Add(Me.TextBox7)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.TextBox5)
        Me.Panel1.Controls.Add(Me.TextBox4)
        Me.Panel1.Controls.Add(Me.TextBox3)
        Me.Panel1.Controls.Add(Me.TextBox2)
        Me.Panel1.Controls.Add(Me.TextBox1)
        Me.Panel1.Location = New System.Drawing.Point(533, 100)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(242, 347)
        Me.Panel1.TabIndex = 7
        Me.Panel1.Visible = False
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(164, 315)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(75, 23)
        Me.Button5.TabIndex = 10
        Me.Button5.Text = "Cancel"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(82, 314)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(75, 23)
        Me.Button4.TabIndex = 9
        Me.Button4.Text = "Delete"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(1, 314)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 8
        Me.Button3.Text = "Update"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(0, 62)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(527, 385)
        Me.DataGridView1.TabIndex = 6
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.MenuStrip1.AutoSize = False
        Me.MenuStrip1.Dock = System.Windows.Forms.DockStyle.None
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.KundenToolStripMenuItem, Me.VerlagToolStripMenuItem, Me.AuftragToolStripMenuItem, Me.BuchlistToolStripMenuItem, Me.AutorToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(3, 1)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(702, 24)
        Me.MenuStrip1.TabIndex = 10
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'KundenToolStripMenuItem
        '
        Me.KundenToolStripMenuItem.Name = "KundenToolStripMenuItem"
        Me.KundenToolStripMenuItem.Size = New System.Drawing.Size(60, 20)
        Me.KundenToolStripMenuItem.Text = "Kunden"
        '
        'VerlagToolStripMenuItem
        '
        Me.VerlagToolStripMenuItem.Name = "VerlagToolStripMenuItem"
        Me.VerlagToolStripMenuItem.Size = New System.Drawing.Size(51, 20)
        Me.VerlagToolStripMenuItem.Text = "Verlag"
        '
        'AuftragToolStripMenuItem
        '
        Me.AuftragToolStripMenuItem.Name = "AuftragToolStripMenuItem"
        Me.AuftragToolStripMenuItem.Size = New System.Drawing.Size(59, 20)
        Me.AuftragToolStripMenuItem.Text = "Auftrag"
        '
        'BuchlistToolStripMenuItem
        '
        Me.BuchlistToolStripMenuItem.Name = "BuchlistToolStripMenuItem"
        Me.BuchlistToolStripMenuItem.Size = New System.Drawing.Size(46, 20)
        Me.BuchlistToolStripMenuItem.Text = "Buch"
        '
        'AutorToolStripMenuItem
        '
        Me.AutorToolStripMenuItem.Name = "AutorToolStripMenuItem"
        Me.AutorToolStripMenuItem.Size = New System.Drawing.Size(49, 20)
        Me.AutorToolStripMenuItem.Text = "Autor"
        '
        'MaterialLabel3
        '
        Me.MaterialLabel3.AutoSize = True
        Me.MaterialLabel3.Depth = 0
        Me.MaterialLabel3.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.MaterialLabel3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialLabel3.Location = New System.Drawing.Point(3, 244)
        Me.MaterialLabel3.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel3.Name = "MaterialLabel3"
        Me.MaterialLabel3.Size = New System.Drawing.Size(47, 19)
        Me.MaterialLabel3.TabIndex = 46
        Me.MaterialLabel3.Text = "Email"
        '
        'MaterialLabel2
        '
        Me.MaterialLabel2.AutoSize = True
        Me.MaterialLabel2.Depth = 0
        Me.MaterialLabel2.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.MaterialLabel2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialLabel2.Location = New System.Drawing.Point(3, 278)
        Me.MaterialLabel2.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel2.Name = "MaterialLabel2"
        Me.MaterialLabel2.Size = New System.Drawing.Size(60, 19)
        Me.MaterialLabel2.TabIndex = 47
        Me.MaterialLabel2.Text = "Telefon"
        '
        'MaterialLabel1
        '
        Me.MaterialLabel1.AutoSize = True
        Me.MaterialLabel1.Depth = 0
        Me.MaterialLabel1.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.MaterialLabel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialLabel1.Location = New System.Drawing.Point(3, 207)
        Me.MaterialLabel1.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel1.Name = "MaterialLabel1"
        Me.MaterialLabel1.Size = New System.Drawing.Size(35, 19)
        Me.MaterialLabel1.TabIndex = 48
        Me.MaterialLabel1.Text = "PLZ"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Depth = 0
        Me.Label5.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(3, 169)
        Me.Label5.MouseState = MaterialSkin.MouseState.HOVER
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(53, 19)
        Me.Label5.TabIndex = 49
        Me.Label5.Text = "Straße"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Depth = 0
        Me.Label4.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(3, 130)
        Me.Label4.MouseState = MaterialSkin.MouseState.HOVER
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(29, 19)
        Me.Label4.TabIndex = 45
        Me.Label4.Text = "Ort"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Depth = 0
        Me.Label3.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(3, 90)
        Me.Label3.MouseState = MaterialSkin.MouseState.HOVER
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(81, 19)
        Me.Label3.TabIndex = 44
        Me.Label3.Text = "Nachname"
        '
        'TextBox8
        '
        Me.TextBox8.Depth = 0
        Me.TextBox8.Hint = ""
        Me.TextBox8.Location = New System.Drawing.Point(82, 278)
        Me.TextBox8.MouseState = MaterialSkin.MouseState.HOVER
        Me.TextBox8.Name = "TextBox8"
        Me.TextBox8.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TextBox8.SelectedText = ""
        Me.TextBox8.SelectionLength = 0
        Me.TextBox8.SelectionStart = 0
        Me.TextBox8.Size = New System.Drawing.Size(146, 23)
        Me.TextBox8.TabIndex = 38
        Me.TextBox8.UseSystemPasswordChar = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Depth = 0
        Me.Label2.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(3, 46)
        Me.Label2.MouseState = MaterialSkin.MouseState.HOVER
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(70, 19)
        Me.Label2.TabIndex = 43
        Me.Label2.Text = "Vorname"
        '
        'TextBox6
        '
        Me.TextBox6.Depth = 0
        Me.TextBox6.Hint = ""
        Me.TextBox6.Location = New System.Drawing.Point(82, 203)
        Me.TextBox6.MouseState = MaterialSkin.MouseState.HOVER
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TextBox6.SelectedText = ""
        Me.TextBox6.SelectionLength = 0
        Me.TextBox6.SelectionStart = 0
        Me.TextBox6.Size = New System.Drawing.Size(146, 23)
        Me.TextBox6.TabIndex = 39
        Me.TextBox6.UseSystemPasswordChar = False
        '
        'TextBox7
        '
        Me.TextBox7.Depth = 0
        Me.TextBox7.Hint = ""
        Me.TextBox7.Location = New System.Drawing.Point(82, 240)
        Me.TextBox7.MouseState = MaterialSkin.MouseState.HOVER
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TextBox7.SelectedText = ""
        Me.TextBox7.SelectionLength = 0
        Me.TextBox7.SelectionStart = 0
        Me.TextBox7.Size = New System.Drawing.Size(146, 23)
        Me.TextBox7.TabIndex = 40
        Me.TextBox7.UseSystemPasswordChar = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Depth = 0
        Me.Label1.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(3, 10)
        Me.Label1.MouseState = MaterialSkin.MouseState.HOVER
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 19)
        Me.Label1.TabIndex = 42
        Me.Label1.Text = "KundenID"
        '
        'TextBox5
        '
        Me.TextBox5.Depth = 0
        Me.TextBox5.Hint = ""
        Me.TextBox5.Location = New System.Drawing.Point(82, 165)
        Me.TextBox5.MouseState = MaterialSkin.MouseState.HOVER
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TextBox5.SelectedText = ""
        Me.TextBox5.SelectionLength = 0
        Me.TextBox5.SelectionStart = 0
        Me.TextBox5.Size = New System.Drawing.Size(146, 23)
        Me.TextBox5.TabIndex = 41
        Me.TextBox5.UseSystemPasswordChar = False
        '
        'TextBox4
        '
        Me.TextBox4.Depth = 0
        Me.TextBox4.Hint = ""
        Me.TextBox4.Location = New System.Drawing.Point(85, 126)
        Me.TextBox4.MouseState = MaterialSkin.MouseState.HOVER
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TextBox4.SelectedText = ""
        Me.TextBox4.SelectionLength = 0
        Me.TextBox4.SelectionStart = 0
        Me.TextBox4.Size = New System.Drawing.Size(143, 23)
        Me.TextBox4.TabIndex = 37
        Me.TextBox4.UseSystemPasswordChar = False
        '
        'TextBox3
        '
        Me.TextBox3.Depth = 0
        Me.TextBox3.Hint = ""
        Me.TextBox3.Location = New System.Drawing.Point(90, 86)
        Me.TextBox3.MouseState = MaterialSkin.MouseState.HOVER
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TextBox3.SelectedText = ""
        Me.TextBox3.SelectionLength = 0
        Me.TextBox3.SelectionStart = 0
        Me.TextBox3.Size = New System.Drawing.Size(138, 23)
        Me.TextBox3.TabIndex = 36
        Me.TextBox3.UseSystemPasswordChar = False
        '
        'TextBox2
        '
        Me.TextBox2.Depth = 0
        Me.TextBox2.Hint = ""
        Me.TextBox2.Location = New System.Drawing.Point(90, 42)
        Me.TextBox2.MouseState = MaterialSkin.MouseState.HOVER
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TextBox2.SelectedText = ""
        Me.TextBox2.SelectionLength = 0
        Me.TextBox2.SelectionStart = 0
        Me.TextBox2.Size = New System.Drawing.Size(138, 23)
        Me.TextBox2.TabIndex = 35
        Me.TextBox2.UseSystemPasswordChar = False
        '
        'TextBox1
        '
        Me.TextBox1.Depth = 0
        Me.TextBox1.Hint = ""
        Me.TextBox1.Location = New System.Drawing.Point(85, 6)
        Me.TextBox1.MouseState = MaterialSkin.MouseState.HOVER
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TextBox1.SelectedText = ""
        Me.TextBox1.SelectionLength = 0
        Me.TextBox1.SelectionStart = 0
        Me.TextBox1.Size = New System.Drawing.Size(143, 23)
        Me.TextBox1.TabIndex = 34
        Me.TextBox1.UseSystemPasswordChar = False
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "Form3"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Kunden"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Button5 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents KundenToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VerlagToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AuftragToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BuchlistToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AutorToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MaterialLabel3 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents MaterialLabel2 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents MaterialLabel1 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents Label5 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents Label4 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents Label3 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents TextBox8 As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents Label2 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents TextBox6 As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents TextBox7 As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents Label1 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents TextBox5 As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents TextBox4 As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents TextBox3 As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents TextBox2 As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents TextBox1 As MaterialSkin.Controls.MaterialSingleLineTextField
End Class
