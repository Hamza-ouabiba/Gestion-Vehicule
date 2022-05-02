Public Class Inscription
    Public user(100) As Utilisateur
    Public compteur As Integer = 0
    Private Sub enregistrer_Click(sender As Object, e As EventArgs) Handles enregistrer.Click
        If compteur < 100 Then
            erreur.Visible = False
            If Nom.Text <> "" And Email.Text <> "" And sexe.Text <> "" And mdp.Text <> "" And mdp2.Text <> "" Then
                user(compteur) = New Utilisateur(Nom.Text, Email.Text, sexe.Text, naissance.Value, mdp.Text)
                With ListView1.Items.Add(user(compteur).nom)
                    .SubItems.Add(user(compteur).email)
                    .SubItems.Add(user(compteur).sexe)
                    .SubItems.Add(user(compteur).date_nais)
                End With
                emptyText()
                compteur += 1
            Else
                erreur.Visible = True
            End If
        Else
            MsgBox("Espace insuffisant ")
        End If
    End Sub
    Sub emptyText()
        Nom.Text = ""
        Email.Text = ""
        sexe.Text = ""
        mdp.Text = ""
        mdp2.Text = ""
    End Sub
    Private Sub initialiser_Click(sender As Object, e As EventArgs) Handles initialiser.Click
        Form1.Show()
        Me.Hide()
    End Sub
End Class