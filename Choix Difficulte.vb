Public Class Choix_Difficulte
    Private TempsSelectionne As Integer
    Private Sub Choix_Difficulte_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    End Sub

    Private Sub btnLancer_Click(sender As Object, e As EventArgs) Handles btnLancer.Click
        Me.Hide()
        Form2.Show()
        Form2.SetGameSettings(TempsSelectionne)
    End Sub

    Private Sub TimeRadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton20Minutes.CheckedChanged, RadioButton15Minutes.CheckedChanged, RadioButton7Minutes.CheckedChanged, RadioButton4Minutes.CheckedChanged
        UpdateSelectionState()
    End Sub

    Private Sub UpdateSelectionState()
        Dim timeSelected As Boolean = RadioButton20Minutes.Checked Or RadioButton15Minutes.Checked Or RadioButton7Minutes.Checked Or RadioButton4Minutes.Checked

        btnLancer.Enabled = timeSelected

        If RadioButton20Minutes.Checked Then
            TempsSelectionne = 25 * 60
        ElseIf RadioButton15Minutes.Checked Then
            TempsSelectionne = 15 * 60
        ElseIf RadioButton7Minutes.Checked Then
            TempsSelectionne = 7 * 60
        ElseIf RadioButton4Minutes.Checked Then
            TempsSelectionne = 4 * 60
        End If
    End Sub
End Class
