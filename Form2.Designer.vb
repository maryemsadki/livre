<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        ListBox_isbn = New ListBox()
        ListBox_titre = New ListBox()
        ListBox_auteur = New ListBox()
        btn_ajt = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(159, 65)
        Label1.Name = "Label1"
        Label1.Size = New Size(41, 20)
        Label1.TabIndex = 0
        Label1.Text = "ISBN"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(424, 69)
        Label2.Name = "Label2"
        Label2.Size = New Size(39, 20)
        Label2.TabIndex = 1
        Label2.Text = "Titre"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(704, 69)
        Label3.Name = "Label3"
        Label3.Size = New Size(53, 20)
        Label3.TabIndex = 2
        Label3.Text = "Auteur"
        ' 
        ' ListBox_isbn
        ' 
        ListBox_isbn.FormattingEnabled = True
        ListBox_isbn.Location = New Point(109, 107)
        ListBox_isbn.Name = "ListBox_isbn"
        ListBox_isbn.Size = New Size(167, 224)
        ListBox_isbn.TabIndex = 3
        ' 
        ' ListBox_titre
        ' 
        ListBox_titre.FormattingEnabled = True
        ListBox_titre.Location = New Point(377, 113)
        ListBox_titre.Name = "ListBox_titre"
        ListBox_titre.Size = New Size(167, 224)
        ListBox_titre.TabIndex = 4
        ' 
        ' ListBox_auteur
        ' 
        ListBox_auteur.FormattingEnabled = True
        ListBox_auteur.Location = New Point(664, 113)
        ListBox_auteur.Name = "ListBox_auteur"
        ListBox_auteur.Size = New Size(167, 224)
        ListBox_auteur.TabIndex = 5
        ' 
        ' btn_ajt
        ' 
        btn_ajt.Location = New Point(649, 376)
        btn_ajt.Name = "btn_ajt"
        btn_ajt.Size = New Size(94, 29)
        btn_ajt.TabIndex = 6
        btn_ajt.Text = "Ajouter"
        btn_ajt.UseVisualStyleBackColor = True
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.RosyBrown
        ClientSize = New Size(920, 450)
        Controls.Add(btn_ajt)
        Controls.Add(ListBox_auteur)
        Controls.Add(ListBox_titre)
        Controls.Add(ListBox_isbn)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "Form2"
        Text = "Form2"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents ListBox_isbn As ListBox
    Friend WithEvents ListBox_titre As ListBox
    Friend WithEvents ListBox_auteur As ListBox
    Friend WithEvents btn_ajt As Button
End Class
