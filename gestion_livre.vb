Module gestion_livre
    Public Structure livre
        Dim ISBN As Integer
        Dim titre As String
        Dim auteur As String
    End Structure
    Public bibliotheque(100) As livre
    Dim nb As Integer = 0
    Function ajoutLivre(l As livre) As Boolean
        If nb < bibliotheque.Length Then
            bibliotheque(nb) = l
            nb += 1
            Return True
        Else
            Return False
        End If
    End Function

    Private Sub Afficher3_livre(l1 As ListBox, l2 As ListBox, l3 As ListBox)
        For Each livre As livre In bibliotheque
            l1.Items.Add(livre.ISBN)
            l2.Items.Add(livre.titre)
            l3.Items.Add(livre.auteur)
        Next
    End Sub
    Sub afficher_livre(l1 As ListBox, l2 As ListBox, l3 As ListBox)
        For i As Integer = 0 To nb - 1
            l1.Items.Add(bibliotheque(i).ISBN)
            l2.Items.Add(bibliotheque(i).titre)
            l3.Items.Add(bibliotheque(i).auteur)


        Next
    End Sub
    Sub afficher2_livre(dgv_livre As DataGridView)
        For i As Integer = 0 To nb - 1
            Dim livre As livre = bibliotheque(i)
            dgv_livre.Rows.Add(livre.ISBN, livre.titre, livre.auteur)

        Next
    End Sub
End Module
