Imports System.Data.OleDb

Public Class InputDataBarang
    'Variable
    Dim conn As OleDbConnection
    Dim da As OleDbDataAdapter
    Dim ds As DataSet
    Dim cmd As OleDbCommand
    Dim rd As OleDbDataReader
    Dim str As String

    'Method Koneksi
    Sub Koneksi()
        str = MenuUtama.strConnection
        conn = New OleDbConnection(str)
        If conn.State = ConnectionState.Closed Then conn.Open()
    End Sub

    'Method TextMati
    Sub TextMati()
        Me.tbKodeBarang.Enabled = False
        Me.tbNamaBarang.Enabled = False
        Me.cbSatuan.Enabled = False
        Me.tbJumlah.Enabled = False
        Me.tbHarga.Enabled = False
    End Sub

    'Method TextHidup
    Sub TextHidup()
        Me.tbKodeBarang.Enabled = True
        Me.tbNamaBarang.Enabled = True
        Me.cbSatuan.Enabled = True
        Me.tbJumlah.Enabled = True
        Me.tbHarga.Enabled = True
    End Sub

    'Method Kosong
    Sub Kosong()
        tbKodeBarang.Clear()
        tbNamaBarang.Clear()
        tbJumlah.Clear()
        tbHarga.Clear()
        tbKodeBarang.Focus()
    End Sub

    'Input Data Barang load pertama kali
    Private Sub InputDataBarang_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call Koneksi()
        Call TampilGrid()
        Call Kosong()
        Call TextMati()
        'dgvDataBarang.ReadOnly = True   
        Me.btnTambah.Enabled = True
        Me.btnSimpan.Enabled = False
        Me.btnEdit.Enabled = False
        Me.btnUpdate.Enabled = False
        Me.btnBatal.Enabled = False
        Me.btnHapus.Enabled = False
        Me.btnKeluar.Enabled = True
    End Sub

    'Button Tambah diclick
    Private Sub btnTambah_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTambah.Click
        Call Kosong()
        Call TextHidup()
        Me.btnTambah.Enabled = False
        Me.btnSimpan.Enabled = True
        Me.btnEdit.Enabled = False
        Me.btnUpdate.Enabled = False
        Me.btnBatal.Enabled = False
        Me.btnHapus.Enabled = False
        Me.btnKeluar.Enabled = True
    End Sub

    'Button Simpan diclick
    Private Sub btnSimpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSimpan.Click
        If tbKodeBarang.Text = "" Or tbNamaBarang.Text = "" Or cbSatuan.Text = "" Then
            MsgBox("Data belum lengkap, pastikan semua form terisi")
            Exit Sub
        Else
            Call Koneksi()
            Dim simpan As String = "insert into tb_barang (kdbarang, nmbarang, satuan, jumlah, harga)" & "values ('" & tbKodeBarang.Text & "','" & tbNamaBarang.Text & "','" & cbSatuan.Text & "','" & tbJumlah.Text & "','" & tbHarga.Text & "')"
            cmd = New OleDbCommand(simpan, conn)
            cmd.ExecuteNonQuery()
            MsgBox("Data berhasil di input", MsgBoxStyle.Information, "Information")
            Me.OleDbConnection1.Close()
            Call TampilGrid()
            dgvDataBarang.Refresh()
            Call Koneksi()
            Call Kosong()
            Call TextMati()
            Me.btnTambah.Enabled = True
            Me.btnSimpan.Enabled = False
            Me.btnEdit.Enabled = False
            Me.btnUpdate.Enabled = False
            Me.btnBatal.Enabled = False
            Me.btnHapus.Enabled = False
            Me.btnKeluar.Enabled = True
        End If
    End Sub

    'Button Keluar diclick
    Private Sub btnKeluar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnKeluar.Click
        MenuUtama.Show()
        Me.Hide()
    End Sub

    'Menampilkan GridView
    Sub TampilGrid()
        da = New OleDbDataAdapter("SELECT * FROM tb_barang", conn)
        ds = New DataSet
        da.Fill(ds, "tb_barang")
        dgvDataBarang.DataSource = ds.Tables("tb_barang")
    End Sub

    'Button Edit    click    
    Private Sub btnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEdit.Click
        Call TextHidup()

        Me.tbKodeBarang.Enabled = False
        Me.btnTambah.Enabled = False
        Me.btnSimpan.Enabled = False
        Me.btnEdit.Enabled = False
        Me.btnUpdate.Enabled = True
        Me.btnBatal.Enabled = True
        Me.btnHapus.Enabled = True
        Me.btnKeluar.Enabled = True
    End Sub

    'Button update click
    Private Sub btnUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpdate.Click
        Dim sql As String

        If MsgBox("Do you want save again ?", MsgBoxStyle.YesNo, "Message") = vbYes Then
            sql = "UPDATE tb_barang SET nmbarang = '" & tbNamaBarang.Text & "', satuan = '" & cbSatuan.Text & "', jumlah = '" & tbJumlah.Text & "', harga = '" & tbHarga.Text & "' where kdbarang='" & tbKodeBarang.Text & "'"
            cmd = New OleDbCommand(sql, conn)
            cmd.ExecuteNonQuery()
            dgvDataBarang.Refresh()
            Me.OleDbConnection1.Close()
            Call TextMati()
            Call Kosong()
            Me.btnTambah.Enabled = True
            Me.btnSimpan.Enabled = False
            Me.btnEdit.Enabled = False
            Me.btnUpdate.Enabled = False
            Me.btnBatal.Enabled = False
            Me.btnHapus.Enabled = False
            Me.btnKeluar.Enabled = True
            dgvDataBarang.Refresh()
            Call TampilGrid()
        End If
    End Sub

    'tbKodeBarang Lost Focuss
    Private Sub tbKodeBarang_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles tbKodeBarang.LostFocus
        str = "SELECT * FROM tb_barang Where kdbarang = '" & tbKodeBarang.Text & "'"
        cmd = New OleDbCommand(str, conn)
        rd = cmd.ExecuteReader
        Try
            While rd.Read
                tbNamaBarang.Text = rd.GetString(1)
                cbSatuan.Text = rd.GetString(2)
                tbJumlah.Text = rd.GetValue(3)
                tbHarga.Text = rd.GetValue(4)
                TextMati()
                Me.btnTambah.Enabled = False
                Me.btnSimpan.Enabled = False
                Me.btnEdit.Enabled = True
                Me.btnUpdate.Enabled = False
                Me.btnBatal.Enabled = False
                Me.btnHapus.Enabled = False
                Me.btnKeluar.Enabled = True
            End While
        Finally
            rd.Close()
        End Try
    End Sub

    'btnBatal Click
    Private Sub btnBatal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBatal.Click
        Call TextMati()
        Call Kosong()
        Me.btnTambah.Enabled = True
        Me.btnSimpan.Enabled = False
        Me.btnEdit.Enabled = False
        Me.btnUpdate.Enabled = False
        Me.btnBatal.Enabled = False
        Me.btnHapus.Enabled = False
        Me.btnKeluar.Enabled = True
    End Sub

    'tbKodeBarang Key Press
    Private Sub tbKodeBarang_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tbKodeBarang.KeyPress
        tbKodeBarang.MaxLength = 5
        If e.KeyChar = Chr(13) Then tbNamaBarang.Focus()
    End Sub

    'tbNamaBarang Key Press
    Private Sub tbNamaBarang_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tbNamaBarang.KeyPress
        tbNamaBarang.MaxLength = 25
        If e.KeyChar = Chr(13) Then cbSatuan.Focus()
    End Sub

    'cbSatuan Key Press
    Private Sub cbSatuan_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cbSatuan.KeyPress
        cbSatuan.MaxLength = 10
        If e.KeyChar = Chr(13) Then tbJumlah.Focus()
    End Sub

    'tbJumlah Key Presss
    Private Sub tbJumlah_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tbJumlah.KeyPress
        If e.KeyChar = Chr(13) Then tbHarga.Focus()
    End Sub

    'tbHarga Key Presss
    Private Sub tbHarga_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tbHarga.KeyPress
        If e.KeyChar = Chr(13) Then btnSimpan.Focus()
    End Sub


    Private Sub btnHapus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHapus.Click
        If tbKodeBarang.Text = "" Then
            MsgBox("Kode belum diisi")
            tbKodeBarang.Focus()
            Exit Sub
        Else
            If MessageBox.Show("Yakin akan dihapus..?", "", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
                Dim hapus As String = "Delete * from tb_barang where kdbarang='" & tbKodeBarang.Text & "'"
                cmd = New OleDbCommand(hapus, conn)
                cmd.ExecuteNonQuery()
                Call TampilGrid()
                Call Kosong()
                Me.btnTambah.Enabled = True
                Me.btnSimpan.Enabled = False
                Me.btnEdit.Enabled = False
                Me.btnUpdate.Enabled = False
                Me.btnBatal.Enabled = False
                Me.btnHapus.Enabled = False
                Me.btnKeluar.Enabled = True
            Else
                Call TextMati()
            End If
        End If
    End Sub
End Class
