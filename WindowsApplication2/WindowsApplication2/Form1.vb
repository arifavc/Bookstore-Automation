﻿Imports System.Data.SqlClient
Imports MaterialSkin
Public Class Form1
    Public Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim SkinManager As MaterialSkinManager = MaterialSkinManager.Instance
        SkinManager.AddFormToManage(Me)
        SkinManager.Theme = MaterialSkinManager.Themes.LIGHT
        SkinManager.ColorScheme = New ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE)
    End Sub

    Dim Buch_ID As Int32 = 0
    Dim connection As SqlConnection = New SqlConnection()


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        DatagridView_Load()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Form2.Visible = True



    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        'Update
        Dim cmd As New SqlCommand
        Try
            cmd.CommandType = System.Data.CommandType.Text
            cmd.CommandText = ("UPDATE Buch SET Titel='" & TextBox1.Text & "', Jahre='" & TextBox2.Text & "', Preis='" & TextBox3.Text & "',BuchID='" & TextBox4.Text & "' WHERE BuchID=" & Buch_ID)

            cmd.Connection = connection
            connection.Open()
            cmd.ExecuteNonQuery()
            connection.Close()
            DatagridView_Load()
            MsgBox("Succesfully Changed", MsgBoxStyle.Information, "update")

        Catch ex As Exception
            MessageBox.Show(ex.Message & vbCrLf & cmd.CommandText)
        End Try
    End Sub

    Private Sub DataGridView1_Click(sender As Object, e As EventArgs) Handles DataGridView1.Click
        Dim i As Integer

        'Stadt_Load()
        i = DataGridView1.CurrentRow.Index
        Buch_ID = DataGridView1.Item(0, i).Value

        Dim connection As SqlConnection = New SqlConnection()
        connection.ConnectionString = "Data Source=.\SQLEXPRESS;Initial Catalog=DatenBank;Integrated Security=True"
        connection.Open()
        Dim adp As SqlDataAdapter = New SqlDataAdapter("select BuchID,Titel,Jahre,Preis from Buch WHERE BuchID=" & Buch_ID, connection)
        Dim ds As DataSet = New DataSet()
        adp.Fill(ds)
        TextBox4.Text = ds.Tables(0).Rows(0).Item(0)
        TextBox1.Text = ds.Tables(0).Rows(0).Item(1)
        TextBox2.Text = ds.Tables(0).Rows(0).Item(2)
        ' ComboBox1.SelectedValue = ds.Tables(0).Rows(0).Item(2)
        TextBox3.Text = ds.Tables(0).Rows(0).Item(3)
        Panel1.Visible = True
        connection.Close()
    End Sub
    'Private Sub Stadt_Load()
    '    connection.Open()
    '    Dim adp As SqlDataAdapter = New SqlDataAdapter("select * from Genre", connection)
    '    Dim ds As DataSet = New DataSet()
    '    adp.Fill(ds)
    '    ComboBox1.DataSource = ds.Tables(0)
    '    ComboBox1.ValueMember = "GenreID"
    '    ComboBox1.DisplayMember = "GenreName"
    '    connection.Close()
    'End Sub
    Private Sub DatagridView_Load()
        connection.ConnectionString = "Data Source=.\SQLEXPRESS;Initial Catalog=DatenBank;Integrated Security=True"
        connection.Open()
        Dim adp As SqlDataAdapter = New SqlDataAdapter("select BuchID,Titel,Jahre,Preis from Buch", connection)
        Dim ds As DataSet = New DataSet()
        adp.Fill(ds)
        DataGridView1.DataSource = ds.Tables(0)
        connection.Close()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Panel1.Visible = False
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        'Delete
        Dim cmd As New SqlCommand
        Try
            cmd.CommandType = System.Data.CommandType.Text
            cmd.CommandText = "DELETE FROM Buch WHERE BuchID =" & Buch_ID
            connection.Open()
            cmd.Connection = connection
            cmd.ExecuteNonQuery()
            connection.Close()
            DatagridView_Load()
            MsgBox("Succesfully Deleted " & MsgBoxStyle.Information, "delete")

        Catch ex As Exception
            ' MessageBox.Show(ex.Message & vbCrLf & cmd.CommandText)
        End Try
    End Sub

    Private Sub KundenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles KundenToolStripMenuItem.Click
        Form3.TopLevel = True
        Form3.Visible = True
        Me.Hide()


    End Sub

    Private Sub BuchlistToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub AuftragToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AuftragToolStripMenuItem.Click
        Auftrag.Visible = True
        Me.Hide()
    End Sub

    Private Sub AutorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AutorToolStripMenuItem.Click
        Autor.Visible = True
        Me.Hide()
    End Sub

    Private Sub VerlagToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VerlagToolStripMenuItem.Click
        Verlag.Visible = True
        Me.Hide()
    End Sub
End Class
