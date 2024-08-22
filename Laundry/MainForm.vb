Imports System.Data.SqlClient
Public Class MainForm
    Dim koneksi As New SqlConnection(StaticData.koneksistring)
    Dim formawal As Form

    Sub PindahForm(formtujuan As Form)
        If Not formawal Is Nothing Then
            formawal.Close()
        End If

        formawal = formtujuan
        formtujuan.TopLevel = False
        formtujuan.FormBorderStyle = FormBorderStyle.None
        Panel1.Controls.Add(formtujuan)
        formtujuan.BringToFront()
        formtujuan.Show()

    End Sub

    Sub gantinama()
        Dim abc As New SqlDataAdapter($"select * from Employee where id = '{StaticData.user_id}' ", koneksi)
        Dim ab As New DataTable()
        abc.Fill(ab)

        Label2.Text = "Welcome, " & ab.Rows(0).Item("Name")
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        PindahForm(EmployeeForm)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        PindahForm(ServiceFormvb)
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        PindahForm(PackageForm)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        PindahForm(TransactionDepositForm)
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        PindahForm(PrepaidPackageForm)
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        PindahForm(ViewTransaction)
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        If MessageBox.Show("Apakah Anda Yakin?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            Form1.tbpassword.Text = ""
            Form1.tbusername.Text = ""
            Form1.Show()
            Me.Close()
        End If
    End Sub

    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        gantinama()
        Timer1.Start()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Label4.Text = DateTime.Now.ToString("dd-MM-yyyy HH:mm:ss")
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub
End Class