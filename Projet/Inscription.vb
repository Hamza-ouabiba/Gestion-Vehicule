Public Class Inscription
    Public user As New LinkedList(Of Utilisateur)
    Public compteur As Integer = 0
    Public taille_voiture(100) As Integer
    Public taille_camion(100) As Integer
    Private Declare Sub Sleep Lib "kernel32" (ByVal dwMilliseconds As Long)
    'creer un nouveau utilisateur
    Private Sub enregistrer_Click(sender As Object, e As EventArgs) Handles enregistrer.Click
        erreur.Visible = False
        If Nom.Text <> "" And Email.Text <> "" And sexe.Text <> "" And mdp.Text <> "" And mdp2.Text <> "" Then
            If mdp.Text = mdp2.Text Then
                erreur.Visible = False
                'instancier un objet de la classe utilisateur : 
                user.AddLast(New Utilisateur(Nom.Text, Email.Text, sexe.Text, naissance.Value.Date, mdp.Text))
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
            erreur.ForeColor = Color.Red
            erreur.Text = "Veuillez entrer les champs requis"
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
        Dim form1 As New Form1
        form1.Show()
        Me.Hide()
    End Sub
    Private Sub IconButton2_Click(sender As Object, e As EventArgs) Handles IconButton2.Click
        mdp.UseSystemPasswordChar = True
        cacher.Visible = True
        IconButton2.Visible = False
    End Sub
    Private Sub cacher_Click(sender As Object, e As EventArgs) Handles cacher.Click
        mdp.UseSystemPasswordChar = False
        cacher.Visible = False
        IconButton2.Visible = True
    End Sub

    Private Sub cacher2_Click(sender As Object, e As EventArgs) Handles cacher2.Click
        mdp2.UseSystemPasswordChar = False
        cacher2.Visible = False
        IconButton3.Visible = True
    End Sub

    Private Sub IconButton3_Click(sender As Object, e As EventArgs) Handles IconButton3.Click
        mdp2.UseSystemPasswordChar = True
        cacher2.Visible = True
        IconButton3.Visible = False
    End Sub
End Class