Imports System.Data.SqlClient
Public Class AddCustomerForm
    Dim koneksi As New SqlConnection(StaticData.koneksistring)
    Dim id As Integer = 0

    Sub cekKoneksi()
        If koneksi.State = ConnectionState.Closed Then
            koneksi.Open()
        End If
    End Sub
    Private Sub AddCustomerForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        If tbname.Text = "" Or tbhp.Text = "" Or tbalamat.Text = "" Then
            MsgBox("Isi Semua Form", MsgBoxStyle.Exclamation)
            Return
        End If

        'Add Customer Kan Nambah Iki Ogk Gae Update Tapi Inssert
        ' Insert into customer () .... Terusane
        Dim abc As New SqlCommand($"insert into customer(Name,PhoneNumber,Addres) values('{tbname.Text}', '{tbhp.Text}', '{tbalamat.Text}' ) ", koneksi)
        cekKoneksi()
        abc.ExecuteNonQuery()
        MsgBox("Customer Berhasil Ditambah", MsgBoxStyle.Information)

    End Sub
End Class