Public Class MenuUtama
    ' Path connection database
    Public strConnection As String = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\MyData\Project\cpp\Project\PemrogramanVB\2008\PemrogramanVB-2008\Database\db_pembelian.mdb" 'Connection laptop kisah

    ' Path crystal report
    Public strCrystalReport As String = "C:\MyData\Project\cpp\Project\PemrogramanVB\2008\PemrogramanVB-2008\PemrogramanVB-2008\LaporanBarang.rpt" 'Path laptop kisah

    ' [MENU ITEM]: Link menuju form InputDataBarang.vb.
    Private Sub DataBarangToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DataBarangToolStripMenuItem.Click
        InputDataBarang.Show()
        Me.Hide()
    End Sub

    ' [MENU ITEM]: Link untuk keluar dari MenuUtama.vb.
    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        FormLogin.Show()
        Me.Hide()
    End Sub

    ' [MENU ITEM]: Link menuju form FormLaporanBarang.vb.
    Private Sub LapDataBarangToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LapDataBarangToolStripMenuItem.Click
        FormLaporanBarang.Show()
        Me.Hide()
    End Sub

    ' [MENU ITEM]: Link menuju form InputDataUser.vb.
    Private Sub TambahUserToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TambahUserToolStripMenuItem.Click
        InputDataUser.Show()
        Me.Hide()
    End Sub

    Private Sub DataSupplierToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DataSupplierToolStripMenuItem.Click
        Supplier.Show()
        Me.Hide()
    End Sub
End Class