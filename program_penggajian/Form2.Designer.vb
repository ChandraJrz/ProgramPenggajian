<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.CBNama = New System.Windows.Forms.ComboBox()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.LBStatus = New System.Windows.Forms.Label()
        Me.LBJabatan = New System.Windows.Forms.Label()
        Me.LBGajiPokok = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.LBKerajinan = New System.Windows.Forms.Label()
        Me.CBCuti = New System.Windows.Forms.ComboBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.LBTunjangan = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.LBGajiLembur = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.CBJamLembur = New System.Windows.Forms.ComboBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.LBTotalGaji = New System.Windows.Forms.Label()
        Me.BTSimpan = New System.Windows.Forms.Button()
        Me.BTBatal = New System.Windows.Forms.Button()
        Me.BTSelesai = New System.Windows.Forms.Button()
        Me.BTHitung = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(316, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(196, 32)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "PENGGAJIAN"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label2.Location = New System.Drawing.Point(84, 110)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(45, 17)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nama"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(84, 242)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(60, 17)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Tanggal"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(15, 45)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(76, 17)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Gaji Pokok"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(15, 84)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(76, 17)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Tunjangan"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(14, 44)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(98, 17)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Total Hari Cuti"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(14, 80)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(68, 17)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Kerajinan"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(17, 44)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(122, 17)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "Total Jam Lembur"
        '
        'CBNama
        '
        Me.CBNama.FormattingEnabled = True
        Me.CBNama.Location = New System.Drawing.Point(210, 108)
        Me.CBNama.Name = "CBNama"
        Me.CBNama.Size = New System.Drawing.Size(201, 24)
        Me.CBNama.TabIndex = 8
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(210, 237)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(200, 22)
        Me.DateTimePicker1.TabIndex = 9
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(84, 154)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(85, 17)
        Me.Label9.TabIndex = 10
        Me.Label9.Text = "Status Kerja"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(85, 197)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(59, 17)
        Me.Label10.TabIndex = 11
        Me.Label10.Text = "Jabatan"
        '
        'LBStatus
        '
        Me.LBStatus.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LBStatus.Location = New System.Drawing.Point(210, 148)
        Me.LBStatus.Name = "LBStatus"
        Me.LBStatus.Size = New System.Drawing.Size(201, 23)
        Me.LBStatus.TabIndex = 12
        Me.LBStatus.Text = "LBStatus"
        '
        'LBJabatan
        '
        Me.LBJabatan.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LBJabatan.Location = New System.Drawing.Point(210, 197)
        Me.LBJabatan.Name = "LBJabatan"
        Me.LBJabatan.Size = New System.Drawing.Size(200, 23)
        Me.LBJabatan.TabIndex = 13
        Me.LBJabatan.Text = "LBJabatan"
        '
        'LBGajiPokok
        '
        Me.LBGajiPokok.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LBGajiPokok.Location = New System.Drawing.Point(155, 45)
        Me.LBGajiPokok.Name = "LBGajiPokok"
        Me.LBGajiPokok.Size = New System.Drawing.Size(136, 23)
        Me.LBGajiPokok.TabIndex = 14
        Me.LBGajiPokok.Text = "LBGajiPokok"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.LBKerajinan)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.CBCuti)
        Me.GroupBox1.Location = New System.Drawing.Point(88, 419)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(323, 135)
        Me.GroupBox1.TabIndex = 15
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Cuti"
        '
        'LBKerajinan
        '
        Me.LBKerajinan.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LBKerajinan.Location = New System.Drawing.Point(157, 80)
        Me.LBKerajinan.Name = "LBKerajinan"
        Me.LBKerajinan.Size = New System.Drawing.Size(133, 24)
        Me.LBKerajinan.TabIndex = 7
        Me.LBKerajinan.Text = "LBKerajinan"
        '
        'CBCuti
        '
        Me.CBCuti.FormattingEnabled = True
        Me.CBCuti.Location = New System.Drawing.Point(157, 37)
        Me.CBCuti.Name = "CBCuti"
        Me.CBCuti.Size = New System.Drawing.Size(73, 24)
        Me.CBCuti.TabIndex = 8
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.LBTunjangan)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.LBGajiPokok)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Location = New System.Drawing.Point(87, 278)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(323, 135)
        Me.GroupBox2.TabIndex = 16
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Gaji Pokok"
        '
        'LBTunjangan
        '
        Me.LBTunjangan.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LBTunjangan.ForeColor = System.Drawing.Color.Black
        Me.LBTunjangan.Location = New System.Drawing.Point(155, 84)
        Me.LBTunjangan.Name = "LBTunjangan"
        Me.LBTunjangan.Size = New System.Drawing.Size(136, 23)
        Me.LBTunjangan.TabIndex = 15
        Me.LBTunjangan.Text = "LBTunjangan"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.LBGajiLembur)
        Me.GroupBox3.Controls.Add(Me.Label15)
        Me.GroupBox3.Controls.Add(Me.Label8)
        Me.GroupBox3.Controls.Add(Me.CBJamLembur)
        Me.GroupBox3.Location = New System.Drawing.Point(446, 110)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(322, 152)
        Me.GroupBox3.TabIndex = 17
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Lembur"
        '
        'LBGajiLembur
        '
        Me.LBGajiLembur.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LBGajiLembur.Location = New System.Drawing.Point(164, 81)
        Me.LBGajiLembur.Name = "LBGajiLembur"
        Me.LBGajiLembur.Size = New System.Drawing.Size(133, 23)
        Me.LBGajiLembur.TabIndex = 9
        Me.LBGajiLembur.Text = "LBGajiLembur"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(17, 87)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(85, 17)
        Me.Label15.TabIndex = 8
        Me.Label15.Text = "Gaji Lembur"
        '
        'CBJamLembur
        '
        Me.CBJamLembur.FormattingEnabled = True
        Me.CBJamLembur.Location = New System.Drawing.Point(164, 44)
        Me.CBJamLembur.Name = "CBJamLembur"
        Me.CBJamLembur.Size = New System.Drawing.Size(73, 24)
        Me.CBJamLembur.TabIndex = 8
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(443, 329)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(69, 17)
        Me.Label14.TabIndex = 18
        Me.Label14.Text = "Total Gaji"
        '
        'LBTotalGaji
        '
        Me.LBTotalGaji.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LBTotalGaji.Location = New System.Drawing.Point(610, 329)
        Me.LBTotalGaji.Name = "LBTotalGaji"
        Me.LBTotalGaji.Size = New System.Drawing.Size(154, 23)
        Me.LBTotalGaji.TabIndex = 9
        Me.LBTotalGaji.Text = "LBTotalGaji"
        '
        'BTSimpan
        '
        Me.BTSimpan.Location = New System.Drawing.Point(446, 419)
        Me.BTSimpan.Name = "BTSimpan"
        Me.BTSimpan.Size = New System.Drawing.Size(102, 47)
        Me.BTSimpan.TabIndex = 19
        Me.BTSimpan.Text = "SIMPAN"
        Me.BTSimpan.UseVisualStyleBackColor = True
        '
        'BTBatal
        '
        Me.BTBatal.Location = New System.Drawing.Point(554, 419)
        Me.BTBatal.Name = "BTBatal"
        Me.BTBatal.Size = New System.Drawing.Size(102, 47)
        Me.BTBatal.TabIndex = 19
        Me.BTBatal.Text = "BATAL"
        Me.BTBatal.UseVisualStyleBackColor = True
        '
        'BTSelesai
        '
        Me.BTSelesai.Location = New System.Drawing.Point(662, 419)
        Me.BTSelesai.Name = "BTSelesai"
        Me.BTSelesai.Size = New System.Drawing.Size(102, 47)
        Me.BTSelesai.TabIndex = 19
        Me.BTSelesai.Text = "SELESAI"
        Me.BTSelesai.UseVisualStyleBackColor = True
        '
        'BTHitung
        '
        Me.BTHitung.Location = New System.Drawing.Point(683, 278)
        Me.BTHitung.Name = "BTHitung"
        Me.BTHitung.Size = New System.Drawing.Size(85, 34)
        Me.BTHitung.TabIndex = 20
        Me.BTHitung.Text = "Hitung"
        Me.BTHitung.UseVisualStyleBackColor = True
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(848, 606)
        Me.Controls.Add(Me.BTHitung)
        Me.Controls.Add(Me.BTSelesai)
        Me.Controls.Add(Me.BTBatal)
        Me.Controls.Add(Me.BTSimpan)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.LBTotalGaji)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.LBJabatan)
        Me.Controls.Add(Me.LBStatus)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.CBNama)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form2"
        Me.Text = "Form Penggajian"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents CBNama As ComboBox
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents LBStatus As Label
    Friend WithEvents LBJabatan As Label
    Friend WithEvents LBGajiPokok As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents LBKerajinan As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents LBTunjangan As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents LBGajiLembur As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents LBTotalGaji As Label
    Friend WithEvents CBCuti As ComboBox
    Friend WithEvents CBJamLembur As ComboBox
    Friend WithEvents BTSimpan As Button
    Friend WithEvents BTBatal As Button
    Friend WithEvents BTSelesai As Button
    Friend WithEvents BTHitung As Button
End Class
