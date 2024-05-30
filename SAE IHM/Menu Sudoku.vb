Imports System.Drawing.Drawing2D

Public Class Form1

    Private Sub Menu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LRegle.Hide()
        BRetour.Hide()
        PLeaderBoard.Hide()
        LCreateurs.Hide()

        Dim audioStream As System.IO.Stream = My.Resources.opNami

        If audioStream IsNot Nothing Then
            Dim tempPath As String = System.IO.Path.GetTempFileName()
            Using fileStream As New System.IO.FileStream(tempPath, System.IO.FileMode.Create, System.IO.FileAccess.Write)
                audioStream.CopyTo(fileStream)
            End Using

            My.Computer.Audio.Play(tempPath, AudioPlayMode.BackgroundLoop)
        Else
            MessageBox.Show("Le fichier audio n'est pas disponible.")
        End If

        AddHandler BCreateurs.Paint, AddressOf Me.BCreateursPaint
        BCreateurs.Size = New Size(30, 30)
    End Sub

    Private Sub BCreateursPaint(sender As Object, e As PaintEventArgs)
        Dim button As Button = CType(sender, Button)
        Dim path As New GraphicsPath()
        Dim diameter As Integer = Math.Min(button.Width, button.Height)
        path.AddEllipse(0, 0, diameter, diameter)
        button.Region = New Region(path)
        Dim sf As New StringFormat With {
            .Alignment = StringAlignment.Center,
            .LineAlignment = StringAlignment.Center
        }
        e.Graphics.DrawString(button.Text, button.Font, Brushes.Black, New Rectangle(0, 0, button.Width, button.Height), sf)
        Using pen As New Pen(Color.Black, 2)
            e.Graphics.DrawPath(pen, path)
        End Using
    End Sub

    Private Sub RemplieScore()
        LScores.Text = ""
        LScores.Text = "Joueurs     |      Temps" & vbCr & "-------------------------------------" & vbCr
        LBNoms.Items.Clear()
        LBMeilleursScores.Items.Clear()
        If nbEnregistrement = 0 Then
            LScores.Text = LScores.Text & "Aucun joueur enregistré"
        Else
            For i As Integer = 0 To nbEnregistrement - 1
                Dim score As Score = scores.GetValue(i)
                LBNoms.Items.Add(score.Nom)
                If Not CBNoms.Items.Contains(score.Nom) Then
                    CBNoms.Items.Add(score.Nom)
                End If
                Dim minutes As Integer = score.MeilleurTemps / 60
                Dim secondes As Integer = score.MeilleurTemps Mod 60
                Dim temps As String = minutes.ToString & ":" & secondes.ToString
                LBMeilleursScores.Items.Add(temps)
            Next
        End If
    End Sub

    Private Sub Button_MouseHover(sender As Object, e As EventArgs) Handles BRetour.MouseEnter, BJouer.MouseEnter, BLeaderBoard.MouseEnter, BLeave.MouseEnter, BRegle.MouseEnter
        sender.BackColor = Color.Silver
    End Sub

    Private Sub Button_MouseLeave(sender As Object, e As EventArgs) Handles BRetour.MouseLeave, BJouer.MouseLeave, BLeaderBoard.MouseLeave, BLeave.MouseLeave, BRegle.MouseLeave
        sender.BackColor = Color.Transparent
    End Sub

    Private Sub BRegle_Click(sender As Object, e As EventArgs) Handles BRegle.Click
        PMenu.Hide()
        BCreateurs.Hide()
        LRegle.Show()
        BRetour.Show()
        LTitre.Text = "REGLES"
    End Sub

    Private Sub BRetour_Click(sender As Object, e As EventArgs) Handles BRetour.Click
        LRegle.Hide()
        BRetour.Hide()
        PLeaderBoard.Hide()
        PMenu.Show()
        BCreateurs.Show()
        LTitre.Text = "SUDOKU"
    End Sub

    Private Sub BLeave_Click(sender As Object, e As EventArgs) Handles BLeave.Click
        Dim MsgResult As MsgBoxResult = MsgBox("Êtes vous sur de vouloir quitter l'application ?", MsgBoxStyle.YesNo)
        If MsgResult = vbYes Then
            Me.Close()
        End If
    End Sub

    Private Sub BLeaderBoard_Click(sender As Object, e As EventArgs) Handles BLeaderBoard.Click
        PMenu.Hide()
        BCreateurs.Hide()
        RemplieScore()
        PLeaderBoard.Show()
        BRetour.Show()
        LTitre.Text = "SCORES"
    End Sub

    Private Sub BJouer_Click(sender As Object, e As EventArgs) Handles BJouer.Click
        Dim formulaireJeu As New Form2()
        formulaireJeu.Show()
        Me.Hide()
    End Sub

    Private Sub BTrierNoms_Click(sender As Object, e As EventArgs) Handles BTrierNoms.Click
        Dim items1 As List(Of String) = LBNoms.Items.Cast(Of String)().ToList()
        Dim items2 As List(Of String) = LBMeilleursScores.Items.Cast(Of String)().ToList()
        Dim pairedItems As List(Of KeyValuePair(Of String, String)) = items1.Zip(items2, Function(a, b) New KeyValuePair(Of String, String)(a, b)).ToList()
        pairedItems.Sort(Function(x, y) x.Key.CompareTo(y.Key))

        LBNoms.Items.Clear()
        LBMeilleursScores.Items.Clear()

        For Each pair As KeyValuePair(Of String, String) In pairedItems
            LBNoms.Items.Add(pair.Key)
            LBMeilleursScores.Items.Add(pair.Value)
        Next
    End Sub

    Private Sub BTriScore_Click(sender As Object, e As EventArgs) Handles BTriScore.Click
        Dim items1 As List(Of String) = LBMeilleursScores.Items.Cast(Of String)().ToList()
        Dim items2 As List(Of String) = LBNoms.Items.Cast(Of String)().ToList()
        Dim pairedItems As List(Of KeyValuePair(Of String, String)) = items1.Zip(items2, Function(a, b) New KeyValuePair(Of String, String)(a, b)).ToList()
        pairedItems.Sort(Function(x, y) x.Key.CompareTo(y.Key))

        LBNoms.Items.Clear()
        LBMeilleursScores.Items.Clear()

        For Each pair As KeyValuePair(Of String, String) In pairedItems
            LBMeilleursScores.Items.Add(pair.Key)
            LBNoms.Items.Add(pair.Value)
        Next
    End Sub

    Private Sub CBNoms_KeyPress(sender As Object, e As KeyPressEventArgs) Handles CBNoms.KeyPress
        If Char.IsDigit(e.KeyChar) And e.KeyChar <> vbBack Then
            e.Handled = True
        End If
        e.KeyChar = Char.ToUpper(e.KeyChar)
    End Sub

    Private Sub LBNoms_SelectedChanged(sender As Object, e As EventArgs) Handles LBNoms.Click, LBMeilleursScores.Click, CBNoms.Click
        LBMeilleursScores.SelectedIndex = sender.SelectedIndex
        LBNoms.SelectedIndex = sender.SelectedIndex
        CBNoms.SelectedItem = LBNoms.SelectedItem
    End Sub

    Private Sub BStats_Click(sender As Object, e As EventArgs) Handles BStats.Click
        For i As Integer = 0 To nbEnregistrement - 1
            Dim s As Score = scores.GetValue(i)
            If s.Nom = LBNoms.SelectedItem Then
                Dim minutes As Integer = s.MeilleurTemps / 60
                Dim secondes As Integer = s.MeilleurTemps Mod 60
                Dim meilleurTemps As String = minutes.ToString & ":" & secondes.ToString
                minutes = s.CumulTemps / 60
                secondes = s.CumulTemps Mod 60
                Dim cumulTemps As String = minutes.ToString & ":" & secondes.ToString
                MsgBox("Nom du joueur : " & s.Nom & vbCr & "Meilleur temps : " & meilleurTemps & vbCr & "Nombre de parties jouer : " & s.NbParties & vbCr & "Cumul du temps de jeu écoulé : " & cumulTemps)
                Exit Sub
            End If
        Next
    End Sub

    Private Sub BCreateurs_Click(sender As Object, e As EventArgs) Handles BCreateurs.Click
        LCreateurs.Show()
        LCreateurs.Refresh()
        System.Threading.Thread.Sleep(4000)
        LCreateurs.Hide()
    End Sub
End Class
