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

    Private Sub supprimer_Click(sender As Object, e As EventArgs) Handles supprimer.Click
        Dim indice As Integer
        indice = ListView1_SelectedIndexChanged(sender, e)
        MsgBox(indice)
        If indice <> -1 And indice <> gestion_voiture.current_user Then
            Me.ListView1.Items.RemoveAt(indice)
            Inscription.user.Remove(Inscription.user(indice))
            Inscription.ListView1.Items.RemoveAt(indice)
            Inscription.compteur -= 1
            erreur.Text = "Supprimer avec succes"
            erreur.ForeColor = Color.Green
        End If
    End Sub

    Private Function ListView1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListView1.ItemChecked
        Try
            If ListView1.Items.Count > 0 Then
                Return ListView1.FocusedItem.Index
            End If
            Return -1
        Catch ex As Exception
            erreur.Text = "Cliquer sur un Item"
        End Try
    End Function
End Class