Imports MaterialSkin
Imports System.Windows.Forms.ProgressBar
Public Class Form4

    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Label3.Hide()
        ProgressBar1.Hide()

        Dim SkinManager As MaterialSkinManager = MaterialSkinManager.Instance
        SkinManager.AddFormToManage(Me)

        SkinManager.Theme = MaterialSkinManager.Themes.LIGHT

    End Sub


    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        ProgressBar1.Value += 20
        Label3.Text = ProgressBar1.Value & "%" & "Completed"
        If ProgressBar1.Value = ProgressBar1.Maximum Then

            Timer1.Stop()

            MsgBox("Wilkommen!", MsgBoxStyle.Information)
            Form1.Show()
            Me.Hide()

        End If
    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text = "admin" And TextBox2.Text = "pass" Then
            Timer1.Start()
            ProgressBar1.Show()

            Label3.Show()

        Else
            MsgBox("Invalid username or password", MsgBoxStyle.Critical)

        End If

    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        SkinManager.Theme = MaterialSkinManager.Themes.DARK
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        SkinManager.Theme = MaterialSkinManager.Themes.LIGHT
    End Sub
End Class