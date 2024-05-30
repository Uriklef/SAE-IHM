Module SudokuMasker

    Private rand As New Random()

    Public Function MaskSudoku(ByVal grid(,) As Integer, ByVal maxNumbers As Integer) As Integer(,)
        Dim maskedGrid(8, 8) As Integer
        Array.Copy(grid, maskedGrid, grid.Length)

        Dim totalCells As Integer = 120
        Dim cellsToHide As Integer = totalCells - maxNumbers

        While cellsToHide > 0
            Dim row As Integer = rand.Next(0, 9)
            Dim col As Integer = rand.Next(0, 9)

            If maskedGrid(row, col) <> 0 Then
                maskedGrid(row, col) = 0
                cellsToHide -= 1
            End If
        End While

        Return maskedGrid
    End Function

End Module
