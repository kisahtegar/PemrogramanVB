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
End Class