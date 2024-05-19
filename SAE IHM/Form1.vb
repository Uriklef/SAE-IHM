Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LRegle.Hide()
        BRetour.Hide()
        LScores.Hide()
        PMenu.Controls.Remove(LScores)
        LScores.SendToBack()
    End Sub

    Private Sub Button_MouseHover(sender As Object, e As EventArgs) Handles BRetour.MouseEnter, BJouer.MouseEnter, BLeaderBoard.MouseEnter, BRegle.MouseEnter, BLeave.MouseEnter
        sender.BackColor = Color.Silver
    End Sub

    Private Sub Button_MouseLeave(sender As Object, e As EventArgs) Handles BRetour.MouseLeave, BJouer.MouseLeave, BLeaderBoard.MouseLeave, BRegle.MouseLeave, BLeave.MouseLeave
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
        LScores.Show()
        BRetour.Show()
        LTitre.Text = "SCORES"
    End Sub
End Class