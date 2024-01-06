Public Class Form_Banve

    Private Sub btn_ve_Click(sender As Object, e As EventArgs) Handles btn_ve.Click
        'Dim Banve As VDProLib5.vdEntities
        Me.Vecto.ActiveDocument.Open(Application.StartupPath + "\Template\template.dxf", 0, 0)
        Me.Vecto.ActiveDocument.Entities.EraseAll()
        'Banve = Me.Vecto.ActiveDocument.Entities
        For Each tang As Cls_tang In congtrinh.Danhsachtang
            Dim x As Integer
            Dim y As Integer
            If tang.Danhsach_Dam.Count > 0 Then
                y = 0
                For Each dam As Cls_dam In tang.Danhsach_Dam
                    VeMatCatDoc(Vecto, dam.Tendam, dam.B * 1000, dam.H * 1000, dam.L * 1000, 9000 * x, -dam.H * 5000 * y, dam.Td1_dk1, dam.Td1_st1, dam.Td2_dk1, dam.Td2_st1, dam.Td3_dk1, dam.Td3_st1, dam.Td1_dk2, dam.Td1_st2, dam.Td2_dk2, dam.Td2_st2, dam.Td3_dk2, dam.Td3_st2)
                    y = y + 1
                Next
                x = x + 1
            End If
        Next
        Me.Vecto.CommandAction.Zoom("e", "USER", "USER")
        Me.Vecto.CommandAction.Zoom("S", 1 / 1.1, "USER")
    End Sub
    Public Sub VeMatCatDoc(VDraw As Object, tendam As String, b As Double, h As Double, l As Integer, vtX As Integer, vtY As Integer, td1_dk1 As Integer, td1_st1 As Integer, td2_dk1 As Integer, td2_st1 As Integer, td3_dk1 As Integer, td3_st1 As Integer, td1_dk2 As Integer, td1_st2 As Integer, td2_dk2 As Integer, td2_st2 As Integer, td3_dk2 As Integer, td3_st2 As Integer)
        Dim a = 30

        Dim Poly As VDProLib5.vdPolyline
        Dim Line As VDProLib5.vdLine
        Dim myDim As VDProLib5.vdDimension
        Dim Text As VDProLib5.vdText
        Dim blog As VDProLib5.vdInsert
        'MC dọc
        Dim bc As Double = 300
