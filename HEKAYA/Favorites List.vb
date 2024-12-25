﻿Public Class Favorites_List
    Private Sub Button2_Click(sender As Object, e As EventArgs)
        Choosse_Your_Distination.Show
        Me.Hide()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs)
        User_Profile.Show
        Me.Show()

    End Sub

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click
        User_Profile.Show()
        Me.Hide()
    End Sub

    Private Sub PictureBox7_Click(sender As Object, e As EventArgs) Handles PictureBox7.Click
        Me.Refresh()
    End Sub

    Private Sub PictureBox6_Click(sender As Object, e As EventArgs) Handles PictureBox6.Click
        Choosse_Your_Distination.Show
        Me.Hide()
    End Sub

    Private Sub Favorites_List_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AddPageToHistory(Me.Name)
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs)

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

    Private Sub PictureBox8_Click(sender As Object, e As EventArgs) Handles PictureBox8.Click
        Dim previousPage As String = GetPreviousPage()

        If Not String.IsNullOrEmpty(previousPage) Then
            Dim frm As Form = Application.OpenForms.OfType(Of Form)().FirstOrDefault(Function(f) f.Name = previousPage)
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
            Me.Close()
        Else
            MessageBox.Show("There's no previous page to go back to.")
        End If
    End Sub

    Private Sub PictureBox1_Click_1(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Restaurants_Cairo_Sequoia.Show()
        Me.Hide()
    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click
        Restaurants_Cairo_Sequoia.Show()
        Me.Hide()
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click
        Restaurants_Cairo_Sequoia.Show()
        Me.Hide()
    End Sub

    Private Sub PictureBox11_Click(sender As Object, e As EventArgs) Handles PictureBox11.Click
        High_Budget_Cairo_Hotels_Waldorf_Astoria_Cairo_Heliopolis.Show()
        Me.Hide()
    End Sub

    Private Sub Label13_Click(sender As Object, e As EventArgs) Handles Label13.Click
        High_Budget_Cairo_Hotels_Waldorf_Astoria_Cairo_Heliopolis.Show()
        Me.Hide()
    End Sub

    Private Sub Label9_Click(sender As Object, e As EventArgs) Handles Label9.Click
        High_Budget_Cairo_Hotels_Waldorf_Astoria_Cairo_Heliopolis.Show()
        Me.Hide()
    End Sub
End Class