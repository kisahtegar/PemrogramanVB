Public Class FormLaporanBarang
    ' [BUTTON]: Digunakan untuk mengubah tampilan report.
    Private Sub btnTampilkan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTampilkan.Click
        CrystalReportViewer1.SelectionFormula = "{tb_barang.kdbarang}='" & tbCariKodeBarang.Text & "'"
        CrystalReportViewer1.ReportSource = MenuUtama.strCrystalReport
    End Sub

    ' [BUTTON]: Digunakan untuk menutup form.
    Private Sub btnTutup_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTutup.Click
        MenuUtama.Show()
        Me.Hide()
    End Sub
End Class