<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.BTSimpan = New System.Windows.Forms.Button()
        Me.BTEdit = New System.Windows.Forms.Button()
        Me.BTHapus = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TBNama = New System.Windows.Forms.TextBox()
        Me.RBLaki = New System.Windows.Forms.RadioButton()
        Me.RBPerempuan = New System.Windows.Forms.RadioButton()
        Me.TBAlamat = New System.Windows.Forms.TextBox()
        Me.TBTelp = New System.Windows.Forms.TextBox()
        Me.CBStatus = New System.Windows.Forms.ComboBox()
        Me.CBJabatan = New System.Windows.Forms.ComboBox()
        Me.CBGaji = New System.Windows.Forms.ComboBox()
        Me.BTBatal = New System.Windows.Forms.Button()
        Me.BTDaftarGaji = New System.Windows.Forms.Button()
        Me.BTPenggajian = New System.Windows.Forms.Button()
        Me.BTSelesai = New System.Windows.Forms.Button()
        Me.LBGaji = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'BTSimpan
        '
        Me.BTSimpan.Location = New System.Drawing.Point(169, 423)
        Me.BTSimpan.Name = "BTSimpan"
        Me.BTSimpan.Size = New System.Drawing.Size(83, 30)
        Me.BTSimpan.TabIndex = 0
        Me.BTSimpan.Text = "TAMBAH"
        Me.BTSimpan.UseVisualStyleBackColor = True
        '
        'BTEdit
        '
        Me.BTEdit.Location = New System.Drawing.Point(258, 423)
        Me.BTEdit.Name = "BTEdit"
        Me.BTEdit.Size = New System.Drawing.Size(83, 30)
        Me.BTEdit.TabIndex = 1
        Me.BTEdit.Text = "EDIT"
        Me.BTEdit.UseVisualStyleBackColor = True
        '
        'BTHapus
        '
        Me.BTHapus.Location = New System.Drawing.Point(347, 423)
        Me.BTHapus.Name = "BTHapus"
        Me.BTHapus.Size = New System.Drawing.Size(83, 30)
        Me.BTHapus.TabIndex = 2
        Me.BTHapus.Text = "HAPUS"
        Me.BTHapus.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(217, 39)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(258, 32)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "DATA KARYAWAN"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(155, 118)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(45, 17)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Nama"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(155, 158)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(95, 17)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Jenis Kelamin"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(155, 198)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(51, 17)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Alamat"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(155, 238)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(62, 17)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "No. Telp"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(155, 278)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(85, 17)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "Status Kerja"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(155, 318)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(59, 17)
        Me.Label7.TabIndex = 9
        Me.Label7.Text = "Jabatan"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(155, 358)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(76, 17)
        Me.Label8.TabIndex = 10
        Me.Label8.Text = "Gaji Pokok"
        '
        'TBNama
        '
        Me.TBNama.Location = New System.Drawing.Point(292, 118)
        Me.TBNama.Name = "TBNama"
        Me.TBNama.Size = New System.Drawing.Size(244, 22)
        Me.TBNama.TabIndex = 11
        '
        'RBLaki
        '
        Me.RBLaki.AutoSize = True
        Me.RBLaki.Location = New System.Drawing.Point(292, 154)
        Me.RBLaki.Name = "RBLaki"
        Me.RBLaki.Size = New System.Drawing.Size(81, 21)
        Me.RBLaki.TabIndex = 12
        Me.RBLaki.TabStop = True
        Me.RBLaki.Text = "Laki-laki"
        Me.RBLaki.UseVisualStyleBackColor = True
        '
        'RBPerempuan
        '
        Me.RBPerempuan.AutoSize = True
        Me.RBPerempuan.Location = New System.Drawing.Point(434, 154)
        Me.RBPerempuan.Name = "RBPerempuan"
        Me.RBPerempuan.Size = New System.Drawing.Size(102, 21)
        Me.RBPerempuan.TabIndex = 13
        Me.RBPerempuan.TabStop = True
        Me.RBPerempuan.Text = "Perempuan"
        Me.RBPerempuan.UseVisualStyleBackColor = True
        '
        'TBAlamat
        '
        Me.TBAlamat.Location = New System.Drawing.Point(292, 198)
        Me.TBAlamat.Name = "TBAlamat"
        Me.TBAlamat.Size = New System.Drawing.Size(244, 22)
        Me.TBAlamat.TabIndex = 14
        '
        'TBTelp
        '
        Me.TBTelp.Location = New System.Drawing.Point(292, 238)
        Me.TBTelp.Name = "TBTelp"
        Me.TBTelp.Size = New System.Drawing.Size(244, 22)
        Me.TBTelp.TabIndex = 15
        '
        'CBStatus
        '
        Me.CBStatus.FormattingEnabled = True
        Me.CBStatus.Location = New System.Drawing.Point(292, 275)
        Me.CBStatus.Name = "CBStatus"
        Me.CBStatus.Size = New System.Drawing.Size(244, 24)
        Me.CBStatus.TabIndex = 16
        '
        'CBJabatan
        '
        Me.CBJabatan.FormattingEnabled = True
        Me.CBJabatan.Location = New System.Drawing.Point(292, 318)
        Me.CBJabatan.Name = "CBJabatan"
        Me.CBJabatan.Size = New System.Drawing.Size(244, 24)
        Me.CBJabatan.TabIndex = 17
        '
        'CBGaji
        '
        Me.CBGaji.FormattingEnabled = True
        Me.CBGaji.Location = New System.Drawing.Point(292, 355)
        Me.CBGaji.Name = "CBGaji"
        Me.CBGaji.Size = New System.Drawing.Size(95, 24)
        Me.CBGaji.TabIndex = 18
        '
        'BTBatal
        '
        Me.BTBatal.Location = New System.Drawing.Point(436, 423)
        Me.BTBatal.Name = "BTBatal"
        Me.BTBatal.Size = New System.Drawing.Size(83, 30)
        Me.BTBatal.TabIndex = 20
        Me.BTBatal.Text = "BATAL"
        Me.BTBatal.UseVisualStyleBackColor = True
        '
        'BTDaftarGaji
        '
        Me.BTDaftarGaji.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.BTDaftarGaji.Location = New System.Drawing.Point(589, 118)
        Me.BTDaftarGaji.Name = "BTDaftarGaji"
        Me.BTDaftarGaji.Size = New System.Drawing.Size(158, 57)
        Me.BTDaftarGaji.TabIndex = 21
        Me.BTDaftarGaji.Text = "DAFTAR GAJI"
        Me.BTDaftarGaji.UseVisualStyleBackColor = True
        '
        'BTPenggajian
        '
        Me.BTPenggajian.Location = New System.Drawing.Point(589, 198)
        Me.BTPenggajian.Name = "BTPenggajian"
        Me.BTPenggajian.Size = New System.Drawing.Size(158, 57)
        Me.BTPenggajian.TabIndex = 22
        Me.BTPenggajian.Text = "PENGGAJIAN"
        Me.BTPenggajian.UseVisualStyleBackColor = True
        '
        'BTSelesai
        '
        Me.BTSelesai.Location = New System.Drawing.Point(589, 278)
        Me.BTSelesai.Name = "BTSelesai"
        Me.BTSelesai.Size = New System.Drawing.Size(158, 57)
        Me.BTSelesai.TabIndex = 22
        Me.BTSelesai.Text = "SELESAI"
        Me.BTSelesai.UseVisualStyleBackColor = True
        '
        'LBGaji
        '
        Me.LBGaji.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LBGaji.Location = New System.Drawing.Point(393, 355)
        Me.LBGaji.Name = "LBGaji"
        Me.LBGaji.Size = New System.Drawing.Size(143, 23)
        Me.LBGaji.TabIndex = 23
        Me.LBGaji.Text = "LBGaji"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(854, 547)
        Me.Controls.Add(Me.LBGaji)
        Me.Controls.Add(Me.BTSelesai)
        Me.Controls.Add(Me.BTPenggajian)
        Me.Controls.Add(Me.BTDaftarGaji)
        Me.Controls.Add(Me.BTBatal)
        Me.Controls.Add(Me.CBGaji)
        Me.Controls.Add(Me.CBJabatan)
        Me.Controls.Add(Me.CBStatus)
        Me.Controls.Add(Me.TBTelp)
        Me.Controls.Add(Me.TBAlamat)
        Me.Controls.Add(Me.RBPerempuan)
        Me.Controls.Add(Me.RBLaki)
        Me.Controls.Add(Me.TBNama)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BTHapus)
        Me.Controls.Add(Me.BTEdit)
        Me.Controls.Add(Me.BTSimpan)
        Me.Name = "Form1"
        Me.Text = "Main Menu"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BTSimpan As Button
    Friend WithEvents BTEdit As Button
    Friend WithEvents BTHapus As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents TBNama As TextBox
    Friend WithEvents RBLaki As RadioButton
    Friend WithEvents RBPerempuan As RadioButton
    Friend WithEvents TBAlamat As TextBox
    Friend WithEvents TBTelp As TextBox
    Friend WithEvents CBStatus As ComboBox
    Friend WithEvents CBJabatan As ComboBox
    Friend WithEvents CBGaji As ComboBox
    Friend WithEvents BTBatal As Button
    Friend WithEvents BTDaftarGaji As Button
    Friend WithEvents BTPenggajian As Button
    Friend WithEvents BTSelesai As Button
    Friend WithEvents LBGaji As Label
End Class
