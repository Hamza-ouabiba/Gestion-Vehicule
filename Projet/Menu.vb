﻿Public Class Menu
    Public user As String
    Private Declare Sub Sleep Lib "kernel32" (ByVal dwMilliseconds As Long)
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim gestion As New gestion_voiture()
        Me.Hide()
        gestion_voiture.Show()
    End Sub

    Private Sub IconButton1_Click(sender As Object, e As EventArgs) Handles IconButton1.Click
        Dim form1 As New Form1
        Me.Hide()
        Sleep(1000)
        form1.Show()
    End Sub

    Private Sub Menu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MsgBox(Inscription.taille_voiture(gestion_voiture.current_user))
        If Inscription.taille_voiture(gestion_voiture.current_user) > 0 Then
            For i As Integer = 0 To Inscription.taille_voiture(gestion_voiture.current_user) - 1
                With gestion_voiture.ListView1.Items.Add(gestion_voiture.voiture(gestion_voiture.current_user, i).chauffeur)
                    .SubItems.Add(gestion_voiture.voiture(gestion_voiture.current_user, i).immatriculation)
                    .SubItems.Add(Convert.ToInt32(gestion_voiture.voiture(gestion_voiture.current_user, i).nombre_place))
                    .SubItems.Add(gestion_voiture.voiture(gestion_voiture.current_user, i).marque)
                    .SubItems.Add(gestion_voiture.voiture(gestion_voiture.current_user, i).date_entre)
                    .SubItems.Add(gestion_voiture.voiture(gestion_voiture.current_user, i).date_sortie)
                End With
            Next
        End If
        Label2.Text = $"A fen {user}"
    End Sub
End Class