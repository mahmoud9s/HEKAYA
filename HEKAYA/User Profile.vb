Public Class User_Profile
    Private Sub Label9_Click(sender As Object, e As EventArgs) Handles Label9.Click

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)
        Choosse_Your_Distination.Show()
        Hide()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs)
        Favorites_List.Show()
        Hide()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs)
        Refresh()

    End Sub

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click
        Me.Refresh()

    End Sub

    Private Sub PictureBox7_Click(sender As Object, e As EventArgs) Handles PictureBox7.Click
        Favorites_List.Show()
        Hide()
    End Sub

    Private Sub PictureBox6_Click(sender As Object, e As EventArgs) Handles PictureBox6.Click
        Choosse_Your_Distination.Show()
        Hide()
    End Sub
End Class