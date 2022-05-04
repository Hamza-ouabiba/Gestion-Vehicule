'Création de la classe Voiture : 
Public Class Voiture
    Public chauffeur As String
    Public immatriculation As String
    Public nombre_place As Integer
    Public marque As String
    Public date_entre As String
    Public date_sortie As String
    Public Sub New(chauffeur As String, immatriculation As String, nombre_place As String, marque As String, date_entre As String, date_sortie As String)
        Me.chauffeur = chauffeur
        Me.immatriculation = immatriculation
        Me.nombre_place = nombre_place
        Me.marque = marque
        Me.date_entre = date_entre
        Me.date_sortie = date_sortie
    End Sub
End Class
