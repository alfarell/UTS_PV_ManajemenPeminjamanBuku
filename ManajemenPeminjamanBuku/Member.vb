Public Interface IMember
    Property Id As String
    Property Nama As String
    Property Alamat As String
End Interface

Public Class Member
    Implements IMember

    Public Property Id As String Implements IMember.Id
    Public Property Nama As String Implements IMember.Nama
    Public Property Alamat As String Implements IMember.Alamat
End Class
