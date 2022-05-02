Imports System.Text.RegularExpressions
Public Class Form1
    Private Declare Sub Sleep Lib "kernel32" (ByVal dwMilliseconds As Long)
    Private Sub Connexion_Click(sender As Object, e As EventArgs) Handles Connexion.Click
        Dim menu As New Menu()
        erreur.Visible = False
        If Nom.Text <> "" And mdp.Text <> "" And Inscription.compteur > 0 Then
            If testeLogin(Inscription.user,
                          Nom.Text,
                          mdp.Text) <> -1 Then
                MsgBox($"la valeur de la position : {testeLogin(Inscription.user, Nom.Text, mdp.Text)}")
                erreur.Visible = True
                erreur.ForeColor = Color.Green
                erreur.Text = "Connexion avec success"
                Sleep(1000)
                Menu.user = Nom.Text
                Me.Hide()
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
    Private Function testeLogin(user As LinkedList(Of Utilisateur), login As String, password As String)
        For Each use In user
            If use.nom = login And use.mdp = password Then
                Return 1
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
