Public Class Login_page
    Private Sub LinkLabel2_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        Sign_Up.Show()
        Me.Hide()
    End Sub


    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Choosse_Your_Distination.Show()
        Me.Hide()
    End Sub
End Class