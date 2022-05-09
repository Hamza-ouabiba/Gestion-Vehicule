Public Class GestionCamion
    Public camion_(100, 100) As Camion
    Public compteur_camion As Integer = 0
    Public current_user As Integer
    Public compteur_taille As Integer = 0
    Private Sub enregistrer_Click(sender As Object, e As EventArgs) Handles enregistrer.Click
        erreur.Visible = False
        compteur_camion = Inscription.taille_camion(current_user)
        If compteur_camion < 100 Then
            If Nom.Text <> "" And matricule.Text <> "" And tonnage.Text <> "" And (peugeot.Text <> "" Or citroen.Text <> "" Or autre.Text <> "") And entree.Text <> "" And sortie.Text <> "" Then
                If peugeot.Checked = True Then
                    Try
                        'Instancier un objet de la classe camion : 
                        camion_(current_user, compteur_camion) = New Camion(Nom.Text, matricule.Text, Convert.ToInt32(tonnage.Text), peugeot.Text, entree.Value.Date, sortie.Value.Date)
                        With lista.Items.Add(camion_(current_user, compteur_camion).chauffeur)
                            .SubItems.Add(camion_(current_user, compteur_camion).immatriculation)
                            .SubItems.Add(Convert.ToInt32(camion_(current_user, compteur_camion).tonnage))
                            .SubItems.Add(camion_(current_user, compteur_camion).marque)
                            .SubItems.Add(camion_(current_user, compteur_camion).date_entre)
                            .SubItems.Add(camion_(current_user, compteur_camion).date_sortie)
                        End With
                        emptyText()
                        compteur_camion += 1
                        Inscription.taille_camion(current_user) = compteur_camion
                    Catch ex As Exception
                        erreur.Visible = True
                        erreur.Text = "Le tonnage ne peut pas etre un texte"
                    End Try
                ElseIf citroen.Checked = True Then
                    Try
                        camion_(current_user, compteur_camion) = New Camion(Nom.Text, matricule.Text, Convert.ToInt32(tonnage.Text), citroen.Text, entree.Value.Date, sortie.Value.Date)
                        With lista.Items.Add(camion_(current_user, compteur_camion).chauffeur)
                            .SubItems.Add(camion_(current_user, compteur_camion).immatriculation)
                            .SubItems.Add(Convert.ToInt32(camion_(current_user, compteur_camion).tonnage))
                            .SubItems.Add(camion_(current_user, compteur_camion).marque)
                            .SubItems.Add(camion_(current_user, compteur_camion).date_entre)
                            .SubItems.Add(camion_(current_user, compteur_camion).date_sortie)
                        End With
                        emptyText()
                        compteur_camion += 1
                        Inscription.taille_camion(current_user) = compteur_camion
                    Catch ex As Exception
                        erreur.Visible = True
                        erreur.Text = "Le tonnage ne peut pas etre un texte"
                    End Try
                Else
                    Try
                        camion_(current_user, compteur_camion) = New Camion(Nom.Text, matricule.Text, Convert.ToInt32(tonnage.Text), autre_.Text, entree.Value.Date, sortie.Value.Date)
                        With lista.Items.Add(camion_(current_user, compteur_camion).chauffeur)
                            .SubItems.Add(camion_(current_user, compteur_camion).immatriculation)
                            .SubItems.Add(Convert.ToInt32(camion_(current_user, compteur_camion).tonnage))
                            .SubItems.Add(camion_(current_user, compteur_camion).marque)
                            .SubItems.Add(camion_(current_user, compteur_camion).date_entre)
                            .SubItems.Add(camion_(current_user, compteur_camion).date_sortie)
                        End With
                        emptyText()
                        compteur_camion += 1
                        Inscription.taille_camion(current_user) = compteur_camion
                    Catch ex As Exception
                        erreur.Visible = True
                        erreur.Text = "Le tonnage ne peut pas etre un texte"
                    End Try
                End If

            Else
                erreur.Visible = True
            End If
        Else
            erreur.Text = "Stockage insuffisant"
            erreur.Visible = True
            erreur.ForeColor = Color.Red
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
        erreur.Text = ""
    End Sub
    Sub effacerContenu()
        lista.Items.Clear()
    End Sub
    Private Sub menu_Click(sender As Object, e As EventArgs) Handles menu.Click
        effacerContenu()
        emptyText()
        gestion_voiture.effacerContenu()
        If Inscription.taille_voiture(gestion_voiture.current_user) > 0 Then
            For i As Integer = 0 To (Inscription.taille_voiture(gestion_voiture.current_user)) - 1
                With gestion_voiture.ListView1.Items.Add(gestion_voiture.voiture(gestion_voiture.current_user, i).chauffeur)
                    .SubItems.Add(gestion_voiture.voiture(gestion_voiture.current_user, i).immatriculation)
                    .SubItems.Add(Convert.ToInt32(gestion_voiture.voiture(gestion_voiture.current_user, i).nombre_place))
                    .SubItems.Add(gestion_voiture.voiture(gestion_voiture.current_user, i).marque)
                    .SubItems.Add(gestion_voiture.voiture(gestion_voiture.current_user, i).date_entre)
                    .SubItems.Add(gestion_voiture.voiture(gestion_voiture.current_user, i).date_sortie)
                End With
            Next
        End If
        If Inscription.taille_camion(Me.current_user) > 0 Then
            For i As Integer = 0 To Inscription.taille_camion(Me.current_user) - 1
                With Me.lista.Items.Add(Me.camion_(Me.current_user, i).chauffeur)
                    .SubItems.Add(Me.camion_(Me.current_user, i).immatriculation)
                    .SubItems.Add(Convert.ToInt32(Me.camion_(Me.current_user, i).tonnage))
                    .SubItems.Add(Me.camion_(Me.current_user, i).marque)
                    .SubItems.Add(Me.camion_(Me.current_user, i).date_entre)
                    .SubItems.Add(Me.camion_(Me.current_user, i).date_sortie)
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
    Function chercherSuppr(chauff As String, imma As String, taille As Integer)
        For i As Integer = 0 To taille - 1
            If camion_(Me.current_user, i).chauffeur = chauff And camion_(Me.current_user, i).immatriculation = imma Then
                Return i
            End If
        Next
        Return -1
    End Function
    Private Sub supprimer_Click(sender As Object, e As EventArgs) Handles supprimer.Click
        Dim indice As Integer = lista_SelectedIndexChanged(sender, e)
        If indice <> -1 Then
            Me.lista.Items.RemoveAt(indice)
            For i As Integer = indice To compteur_camion - 2
                camion_(Me.current_user, i) = camion_(Me.current_user, i + 1)
            Next
            Inscription.taille_camion(Me.current_user) -= 1
            erreur.Visible = True
            erreur.Text = "Supprimer avec succes"
            erreur.ForeColor = Color.Green
        End If
    End Sub
    Private Sub modifier_Click(sender As Object, e As EventArgs) Handles modifier.Click
        Dim indice As Integer
        If Nom.Text <> "" And matricule.Text <> "" Then
            indice = lista_SelectedIndexChanged(sender, e)
            If indice <> -1 Then
                If Nom.Text <> "" And matricule.Text <> "" And tonnage.Text <> "" And (peugeot.Text <> "" Or citroen.Text <> "" Or autre.Text <> "") And entree.Text <> "" And sortie.Text <> "" Then
                    camion_(current_user, indice).chauffeur = Nom.Text
                    camion_(current_user, indice).immatriculation = matricule.Text
                    camion_(current_user, indice).tonnage = tonnage.Text
                    If peugeot.Checked Then
                        camion_(current_user, indice).marque = peugeot.Text
                    ElseIf citroen.Checked Then
                        camion_(current_user, indice).marque = citroen.Text
                    Else
                        camion_(current_user, indice).marque = autre_.Text
                    End If
                    camion_(current_user, indice).date_entre = entree.Value.Date
                    camion_(current_user, indice).date_sortie = sortie.Value.Date
                    With lista.Items(indice)
                        .SubItems(0).Text = camion_(current_user, indice).chauffeur
                        .SubItems(1).Text = camion_(current_user, indice).immatriculation
                        .SubItems(2).Text = camion_(current_user, indice).tonnage
                        .SubItems(3).Text = camion_(current_user, indice).marque
                        .SubItems(4).Text = camion_(current_user, indice).date_entre
                        .SubItems(5).Text = camion_(current_user, indice).date_sortie
                    End With
                End If
            Else
                erreur.Text = "Aucune donne trouvée"
                erreur.ForeColor = Color.Red
            End If
        End If
    End Sub

    Private Function lista_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lista.ItemChecked
        If lista.Items.Count > 0 Then
            Return lista.FocusedItem.Index
        End If
        Return -1
    End Function
End Class