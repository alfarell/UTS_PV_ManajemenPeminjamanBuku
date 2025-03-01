# Aplikasi Manajemen Peminjaman Buku Perpustakaan

Aplikasi ini dirancang untuk mengelola peminjaman buku di perpustakaan. Aplikasi memiliki tiga tab utama: Peminjaman Buku, Daftar Peminjaman, dan Manajemen Member.

## Fitur Aplikasi

### 1. Tab Buat Peminjaman
- **Field Data Buku**:
  - Judul Buku
  - ISBN
  - Durasi
  - Harga
- **Field Data Profil Member**:
  - Nomor Member
  - Nama
  - Alamat
- **Tombol Import File TXT**:
  - Mengimpor file TXT yang berisi data member dengan format: 
    ```
    id="member-id"
    nama="nama-member"
    alamat="alamat-member"
    ```
- **Tombol Buat**:
  - Menyimpan data peminjaman buku ke database.

### 2. Tab Daftar Peminjaman
- Menampilkan daftar peminjaman buku dalam bentuk tabel (`DataGridView`).
- Kolom yang ditampilkan:
  - ID Peminjaman
  - Judul Buku
  - ISBN
  - Durasi
  - Harga
  - Nomor Member
  - Nama Member
  - Alamat Member
  - Tanggal Pinjam

### 3. Tab Daftar Member
- **Form Tambah Member**:
  - Nomor Member
  - Nama
  - Alamat
  - Tombol Simpan
- **Daftar Member**:
  - Menampilkan daftar member dalam bentuk tabel (`DataGridView`).
  - Kolom yang ditampilkan:
    - ID Member
    - Nama
    - Alamat

## Cara Menggunakan

### 1. Menambahkan Buat Peminjaman
- Buka **Tab Peminjaman Buku**.
- Isi field data buku dan data member.
- Tekan tombol **Buat**.

### 2. Melihat Daftar Peminjaman
- Buka **Tab Daftar Peminjaman**.
- Daftar peminjaman akan otomatis ditampilkan.

### 3. Menambahkan Member
- Buka **Tab Manajemen Member**.
- Isi form tambah member.
- Tekan tombol **Simpan**.

### 4. Mengimpor Data Member
- Buka **Tab Peminjaman Buku**.
- Tekan tombol **Import File TXT**.
- Pilih file TXT yang berisi data member.

## Struktur Database

Aplikasi menggunakan database SQLite dengan dua tabel utama:

1. **Tabel Member**:
   - `Id` (Primary Key, Auto Increment)
   - `Nama` (TEXT)
   - `Alamat` (TEXT)

2. **Tabel PeminjamanBuku**:
   - `Id` (Primary Key, Auto Increment)
   - `JudulBuku` (TEXT)
   - `ISBN` (TEXT)
   - `Durasi` (INTEGER)
   - `Harga` (REAL)
   - `MemberId` (Foreign Key ke tabel Member)
   - `TanggalPinjam` (TEXT)
