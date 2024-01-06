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
            dgv_chonthep.Rows(i).Cells("ø").Value = "20"
            dgv_chonthep.Rows(i).Cells("ø2").Value = "20"

            ' chọn số lượng thanh thép tạm thời
            Dim soluongthanhthep As Integer = chonthep(dgv_chonthep.Rows(i).Cells("Astt").Value, dgv_chonthep.Rows(i).Cells("ø").Value)
            If soluongthanhthep > 4 Then
                dgv_chonthep.Rows(i).Cells("theploai1").Value = 4
                dgv_chonthep.Rows(i).Cells("theploai2").Value = soluongthanhthep - 4
            ElseIf soluongthanhthep <= 4 Then
                dgv_chonthep.Rows(i).Cells("theploai1").Value = soluongthanhthep
            End If
        Next
    End Sub
    Function chonthep(A_s As Double, duongkinh As Integer) As Double
        Return Int(A_s / S(duongkinh)) + 1
    End Function

    ' Command cho hàm S
    Private Function S(duongkinh As Integer) As Double
        ' Tính diện tích và làm tròn đến 3 chữ số thập phân
        Dim dienTich As Double = Math.PI * ((duongkinh / 10) / 2) ^ 2
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

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim tendam As String = ""
        Dim vitri As Double
        Dim ø1 As Double
        Dim theplop1 As Double
        Dim ø2 As Double
        Dim theplop2 As Double
        If dgv_chonthep.RowCount > 1 Then
            For i = 0 To dgv_chonthep.RowCount - 1
                If dgv_chonthep.Rows(i).Cells("tendam").Value IsNot Nothing Then
                    tendam = dgv_chonthep.Rows(i).Cells("tendam").Value.ToString()
                End If

                If dgv_chonthep.Rows(i).Cells("vitri").Value IsNot Nothing Then
                    vitri = dgv_chonthep.Rows(i).Cells("vitri").Value.ToString()
                End If

                If dgv_chonthep.Rows(i).Cells("ø").Value IsNot Nothing Then
                    ø1 = dgv_chonthep.Rows(i).Cells("ø").Value.ToString()
                End If

                If dgv_chonthep.Rows(i).Cells("theploai1").Value IsNot Nothing Then
                    theplop1 = dgv_chonthep.Rows(i).Cells("theploai1").Value.ToString()
                End If

                If dgv_chonthep.Rows(i).Cells("ø2").Value IsNot Nothing Then
                    ø2 = dgv_chonthep.Rows(i).Cells("ø2").Value.ToString()
                End If

                If dgv_chonthep.Rows(i).Cells("theploai2").Value IsNot Nothing Then
                    theplop2 = dgv_chonthep.Rows(i).Cells("theploai2").Value.ToString()
                End If

                For Each tang As Cls_tang In congtrinh.Danhsachtang
                    For Each dam As Cls_dam In tang.Danhsach_Dam
                        If tendam.Contains(dam.Tendam.ToString()) AndAlso
                           (dam.Vitri_T = vitri OrElse dam.Vitri_G = vitri OrElse dam.Vitri_P = vitri) Then

                            If dam.Vitri_T = vitri Then
                                dam.Td1_st1 = theplop1
                                dam.Td1_dk1 = ø1
                                dam.Td1_st2 = theplop2
                                dam.Td1_dk2 = ø2
                            ElseIf dam.Vitri_G = vitri Then
                                dam.Td2_st1 = theplop1
                                dam.Td2_dk1 = ø1
                                dam.Td2_st2 = theplop2
                                dam.Td2_dk2 = ø2
                            ElseIf dam.Vitri_P = vitri Then
                                dam.Td3_st1 = theplop1
                                dam.Td3_dk1 = ø1
                                dam.Td3_st2 = theplop2
                                dam.Td3_dk2 = ø2
                            End If
                        End If
                    Next
                Next
            Next
            MessageBox.Show("Đã lưu thông tin cốt thép")
        End If
    End Sub
End Class
