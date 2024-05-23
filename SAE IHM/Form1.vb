Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LRegle.Hide()
        BRetour.Hide()
        PLeaderBoard.Hide()

    End Sub

    Private Sub RemplieScore()
        LScores.Text = ""
        LScores.Text = "Joueurs     |      Temps" & vbCr & "-------------------------------------" & vbCr
        LBNoms.Items.Clear()
        LBMeilleursScores.Items.Clear()
        If nbEnregistrement = 0 Then
            LScores.Text = LScores.Text & "Aucun joueur enregistrer"
        Else
            For i As Integer = 0 To nbEnregistrement - 1
                Dim score As Score = scores.GetValue(i)
                LBNoms.Items.Add(score.Nom)
                LBMeilleursScores.Items.Add(score.Temps)
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
        LRegle.Show()
        BRetour.Show()
        LTitre.Text = "REGLES"
    End Sub

    Private Sub BRetour_Click(sender As Object, e As EventArgs) Handles BRetour.Click
        LRegle.Hide()
        BRetour.Hide()
        PLeaderBoard.Hide()
        PMenu.Show()
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

    Private Sub LB_SelectedIndexChanged(sender As Object, e As EventArgs) Handles LBNoms.SelectedIndexChanged, LBMeilleursScores.SelectedIndexChanged
        LBNoms.SelectedIndex = sender.SelectedIndex
        LBMeilleursScores.SelectedIndex = sender.SelectedIndex
        LBNoms.TopIndex = LBNoms.SelectedIndex
        LBMeilleursScores.TopIndex = LBMeilleursScores.SelectedIndex
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
End Class