Imports System.Text.RegularExpressions
'création de la classe utilisateur : 
Public Class Utilisateur
    Public nom As String
    Public email As String
    Public sexe As String
    Public date_nais As String
    Public mdp As String
    'constructeur
    Public Sub New(Nom As String, Email As String, Sexe As String, date_naissance As String, mdp As String)
        Me.nom = Nom
        Me.email = Email
        Me.sexe = Sexe
        Me.date_nais = date_naissance
        Me.mdp = mdp
    End Sub
    Public Property Mot_de_passe() As String
        Get
            Return Me.mdp
        End Get
        Set(value As String)
            If (testRegex(value) = "hh") Then
                Inscription.erreur.Visible = True
                MsgBox(Inscription.erreur.Text = "Veuillez Entre un autre mot de passe")
                Inscription.erreur.ForeColor = Color.Red
            Else
                MsgBox(value)
                Me.mdp = value
            End If
        End Set
    End Property
    'Pour les expressions régulières: tester sur le mot de passe 
    Function testRegex(password As String)
        Dim expression As String = "[a-z]"
        Dim test As New Regex(expression)
        If test.IsMatch(expression) Then
            Return "hh"
        Else
            Return "hamza"
        End If
    End Function
End Class