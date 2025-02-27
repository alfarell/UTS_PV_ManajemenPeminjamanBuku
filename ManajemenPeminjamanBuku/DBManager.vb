Imports System.Data.SQLite

Public Class DBManager
    Dim connString As String = "Data Source=peminjaman_buku.db;Version=3;"
    Dim conn As New SQLiteConnection(connString)

    Public Sub CreateTable()
        Try
            conn.Open()
            Dim createPeminjaman As New SQLiteCommand(
                "CREATE TABLE IF NOT EXISTS PeminjamanBuku (
                    id INTEGER PRIMARY KEY AUTOINCREMENT, 
                    judul TEXT, 
                    isbn TEXT,
                    durasi TEXT,
                    harga TEXT,
                    tanggal TEXT,
                    memberId TEXT,
                    FOREIGN KEY (memberId) REFERENCES Member(id)
                );",
                conn
            )
            createPeminjaman.ExecuteNonQuery()
            Dim createMember As New SQLiteCommand(
                "CREATE TABLE IF NOT EXISTS Member (
                    id INTEGER PRIMARY KEY AUTOINCREMENT, 
                    nama TEXT NOT NULL, 
                    alamat TEXT NOT NULL
                );",
                conn
            )
            createMember.ExecuteNonQuery()
        Catch ex As Exception
            MessageBox.Show("create table error: " & ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    Public Function InsertPeminjaman(peminjaman As IPeminjaman) As Boolean
        Try
            conn.Open()

            Dim query As String = "
                INSERT INTO PeminjamanBuku (
                    judul,
                    isbn,
                    durasi,
                    harga,
                    tanggal,
                    memberId
                ) 
                VALUES (
                    @judul, 
                    @isbn, 
                    @durasi,
                    @harga,
                    @tanggal,
                    @memberId
                )
            "
            Using cmd As New SQLiteCommand(query, conn)
                cmd.Parameters.AddWithValue("@judul", peminjaman.Judul)
                cmd.Parameters.AddWithValue("@isbn", peminjaman.ISBN)
                cmd.Parameters.AddWithValue("@durasi", peminjaman.Durasi)
                cmd.Parameters.AddWithValue("@harga", peminjaman.Harga)
                cmd.Parameters.AddWithValue("@tanggal", peminjaman.Tanggal)
                cmd.Parameters.AddWithValue("@memberId", peminjaman.MemberId)
                cmd.ExecuteNonQuery()
            End Using

            MessageBox.Show("Data peminjaman berhasil ditambahkan!")
            Return True
        Catch ex As Exception
            MessageBox.Show("Insert peminjaman error: " & ex.Message)
            Return False
        Finally
            conn.Close()
        End Try
    End Function

    Public Function InsertMember(member As IMember) As Boolean
        Try
            conn.Open()

            Dim query As String = "
                INSERT INTO Member (nama, alamat) 
                VALUES (@nama, @alamat)
            "
            Using cmd As New SQLiteCommand(query, conn)
                cmd.Parameters.AddWithValue("@nama", member.Nama)
                cmd.Parameters.AddWithValue("@alamat", member.Alamat)
                cmd.ExecuteNonQuery()
            End Using

            MessageBox.Show("Data peminjaman berhasil ditambahkan!")
            Return True
        Catch ex As Exception
            MessageBox.Show("Insert member error: " & ex.Message)
            Return False
        Finally
            conn.Close()
        End Try
    End Function

    Public Function GetPeminjaman() As DataTable
        Dim dt As New DataTable()

        Try
            conn.Open()

            Dim query As String = "
                SELECT 
                    PeminjamanBuku.id AS id,
                    PeminjamanBuku.judul AS judul,
                    PeminjamanBuku.isbn AS isbn,
                    PeminjamanBuku.durasi AS durasi,
                    PeminjamanBuku.tanggal AS tanggal,
                    PeminjamanBuku.harga AS harga,
                    PeminjamanBuku.memberId AS memberId,
                    Member.nama AS nama,
                    Member.alamat AS alamat
                FROM 
                    PeminjamanBuku 
                INNER JOIN Member ON PeminjamanBuku.memberId = Member.id;
            "
            Using cmd As New SQLiteCommand(query, conn)
                Dim adapter As New SQLiteDataAdapter(cmd)
                adapter.Fill(dt)
            End Using
        Catch ex As Exception
            MessageBox.Show("Get Peminjaman Error: " & ex.Message)
        Finally
            conn.Close()
        End Try

        Return dt
    End Function

    Public Function GetMember() As DataTable
        Dim dt As New DataTable()

        Try
            conn.Open()

            Dim query As String = "SELECT * FROM Member"
            Using cmd As New SQLiteCommand(query, conn)
                Dim adapter As New SQLiteDataAdapter(cmd)
                adapter.Fill(dt)
            End Using
        Catch ex As Exception
            MessageBox.Show("Get Member Error: " & ex.Message)
        Finally
            conn.Close()
        End Try

        Return dt
    End Function

    Public Function GetMemberById(memberId As String) As Member
        Dim dt As New DataTable()
        Dim result As New Member()

        Try
            conn.Open()

            Dim query As String = "SELECT * FROM Member WHERE id = @memberId"
            Using cmd As New SQLiteCommand(query, conn)
                cmd.Parameters.AddWithValue("@memberId", memberId)
                Dim adapter As New SQLiteDataAdapter(cmd)
                adapter.Fill(dt)
            End Using
        Catch ex As Exception
            MessageBox.Show("Get Member by ID Error: " & ex.Message)
        Finally
            conn.Close()
        End Try

        If dt.Rows.Count > 0 Then
            Dim row As DataRow = dt.Rows(0)

            result.Id = row("id").ToString()
            result.Nama = row("nama").ToString()
            result.Alamat = row("alamat").ToString()
        End If

        Return result
    End Function
End Class
