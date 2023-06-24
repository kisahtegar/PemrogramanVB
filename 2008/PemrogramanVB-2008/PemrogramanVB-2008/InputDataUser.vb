Imports System.Data.OleDb

Public Class InputDataUser
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
        Me.tbIdUser.Enabled = False
        Me.tbPassword.Enabled = False
        Me.cbBagian.Enabled = False
    End Sub

    'Method TextHidup
    Sub TextHidup()
        Me.tbIdUser.Enabled = True
        Me.tbPassword.Enabled = True
        Me.cbBagian.Enabled = True
    End Sub

    'Method Kosong
    Sub Kosong()
        tbIdUser.Clear()
        tbPassword.Clear()
        tbIdUser.Focus()
    End Sub

    'Menampilkan GridView
    Sub TampilGrid()
        da = New OleDbDataAdapter("SELECT * FROM tb_user", conn)
        ds = New DataSet
        da.Fill(ds, "tb_user")
        DataGridView1.DataSource = ds.Tables("tb_user")
    End Sub

    'Input Data Barang load pertama kali
    Private Sub InputDataUser_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call Koneksi()
        Call TampilGrid()
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
        If tbIdUser.Text = "" Or tbPassword.Text = "" Or cbBagian.Text = "" Then
            MsgBox("Data belum lengkap, pastikan semua form terisi")
            Exit Sub
        Else
            Call Koneksi()
            Dim simpan As String = "insert into tb_user (idUser, password_user, bagian_user)" & "values ('" & tbIdUser.Text & "','" & tbPassword.Text & "','" & cbBagian.Text & "')"
            cmd = New OleDbCommand(simpan, conn)
            cmd.ExecuteNonQuery()
            MsgBox("Data berhasil di input", MsgBoxStyle.Information, "Information")
            Me.OleDbConnection1.Close()
            Call TampilGrid()
            DataGridView1.Refresh()
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
        Dim keluar As MsgBoxResult

        keluar = MsgBox("Apakan anda akan keluar?", MsgBoxStyle.YesNo, "Peringatan")
        If keluar = MsgBoxResult.Yes Then
            MenuUtama.Show()
            Close()
        End If
    End Sub

    'Button Edit click
    Private Sub btnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEdit.Click
        Call TextHidup()

        Me.tbIdUser.Enabled = False
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
            sql = "UPDATE tb_user SET password_user = '" & tbPassword.Text & "', bagian_user = '" & cbBagian.Text & "' where idUser='" & tbIdUser.Text & "'"
            cmd = New OleDbCommand(sql, conn)
            cmd.ExecuteNonQuery()
            DataGridView1.Refresh()
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
            DataGridView1.Refresh()
            Call TampilGrid()
        End If
    End Sub


    ' [LOST FOCUS]: Digunakan untuk mengisi otomatiss text box.
    Private Sub tbIdUser_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles tbIdUser.LostFocus
        str = "SELECT * FROM tb_user Where idUser = '" & tbIdUser.Text & "'"
        cmd = New OleDbCommand(str, conn)
        rd = cmd.ExecuteReader
        Try
            While rd.Read
                tbPassword.Text = rd.GetString(1)
                cbBagian.Text = rd.GetString(2)
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

    ' [BUTTON]: Digunakan untuk membatalkan.
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

    ' [BUTTON]: Digunakan untuk menghapus data.
    Private Sub btnHapus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHapus.Click
        If tbIdUser.Text = "" Then
            MsgBox("Kode belum diisi")
            tbIdUser.Focus()
            Exit Sub
        Else
            If MessageBox.Show("Yakin akan dihapus..?", "", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
                Dim hapus As String = "Delete * from tb_user where idUser='" & tbIdUser.Text & "'"
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