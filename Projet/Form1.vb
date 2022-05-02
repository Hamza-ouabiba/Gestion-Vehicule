Imports System
Public Class Form1
    Private Sub Connexion_Click(sender As Object, e As EventArgs) Handles Connexion.Click
        erreur.Visible = False
        If Nom.Text <> "" And mdp.Text <> "" And Inscription.compteur > 0 Then
            If testeLogin(Inscription.user, Nom.Text, mdp.Text, Inscription.compteur) <> -1 Then
                MsgBox($"la valeur de la position : {testeLogin(Inscription.user, Nom.Text, mdp.Text, Inscription.compteur)}")
                erreur.Visible = True
                erreur.ForeColor = Color.Green
                erreur.Text = "Connexion avec success"
                Me.Hide()
                Menu.Show()
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
    Private Function testeLogin(user() As Utilisateur, login As String, password As String, compteur As Integer)
        Dim i As Integer
        For i = 0 To compteur - 1
            If (user(i).nom = login And user(i).mdp = password) Then
                Return i
            End If
        Next
        Return -1
    End Function

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