#Region "Vẽ tiết diện cột"
        'Đường line bên trái cột ngoài cùng
        Line = Vecto.ActiveDocument.Entities.AddLine(New Object() {vtX + 0, vtY}, New Object() {vtX + 0, vtY - h - 2 * bc})
        Line.PenColor.ColorIndex = "7"
        'Lớp bê tông trên của dầm
        Poly = Vecto.ActiveDocument.Entities.AddPolyLine(New Object() {New Object() {vtX + bc, vtY}, New Object() {vtX + bc, vtY - bc},
                                                                    New Object() {vtX + bc + l, vtY - bc}, New Object() {vtX + bc + l, vtY}})
        Poly.PenColor.ColorIndex = 7
        'Đường line bên phải cột ngoài cùng
        Line = Vecto.ActiveDocument.Entities.AddLine(New Object() {vtX + bc * 2 + l, vtY}, New Object() {vtX + bc * 2 + l, vtY - 2 * bc - h})
        Poly.PenColor.ColorIndex = 7
        'Lớp bê tông dưới của dầm
        Poly = Vecto.ActiveDocument.Entities.AddPolyLine(New Object() {New Object() {vtX + bc, vtY - 2 * bc - h}, New Object() {vtX + bc, vtY - bc - h},
                                                                    New Object() {vtX + bc + l, vtY - bc - h}, New Object() {vtX + bc + l, vtY - 2 * bc - h}})
        Poly.PenColor.ColorIndex = 7
        'Break Line (trên cùng) của cột bên trái
        Poly = Vecto.ActiveDocument.Entities.AddPolyLine(New Object() {New Object() {vtX + -50, vtY}, New Object() {vtX + bc / 2 - 20, vtY},
                                                                    New Object() {vtX + bc / 2, vtY + 30}, New Object() {vtX + bc / 2, vtY - 30},
                                                                       New Object() {vtX + bc / 2 + 20, vtY}, New Object() {vtX + bc + 50, vtY}})
        Poly.PenColor.ColorIndex = 8
        'Break Line (dưới cùng) của cột bên trái
        Poly = Vecto.ActiveDocument.Entities.AddPolyLine(New Object() {New Object() {vtX + -50, vtY - h - 2 * bc}, New Object() {vtX + bc / 2 - 20, vtY - h - 2 * bc},
                                                                    New Object() {vtX + bc / 2, vtY - h - bc * 2 + 30}, New Object() {vtX + bc / 2, vtY - h - 2 * bc - 30},
                                                                     New Object() {vtX + bc / 2 + 20, vtY - h - 2 * bc}, New Object() {vtX + bc + 50, vtY - h - 2 * bc}})
        Poly.PenColor.ColorIndex = 8
        'Break Line (trên cùng) của cột bên phải
        Poly = Vecto.ActiveDocument.Entities.AddPolyLine(New Object() {New Object() {vtX + -50 + bc + l, vtY}, New Object() {vtX + bc + l + bc / 2 - 20, vtY},
                                                                    New Object() {vtX + bc + l + bc / 2, vtY + 30}, New Object() {vtX + bc + l + bc / 2, vtY - 30},
                                                                       New Object() {vtX + bc + l + bc / 2 + 20, vtY}, New Object() {vtX + bc + l + bc + 50, vtY}})
        Poly.PenColor.ColorIndex = 8
        'Break Line (dưới cùng) của cột bên phải
        Poly = Vecto.ActiveDocument.Entities.AddPolyLine(New Object() {New Object() {vtX + -50 + bc + l, vtY - h - 2 * bc}, New Object() {vtX + bc + l + bc / 2 - 20, vtY - h - 2 * bc},
                                                                   New Object() {vtX + bc + l + bc / 2, vtY - h - bc * 2 + 30}, New Object() {vtX + bc + l + bc / 2, vtY - h - 2 * bc - 30},
                                                                      New Object() {vtX + bc + l + bc / 2 + 20, vtY - h - 2 * bc}, New Object() {vtX + bc + l + bc + 50, vtY - h - 2 * bc}})
        Poly.PenColor.ColorIndex = 8
        Vecto.ActiveDocument.Entities.AddDimRotated(New Object() {vtX + 0, vtY - h - 2.5 * bc},
                                                    New Object() {vtX + bc, vtY - h - 2.5 * bc},
                                                     New Object() {vtX + bc / 2, vtY - h - 3 * bc}, 0)

        Vecto.ActiveDocument.Entities.AddDimRotated(New Object() {vtX + bc, vtY - h - 2.5 * bc},
                                                    New Object() {vtX + bc + l, vtY - h - 2.5 * bc},
                                                     New Object() {vtX + (bc + l) / 2, vtY - h - 3 * bc}, 0)

        Vecto.ActiveDocument.Entities.AddDimRotated(New Object() {vtX + bc + l, vtY - h - 2.5 * bc},
                                                    New Object() {vtX + bc + l + bc, vtY - h - 2.5 * bc},
                                                     New Object() {vtX + (bc + l + bc) / 2, vtY - h - 3 * bc}, 0)
#End Region
#Region "Vẽ thép dọc"
        ' Thép lớp trên
        Poly = Vecto.ActiveDocument.Entities.AddPolyLine(New Object() {New Object() {vtX + 0 + a + 50, vtY - bc - h + 50}, New Object() {vtX + 0 + a, vtY - bc - h},
                                                                      New Object() {vtX + 0 + a, vtY - bc - a}, New Object() {vtX + bc * 2 + l - a, vtY - bc - a},
                                                                      New Object() {vtX + bc * 2 + l - a, vtY - bc - h}, New Object() {vtX + bc * 2 + l - a - 50, vtY - bc - h + 50}})
        Poly.PenColor.ColorIndex = 1
        ' Thép lớp dưới
        Poly = Vecto.ActiveDocument.Entities.AddPolyLine(New Object() {New Object() {vtX + bc - 200 + 50, vtY - bc - h + a + 50}, New Object() {vtX + bc - 200, vtY - bc - h + a},
                                                                      New Object() {vtX + bc + l + 200, vtY - bc - h + a}, New Object() {vtX + bc + l + 200 - 50, vtY - bc - h + a + 50}})
        Poly.PenColor.ColorIndex = 1
