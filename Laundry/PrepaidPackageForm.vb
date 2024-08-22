Imports System.Data.SqlClient
Public Class PrepaidPackageForm
    Dim koneksi As New SqlConnection(StaticData.koneksistring)
    Dim id As Integer

    Sub cekKoneksi()
        If koneksi.State = ConnectionState.Closed Then
            koneksi.Open()
        End If
    End Sub

    Sub prepaid()
        cekKoneksi()
        Dim abc As New SqlDataAdapter($"select * from View_prepaid where Name like '%{tbCari.Text}%' or PackageName like '%{tbCari.Text}%'", koneksi)
        Dim ab As New DataTable()
        abc.Fill(ab)

        dgprepaid.DataSource = ab
        dgprepaid.Columns(0).Visible = False
        dgprepaid.Columns(1).HeaderText = "Customer"
    End Sub

    Sub getpackage()
        Dim abc As New SqlDataAdapter($"select * from Service", koneksi)
        Dim ab As New DataTable()
        abc.Fill(ab)

        cbpackage.DataSource = ab
        cbpackage.DisplayMember = "Name"
        cbpackage.ValueMember = "id"
    End Sub

    Sub gantinama()
        Dim abc As New SqlDataAdapter($"select * from customer where id = '{StaticData.user_id}' ", koneksi)
        Dim ab As New DataTable()
        abc.Fill(ab)

        Label8.Text = "Name     " & ab.Rows(0).Item("Name")
    End Sub

    Sub alamat()
        Dim abc As New SqlDataAdapter($"select * from customer where id = '{StaticData.user_id}' ", koneksi)
        Dim ab As New DataTable()
        abc.Fill(ab)

        Label9.Text = "Address     " & ab.Rows(0).Item("Addres")
    End Sub

    Private Sub PrepaidPackageForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        prepaid()
        getpackage()
        gantinama()
        alamat()
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        If cbpackage.SelectedIndex = -1 Or numharga.Value = 0 Then
            MsgBox("Isi Semua Form", MsgBoxStyle.Exclamation)
        End If


        Dim abc As New SqlCommand($"insert into View_prepaid(id,PackageName,Price) values ('{id}', '{cbpackage.SelectedValue}', {numharga.Value}", koneksi)
        cekKoneksi()
        abc.ExecuteNonQuery()
    End Sub

    Private Sub tbhp_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tbhp.KeyPress
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9" Or e.KeyChar = vbBack)) Then
            e.Handled = True
        End If
    End Sub

    Private Sub dgprepaid_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgprepaid.CellContentClick

    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click

    End Sub
End Class