Imports System.Data.OleDb
Public Class Driver
    Dim cn As New OleDbConnection
    Dim cmd As OleDbCommand
    Dim dr As OleDbDataReader
    Dim adp As New OleDbDataAdapter
    Dim ds As New DataSet
    Public Sub display()
        ds.Clear()
        adp = New OleDbDataAdapter("select * from Driver", cn)
        adp.Fill(ds)
        datagridviewdriver.DataSource = ds.Tables(0)
        datagridviewdriver.ReadOnly = True
    End Sub
    Private Sub Driver_Details_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\admin\Documents\Visual Studio 2008\Projects\Vehicle Hiring System\Vehicle Hiring System.accdb"
        cn.Open()
        display()
    End Sub
End Class