Module NavigationModule

    Public PagesHistory As New List(Of String)
    Public Sub AddPageToHistory(pageName As String)
        PagesHistory.Add(pageName)
    End Sub
    Public Function GetPreviousPage() As String
        If PagesHistory.Count > 1 Then
            Dim previousPage As String = PagesHistory(PagesHistory.Count - 2)
            PagesHistory.RemoveAt(PagesHistory.Count - 1)
            Return previousPage
        Else
            Return Nothing
        End If
    End Function
End Module
