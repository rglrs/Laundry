Imports System.ComponentModel
Imports System.Data.SqlClient
Imports System.Math

Public Class EmployeeForm
    Dim koneksi As New SqlConnection(StaticData.koneksistring)
    Dim id As Integer = 0
    Dim insert As Boolean = False

    Sub cekKoneksi()
        If koneksi.State = ConnectionState.Closed Then
            koneksi.Open()
        End If
    End Sub

    Sub employa()
        cekKoneksi()
        Dim abc As New SqlDataAdapter($"select * from View_job where name like '%{tbCari.Text}%' or Email like '%{tbCari.Text}%' or PhoneNumber like '%{tbCari.Text}%'", koneksi)
        Dim ab As New DataTable()
        abc.Fill(ab)

        dgemploya.DataSource = ab
        dgemploya.Columns(0).Visible = False
        dgemploya.Columns(7).Visible = False

        GroupBox1.Visible = False
        GroupBox2.Visible = True
        dgemploya.Enabled = True
        dgemploya.Columns(7).HeaderText = "JobTitle"
    End Sub

    Sub enableform()
        GroupBox1.Visible = True
        GroupBox2.Visible = False
        dgemploya.Enabled = False
    End Sub

    Sub getTitle()
        Dim abc As New SqlDataAdapter("select * from Job", koneksi)
        Dim ab As New DataTable()
        abc.Fill(ab)

        cbtitle.DataSource = ab
        cbtitle.DisplayMember = "Name"
        cbtitle.ValueMember = "id"
        cbtitle.SelectedIndex = 0
    End Sub

    Private Sub EmployeeForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        employa()
        getTitle()
    End Sub

    Private Sub EmployeeForm_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        MainForm.Show()
    End Sub

    Private Sub btInserrt_Click(sender As Object, e As EventArgs) Handles btInserrt.Click
        insert = True
        enableform()

        tbname.Text = ""
        tbemail.Text = ""
        tbhp.Text = ""
        tbalamat.Text = ""
        cbtitle.SelectedIndex = -1
        dtDate.Value = Now
        numSalary.Value = 0
        tbpas.Text = ""
        tbconfirm.Text = ""
    End Sub

    Private Sub btUpdate_Click(sender As Object, e As EventArgs) Handles btUpdate.Click
        If id = 0 Then
            MsgBox("Pilih Data Dulu", MsgBoxStyle.Exclamation)
            Return
        End If
        enableform()
        insert = False
    End Sub

    Private Sub btSave_Click(sender As Object, e As EventArgs) Handles btSave.Click
        If tbname.Text = "" Or tbemail.Text = "" Or tbhp.Text = "" Or tbalamat.Text = "" Or cbtitle.SelectedIndex = -1 Or numSalary.Value = 0 Or tbpas.Text = "" Or tbconfirm.Text = "" Then
            MsgBox("Isi Semua Form", MsgBoxStyle.Exclamation)
            Return
        ElseIf Not tbpas.Text = tbconfirm.Text Then
            MsgBox("Password Harus Sama", MsgBoxStyle.Exclamation)

        End If


        If insert Then
            Dim abc As New SqlCommand($"insert into Employee(Name,Email,PhoneNumber,addres,DateofBirth,idJob,salary,password) values ('{tbname.Text}', '{tbemail.Text}', '{tbhp.Text}', '{tbalamat.Text}', '{dtDate.Value}', '{cbtitle.SelectedValue}', '{numSalary.Value}', '{tbpas.Text}')", koneksi)
            cekKoneksi()
            abc.ExecuteNonQuery()
            MsgBox("Data Ditambahkan", MsgBoxStyle.Information)

            id = 0
            employa()

        Else
            Dim abc As New SqlCommand($"update Employee set Name = '{tbname.Text}', Email = '{tbemail.Text}', PhoneNumber = '{tbhp.Text}', addres = '{tbalamat.Text}', DateofBirth = '{dtDate.Value}', idJob = '{cbtitle.SelectedValue}', salary = '{numSalary.Value}', password = '{tbpas.Text}' where id = {id}", koneksi)
            cekKoneksi()
            abc.ExecuteNonQuery()
            MsgBox("Data Diupdate", MsgBoxStyle.Information)

            id = 0
            employa()
        End If
    End Sub

    Private Sub dgemploya_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgemploya.CellClick
        If e.RowIndex >= 0 Then
            id = dgemploya.Rows(e.RowIndex).Cells(0).Value
            tbname.Text = dgemploya.Rows(e.RowIndex).Cells(2).Value
            tbemail.Text = dgemploya.Rows(e.RowIndex).Cells(3).Value
            tbhp.Text = dgemploya.Rows(e.RowIndex).Cells(5).Value
            tbalamat.Text = dgemploya.Rows(e.RowIndex).Cells(4).Value
            tbpas.Text = dgemploya.Rows(e.RowIndex).Cells(1).Value
            'cbdate.SelectedValue = dgemploya.Rows(e.RowIndex).Cells(6).Value
            cbtitle.SelectedValue = dgemploya.Rows(e.RowIndex).Cells(7).Value
            numSalary.Value = Math.Round(dgemploya.Rows(e.RowIndex).Cells(8).Value)
        End If
    End Sub

    Private Sub tbCari_TextChanged(sender As Object, e As EventArgs) Handles tbCari.TextChanged
        employa()
    End Sub

    Private Sub btDelete_Click(sender As Object, e As EventArgs) Handles btDelete.Click
        If MessageBox.Show("Apakah Yakin Menghapus Data?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            Dim abc As New SqlCommand($"delete from Employee where id = '{id}'", koneksi)
            cekKoneksi()
            abc.ExecuteNonQuery()
            id = 0
            employa()
            Return
        End If
    End Sub

    Private Sub btCancel_Click(sender As Object, e As EventArgs) Handles btCancel.Click
        id = 0
        employa()
    End Sub
End Class