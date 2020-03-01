Public Class Login
    Private Sub btncancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncancel.Click
        Me.Close()
    End Sub

    Private Sub btnlogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnlogin.Click
        Dim frm As New Home
        If txtusername.Text = "dhanusha" And txtpassword.Text = "123" Then
            MsgBox("Welcome Dhanusha", , "Login Successful")
            frm.ShowDialog()
        Else
            MsgBox("Incorrect Usernme or Password", MsgBoxStyle.Critical, "Try Again")
        End If
    End Sub
End Class