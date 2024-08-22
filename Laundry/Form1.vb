Imports System.ComponentModel
Imports System.Data.SqlClient

Public Class Form1
    Dim koneksi As New SqlConnection(StaticData.koneksistring)


    Sub cekKoneksi()
        If koneksi.State = ConnectionState.Closed Then
            koneksi.Open()
        End If
    End Sub

    Sub reset()
        tbpassword.Clear()
        tbusername.Clear()
    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Form1_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        End
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If tbpassword.Text = "" Or tbusername.Text = "" Then
            MsgBox("Isi Semua", MsgBoxStyle.Exclamation)
            Return

        End If

        cekKoneksi()
        Dim abc As New SqlDataAdapter($"select * from Employee where Name= '{tbusername.Text}' and Password='{tbpassword.Text}' ", koneksi)
        Dim ab As New DataTable()
        abc.Fill(ab)

        If ab.Rows.Count <= 0 Then
            MsgBox("Username dan Password Salah", MsgBoxStyle.Exclamation)
            Return

        End If

        StaticData.user_id = ab.Rows(0).Item(0)

        MainForm.Show()
        Me.Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Btreset.Click
        Try
            Call reset()
        Catch ex As Exception

        End Try
    End Sub
End Class
