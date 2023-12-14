Module cls_Tohopnoiluc
    Public Function Tohopnoiluc(data As DataTable, list_tang As List(Of String)) As DataTable
        ' Create a new DataTable with the same structure as the input DataTable
        Dim result As New DataTable()
        result = data.Clone()
        Dim Mmin_T As String
        ' Iterate through the list of strings (list_tang)
        For i = 0 To list_tang.Count - 1
            'Momen âm bên trái 
            Dim min1 As Double = Double.MaxValue
            Dim min2 As Double = Double.MaxValue
            Dim min1_m3 As Double = 0
            Dim min2_m3 As Double = 0
            Dim minM3Value As Double = 0
            Dim correspondingRow As DataRow = Nothing
            For Each row As DataRow In data.Rows
                If row("Unique Name").ToString().Contains(list_tang(i)) Then
                    Dim stationValue As Double = CDbl(row("Station"))
                    Dim m3Value As Double = CDbl(row("M3"))
                    If stationValue < min1 Then
                        min2 = min1
                        min1 = stationValue
                        min2_m3 = min1_m3
                        min1_m3 = m3Value
                    ElseIf stationValue < min2 Then
                        min2 = stationValue
                        min2_m3 = m3Value
                    End If
                End If
            Next
            minM3Value = Math.Min(min1_m3, min2_m3)
            For Each row As DataRow In data.Rows
                Dim m3Value As Double = CDbl(row("M3"))
                If m3Value = minM3Value Then
                    correspondingRow = row
                    Exit For
                End If
            Next
            If correspondingRow IsNot Nothing Then
                Dim resultRow As DataRow = result.NewRow()
                resultRow.ItemArray = correspondingRow.ItemArray
                result.Rows.Add(resultRow)
            End If
            'Momen dương
            Dim maxPositiveValue As Double = Double.MinValue
            Dim newRow As DataRow = Nothing
            For Each row As DataRow In data.Rows
                If row("Unique Name").ToString().Contains(list_tang(i)) Then
                    Dim currentValue As Double = Convert.ToDouble(row("M3"))
                    If currentValue > 0 AndAlso currentValue > maxPositiveValue Then
                        maxPositiveValue = currentValue
                        newRow = result.NewRow()
                        newRow.ItemArray = row.ItemArray
                    End If
                End If
            Next
            If newRow IsNot Nothing Then
                result.Rows.Add(newRow)
            End If

            'Momen âm bên phải
            Dim max1 As Double = Double.MinValue
            Dim max2 As Double = Double.MinValue
            Dim max1_m3 As Double = 0
            Dim max2_m3 As Double = 0
            Dim maxM3Value As Double = 0
            Dim correspondingRowMax As DataRow = Nothing
            For Each row As DataRow In data.Rows
                If row("Unique Name").ToString().Contains(list_tang(i)) Then
                    Dim stationValue As Double = CDbl(row("Station"))
                    Dim m3Value As Double = CDbl(row("M3"))
                    If stationValue > max1 Then
                        max2 = max1
                        max1 = stationValue
                        max2_m3 = max1_m3
                        max1_m3 = m3Value
                    ElseIf stationValue > max2 Then
                        max2 = stationValue
                        max2_m3 = m3Value
                    End If
                End If
            Next
            maxM3Value = Math.Min(max1_m3, max2_m3)
            For Each row As DataRow In data.Rows
                Dim m3Value As Double = CDbl(row("M3"))
                If m3Value = maxM3Value Then
                    correspondingRowMax = row
                    Exit For
                End If
            Next
            If correspondingRowMax IsNot Nothing Then
                Dim resultRowMax As DataRow = result.NewRow()
                resultRowMax.ItemArray = correspondingRowMax.ItemArray
                result.Rows.Add(resultRowMax)
            End If
        Next
        Return result
    End Function
End Module
