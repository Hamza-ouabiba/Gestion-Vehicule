Public Class Camion
    Public chauffeur As String
    Public immatriculation As String
    Public tonnage As Integer
    Public marque As String
    Public date_entre As String
    Public date_sortie As String
    Public Sub New(chauffeur As String, immatriculation As String, tonnage As String, marque As String, date_entre As String, date_sortie As String)
        Me.chauffeur = chauffeur
        Me.immatriculation = immatriculation
        Me.tonnage = tonnage
        Me.marque = marque
        Me.date_entre = date_entre
        Me.date_sortie = date_sortie
    End Sub
End Class
