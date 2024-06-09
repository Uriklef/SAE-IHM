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
        Me.LBNoms = New System.Windows.Forms.ListBox()
        Me.LBMeilleursScores = New System.Windows.Forms.ListBox()
        Me.PMenu = New System.Windows.Forms.Panel()
        Me.BJouer = New System.Windows.Forms.Button()
        Me.BLeave = New System.Windows.Forms.Button()
        Me.BRegle = New System.Windows.Forms.Button()
        Me.BLeaderBoard = New System.Windows.Forms.Button()
        Me.BTrierNoms = New System.Windows.Forms.Button()
        Me.PLeaderBoard = New System.Windows.Forms.Panel()
        Me.CBNoms = New System.Windows.Forms.ComboBox()
        Me.BStats = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BTriScore = New System.Windows.Forms.Button()
        Me.BCreateurs = New System.Windows.Forms.Button()
        Me.LCreateurs = New System.Windows.Forms.Label()
        Me.BtnCouperSon = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.LBDifficulte = New System.Windows.Forms.ListBox()
        Me.LScores = New System.Windows.Forms.Label()
        Me.PMenu.SuspendLayout()
        Me.PLeaderBoard.SuspendLayout()
        Me.SuspendLayout()
        '
        'LRegle
        '
        Me.LRegle.BackColor = System.Drawing.Color.Transparent
        Me.LRegle.Cursor = System.Windows.Forms.Cursors.No
        Me.LRegle.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.LRegle.Font = New System.Drawing.Font("Impact", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LRegle.ForeColor = System.Drawing.Color.Snow
        Me.LRegle.Location = New System.Drawing.Point(16, 165)
        Me.LRegle.Name = "LRegle"
        Me.LRegle.Size = New System.Drawing.Size(821, 329)
        Me.LRegle.TabIndex = 3
        Me.LRegle.Text = resources.GetString("LRegle.Text")
        Me.LRegle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LTitre
        '
        Me.LTitre.AutoSize = True
        Me.LTitre.BackColor = System.Drawing.Color.Transparent
        Me.LTitre.Font = New System.Drawing.Font("Showcard Gothic", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LTitre.ForeColor = System.Drawing.Color.Brown
        Me.LTitre.Location = New System.Drawing.Point(227, 15)
        Me.LTitre.Name = "LTitre"
        Me.LTitre.Size = New System.Drawing.Size(368, 98)
        Me.LTitre.TabIndex = 2
        Me.LTitre.Text = "SUDOKU"
        Me.LTitre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BRetour
        '
        Me.BRetour.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BRetour.Location = New System.Drawing.Point(23, 496)
        Me.BRetour.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BRetour.Name = "BRetour"
        Me.BRetour.Size = New System.Drawing.Size(125, 44)
        Me.BRetour.TabIndex = 8
        Me.BRetour.Text = "Retour"
        Me.BRetour.UseVisualStyleBackColor = True
        '
        'LBNoms
        '
        Me.LBNoms.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBNoms.FormattingEnabled = True
        Me.LBNoms.ItemHeight = 20
        Me.LBNoms.Location = New System.Drawing.Point(185, 105)
        Me.LBNoms.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.LBNoms.Name = "LBNoms"
        Me.LBNoms.Size = New System.Drawing.Size(132, 124)
        Me.LBNoms.TabIndex = 11
        '
        'LBMeilleursScores
        '
        Me.LBMeilleursScores.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBMeilleursScores.FormattingEnabled = True
        Me.LBMeilleursScores.ItemHeight = 20
        Me.LBMeilleursScores.Location = New System.Drawing.Point(330, 105)
        Me.LBMeilleursScores.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.LBMeilleursScores.Name = "LBMeilleursScores"
        Me.LBMeilleursScores.Size = New System.Drawing.Size(132, 124)
        Me.LBMeilleursScores.TabIndex = 12
        '
        'PMenu
        '
        Me.PMenu.BackColor = System.Drawing.Color.Transparent
        Me.PMenu.Controls.Add(Me.BJouer)
        Me.PMenu.Controls.Add(Me.BLeave)
        Me.PMenu.Controls.Add(Me.BRegle)
        Me.PMenu.Controls.Add(Me.BLeaderBoard)
        Me.PMenu.Cursor = System.Windows.Forms.Cursors.Default
        Me.PMenu.Location = New System.Drawing.Point(279, 140)
        Me.PMenu.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PMenu.Name = "PMenu"
        Me.PMenu.Size = New System.Drawing.Size(285, 358)
        Me.PMenu.TabIndex = 13
        '
        'BJouer
        '
        Me.BJouer.BackColor = System.Drawing.Color.Snow
        Me.BJouer.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BJouer.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BJouer.Location = New System.Drawing.Point(53, 25)
        Me.BJouer.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BJouer.Name = "BJouer"
        Me.BJouer.Size = New System.Drawing.Size(183, 62)
        Me.BJouer.TabIndex = 4
        Me.BJouer.Text = "Lancer une partie"
        Me.BJouer.UseVisualStyleBackColor = False
        '
        'BLeave
        '
        Me.BLeave.BackColor = System.Drawing.Color.Snow
        Me.BLeave.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BLeave.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BLeave.Location = New System.Drawing.Point(53, 274)
        Me.BLeave.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BLeave.Name = "BLeave"
        Me.BLeave.Size = New System.Drawing.Size(183, 58)
        Me.BLeave.TabIndex = 8
        Me.BLeave.Text = "Quitter"
        Me.BLeave.UseVisualStyleBackColor = False
        '
        'BRegle
        '
        Me.BRegle.BackColor = System.Drawing.Color.Snow
        Me.BRegle.Cursor = System.Windows.Forms.Cursors.Default
        Me.BRegle.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BRegle.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BRegle.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.BRegle.Location = New System.Drawing.Point(53, 192)
        Me.BRegle.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BRegle.Name = "BRegle"
        Me.BRegle.Size = New System.Drawing.Size(183, 58)
        Me.BRegle.TabIndex = 6
        Me.BRegle.Text = "Règles"
        Me.BRegle.UseVisualStyleBackColor = False
        '
        'BLeaderBoard
        '
        Me.BLeaderBoard.BackColor = System.Drawing.Color.Snow
        Me.BLeaderBoard.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BLeaderBoard.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BLeaderBoard.Location = New System.Drawing.Point(53, 108)
        Me.BLeaderBoard.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BLeaderBoard.Name = "BLeaderBoard"
        Me.BLeaderBoard.Size = New System.Drawing.Size(183, 62)
        Me.BLeaderBoard.TabIndex = 5
        Me.BLeaderBoard.Text = "Tableau des scores"
        Me.BLeaderBoard.UseVisualStyleBackColor = False
        '
        'BTrierNoms
        '
        Me.BTrierNoms.Location = New System.Drawing.Point(684, 105)
        Me.BTrierNoms.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BTrierNoms.Name = "BTrierNoms"
        Me.BTrierNoms.Size = New System.Drawing.Size(132, 28)
        Me.BTrierNoms.TabIndex = 14
        Me.BTrierNoms.Text = "Trier par Noms"
        Me.BTrierNoms.UseVisualStyleBackColor = True
        '
        'PLeaderBoard
        '
        Me.PLeaderBoard.BackColor = System.Drawing.Color.Transparent
        Me.PLeaderBoard.Controls.Add(Me.LBDifficulte)
        Me.PLeaderBoard.Controls.Add(Me.CBNoms)
        Me.PLeaderBoard.Controls.Add(Me.BStats)
        Me.PLeaderBoard.Controls.Add(Me.Label1)
        Me.PLeaderBoard.Controls.Add(Me.BTriScore)
        Me.PLeaderBoard.Controls.Add(Me.BTrierNoms)
        Me.PLeaderBoard.Controls.Add(Me.LBMeilleursScores)
        Me.PLeaderBoard.Controls.Add(Me.LBNoms)
        Me.PLeaderBoard.Controls.Add(Me.LScores)
        Me.PLeaderBoard.Location = New System.Drawing.Point(2, 177)
        Me.PLeaderBoard.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PLeaderBoard.Name = "PLeaderBoard"
        Me.PLeaderBoard.Size = New System.Drawing.Size(853, 315)
        Me.PLeaderBoard.TabIndex = 15
        '
        'CBNoms
        '
        Me.CBNoms.FormattingEnabled = True
        Me.CBNoms.Location = New System.Drawing.Point(27, 178)
        Me.CBNoms.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.CBNoms.Name = "CBNoms"
        Me.CBNoms.Size = New System.Drawing.Size(137, 24)
        Me.CBNoms.TabIndex = 18
        '
        'BStats
        '
        Me.BStats.Location = New System.Drawing.Point(686, 185)
        Me.BStats.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BStats.Name = "BStats"
        Me.BStats.Size = New System.Drawing.Size(130, 44)
        Me.BStats.TabIndex = 17
        Me.BStats.Text = "Afficher les Statistiques"
        Me.BStats.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label1.Location = New System.Drawing.Point(3, 147)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(158, 18)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "Rechercher un joueur :"
        '
        'BTriScore
        '
        Me.BTriScore.Location = New System.Drawing.Point(684, 145)
        Me.BTriScore.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BTriScore.Name = "BTriScore"
        Me.BTriScore.Size = New System.Drawing.Size(132, 25)
        Me.BTriScore.TabIndex = 15
        Me.BTriScore.Text = "Trier par Scores"
        Me.BTriScore.UseVisualStyleBackColor = True
        '
        'BCreateurs
        '
        Me.BCreateurs.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BCreateurs.Location = New System.Drawing.Point(792, 12)
        Me.BCreateurs.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BCreateurs.Name = "BCreateurs"
        Me.BCreateurs.Size = New System.Drawing.Size(75, 23)
        Me.BCreateurs.TabIndex = 17
        Me.BCreateurs.Text = "?"
        Me.BCreateurs.UseVisualStyleBackColor = True
        '
        'LCreateurs
        '
        Me.LCreateurs.AutoSize = True
        Me.LCreateurs.BackColor = System.Drawing.SystemColors.Info
        Me.LCreateurs.Location = New System.Drawing.Point(659, 53)
        Me.LCreateurs.Name = "LCreateurs"
        Me.LCreateurs.Size = New System.Drawing.Size(168, 80)
        Me.LCreateurs.TabIndex = 18
        Me.LCreateurs.Text = "Créateurs de l'application : " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & " - Rayan Meri" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & " - Oskar Jakubczyk" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & " - Tony Olivier" &
    "a" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & " - Arnaud Sahat"
        '
        'BtnCouperSon
        '
        Me.BtnCouperSon.BackColor = System.Drawing.Color.Snow
        Me.BtnCouperSon.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnCouperSon.Location = New System.Drawing.Point(16, 15)
        Me.BtnCouperSon.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BtnCouperSon.Name = "BtnCouperSon"
        Me.BtnCouperSon.Size = New System.Drawing.Size(145, 47)
        Me.BtnCouperSon.TabIndex = 19
        Me.BtnCouperSon.Text = "Couper/Remettre Le Son"
        Me.BtnCouperSon.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Panel1.Location = New System.Drawing.Point(23, 165)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(813, 308)
        Me.Panel1.TabIndex = 110
        '
        'LBDifficulte
        '
        Me.LBDifficulte.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBDifficulte.FormattingEnabled = True
        Me.LBDifficulte.ItemHeight = 20
        Me.LBDifficulte.Location = New System.Drawing.Point(478, 105)
        Me.LBDifficulte.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.LBDifficulte.Name = "LBDifficulte"
        Me.LBDifficulte.Size = New System.Drawing.Size(171, 124)
        Me.LBDifficulte.TabIndex = 19
        '
        'LScores
        '
        Me.LScores.AutoSize = True
        Me.LScores.Cursor = System.Windows.Forms.Cursors.Default
        Me.LScores.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LScores.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.LScores.Location = New System.Drawing.Point(164, 7)
        Me.LScores.Name = "LScores"
        Me.LScores.Size = New System.Drawing.Size(0, 31)
        Me.LScores.TabIndex = 9
        Me.LScores.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.BackgroundImage = Global.SAE_IHM.My.Resources.Resources.fond
        Me.ClientSize = New System.Drawing.Size(857, 559)
        Me.Controls.Add(Me.BtnCouperSon)
        Me.Controls.Add(Me.LCreateurs)
        Me.Controls.Add(Me.BCreateurs)
        Me.Controls.Add(Me.PLeaderBoard)
        Me.Controls.Add(Me.PMenu)
        Me.Controls.Add(Me.BRetour)
        Me.Controls.Add(Me.LTitre)
        Me.Controls.Add(Me.LRegle)
        Me.Controls.Add(Me.Panel1)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "Form1"
        Me.Text = "à"
        Me.PMenu.ResumeLayout(False)
        Me.PLeaderBoard.ResumeLayout(False)
        Me.PLeaderBoard.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LRegle As Label
    Friend WithEvents LTitre As Label
    Friend WithEvents BRetour As Button
    Friend WithEvents LBNoms As ListBox
    Friend WithEvents LBMeilleursScores As ListBox
    Friend WithEvents PMenu As Panel
    Friend WithEvents BLeave As Button
    Friend WithEvents BRegle As Button
    Friend WithEvents BLeaderBoard As Button
    Friend WithEvents BJouer As Button
    Friend WithEvents BTrierNoms As Button
    Friend WithEvents PLeaderBoard As Panel
    Friend WithEvents BTriScore As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents BStats As Button
    Friend WithEvents CBNoms As ComboBox
    Friend WithEvents BCreateurs As Button
    Friend WithEvents LCreateurs As Label
    Friend WithEvents BtnCouperSon As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents LBDifficulte As ListBox
    Friend WithEvents LScores As Label
End Class
