Imports System.Windows.Forms.VisualStyles.VisualStyleElement.Header

Public Class Form2

    Dim tempsMax As Integer = 7 * 60
    Private Sub Timer_Tick(sender As Object, e As EventArgs) Handles Timer.Tick
        If tempsMax > 0 Then
            tempsMax -= 1
            ActualisationLabel()
        Else
            Timer.Stop()
            MessageBox.Show("Le temps est écoulé!")
        End If
    End Sub

    Private Sub BtnNouvellePartie_Click(sender As Object, e As EventArgs) Handles BtnNouvellePartie.Click
        tempsMax = 7 * 60
        Timer.Start()
        ActualisationLabel()
    End Sub

    Private Sub ActualisationLabel()
        Dim minutes As Integer = tempsMax \ 60
        Dim seconds As Integer = tempsMax Mod 60
        labelMinuteur.Text = String.Format("{0:00}:{1:00}", minutes, seconds)
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer.Interval = 1000
        ActualisationLabel()
    End Sub

    Private Sub BtnQuitter_Click(sender As Object, e As EventArgs) Handles BtnQuitter.Click
        Dim resultat As MsgBoxResult = MsgBox("Voulez vous vraiment quitter ?", vbYesNo)
        If resultat = MsgBoxResult.Yes Then
            Me.Close()
            Dim form1 As New Form1()
            form1.Show()
        End If
    End Sub
End Class
