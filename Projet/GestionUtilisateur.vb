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
    Private Sub modifier_Click(sender As Object, e As EventArgs) Handles modifier.Click
        Dim indice As Integer
        indice = ListView1_SelectedIndexChanged(sender, e)
        If indice <> -1 And indice <> gestion_voiture.current_user Then
            If Nom.Text <> "" And Email.Text <> "" Then
                Inscription.user(indice).nom = Nom.Text
                Inscription.user(indice).email = Email.Text
                Inscription.user(indice).date_nais = naissance.Value.Date
                With Inscription.ListView1.Items(indice)
                    .SubItems(0).Text = Inscription.user(indice).nom
                    .SubItems(1).Text = Inscription.user(indice).email
                    .SubItems(2).Text = Inscription.user(indice).date_nais
                End With
                With ListView1.Items(indice)
                    .SubItems(0).Text = Inscription.user(indice).nom
                    .SubItems(1).Text = Inscription.user(indice).email
                    .SubItems(2).Text = Inscription.user(indice).date_nais
                End With
                erreur.ForeColor = Color.Green
                erreur.Text = "Modifier avec succes"
                erreur.Visible = True
            End If
        End If
    End Sub
End Class