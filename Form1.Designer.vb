<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        txt_ISBN = New TextBox()
        txt_auteur = New TextBox()
        txt_titre = New TextBox()
        btn_ajout = New Button()
        btn_ffich = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(99, 75)
        Label1.Name = "Label1"
        Label1.Size = New Size(41, 20)
        Label1.TabIndex = 0
        Label1.Text = "ISBN"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(99, 226)
        Label2.Name = "Label2"
        Label2.Size = New Size(51, 20)
        Label2.TabIndex = 1
        Label2.Text = "auteur"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(104, 149)
        Label3.Name = "Label3"
        Label3.Size = New Size(36, 20)
        Label3.TabIndex = 2
        Label3.Text = "titre"
        ' 
        ' txt_ISBN
        ' 
        txt_ISBN.Location = New Point(194, 72)
        txt_ISBN.Name = "txt_ISBN"
        txt_ISBN.Size = New Size(125, 27)
        txt_ISBN.TabIndex = 3
        ' 
        ' txt_auteur
        ' 
        txt_auteur.Location = New Point(194, 219)
        txt_auteur.Name = "txt_auteur"
        txt_auteur.Size = New Size(125, 27)
        txt_auteur.TabIndex = 4
        ' 
        ' txt_titre
        ' 
        txt_titre.Location = New Point(194, 149)
        txt_titre.Name = "txt_titre"
        txt_titre.Size = New Size(125, 27)
        txt_titre.TabIndex = 5
        ' 
        ' btn_ajout
        ' 
        btn_ajout.Location = New Point(158, 331)
        btn_ajout.Name = "btn_ajout"
        btn_ajout.Size = New Size(94, 29)
        btn_ajout.TabIndex = 6
        btn_ajout.Text = "ajouter"
        btn_ajout.UseVisualStyleBackColor = True
        ' 
        ' btn_ffich
        ' 
        btn_ffich.Location = New Point(341, 331)
        btn_ffich.Name = "btn_ffich"
        btn_ffich.Size = New Size(94, 29)
        btn_ffich.TabIndex = 7
        btn_ffich.Text = "afficher"
        btn_ffich.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.LightCoral
        ClientSize = New Size(800, 450)
        Controls.Add(btn_ffich)
        Controls.Add(btn_ajout)
        Controls.Add(txt_titre)
        Controls.Add(txt_auteur)
        Controls.Add(txt_ISBN)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txt_ISBN As TextBox
    Friend WithEvents txt_auteur As TextBox
    Friend WithEvents txt_titre As TextBox
    Friend WithEvents btn_ajout As Button
    Friend WithEvents btn_ffich As Button

End Class
