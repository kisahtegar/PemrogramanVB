Imports System.Data.OleDb

Public Class InputDataBarang
    Dim conn As OleDbConnection
    Dim da As OleDbDataAdapter
    Dim ds As DataSet
    Dim cmd As OleDbCommand
    Dim rd As OleDbDataReader
    Dim str As String

    'Method Koneksi
    Sub Koneksi()
        ' Ganti path str sesuai dengan lokasi Connection String database.
        str = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\MyData\Project\cpp\Project\PemrogramanVB\Database\db_pembelian.mdb"
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
    Private Sub InputDataBarang_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call Kosong()
        Call TextMati()
        Me.btnTambah.Enabled = True
        Me.btnSimpan.Enabled = False
        Me.btnEdit.Enabled = False
        Me.btnUpdate.Enabled = False
        Me.btnBatal.Enabled = False
        Me.btnHapus.Enabled = False
        Me.btnKeluar.Enabled = True
    End Sub

    'Button Tambah diclick
    Private Sub btnTambah_Click(sender As Object, e As EventArgs) Handles btnTambah.Click
        Call Kosong()
        Call TextHidup()
        Me.btnTambah.Enabled = False
        Me.btnSimpan.Enabled = True
        Me.btnEdit.Enabled = False
        Me.btnUpdate.Enabled = False
        Me.btnBatal.Enabled = True
        Me.btnHapus.Enabled = False
        Me.btnKeluar.Enabled = True
    End Sub

    'Button Simpan diclick
    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
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
            Call Koneksi()
            Call Kosong()
            Call TextMati()
        End If
    End Sub

    'Button Keluar diclick
    Private Sub btnKeluar_Click(sender As Object, e As EventArgs) Handles btnKeluar.Click
        Close()
    End Sub
End Class