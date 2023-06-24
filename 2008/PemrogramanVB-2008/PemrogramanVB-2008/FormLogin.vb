Imports System
Imports System.Data
Imports System.Data.OleDb

Public Class FormLogin
    Dim conn As OleDbConnection
    Dim da As OleDbDataAdapter
    Dim ds As DataSet
    Dim cmd As OleDbCommand
    Dim rd As OleDbDataReader
    Dim str As String


    ' [METHOD] Koneksi.
    Sub Koneksi()
        str = MenuUtama.strConnection
        conn = New OleDbConnection(str)
        If conn.State = ConnectionState.Closed Then conn.Open()
    End Sub

    ' [LOAD]: FormLogin LOAD.
    Private Sub FormLogin_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        tbIdUser.Focus()
    End Sub

    ' [BUTTON]: Digunakan untuk login.
    Private Sub btnLogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLogin.Click
        Koneksi()
        cmd = New OleDbCommand("select * from tb_user where idUser='" & tbIdUser.Text & "' and password_user='" & tbPassword.Text & "' and bagian_user='" & cbBagian.Text & "'", conn)
        rd = cmd.ExecuteReader
        rd.Read()
        If rd.HasRows Then
            MsgBox("Login sukses")
            If cbBagian.Text = "ADM" Then
                MenuUtama.USERBARUToolStripMenuItem.Enabled = True
                MenuUtama.MASTERToolStripMenuItem.Enabled = False

            ElseIf cbBagian.Text = "SPV" Then
                MenuUtama.USERBARUToolStripMenuItem.Enabled = False
                MenuUtama.FILEToolStripMenuItem.Enabled = True
                MenuUtama.MASTERToolStripMenuItem.Enabled = True
                MenuUtama.TRANSAKSIToolStripMenuItem.Enabled = True
            End If
            MenuUtama.Show()
            Me.Hide()
        Else
            MsgBox("login salah, periksan kembali IDuser dan password")
            tbIdUser.Focus()
            Me.tbIdUser.Text = ""
            Me.tbPassword.Text = ""
            Me.cbBagian.Text = ""
        End If
    End Sub
End Class