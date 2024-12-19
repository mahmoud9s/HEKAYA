Public Class Favorites_List
    Private Sub Button2_Click(sender As Object, e As EventArgs)
        Choosse_Your_Distination.Show
        Hide
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs)
        User_Profile.Show
        Show

    End Sub

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click
        User_Profile.Show()
        Me.Hide()
    End Sub

    Private Sub PictureBox7_Click(sender As Object, e As EventArgs) Handles PictureBox7.Click
        Me.Refresh()
    End Sub

    Private Sub PictureBox6_Click(sender As Object, e As EventArgs) Handles PictureBox6.Click
        Choosse_Your_Distination.Show()
        Me.Hide()
    End Sub

    Private Sub Favorites_List_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click

    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Landmarks_Cairo_Grand_Egyptian_Museum.Show()
        Me.Hide()
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click
        Landmarks_Cairo_Grand_Egyptian_Museum.Show()
        Me.Hide()
    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click
        Landmarks_Cairo_Grand_Egyptian_Museum.Show()
        Me.Hide()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub
End Class