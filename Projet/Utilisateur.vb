﻿'création de la classe utilisateur : 
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
    'Public Property Mot_de_passe As String
    'Get
    '   Return Me.mdp
    'End Get
    ' Set(value As String)
    '  If (testRegex(value) = 1) Then
    '       Me.mdp = value
    '    Else
    '         MsgBox("3awd ")
    '      End If
    '   End Set
    'End Property

End Class