Module StockageScore

    Public Structure Score
        Public Nom As String
        Public MeilleurTemps As Integer
        Public CumulTemps As Integer
        Public NbParties As Integer
        Public Difficulte As String
        Public Sub SetTemps(temps As Integer)
            If temps < Me.MeilleurTemps Then
                Me.MeilleurTemps = temps
            End If
        End Sub
    End Structure

    Public scores(10) As Score
    Public nbEnregistrement As Integer = 0

End Module
