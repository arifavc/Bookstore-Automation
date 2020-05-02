Imports System.Data.SqlClient
Imports MaterialSkin

Public Class AddAuftrag
    Dim connection As SqlConnection = New SqlConnection("Data Source=.\SQLEXPRESS;Initial Catalog=DatenBank;Integrated Security=True")
    Private Sub AddAuftrag_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim SkinManager As MaterialSkinManager = MaterialSkinManager.Instance
        SkinManager.AddFormToManage(Me)
        SkinManager.Theme = MaterialSkinManager.Themes.LIGHT
        SkinManager.ColorScheme = New ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE)

        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()



    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim cmd As New SqlCommand
        Try
            connection.Open()
            cmd.CommandType = System.Data.CommandType.Text
            cmd.CommandText = "Insert Into a.AuftragID,Titel,Preis,AuftragDatum from Auftrag inner join AuftragDetail a on Buch.BuchID=a.BuchID inner join Auftrag on a.AuftragID=Auftrag.AuftragID values ('" & TextBox1.Text & "','" & TextBox2.Text & "','" & TextBox3.Text & "')"
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

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
       
        Me.Hide()
    End Sub


End Class