#End Region
#Region "Cắt thép"
        If l > 6000 Then
            ''lớp trên trái
            If td1_st1 + td1_st2 > 2 Then
                Line = Vecto.ActiveDocument.Entities.AddLine(New Object() {Math.Round(vtX + (bc + l / 4), 0), vtY - bc - a}, New Object() {Math.Round(vtX + (bc + l / 4), 0) - 50, vtY - bc - a - 50})
                Line.PenColor.ColorIndex = 1
            End If
            'lớp trên phải
            If td3_st1 + td3_st2 > 2 Then
                Line = Vecto.ActiveDocument.Entities.AddLine(New Object() {vtX + bc + l - Math.Round((l / 4) / 100, 0) * 100, vtY - bc - a}, New Object() {vtX + bc + l - Math.Round((l / 4) / 100, 0) * 100 + 50, vtY - bc - a - 50})
                Line.PenColor.ColorIndex = 1
            End If
        End If
        'lớp dưới
        If td2_st1 + td2_st2 > 4 Then
            Line = Vecto.ActiveDocument.Entities.AddLine(New Object() {vtX + Math.Round((bc + l / 6) / 100, 0) * 100, vtY - bc - h + a}, New Object() {vtX + Math.Round((bc + l / 6) / 100, 0) * 100 + 50, vtY - bc - h + a + 50})
            Line.PenColor.ColorIndex = 1
            Line = Vecto.ActiveDocument.Entities.AddLine(New Object() {vtX + Math.Round((bc + l - l / 6) / 100, 0) * 100, vtY - bc - h + a}, New Object() {vtX + Math.Round((bc + l - l / 6) / 100, 0) * 100 - 50, vtY - bc - h + a + 50})
            Line.PenColor.ColorIndex = 1
        End If
#End Region
#Region "Ghi chú thép dọc"
        'Lớp trên
        Line = Vecto.ActiveDocument.Entities.AddLine(New Object() {vtX + bc + 300, vtY - bc - a}, New Object() {vtX + bc + 300, vtY - bc - a + 200})
        Line.PenColor.ColorIndex = 8
        Line = Vecto.ActiveDocument.Entities.AddLine(New Object() {vtX + bc + 300, vtY - bc - a + 200}, New Object() {vtX + bc + 600, vtY - bc - a + 200})
        Line.PenColor.ColorIndex = 8
        If td1_st1 = 0 Then
            Text = Vecto.ActiveDocument.Entities.AddText("2%%20", New Object() {vtX + bc + 300, vtY - bc - a + 200}, 100)
        Else
            Text = Vecto.ActiveDocument.Entities.AddText(td1_st1 & "%%C" & td1_dk1, New Object() {vtX + bc + 300, vtY - bc - a + 200}, 100)
        End If

        Line = Vecto.ActiveDocument.Entities.AddLine(New Object() {vtX + bc + l - 300, vtY - bc - a}, New Object() {vtX + bc + l - 300, vtY - bc - a + 200})
        Line.PenColor.ColorIndex = 8
        Line = Vecto.ActiveDocument.Entities.AddLine(New Object() {vtX + bc + l - 300, vtY - bc - a + 200}, New Object() {vtX + bc + l - 600, vtY - bc - a + 200})
        Line.PenColor.ColorIndex = 8
        If td3_st1 = 0 Then
            Text = Vecto.ActiveDocument.Entities.AddText("2%%20", New Object() {vtX + bc + l - 600, vtY - bc - a + 200}, 100)
        Else
            Text = Vecto.ActiveDocument.Entities.AddText(td3_st1 & "%%C" & td3_dk1, New Object() {vtX + bc + l - 600, vtY - bc - a + 200}, 100)
        End If

        'Lớp dưới
        Line = Vecto.ActiveDocument.Entities.AddLine(New Object() {vtX + bc + l / 2, vtY - bc - h}, New Object() {vtX + bc + l / 2, vtY - bc - h - 200})
        Line.PenColor.ColorIndex = 8
        Line = Vecto.ActiveDocument.Entities.AddLine(New Object() {vtX + bc + l / 2, vtY - bc - h - 200}, New Object() {vtX + bc + l / 2 + 300, vtY - bc - h - 200})
        Line.PenColor.ColorIndex = 8
        If td2_st1 = 0 Then
            Text = Vecto.ActiveDocument.Entities.AddText("2%%C20", New Object() {vtX + bc + l / 2, vtY - bc - h - 200}, 100)
        Else
            Text = Vecto.ActiveDocument.Entities.AddText(td2_st1 & "%%C" & td2_dk1, New Object() {vtX + bc + l / 2, vtY - bc - h - 200}, 100)
        End If

