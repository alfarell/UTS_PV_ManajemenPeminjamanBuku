<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        TabControl1 = New TabControl()
        buatPeminjaman = New TabPage()
        btnResetMemberId = New Button()
        btnCari = New Button()
        btnRedirectBuatMember = New Button()
        btnBuatPeminjaman = New Button()
        btnImportDataPeminjam = New Button()
        txtAlamat = New TextBox()
        labelAlamat = New Label()
        txtNama = New TextBox()
        labelNama = New Label()
        txtNoMember = New TextBox()
        labelNoMember = New Label()
        labelDataPeminjam = New Label()
        labelDataBuku = New Label()
        txtHarga = New TextBox()
        labelHarga = New Label()
        labelHari = New Label()
        numDurasi = New NumericUpDown()
        labelDurasi = New Label()
        txtISBN = New TextBox()
        labelISBN = New Label()
        txtJudul = New TextBox()
        labelJudulBuku = New Label()
        daftarPeminjaman = New TabPage()
        dgvPeminjaman = New DataGridView()
        peminjamanId = New DataGridViewTextBoxColumn()
        peminjamanJudul = New DataGridViewTextBoxColumn()
        peminjamanISBN = New DataGridViewTextBoxColumn()
        peminjamanDurasi = New DataGridViewTextBoxColumn()
        tanggal = New DataGridViewTextBoxColumn()
        harga = New DataGridViewTextBoxColumn()
        peminjamanMemberId = New DataGridViewTextBoxColumn()
        peminjamanNama = New DataGridViewTextBoxColumn()
        peminjamanAlamat = New DataGridViewTextBoxColumn()
        daftarMember = New TabPage()
        Button3 = New Button()
        dgvMember = New DataGridView()
        memberId = New DataGridViewTextBoxColumn()
        memberNama = New DataGridViewTextBoxColumn()
        memberAlamat = New DataGridViewTextBoxColumn()
        btnBuatMember = New Button()
        txtMemberAlamat = New TextBox()
        txtMemberNama = New TextBox()
        labelMemberAlamat = New Label()
        labelMemberNama = New Label()
        TabControl1.SuspendLayout()
        buatPeminjaman.SuspendLayout()
        CType(numDurasi, ComponentModel.ISupportInitialize).BeginInit()
        daftarPeminjaman.SuspendLayout()
        CType(dgvPeminjaman, ComponentModel.ISupportInitialize).BeginInit()
        daftarMember.SuspendLayout()
        CType(dgvMember, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' TabControl1
        ' 
        TabControl1.Controls.Add(buatPeminjaman)
        TabControl1.Controls.Add(daftarPeminjaman)
        TabControl1.Controls.Add(daftarMember)
        TabControl1.Location = New Point(12, 12)
        TabControl1.Name = "TabControl1"
        TabControl1.SelectedIndex = 0
        TabControl1.Size = New Size(776, 426)
        TabControl1.TabIndex = 0
        ' 
        ' buatPeminjaman
        ' 
        buatPeminjaman.Controls.Add(btnResetMemberId)
        buatPeminjaman.Controls.Add(btnCari)
        buatPeminjaman.Controls.Add(btnRedirectBuatMember)
        buatPeminjaman.Controls.Add(btnBuatPeminjaman)
        buatPeminjaman.Controls.Add(btnImportDataPeminjam)
        buatPeminjaman.Controls.Add(txtAlamat)
        buatPeminjaman.Controls.Add(labelAlamat)
        buatPeminjaman.Controls.Add(txtNama)
        buatPeminjaman.Controls.Add(labelNama)
        buatPeminjaman.Controls.Add(txtNoMember)
        buatPeminjaman.Controls.Add(labelNoMember)
        buatPeminjaman.Controls.Add(labelDataPeminjam)
        buatPeminjaman.Controls.Add(labelDataBuku)
        buatPeminjaman.Controls.Add(txtHarga)
        buatPeminjaman.Controls.Add(labelHarga)
        buatPeminjaman.Controls.Add(labelHari)
        buatPeminjaman.Controls.Add(numDurasi)
        buatPeminjaman.Controls.Add(labelDurasi)
        buatPeminjaman.Controls.Add(txtISBN)
        buatPeminjaman.Controls.Add(labelISBN)
        buatPeminjaman.Controls.Add(txtJudul)
        buatPeminjaman.Controls.Add(labelJudulBuku)
        buatPeminjaman.Location = New Point(4, 24)
        buatPeminjaman.Name = "buatPeminjaman"
        buatPeminjaman.Padding = New Padding(3)
        buatPeminjaman.Size = New Size(768, 398)
        buatPeminjaman.TabIndex = 0
        buatPeminjaman.Text = "Buat Peminjaman"
        buatPeminjaman.UseVisualStyleBackColor = True
        ' 
        ' btnResetMemberId
        ' 
        btnResetMemberId.Location = New Point(405, 220)
        btnResetMemberId.Name = "btnResetMemberId"
        btnResetMemberId.Size = New Size(81, 23)
        btnResetMemberId.TabIndex = 21
        btnResetMemberId.Text = "Reset"
        btnResetMemberId.UseVisualStyleBackColor = True
        ' 
        ' btnCari
        ' 
        btnCari.Location = New Point(318, 220)
        btnCari.Name = "btnCari"
        btnCari.Size = New Size(81, 23)
        btnCari.TabIndex = 20
        btnCari.Text = "Cari"
        btnCari.UseVisualStyleBackColor = True
        ' 
        ' btnRedirectBuatMember
        ' 
        btnRedirectBuatMember.Location = New Point(320, 187)
        btnRedirectBuatMember.Name = "btnRedirectBuatMember"
        btnRedirectBuatMember.Size = New Size(166, 23)
        btnRedirectBuatMember.TabIndex = 14
        btnRedirectBuatMember.Text = "Buat Member Baru"
        btnRedirectBuatMember.UseVisualStyleBackColor = True
        ' 
        ' btnBuatPeminjaman
        ' 
        btnBuatPeminjaman.Location = New Point(104, 359)
        btnBuatPeminjaman.Name = "btnBuatPeminjaman"
        btnBuatPeminjaman.Size = New Size(382, 23)
        btnBuatPeminjaman.TabIndex = 19
        btnBuatPeminjaman.Text = "Buat Peminjaman"
        btnBuatPeminjaman.UseVisualStyleBackColor = True
        ' 
        ' btnImportDataPeminjam
        ' 
        btnImportDataPeminjam.Location = New Point(148, 187)
        btnImportDataPeminjam.Name = "btnImportDataPeminjam"
        btnImportDataPeminjam.Size = New Size(166, 23)
        btnImportDataPeminjam.TabIndex = 12
        btnImportDataPeminjam.Text = "Import Data Member"
        btnImportDataPeminjam.UseVisualStyleBackColor = True
        ' 
        ' txtAlamat
        ' 
        txtAlamat.Enabled = False
        txtAlamat.Location = New Point(104, 278)
        txtAlamat.Multiline = True
        txtAlamat.Name = "txtAlamat"
        txtAlamat.Size = New Size(382, 65)
        txtAlamat.TabIndex = 18
        ' 
        ' labelAlamat
        ' 
        labelAlamat.AutoSize = True
        labelAlamat.Location = New Point(14, 281)
        labelAlamat.Name = "labelAlamat"
        labelAlamat.Size = New Size(45, 15)
        labelAlamat.TabIndex = 15
        labelAlamat.Text = "Alamat"
        ' 
        ' txtNama
        ' 
        txtNama.Enabled = False
        txtNama.Location = New Point(104, 249)
        txtNama.Name = "txtNama"
        txtNama.Size = New Size(382, 23)
        txtNama.TabIndex = 17
        ' 
        ' labelNama
        ' 
        labelNama.AutoSize = True
        labelNama.Location = New Point(14, 252)
        labelNama.Name = "labelNama"
        labelNama.Size = New Size(39, 15)
        labelNama.TabIndex = 13
        labelNama.Text = "Nama"
        ' 
        ' txtNoMember
        ' 
        txtNoMember.Location = New Point(104, 220)
        txtNoMember.Name = "txtNoMember"
        txtNoMember.Size = New Size(208, 23)
        txtNoMember.TabIndex = 16
        ' 
        ' labelNoMember
        ' 
        labelNoMember.AutoSize = True
        labelNoMember.Location = New Point(14, 223)
        labelNoMember.Name = "labelNoMember"
        labelNoMember.Size = New Size(74, 15)
        labelNoMember.TabIndex = 11
        labelNoMember.Text = "No. Member"
        ' 
        ' labelDataPeminjam
        ' 
        labelDataPeminjam.AutoSize = True
        labelDataPeminjam.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        labelDataPeminjam.Location = New Point(14, 186)
        labelDataPeminjam.Name = "labelDataPeminjam"
        labelDataPeminjam.Size = New Size(128, 21)
        labelDataPeminjam.TabIndex = 10
        labelDataPeminjam.Text = "Data Peminjam"
        ' 
        ' labelDataBuku
        ' 
        labelDataBuku.AutoSize = True
        labelDataBuku.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        labelDataBuku.Location = New Point(14, 9)
        labelDataBuku.Name = "labelDataBuku"
        labelDataBuku.Size = New Size(89, 21)
        labelDataBuku.TabIndex = 9
        labelDataBuku.Text = "Data Buku"
        ' 
        ' txtHarga
        ' 
        txtHarga.Location = New Point(104, 131)
        txtHarga.Name = "txtHarga"
        txtHarga.Size = New Size(382, 23)
        txtHarga.TabIndex = 8
        ' 
        ' labelHarga
        ' 
        labelHarga.AutoSize = True
        labelHarga.Location = New Point(14, 134)
        labelHarga.Name = "labelHarga"
        labelHarga.Size = New Size(39, 15)
        labelHarga.TabIndex = 7
        labelHarga.Text = "Harga"
        ' 
        ' labelHari
        ' 
        labelHari.AutoSize = True
        labelHari.Location = New Point(320, 104)
        labelHari.Name = "labelHari"
        labelHari.Size = New Size(29, 15)
        labelHari.TabIndex = 6
        labelHari.Text = "Hari"
        ' 
        ' numDurasi
        ' 
        numDurasi.Location = New Point(104, 102)
        numDurasi.Maximum = New Decimal(New Integer() {30, 0, 0, 0})
        numDurasi.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        numDurasi.Name = "numDurasi"
        numDurasi.Size = New Size(210, 23)
        numDurasi.TabIndex = 5
        numDurasi.Value = New Decimal(New Integer() {1, 0, 0, 0})
        ' 
        ' labelDurasi
        ' 
        labelDurasi.AutoSize = True
        labelDurasi.Location = New Point(14, 104)
        labelDurasi.Name = "labelDurasi"
        labelDurasi.Size = New Size(40, 15)
        labelDurasi.TabIndex = 4
        labelDurasi.Text = "Durasi"
        ' 
        ' txtISBN
        ' 
        txtISBN.Location = New Point(104, 73)
        txtISBN.Name = "txtISBN"
        txtISBN.Size = New Size(382, 23)
        txtISBN.TabIndex = 3
        ' 
        ' labelISBN
        ' 
        labelISBN.AutoSize = True
        labelISBN.Location = New Point(14, 76)
        labelISBN.Name = "labelISBN"
        labelISBN.Size = New Size(32, 15)
        labelISBN.TabIndex = 2
        labelISBN.Text = "ISBN"
        ' 
        ' txtJudul
        ' 
        txtJudul.Location = New Point(104, 44)
        txtJudul.Name = "txtJudul"
        txtJudul.Size = New Size(382, 23)
        txtJudul.TabIndex = 1
        ' 
        ' labelJudulBuku
        ' 
        labelJudulBuku.AutoSize = True
        labelJudulBuku.Location = New Point(14, 47)
        labelJudulBuku.Name = "labelJudulBuku"
        labelJudulBuku.Size = New Size(65, 15)
        labelJudulBuku.TabIndex = 0
        labelJudulBuku.Text = "Judul Buku"
        ' 
        ' daftarPeminjaman
        ' 
        daftarPeminjaman.Controls.Add(dgvPeminjaman)
        daftarPeminjaman.Location = New Point(4, 24)
        daftarPeminjaman.Name = "daftarPeminjaman"
        daftarPeminjaman.Padding = New Padding(3)
        daftarPeminjaman.Size = New Size(768, 398)
        daftarPeminjaman.TabIndex = 1
        daftarPeminjaman.Text = "Daftar Peminjaman"
        daftarPeminjaman.UseVisualStyleBackColor = True
        ' 
        ' dgvPeminjaman
        ' 
        dgvPeminjaman.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvPeminjaman.Columns.AddRange(New DataGridViewColumn() {peminjamanId, peminjamanJudul, peminjamanISBN, peminjamanDurasi, tanggal, harga, peminjamanMemberId, peminjamanNama, peminjamanAlamat})
        dgvPeminjaman.Location = New Point(6, 6)
        dgvPeminjaman.Name = "dgvPeminjaman"
        dgvPeminjaman.ReadOnly = True
        dgvPeminjaman.Size = New Size(756, 386)
        dgvPeminjaman.TabIndex = 0
        ' 
        ' peminjamanId
        ' 
        peminjamanId.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        peminjamanId.DataPropertyName = "id"
        peminjamanId.HeaderText = "ID"
        peminjamanId.Name = "peminjamanId"
        peminjamanId.ReadOnly = True
        peminjamanId.Width = 43
        ' 
        ' peminjamanJudul
        ' 
        peminjamanJudul.DataPropertyName = "judul"
        peminjamanJudul.HeaderText = "Judul"
        peminjamanJudul.MinimumWidth = 50
        peminjamanJudul.Name = "peminjamanJudul"
        peminjamanJudul.ReadOnly = True
        ' 
        ' peminjamanISBN
        ' 
        peminjamanISBN.DataPropertyName = "isbn"
        peminjamanISBN.HeaderText = "ISBN"
        peminjamanISBN.MinimumWidth = 50
        peminjamanISBN.Name = "peminjamanISBN"
        peminjamanISBN.ReadOnly = True
        ' 
        ' peminjamanDurasi
        ' 
        peminjamanDurasi.DataPropertyName = "durasi"
        peminjamanDurasi.HeaderText = "Durasi (Hari)"
        peminjamanDurasi.MinimumWidth = 50
        peminjamanDurasi.Name = "peminjamanDurasi"
        peminjamanDurasi.ReadOnly = True
        ' 
        ' tanggal
        ' 
        tanggal.DataPropertyName = "tanggal"
        tanggal.HeaderText = "Tanggal"
        tanggal.MinimumWidth = 50
        tanggal.Name = "tanggal"
        tanggal.ReadOnly = True
        ' 
        ' harga
        ' 
        harga.DataPropertyName = "harga"
        harga.HeaderText = "Harga"
        harga.MinimumWidth = 50
        harga.Name = "harga"
        harga.ReadOnly = True
        ' 
        ' peminjamanMemberId
        ' 
        peminjamanMemberId.DataPropertyName = "memberId"
        peminjamanMemberId.HeaderText = "Member ID"
        peminjamanMemberId.MinimumWidth = 50
        peminjamanMemberId.Name = "peminjamanMemberId"
        peminjamanMemberId.ReadOnly = True
        ' 
        ' peminjamanNama
        ' 
        peminjamanNama.DataPropertyName = "nama"
        peminjamanNama.HeaderText = "Nama"
        peminjamanNama.MinimumWidth = 50
        peminjamanNama.Name = "peminjamanNama"
        peminjamanNama.ReadOnly = True
        ' 
        ' peminjamanAlamat
        ' 
        peminjamanAlamat.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        peminjamanAlamat.DataPropertyName = "alamat"
        peminjamanAlamat.HeaderText = "Alamat"
        peminjamanAlamat.MinimumWidth = 100
        peminjamanAlamat.Name = "peminjamanAlamat"
        peminjamanAlamat.ReadOnly = True
        ' 
        ' daftarMember
        ' 
        daftarMember.Controls.Add(Button3)
        daftarMember.Controls.Add(dgvMember)
        daftarMember.Controls.Add(btnBuatMember)
        daftarMember.Controls.Add(txtMemberAlamat)
        daftarMember.Controls.Add(txtMemberNama)
        daftarMember.Controls.Add(labelMemberAlamat)
        daftarMember.Controls.Add(labelMemberNama)
        daftarMember.Location = New Point(4, 24)
        daftarMember.Name = "daftarMember"
        daftarMember.Padding = New Padding(3)
        daftarMember.Size = New Size(768, 398)
        daftarMember.TabIndex = 2
        daftarMember.Text = "Daftar Member"
        daftarMember.UseVisualStyleBackColor = True
        ' 
        ' Button3
        ' 
        Button3.Location = New Point(77, 6)
        Button3.Name = "Button3"
        Button3.Size = New Size(147, 23)
        Button3.TabIndex = 8
        Button3.Text = "Import Data Member"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' dgvMember
        ' 
        dgvMember.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvMember.Columns.AddRange(New DataGridViewColumn() {memberId, memberNama, memberAlamat})
        dgvMember.Location = New Point(306, 6)
        dgvMember.Name = "dgvMember"
        dgvMember.ReadOnly = True
        dgvMember.Size = New Size(456, 386)
        dgvMember.TabIndex = 5
        ' 
        ' memberId
        ' 
        memberId.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        memberId.DataPropertyName = "id"
        memberId.HeaderText = "ID"
        memberId.Name = "memberId"
        memberId.ReadOnly = True
        memberId.Width = 43
        ' 
        ' memberNama
        ' 
        memberNama.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        memberNama.DataPropertyName = "nama"
        memberNama.FillWeight = 70.12987F
        memberNama.HeaderText = "Nama"
        memberNama.MinimumWidth = 50
        memberNama.Name = "memberNama"
        memberNama.ReadOnly = True
        ' 
        ' memberAlamat
        ' 
        memberAlamat.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        memberAlamat.DataPropertyName = "alamat"
        memberAlamat.FillWeight = 129.870132F
        memberAlamat.HeaderText = "Alamat"
        memberAlamat.MinimumWidth = 100
        memberAlamat.Name = "memberAlamat"
        memberAlamat.ReadOnly = True
        ' 
        ' btnBuatMember
        ' 
        btnBuatMember.Location = New Point(77, 179)
        btnBuatMember.Name = "btnBuatMember"
        btnBuatMember.Size = New Size(205, 23)
        btnBuatMember.TabIndex = 4
        btnBuatMember.Text = "Buat Member"
        btnBuatMember.UseVisualStyleBackColor = True
        ' 
        ' txtMemberAlamat
        ' 
        txtMemberAlamat.Location = New Point(77, 64)
        txtMemberAlamat.Multiline = True
        txtMemberAlamat.Name = "txtMemberAlamat"
        txtMemberAlamat.Size = New Size(205, 109)
        txtMemberAlamat.TabIndex = 3
        ' 
        ' txtMemberNama
        ' 
        txtMemberNama.Location = New Point(77, 35)
        txtMemberNama.Name = "txtMemberNama"
        txtMemberNama.Size = New Size(205, 23)
        txtMemberNama.TabIndex = 2
        ' 
        ' labelMemberAlamat
        ' 
        labelMemberAlamat.AutoSize = True
        labelMemberAlamat.Location = New Point(13, 67)
        labelMemberAlamat.Name = "labelMemberAlamat"
        labelMemberAlamat.Size = New Size(45, 15)
        labelMemberAlamat.TabIndex = 1
        labelMemberAlamat.Text = "Alamat"
        ' 
        ' labelMemberNama
        ' 
        labelMemberNama.AutoSize = True
        labelMemberNama.Location = New Point(13, 38)
        labelMemberNama.Name = "labelMemberNama"
        labelMemberNama.Size = New Size(39, 15)
        labelMemberNama.TabIndex = 0
        labelMemberNama.Text = "Nama"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(TabControl1)
        Name = "Form1"
        Text = "Form1"
        TabControl1.ResumeLayout(False)
        buatPeminjaman.ResumeLayout(False)
        buatPeminjaman.PerformLayout()
        CType(numDurasi, ComponentModel.ISupportInitialize).EndInit()
        daftarPeminjaman.ResumeLayout(False)
        CType(dgvPeminjaman, ComponentModel.ISupportInitialize).EndInit()
        daftarMember.ResumeLayout(False)
        daftarMember.PerformLayout()
        CType(dgvMember, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents buatPeminjaman As TabPage
    Friend WithEvents labelISBN As Label
    Friend WithEvents txtJudul As TextBox
    Friend WithEvents labelJudulBuku As Label
    Friend WithEvents daftarPeminjaman As TabPage
    Friend WithEvents txtHarga As TextBox
    Friend WithEvents labelHarga As Label
    Friend WithEvents labelHari As Label
    Friend WithEvents numDurasi As NumericUpDown
    Friend WithEvents labelDurasi As Label
    Friend WithEvents txtISBN As TextBox
    Friend WithEvents labelDataBuku As Label
    Friend WithEvents labelDataPeminjam As Label
    Friend WithEvents txtNama As TextBox
    Friend WithEvents labelNama As Label
    Friend WithEvents txtNoMember As TextBox
    Friend WithEvents labelNoMember As Label
    Friend WithEvents txtAlamat As TextBox
    Friend WithEvents labelAlamat As Label
    Friend WithEvents btnBuatPeminjaman As Button
    Friend WithEvents btnImportDataPeminjam As Button
    Friend WithEvents btnRedirectBuatMember As Button
    Friend WithEvents daftarMember As TabPage
    Friend WithEvents txtMemberAlamat As TextBox
    Friend WithEvents txtMemberNama As TextBox
    Friend WithEvents labelMemberAlamat As Label
    Friend WithEvents labelMemberNama As Label
    Friend WithEvents btnBuatMember As Button
    Friend WithEvents btnCari As Button
    Friend WithEvents dgvPeminjaman As DataGridView
    Friend WithEvents dgvMember As DataGridView
    Friend WithEvents memberId As DataGridViewTextBoxColumn
    Friend WithEvents memberNama As DataGridViewTextBoxColumn
    Friend WithEvents memberAlamat As DataGridViewTextBoxColumn
    Friend WithEvents peminjamanId As DataGridViewTextBoxColumn
    Friend WithEvents peminjamanJudul As DataGridViewTextBoxColumn
    Friend WithEvents peminjamanISBN As DataGridViewTextBoxColumn
    Friend WithEvents peminjamanDurasi As DataGridViewTextBoxColumn
    Friend WithEvents tanggal As DataGridViewTextBoxColumn
    Friend WithEvents harga As DataGridViewTextBoxColumn
    Friend WithEvents peminjamanMemberId As DataGridViewTextBoxColumn
    Friend WithEvents peminjamanNama As DataGridViewTextBoxColumn
    Friend WithEvents peminjamanAlamat As DataGridViewTextBoxColumn
    Friend WithEvents Button3 As Button
    Friend WithEvents btnResetMemberId As Button

End Class
