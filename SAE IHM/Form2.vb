Imports System.Windows.Forms.VisualStyles.VisualStyleElement.Header

Public Class Form2

    Dim tempsMax As Integer = 7 * 60
    Dim partieActive As Boolean
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
        If partieActive = True Then
            Dim resultat As MsgBoxResult = MsgBox("Etes vous sur de vouloir relancer une partie ?", vbYesNo)
            If resultat = MsgBoxResult.Yes Then
                LancerPartie()
            End If
        Else
            LancerPartie()
        End If
    End Sub

    Private Sub LancerPartie()
        partieActive = True
        tempsMax = 7 * 60
        Timer.Start()
        ActualisationLabel()

        Dim index As Integer
        For index = 1 To 81
            Dim txtBox As TextBox = CType(Me.Controls("TextBox" & index.ToString()), TextBox)
            txtBox.Enabled = True
            txtBox.Text = ""
        Next
    End Sub

    Private Sub ActualisationLabel()
        Dim minutes As Integer = tempsMax \ 60
        Dim secondes As Integer = tempsMax Mod 60
        labelMinuteur.Text = String.Format("{0:00}:{1:00}", minutes, secondes)
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer.Interval = 1000
        ActualisationLabel()

        Dim index As Integer
        For index = 1 To 81
            Dim txtBox As TextBox = CType(Me.Controls("TextBox" & index.ToString()), TextBox)
            txtBox.Enabled = False
        Next
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
