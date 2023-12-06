Public Class frm_main
    Private Sub AjouterToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AjouterToolStripMenuItem.Click

        frm_ajoutpatient.Show()
    End Sub

    Private Sub AfficherToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AfficherToolStripMenuItem.Click
        frm_afficherpatient.Show()
    End Sub

    Private Sub AjouterToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles AjouterToolStripMenuItem1.Click

        frm_priseRDV.Show()
    End Sub

    Private Sub AfficherToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles AfficherToolStripMenuItem1.Click
        frm_RDCjour.Show()
    End Sub

    Private Sub PatientToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PatientToolStripMenuItem.Click

    End Sub
End Class
