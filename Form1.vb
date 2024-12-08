Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btn_ajout_Click(sender As Object, e As EventArgs) Handles btn_ajout.Click
        Dim l As livre
        l.ISBN = txt_ISBN.Text
        If Not IsNumeric(l.ISBN) Then
            MessageBox.Show("Erreur le champ de ISBN doit etre numérique ")
        End If
        l.titre = txt_titre.Text
        If l.titre = "" Then
            MessageBox.Show("Erreur le champ de titre est vide ")
        ElseIf IsNumeric(l.titre) Then
            MessageBox.Show("Erreur le champ de titre doit etre alphabétique ")
        End If
        l.auteur = txt_auteur.Text
        If l.auteur = "" Then
            MessageBox.Show("Erreur le champ de auteur est vide ")
        ElseIf IsNumeric(l.titre) Then
            MessageBox.Show("Erreur le champ de auteur doit etre alphabétique ")
        End If
        If ajoutLivre(l) Then
            MessageBox.Show("ajout de livre avec succés")
        Else
            MessageBox.Show("le tableau bibliotheque est saturé")
        End If
    End Sub

    Private Sub btn_ffich_Click(sender As Object, e As EventArgs) Handles btn_ffich.Click
        Form2.Show()
        Form_afficher2.Show()
    End Sub
End Class
