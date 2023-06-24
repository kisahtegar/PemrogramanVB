<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormLaporanBarang
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
        Me.CrystalReportViewer1 = New CrystalDecisions.Windows.Forms.CrystalReportViewer
        Me.Label1 = New System.Windows.Forms.Label
        Me.tbCariKodeBarang = New System.Windows.Forms.TextBox
        Me.btnTampilkan = New System.Windows.Forms.Button
        Me.btnTutup = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'CrystalReportViewer1
        '
        Me.CrystalReportViewer1.ActiveViewIndex = 0
        Me.CrystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CrystalReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CrystalReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.CrystalReportViewer1.Name = "CrystalReportViewer1"
        Me.CrystalReportViewer1.ReportSource = "C:\MyData\Project\cpp\Project\PemrogramanVB\2008\PemrogramanVB-2008\PemrogramanVB" & _
            "-2008\LaporanBarang.rpt"
        Me.CrystalReportViewer1.Size = New System.Drawing.Size(763, 543)
        Me.CrystalReportViewer1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(239, 33)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(106, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Cari Kode Barang"
        '
        'tbCariKodeBarang
        '
        Me.tbCariKodeBarang.Location = New System.Drawing.Point(351, 30)
        Me.tbCariKodeBarang.Name = "tbCariKodeBarang"
        Me.tbCariKodeBarang.Size = New System.Drawing.Size(146, 20)
        Me.tbCariKodeBarang.TabIndex = 2
        '
        'btnTampilkan
        '
        Me.btnTampilkan.Location = New System.Drawing.Point(509, 28)
        Me.btnTampilkan.Name = "btnTampilkan"
        Me.btnTampilkan.Size = New System.Drawing.Size(75, 23)
        Me.btnTampilkan.TabIndex = 3
        Me.btnTampilkan.Text = "Tampilkan"
        Me.btnTampilkan.UseVisualStyleBackColor = True
        '
        'btnTutup
        '
        Me.btnTutup.Location = New System.Drawing.Point(590, 28)
        Me.btnTutup.Name = "btnTutup"
        Me.btnTutup.Size = New System.Drawing.Size(75, 23)
        Me.btnTutup.TabIndex = 4
        Me.btnTutup.Text = "Tutup"
        Me.btnTutup.UseVisualStyleBackColor = True
        '
        'FormLaporanBarang
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(763, 543)
        Me.Controls.Add(Me.btnTutup)
        Me.Controls.Add(Me.btnTampilkan)
        Me.Controls.Add(Me.tbCariKodeBarang)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.CrystalReportViewer1)
        Me.Name = "FormLaporanBarang"
        Me.Text = "FormLaporanBarang"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents CrystalReportViewer1 As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents tbCariKodeBarang As System.Windows.Forms.TextBox
    Friend WithEvents btnTampilkan As System.Windows.Forms.Button
    Friend WithEvents btnTutup As System.Windows.Forms.Button
End Class
