
Imports System.Data.SqlClient
Public Class PackageForm
    Dim koneksi As New SqlConnection(StaticData.koneksistring)
    Dim id As Integer = 0
    Dim insert As Boolean = False

    Sub cekKoneksi()
        If koneksi.State = ConnectionState.Closed Then
            koneksi.Open()
        End If
    End Sub

    Sub package()
        cekKoneksi()
        Dim abc As New SqlDataAdapter($"select * from View_package where Name like '%{tbCari.Text}%'", koneksi)
        Dim ab As New DataTable()
        abc.Fill(ab)

        dgpackage.DataSource = ab
        dgpackage.Columns(0).Visible = False
        dgpackage.Columns(1).Visible = False

        gbform.Visible = False
        gbbutton.Visible = True
        dgpackage.Enabled = True
    End Sub

    Sub getServiceName()
        Dim abc As New SqlDataAdapter("select * from Service", koneksi)
        Dim ab As New DataTable()
        abc.Fill(ab)

        cbservice.DataSource = ab
        cbservice.DisplayMember = "Name"
        cbservice.ValueMember = "id"
    End Sub

    Sub enaableform()
        gbform.Visible = True
        gbbutton.Visible = False
        dgpackage.Enabled = False
    End Sub
    Private Sub PackageForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        package()
        getServiceName()
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        insert = True
        enaableform()

        cbservice.SelectedIndex = -1
        numtotal.Value = 0
        numunit.Value = 0
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        If id = 0 Then
            MsgBox("Pilih Data Dulu", MsgBoxStyle.Exclamation)
            Return
        End If
        enaableform()
        insert = False
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        If MessageBox.Show("Apakah Anda Yakin?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            Dim abc As New SqlCommand($"delete from Service where id = '{id}'", koneksi)
            cekKoneksi()
            abc.ExecuteNonQuery()
            id = 0
            package()
            Return


        End If
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        id = 0
        package()
    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        If cbservice.SelectedIndex = -1 Or numtotal.Value = 0 Or numunit.Value = 0 Then
            MsgBox("Isi Semua Form", MsgBoxStyle.Exclamation)
        End If

        If insert Then
                Dim abc As New SqlCommand($"insert into Package(idService,TotalUnit,Price) values ('{cbservice.SelectedValue}', '{numtotal.Value}', '{numunit.Value}') ", koneksi)
                cekKoneksi()
                abc.ExecuteNonQuery()
                MsgBox("Data Ditambahkan", MsgBoxStyle.Information)

                id = 0
                package()

            Else
                Dim abc As New SqlCommand($"update Package set idService = '{cbservice.SelectedValue}', TotalUnit = '{numtotal.Value}', Price = '{numunit.Value}' where id = '{id}'", koneksi)
                cekKoneksi()
                abc.ExecuteNonQuery()
                MsgBox("Data Diupdate", MsgBoxStyle.Information)

                id = 0
                package()
            End If

    End Sub
End Class