﻿Public Class Low_Budget_Hurghada_Golden_Rose_Hotel
    Private Sub Label13_Click(sender As Object, e As EventArgs) Handles Label13.Click

    End Sub

    Private Sub PictureBox12_Click(sender As Object, e As EventArgs) Handles PictureBox12.Click
        Choosse_Your_Distination.Show()
        Me.Hide()
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        Choosse_Your_Distination.Show()
        Me.Hide()
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click
        Looking_for_Hurghada.Show()
        Me.Hide()
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click
        Hotels_Hurghada_Small_Budget.Show()
        Me.Hide()
    End Sub

    Private Sub PictureBox16_Click(sender As Object, e As EventArgs) Handles PictureBox16.Click
        User_Profile.Show()
        Me.Hide()
    End Sub

    Private Sub PictureBox13_Click(sender As Object, e As EventArgs) Handles PictureBox13.Click
        Favorites_List.Show()
        Me.Hide()
    End Sub

    Private Sub PictureBox11_Click(sender As Object, e As EventArgs) Handles PictureBox11.Click
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

    Private Sub Low_Budget_Hurghada_Golden_Rose_Hotel_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AddPageToHistory(Me.Name)
    End Sub
End Class