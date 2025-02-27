﻿Public Class PeminjamanManager
    Private dbManager As DBManager

    Public Sub New(dbManager As DBManager)
        Me.dbManager = dbManager
    End Sub

    Public Sub LoadPeminjamanToDataGridView(dgvPeminjaman As DataGridView)
        Dim dtPeminjaman As DataTable = dbManager.GetPeminjaman()
        dgvPeminjaman.DataSource = dtPeminjaman
    End Sub

    Public Sub BuatPeminjaman(txtNama As TextBox, txtISBN As TextBox, numDurasi As NumericUpDown, txtHarga As TextBox, txtNoMember As TextBox, dgvPeminjaman As DataGridView)
        Dim peminjaman As New Peminjaman
        peminjaman.Judul = txtNama.Text
        peminjaman.ISBN = txtISBN.Text
        peminjaman.Durasi = numDurasi.Value
        peminjaman.Harga = txtHarga.Text
        peminjaman.Tanggal = Date.Now.ToString("dd-MM-yyyy")
        peminjaman.MemberId = txtNoMember.Text

        If String.IsNullOrEmpty(peminjaman.Judul) Or
            String.IsNullOrEmpty(peminjaman.ISBN) Or
            String.IsNullOrEmpty(peminjaman.Harga) Or
            String.IsNullOrEmpty(peminjaman.MemberId) Then

            MessageBox.Show(
                "Informasi data buku dan peminjam wajib diisi!",
                "Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
            )

            Return
        End If

        Dim res = dbManager.InsertPeminjaman(peminjaman)

        If True = res Then
            ResetFormPeminjaman(txtNama, txtISBN, numDurasi, txtHarga, txtNoMember)
            LoadPeminjamanToDataGridView(dgvPeminjaman)
        End If
    End Sub

    Private Sub ResetFormPeminjaman(txtNama As TextBox, txtISBN As TextBox, numDurasi As NumericUpDown, txtHarga As TextBox, txtNoMember As TextBox)
        txtNama.Clear()
        txtISBN.Clear()
        numDurasi.Value = numDurasi.Minimum
        txtHarga.Clear()
        txtNoMember.Clear()
    End Sub
End Class
