Public Class Pause

    Public Property NbErreursRestantes As Integer
    Public Property TempsRestant As Integer

    Private Sub Pause_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblNbErreursRestantes.Text = String.Format("{0}", NbErreursRestantes)

        Dim minutes As Integer = TempsRestant \ 60
        Dim secondes As Integer = TempsRestant Mod 60
        labelMinuteur.Text = String.Format("{0:00}:{1:00}", minutes, secondes)

        ' Définition de l'opacité souhaitée (entre 0 et 1)
        Dim OpacitePanel As Double = 0.6 ' Opacité à 60%
        ' Appliquer l'opacité au panel
        Panel1.BackColor = Color.FromArgb(CInt(OpacitePanel * 255), Panel1.BackColor.R, Panel1.BackColor.G, Panel1.BackColor.B)
        Label2.BackColor = Color.FromArgb(CInt(OpacitePanel * 255), Label2.BackColor.R, Label2.BackColor.G, Label2.BackColor.B)
        labelMinuteur.BackColor = Color.FromArgb(CInt(OpacitePanel * 255), labelMinuteur.BackColor.R, labelMinuteur.BackColor.G, labelMinuteur.BackColor.B)
        Label3.BackColor = Color.FromArgb(CInt(OpacitePanel * 255), Label3.BackColor.R, Label3.BackColor.G, Label3.BackColor.B)
        lblNbErreursRestantes.BackColor = Color.FromArgb(CInt(OpacitePanel * 255), lblNbErreursRestantes.BackColor.R, lblNbErreursRestantes.BackColor.G, lblNbErreursRestantes.BackColor.B)
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

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub
End Class
