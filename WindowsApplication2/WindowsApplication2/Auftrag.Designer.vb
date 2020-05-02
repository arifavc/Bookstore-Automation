<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Auftrag
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
        Me.Button1 = New MaterialSkin.Controls.MaterialFlatButton()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.TextBox4 = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.TextBox2 = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.TextBox1 = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.Label4 = New MaterialSkin.Controls.MaterialLabel()
        Me.Label2 = New MaterialSkin.Controls.MaterialLabel()
        Me.Label1 = New MaterialSkin.Controls.MaterialLabel()
        Me.Label3 = New MaterialSkin.Controls.MaterialLabel()
        Me.Button5 = New MaterialSkin.Controls.MaterialFlatButton()
        Me.Button4 = New MaterialSkin.Controls.MaterialFlatButton()
        Me.Button3 = New MaterialSkin.Controls.MaterialFlatButton()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.KundenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VerlagToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AuftragToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BuchlistToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AutorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Panel1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.AutoSize = True
        Me.Button1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Button1.Depth = 0
        Me.Button1.Location = New System.Drawing.Point(620, 91)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.Button1.MouseState = MaterialSkin.MouseState.HOVER
        Me.Button1.Name = "Button1"
        Me.Button1.Primary = False
        Me.Button1.Size = New System.Drawing.Size(70, 36)
        Me.Button1.TabIndex = 10
        Me.Button1.Text = "Refresh"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.DateTimePicker1)
        Me.Panel1.Controls.Add(Me.TextBox4)
        Me.Panel1.Controls.Add(Me.TextBox2)
        Me.Panel1.Controls.Add(Me.TextBox1)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Button5)
        Me.Panel1.Controls.Add(Me.Button4)
        Me.Panel1.Controls.Add(Me.Button3)
        Me.Panel1.Location = New System.Drawing.Point(501, 156)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(287, 288)
        Me.Panel1.TabIndex = 8
        Me.Panel1.Visible = False
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.Location = New System.Drawing.Point(119, 121)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(138, 20)
        Me.DateTimePicker1.TabIndex = 9
        '
        'TextBox4
        '
        Me.TextBox4.BackColor = System.Drawing.Color.White
        Me.TextBox4.Depth = 0
        Me.TextBox4.Hint = ""
        Me.TextBox4.Location = New System.Drawing.Point(123, 22)
        Me.TextBox4.MouseState = MaterialSkin.MouseState.HOVER
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TextBox4.SelectedText = ""
        Me.TextBox4.SelectionLength = 0
        Me.TextBox4.SelectionStart = 0
        Me.TextBox4.Size = New System.Drawing.Size(133, 23)
        Me.TextBox4.TabIndex = 8
        Me.TextBox4.UseSystemPasswordChar = False
        '
        'TextBox2
        '
        Me.TextBox2.BackColor = System.Drawing.Color.White
        Me.TextBox2.Depth = 0
        Me.TextBox2.Hint = ""
        Me.TextBox2.Location = New System.Drawing.Point(123, 84)
        Me.TextBox2.MouseState = MaterialSkin.MouseState.HOVER
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TextBox2.SelectedText = ""
        Me.TextBox2.SelectionLength = 0
        Me.TextBox2.SelectionStart = 0
        Me.TextBox2.Size = New System.Drawing.Size(133, 23)
        Me.TextBox2.TabIndex = 8
        Me.TextBox2.UseSystemPasswordChar = False
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.Color.White
        Me.TextBox1.Depth = 0
        Me.TextBox1.Hint = ""
        Me.TextBox1.Location = New System.Drawing.Point(123, 54)
        Me.TextBox1.MouseState = MaterialSkin.MouseState.HOVER
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TextBox1.SelectedText = ""
        Me.TextBox1.SelectionLength = 0
        Me.TextBox1.SelectionStart = 0
        Me.TextBox1.Size = New System.Drawing.Size(133, 23)
        Me.TextBox1.TabIndex = 8
        Me.TextBox1.UseSystemPasswordChar = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Depth = 0
        Me.Label4.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(10, 117)
        Me.Label4.MouseState = MaterialSkin.MouseState.HOVER
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(53, 19)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Datum"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Depth = 0
        Me.Label2.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(10, 86)
        Me.Label2.MouseState = MaterialSkin.MouseState.HOVER
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(43, 19)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Preis"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Depth = 0
        Me.Label1.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(10, 58)
        Me.Label1.MouseState = MaterialSkin.MouseState.HOVER
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 19)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Titel"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Depth = 0
        Me.Label3.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(10, 29)
        Me.Label3.MouseState = MaterialSkin.MouseState.HOVER
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(72, 19)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "AuftragID"
        '
        'Button5
        '
        Me.Button5.AutoSize = True
        Me.Button5.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Button5.Depth = 0
        Me.Button5.Location = New System.Drawing.Point(114, 246)
        Me.Button5.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.Button5.MouseState = MaterialSkin.MouseState.HOVER
        Me.Button5.Name = "Button5"
        Me.Button5.Primary = False
        Me.Button5.Size = New System.Drawing.Size(64, 36)
        Me.Button5.TabIndex = 7
        Me.Button5.Text = "Cancel"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.AutoSize = True
        Me.Button4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Button4.Depth = 0
        Me.Button4.Location = New System.Drawing.Point(165, 198)
        Me.Button4.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.Button4.MouseState = MaterialSkin.MouseState.HOVER
        Me.Button4.Name = "Button4"
        Me.Button4.Primary = False
        Me.Button4.Size = New System.Drawing.Size(60, 36)
        Me.Button4.TabIndex = 7
        Me.Button4.Text = "Delete"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.AutoSize = True
        Me.Button3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Button3.Depth = 0
        Me.Button3.Location = New System.Drawing.Point(65, 198)
        Me.Button3.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.Button3.MouseState = MaterialSkin.MouseState.HOVER
        Me.Button3.Name = "Button3"
        Me.Button3.Primary = False
        Me.Button3.Size = New System.Drawing.Size(64, 36)
        Me.Button3.TabIndex = 7
        Me.Button3.Text = "Update"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowDrop = True
        Me.DataGridView1.Location = New System.Drawing.Point(0, 64)
        Me.DataGridView1.MultiSelect = False
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(495, 415)
        Me.DataGridView1.TabIndex = 7
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.MenuStrip1.AutoSize = False
        Me.MenuStrip1.Dock = System.Windows.Forms.DockStyle.None
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.KundenToolStripMenuItem, Me.VerlagToolStripMenuItem, Me.AuftragToolStripMenuItem, Me.BuchlistToolStripMenuItem, Me.AutorToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 1)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(661, 24)
        Me.MenuStrip1.TabIndex = 11
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
        'Auftrag
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 481)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "Auftrag"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Auftrag"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button1 As MaterialSkin.Controls.MaterialFlatButton
    Friend WithEvents Panel1 As Panel
    Friend WithEvents TextBox4 As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents TextBox2 As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents TextBox1 As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents Label2 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents Label1 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents Label3 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents Button5 As MaterialSkin.Controls.MaterialFlatButton
    Friend WithEvents Button4 As MaterialSkin.Controls.MaterialFlatButton
    Friend WithEvents Button3 As MaterialSkin.Controls.MaterialFlatButton
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label4 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents KundenToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VerlagToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AuftragToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BuchlistToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AutorToolStripMenuItem As ToolStripMenuItem
End Class
