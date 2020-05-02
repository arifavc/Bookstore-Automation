Imports System.Data.SqlClient
Public Class Form3
    Dim Kunden_ID As Int32 = 0
    Dim connection As SqlConnection = New SqlConnection()

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        DatagridView_Load()
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        AddKunden.Visible = True

    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        'Update
        Dim cmd As New SqlCommand
        Try
            cmd.CommandType = System.Data.CommandType.Text
            cmd.CommandText = "UPDATE Kunden SET KundenID='" & TextBox1.Text & "', KundenVorname='" & TextBox2.Text & "', KundenNachname='" & TextBox3.Text & "', Ort='" & TextBox4.Text & "', Straße='" & TextBox5.Text & "', PLZ='" & TextBox6.Text & "', [E-Mail]='" & TextBox7.Text & "', Telefon='" & TextBox8.Text & "' WHERE KundenID=" & Kunden_ID
            connection.Open()
            cmd.Connection = connection
            cmd.ExecuteNonQuery()
            connection.Close()
            DatagridView_Load()
            MsgBox("Succesfully Changed", MsgBoxStyle.Information, "update")
            Panel1.Visible = False
        Catch ex As Exception
            MessageBox.Show(ex.Message & vbCrLf & cmd.CommandText)
        End Try
    End Sub
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        'Update
        Dim cmd As New SqlCommand
        Try
            cmd.CommandType = System.Data.CommandType.Text
            cmd.CommandText = ("DELETE FROM Kunden WHERE KundenID=" & Kunden_ID)
            connection.Open()
            cmd.Connection = connection

            cmd.ExecuteNonQuery()
            connection.Close()
            DatagridView_Load()
            MsgBox("Succesfully Deleted", MsgBoxStyle.Information, "delete")

        Catch ex As Exception
            MessageBox.Show(ex.Message & vbCrLf & cmd.CommandText)
        End Try
    End Sub
    Private Sub DataGridView1_Click(sender As Object, e As EventArgs) Handles DataGridView1.Click
        Dim i As Integer

        ' Stadt_Load()
        i = DataGridView1.CurrentRow.Index
        Kunden_ID = DataGridView1.Item(0, i).Value

        Dim connection As SqlConnection = New SqlConnection()
        connection.ConnectionString = "Data Source=.\SQLEXPRESS;Initial Catalog=DatenBank;Integrated Security=True"
        connection.Open()
        Dim adp As SqlDataAdapter = New SqlDataAdapter("select * from Kunden WHERE KundenID=" & Kunden_ID, connection)
        Dim ds As DataSet = New DataSet()
        adp.Fill(ds)
        TextBox1.Text = ds.Tables(0).Rows(0).Item(0)
        TextBox2.Text = ds.Tables(0).Rows(0).Item(1)
        TextBox3.Text = ds.Tables(0).Rows(0).Item(2)
        TextBox4.Text = ds.Tables(0).Rows(0).Item(3)
        TextBox5.Text = ds.Tables(0).Rows(0).Item(4)
        TextBox6.Text = ds.Tables(0).Rows(0).Item(5)
        TextBox7.Text = ds.Tables(0).Rows(0).Item(6)
        TextBox8.Text = ds.Tables(0).Rows(0).Item(7)
        Panel1.Visible = True
        connection.Close()
    End Sub
    Private Sub DatagridView_Load()
        connection.ConnectionString = "Data Source=.\SQLEXPRESS;Initial Catalog=DatenBank;Integrated Security=True"
        connection.Open()
        Dim adp As SqlDataAdapter = New SqlDataAdapter("select * from Kunden", connection)
        Dim ds As DataSet = New DataSet()
        adp.Fill(ds)
        DataGridView1.DataSource = ds.Tables(0)
        connection.Close()
    End Sub
    'Private Sub Stadt_Load()
    '    connection.Open()
    '    Dim adp As SqlDataAdapter = New SqlDataAdapter("select * from Kunden", connection)
    '    Dim ds As DataSet = New DataSet()
    '    adp.Fill(ds)
    '    ComboBox1.DataSource = ds.Tables(0)
    '    ComboBox1.ValueMember = "OrtID"
    '    ComboBox1.DisplayMember = "Ort"
    '    connection.Close()
    'End Sub

    Private Sub BuchlistToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BuchlistToolStripMenuItem.Click
        Me.TopLevel = False
        Form1.Show()
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

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Me.Hide()
    End Sub
End Class