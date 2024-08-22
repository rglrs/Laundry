Imports System.Data.SqlClient
Public Class ServiceFormvb
    Dim koneksi As New SqlConnection(StaticData.koneksistring)
    Dim id As Integer = 0
    Dim insert As Boolean = False

    Sub cekKoneksi()
        If koneksi.State = ConnectionState.Closed Then
            koneksi.Open()
        End If
    End Sub

    Sub service()
        cekKoneksi()
        Dim abc As New SqlDataAdapter($"select * from View_service where Name like '%{tbCari.Text}%' or Nama_category like '%{tbCari.Text}%' or Nama_unit like '%{tbCari.Text}%' or PriceUnit like '%{tbCari.Text}%'", koneksi)
        Dim ab As New DataTable()
        abc.Fill(ab)

        dgservice.DataSource = ab
        dgservice.Columns(0).Visible = False
        dgservice.Columns(2).Visible = False
        dgservice.Columns(3).Visible = False

        gbform.Visible = False
        gbbutton.Visible = True
        dgservice.Enabled = True
    End Sub

    Sub enableform()
        gbform.Visible = True
        gbbutton.Visible = False
        dgservice.Enabled = False
    End Sub

    Sub getKategori()
        Dim abc As New SqlDataAdapter($"select * from category", koneksi)
        Dim ab As New DataTable()
        abc.Fill(ab)

        cbkategori.DataSource = ab
        cbkategori.DisplayMember = "Name"
        cbkategori.ValueMember = "id"
    End Sub

    Sub getUnit()
        Dim abc As New SqlDataAdapter($"select * from Unit", koneksi)
        Dim ab As New DataTable()
        abc.Fill(ab)

        cbunit.DataSource = ab
        cbunit.DisplayMember = "Name"
        cbunit.ValueMember = "id"
    End Sub
    Private Sub ServiceFormvb_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        service()
        getKategori()
        getUnit()
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        insert = True
        enableform()

        tbname.Text = ""
        cbkategori.SelectedIndex = -1
        cbunit.SelectedIndex = -1
        numprice.Value = 0
        numdurasi.Value = 0
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        If id = 0 Then
            MsgBox("Pilih Data Dulu", MsgBoxStyle.Exclamation)
            Return
        End If

        enableform()
        insert = False
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        If MessageBox.Show("Apakah Yakin Menghapus Data?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            Dim abc As New SqlCommand($"delete from Service where id = '{id}'", koneksi)
            cekKoneksi()
            abc.ExecuteNonQuery()
            id = 0
            service()
            Return

        End If
    End Sub

    Private Sub tbCari_TextChanged(sender As Object, e As EventArgs) Handles tbCari.TextChanged
        service()
    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        If tbname.Text = "" Or cbkategori.SelectedIndex = -1 Or cbunit.SelectedIndex = -1 Or numprice.Value = 0 Or numdurasi.Value = 0 Then
            MsgBox("Isi Semua Form", MsgBoxStyle.Exclamation)
            Return
        End If

        If insert Then
            Dim abc As New SqlCommand($"insert into Service(Name,PriceUnit,EstimationDuration,idCategory,idUnit) values ('{tbname.Text}', '{numprice.Value}', '{numdurasi.Value}', '{cbkategori.SelectedValue}', '{cbunit.SelectedValue}') ", koneksi)
            cekKoneksi()
            abc.ExecuteNonQuery()
            MsgBox("Data Ditambahkan", MsgBoxStyle.Information)

            id = 0
            service()

        Else
            Dim abc As New SqlCommand($"update Service set Name = '{tbname.Text}', PriceUnit = '{numprice.Value}' , EstimationDuration = '{numprice.Value}' , idCategory = '{cbkategori.SelectedValue}' , idUnit = '{cbunit.SelectedValue}')  ", koneksi)
            cekKoneksi()
            abc.ExecuteNonQuery()
            MsgBox("Data Berhasil Diupdate", MsgBoxStyle.Information)

            id = 0
            service()
        End If
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        id = 0
        service()
    End Sub

    Private Sub dgservice_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgservice.CellClick
        If e.RowIndex >= 0 Then
            id = dgservice.Rows(e.RowIndex).Cells(0).Value
            tbname.Text = dgservice.Rows(e.RowIndex).Cells(1).Value
            cbkategori.SelectedValue = dgservice.Rows(e.RowIndex).Cells(2).Value
            cbunit.SelectedValue = dgservice.Rows(e.RowIndex).Cells(3).Value
            numprice.Value = dgservice.Rows(e.RowIndex).Cells(4).Value
            numdurasi.Value = dgservice.Rows(e.RowIndex).Cells(5).Value
        End If
    End Sub
End Class