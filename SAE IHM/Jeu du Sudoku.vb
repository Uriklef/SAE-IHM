Imports System.Drawing.Text
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.Header

Public Class Form2

    Dim tempsMax As Integer = 7 * 60
    Dim partieActive As Boolean
    Dim currentJoueur As String
    Dim nbErreursPossibles As Integer = 3
    Dim grille As Integer(,)

    Private Sub Timer_Tick(sender As Object, e As EventArgs) Handles Timer.Tick
        If tempsMax > 0 Then
            tempsMax -= 1
            ActualisationLabel()
        Else
            Timer.Stop()
            MessageBox.Show("Le temps est écoulé!")
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
            tempsMax = 7 * 60
            Timer.Start()
            ActualisationLabel()
            AfficherSudoku(grille, 80)
            TableLayoutPanelQuadrillage.Enabled = True
        End If

    End Sub

    Private Sub ActualisationLabel()
        Dim minutes As Integer = tempsMax \ 60
        Dim secondes As Integer = tempsMax Mod 60
        labelMinuteur.Text = String.Format("{0:00}:{1:00}", minutes, secondes)

        lblNbErreursRestantes.Text = String.Format("{0}", nbErreursPossibles)
    End Sub

    Private Sub Jeu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer.Interval = 1000
        ActualisationLabel()

        BtnTerminer.Enabled = False
        BtnTerminer.Hide()
        BtnQuitter.Hide()

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
    End Sub

    Private Function grilleComplete()
        For i As Integer = 0 To 80
            Dim item As String = TableLayoutPanelQuadrillage.Controls.Item(i).Text
            If item = "" Then
                Return False
            End If
        Next
        Return True
    End Function

    Private Sub BtnQuitter_Click(sender As Object, e As EventArgs) Handles BtnAbandonner.Click
        Dim resultat As MsgBoxResult = MsgBox("Voulez vous vraiment abandonner ?", vbYesNo)
        If resultat = MsgBoxResult.Yes Then
            Dim soluce As MsgBoxResult = MsgBox("Voulez vous voir la solution ?", vbYesNo)
            If soluce = vbYes Then
                MsgBox("Coming soon")
                BtnAbandonner.Hide()
                BtnIndice.Hide()
                BtnQuitter.Show()
            Else
                Me.Close()
                Form1.Show()
            End If
        End If
    End Sub

    Private Sub TextBox_KeyPress(sender As Object, e As KeyPressEventArgs)
        If Not Char.IsDigit(e.KeyChar) AndAlso e.KeyChar <> vbBack Then
            e.Handled = True
        ElseIf Char.IsDigit(e.KeyChar) Then
            Dim textBox As TextBox = DirectCast(sender, TextBox)
            Dim position As TableLayoutPanelCellPosition = TableLayoutPanelQuadrillage.GetPositionFromControl(textBox)
            If grille(position.Row, position.Column).ToString <> e.KeyChar Then
                textBox.ForeColor = Color.Red
                nbErreursPossibles = nbErreursPossibles - 1
            Else
                textBox.ForeColor = Color.LightGreen
            End If
            If nbErreursPossibles = 0 Then
                MsgBox("Tu as fais trop d'erreurs, la partie est perdue")
                ReinitialiserPartie()
            End If
            If grilleComplete() Then
                BtnTerminer.Show()
            End If
        End If
    End Sub

    Private Sub BtnIndice_Click(sender As Object, e As EventArgs) Handles BtnIndice.Click
        If partieActive = False Then
            MessageBox.Show("Il faut lancer une partie pour avoir accès à un indice")
        End If
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
        BtnIndice.Enabled = False
        Timer.Stop()
    End Sub

    Private Sub TextBox_Click(sender As Object, e As MouseEventArgs)
        Dim textBox As TextBox = DirectCast(sender, TextBox)
        Dim position As TableLayoutPanelCellPosition = TableLayoutPanelQuadrillage.GetPositionFromControl(textBox)
        Dim ligne As Integer = position.Row
        Dim colonne As Integer = position.Column

        ' On met toutes les textbox en blanc
        For i As Integer = 0 To 8
            For j As Integer = 0 To 8
                Dim tb As TextBox = GetTextBox(i, j)
                If tb IsNot Nothing Then
                    tb.BackColor = Color.White
                End If
            Next
        Next

        ' Colorier la ligne
        For i As Integer = 0 To 8
            Dim tb As TextBox = GetTextBox(ligne, i)
            If tb IsNot Nothing Then
                tb.BackColor = Color.LightBlue
            End If
        Next

        ' Colorier la colonne
        For i As Integer = 0 To 8
            Dim tb As TextBox = GetTextBox(i, colonne)
            If tb IsNot Nothing Then
                tb.BackColor = Color.LightBlue
            End If
        Next

        ' Colorer la region
        Dim debutLigne As Integer = (ligne \ 3) * 3
        Dim debutColonne As Integer = (colonne \ 3) * 3

        For i As Integer = debutLigne To debutLigne + 2
            For j As Integer = debutColonne To debutColonne + 2
                Dim tb As TextBox = GetTextBox(i, j)
                If tb IsNot Nothing Then
                    tb.BackColor = Color.LightBlue
                End If
            Next
        Next

        ' On change la couleur de la textbox sur laquelle on clique
        textBox.BackColor = Color.LightSteelBlue
    End Sub

    Private Sub BtnTerminer_Click(sender As Object, e As EventArgs) Handles BtnTerminer.Click

        MsgBox("Felicitation " & currentJoueur & " ,tu remportes la partie !")
        Timer.Stop()
        BtnTerminer.Enabled = False

        Dim nvScore As New Score With {
            .Nom = currentJoueur.ToUpper(),
            .MeilleurTemps = (7 * 60 - tempsMax),
            .CumulTemps = .MeilleurTemps,
            .NbParties = 1
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
    End Sub

    Private Sub AfficherSudoku(ByVal grille As Integer(,), ByVal nbMax As Integer)
        Dim grilleMasque As Integer(,) = SudokuMasker.MaskSudoku(grille, nbMax)
        For ligne As Integer = 0 To 8
            For colonne As Integer = 0 To 8
                Dim textBox As TextBox = GetTextBox(ligne, colonne)
                Dim Chiffre As String = grilleMasque(ligne, colonne)
                If Chiffre <> 0 Then
                    textBox.Text = grilleMasque(ligne, colonne).ToString()
                    textBox.ReadOnly = True
                End If
            Next
        Next
    End Sub

    Private Function GetTextBox(ligne As Integer, colonne As Integer) As TextBox ' Obtient la TextBox a la position donnée
        Return TryCast(TableLayoutPanelQuadrillage.GetControlFromPosition(colonne, ligne), TextBox)
    End Function

    Private Sub BtnQuitter_Click_1(sender As Object, e As EventArgs) Handles BtnQuitter.Click
        Me.Close()
        Form1.Show()
    End Sub
End Class
