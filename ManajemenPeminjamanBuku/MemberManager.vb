Public Class MemberManager
    Private dbManager As DBManager

    Public Sub New(dbManager As DBManager)
        Me.dbManager = dbManager
    End Sub

    Public Sub LoadMemberToDataGridView(dgvMember As DataGridView)
        Dim dtMember As DataTable = dbManager.GetMember()
        dgvMember.DataSource = dtMember
    End Sub

    Public Sub BuatMember(txtMemberNama As TextBox, txtMemberAlamat As TextBox, dgvMember As DataGridView)
        Dim member As New Member
        member.Nama = txtMemberNama.Text
        member.Alamat = txtMemberAlamat.Text

        If String.IsNullOrEmpty(member.Nama) Or
            String.IsNullOrEmpty(member.Alamat) Then

            MessageBox.Show(
                "Nama dan Alamat wajib diisi!",
                "Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
            )

            Return
        End If

        Dim res = dbManager.InsertMember(member)

        If True = res Then
            ResetFormMember(txtMemberNama, txtMemberAlamat)
            LoadMemberToDataGridView(dgvMember)
        End If
    End Sub

    Public Sub ResetFormMember(txtMemberNama As TextBox, txtMemberAlamat As TextBox)
        txtMemberNama.Clear()
        txtMemberAlamat.Clear()
    End Sub

    Public Sub FindAndFillMemberFields(memberId As String, txtNama As TextBox, txtAlamat As TextBox)
        Dim dtMember = dbManager.GetMemberById(memberId)

        If Not String.IsNullOrEmpty(dtMember.Id) AndAlso
           Not String.IsNullOrEmpty(dtMember.Nama) AndAlso
           Not String.IsNullOrEmpty(dtMember.Alamat) Then

            txtNama.Text = dtMember.Nama
            txtAlamat.Text = dtMember.Alamat
        Else
            MessageBox.Show(
                "Member dengan ID tersebut tidak ditemukan!",
                "Info",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            )
            txtNama.Clear()
            txtAlamat.Clear()
        End If
    End Sub

    Public Function LoadMemberFile() As Member
        Dim openFileDialog As New OpenFileDialog()
        openFileDialog.Filter = "Text Files (*.txt)|*.txt"
        openFileDialog.Title = "Select a Text File"

        Dim member As New Member()

        If openFileDialog.ShowDialog() = DialogResult.OK Then
            Dim filePath As String = openFileDialog.FileName
            Dim lines() As String = IO.File.ReadAllLines(filePath)

            For Each line As String In lines
                Dim parts() As String = line.Split("="c)
                If parts.Length = 2 Then
                    Dim key As String = parts(0).Trim().ToLower()
                    Dim value As String = parts(1).Trim().Trim(""""c)

                    Select Case key
                        Case "id"
                            member.Id = value
                        Case "nama"
                            member.Nama = value
                        Case "alamat"
                            member.Alamat = value
                    End Select
                End If
            Next
        End If

        Return member
    End Function
End Class
