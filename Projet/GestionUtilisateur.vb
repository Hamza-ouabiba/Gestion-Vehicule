Public Class GestionUtilisateur
    Private Sub GestionUtilisateur_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Inscription.compteur > 0 Then
            For Each use In Inscription.user
                With Me.ListView1.Items.Add(use.nom)
                    .SubItems.Add(use.email)
                    .SubItems.Add(use.sexe)
                    .SubItems.Add(use.date_nais)
                End With
            Next
        End If
    End Sub

    Private Sub menu_Click(sender As Object, e As EventArgs) Handles menu.Click
        Me.Hide()
        MenuPrinci.Show()
    End Sub
    Private Sub decon_Click(sender As Object, e As EventArgs) Handles decon.Click
        Dim form1 As New Form1()
        Me.Hide()
        form1.Show()
    End Sub

    Private Sub IconButton2_Click(sender As Object, e As EventArgs)

    End Sub
End Class