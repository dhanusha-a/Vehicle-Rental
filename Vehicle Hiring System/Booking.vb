Imports System.Data.OleDb
Public Class Booking
    Dim cn As New OleDbConnection
    Dim cmd As OleDbCommand
    Dim dr As OleDbDataReader
    Dim adp As New OleDbDataAdapter
    Dim ds As New DataSet
    Private Sub btnscliview_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnscliview.Click
        Dim frmclient As New Client
        frmclient.ShowDialog()
    End Sub

    Private Sub btncarview_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncarview.Click
        Dim frmcar As New Cars
        frmcar.ShowDialog()
    End Sub

    Private Sub btndrvview_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btndrvview.Click
        Dim frmdriver As New Driver
        frmdriver.ShowDialog()
    End Sub

    Private Sub btnbookdisp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnbookdisp.Click
        Dim frmdispbook As New Display_Bookings
        frmdispbook.Show()
    End Sub

    Private Sub Booking_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\admin\Documents\Visual Studio 2008\Projects\Vehicle Hiring System\Vehicle Hiring System.accdb"
        cn.Open()
    End Sub
End Class