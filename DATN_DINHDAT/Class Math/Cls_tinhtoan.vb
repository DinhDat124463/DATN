Imports System.IO
Module Cls_tinhtoan
    Dim μ As Double
    Dim M As Double
    Dim b As Double
    Dim h As Double
    Dim h0 As Double
    Dim KieuTietDienTinhToan As String
    Dim ViTriTrucTrungHoa As String
    Dim a As Double
    Dim am As Double
    Dim Rb As Double
    Dim Rs As Double
    Dim [As] As Double
    Dim L As Double
    Dim bf As Double
    Dim hf As Double
    Public Function TinhToan(datanoiluc As DataTable, datatietdien As DataTable)
        Dim dientichthep As New DataTable()
        dientichthep.Columns.Add("Tầng", GetType(String))
        dientichthep.Columns.Add("Tên dầm", GetType(String))
        dientichthep.Columns.Add("Vị trí", GetType(Double))
        dientichthep.Columns.Add("V2", GetType(Double))
        dientichthep.Columns.Add("M3", GetType(Double))
        dientichthep.Columns.Add("Tiết diện đi qua", GetType(String))
        dientichthep.Columns.Add("Astt", GetType(Double))
        dientichthep.Columns.Add("μ(%)", GetType(String))
        Dim filePath As String = $"{Application.StartupPath}\Template\Vatlieu.txt"
        For Each row As DataRow In datanoiluc.Rows
            For Each tietdien As DataRow In datatietdien.Rows
                If row("Tên dầm").ToString().Contains(tietdien("Tên dầm").ToString()) Then
                    Dim newRow As DataRow = dientichthep.NewRow()
                    newRow("Tầng") = row("Tầng").ToString()
                    newRow("Tên dầm") = row("Tên dầm").ToString()
                    newRow("Vị trí") = Convert.ToDouble(row("Vị trí").ToString())
                    newRow("V2") = Math.Round(Convert.ToDouble(row("V2").ToString()), 3)
                    newRow("M3") = Math.Round(Convert.ToDouble(row("M3").ToString()), 3)
                    a = 3
                    ' a = 0.1 * Convert.ToDouble(tietdien("Chiều cao")) * 100
                    h = Convert.ToDouble(tietdien("Chiều cao")) * 100
                    h0 = (h - a)
                    ' Mở tệp để đọc
                    Using reader As New StreamReader(filePath)
                        Rb = ReadSpecificLine(reader, 3)
                        Rs = ReadSpecificLine(reader, -3 + 8)
                    End Using

                    b = Convert.ToDouble(tietdien("Bề rộng")) * 100
                    hf = 140
                    If Convert.ToDouble(row("M3")) < 0 Then
                        M = row("M3") * 1000
                        KieuTietDienTinhToan = "Tiết diện chữ nhật"
                        [As] = DienTichThepTietDienChuNhat(b)
                        μ = ([As] / (b * h0)) * 100
                        newRow("Tiết diện đi qua") = KieuTietDienTinhToan
                        newRow("Astt") = [As]
                        newRow("μ(%)") = Math.Round(μ, 3) & "%"
                    Else
                        bf = b + 2 * DoVuonCanh()
                        M = row("M3") * 1000
                        KieuTietDienTinhToan = "Tiết diện chữ T"
                        ViTriTrucTrungHoa = "Đi qua sườn"
                        [As] = DienTichThepTietDienChuT()
                        μ = ([As] / (b * h0)) * 100
                        newRow("Tiết diện đi qua") = KieuTietDienTinhToan
                        newRow("Astt") = [As]
                        newRow("μ(%)") = Math.Round(μ, 3) & "%"
                        ' End If
                    End If
                    dientichthep.Rows.Add(newRow)
                End If
            Next
        Next
        Return dientichthep
    End Function
    ' Hàm tính độ vuồn cạnh
    Private Function DoVuonCanh() As Double
        If hf >= 0.1 * h Then
            ' Nếu chiều cao đối với nhịp là lớn hơn hoặc bằng 10% chiều cao của dầm
            Dim res As Double = L / 6 ' Giảm chiều rộng cạnh vuông
            Return Math.Floor(res / 10) * 10
        Else
            ' Nếu chiều cao đối với nhịp là nhỏ hơn 10% chiều cao của dầm
            Dim res As Double = Math.Min(L / 6, 6 * hf) ' Giảm chiều rộng cạnh vuông theo công thức khác
            Return Math.Floor(res / 10) * 10
        End If
    End Function

    ' Hàm tính diện tích thép cho tiết diện chữ nhật
    Private Function DienTichThepTietDienChuNhat(_b As Double) As Double
        Dim h0 As Double = h - a

        ' Tính hệ số am
        am = Math.Abs(M) / (Rb * _b * h0 * h0)

        ' Tính hệ số zeta
        Dim zeta As Double = (1 + Math.Sqrt(1 - 2 * am)) / 2

        ' Tính diện tích thép
        Return Math.Round(Math.Abs(M) / (Rs * zeta * h0), 3)
    End Function

    ' Hàm tính diện tích thép cho tiết diện chữ T
    Private Function DienTichThepTietDienChuT() As Double
        Dim h0 As Double = h - a

        ' Tính hệ số am
        am = (Math.Abs(M) - Rb * (bf - b) * hf * (h0 - 0.5 * hf)) / (Rb * b * h0 * h0)

        ' Tính giá trị E dựa trên hệ số am
        Dim E As Double = Esp(am)

        ' Tính diện tích thép cho tiết diện chữ T
        Return Math.Round(Rb / Rs * (E * b * h0 + (bf - b) * hf), 3)
    End Function
    ' Hàm tính giá trị E dựa trên hệ số am
    Public Function Er(Rb As Double, Rs As Double) As Double
        Dim w As Double = 0.85 - 0.008 * Rb
        Dim ErResult As Double = w / (1 + (Rs / 400) * (1 - w / 1.1))
        Return Math.Round(ErResult, 3)
    End Function
    Public Function Esp(am As Double) As Double
        Return (1 - Math.Sqrt(1 - 2 * am))
    End Function
    Public Function Mf(Rb As Double, bf As Double, hf As Double, h0 As Double) As Double
        Return Rb * bf * hf * (h0 - 0.5 * hf)
    End Function
    Function ReadSpecificLine(reader As StreamReader, lineNumber As Integer) As String
        ' Duyệt qua từng dòng cho đến khi đến dòng cần đọc
        For i As Integer = 1 To lineNumber - 1
            If reader.ReadLine() Is Nothing Then
                Return ""
            End If
        Next
        ' Đọc dòng cần đọc
        Return reader.ReadLine()
    End Function
End Module
