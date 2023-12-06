Imports System.Diagnostics.Eventing.Reader

Public Class frm_authentification
    Private Sub init()
        txt_login.Clear()
        txt_pw.Clear()
    End Sub
    Private Sub btn_valider_Click(sender As Object, e As EventArgs) Handles btn_valider.Click
        Dim login As String
        Dim pw As String
        login = txt_login.Text
        pw = txt_pw.Text
        If (login = "admin") And (pw = "1234") Then
            Me.Hide()
            MessageBox.Show("la connexion est validé")
            frm_main.Show()
        Else
            MessageBox.Show("mot de passe incorrecte")
            init()
        End If

    End Sub

End Class