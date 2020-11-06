Imports System.Data
Imports System.Data.OleDb
Public Class Form2
    Sub KondisiAwal()
        CBNama.Text = ""
        LBStatus.Text = ""
        LBJabatan.Text = ""
        DateTimePicker1.Value = DateTime.Now
        LBGajiPokok.Text = ""
        LBTunjangan.Text = ""
        CBCuti.Text = ""
        LBKerajinan.Text = ""
        CBJamLembur.Text = ""
        LBGajiLembur.Text = ""
        LBTotalGaji.Text = ""
    End Sub
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call KondisiAwal()
        CBNama.Items.Clear()
        OleCmd = New OleDbCommand("SELECT Nama_Karyawan FROM tbl_karyawan", Cnn)
        OleRdr = OleCmd.ExecuteReader()
        While OleRdr.Read()
            CBNama.Items.Add(OleRdr.Item("Nama_Karyawan"))
        End While
        CBCuti.Items.Clear()
        CBJamLembur.Items.Clear()
        For i As Integer = 0 To 50
            CBCuti.Items.Add(i)
            CBJamLembur.Items.Add(i)
        Next
    End Sub
    Private Sub BTBatal_Click(sender As Object, e As EventArgs) Handles BTBatal.Click
        Call KondisiAwal()
    End Sub

    Private Sub BTSelesai_Click(sender As Object, e As EventArgs) Handles BTSelesai.Click
        Me.Close()
    End Sub

    Private Sub CBCuti_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CBCuti.SelectedIndexChanged
        LBKerajinan.Text = Val(CBCuti.Text) * -10000
    End Sub

    Private Sub CBJamLembur_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CBJamLembur.SelectedIndexChanged
        LBGajiLembur.Text = Val(CBJamLembur.Text) * 20000
    End Sub

    Private Sub CBNama_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CBNama.SelectedIndexChanged
        Call Koneksi()
        OleCmd = New OleDbCommand("SELECT * FROM tbl_karyawan LEFT JOIN tbl_gaji ON tbl_karyawan.ID_Gaji = tbl_gaji.ID_Gaji WHERE Nama_Karyawan = '" & CBNama.Text & "'", Cnn)
        OleRdr = OleCmd.ExecuteReader()
        While OleRdr.Read()
            LBStatus.Text = OleRdr.Item("Status_Kerja")
            LBJabatan.Text = OleRdr.Item("Jabatan")
            LBGajiPokok.Text = OleRdr.Item("Gaji_Pokok")
            LBTunjangan.Text = OleRdr.Item("Tunjangan")
        End While
    End Sub

    Private Sub BTHitung_Click(sender As Object, e As EventArgs) Handles BTHitung.Click
        LBTotalGaji.Text = Val(LBGajiPokok.Text) + Val(LBTunjangan.Text) + Val(LBKerajinan.Text) + Val(LBGajiLembur.Text)
    End Sub

    Private Sub BTSimpan_Click(sender As Object, e As EventArgs) Handles BTSimpan.Click
        If LBTotalGaji.Text = "" Then
            MsgBox("Silahkan diisi semua kolom!")
        Else
            Call Koneksi()
            Dim InputData As String = "INSERT INTO tbl_penggajian (Nama,Gaji_Kerajinan,Gaji_Lembur,Gaji_Bersih) VALUES('" & CBNama.Text & "','" & Val(LBKerajinan.Text) & "','" & Val(LBGajiLembur.Text) & "','" & Val(LBTotalGaji.Text) & "')"
            OleCmd = New OleDbCommand(InputData, Cnn)
            OleCmd.ExecuteNonQuery()
            MsgBox("Tambah Data Berhasil")
            Call KondisiAwal()
        End If
    End Sub
End Class