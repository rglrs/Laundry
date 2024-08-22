Imports System.Data.SqlClient
Public Class TransactionDepositForm
    Dim koneksi As New SqlConnection(StaticData.koneksistring)
    Dim id As Integer
    Dim detailid As Integer

    Sub cekKoneksi()
        If koneksi.State = ConnectionState.Closed Then
            koneksi.Open()
        End If
    End Sub

    Sub getserviceID()
        Dim abc As New SqlDataAdapter($"select * from Service", koneksi)
        Dim ab As New DataTable()
        abc.Fill(ab)

        cbservice.DataSource = ab
        cbservice.DisplayMember = "id"
        cbservice.ValueMember = "id"
    End Sub

    'Sub getdeposit()
    '    Dim abc As New SqlDataAdapter($"select id,Name,idCategory,idUnit,PriceUnit,EstimationDuration from Service where id = '{cbservice.SelectedValue}'", koneksi)
    '    Dim ab As New DataTable()
    '    abc.Fill(ab)

    '    dgdeposit.DataSource = ab
    '    dgdeposit.Columns(0).Visible = False
    '    dgdeposit.Columns(2).Visible = False
    '    dgdeposit.Columns(3).Visible = False

    'End Sub

    Sub detaildeposit()
        Dim abc As New SqlDataAdapter($"select id,idDeposit,idService,idPrepaidPackage,PriceUnit,totalUnit,CompleteDateTime from DetailDeposit where id = '{cbservice.SelectedValue}'", koneksi)
        Dim ab As New DataTable()
        abc.Fill(ab)

        dgdeposit.DataSource = ab
        dgdeposit.Columns(0).Visible = False
        dgdeposit.Columns(1).Visible = False
        dgdeposit.Columns(2).HeaderText = "Service Name"
        dgdeposit.Columns(3).Visible = False
    End Sub

    Sub total()

    End Sub


    Private Sub TransactionDepositForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        getserviceID()
        'getdeposit()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If cbservice.SelectedIndex = -1 Then
            MsgBox("Isi Semua Format", MsgBoxStyle.Exclamation)
            Return
        End If

        Dim abc As New SqlCommand($"select * from Service where id = '{cbservice.SelectedValue}'", koneksi)
        cekKoneksi()
        abc.ExecuteNonQuery()
        detaildeposit()
        'getdeposit()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim abc As New SqlCommand($"delete from DetailDeposit where id = '{detailid}' ", koneksi)
        cekKoneksi()
        abc.ExecuteNonQuery()
    End Sub

    Private Sub dgdeposit_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgdeposit.CellContentClick

    End Sub

    Private Sub dgdeposit_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgdeposit.CellClick

    End Sub
End Class