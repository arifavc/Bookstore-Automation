Imports System.Data.SqlClient
Imports MaterialSkin

Public Class AddKunden
    Dim connection As SqlConnection = New SqlConnection("Data Source=.\SQLEXPRESS;Initial Catalog=DatenBank;Integrated Security=True")
    Private Sub AddKunden_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim SkinManager As MaterialSkinManager = MaterialSkinManager.Instance
        SkinManager.AddFormToManage(Me)
        SkinManager.Theme = MaterialSkinManager.Themes.LIGHT
        SkinManager.ColorScheme = New ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE)

        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
        TextBox4.Clear()
        TextBox5.Clear()
        TextBox6.Clear()
        TextBox7.Clear()
        TextBox8.Clear()


    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim cmd As New SqlCommand
        Try

            connection.Open()
            cmd.CommandType = System.Data.CommandType.Text
            cmd.CommandText = "Insert Into Kunden values ('" & TextBox1.Text & "','" & TextBox2.Text & "','" & TextBox3.Text & "','" & TextBox4.Text & "','" & TextBox5.Text & "','" & TextBox6.Text & "','" & TextBox7.Text & "', '" & TextBox8.Text & "')"
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
        TextBox6.Clear()
        TextBox7.Clear()
        TextBox8.Clear()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Form3.Show()
        Me.Hide()
    End Sub


End Class