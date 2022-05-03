Public Class gestion_voiture
    Public voiture(100, 100) As Voiture
    Public compteur_voiture As Integer = 0
    Public current_user As Integer
    Private Sub enregistrer_Click(sender As Object, e As EventArgs) Handles enregistrer.Click
        erreur.Visible = False
        compteur_voiture = Inscription.taille_voiture(current_user)
        If Nom.Text <> "" And matricule.Text <> "" And place.Text <> "" And (peugeot.Text <> "" Or citroen.Text <> "" Or autre.Text <> "") And entree.Text <> "" And sortie.Text <> "" Then
            If peugeot.Checked = True Then
                Try
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
                Catch ex As Exception
                    erreur.Visible = True
                    erreur.Text = "Le nombre de place ne peut pas etre un texte"
                End Try
            ElseIf citroen.Checked = True Then
                Try
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
                Catch ex As Exception
                    erreur.Visible = True
                    erreur.Text = "Le nombre de place ne peut pas etre un texte"
                End Try
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
    Private Sub menu_Click(sender As Object, e As EventArgs) Handles menu.Click
        MenuPrinci.Show()
        Me.Hide()
    End Sub
    Private Sub decon_Click(sender As Object, e As EventArgs) Handles decon.Click
        Dim form1 As New Form1()
        Me.Hide()
        form1.Show()
    End Sub
    Function chercherSuppr(chauff As String, imma As String, taille As Integer)
        For i As Integer = 0 To taille - 1
            If voiture(Me.current_user, i).chauffeur = chauff And voiture(Me.current_user, i).immatriculation = imma Then
                Return i
            End If
        Next
        Return -1
    End Function
    Private Sub supprimer_Click(sender As Object, e As EventArgs) Handles supprimer.Click
        Dim indice As Integer
        erreur.Visible = True
        erreur.Text = "Entre le nom du chaffeur et l'immatriculation a supprimer"
        erreur.ForeColor = Color.Orange
        If Nom.Text <> "" And matricule.Text <> "" Then
            indice = chercherSuppr(Nom.Text, matricule.Text, compteur_voiture)
            If indice <> -1 Then
                Me.ListView1.Items.RemoveAt(indice)
                For i As Integer = indice To compteur_voiture - 2
                    voiture(Me.current_user, i) = voiture(Me.current_user, i + 1)
                Next
                Inscription.taille_voiture(Me.current_user) -= 1
            End If
            erreur.Text = "Supprimer avec succes"
            erreur.ForeColor = Color.Green
        End If
    End Sub

    Private Sub gestion_voiture_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
    End Sub
End Class