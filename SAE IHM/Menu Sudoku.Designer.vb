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
        Me.CBNoms = New System.Windows.Forms.ComboBox()
        Me.BStats = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BTriScore = New System.Windows.Forms.Button()
        Me.BCreateurs = New System.Windows.Forms.Button()
        Me.LCreateurs = New System.Windows.Forms.Label()
        Me.PMenu.SuspendLayout()
        Me.PLeaderBoard.SuspendLayout()
        Me.SuspendLayout()
        '
        'LRegle
        '
        Me.LRegle.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LRegle.Location = New System.Drawing.Point(20, 155)
        Me.LRegle.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LRegle.Name = "LRegle"
        Me.LRegle.Size = New System.Drawing.Size(600, 162)
        Me.LRegle.TabIndex = 3
        Me.LRegle.Text = resources.GetString("LRegle.Text")
        Me.LRegle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LTitre
        '
        Me.LTitre.AutoSize = True
        Me.LTitre.Font = New System.Drawing.Font("Papyrus", 28.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LTitre.Location = New System.Drawing.Point(182, 43)
        Me.LTitre.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LTitre.Name = "LTitre"
        Me.LTitre.Size = New System.Drawing.Size(259, 60)
        Me.LTitre.TabIndex = 2
        Me.LTitre.Text = "SUDOKU"
        Me.LTitre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BRetour
        '
        Me.BRetour.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BRetour.Location = New System.Drawing.Point(17, 403)
        Me.BRetour.Margin = New System.Windows.Forms.Padding(2)
        Me.BRetour.Name = "BRetour"
        Me.BRetour.Size = New System.Drawing.Size(94, 36)
        Me.BRetour.TabIndex = 8
        Me.BRetour.Text = "Retour"
        Me.BRetour.UseVisualStyleBackColor = True
        '
        'LScores
        '
        Me.LScores.AutoSize = True
        Me.LScores.Cursor = System.Windows.Forms.Cursors.Default
        Me.LScores.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LScores.Location = New System.Drawing.Point(148, 13)
        Me.LScores.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LScores.Name = "LScores"
        Me.LScores.Size = New System.Drawing.Size(232, 48)
        Me.LScores.TabIndex = 9
        Me.LScores.Text = "Joueurs         |         Temps" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "-------------------------------------" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.LScores.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'LBNoms
        '
        Me.LBNoms.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBNoms.FormattingEnabled = True
        Me.LBNoms.ItemHeight = 17
        Me.LBNoms.Location = New System.Drawing.Point(152, 84)
        Me.LBNoms.Margin = New System.Windows.Forms.Padding(2)
        Me.LBNoms.Name = "LBNoms"
        Me.LBNoms.Size = New System.Drawing.Size(100, 106)
        Me.LBNoms.TabIndex = 11
        '
        'LBMeilleursScores
        '
        Me.LBMeilleursScores.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBMeilleursScores.FormattingEnabled = True
        Me.LBMeilleursScores.ItemHeight = 17
        Me.LBMeilleursScores.Location = New System.Drawing.Point(280, 84)
        Me.LBMeilleursScores.Margin = New System.Windows.Forms.Padding(2)
        Me.LBMeilleursScores.Name = "LBMeilleursScores"
        Me.LBMeilleursScores.Size = New System.Drawing.Size(100, 106)
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
        Me.PMenu.Location = New System.Drawing.Point(209, 114)
        Me.PMenu.Margin = New System.Windows.Forms.Padding(2)
        Me.PMenu.Name = "PMenu"
        Me.PMenu.Size = New System.Drawing.Size(214, 266)
        Me.PMenu.TabIndex = 13
        '
        'BLeave
        '
        Me.BLeave.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BLeave.Location = New System.Drawing.Point(40, 206)
        Me.BLeave.Margin = New System.Windows.Forms.Padding(2)
        Me.BLeave.Name = "BLeave"
        Me.BLeave.Size = New System.Drawing.Size(137, 47)
        Me.BLeave.TabIndex = 8
        Me.BLeave.Text = "Quitter"
        Me.BLeave.UseVisualStyleBackColor = True
        '
        'BRegle
        '
        Me.BRegle.Cursor = System.Windows.Forms.Cursors.Default
        Me.BRegle.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BRegle.Location = New System.Drawing.Point(40, 143)
        Me.BRegle.Margin = New System.Windows.Forms.Padding(2)
        Me.BRegle.Name = "BRegle"
        Me.BRegle.Size = New System.Drawing.Size(137, 47)
        Me.BRegle.TabIndex = 6
        Me.BRegle.Text = "Règles"
        Me.BRegle.UseVisualStyleBackColor = True
        '
        'BLeaderBoard
        '
        Me.BLeaderBoard.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BLeaderBoard.Location = New System.Drawing.Point(40, 74)
        Me.BLeaderBoard.Margin = New System.Windows.Forms.Padding(2)
        Me.BLeaderBoard.Name = "BLeaderBoard"
        Me.BLeaderBoard.Size = New System.Drawing.Size(137, 50)
        Me.BLeaderBoard.TabIndex = 5
        Me.BLeaderBoard.Text = "Tableau des scores"
        Me.BLeaderBoard.UseVisualStyleBackColor = True
        '
        'BJouer
        '
        Me.BJouer.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BJouer.Location = New System.Drawing.Point(40, 11)
        Me.BJouer.Margin = New System.Windows.Forms.Padding(2)
        Me.BJouer.Name = "BJouer"
        Me.BJouer.Size = New System.Drawing.Size(137, 42)
        Me.BJouer.TabIndex = 4
        Me.BJouer.Text = "Lancer une partie"
        Me.BJouer.UseVisualStyleBackColor = True
        '
        'BTrierNoms
        '
        Me.BTrierNoms.Location = New System.Drawing.Point(418, 84)
        Me.BTrierNoms.Margin = New System.Windows.Forms.Padding(2)
        Me.BTrierNoms.Name = "BTrierNoms"
        Me.BTrierNoms.Size = New System.Drawing.Size(104, 23)
        Me.BTrierNoms.TabIndex = 14
        Me.BTrierNoms.Text = "Trier par Noms"
        Me.BTrierNoms.UseVisualStyleBackColor = True
        '
        'PLeaderBoard
        '
        Me.PLeaderBoard.Controls.Add(Me.CBNoms)
        Me.PLeaderBoard.Controls.Add(Me.BStats)
        Me.PLeaderBoard.Controls.Add(Me.Label1)
        Me.PLeaderBoard.Controls.Add(Me.BTriScore)
        Me.PLeaderBoard.Controls.Add(Me.BTrierNoms)
        Me.PLeaderBoard.Controls.Add(Me.LBMeilleursScores)
        Me.PLeaderBoard.Controls.Add(Me.LBNoms)
        Me.PLeaderBoard.Controls.Add(Me.LScores)
        Me.PLeaderBoard.Location = New System.Drawing.Point(54, 125)
        Me.PLeaderBoard.Margin = New System.Windows.Forms.Padding(2)
        Me.PLeaderBoard.Name = "PLeaderBoard"
        Me.PLeaderBoard.Size = New System.Drawing.Size(545, 219)
        Me.PLeaderBoard.TabIndex = 15
        '
        'CBNoms
        '
        Me.CBNoms.FormattingEnabled = True
        Me.CBNoms.Location = New System.Drawing.Point(20, 145)
        Me.CBNoms.Margin = New System.Windows.Forms.Padding(2)
        Me.CBNoms.Name = "CBNoms"
        Me.CBNoms.Size = New System.Drawing.Size(104, 21)
        Me.CBNoms.TabIndex = 18
        '
        'BStats
        '
        Me.BStats.Location = New System.Drawing.Point(418, 169)
        Me.BStats.Margin = New System.Windows.Forms.Padding(2)
        Me.BStats.Name = "BStats"
        Me.BStats.Size = New System.Drawing.Size(104, 36)
        Me.BStats.TabIndex = 17
        Me.BStats.Text = "Afficher les Statistiques"
        Me.BStats.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(20, 106)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(116, 13)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "Rechercher un joueur :"
        '
        'BTriScore
        '
        Me.BTriScore.Location = New System.Drawing.Point(418, 130)
        Me.BTriScore.Margin = New System.Windows.Forms.Padding(2)
        Me.BTriScore.Name = "BTriScore"
        Me.BTriScore.Size = New System.Drawing.Size(104, 20)
        Me.BTriScore.TabIndex = 15
        Me.BTriScore.Text = "Trier par Scores"
        Me.BTriScore.UseVisualStyleBackColor = True
        '
        'BCreateurs
        '
        Me.BCreateurs.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BCreateurs.Location = New System.Drawing.Point(594, 10)
        Me.BCreateurs.Margin = New System.Windows.Forms.Padding(2)
        Me.BCreateurs.Name = "BCreateurs"
        Me.BCreateurs.Size = New System.Drawing.Size(56, 19)
        Me.BCreateurs.TabIndex = 17
        Me.BCreateurs.Text = "?"
        Me.BCreateurs.UseVisualStyleBackColor = True
        '
        'LCreateurs
        '
        Me.LCreateurs.AutoSize = True
        Me.LCreateurs.BackColor = System.Drawing.SystemColors.Info
        Me.LCreateurs.Location = New System.Drawing.Point(494, 43)
        Me.LCreateurs.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LCreateurs.Name = "LCreateurs"
        Me.LCreateurs.Size = New System.Drawing.Size(134, 65)
        Me.LCreateurs.TabIndex = 18
        Me.LCreateurs.Text = "Créateurs de l'application : " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & " - Rayan Meri" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & " - Oskar Jakubczyk" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & " - Tony Olivier" &
    "a" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & " - Arnaud Sahat"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(643, 454)
        Me.Controls.Add(Me.LCreateurs)
        Me.Controls.Add(Me.BCreateurs)
        Me.Controls.Add(Me.PLeaderBoard)
        Me.Controls.Add(Me.PMenu)
        Me.Controls.Add(Me.BRetour)
        Me.Controls.Add(Me.LRegle)
        Me.Controls.Add(Me.LTitre)
        Me.Margin = New System.Windows.Forms.Padding(2)
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
    Friend WithEvents BTriScore As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents BStats As Button
    Friend WithEvents CBNoms As ComboBox
    Friend WithEvents BCreateurs As Button
    Friend WithEvents LCreateurs As Label
End Class