#End Region
#Region "Text mặt cắt"
        Text = Vecto.ActiveDocument.Entities.AddText("1|", New Object() {vtX + bc + 100, vtY - bc + 50}, 100)
        Text.PenColor.ColorIndex = 2
        Text = Vecto.ActiveDocument.Entities.AddText("1|", New Object() {vtX + bc + 100, vtY - bc - h - 200}, 100)
        Text.PenColor.ColorIndex = 2

        Text = Vecto.ActiveDocument.Entities.AddText("2|", New Object() {vtX + bc + l / 2 - 100, vtY - bc + 50}, 100)
        Text.PenColor.ColorIndex = 2
        Text = Vecto.ActiveDocument.Entities.AddText("2|", New Object() {vtX + bc + l / 2 - 100, vtY - bc - h - 200}, 100)
        Text.PenColor.ColorIndex = 2

        Text = Vecto.ActiveDocument.Entities.AddText("3|", New Object() {vtX + bc + l - 200, vtY - bc + 50}, 100)
        Text.PenColor.ColorIndex = 2
        Text = Vecto.ActiveDocument.Entities.AddText("3|", New Object() {vtX + bc + l - 200, vtY - bc - h - 200}, 100)
        Text.PenColor.ColorIndex = 2
#End Region
#Region "Ghi chú tên dầm"
        Text = Vecto.ActiveDocument.Entities.AddText(tendam, New Object() {vtX + l / 2 - 300, vtY + bc * 0.6}, 150)
        Text.PenColor.ColorIndex = 2
#End Region
#Region "Vẽ thép đai"
        For i = 50 To l / 4 Step 300
            Line = Vecto.ActiveDocument.Entities.AddLine(New Object() {vtX + bc + i, vtY - bc - a}, New Object() {vtX + bc + i, vtY - h - bc + a})
            Line.PenColor.ColorIndex = "3"
        Next
        For i = l / 4 To 3 * l / 4 Step 200
            Line = Vecto.ActiveDocument.Entities.AddLine(New Object() {vtX + bc + i, vtY - bc - a}, New Object() {vtX + bc + i, vtY - h - bc + a})
            Line.PenColor.ColorIndex = "3"
            myDim = Vecto.ActiveDocument.Entities.AddDimAligned(New Object() {vtX + bc, vtY - bc + 100},
                                                           New Object() {vtX + Math.Round((bc + l / 4) / 100, 0) * 100, vtY - bc + 100}, New Object() {vtX + bc, vtY - bc + 300})
        Next
        For i = 3 * l / 4 To l Step 300
            Line = Vecto.ActiveDocument.Entities.AddLine(New Object() {vtX + bc + i, vtY - bc - a}, New Object() {vtX + bc + i, vtY - h - bc + a})
            Line.PenColor.ColorIndex = "3"
            myDim = Vecto.ActiveDocument.Entities.AddDimAligned(New Object() {vtX + bc + l, vtY - bc + 100},
                                                          New Object() {vtX + bc + l - Math.Round((l / 4) / 100, 0) * 100, vtY - bc + 100}, New Object() {vtX + bc, vtY - bc + 300})
        Next
