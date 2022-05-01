Public Class Utilisateur
    Public nom As String
    Public email As String
    Public sexe As String
    Public date_nais As String
    Public mdp As String
    Public Sub New(Nom As String, Email As String, Sexe As String, date_naissance As String, mdp As String)
        Me.nom = Nom
        Me.email = Email
        Me.sexe = Sexe
        Me.date_nais = date_naissance
        Me.mdp = mdp
    End Sub
End Class