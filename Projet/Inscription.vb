Public Class Inscription
    Public user(100) As Utilisateur
    Public compteur As Integer = 0
    Private Declare Sub Sleep Lib "kernel32" (ByVal dwMilliseconds As Long)
    Private Sub enregistrer_Click(sender As Object, e As EventArgs) Handles enregistrer.Click
        If compteur < 100 Then
            erreur.Visible = False
            If Nom.Text <> "" And Email.Text <> "" And sexe.Text <> "" And mdp.Text <> "" And mdp2.Text <> "" Then
                If mdp.Text = mdp2.Text Then
                    erreur.Visible = False
                    user(compteur) = New Utilisateur(Nom.Text, Email.Text, sexe.Text, naissance.Value, mdp.Text)
                    With ListView1.Items.Add(user(compteur).nom)
                        .SubItems.Add(user(compteur).email)
                        .SubItems.Add(user(compteur).sexe)
                        .SubItems.Add(user(compteur).date_nais)
                    End With
                    erreur.Visible = True
                    erreur.Text = "Compte Creer avec succees"
                    erreur.ForeColor = Color.Green
                    Sleep(1000)
                    emptyText()
                    erreur.Visible = False
                    compteur += 1
                Else
                    erreur.Visible = True
                    erreur.Text = "Mot de passe Erronne"
                    erreur.ForeColor = Color.Red
                End If
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
        cacher.Visible = False
        cacher2.Visible = False
    End Sub
    Private Sub initialiser_Click(sender As Object, e As EventArgs) Handles initialiser.Click
        Form1.Show()
        Me.Hide()
    End Sub
    Private Sub IconButton2_Click(sender As Object, e As EventArgs) Handles IconButton2.Click
        mdp.UseSystemPasswordChar = False
        cacher.Visible = True
    End Sub
    Private Sub cacher_Click(sender As Object, e As EventArgs) Handles cacher.Click
        mdp.UseSystemPasswordChar = True
        cacher.Visible = False
    End Sub

    Private Sub cacher2_Click(sender As Object, e As EventArgs) Handles cacher2.Click
        mdp2.UseSystemPasswordChar = True
        cacher2.Visible = False
    End Sub

    Private Sub IconButton3_Click(sender As Object, e As EventArgs) Handles IconButton3.Click
        mdp2.UseSystemPasswordChar = False
        cacher2.Visible = True
    End Sub
End Class