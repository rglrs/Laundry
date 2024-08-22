Imports System.Data.SqlClient
Public Class ViewTransaction
    Dim koneksi As New SqlConnection(StaticData.koneksistring)

    Sub cekKoneksi()
        If koneksi.State = ConnectionState.Closed Then
            koneksi.Open()
        End If
    End Sub

    Sub getHeader()
        Dim abc As New SqlDataAdapter($"select * from View_header where name like '%{tbCari.Text}%' or EmployeeName like '%{tbCari.Text}%'", koneksi)
        Dim ab As New DataTable()
        abc.Fill(ab)

        dgheader.DataSource = ab
        dgheader.Columns(0).Visible = False
        dgheader.Columns(1).Visible = False
    End Sub

    Sub getDetail()
        Dim abc As New SqlDataAdapter($"select * from View_detail", koneksi)
        Dim ab As New DataTable()
        abc.Fill(ab)

        dgdetail.DataSource = ab
        dgdetail.Columns(1).Visible = False
    End Sub

    Private Sub DataGridView2_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgdetail.CellContentClick

    End Sub

    Private Sub ViewTransaction_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        getHeader()
        getDetail()
    End Sub
End Class