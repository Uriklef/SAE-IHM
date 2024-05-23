Imports System.Windows.Forms.VisualStyles.VisualStyleElement.Header

Public Class Form2

    Dim tempsMax As Integer = 7 * 60
    Dim partieActive As Boolean
    Dim currentJoueur As String

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
        currentJoueur = InputBox("Saisissez votre nom")
        partieActive = True
        BtnTerminer.Enabled = True
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

        BtnTerminer.Enabled = False

        Dim index As Integer
        For index = 1 To 81
            Dim txtBox As TextBox = CType(Me.Controls("TextBox" & index.ToString()), TextBox)
            txtBox.Enabled = False
            txtBox.MaxLength = 1
            AddHandler txtBox.KeyPress, AddressOf TextBox_KeyPress
            AddHandler txtBox.Click, AddressOf TextBox_Click
        Next
    End Sub

    Private Sub BtnQuitter_Click(sender As Object, e As EventArgs) Handles BtnQuitter.Click
        Dim resultat As MsgBoxResult = MsgBox("Voulez vous vraiment quitter ?", vbYesNo)
        If resultat = MsgBoxResult.Yes Then
            Me.Close()
            Form1.Show()
        End If
    End Sub

    Private Sub TextBox_KeyPress(sender As Object, e As KeyPressEventArgs)
        If Not Char.IsDigit(e.KeyChar) AndAlso e.KeyChar <> vbBack Then
            e.Handled = True
        End If
    End Sub

    Private Sub BtnIndice_Click(sender As Object, e As EventArgs) Handles BtnIndice.Click
        If partieActive = False Then
            MessageBox.Show("Il faut lancer une partie pour avoir accès à un indice")
        End If
    End Sub

    Private Sub TextBox_Click(sender As Object, e As EventArgs)
        Dim clickedTextBox As TextBox = DirectCast(sender, TextBox)

        Dim TextBoxSelectionnee As TextBox = DirectCast(sender, TextBox)
        Dim referenceTop As Integer = TextBoxSelectionnee.Top
        Dim referenceLeft As Integer = TextBoxSelectionnee.Left

        For Each ctrl As Control In Me.Controls
            If TypeOf ctrl Is TextBox Then
                Dim txtBox As TextBox = DirectCast(ctrl, TextBox)
                txtBox.BackColor = SystemColors.Window
            End If
        Next

        For Each ctrl As Control In Me.Controls
            If TypeOf ctrl Is TextBox Then
                Dim txtBox As TextBox = DirectCast(ctrl, TextBox)
                If txtBox.Top = referenceTop OrElse txtBox.Left = referenceLeft Then
                    txtBox.BackColor = Color.LightBlue
                End If
            End If
        Next
    End Sub

    Private Sub BtnTerminer_Click(sender As Object, e As EventArgs) Handles BtnTerminer.Click
        For index As Integer = 1 To 81
            Dim txtBox As TextBox = CType(Me.Controls("TextBox" & index.ToString()), TextBox)
            If txtBox.Text = "" OrElse txtBox.ForeColor = Color.Red Then
                MsgBox("Grille imcomplète ou possède des erreurs")
                Exit Sub
            End If
        Next

        Dim score As New Score With {
            .Nom = currentJoueur,
            .Temps = labelMinuteur.Text
        }
        scores.SetValue(score, nbEnregistrement)
        nbEnregistrement += 1

        MsgBox("Felicitation " & currentJoueur & " ,tu remportes la partie !")
        Timer.Stop()
        BtnTerminer.Enabled = False

    End Sub
End Class
