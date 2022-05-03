Public Class gestionUtilisateur
    Private Sub gestionUtilisateur_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        For Each use In Inscription.user
            With Me.ListView1.Items.Add(use.nom)
                .SubItems.Add(use.email)
                .SubItems.Add(use.sexe)
                .SubItems.Add(use.date_nais)
            End With
        Next
    End Sub
    Sub effacerContenu()
        ListView1.Items.Clear()
    End Sub

    Private Sub menu_Click(sender As Object, e As EventArgs) Handles menu.Click
        Me.Hide()
        MenuPrinci.Show()
    End Sub
End Class