<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
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

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.LRegle = New System.Windows.Forms.Label()
        Me.LTitre = New System.Windows.Forms.Label()
        Me.BRetour = New System.Windows.Forms.Button()
        Me.LScores = New System.Windows.Forms.Label()
        Me.LBNoms = New System.Windows.Forms.ListBox()
        Me.LBMeilleursScores = New System.Windows.Forms.ListBox()
        Me.PMenu = New System.Windows.Forms.Panel()
        Me.BLeave = New System.Windows.Forms.Button()
        Me.BRegle = New System.Windows.Forms.Button()
        Me.BLeaderBoard = New System.Windows.Forms.Button()
        Me.BJouer = New System.Windows.Forms.Button()
        Me.BTrierNoms = New System.Windows.Forms.Button()
        Me.PLeaderBoard = New System.Windows.Forms.Panel()
        Me.PMenu.SuspendLayout()
        Me.PLeaderBoard.SuspendLayout()
        Me.SuspendLayout()
        '
        'LRegle
        '
        Me.LRegle.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LRegle.Location = New System.Drawing.Point(62, 198)
        Me.LRegle.Name = "LRegle"
        Me.LRegle.Size = New System.Drawing.Size(800, 199)
        Me.LRegle.TabIndex = 3
        Me.LRegle.Text = resources.GetString("LRegle.Text")
        '
        'LTitre
        '
        Me.LTitre.AutoSize = True
        Me.LTitre.Font = New System.Drawing.Font("Papyrus", 28.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LTitre.Location = New System.Drawing.Point(277, 60)
        Me.LTitre.Name = "LTitre"
        Me.LTitre.Size = New System.Drawing.Size(321, 74)
        Me.LTitre.TabIndex = 2
        Me.LTitre.Text = "SUDOKU"
        Me.LTitre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BRetour
        '
        Me.BRetour.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BRetour.Location = New System.Drawing.Point(57, 503)
        Me.BRetour.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BRetour.Name = "BRetour"
        Me.BRetour.Size = New System.Drawing.Size(125, 44)
        Me.BRetour.TabIndex = 8
        Me.BRetour.Text = "Retour"
        Me.BRetour.UseVisualStyleBackColor = True
        '
        'LScores
        '
        Me.LScores.AutoSize = True
        Me.LScores.Cursor = System.Windows.Forms.Cursors.Default
        Me.LScores.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LScores.Location = New System.Drawing.Point(197, 16)
        Me.LScores.Name = "LScores"
        Me.LScores.Size = New System.Drawing.Size(309, 58)
        Me.LScores.TabIndex = 9
        Me.LScores.Text = "Joueurs         |         Temps" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "-------------------------------------" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.LScores.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'LBNoms
        '
        Me.LBNoms.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBNoms.FormattingEnabled = True
        Me.LBNoms.ItemHeight = 20
        Me.LBNoms.Location = New System.Drawing.Point(202, 103)
        Me.LBNoms.Name = "LBNoms"
        Me.LBNoms.Size = New System.Drawing.Size(132, 124)
        Me.LBNoms.TabIndex = 11
        '
        'LBMeilleursScores
        '
        Me.LBMeilleursScores.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBMeilleursScores.FormattingEnabled = True
        Me.LBMeilleursScores.ItemHeight = 20
        Me.LBMeilleursScores.Location = New System.Drawing.Point(374, 103)
        Me.LBMeilleursScores.Name = "LBMeilleursScores"
        Me.LBMeilleursScores.Size = New System.Drawing.Size(132, 124)
        Me.LBMeilleursScores.TabIndex = 12
        '
        'PMenu
        '
        Me.PMenu.BackColor = System.Drawing.Color.Transparent
        Me.PMenu.Controls.Add(Me.BLeave)
        Me.PMenu.Controls.Add(Me.BRegle)
        Me.PMenu.Controls.Add(Me.BLeaderBoard)
        Me.PMenu.Controls.Add(Me.BJouer)
        Me.PMenu.Cursor = System.Windows.Forms.Cursors.Default
        Me.PMenu.Location = New System.Drawing.Point(313, 148)
        Me.PMenu.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PMenu.Name = "PMenu"
        Me.PMenu.Size = New System.Drawing.Size(285, 327)
        Me.PMenu.TabIndex = 13
        '
        'BLeave
        '
        Me.BLeave.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BLeave.Location = New System.Drawing.Point(53, 254)
        Me.BLeave.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BLeave.Name = "BLeave"
        Me.BLeave.Size = New System.Drawing.Size(183, 58)
        Me.BLeave.TabIndex = 8
        Me.BLeave.Text = "Quitter"
        Me.BLeave.UseVisualStyleBackColor = True
        '
        'BRegle
        '
        Me.BRegle.Cursor = System.Windows.Forms.Cursors.Default
        Me.BRegle.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BRegle.Location = New System.Drawing.Point(53, 176)
        Me.BRegle.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BRegle.Name = "BRegle"
        Me.BRegle.Size = New System.Drawing.Size(183, 58)
        Me.BRegle.TabIndex = 6
        Me.BRegle.Text = "Règles"
        Me.BRegle.UseVisualStyleBackColor = True
        '
        'BLeaderBoard
        '
        Me.BLeaderBoard.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BLeaderBoard.Location = New System.Drawing.Point(53, 91)
        Me.BLeaderBoard.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BLeaderBoard.Name = "BLeaderBoard"
        Me.BLeaderBoard.Size = New System.Drawing.Size(183, 62)
        Me.BLeaderBoard.TabIndex = 5
        Me.BLeaderBoard.Text = "Tableau des scores"
        Me.BLeaderBoard.UseVisualStyleBackColor = True
        '
        'BJouer
        '
        Me.BJouer.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BJouer.Location = New System.Drawing.Point(53, 14)
        Me.BJouer.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BJouer.Name = "BJouer"
        Me.BJouer.Size = New System.Drawing.Size(183, 52)
        Me.BJouer.TabIndex = 4
        Me.BJouer.Text = "Lancer une partie"
        Me.BJouer.UseVisualStyleBackColor = True
        '
        'BTrierNoms
        '
        Me.BTrierNoms.Location = New System.Drawing.Point(558, 112)
        Me.BTrierNoms.Name = "BTrierNoms"
        Me.BTrierNoms.Size = New System.Drawing.Size(139, 28)
        Me.BTrierNoms.TabIndex = 14
        Me.BTrierNoms.Text = "Trier par Noms"
        Me.BTrierNoms.UseVisualStyleBackColor = True
        '
        'PLeaderBoard
        '
        Me.PLeaderBoard.Controls.Add(Me.BTrierNoms)
        Me.PLeaderBoard.Controls.Add(Me.LBMeilleursScores)
        Me.PLeaderBoard.Controls.Add(Me.LBNoms)
        Me.PLeaderBoard.Controls.Add(Me.LScores)
        Me.PLeaderBoard.Location = New System.Drawing.Point(92, 164)
        Me.PLeaderBoard.Name = "PLeaderBoard"
        Me.PLeaderBoard.Size = New System.Drawing.Size(727, 270)
        Me.PLeaderBoard.TabIndex = 15
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(919, 559)
        Me.Controls.Add(Me.PLeaderBoard)
        Me.Controls.Add(Me.PMenu)
        Me.Controls.Add(Me.BRetour)
        Me.Controls.Add(Me.LRegle)
        Me.Controls.Add(Me.LTitre)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.PMenu.ResumeLayout(False)
        Me.PLeaderBoard.ResumeLayout(False)
        Me.PLeaderBoard.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LRegle As Label
    Friend WithEvents LTitre As Label
    Friend WithEvents BRetour As Button
    Friend WithEvents LScores As Label
    Friend WithEvents LBNoms As ListBox
    Friend WithEvents LBMeilleursScores As ListBox
    Friend WithEvents PMenu As Panel
    Friend WithEvents BLeave As Button
    Friend WithEvents BRegle As Button
    Friend WithEvents BLeaderBoard As Button
    Friend WithEvents BJouer As Button
    Friend WithEvents BTrierNoms As Button
    Friend WithEvents PLeaderBoard As Panel
End Class
