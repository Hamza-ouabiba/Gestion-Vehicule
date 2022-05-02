Public Class gestion_voiture
    Public voiture As New LinkedList(Of Voiture)
    Public compteur_voiture As Integer = 0
    Private Sub enregistrer_Click(sender As Object, e As EventArgs) Handles enregistrer.Click
        erreur.Visible = False
        If Nom.Text <> "" And matricule.Text <> "" And place.Text <> "" And (peugeot.Text <> "" Or citroen.Text <> "" Or autre.Text <> "") And entree.Text <> "" And sortie.Text <> "" Then
            If peugeot.Checked = True Then
                voiture.AddLast(New Voiture(Nom.Text, matricule.Text, Convert.ToInt32(place.Text), peugeot.Text, entree.Text, sortie.Text))
                With ListView1.Items.Add(voiture(compteur_voiture).chauffeur)
                    .SubItems.Add(voiture(compteur_voiture).immatriculation)
                    .SubItems.Add(Convert.ToInt32(voiture(compteur_voiture).nombre_place))
                    .SubItems.Add(voiture(compteur_voiture).marque)
                    .SubItems.Add(voiture(compteur_voiture).date_entre)
                    .SubItems.Add(voiture(compteur_voiture).date_sortie)
                End With
                emptyText()
                compteur_voiture += 1
            ElseIf citroen.Checked = True Then
                voiture.AddLast(New Voiture(Nom.Text, matricule.Text, place.Text, citroen.Text, entree.Text, sortie.Text))
                With ListView1.Items.Add(voiture(compteur_voiture).chauffeur)
                    .SubItems.Add(voiture(compteur_voiture).immatriculation)
                    .SubItems.Add(Convert.ToInt32(voiture(compteur_voiture).nombre_place))
                    .SubItems.Add(voiture(compteur_voiture).marque)
                    .SubItems.Add(voiture(compteur_voiture).date_entre)
                    .SubItems.Add(voiture(compteur_voiture).date_sortie)
                End With
                emptyText()
                compteur_voiture += 1
            Else
                voiture.AddLast(New Voiture(Nom.Text, matricule.Text, place.Text, autre_.Text, entree.Text, sortie.Text))
                With ListView1.Items.Add(voiture(compteur_voiture).chauffeur)
                    .SubItems.Add(voiture(compteur_voiture).immatriculation)
                    .SubItems.Add(Convert.ToInt32(voiture(compteur_voiture).nombre_place))
                    .SubItems.Add(voiture(compteur_voiture).marque)
                    .SubItems.Add(voiture(compteur_voiture).date_entre)
                    .SubItems.Add(voiture(compteur_voiture).date_sortie)
                End With
                emptyText()
                compteur_voiture += 1
            End If
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
    Private Sub initialiser_Click(sender As Object, e As EventArgs) Handles initialiser.Click

    End Sub
End Class