Public Class Choix_Difficulte
    Private TempsSelectionne As Integer
    Private CasesAafficher As Integer

    Private Sub Choix_Difficulte_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Définition de l'opacité souhaitée (entre 0 et 1)
        Dim nouvelleOpacite As Double = 0.7 ' Opacité à 70%

        ' Appliquer l'opacité au panel
        Panel1.BackColor = Color.FromArgb(CInt(nouvelleOpacite * 255), Panel1.BackColor.R, Panel1.BackColor.G, Panel1.BackColor.B)
    End Sub

    Private Sub btnLancer_Click(sender As Object, e As EventArgs) Handles btnLancer.Click
        Me.Hide()
        Form2.Show()
        Form2.SetGameSettings(TempsSelectionne)
        Form2.SetCasesAafficher(CasesAafficher)
    End Sub

    Private Sub TimeRadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButtonFacile.CheckedChanged, RadioButtonMoyen.CheckedChanged, RadioButtonDifficile.CheckedChanged, RadioButtonExpert.CheckedChanged
        UpdateSelectionState()
    End Sub

    Private Sub UpdateSelectionState()
        Dim timeSelected As Boolean = RadioButtonFacile.Checked Or RadioButtonMoyen.Checked Or RadioButtonDifficile.Checked Or RadioButtonExpert.Checked

        btnLancer.Enabled = timeSelected

        If RadioButtonFacile.Checked Then
            TempsSelectionne = 25 * 60
            CasesAafficher = 90
        ElseIf RadioButtonMoyen.Checked Then
            TempsSelectionne = 15 * 60
            CasesAafficher = 84
        ElseIf RadioButtonDifficile.Checked Then
            TempsSelectionne = 7 * 60
            CasesAafficher = 79
        ElseIf RadioButtonExpert.Checked Then
            TempsSelectionne = 4 * 60
            CasesAafficher = 70
        End If
    End Sub

    Public Function getChoix()
        For Each control As Control In Panel1.Controls
            If TypeOf control Is RadioButton Then
                Dim bouton As RadioButton = control
                If bouton.Checked = True Then
                    Return bouton.Text
                End If
            End If
        Next
    End Function
End Class