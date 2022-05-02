﻿Public Class GestionCamion
    Public camion_(100, 100) As Camion
    Public compteur_camion As Integer = 0
    Public current_user As Integer
    Public compteur_taille As Integer = 0
    Private Sub enregistrer_Click(sender As Object, e As EventArgs) Handles enregistrer.Click
        erreur.Visible = False
        compteur_camion = Inscription.taille_camion(current_user)
        If Nom.Text <> "" And matricule.Text <> "" And tonnage.Text <> "" And (peugeot.Text <> "" Or citroen.Text <> "" Or autre.Text <> "") And entree.Text <> "" And sortie.Text <> "" Then
            If peugeot.Checked = True Then
                camion_(current_user, compteur_camion) = New Camion(Nom.Text, matricule.Text, Convert.ToInt32(tonnage.Text), peugeot.Text, entree.Text, sortie.Text)
                With lista.Items.Add(camion_(current_user, compteur_camion).chauffeur)
                    .SubItems.Add(camion_(current_user, compteur_camion).immatriculation)
                    .SubItems.Add(Convert.ToInt32(camion_(current_user, compteur_camion).tonnage))
                    .SubItems.Add(camion_(current_user, compteur_camion).marque)
                    .SubItems.Add(camion_(current_user, compteur_camion).date_entre)
                    .SubItems.Add(camion_(current_user, compteur_camion).date_sortie)
                End With
                emptyText()
                compteur_camion += 1
            ElseIf citroen.Checked = True Then
                camion_(current_user, compteur_camion) = New Camion(Nom.Text, matricule.Text, Convert.ToInt32(tonnage.Text), citroen.Text, entree.Text, sortie.Text)
                With lista.Items.Add(camion_(current_user, compteur_camion).chauffeur)
                    .SubItems.Add(camion_(current_user, compteur_camion).immatriculation)
                    .SubItems.Add(Convert.ToInt32(camion_(current_user, compteur_camion).tonnage))
                    .SubItems.Add(camion_(current_user, compteur_camion).marque)
                    .SubItems.Add(camion_(current_user, compteur_camion).date_entre)
                    .SubItems.Add(camion_(current_user, compteur_camion).date_sortie)
                End With
                emptyText()
                compteur_camion += 1
            Else
                camion_(current_user, compteur_camion) = New Camion(Nom.Text, matricule.Text, Convert.ToInt32(tonnage.Text), autre_.Text, entree.Text, sortie.Text)
                With lista.Items.Add(camion_(current_user, compteur_camion).chauffeur)
                    .SubItems.Add(camion_(current_user, compteur_camion).immatriculation)
                    .SubItems.Add(Convert.ToInt32(camion_(current_user, compteur_camion).tonnage))
                    .SubItems.Add(camion_(current_user, compteur_camion).marque)
                    .SubItems.Add(camion_(current_user, compteur_camion).date_entre)
                    .SubItems.Add(camion_(current_user, compteur_camion).date_sortie)
                End With
                emptyText()
                compteur_camion += 1
            End If
            Inscription.taille_camion(current_user) = compteur_camion
        Else
            erreur.Visible = True
        End If
    End Sub
    Sub emptyText()
        Nom.Text = ""
        matricule.Text = ""
        tonnage.Text = ""
        peugeot.Checked = False
        citroen.Checked = False
        autre.Checked = False
        autre_.Text = ""
        entree.Text = ""
        sortie.Text = ""
    End Sub
    Sub effacerContenu()
        lista.Items.Clear()
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Deconn.Click
        Dim form1 As New Form1()
        effacerContenu()
        gestion_voiture.effacerContenu()
        compteur_camion = 0
        Me.Hide()
        form1.Show()
    End Sub

End Class