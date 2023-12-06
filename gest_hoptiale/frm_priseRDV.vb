Public Class frm_priseRDV

    Private Sub btn_ajouter_Click(sender As Object, e As EventArgs) Handles btn_ajouter.Click
        Dim p As rdv
        With p
            p.code = txt_cods.Text
            p.date_heure = txt_date.Text
        End With
        If ajouter_rdv(p) Then
            MessageBox.Show("ajouter avec succées")
        Else
            MessageBox.Show("le tableau est saturé")
        End If
        txt_cods.Clear()
        txt_date.Clear()


    End Sub

    Private Sub txt_date_TextChanged(sender As Object, e As EventArgs) Handles txt_date.TextChanged

    End Sub
End Class