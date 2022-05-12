Public Class gestion_voiture
    Public voiture(100, 100) As Voiture
    Public compteur_voiture As Integer = 0
    Public current_user As Integer
    Private Sub enregistrer_Click(sender As Object, e As EventArgs) Handles enregistrer.Click
        erreur.Visible = False
        compteur_voiture = Inscription.taille_voiture(current_user)
        If compteur_voiture < 100 Then
            If Nom.Text <> "" And matricule.Text <> "" And place.Text <> "" And (peugeot.Text <> "" Or citroen.Text <> "" Or autre.Text <> "") And entree.Text <> "" And sortie.Text <> "" Then
                If testeMatricule(matricule.Text) = -1 Then
                    If peugeot.Checked = True Then
                        Try
                            'Instancier un objet de la classe voiture : 
                            voiture(current_user, compteur_voiture) = New Voiture(Nom.Text, matricule.Text, Convert.ToInt32(place.Text), peugeot.Text, entree.Value.Date, sortie.Value.Date)
                            With ListView1.Items.Add(voiture(current_user, compteur_voiture).chauffeur)
                                .SubItems.Add(voiture(current_user, compteur_voiture).immatriculation)
                                .SubItems.Add(Convert.ToInt32(voiture(current_user, compteur_voiture).nombre_place))
                                .SubItems.Add(voiture(current_user, compteur_voiture).marque)
                                .SubItems.Add(voiture(current_user, compteur_voiture).date_entre)
                                .SubItems.Add(voiture(current_user, compteur_voiture).date_sortie)
                            End With
                            emptyText()
                            compteur_voiture += 1
                            Inscription.taille_voiture(current_user) = compteur_voiture
                        Catch ex As Exception
                            erreur.Visible = True
                            erreur.Text = "Le nombre de place ne peut pas etre un texte"
                        End Try
                    ElseIf citroen.Checked = True Then
                        Try
                            voiture(current_user, compteur_voiture) = New Voiture(Nom.Text, matricule.Text, Convert.ToInt32(place.Text), citroen.Text, entree.Value.Date, sortie.Value.Date)
                            With ListView1.Items.Add(voiture(current_user, compteur_voiture).chauffeur)
                                .SubItems.Add(voiture(current_user, compteur_voiture).immatriculation)
                                .SubItems.Add(Convert.ToInt32(voiture(current_user, compteur_voiture).nombre_place))
                                .SubItems.Add(voiture(current_user, compteur_voiture).marque)
                                .SubItems.Add(voiture(current_user, compteur_voiture).date_entre)
                                .SubItems.Add(voiture(current_user, compteur_voiture).date_sortie)
                            End With
                            emptyText()
                            compteur_voiture += 1
                            Inscription.taille_voiture(current_user) = compteur_voiture
                        Catch ex As Exception
                            erreur.Visible = True
                            erreur.Text = "Le nombre de place ne peut pas etre un texte"
                        End Try
                    Else
                        Try
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
                            Inscription.taille_voiture(current_user) = compteur_voiture
                        Catch ex As Exception
                            erreur.Visible = True
                            erreur.Text = "Le nombre de place ne peut pas etre un texte"
                        End Try
                    End If
                Else
                    erreur.Visible = True
                    erreur.Text = "Ce matricule existe deja"
                End If
            Else
                erreur.Visible = True
            End If
        Else
            erreur.Visible = True
            erreur.Text = "Stockage insuffisant"
            erreur.ForeColor = Color.Red
        End If
    End Sub
    Function testeMatricule(matricule As String)
        For i As Integer = 0 To compteur_voiture - 1
            If matricule = voiture(current_user, i).immatriculation Then
                Return i
            End If
        Next
        Return -1
    End Function
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
        erreur.Text = ""
    End Sub
    Sub effacerContenu()
        ListView1.Items.Clear()
    End Sub
    Private Sub menu_Click(sender As Object, e As EventArgs) Handles menu.Click
        effacerContenu()
        emptyText()
        GestionCamion.effacerContenu()
        If Inscription.taille_voiture(Me.current_user) > 0 Then
            For i As Integer = 0 To (Inscription.taille_voiture(Me.current_user)) - 1
                With Me.ListView1.Items.Add(Me.voiture(Me.current_user, i).chauffeur)
                    .SubItems.Add(Me.voiture(Me.current_user, i).immatriculation)
                    .SubItems.Add(Convert.ToInt32(Me.voiture(Me.current_user, i).nombre_place))
                    .SubItems.Add(Me.voiture(Me.current_user, i).marque)
                    .SubItems.Add(Me.voiture(Me.current_user, i).date_entre)
                    .SubItems.Add(Me.voiture(Me.current_user, i).date_sortie)
                End With
            Next
        End If
        If Inscription.taille_camion(GestionCamion.current_user) > 0 Then
            For i As Integer = 0 To Inscription.taille_camion(GestionCamion.current_user) - 1
                With GestionCamion.lista.Items.Add(GestionCamion.camion_(GestionCamion.current_user, i).chauffeur)
                    .SubItems.Add(GestionCamion.camion_(GestionCamion.current_user, i).immatriculation)
                    .SubItems.Add(Convert.ToInt32(GestionCamion.camion_(GestionCamion.current_user, i).tonnage))
                    .SubItems.Add(GestionCamion.camion_(GestionCamion.current_user, i).marque)
                    .SubItems.Add(GestionCamion.camion_(GestionCamion.current_user, i).date_entre)
                    .SubItems.Add(GestionCamion.camion_(GestionCamion.current_user, i).date_sortie)
                End With
            Next
        End If
        MenuPrinci.Show()
        Me.Hide()
    End Sub
    Private Sub decon_Click(sender As Object, e As EventArgs) Handles decon.Click
        Dim form1 As New Form1()
        emptyText()
        Me.Hide()
        form1.Show()
    End Sub
    Private Sub supprimer_Click(sender As Object, e As EventArgs) Handles supprimer.Click
        Dim indice As Integer
        indice = ListView1_SelectedIndexChanged(sender, e)
        If indice <> -1 Then
            Me.ListView1.Items.RemoveAt(indice)
            For i As Integer = indice To compteur_voiture - 2
                voiture(Me.current_user, i) = voiture(Me.current_user, i + 1)
            Next
            Inscription.taille_voiture(Me.current_user) -= 1
            erreur.Text = "Supprimer avec succes"
            erreur.ForeColor = Color.Green
        End If
    End Sub
    Private Function ListView1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListView1.ItemChecked
        If ListView1.Items.Count > 0 Then
            Return ListView1.FocusedItem.Index
        End If
        Return -1
    End Function

    Private Sub modifier_Click(sender As Object, e As EventArgs) Handles modifier.Click
        Dim indice As Integer
        If Nom.Text <> "" And matricule.Text <> "" Then
            indice = ListView1_SelectedIndexChanged(sender, e)
            If indice <> -1 Then
                If Nom.Text <> "" And matricule.Text <> "" And place.Text <> "" And (peugeot.Text <> "" Or citroen.Text <> "" Or autre.Text <> "") And entree.Text <> "" And sortie.Text <> "" Then
                    If testeMatricule(matricule.Text) = -1 Then
                        voiture(current_user, indice).chauffeur = Nom.Text
                        voiture(current_user, indice).immatriculation = matricule.Text
                        voiture(current_user, indice).nombre_place = place.Text
                        If peugeot.Checked Then
                            voiture(current_user, indice).marque = peugeot.Text
                        ElseIf citroen.Checked Then
                            voiture(current_user, indice).marque = citroen.Text
                        Else
                            voiture(current_user, indice).marque = autre_.Text
                        End If
                        voiture(current_user, indice).date_entre = entree.Value.Date
                        voiture(current_user, indice).date_sortie = sortie.Value.Date
                        With ListView1.Items(indice)
                            .SubItems(0).Text = voiture(current_user, indice).chauffeur
                            .SubItems(1).Text = voiture(current_user, indice).immatriculation
                            .SubItems(2).Text = voiture(current_user, indice).nombre_place
                            .SubItems(3).Text = voiture(current_user, indice).marque
                            .SubItems(4).Text = voiture(current_user, indice).date_entre
                            .SubItems(5).Text = voiture(current_user, indice).date_sortie
                        End With
                    Else
                        erreur.Text = "Matricule existe deja"
                        erreur.Visible = True
                    End If
                End If
                emptyText()
            Else
                erreur.Text = "Aucune donne trouvée"
                erreur.ForeColor = Color.Red
            End If
        End If
    End Sub
End Class