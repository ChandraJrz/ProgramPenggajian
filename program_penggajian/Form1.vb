Imports System.Data
Imports System.Data.OleDb
Public Class Form1
    Sub KondisiAwal()
        TBNama.Enabled = False
        RBLaki.Enabled = False
        RBPerempuan.Enabled = False
        TBAlamat.Enabled = False
        TBTelp.Enabled = False
        CBStatus.Enabled = False
        CBJabatan.Enabled = False
        CBGaji.Enabled = False
        TBNama.Text = ""
        RBLaki.Checked = False
        RBPerempuan.Checked = False
        TBAlamat.Text = ""
        TBTelp.Text = ""
        CBStatus.Text = ""
        CBJabatan.Text = ""
        CBGaji.Text = ""
        LBGaji.Text = ""
        BTSimpan.Text = "TAMBAH"
        BTEdit.Enabled = False
        BTHapus.Enabled = False
        BTBatal.Enabled = False
    End Sub

    Sub TambahData()
        TBNama.Enabled = True
        RBLaki.Enabled = True
        RBPerempuan.Enabled = True
        TBAlamat.Enabled = True
        TBTelp.Enabled = True
        CBStatus.Enabled = True
        CBJabatan.Enabled = True
        CBGaji.Enabled = True
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call KondisiAwal()
        Call Koneksi()
        CBStatus.Items.Clear()
        CBStatus.Items.Add("Pekerja Tetap")
        CBStatus.Items.Add("Pekerja Sementara")
        CBJabatan.Items.Clear()
        CBJabatan.Items.Add("CEO")
        CBJabatan.Items.Add("General Manager")
        CBJabatan.Items.Add("Admin")
        CBJabatan.Items.Add("Karyawan")
        CBGaji.Items.Clear()
        OleCmd = New OleDbCommand("SELECT ID_Gaji FROM tbl_gaji", Cnn)
        OleRdr = OleCmd.ExecuteReader
        While OleRdr.Read()
            CBGaji.Items.Add(OleRdr.Item("ID_Gaji"))
        End While
    End Sub

    Private Sub BTDaftarGaji_Click(sender As Object, e As EventArgs) Handles BTDaftarGaji.Click
        Form3.ShowDialog()
    End Sub

    Private Sub BTPenggajian_Click(sender As Object, e As EventArgs) Handles BTPenggajian.Click
        Form2.ShowDialog()
    End Sub

    Private Sub BTSelesai_Click(sender As Object, e As EventArgs) Handles BTSelesai.Click
        Me.Close()
    End Sub

    Private Sub BTSimpan_Click(sender As Object, e As EventArgs) Handles BTSimpan.Click
        Call TambahData()
        Dim Kelamin As String
        If RBLaki.Checked = True Then
            Kelamin = "Laki-laki"
        ElseIf RBPerempuan.Checked = True Then
            Kelamin = "Perempuan"
        End If
        If BTSimpan.Text = "TAMBAH" Then
            BTSimpan.Text = "SIMPAN"
            BTBatal.Enabled = True
        Else
            If TBNama.Text = "" Or TBAlamat.Text = "" Or TBTelp.Text = "" Or CBStatus.Text = "" Or CBJabatan.Text = "" Or LBGaji.Text = "" Then
                MsgBox("Silahkan diisi semua kolom!")
            Else
                Call Koneksi()
                Dim InputData As String = "INSERT INTO tbl_karyawan (Nama_Karyawan,Jenis_Kelamin,Alamat,Nomor_Telp,Status_Kerja,Jabatan,ID_Gaji) VALUES('" & TBNama.Text & "','" & Kelamin & "','" & TBAlamat.Text & "','" & TBTelp.Text & "','" & CBStatus.Text & "','" & CBJabatan.Text & "','" & CBGaji.Text & "')"
                OleCmd = New OleDbCommand(InputData, Cnn)
                OleCmd.ExecuteNonQuery()
                MsgBox("Tambah Data Berhasil")
                Call KondisiAwal()
            End If
        End If
    End Sub

    Private Sub CBGaji_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CBGaji.SelectedIndexChanged
        Call Koneksi()
        OleCmd = New OleDbCommand("SELECT Gaji_Pokok FROM tbl_gaji WHERE ID_Gaji = '" & CBGaji.Text & "'", Cnn)
        OleRdr = OleCmd.ExecuteReader()
        While OleRdr.Read()
            LBGaji.Text = OleRdr.Item("Gaji_Pokok")
        End While
    End Sub

    Private Sub BTBatal_Click(sender As Object, e As EventArgs) Handles BTBatal.Click
        Call KondisiAwal()
    End Sub
End Class
