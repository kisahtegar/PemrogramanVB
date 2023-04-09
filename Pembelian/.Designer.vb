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
        Me.OleDbConnection1 = New System.Data.OleDb.OleDbConnection()
        Me.dgvDataBarang = New System.Windows.Forms.DataGridView()
        Me.btnKeluar = New System.Windows.Forms.Button()
        Me.btnHapus = New System.Windows.Forms.Button()
        Me.btnBatal = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.btnSimpan = New System.Windows.Forms.Button()
        Me.btnTambah = New System.Windows.Forms.Button()
        Me.OleDbCommand1 = New System.Data.OleDb.OleDbCommand()
        Me.cbSatuan = New System.Windows.Forms.ComboBox()
        Me.tbHarga = New System.Windows.Forms.TextBox()
        Me.tbJumlah = New System.Windows.Forms.TextBox()
        Me.tbNamaBarang = New System.Windows.Forms.TextBox()
        Me.tbKodeBarang = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.dgvDataBarang, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'OleDbConnection1
        '
        Me.OleDbConnection1.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\MyData\Project\cpp\Project\Pemro" &
    "gramanVB\Database\db_pembelian.mdb"
        '
        'dgvDataBarang
        '
        Me.dgvDataBarang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDataBarang.Location = New System.Drawing.Point(31, 363)
        Me.dgvDataBarang.Name = "dgvDataBarang"
        Me.dgvDataBarang.Size = New System.Drawing.Size(520, 209)
        Me.dgvDataBarang.TabIndex = 37
        '
        'btnKeluar
        '
        Me.btnKeluar.Location = New System.Drawing.Point(395, 210)
        Me.btnKeluar.Name = "btnKeluar"
        Me.btnKeluar.Size = New System.Drawing.Size(156, 39)
        Me.btnKeluar.TabIndex = 36
        Me.btnKeluar.Text = "Keluar"
        Me.btnKeluar.UseVisualStyleBackColor = True
        '
        'btnHapus
        '
        Me.btnHapus.Location = New System.Drawing.Point(476, 165)
        Me.btnHapus.Name = "btnHapus"
        Me.btnHapus.Size = New System.Drawing.Size(75, 39)
        Me.btnHapus.TabIndex = 35
        Me.btnHapus.Text = "Hapus"
        Me.btnHapus.UseVisualStyleBackColor = True
        '
        'btnBatal
        '
        Me.btnBatal.Location = New System.Drawing.Point(476, 76)
        Me.btnBatal.Name = "btnBatal"
        Me.btnBatal.Size = New System.Drawing.Size(75, 39)
        Me.btnBatal.TabIndex = 34
        Me.btnBatal.Text = "Batal"
        Me.btnBatal.UseVisualStyleBackColor = True
        '
        'btnUpdate
        '
        Me.btnUpdate.Location = New System.Drawing.Point(476, 120)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(75, 39)
        Me.btnUpdate.TabIndex = 33
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'btnEdit
        '
        Me.btnEdit.Location = New System.Drawing.Point(395, 165)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(75, 39)
        Me.btnEdit.TabIndex = 32
        Me.btnEdit.Text = "Edit"
        Me.btnEdit.UseVisualStyleBackColor = True
        '
        'btnSimpan
        '
        Me.btnSimpan.Location = New System.Drawing.Point(395, 120)
        Me.btnSimpan.Name = "btnSimpan"
        Me.btnSimpan.Size = New System.Drawing.Size(75, 39)
        Me.btnSimpan.TabIndex = 31
        Me.btnSimpan.Text = "Simpan"
        Me.btnSimpan.UseVisualStyleBackColor = True
        '
        'btnTambah
        '
        Me.btnTambah.Location = New System.Drawing.Point(395, 75)
        Me.btnTambah.Name = "btnTambah"
        Me.btnTambah.Size = New System.Drawing.Size(75, 39)
        Me.btnTambah.TabIndex = 30
        Me.btnTambah.Text = "Tambah"
        Me.btnTambah.UseVisualStyleBackColor = True
        '
        'cbSatuan
        '
        Me.cbSatuan.FormattingEnabled = True
        Me.cbSatuan.Items.AddRange(New Object() {"Pcs", "Set", "Box", "Kg", "Kardus", "Meter"})
        Me.cbSatuan.Location = New System.Drawing.Point(215, 199)
        Me.cbSatuan.Name = "cbSatuan"
        Me.cbSatuan.Size = New System.Drawing.Size(121, 21)
        Me.cbSatuan.TabIndex = 29
        '
        'tbHarga
        '
        Me.tbHarga.Location = New System.Drawing.Point(215, 309)
        Me.tbHarga.Name = "tbHarga"
        Me.tbHarga.Size = New System.Drawing.Size(121, 20)
        Me.tbHarga.TabIndex = 28
        '
        'tbJumlah
        '
        Me.tbJumlah.Location = New System.Drawing.Point(215, 253)
        Me.tbJumlah.Name = "tbJumlah"
        Me.tbJumlah.Size = New System.Drawing.Size(121, 20)
        Me.tbJumlah.TabIndex = 27
        '
        'tbNamaBarang
        '
        Me.tbNamaBarang.Location = New System.Drawing.Point(215, 142)
        Me.tbNamaBarang.Name = "tbNamaBarang"
        Me.tbNamaBarang.Size = New System.Drawing.Size(160, 20)
        Me.tbNamaBarang.TabIndex = 26
        '
        'tbKodeBarang
        '
        Me.tbKodeBarang.Location = New System.Drawing.Point(215, 85)
        Me.tbKodeBarang.Name = "tbKodeBarang"
        Me.tbKodeBarang.Size = New System.Drawing.Size(121, 20)
        Me.tbKodeBarang.TabIndex = 25
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(27, 309)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(66, 24)
        Me.Label6.TabIndex = 24
        Me.Label6.Text = "Harga"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(27, 253)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(77, 24)
        Me.Label5.TabIndex = 23
        Me.Label5.Text = "Jumlah"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(27, 197)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(74, 24)
        Me.Label4.TabIndex = 22
        Me.Label4.Text = "Satuan"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(27, 137)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(142, 24)
        Me.Label3.TabIndex = 21
        Me.Label3.Text = "Nama Barang "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(27, 81)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(137, 24)
        Me.Label2.TabIndex = 20
        Me.Label2.Text = "Kode Barang "
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(175, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(222, 24)
        Me.Label1.TabIndex = 19
        Me.Label1.Text = "INPUT DATA BARANG"
        '
        'InputDataBarang
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.OrangeRed
        Me.ClientSize = New System.Drawing.Size(591, 611)
        Me.Controls.Add(Me.dgvDataBarang)
        Me.Controls.Add(Me.btnKeluar)
        Me.Controls.Add(Me.btnHapus)
        Me.Controls.Add(Me.btnBatal)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.btnEdit)
        Me.Controls.Add(Me.btnSimpan)
        Me.Controls.Add(Me.btnTambah)
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
        Me.Text = "InputDataBarang"
        CType(Me.dgvDataBarang, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents OleDbConnection1 As OleDb.OleDbConnection
    Friend WithEvents dgvDataBarang As DataGridView
    Friend WithEvents btnKeluar As Button
    Friend WithEvents btnHapus As Button
    Friend WithEvents btnBatal As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnEdit As Button
    Friend WithEvents btnSimpan As Button
    Friend WithEvents btnTambah As Button
    Friend WithEvents OleDbCommand1 As OleDb.OleDbCommand
    Friend WithEvents cbSatuan As ComboBox
    Friend WithEvents tbHarga As TextBox
    Friend WithEvents tbJumlah As TextBox
    Friend WithEvents tbNamaBarang As TextBox
    Friend WithEvents tbKodeBarang As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
End Class
