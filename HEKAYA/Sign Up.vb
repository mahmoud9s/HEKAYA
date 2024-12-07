Public Class Sign_Up
    Private Sub LinkLabel2_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        Login_page.Show()
        Me.Hide()
    End Sub

    Private Sub Sign_Up_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class