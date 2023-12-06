Public Class frm_RDCjour


    Private Sub btn_supprimer_Click(sender As Object, e As EventArgs) Handles btn_supprimer.Click
        Dim q As Integer
        q = aff_rdv.SelectedCells(0).RowIndex
        tabrdv(q) = Nothing
        aff_rdv.Rows.RemoveAt(q)
        MessageBox.Show("supprimer avec succées")
    End Sub

    Private Sub frm_RDCjour_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        affichers(aff_rdv)
    End Sub
End Class