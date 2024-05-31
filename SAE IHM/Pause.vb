Public Class Pause

    Public Property NbErreursRestantes As Integer
    Public Property TempsRestant As Integer

    Private Sub Pause_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblNbErreursRestantes.Text = String.Format("{0}", NbErreursRestantes)

        Dim minutes As Integer = TempsRestant \ 60
        Dim secondes As Integer = TempsRestant Mod 60
        labelMinuteur.Text = String.Format("{0:00}:{1:00}", minutes, secondes)
    End Sub

    Private Sub lblNbErreursRestantes_Click(sender As Object, e As EventArgs) Handles lblNbErreursRestantes.Click
        lblNbErreursRestantes.Text = String.Format("{0}", NbErreursRestantes)
    End Sub

    Private Sub labelMinuteur_Click(sender As Object, e As EventArgs) Handles labelMinuteur.Click
        Dim minutes As Integer = TempsRestant \ 60
        Dim secondes As Integer = TempsRestant Mod 60
        labelMinuteur.Text = String.Format("{0:00}:{1:00}", minutes, secondes)
    End Sub

    Private Sub BtnReprendre_Click(sender As Object, e As EventArgs) Handles BtnReprendre.Click
        Me.DialogResult = DialogResult.OK
        Me.Close()
    End Sub
End Class