#End Region
#Region "Dim thép đai"
        myDim = Vecto.ActiveDocument.Entities.AddDimAligned(New Object() {vtX + bc, vtY - bc - h - 100}, New Object() {vtX + bc + l / 4, vtY - bc - h - 100}, New Object() {vtX + bc, vtY - bc - h - 300})
        Text = Vecto.ActiveDocument.Entities.AddText("(" & "%%c8a300)", New Object() {vtX + bc + l / 8 - 100, vtY - bc - h - 300}, 50)
        Text.PenColor.ColorIndex = "3"

        myDim = Vecto.ActiveDocument.Entities.AddDimAligned(New Object() {vtX + bc + l / 4, vtY - bc - h - 100}, New Object() {vtX + bc + 3 * l / 4, vtY - bc - h - 100}, New Object() {vtX + bc, vtY - bc - h - 300})
        Text = Vecto.ActiveDocument.Entities.AddText("(" & "%%c8a200)", New Object() {bc + l / 2 - 100, vtY - bc - h - 300}, 50)
        Text.PenColor.ColorIndex = "3"

        myDim = Vecto.ActiveDocument.Entities.AddDimAligned(New Object() {vtX + bc + 3 * l / 4, vtY - bc - h - 100}, New Object() {vtX + bc + l, vtY - bc - h - 100}, New Object() {vtX + bc, vtY - bc - h - 300})
        Text = Vecto.ActiveDocument.Entities.AddText("(" & "%%c8a300)", New Object() {bc + 7 * l / 8 - 100, vtY - bc - h - 300}, 50)
        Text.PenColor.ColorIndex = "3"
#End Region
    End Sub
    Public Sub VeMatCat(NameMC As String, tendam As String, VDraw As Object, b As Double, h As Double, vtX As Integer, vtY As Integer, soThepLoai1 As Integer, soThepLoai2 As Integer, duongKinhLoai1 As Integer, duongKinhLoai2 As Integer, soThepLoai1_LopDuoi As Integer, soThepLoai2_LopDuoi As Integer, duongKinhLoai1_LopDuoi As Integer, duongKinhLoai2_LopDuoi As Integer, ThepDai As Integer, KhoangCachDai As Integer)
        'MC đầu dầm
        'Vẽ thép hai lớp      
        Dim Poly As VDProLib5.vdPolyline
        Dim Line As VDProLib5.vdLine
        Dim myDim As VDProLib5.vdDimension
        Dim Text As VDProLib5.vdText
        Dim blog As VDProLib5.vdInsert
        'mc 
