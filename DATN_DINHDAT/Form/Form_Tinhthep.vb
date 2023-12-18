Public Class Form_Tinhthep
    Private Sub Form_Tinhthep_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Tinh_As()
    End Sub

    ' Command cho hàm Tinh_As
    Private Sub Tinh_As()
        ' Lấy số lượng dòng từ DataTable trong Form_Main
        Dim a As Integer = Form_Main.chonthep.Rows.Count

        ' Gắn dữ liệu từ cột 1 và cột 3 của DataTable1 vào cột 1 và cột 5 của DataGridView
        For i As Integer = 0 To a - 1
            dgv_chonthep.Rows.Add()
            dgv_chonthep.Rows(i).Cells("tang").Value = Form_Main.chonthep.Rows(i)("Tầng")
            dgv_chonthep.Rows(i).Cells("tendam").Value = Form_Main.chonthep.Rows(i)("Tên dầm")
            dgv_chonthep.Rows(i).Cells("vitri").Value = Form_Main.chonthep.Rows(i)("Vị trí")
            dgv_chonthep.Rows(i).Cells("Astt").Value = Form_Main.chonthep.Rows(i)("Astt")
            dgv_chonthep.Rows(i).Cells("ø").Value = "6"
            dgv_chonthep.Rows(i).Cells("ø2").Value = "6"
        Next
    End Sub

    ' Command cho hàm S
    Private Function S(duongkinh As Integer) As Double
        ' Tính diện tích và làm tròn đến 3 chữ số thập phân
        Dim dienTich As Double = Math.PI * ((duongkinh) / 2) ^ 2
        Return Math.Round(dienTich, 3)
    End Function

    ' Command cho sự kiện CellValueChanged của DataGridView
    Private Sub dgv_chonthep_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_chonthep.CellValueChanged
        ' Kiểm tra nếu chỉ số dòng hợp lệ
        If e.RowIndex >= 0 AndAlso e.RowIndex < dgv_chonthep.Rows.Count Then
            ' Kiểm tra xem có cột cần thiết hay không
            Dim theploai1Column As DataGridViewColumn = dgv_chonthep.Columns("theploai1")
            Dim øColumn As DataGridViewColumn = dgv_chonthep.Columns("ø")
            Dim ø2Column As DataGridViewColumn = dgv_chonthep.Columns("ø2")

            If theploai1Column IsNot Nothing AndAlso øColumn IsNot Nothing AndAlso ø2Column IsNot Nothing Then
                ' Lấy chỉ số dòng
                Dim rowIndex As Integer = e.RowIndex
                ' Lấy giá trị của ô "ø"
                Dim øCellValue As Object = dgv_chonthep.Rows(rowIndex).Cells("ø").Value

                ' Kiểm tra giá trị không phải DBNull hoặc Nothing
                If øCellValue IsNot DBNull.Value AndAlso øCellValue IsNot Nothing Then
                    Dim selectedValue As String = øCellValue.ToString()

                    ' Lấy giá trị của ô "ø2"
                    Dim ø2CellValue As Object = dgv_chonthep.Rows(rowIndex).Cells("ø2").Value
                    ' Kiểm tra giá trị không phải DBNull hoặc Nothing
                    If ø2CellValue IsNot DBNull.Value AndAlso ø2CellValue IsNot Nothing Then
                        Dim selectedValue2 As String = ø2CellValue.ToString()

                        ' Cập nhật giá trị Astc khi có cả "ø" và "ø2"
                        Dim theploai1 As Integer = GetCellValueAsInteger(dgv_chonthep.Rows(rowIndex).Cells("theploai1"))
                        Dim theploai2 As Integer = GetCellValueAsInteger(dgv_chonthep.Rows(rowIndex).Cells("theploai2"))
                        dgv_chonthep.Rows(rowIndex).Cells("Astc").Value = S(Convert.ToInt32(selectedValue)) * (theploai1) + S(Convert.ToInt32(selectedValue2)) * (theploai2)
                    Else
                        ' Cập nhật giá trị Astc khi chỉ có "ø"
                        Dim theploai1 As Integer = GetCellValueAsInteger(dgv_chonthep.Rows(rowIndex).Cells("theploai1"))
                        dgv_chonthep.Rows(rowIndex).Cells("Astc").Value = S(Convert.ToInt32(selectedValue)) * (theploai1)
                    End If

                    ' Kiểm tra điều kiện và cập nhật giá trị "kiemtra"
                    Dim asttValue As Double = GetCellValueAsDouble(dgv_chonthep.Rows(rowIndex).Cells("Astt"))
                    Dim astcValue As Double = GetCellValueAsDouble(dgv_chonthep.Rows(rowIndex).Cells("Astc"))
                    If asttValue > astcValue Then
                        dgv_chonthep.Rows(rowIndex).Cells("kiemtra").Value = "Chưa thỏa mãn"
                    Else
                        dgv_chonthep.Rows(rowIndex).Cells("kiemtra").Value = ""
                    End If
                Else
                    ' Xử lý trường hợp "ø" là DBNull hoặc Nothing
                    ' ...
                End If
            End If
        End If
    End Sub

    ' Command cho hàm GetCellValueAsInteger
    Private Function GetCellValueAsInteger(cell As DataGridViewCell) As Integer
        ' Kiểm tra ô có tồn tại và không phải DBNull hoặc Nothing
        If cell IsNot Nothing AndAlso cell.Value IsNot DBNull.Value AndAlso cell.Value IsNot Nothing Then
            Return Convert.ToInt32(cell.Value)
        Else
            Return 0
        End If
    End Function

    ' Command cho hàm GetCellValueAsDouble
    Private Function GetCellValueAsDouble(cell As DataGridViewCell) As Double
        ' Kiểm tra ô có tồn tại và không phải DBNull hoặc Nothing
        If cell IsNot Nothing AndAlso cell.Value IsNot DBNull.Value AndAlso cell.Value IsNot Nothing Then
            Return Convert.ToDouble(cell.Value)
        Else
            Return 0
        End If
    End Function
End Class
