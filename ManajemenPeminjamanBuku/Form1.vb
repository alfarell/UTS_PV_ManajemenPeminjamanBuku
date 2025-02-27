Imports System.Data.SQLite

Public Class Form1
    Private dbManager As New DBManager()
    Private peminjamanManager As New PeminjamanManager(dbManager)
    Private memberManager As New MemberManager(dbManager)

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dbManager.CreateTable()
        peminjamanManager.LoadPeminjamanToDataGridView(dgvPeminjaman)
        memberManager.LoadMemberToDataGridView(dgvMember)
        btnResetMemberId.Enabled = False
    End Sub

    Private Sub btnCari_Click(sender As Object, e As EventArgs) Handles btnCari.Click
        txtNama.Clear()
        txtAlamat.Clear()

        If String.IsNullOrEmpty(txtNoMember.Text) Then
            MessageBox.Show(
                "No Member wajib diisi!",
                "Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
            )

            Return
        End If

        Dim noMember As Integer = txtNoMember.Text
        memberManager.FindAndFillMemberFields(noMember, txtNama, txtAlamat)
    End Sub

    Private Sub btnBuatPeminjaman_Click(sender As Object, e As EventArgs) Handles btnBuatPeminjaman.Click
        peminjamanManager.BuatPeminjaman(txtNama, txtISBN, numDurasi, txtHarga, txtNoMember, dgvPeminjaman)
    End Sub

    Private Sub btnBuatMember_Click(sender As Object, e As EventArgs) Handles btnBuatMember.Click
        memberManager.BuatMember(txtMemberNama, txtMemberAlamat, dgvMember)
    End Sub

    Private Sub btnRedirectBuatMember_Click(sender As Object, e As EventArgs) Handles btnRedirectBuatMember.Click
        TabControl1.SelectedTab = daftarMember
    End Sub

    Private Sub txtNoMember_TextChanged(sender As Object, e As EventArgs) Handles txtNoMember.TextChanged
        If String.IsNullOrEmpty(txtNoMember.Text) Then
            btnResetMemberId.Enabled = False
        Else
            btnResetMemberId.Enabled = True
        End If
    End Sub

    Private Sub btnResetMemberId_Click(sender As Object, e As EventArgs) Handles btnResetMemberId.Click
        memberManager.ResetFormMember(txtNama, txtAlamat)
    End Sub

    Private Sub btnImportDataPeminjam_Click(sender As Object, e As EventArgs) Handles btnImportDataPeminjam.Click
        Dim member As Member = memberManager.LoadMemberFile()
        memberManager.FindAndFillMemberFields(member.Id, txtNama, txtAlamat)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim member As Member = memberManager.LoadMemberFile()

        If String.IsNullOrEmpty(member.Nama) Or
            String.IsNullOrEmpty(member.Alamat) Then
            MessageBox.Show(
                "Nama dan Alamat tidak sesuai format!",
                "Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
            )

            Return
        End If

        txtMemberNama.Text = member.Nama
        txtMemberAlamat.Text = member.Alamat
    End Sub
End Class