#Region " Vẽ tiết diện thép"
        Dim a = 30
        Dim hf = 140
        ' Đường line bên trên
        Line = Vecto.ActiveDocument.Entities.AddLine(New Object() {vtX + -b / 3, vtY + h}, New Object() {vtX + b + b / 3, vtY + h})
        Line.PenColor.ColorIndex = "7"
        ' Đường bao xung quanh
        Poly = Vecto.ActiveDocument.Entities.AddPolyLine(New Object() {New Object() {vtX + -b / 3, vtY + h - hf}, New Object() {vtX + 0, vtY + h - hf},
                                                                        New Object() {vtX, vtY + 0}, New Object() {vtX + b, vtY + 0},
                                                                        New Object() {vtX + b, vtY + h - hf}, New Object() {vtX + b + b / 3, vtY + h - hf}})
        Poly.PenColor.ColorIndex = "7"
        ' Breakline bên trái
        Poly = Vecto.ActiveDocument.Entities.AddPolyLine(New Object() {New Object() {vtX + -b / 3, vtY + h + 20}, New Object() {vtX + -b / 3, vtY + h}, New Object() {vtX + -b / 3, vtY + h - hf / 2 + 10},
                                                                          New Object() {vtX + -b / 3 + 10, vtY + h - hf / 2 + 10}, New Object() {vtX + -b / 3 - 10, vtY + h - hf / 2 - 10},
                                                                          New Object() {vtX + -b / 3, vtY + h - hf / 2 - 10}, New Object() {vtX + -b / 3, vtY + h - hf}, New Object() {vtX + -b / 3, vtY + h - hf - 20}})

        Poly.PenColor.ColorIndex = "8"
        ' Breakline bên phải
        Poly = Vecto.ActiveDocument.Entities.AddPolyLine(New Object() {New Object() {vtX + b + b / 3, vtY + h + 20}, New Object() {vtX + b + b / 3, vtY + h}, New Object() {vtX + b + b / 3, vtY + h - hf / 2 + 10},
                                                                          New Object() {vtX + b + b / 3 + 10, vtY + h - hf / 2 + 10}, New Object() {vtX + b + b / 3 - 10, vtY + h - hf / 2 - 10},
                                                                          New Object() {vtX + b + b / 3, vtY + h - hf / 2 - 10}, New Object() {vtX + b + b / 3, vtY + h - hf}, New Object() {vtX + b + b / 3, vtY + h - hf - 20}})
        Poly.PenColor.ColorIndex = "8"
        ' Ghi chú tầng
        Text = Vecto.ActiveDocument.Entities.AddText(tendam, New Object() {vtX + -b / 3, vtY + h, vtX + b + b / 3, vtY + h}, 150)
        Text.PenColor.ColorIndex = 2
#End Region
#Region "Vẽ  thép đai"
        Poly = Vecto.ActiveDocument.Entities.AddPolyLine(New Object() {New Object() {vtX + a, vtY + a}, New Object() {vtX + b - a, vtY + a},
                                                                        New Object() {vtX + b - a, vtY + h - a}, New Object() {vtX + a, vtY + h - a},
                                                                        New Object() {vtX + a, vtY + a}})
        Poly.PenColor.ColorIndex = "1"
#End Region
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Vecto.ActiveDocument.Open(Application.StartupPath + "\Template\template.dxf", 0, 0)
        Me.Vecto.ActiveDocument.Entities.EraseAll()
        Dim x As Integer
        Dim y As Integer
        y = 0
        For Each tang As Cls_tang In congtrinh.Danhsachtang

            If tang.Danhsach_Dam.Count > 0 Then

                For Each dam As Cls_dam In tang.Danhsach_Dam
                    VeMatCat("1-1", dam.Tendam, Vecto, dam.B * 1000, dam.H * 1000, 0, -1300 * y, dam.Td1_st1, dam.Td1_st2, dam.Td1_dk1, dam.Td1_dk2, dam.Td2_st1, dam.Td2_st2, dam.Td2_dk1, dam.Td2_dk2, "8", 200)
                    VeMatCat("2-2", dam.Tendam, Vecto, dam.B * 1000, dam.H * 1000, 2000, -1300 * y, dam.Td1_st1, dam.Td1_st2, dam.Td1_dk1, dam.Td1_dk2, dam.Td2_st1, dam.Td2_st2, dam.Td2_dk1, dam.Td2_dk2, "8", 200)
                    VeMatCat("3-3", dam.Tendam, Vecto, dam.B * 1000, dam.H * 1000, 4000, -1300 * y, dam.Td3_st1, dam.Td3_st2, dam.Td3_dk1, dam.Td3_dk2, dam.Td2_st1, dam.Td2_st2, dam.Td2_dk1, dam.Td2_dk2, "8", 200)
                    y = y + 1
                Next

                x = x + 1
            End If
        Next
        Me.Vecto.CommandAction.Zoom("e", "USER", "USER")
        Me.Vecto.CommandAction.Zoom("S", 1 / 1.1, "USER")
    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        SaveFileDialog1.Filter = "Drawing (*.dwg)|*.dwg|All Files (*.*)|*.*"
        If SaveFileDialog1.ShowDialog = DialogResult.OK Then
            Me.Vecto.ActiveDocument.SaveAs(SaveFileDialog1.FileName, 2007)
        End If
    End Sub
End Class