Module SudokuGenerator

    Private rand As New Random()

    Public Function GenerateSudoku() As Integer(,)
        Dim grid(8, 8) As Integer
        FillSudoku(grid)
        Return grid
    End Function

    Private Function IsSafe(grid(,) As Integer, row As Integer, col As Integer, num As Integer) As Boolean
        For x As Integer = 0 To 8
            If grid(row, x) = num Or grid(x, col) = num Then
                Return False
            End If
        Next

        Dim startRow As Integer = row - row Mod 3
        Dim startCol As Integer = col - col Mod 3

        For i As Integer = 0 To 2
            For j As Integer = 0 To 2
                If grid(i + startRow, j + startCol) = num Then
                    Return False
                End If
            Next
        Next

        Return True
    End Function

    Private Function FillSudoku(ByRef grid(,) As Integer) As Boolean
        Dim row As Integer = -1
        Dim col As Integer = -1
        Dim isEmpty As Boolean = True
        For i As Integer = 0 To 8
            For j As Integer = 0 To 8
                If grid(i, j) = 0 Then
                    row = i
                    col = j
                    isEmpty = False
                    Exit For
                End If
            Next
            If Not isEmpty Then
                Exit For
            End If
        Next

        If isEmpty Then
            Return True
        End If

        Dim numbers As List(Of Integer) = Enumerable.Range(1, 9).OrderBy(Function(n) rand.Next()).ToList()

        For Each num As Integer In numbers
            If IsSafe(grid, row, col, num) Then
                grid(row, col) = num
                If FillSudoku(grid) Then
                    Return True
                End If
                grid(row, col) = 0
            End If
        Next

        Return False
    End Function

End Module