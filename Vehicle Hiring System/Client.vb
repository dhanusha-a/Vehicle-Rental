Imports System.Data.OleDb
Public Class Client
    Public cname As String
    Public cid As Integer
    Public cadd As String
    Public cno As Integer

    Dim cn As New OleDbConnection
    Dim cmd As OleDbCommand
    Dim dr As OleDbDataReader
    Dim adp As New OleDbDataAdapter
    Dim ds As New DataSet
    Dim dro As DataRow
    Dim no As Integer

    Public Sub display()
        ds.Clear()
        adp = New OleDbDataAdapter("select * from Client", cn)
        adp.Fill(ds)
        datagridviewclient.DataSource = ds.Tables(0)
        datagridviewclient.ReadOnly = True
    End Sub
    Sub showdata()
        dro = ds.Tables(0).Rows(0)
        txtcliid.Text = dr.Item(0)
        txtcliname = dr.Item(1)
        txtcliadd.Text = dr.Item(2)
        txtclino.Text = dr.Item(3)
        txtcliemail.Text = dr.Item(4)
    End Sub
    Private Sub Client_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source =C:\Users\admin\Documents\Visual Studio 2008\Projects\Vehicle Hiring System\Vehicle Hiring System.accdb"
        cn.Open()
        display()
        no = 0

        txtcliid.Text = cid
        txtcliname.Text = cname
        txtcliadd.Text = cadd
        txtclino.Text = cno
    End Sub

    Private Sub btninsert_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btninsert.Click
        Try
            cmd = New OleDbCommand(" insert into Client values (" & txtcliid.Text & ", ' " & txtcliname.Text & " ',' " & txtcliadd.Text & " ', " & txtclino.Text & ", ' " & txtcliemail.Text & " ')", cn)
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox("Insert Correctly")
        End Try
        display()
    End Sub

    Private Sub btnupdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnupdate.Click
        cmd = New OleDbCommand(" update Client set c_name=' " & txtcliname.Text & " ', c_add=' " & txtcliadd.Text & " ', c_phno=" & txtclino.Text & ", c_email=' " & txtcliemail.Text & " ' where Client_id=" & txtcliid.Text & " ", cn)
        cmd.ExecuteNonQuery()
        display()
    End Sub

    Private Sub btndelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btndelete.Click
        cmd = New OleDbCommand(" delete from Client where Client_id=" & txtcliid.Text & " ", cn)
        cmd.ExecuteNonQuery()
        display()
    End Sub

    Private Sub btnreset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnreset.Click
        txtcliid.Clear()
        txtcliname.Clear()
        txtcliadd.Clear()
        txtclino.Clear()
        txtcliemail.Clear()
    End Sub

    Private Sub datagridviewclient_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles datagridviewclient.CellContentClick
        Dim i As Integer
        i = datagridviewclient.CurrentRow.Index
        txtcliid.Text = datagridviewclient.Item(0, i).Value
        txtcliname.Text = datagridviewclient.Item(1, i).Value
        txtcliadd.Text = datagridviewclient.Item(2, i).Value
        txtclino.Text = datagridviewclient.Item(3, i).Value
        txtcliemail.Text = datagridviewclient.Item(4, i).Value
    End Sub

    Private Sub btnsearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsearch.Click
        Try
            cmd = New OleDbCommand("select * from Client where c_name=' " & txtclisearch.Text & " ' ", cn)
            dr = cmd.ExecuteReader()
            If dr.HasRows Then
                dr.Read()
                txtcliid.Text = dr.Item(0)
                txtcliname = dr.Item(1)
                txtcliadd.Text = dr.Item(2)
                txtclino.Text = dr.Item(3)
                txtcliemail.Text = dr.Item(4)
            Else
                MsgBox("Sorry! record not found")
            End If
            dr.Close()
        Catch ex As Exception
            MsgBox(ex.ToString, , "Record not found")
        End Try
    End Sub

    Private Sub btnfirst_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnfirst.Click
        no = 0
        showdata()
    End Sub

    Private Sub btnlast_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnlast.Click
        no = ds.Tables(0).Rows.Count - 1
        showdata()
    End Sub

    Private Sub btnprevious_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnprevious.Click
        no = no - 1
        If no < 0 Then
            no = ds.Tables(0).Rows.Count - 1
        End If
        showdata()
    End Sub

    Private Sub btnnext_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnnext.Click
        no = no + 1
        If no > ds.Tables(0).Rows.Count - 1 Then
            no = 0
        End If
        showdata()
    End Sub
End Class