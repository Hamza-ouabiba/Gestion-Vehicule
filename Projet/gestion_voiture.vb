Public Class gestion_voiture
    Public voiture(100, 100) As Voiture
    Public compteur_voiture As Integer = 0
    Public current_user As Integer
    Private Sub enregistrer_Click(sender As Object, e As EventArgs) Handles enregistrer.Click
        erreur.Visible = False
        compteur_voiture = Inscription.taille_voiture(current_user)
        If Nom.Text <> "" And matricule.Text <> "" And place.Text <> "" And (peugeot.Text <> "" Or citroen.Text <> "" Or autre.Text <> "") And entree.Text <> "" And sortie.Text <> "" Then
            If peugeot.Checked = True Then
                voiture(current_user, compteur_voiture) = New Voiture(Nom.Text, matricule.Text, Convert.ToInt32(place.Text), peugeot.Text, entree.Text, sortie.Text)
                With ListView1.Items.Add(voiture(current_user, compteur_voiture).chauffeur)
                    .SubItems.Add(voiture(current_user, compteur_voiture).immatriculation)
                    .SubItems.Add(Convert.ToInt32(voiture(current_user, compteur_voiture).nombre_place))
                    .SubItems.Add(voiture(current_user, compteur_voiture).marque)
                    .SubItems.Add(voiture(current_user, compteur_voiture).date_entre)
                    .SubItems.Add(voiture(current_user, compteur_voiture).date_sortie)
                End With
                emptyText()
                compteur_voiture += 1
            ElseIf citroen.Checked = True Then
                voiture(current_user, compteur_voiture) = New Voiture(Nom.Text, matricule.Text, Convert.ToInt32(place.Text), citroen.Text, entree.Text, sortie.Text)
                With ListView1.Items.Add(voiture(current_user, compteur_voiture).chauffeur)
                    .SubItems.Add(voiture(current_user, compteur_voiture).immatriculation)
                    .SubItems.Add(Convert.ToInt32(voiture(current_user, compteur_voiture).nombre_place))
                    .SubItems.Add(voiture(current_user, compteur_voiture).marque)
                    .SubItems.Add(voiture(current_user, compteur_voiture).date_entre)
                    .SubItems.Add(voiture(current_user, compteur_voiture).date_sortie)
                End With
                emptyText()
                compteur_voiture += 1
            Else
                voiture(current_user, compteur_voiture) = New Voiture(Nom.Text, matricule.Text, Convert.ToInt32(place.Text), autre_.Text, entree.Text, sortie.Text)
                With ListView1.Items.Add(voiture(current_user, compteur_voiture).chauffeur)
                    .SubItems.Add(voiture(current_user, compteur_voiture).immatriculation)
                    .SubItems.Add(Convert.ToInt32(voiture(current_user, compteur_voiture).nombre_place))
                    .SubItems.Add(voiture(current_user, compteur_voiture).marque)
                    .SubItems.Add(voiture(current_user, compteur_voiture).date_entre)
                    .SubItems.Add(voiture(current_user, compteur_voiture).date_sortie)
                End With
                emptyText()
                compteur_voiture += 1
            End If
            Inscription.taille_voiture(current_user) = compteur_voiture
        Else
            erreur.Visible = True
        End If
    End Sub
    Sub emptyText()
        Nom.Text = ""
        matricule.Text = ""
        place.Text = ""
        peugeot.Checked = False
        citroen.Checked = False
        autre.Checked = False
        autre_.Text = ""
        entree.Text = ""
        sortie.Text = ""
    End Sub
    Sub effacerContenu()
        ListView1.Items.Clear()
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Deconn.Click
        Dim form1 As New Form1()
        effacerContenu()
        GestionCamion.effacerContenu()
        Me.Hide()
        form1.Show()
    End Sub
End Class