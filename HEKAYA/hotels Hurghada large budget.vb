﻿Imports System.Windows.Forms.Design

Public Class Hotels_Hurghada_large_budget
    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        High_Budget_Hurghada_Steigenberger_Aldau_Beach_Hotel.Show()
        Me.Hide()
    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click
        High_Budget_Hurghada_Steigenberger_Aldau_Beach_Hotel.Show()
        Me.Hide()
    End Sub

    Private Sub PictureBox14_Click(sender As Object, e As EventArgs) Handles PictureBox14.Click
        Choosse_Your_Distination.Show()
        Me.Hide()
    End Sub

    Private Sub PictureBox16_Click(sender As Object, e As EventArgs) Handles PictureBox16.Click
        User_Profile.Show()
        Me.Hide()
    End Sub

    Private Sub PictureBox15_Click(sender As Object, e As EventArgs) Handles PictureBox15.Click
        Favorites_List.Show()
        Me.Hide()
    End Sub

    Private Sub Label10_Click(sender As Object, e As EventArgs) Handles Label10.Click
        High_Budget_Hurghada_Steigenberger_Aldau_Beach_Hotel.Show()
        Me.Hide()
    End Sub

    Private Sub PictureBox11_Click(sender As Object, e As EventArgs) Handles PictureBox11.Click
        High_Budget_Hurghada_The_Oberoi_Beach_Resort.Show()
        Me.Hide()
    End Sub

    Private Sub Label13_Click(sender As Object, e As EventArgs) Handles Label13.Click
        High_Budget_Hurghada_The_Oberoi_Beach_Resort.Show()
        Me.Hide()
    End Sub

    Private Sub Label9_Click(sender As Object, e As EventArgs) Handles Label9.Click
        High_Budget_Hurghada_The_Oberoi_Beach_Resort.Show()
        Me.Hide()
    End Sub

    Private Sub PictureBox10_Click(sender As Object, e As EventArgs) Handles PictureBox10.Click
        High_Budget_Hurghada_Baron_Palace_Sahl_Hasheesh.Show()
        Me.Hide()
    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click
        High_Budget_Hurghada_Baron_Palace_Sahl_Hasheesh.Show()
        Me.Hide()
    End Sub

    Private Sub Label11_Click(sender As Object, e As EventArgs) Handles Label11.Click
        High_Budget_Hurghada_Baron_Palace_Sahl_Hasheesh.Show()
        Me.Hide()
    End Sub

    Private Sub PictureBox9_Click(sender As Object, e As EventArgs) Handles PictureBox9.Click
        High_Budget_Hurghada_Sunrise_Aqua_Joy_Resort.Show()
        Me.Hide()
    End Sub

    Private Sub Label12_Click(sender As Object, e As EventArgs) Handles Label12.Click
        High_Budget_Hurghada_Sunrise_Aqua_Joy_Resort.Show()
        Me.Hide()
    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click
        High_Budget_Hurghada_Sunrise_Aqua_Joy_Resort.Show()
        Me.Hide()
    End Sub

    Private Sub PictureBox13_Click(sender As Object, e As EventArgs) Handles PictureBox13.Click
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

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click
        Hotels_Hurghada_Moderate_Budget.Show()
        Me.Hide()

    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Hotels_Hurghada_Moderate_Budget.Show()
        Me.Hide()

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        Hotels_Hurghada_Small_Budget.Show()
        Me.Hide()
    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        Hotels_Hurghada_Small_Budget.Show()
        Me.Hide()
    End Sub

    Private Sub Hotels_Hurghada_Large_Budget_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AddPageToHistory(Me.Name)
    End Sub
End Class