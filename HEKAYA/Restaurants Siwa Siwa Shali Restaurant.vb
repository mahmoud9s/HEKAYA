﻿Public Class Restaurants_Siwa_Siwa_Shali_Restaurant
    Private Sub PictureBox7_Click(sender As Object, e As EventArgs) Handles PictureBox7.Click
        Choosse_Your_Distination.Show()
        Hide()
    End Sub

    Private Sub Label12_Click(sender As Object, e As EventArgs) Handles Label12.Click
        Choosse_Your_Distination.Show()
        Me.Hide()
    End Sub

    Private Sub Label9_Click(sender As Object, e As EventArgs) Handles Label9.Click
        Looking_For_Siwa.Show()
        Me.Hide()
    End Sub

    Private Sub Label11_Click(sender As Object, e As EventArgs) Handles Label11.Click
        Restaurants_Siwa.Show()
        Me.Hide()
    End Sub

    Private Sub PictureBox10_Click(sender As Object, e As EventArgs) Handles PictureBox10.Click
        User_Profile.Show()
        Me.Hide()
    End Sub

    Private Sub PictureBox9_Click(sender As Object, e As EventArgs) Handles PictureBox9.Click
        Favorites_List.Show()
        Me.Hide()
    End Sub

    Private Sub PictureBox8_Click(sender As Object, e As EventArgs) Handles PictureBox8.Click
        Dim previousPage = GetPreviousPage()

        If Not String.IsNullOrEmpty(previousPage) Then
            Dim frm = Application.OpenForms.OfType(Of Form).FirstOrDefault(Function(f) f.Name = previousPage)
            If frm Is Nothing Then
                Try
                    frm = Activator.CreateInstance(Type.GetType(previousPage))
                    frm.Show()
                Catch ex As Exception
                    MessageBox.Show("The previous page cannot be opened " & ex.Message)
                End Try
            Else
                frm.Show()
            End If
            Close()
        Else
            MessageBox.Show("There's no previous page to go back to.")
        End If
    End Sub

    Private Sub Restaurants_Siwa_Siwa_Shali_Restaurant_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AddPageToHistory(Me.Name)
    End Sub
End Class