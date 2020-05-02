Imports System.Data.SqlClient
Imports MaterialSkin
Public Class Verlag
    Private Sub Verlag_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim SkinManager As MaterialSkinManager = MaterialSkinManager.Instance
        SkinManager.AddFormToManage(Me)
        SkinManager.Theme = MaterialSkinManager.Themes.LIGHT
        SkinManager.ColorScheme = New ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE)

    End Sub
    Dim Verlag_ID As Int32 = 0
    Dim connection As SqlConnection = New SqlConnection()
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        DatagridView_Load()
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        AddVerlag.Visible = True
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        'Update
        Dim cmd As New SqlCommand
        Try
            cmd.CommandType = System.Data.CommandType.Text
            cmd.CommandText = ("UPDATE Verlag SET VerlagID='" & TextBox4.Text & "', VerlagName='" & TextBox1.Text & "' WHERE VerlagID=" & Verlag_ID)

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


        i = DataGridView1.CurrentRow.Index
        Verlag_ID = DataGridView1.Item(0, i).Value

        Dim connection As SqlConnection = New SqlConnection()
        connection.ConnectionString = "Data Source=.\SQLEXPRESS;Initial Catalog=DatenBank;Integrated Security=True"
        connection.Open()
        Dim adp As SqlDataAdapter = New SqlDataAdapter("select VerlagID,VerlagName from Verlag WHERE VerlagID=" & Verlag_ID, connection)
        Dim ds As DataSet = New DataSet()
        adp.Fill(ds)
        TextBox4.Text = ds.Tables(0).Rows(0).Item(0)
        TextBox1.Text = ds.Tables(0).Rows(0).Item(1)
        Panel1.Visible = True
        connection.Close()

    End Sub
    Private Sub DatagridView_Load()
        connection.ConnectionString = "Data Source=.\SQLEXPRESS;Initial Catalog=DatenBank;Integrated Security=True"
        connection.Open()
        Dim adp As SqlDataAdapter = New SqlDataAdapter("select VerlagID,VerlagName from Verlag", connection)
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
            cmd.CommandText = "DELETE FROM Verlag WHERE VerlagID =" & Verlag_ID
            connection.Open()
            cmd.Connection = connection
            cmd.ExecuteNonQuery()
            connection.Close()
            DatagridView_Load()
            MsgBox("Succesfully Deleted " & MsgBoxStyle.Information, "delete")
            Panel1.Visible = False
        Catch ex As Exception
            ' MessageBox.Show(ex.Message & vbCrLf & cmd.CommandText)
        End Try
    End Sub
    Private Sub KundenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles KundenToolStripMenuItem.Click
        Form3.TopLevel = True
        Form3.Visible = True
        Me.Hide()


    End Sub

    Private Sub BuchlistToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BuchlistToolStripMenuItem.Click
        Form1.Visible = True
        Me.Hide()
    End Sub

    Private Sub AuftragToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AuftragToolStripMenuItem.Click
        Auftrag.Visible = True
        Me.Hide()
    End Sub

    Private Sub AutorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AutorToolStripMenuItem.Click
        Autor.Visible = True
        Me.Hide()
    End Sub


End Class