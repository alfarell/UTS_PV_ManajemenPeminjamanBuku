Public Interface IPeminjaman
    Property Id As String
    Property Judul As String
    Property ISBN As String
    Property Durasi As String
    Property Tanggal As String
    Property Harga As String
    Property MemberId As String
End Interface

Public Class Peminjaman
    Implements IPeminjaman

    Public Property Id As String Implements IPeminjaman.Id
    Public Property Judul As String Implements IPeminjaman.Judul
    Public Property ISBN As String Implements IPeminjaman.ISBN
    Public Property Durasi As String Implements IPeminjaman.Durasi
    Public Property Tanggal As String Implements IPeminjaman.Tanggal
    Public Property Harga As String Implements IPeminjaman.Harga
    Public Property MemberId As String Implements IPeminjaman.MemberId
End Class