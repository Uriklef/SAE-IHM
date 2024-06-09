Public Class Form2
    Dim tempsMax As Integer
    Dim partieActive As Boolean
    Dim currentJoueur As String
    Dim nbErreursPossibles As Integer = 3
    Dim nbIndicesPossibles As Integer = 3
    Dim grille As Integer(,)
    Private modeIndice As Boolean = False
    Private casesAafficher As Integer

    Public Sub SetGameSettings(time As Integer)
        tempsMax = time
    End Sub

    Public Sub SetCasesAafficher(cases As Integer)
        casesAafficher = cases
    End Sub

    Public Class FormAvecTransparence
        Inherits Form
        Protected Overrides ReadOnly Property CreateParams As CreateParams
            Get
                Dim cp As CreateParams = MyBase.CreateParams
                cp.ExStyle = cp.ExStyle Or &H20 ' Ajouter le style WS_EX_TRANSPARENT
                Return cp
            End Get
        End Property
    End Class

    Private Sub Timer_Tick(sender As Object, e As EventArgs) Handles Timer.Tick
        If tempsMax > 0 Then
            tempsMax -= 1
            ActualisationLabel()
        Else
            Timer.Stop()
            MessageBox.Show("Le temps est écoulé!")
            For i As Integer = 0 To 8
                For j As Integer = 0 To 8
                    Dim tb As TextBox = GetTextBox(i, j)
                    If tb IsNot Nothing Then
                        tb.BackColor = Color.White
                    End If
                Next
            Next
            TableLayoutPanelQuadrillage.Enabled = False
            BtnTerminer.Enabled = False
            BtnIndice.Hide()
            lblNbFoisIndice.Hide()
            BtnPause.Hide()
            ColorierRegions()
        End If
    End Sub

    Private Sub BtnNouvellePartie_Click(sender As Object, e As EventArgs) Handles BtnCommencer.Click
        LancerPartie()
        BtnCommencer.Hide()
    End Sub

    Private Sub LancerPartie()
        currentJoueur = InputBox("Saisissez votre nom", vbOKCancel)
        If currentJoueur = "" Then
            MsgBox("Vous avez cliqué sur Annuler ou n'avez rien saisi.", vbExclamation, "Annulation")
            partieActive = False
        Else
            partieActive = True
            BtnTerminer.Enabled = True
            BtnIndice.Enabled = True
            BtnQuitter.Enabled = False
            BtnAbandonner.Show()
            BtnQuitter.Hide()
            BtnPause.Show()
            BtnAbandonner.Enabled = True
            Timer.Start()
            ActualisationLabel()
            AfficherSudoku(grille, 117)
            TableLayoutPanelQuadrillage.Enabled = True
        End If
    End Sub

    Private Sub ActualisationLabel()
        Dim minutes As Integer = tempsMax \ 60
        Dim secondes As Integer = tempsMax Mod 60
        labelMinuteur.Text = String.Format("{0:00}:{1:00}", minutes, secondes)

        lblNbErreursRestantes.Text = String.Format("{0}", nbErreursPossibles)

        lblNbFoisIndice.Text = String.Format("X{0}", nbIndicesPossibles)
    End Sub

    Private Sub Jeu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer.Interval = 1000
        ActualisationLabel()

        BtnTerminer.Enabled = False
        BtnTerminer.Hide()

        If partieActive = False Then
            BtnPause.Hide()
        End If

        For ligne As Integer = 0 To 8
            For colonne As Integer = 0 To 8
                Dim textbox As New TextBox With {
                .BackColor = Color.White,
                .Dock = DockStyle.Fill,
                .BorderStyle = BorderStyle.None,
                .Multiline = True,
                .TextAlign = HorizontalAlignment.Center,
                .MaxLength = 1,
                .Font = New Font("FontFamily", 25)
            }
                TableLayoutPanelQuadrillage.Controls.Add(textbox, colonne, ligne)
                AddHandler textbox.KeyPress, AddressOf TextBox_KeyPress
                AddHandler textbox.MouseClick, AddressOf TextBox_Click
            Next
        Next
        grille = GenerateSudoku()
        ColorierRegions()

        Dim nouvelleOpacite As Double = 0.6 ' Opacité à 70%
        Panel1.BackColor = Color.FromArgb(CInt(nouvelleOpacite * 255), Panel1.BackColor.R, Panel1.BackColor.G, Panel1.BackColor.B)
    End Sub


    Private Sub BtnQuitter_Click(sender As Object, e As EventArgs) Handles BtnAbandonner.Click
        Dim resultat As MsgBoxResult = MsgBox("Voulez vous vraiment abandonner ?", vbYesNo)
        If resultat = MsgBoxResult.Yes Then
            If MsgBox("Voulez vous voir la solution ?", vbYesNo) = vbYes Then
                MontrerSolution()
                ReinitialiserPartie()
                BtnAbandonner.Hide()
                BtnIndice.Hide()
                BtnQuitter.Show()
                lblNbFoisIndice.Hide()
                BtnPause.Hide()
                BtnQuitter.Enabled = True
            Else
                Me.Close()
                Form1.Show()
            End If
        End If
    End Sub

    Private Sub MontrerSolution()
        For i As Integer = 0 To 8
            For j As Integer = 0 To 8
                Dim tb As TextBox = GetTextBox(i, j)
                If tb.Text = "" Then
                    tb.Text = grille(i, j)
                End If
            Next
        Next
    End Sub

    Private Sub TextBox_KeyPress(sender As Object, e As KeyPressEventArgs)
        If Not sender.ReadOnly Then
            If Not Char.IsDigit(e.KeyChar) AndAlso e.KeyChar <> vbBack Then
                e.Handled = True
            ElseIf Char.IsDigit(e.KeyChar) Then
                Dim textBox As TextBox = DirectCast(sender, TextBox)
                Dim position As TableLayoutPanelCellPosition = TableLayoutPanelQuadrillage.GetPositionFromControl(textBox)
                Dim ligne As Integer = position.Row
                Dim colonne As Integer = position.Column

                ' Vérifiez si la réponse est correcte
                If grille(ligne, colonne).ToString() = e.KeyChar.ToString() Then
                    textBox.BackColor = Color.LightGreen
                    textBox.Text = e.KeyChar
                    textBox.ReadOnly = True
                    RemoveHandler textBox.KeyPress, AddressOf TextBox_KeyPress
                Else
                    textBox.BackColor = Color.Red
                    nbErreursPossibles -= 1
                End If

                ' Vérifiez si le nombre maximum d'erreurs est atteint
                If nbErreursPossibles = 0 Then
                    MsgBox("Tu as fais trop d'erreurs, la partie est perdue")
                    ReinitialiserPartie()
                End If

                ' Vérifiez si la grille est complète
                If grilleComplete() Then
                    BtnTerminer.Show()
                Else
                    BtnTerminer.Hide()
                End If
            End If
        End If
    End Sub

    Private Function grilleComplete() As Boolean
        For i As Integer = 0 To 8
            For j As Integer = 0 To 8
                Dim tb As TextBox = GetTextBox(i, j)
                If GetTextBox(i, j).Text = "" Then
                    Return False
                End If
            Next
        Next
        Return True
    End Function


    Private Sub BtnIndice_Click(sender As Object, e As EventArgs) Handles BtnIndice.Click
        If Not partieActive Then
            MessageBox.Show("Il faut lancer une partie pour avoir accès à un indice")
            Return
        End If

        If nbIndicesPossibles = 0 Then
            MessageBox.Show("Vous avez épuisé tous vos indices")
            BtnIndice.Enabled = False
            lblNbFoisIndice.Enabled = False
            Return
        End If

        modeIndice = True

        ' Désactiver l'édition des TextBox
        For i As Integer = 0 To 8
            For j As Integer = 0 To 8
                Dim tb As TextBox = GetTextBox(i, j)
                If tb IsNot Nothing Then
                    tb.ReadOnly = True
                End If
            Next
        Next

        MessageBox.Show("Mode indice activé. Cliquez sur une case vide pour afficher un indice.")
        nbIndicesPossibles = nbIndicesPossibles - 1
    End Sub

    Private Sub ReinitialiserPartie()
        For i As Integer = 0 To 8
            For j As Integer = 0 To 8
                Dim tb As TextBox = GetTextBox(i, j)
                If tb IsNot Nothing Then
                    tb.BackColor = Color.White
                End If
            Next
        Next
        TableLayoutPanelQuadrillage.Enabled = False
        BtnTerminer.Enabled = False
        BtnIndice.Hide()
        lblNbFoisIndice.Hide()
        BtnPause.Hide()
        Timer.Stop()
        ColorierRegions()
    End Sub

    Private Sub TextBox_Click(sender As Object, e As MouseEventArgs)
        Dim textBox As TextBox = DirectCast(sender, TextBox)

        ' Si la TextBox est rouge ou verte, ne rien faire
        If textBox.BackColor = Color.Red OrElse textBox.BackColor = Color.LightGreen Then
            Return
        End If

        Dim position As TableLayoutPanelCellPosition = TableLayoutPanelQuadrillage.GetPositionFromControl(textBox)
        Dim ligne As Integer = position.Row
        Dim colonne As Integer = position.Column

        If modeIndice AndAlso textBox.Text = "" Then
            ' Afficher le chiffre correct et colorier le texte en jaune
            textBox.Text = grille(ligne, colonne).ToString()
            textBox.ForeColor = Color.Yellow
            textBox.BackColor = Color.LightGreen
            textBox.ReadOnly = True

            ' Supprimer le gestionnaire d'événements KeyPress seulement pour cette TextBox
            RemoveHandler textBox.KeyPress, AddressOf TextBox_KeyPress

            ' Vérifier si la grille est complète
            If grilleComplete() Then
                BtnTerminer.Show()
            Else
                BtnTerminer.Hide()
            End If

            ' Désactiver le mode indice après avoir affiché un indice
            modeIndice = False

            ' Réactiver l'édition des autres TextBoxes
            For i As Integer = 0 To 8
                For j As Integer = 0 To 8
                    Dim tb As TextBox = GetTextBox(i, j)
                    If tb IsNot Nothing AndAlso (String.IsNullOrEmpty(tb.Text) OrElse tb.BackColor = Color.Red) Then
                        tb.ReadOnly = False
                    End If
                Next
            Next
        Else
            ' Restaurer les couleurs des régions avant de les colorier en bleu
            RestaurerCouleurs()

            ' Colorier la ligne
            For i As Integer = 0 To 8
                Dim tb As TextBox = GetTextBox(ligne, i)
                If tb IsNot Nothing AndAlso tb.BackColor <> Color.Red AndAlso tb.BackColor <> Color.LightGreen Then
                    tb.BackColor = Color.LightBlue
                End If
            Next

            ' Colorier la colonne
            For i As Integer = 0 To 8
                Dim tb As TextBox = GetTextBox(i, colonne)
                If tb IsNot Nothing AndAlso tb.BackColor <> Color.Red AndAlso tb.BackColor <> Color.LightGreen Then
                    tb.BackColor = Color.LightBlue
                End If
            Next

            ' Colorer la région
            Dim debutLigne As Integer = (ligne \ 3) * 3
            Dim debutColonne As Integer = (colonne \ 3) * 3

            For i As Integer = debutLigne To debutLigne + 2
                For j As Integer = debutColonne To debutColonne + 2
                    Dim tb As TextBox = GetTextBox(i, j)
                    If tb IsNot Nothing AndAlso tb.BackColor <> Color.Red AndAlso tb.BackColor <> Color.LightGreen Then
                        tb.BackColor = Color.LightBlue
                    End If
                Next
            Next

            ' On change la couleur de la textbox sur laquelle on clique
            textBox.BackColor = Color.LightSteelBlue
        End If
    End Sub


    Private Sub BtnTerminer_Click(sender As Object, e As EventArgs) Handles BtnTerminer.Click
        ' Vérifier s'il y a des erreurs (cases rouges) sur la grille
        For Each ctrl As Control In TableLayoutPanelQuadrillage.Controls
            If TypeOf ctrl Is TextBox Then
                Dim tb As TextBox = DirectCast(ctrl, TextBox)
                If tb.BackColor = Color.Red Then
                    MsgBox("Il y a des erreurs sur la grille. Corrigez-les avant de terminer la partie.")
                    Return
                End If
            End If
        Next

        MsgBox("Félicitations " & currentJoueur & ", tu remportes la partie !")
        Timer.Stop()

        Dim nvScore As New Score With {
        .Nom = currentJoueur.ToUpper(),
        .MeilleurTemps = (7 * 60 - tempsMax),
        .CumulTemps = .MeilleurTemps,
        .NbParties = 1,
        .Difficulte = Choix_Difficulte.getChoix()
        }

        For i As Integer = 0 To nbEnregistrement - 1
            Dim s As Score = scores.GetValue(i)
            If s.Nom = nvScore.Nom.ToUpper Then
                s.SetTemps(nvScore.MeilleurTemps)
                s.CumulTemps += nvScore.CumulTemps
                s.NbParties += 1
                scores.SetValue(s, i)
                Exit Sub
            End If
        Next

        scores.SetValue(nvScore, nbEnregistrement)
        nbEnregistrement += 1
        Me.Close()
        Form1.Show()

    End Sub

    Private Sub AfficherSudoku(grille As Integer(,), nbMax As Integer)
        ' Use the passed number of cases to display
        Dim grilleMasque As Integer(,) = SudokuMasker.MaskSudoku(grille, casesAafficher)
        For ligne As Integer = 0 To 8
            For colonne As Integer = 0 To 8
                Dim textBox As TextBox = GetTextBox(ligne, colonne)
                Dim Chiffre As String = grilleMasque(ligne, colonne)
                If Chiffre <> 0 Then
                    textBox.Text = grilleMasque(ligne, colonne).ToString()
                    textBox.ReadOnly = True
                    RemoveHandler textBox.KeyPress, AddressOf TextBox_KeyPress
                End If
            Next
        Next
        ColorierRegions()
    End Sub

    Private Function GetTextBox(ligne As Integer, colonne As Integer) As TextBox ' Obtient la TextBox a la position donnée
        Return TryCast(TableLayoutPanelQuadrillage.GetControlFromPosition(colonne, ligne), TextBox)
    End Function

    Private Sub BtnQuitter_Click_1(sender As Object, e As EventArgs) Handles BtnQuitter.Click
        Me.Close()
        Form1.Show()
    End Sub

    Private Sub ColorierRegions()
        For regionLigne As Integer = 0 To 2
            For regionColonne As Integer = 0 To 2
                For i As Integer = regionLigne * 3 To regionLigne * 3 + 2
                    For j As Integer = regionColonne * 3 To regionColonne * 3 + 2
                        Dim tb As TextBox = GetTextBox(i, j)
                        If tb IsNot Nothing AndAlso tb.BackColor <> Color.Red AndAlso tb.BackColor <> Color.LightGreen Then
                            If (regionLigne + regionColonne) Mod 2 = 0 Then
                                tb.BackColor = Color.RosyBrown
                            Else
                                tb.BackColor = Color.Snow
                            End If
                        End If
                    Next
                Next
            Next
        Next
    End Sub

    Private Sub RestaurerCouleurs()
        For i As Integer = 0 To 8
            For j As Integer = 0 To 8
                Dim tb As TextBox = GetTextBox(i, j)
                If tb IsNot Nothing Then
                    If tb.BackColor <> Color.Red AndAlso tb.BackColor <> Color.LightGreen Then
                        If ((i \ 3) + (j \ 3)) Mod 2 = 0 Then
                            tb.BackColor = Color.LightGray
                        Else
                            tb.BackColor = Color.White
                        End If
                    End If
                End If
            Next
        Next
        ColorierRegions()
    End Sub

    Private Sub BtnPause_Click(sender As Object, e As EventArgs) Handles BtnPause.Click
        Timer.Stop()
        Dim formulairePause As New Pause()
        formulairePause.NbErreursRestantes = nbErreursPossibles
        formulairePause.TempsRestant = tempsMax
        Me.Hide()
        formulairePause.ShowDialog()
        If formulairePause.DialogResult = DialogResult.OK Then
            Timer.Start()
            Me.Show()
        End If
    End Sub

    Private Sub lblNbFoisIndice_Click(sender As Object, e As EventArgs) Handles lblNbFoisIndice.Click
        If nbErreursPossibles = 0 Then
            lblNbFoisIndice.Enabled = False
        End If
    End Sub

    Private Sub LblNombreErreurs_Click(sender As Object, e As EventArgs) Handles LblNombreErreurs.Click

    End Sub
End Class
