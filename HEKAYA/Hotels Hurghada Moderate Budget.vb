Public Class Hotels_Hurghada_Moderate_Budget
    Private Sub PictureBox6_Click(sender As Object, e As EventArgs) Handles PictureBox6.Click
        Choosse_Your_Distination.Show()
        Me.Hide()
    End Sub

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click
        User_Profile.Show()
        Me.Hide()
    End Sub

    Private Sub PictureBox7_Click(sender As Object, e As EventArgs) Handles PictureBox7.Click
        Favorites_List.Show()
        Me.Hide()
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        Moderate_Budget_Hurghada_Kempinski_Hotel_Soma_Bay.Show()
        Me.Hide()
    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click
        Moderate_Budget_Hurghada_Kempinski_Hotel_Soma_Bay.Show()
        Me.Hide()
    End Sub

    Private Sub Label10_Click(sender As Object, e As EventArgs) Handles Label10.Click
        Moderate_Budget_Hurghada_Kempinski_Hotel_Soma_Bay.Show()
        Me.Hide()
    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click
        Moderate_Budget_Hurghada_Old_Palace_Resort.Show()
        Me.Hide()
    End Sub

    Private Sub Label11_Click(sender As Object, e As EventArgs) Handles Label11.Click
        Moderate_Budget_Hurghada_Kempinski_Hotel_Soma_Bay.Show()
        Me.Hide()
    End Sub

    Private Sub PictureBox10_Click(sender As Object, e As EventArgs) Handles PictureBox10.Click
        Moderate_Budget_Hurghada_Kempinski_Hotel_Soma_Bay.Show()
        Me.Hide()
    End Sub

    Private Sub PictureBox11_Click(sender As Object, e As EventArgs) Handles PictureBox11.Click
        Moderate_Budget_Hurghada_Sunny_Days_Mirette_Family_Resort.Show()
        Me.Hide()
    End Sub

    Private Sub Label13_Click(sender As Object, e As EventArgs) Handles Label13.Click
        Moderate_Budget_Hurghada_Sunny_Days_Mirette_Family_Resort.Show()
        Me.Hide()
    End Sub

    Private Sub Label9_Click(sender As Object, e As EventArgs) Handles Label9.Click
        Moderate_Budget_Hurghada_Sunny_Days_Mirette_Family_Resort.Show()
        Me.Hide()
    End Sub

    Private Sub PictureBox9_Click(sender As Object, e As EventArgs) Handles PictureBox9.Click
        Moderate_Budget_Hurghada_Elaria_Hotel_Hurghada.Show()
        Me.Hide()
    End Sub

    Private Sub Label12_Click(sender As Object, e As EventArgs) Handles Label12.Click
        Moderate_Budget_Hurghada_Elaria_Hotel_Hurghada.Show()
        Me.Hide()
    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click
        Moderate_Budget_Hurghada_Elaria_Hotel_Hurghada.Show()
        Me.Hide()
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

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        Hotels_Hurghada_Small_Budget.Show()
        Me.Hide()
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click
        hotels_Hurghada_large_budget.Show()
        Me.Hide()
    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        Hotels_Hurghada_Small_Budget.Show()
        Me.Hide()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        hotels_Hurghada_large_budget.Show()
        Me.Hide()
    End Sub

    Private Sub Hotels_Hurghada_Moderate_Budget_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AddPageToHistory(Me.Name)
    End Sub
End Class