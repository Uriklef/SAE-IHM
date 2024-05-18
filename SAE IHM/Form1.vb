Public Class Form1
    Private Sub btnQuitter_Click(sender As Object, e As EventArgs) Handles btnQuitter.Click
        Dim resultat As MsgBoxResult = MsgBox("Voulez vous quitter l'application ?", vbYesNo)
        If resultat = MsgBoxResult.Yes Then
            MsgBox("Arrêt de l'application")
            Me.Hide()
        ElseIf resultat = MsgBoxResult.No Then
            Me.Hide()
            Me.Show()
        End If
    End Sub

    Private Sub ComboBoxNom_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxNom.SelectedIndexChanged

    End Sub

    Private Sub BtnTableauScore_Click(sender As Object, e As EventArgs) Handles BtnTableauScore.Click

    End Sub
End Class
