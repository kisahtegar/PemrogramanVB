<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MenuUtama
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
        Me.Label2 = New System.Windows.Forms.Label
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.LOGOUTToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.TambahUserToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.USERBARUToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.LapTrxPembelianToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.LapDataCustomerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.LapDataBarangToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.LAPORANToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.TransaksiPembelianToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.TRANSAKSIToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.DataCustomerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.DataBarangToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.MASTERToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.BantuanToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.FILEToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.MenuStrip2 = New System.Windows.Forms.MenuStrip
        Me.Label1 = New System.Windows.Forms.Label
        Me.MenuStrip2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Red
        Me.Label2.Location = New System.Drawing.Point(7, 463)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(273, 18)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Created By: Kisah Tegar Putra Abdi"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.I), System.Windows.Forms.Keys)
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(130, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'LOGOUTToolStripMenuItem
        '
        Me.LOGOUTToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExitToolStripMenuItem})
        Me.LOGOUTToolStripMenuItem.Name = "LOGOUTToolStripMenuItem"
        Me.LOGOUTToolStripMenuItem.Size = New System.Drawing.Size(65, 20)
        Me.LOGOUTToolStripMenuItem.Text = "LOGOUT"
        '
        'TambahUserToolStripMenuItem
        '
        Me.TambahUserToolStripMenuItem.Name = "TambahUserToolStripMenuItem"
        Me.TambahUserToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.H), System.Windows.Forms.Keys)
        Me.TambahUserToolStripMenuItem.Size = New System.Drawing.Size(185, 22)
        Me.TambahUserToolStripMenuItem.Text = "Tambah User"
        '
        'USERBARUToolStripMenuItem
        '
        Me.USERBARUToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TambahUserToolStripMenuItem})
        Me.USERBARUToolStripMenuItem.Name = "USERBARUToolStripMenuItem"
        Me.USERBARUToolStripMenuItem.Size = New System.Drawing.Size(79, 20)
        Me.USERBARUToolStripMenuItem.Text = "USER BARU"
        '
        'LapTrxPembelianToolStripMenuItem
        '
        Me.LapTrxPembelianToolStripMenuItem.Name = "LapTrxPembelianToolStripMenuItem"
        Me.LapTrxPembelianToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.G), System.Windows.Forms.Keys)
        Me.LapTrxPembelianToolStripMenuItem.Size = New System.Drawing.Size(215, 22)
        Me.LapTrxPembelianToolStripMenuItem.Text = "Lap Trx Pembelian"
        '
        'LapDataCustomerToolStripMenuItem
        '
        Me.LapDataCustomerToolStripMenuItem.Name = "LapDataCustomerToolStripMenuItem"
        Me.LapDataCustomerToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.F), System.Windows.Forms.Keys)
        Me.LapDataCustomerToolStripMenuItem.Size = New System.Drawing.Size(215, 22)
        Me.LapDataCustomerToolStripMenuItem.Text = "Lap Data Customer"
        '
        'LapDataBarangToolStripMenuItem
        '
        Me.LapDataBarangToolStripMenuItem.Name = "LapDataBarangToolStripMenuItem"
        Me.LapDataBarangToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.E), System.Windows.Forms.Keys)
        Me.LapDataBarangToolStripMenuItem.Size = New System.Drawing.Size(215, 22)
        Me.LapDataBarangToolStripMenuItem.Text = "Lap Data Barang"
        '
        'LAPORANToolStripMenuItem
        '
        Me.LAPORANToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LapDataBarangToolStripMenuItem, Me.LapDataCustomerToolStripMenuItem, Me.LapTrxPembelianToolStripMenuItem})
        Me.LAPORANToolStripMenuItem.Name = "LAPORANToolStripMenuItem"
        Me.LAPORANToolStripMenuItem.Size = New System.Drawing.Size(73, 20)
        Me.LAPORANToolStripMenuItem.Text = "LAPORAN"
        '
        'TransaksiPembelianToolStripMenuItem
        '
        Me.TransaksiPembelianToolStripMenuItem.Name = "TransaksiPembelianToolStripMenuItem"
        Me.TransaksiPembelianToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.D), System.Windows.Forms.Keys)
        Me.TransaksiPembelianToolStripMenuItem.Size = New System.Drawing.Size(222, 22)
        Me.TransaksiPembelianToolStripMenuItem.Text = "Transaksi Pembelian"
        '
        'TRANSAKSIToolStripMenuItem
        '
        Me.TRANSAKSIToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TransaksiPembelianToolStripMenuItem})
        Me.TRANSAKSIToolStripMenuItem.Name = "TRANSAKSIToolStripMenuItem"
        Me.TRANSAKSIToolStripMenuItem.Size = New System.Drawing.Size(79, 20)
        Me.TRANSAKSIToolStripMenuItem.Text = "TRANSAKSI"
        '
        'DataCustomerToolStripMenuItem
        '
        Me.DataCustomerToolStripMenuItem.Name = "DataCustomerToolStripMenuItem"
        Me.DataCustomerToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.C), System.Windows.Forms.Keys)
        Me.DataCustomerToolStripMenuItem.Size = New System.Drawing.Size(195, 22)
        Me.DataCustomerToolStripMenuItem.Text = "Data Customer"
        '
        'DataBarangToolStripMenuItem
        '
        Me.DataBarangToolStripMenuItem.Name = "DataBarangToolStripMenuItem"
        Me.DataBarangToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.B), System.Windows.Forms.Keys)
        Me.DataBarangToolStripMenuItem.Size = New System.Drawing.Size(195, 22)
        Me.DataBarangToolStripMenuItem.Text = "Data Barang"
        '
        'MASTERToolStripMenuItem
        '
        Me.MASTERToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DataBarangToolStripMenuItem, Me.DataCustomerToolStripMenuItem})
        Me.MASTERToolStripMenuItem.Name = "MASTERToolStripMenuItem"
        Me.MASTERToolStripMenuItem.Size = New System.Drawing.Size(63, 20)
        Me.MASTERToolStripMenuItem.Text = "MASTER"
        '
        'BantuanToolStripMenuItem
        '
        Me.BantuanToolStripMenuItem.Name = "BantuanToolStripMenuItem"
        Me.BantuanToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.A), System.Windows.Forms.Keys)
        Me.BantuanToolStripMenuItem.Size = New System.Drawing.Size(160, 22)
        Me.BantuanToolStripMenuItem.Text = "Bantuan"
        '
        'FILEToolStripMenuItem
        '
        Me.FILEToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BantuanToolStripMenuItem})
        Me.FILEToolStripMenuItem.Name = "FILEToolStripMenuItem"
        Me.FILEToolStripMenuItem.Size = New System.Drawing.Size(40, 20)
        Me.FILEToolStripMenuItem.Text = "FILE"
        '
        'MenuStrip2
        '
        Me.MenuStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FILEToolStripMenuItem, Me.MASTERToolStripMenuItem, Me.TRANSAKSIToolStripMenuItem, Me.LAPORANToolStripMenuItem, Me.USERBARUToolStripMenuItem, Me.LOGOUTToolStripMenuItem})
        Me.MenuStrip2.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip2.Name = "MenuStrip2"
        Me.MenuStrip2.Size = New System.Drawing.Size(579, 24)
        Me.MenuStrip2.TabIndex = 5
        Me.MenuStrip2.Text = "MenuStrip2"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(65, 138)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(415, 120)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "    SELAMAT DATANG DI MENU UTAMA" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "       SISTEM INFORMASI PEMBELIAN" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "PADA INS" & _
            "AN PEMBANGUNAN INDONESIA"
        '
        'MenuUtama
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(579, 526)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.MenuStrip2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "MenuUtama"
        Me.Text = "MenuUtama"
        Me.MenuStrip2.ResumeLayout(False)
        Me.MenuStrip2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LOGOUTToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TambahUserToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents USERBARUToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LapTrxPembelianToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LapDataCustomerToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LapDataBarangToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LAPORANToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TransaksiPembelianToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TRANSAKSIToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DataCustomerToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DataBarangToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MASTERToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BantuanToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FILEToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuStrip2 As System.Windows.Forms.MenuStrip
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
