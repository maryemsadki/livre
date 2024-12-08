<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_afficher2
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        dgv_livre = New DataGridView()
        ISBN = New DataGridViewTextBoxColumn()
        titre = New DataGridViewTextBoxColumn()
        auteur = New DataGridViewTextBoxColumn()
        CType(dgv_livre, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' dgv_livre
        ' 
        dgv_livre.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgv_livre.Columns.AddRange(New DataGridViewColumn() {ISBN, titre, auteur})
        dgv_livre.Location = New Point(248, 100)
        dgv_livre.Name = "dgv_livre"
        dgv_livre.RowHeadersWidth = 51
        dgv_livre.Size = New Size(427, 188)
        dgv_livre.TabIndex = 0
        ' 
        ' ISBN
        ' 
        ISBN.HeaderText = "ISBN"
        ISBN.MinimumWidth = 6
        ISBN.Name = "ISBN"
        ISBN.Width = 125
        ' 
        ' titre
        ' 
        titre.HeaderText = "titre"
        titre.MinimumWidth = 6
        titre.Name = "titre"
        titre.Width = 125
        ' 
        ' auteur
        ' 
        auteur.HeaderText = "auteur"
        auteur.MinimumWidth = 6
        auteur.Name = "auteur"
        auteur.Width = 125
        ' 
        ' Form_afficher2
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(dgv_livre)
        Name = "Form_afficher2"
        Text = "Form_afficher2"
        CType(dgv_livre, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents dgv_livre As DataGridView
    Friend WithEvents ISBN As DataGridViewTextBoxColumn
    Friend WithEvents titre As DataGridViewTextBoxColumn
    Friend WithEvents auteur As DataGridViewTextBoxColumn
End Class
