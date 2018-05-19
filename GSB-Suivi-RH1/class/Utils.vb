Public Class Utils

    Public Shared Sub logout()
        General.user = Nothing
    End Sub

    Public Shared Function yearIsValid(ByVal annee As String) As Boolean
        If annee.Count <> 4 Then
            Return False
        Else
            If Not (annee.All(AddressOf Char.IsDigit)) Then
                Return False
            End If
        End If

        Return True
    End Function

End Class
