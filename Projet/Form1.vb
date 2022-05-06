Imports System.Text.RegularExpressions
Public Class Form1
    Private Declare Sub Sleep Lib "kernel32" (ByVal dwMilliseconds As Long)
    Private Sub Connexion_Click(sender As Object, e As EventArgs) Handles Connexion.Click
        Dim menu As New MenuPrinci()
        erreur.Visible = False
        If Nom.Text <> "" And mdp.Text <> "" And Inscription.compteur > 0 Then
            If testeLogin(Inscription.user,
                          Nom.Text,
                          mdp.Text, Inscription.compteur) <> -1 Then
                Sleep(1000)
                Me.Hide()
                gestion_voiture.current_user = testeLogin(Inscription.user, Nom.Text, mdp.Text, Inscription.compteur)
                GestionCamion.current_user = testeLogin(Inscription.user, Nom.Text, mdp.Text, Inscription.compteur)
                menu.Show()
            Else
                erreur.Visible = True
                erreur.ForeColor = Color.Red
                erreur.Text = "Nom ou mot De passe est incorrecte"
            End If
        ElseIf Inscription.compteur = 0 Then
            erreur.Visible = True
            erreur.ForeColor = Color.Red
            erreur.Text = "Base de donne vide veuillez creer un compte "
        End If
    End Sub
    'la recherche des utilisateurs dans la liste : 
    Private Function testeLogin(user As LinkedList(Of Utilisateur), login As String, password As String, taille As Integer)
        For i As Integer = 0 To taille - 1
            If user(i).nom = login And user(i).mdp = password Then
                Return i
            End If
        Next
        Return -1
    End Function
    Private Sub affichage_us(user As LinkedList(Of Utilisateur))
        For Each use In user
            MsgBox($"Nom {use.nom} Sexe {use.sexe} \n")
        Next
    End Sub
    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles affichage.CheckedChanged
        If affichage.Checked Then
            mdp.UseSystemPasswordChar = False
        Else
            mdp.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub inscri_Click_1(sender As Object, e As EventArgs) Handles inscri.Click
        Inscription.Show()
        Me.Hide()
    End Sub
End Class
