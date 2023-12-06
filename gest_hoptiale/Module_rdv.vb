Module Module_rdv
    Public Structure rdv
        Dim code As String
        Dim date_heure As String



    End Structure
    Public tabrdv(100) As rdv
    Dim nb As Integer
    Public Function ajouter_rdv(p As rdv) As Boolean
        If nb < tabrdv.Length Then
            tabrdv(nb) = p
            nb += 1
            Return True
        Else
            Return False
        End If
    End Function
    Public Function affichers(dgv As DataGridView)
        Dim p As rdv

        For Each p In tabrdv
            If p.code IsNot Nothing Then
                dgv.Rows.Add(p.code, p.date_heure)
            End If
        Next
    End Function

End Module
