Public Class frm_ajoutpatient
    Private Sub txt_nom_TextChanged(sender As Object, e As EventArgs) Handles txt_code.TextChanged

    End Sub

    Private Sub btn_ajouter_Click(sender As Object, e As EventArgs) Handles btn_ajouter.Click
        Dim p As patient
        With p
            p.code = txt_code.Text
            p.nom = txt_nom.Text
            p.prenom = txt_prenom.Text
        End With
        ajout_patient(p)
        MessageBox.Show("ajouter avec succées")



        txt_code.Clear()
        txt_nom.Clear()
        txt_prenom.Clear()
    End Sub

    Private Sub btn_afficher_Click(sender As Object, e As EventArgs)
        frm_afficherpatient.Show()
    End Sub

    Private Sub btn_annuler_Click(sender As Object, e As EventArgs) Handles btn_annuler.Click
        Me.Close()
    End Sub
End Class