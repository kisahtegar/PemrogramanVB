Imports System.Data.OleDb

Public Class Supplier
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
        Me.tbKodeSupplier.Enabled = False
        Me.tbNamaSupplier.Enabled = False
        Me.tbTelepon.Enabled = False
        Me.tbEmail.Enabled = False
        Me.tbAlamat.Enabled = False
    End Sub

    'Method TextHidup
    Sub TextHidup()
        Me.tbKodeSupplier.Enabled = True
        Me.tbNamaSupplier.Enabled = True
        Me.tbTelepon.Enabled = True
        Me.tbEmail.Enabled = True
        Me.tbAlamat.Enabled = True
    End Sub

    'Method Kosong
    Sub Kosong()
        tbKodeSupplier.Clear()
        tbNamaSupplier.Clear()
        tbTelepon.Clear()
        tbEmail.Clear()
        tbAlamat.Clear()
        tbKodeSupplier.Focus()
    End Sub

    'Menampilkan GridView
    Sub TampilGrid()
        da = New OleDbDataAdapter("SELECT * FROM tb_supplier", conn)
        ds = New DataSet
        da.Fill(ds, "tb_supplier")
        dgvDataSupplier.DataSource = ds.Tables("tb_supplier")
    End Sub

    'Input Data Supplier load pertama kali
    Private Sub supplier_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
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
        If tbKodeSupplier.Text = "" Or tbNamaSupplier.Text = "" Or tbTelepon.Text = "" Or tbEmail.Text = "" Or tbAlamat.Text = "" Then
            MsgBox("Data belum lengkap, pastikan semua form terisi")
            Exit Sub
        Else
            Call Koneksi()
            Dim simpan As String = "insert into tb_supplier (kdsupplier, nmsupplier, telepon, email, alamat)" & "values ('" & tbKodeSupplier.Text & "','" & tbNamaSupplier.Text & "','" & tbTelepon.Text & "','" & tbEmail.Text & "','" & tbAlamat.Text & "')"
            cmd = New OleDbCommand(simpan, conn)
            cmd.ExecuteNonQuery()
            MsgBox("Data berhasil di input", MsgBoxStyle.Information, "Information")
            Me.OleDbConnection1.Close()
            Call TampilGrid()
            dgvDataSupplier.Refresh()
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

    'Button Edit click    
    Private Sub btnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEdit.Click
        Call TextHidup()

        Me.tbKodeSupplier.Enabled = False
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
            sql = "UPDATE tb_supplier SET nmsupplier = '" & tbNamaSupplier.Text & "', telepon = '" & tbTelepon.Text & "', email = '" & tbEmail.Text & "', alamat = '" & tbAlamat.Text & "' where kdsupplier='" & tbKodeSupplier.Text & "'"
            cmd = New OleDbCommand(sql, conn)
            cmd.ExecuteNonQuery()
            dgvDataSupplier.Refresh()
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
            dgvDataSupplier.Refresh()
            Call TampilGrid()
        End If
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

    ' Button hapus
    Private Sub btnHapus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHapus.Click
        If tbKodeSupplier.Text = "" Then
            MsgBox("Kode belum diisi")
            tbKodeSupplier.Focus()
            Exit Sub
        Else
            If MessageBox.Show("Yakin akan dihapus..?", "", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
                Dim hapus As String = "Delete * from tb_supplier where kdsupplier='" & tbKodeSupplier.Text & "'"
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

    ' Kode Supplier lost
    Private Sub tbKodeSupplier_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles tbKodeSupplier.LostFocus
        str = "SELECT * FROM tb_supplier Where kdsupplier = '" & tbKodeSupplier.Text & "'"
        cmd = New OleDbCommand(str, conn)
        rd = cmd.ExecuteReader
        Try
            While rd.Read
                tbNamaSupplier.Text = rd.GetString(1)
                tbTelepon.Text = rd.GetString(2)
                tbEmail.Text = rd.GetValue(3)
                tbAlamat.Text = rd.GetValue(4)
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
End Class