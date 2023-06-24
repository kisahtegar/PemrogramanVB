<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class InputDataBarang
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
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.tbKodeBarang = New System.Windows.Forms.TextBox
        Me.tbNamaBarang = New System.Windows.Forms.TextBox
        Me.tbJumlah = New System.Windows.Forms.TextBox
        Me.tbHarga = New System.Windows.Forms.TextBox
        Me.cbSatuan = New System.Windows.Forms.ComboBox
        Me.dgvDataBarang = New System.Windows.Forms.DataGridView
        Me.btnKeluar = New System.Windows.Forms.Button
        Me.btnHapus = New System.Windows.Forms.Button
        Me.btnBatal = New System.Windows.Forms.Button
        Me.btnUpdate = New System.Windows.Forms.Button
        Me.btnEdit = New System.Windows.Forms.Button
        Me.btnSimpan = New System.Windows.Forms.Button
        Me.btnTambah = New System.Windows.Forms.Button
        Me.OleDbCommand1 = New System.Data.OleDb.OleDbCommand
        Me.OleDbConnection1 = New System.Data.OleDb.OleDbConnection
        CType(Me.dgvDataBarang, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(151, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(247, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "INPUT DATA BARANG"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 59)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(131, 24)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Kode Barang"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 102)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(136, 24)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Nama Barang"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(12, 142)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(146, 24)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Satuan Barang"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(12, 180)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(77, 24)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Jumlah"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(12, 219)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(66, 24)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Harga"
        '
        'tbKodeBarang
        '
        Me.tbKodeBarang.Location = New System.Drawing.Point(214, 63)
        Me.tbKodeBarang.Name = "tbKodeBarang"
        Me.tbKodeBarang.Size = New System.Drawing.Size(151, 20)
        Me.tbKodeBarang.TabIndex = 6
        '
        'tbNamaBarang
        '
        Me.tbNamaBarang.Location = New System.Drawing.Point(214, 106)
        Me.tbNamaBarang.Name = "tbNamaBarang"
        Me.tbNamaBarang.Size = New System.Drawing.Size(184, 20)
        Me.tbNamaBarang.TabIndex = 7
        '
        'tbJumlah
        '
        Me.tbJumlah.Location = New System.Drawing.Point(214, 184)
        Me.tbJumlah.Name = "tbJumlah"
        Me.tbJumlah.Size = New System.Drawing.Size(151, 20)
        Me.tbJumlah.TabIndex = 8
        '
        'tbHarga
        '
        Me.tbHarga.Location = New System.Drawing.Point(214, 224)
        Me.tbHarga.Name = "tbHarga"
        Me.tbHarga.Size = New System.Drawing.Size(151, 20)
        Me.tbHarga.TabIndex = 9
        '
        'cbSatuan
        '
        Me.cbSatuan.FormattingEnabled = True
        Me.cbSatuan.Items.AddRange(New Object() {"Pcs", "Set", "Box", "Kg", "Kardus", "Meter"})
        Me.cbSatuan.Location = New System.Drawing.Point(214, 145)
        Me.cbSatuan.Name = "cbSatuan"
        Me.cbSatuan.Size = New System.Drawing.Size(151, 21)
        Me.cbSatuan.TabIndex = 10
        '
        'dgvDataBarang
        '
        Me.dgvDataBarang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDataBarang.Location = New System.Drawing.Point(16, 261)
        Me.dgvDataBarang.Name = "dgvDataBarang"
        Me.dgvDataBarang.Size = New System.Drawing.Size(550, 205)
        Me.dgvDataBarang.TabIndex = 11
        '
        'btnKeluar
        '
        Me.btnKeluar.Location = New System.Drawing.Point(410, 196)
        Me.btnKeluar.Name = "btnKeluar"
        Me.btnKeluar.Size = New System.Drawing.Size(156, 39)
        Me.btnKeluar.TabIndex = 43
        Me.btnKeluar.Text = "Keluar"
        Me.btnKeluar.UseVisualStyleBackColor = True
        '
        'btnHapus
        '
        Me.btnHapus.Location = New System.Drawing.Point(491, 151)
        Me.btnHapus.Name = "btnHapus"
        Me.btnHapus.Size = New System.Drawing.Size(75, 39)
        Me.btnHapus.TabIndex = 42
        Me.btnHapus.Text = "Hapus"
        Me.btnHapus.UseVisualStyleBackColor = True
        '
        'btnBatal
        '
        Me.btnBatal.Location = New System.Drawing.Point(491, 62)
        Me.btnBatal.Name = "btnBatal"
        Me.btnBatal.Size = New System.Drawing.Size(75, 39)
        Me.btnBatal.TabIndex = 41
        Me.btnBatal.Text = "Batal"
        Me.btnBatal.UseVisualStyleBackColor = True
        '
        'btnUpdate
        '
        Me.btnUpdate.Location = New System.Drawing.Point(491, 106)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(75, 39)
        Me.btnUpdate.TabIndex = 40
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'btnEdit
        '
        Me.btnEdit.Location = New System.Drawing.Point(410, 151)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(75, 39)
        Me.btnEdit.TabIndex = 39
        Me.btnEdit.Text = "Edit"
        Me.btnEdit.UseVisualStyleBackColor = True
        '
        'btnSimpan
        '
        Me.btnSimpan.Location = New System.Drawing.Point(410, 106)
        Me.btnSimpan.Name = "btnSimpan"
        Me.btnSimpan.Size = New System.Drawing.Size(75, 39)
        Me.btnSimpan.TabIndex = 38
        Me.btnSimpan.Text = "Simpan"
        Me.btnSimpan.UseVisualStyleBackColor = True
        '
        'btnTambah
        '
        Me.btnTambah.Location = New System.Drawing.Point(410, 61)
        Me.btnTambah.Name = "btnTambah"
        Me.btnTambah.Size = New System.Drawing.Size(75, 39)
        Me.btnTambah.TabIndex = 37
        Me.btnTambah.Text = "Tambah"
        Me.btnTambah.UseVisualStyleBackColor = True
        '
        'OleDbConnection1
        '
        Me.OleDbConnection1.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=D:\MyData\Programs\PemrogramanVB-200" & _
            "8\Database\db_pembelian.mdb"
        '
        'InputDataBarang
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(578, 478)
        Me.Controls.Add(Me.btnKeluar)
        Me.Controls.Add(Me.btnHapus)
        Me.Controls.Add(Me.btnBatal)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.btnEdit)
        Me.Controls.Add(Me.btnSimpan)
        Me.Controls.Add(Me.btnTambah)
        Me.Controls.Add(Me.dgvDataBarang)
        Me.Controls.Add(Me.cbSatuan)
        Me.Controls.Add(Me.tbHarga)
        Me.Controls.Add(Me.tbJumlah)
        Me.Controls.Add(Me.tbNamaBarang)
        Me.Controls.Add(Me.tbKodeBarang)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "InputDataBarang"
        Me.Text = "Form1"
        CType(Me.dgvDataBarang, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents tbKodeBarang As System.Windows.Forms.TextBox
    Friend WithEvents tbNamaBarang As System.Windows.Forms.TextBox
    Friend WithEvents tbJumlah As System.Windows.Forms.TextBox
    Friend WithEvents tbHarga As System.Windows.Forms.TextBox
    Friend WithEvents cbSatuan As System.Windows.Forms.ComboBox
    Friend WithEvents dgvDataBarang As System.Windows.Forms.DataGridView
    Friend WithEvents btnKeluar As System.Windows.Forms.Button
    Friend WithEvents btnHapus As System.Windows.Forms.Button
    Friend WithEvents btnBatal As System.Windows.Forms.Button
    Friend WithEvents btnUpdate As System.Windows.Forms.Button
    Friend WithEvents btnEdit As System.Windows.Forms.Button
    Friend WithEvents btnSimpan As System.Windows.Forms.Button
    Friend WithEvents btnTambah As System.Windows.Forms.Button
    Friend WithEvents OleDbCommand1 As System.Data.OleDb.OleDbCommand
    Friend WithEvents OleDbConnection1 As System.Data.OleDb.OleDbConnection

End Class
