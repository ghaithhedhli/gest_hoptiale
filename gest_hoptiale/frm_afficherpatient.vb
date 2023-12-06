Public Class frm_afficherpatient


    Private Sub btn_supprimer_Click(sender As Object, e As EventArgs) Handles btn_supprimer.Click
        Dim q As Integer
        q = dgv_pat.SelectedCells(0).RowIndex
        patients(q) = Nothing
        dgv_pat.Rows.RemoveAt(q)
        MessageBox.Show("supprimer avec succées")
    End Sub

    Private Sub frm_afficherpatient_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        afficher(dgv_pat)
    End Sub
End Class