Module StockageScore

    Public Structure Score
        Public Nom As String
        Public Temps As String
        Public MeilleurTemps As String
        Public CumulTemps As String
    End Structure

    Public scores(10) As Score
    Public nbEnregistrement As Integer = 0

End Module
