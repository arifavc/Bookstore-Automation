Imports System.Data.SqlClient
Imports MaterialSkin

Public Class Form2
    Dim connection As SqlConnection = New SqlConnection("Data Source=.\SQLEXPRESS;Initial Catalog=DatenBank;Integrated Security=True")
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim SkinManager As MaterialSkinManager = MaterialSkinManager.Instance
        SkinManager.AddFormToManage(Me)
        SkinManager.Theme = MaterialSkinManager.Themes.LIGHT
        SkinManager.ColorScheme = New ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE)

        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
        TextBox4.Clear()
        TextBox5.Clear()



        Sprache_Load()
        Verlag_Load()
    End Sub
    Private Sub Sprache_Load()
        connection.Open()
        Dim adp As SqlDataAdapter = New SqlDataAdapter("select * from Sprache", connection)
        Dim ds As DataSet = New DataSet()
        adp.Fill(ds)
        ComboBox1.DataSource = ds.Tables(0)
        ComboBox1.ValueMember = "SpracheID"
        ComboBox1.DisplayMember = "SpracheName"
        connection.Close()
    End Sub
    Private Sub Verlag_Load()
        connection.Open()
        Dim adp As SqlDataAdapter = New SqlDataAdapter("select * from Verlag", connection)
        Dim ds As DataSet = New DataSet()
        adp.Fill(ds)
        ComboBox2.DataSource = ds.Tables(0)
        ComboBox2.ValueMember = "VerlagID"
        ComboBox2.DisplayMember = "VerlagName"
        connection.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim cmd As New SqlCommand
        Try
            connection.Open()
            cmd.CommandType = System.Data.CommandType.Text
            cmd.CommandText = "Insert Into Buch values ('" & TextBox1.Text & "','" & TextBox2.Text & "','" & TextBox3.Text & "','" & TextBox4.Text & "','" & ComboBox1.SelectedValue.ToString & "','" & ComboBox2.SelectedValue.ToString & "','" &
                TextBox5.Text & "')"
            cmd.Connection = connection

            cmd.ExecuteNonQuery()
            connection.Close()
            MsgBox("Succesfully Added", MsgBoxStyle.Information, "add")

            Me.Hide()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
        TextBox4.Clear()
        TextBox5.Clear()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        Me.Hide()
    End Sub


End Class