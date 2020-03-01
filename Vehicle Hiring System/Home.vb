Public Class Home
    Private Sub BookToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BookToolStripMenuItem.Click
        Dim frmbook As New Booking
        frmbook.MdiParent = Me
        frmbook.Show()
    End Sub

    Private Sub ViewToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ViewToolStripMenuItem.Click
        Dim frmdispbook As New Display_Bookings
        frmdispbook.MdiParent = Me
        frmdispbook.Show()
    End Sub

    Private Sub CustomerToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ClientToolStripMenuItem.Click
        Dim frmclient As New Client
        frmclient.MdiParent = Me
        frmclient.Show()
    End Sub

    Private Sub CarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CarToolStripMenuItem.Click
        Dim frmcar As New Cars
        frmcar.MdiParent = Me
        frmcar.Show()
    End Sub

    Private Sub DriverToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DriverToolStripMenuItem.Click
        Dim frmdriver As New Driver
        frmdriver.MdiParent = Me
        frmdriver.Show()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
        Login.Close()
    End Sub

    Private Sub ExitToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem1.Click
        Me.Close()
        Login.Close()
    End Sub

End Class