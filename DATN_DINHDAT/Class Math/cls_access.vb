Imports System.Data.OleDb
Imports System.Data
Imports DevExpress.Xpo.DB.Helpers
Imports DevExpress.XtraEditors
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar

Module cls_access
    Public Function Access(path As String, table_name As String, column_name As String) As List(Of String)
        Dim result As New List(Of String)

        Dim connectionString As String = $"Provider=Microsoft.Jet.OLEDB.4.0;Data Source={path};Persist Security Info=False;"

        ' Modify the query to select specific columns based on user input
        Dim query As String = $"SELECT [{column_name}] FROM [{table_name}]"

        Using connection As New OleDbConnection(connectionString)
            connection.Open()

            Using command As New OleDbCommand(query, connection)
                Using reader As OleDbDataReader = command.ExecuteReader()
                    While reader.Read()
                        If Not reader.IsDBNull(0) Then
                            Dim value As Object = reader.GetValue(0)

                            If TypeOf value Is String Then
                                ' Ép kiểu nếu kiểu là String
                                result.Add(DirectCast(value, String))
                            ElseIf TypeOf value Is Double Then
                                ' Ép kiểu nếu kiểu là Double
                                result.Add(DirectCast(value, Double).ToString())
                            Else
                                ' Xử lý kiểu dữ liệu khác nếu cần
                                ' Nếu kiểu dữ liệu không khớp với String hoặc Double, bạn có thể thêm xử lý ở đây
                            End If
                        Else
                            ' Xử lý giá trị null nếu cần
                            result.Add("Value is null")
                        End If
                    End While

                End Using
            End Using
        End Using

        Return result
    End Function
    Public Function Access_Tang(path As String) As List(Of Cls_congtrinh)
        Dim Tang As New List(Of Cls_congtrinh)

        ' Lấy giá trị từ cơ sở dữ liệu - Giả sử hàm Access trả về một danh sách các giá trị từ cột "Story"
        Dim tenTangList As List(Of String) = Access(path, "Centers Of Mass And Rigidity", "Story")

        ' Duyệt qua danh sách các tên tầng và thêm chúng vào đối tượng Cls_congtrinh
        For Each tenTang As String In tenTangList
            Dim _Tang = New Cls_congtrinh() ' Tạo mới một đối tượng _Tang cho mỗi tầng
            Dim tangItem As New Cls_tang()
            tangItem.TenTang = tenTang
            _Tang.Danhsachtang.Add(tangItem)
            congtrinh.Danhsachtang.Add(tangItem)
        Next
        Return Tang
    End Function
    Public Function Access_Dam(path As String) As List(Of Cls_dam)
        Dim Dam As New List(Of Cls_dam)

        'Tên dầm
        Dim TenDam_List As List(Of String) = Access(path, "Element Forces - Beams", "Unique Name")
        Dim Taitrong_list As List(Of String) = Access(path, "Element Forces - Beams", "Output Case")
        Dim Q_list As List(Of String) = Access(path, "Element Forces - Beams", "V2")
        Dim Mmax_list As List(Of String) = Access(path, "Element Forces - Beams", "M3")
        For i = 0 To Taitrong_list.Count - 1
            Dim DamItem = New Cls_dam()

            ' Tên dầm
            DamItem.Tendam = TenDam_List(i)

            ' Tải trọng
            DamItem.TaiTrong = Taitrong_list(i)

            ' Lực cắt
            DamItem.Qmax = Q_list(i)

            DamItem.Mmax = Mmax_list(i)

            Dam.Add(DamItem)
        Next

        Return Dam
    End Function
    Public Function Read_Access(path As String) As DataTable
        Dim connectionString As String = $"Provider=Microsoft.Jet.OLEDB.4.0;Data Source={path};Persist Security Info=False;"
        Dim data As New DataTable

        Using connection As New OleDbConnection(connectionString)
            connection.Open()

            Dim sqlQuery As String = "SELECT [Story], [UniqueName],[Design Type], [Length],[Design Section] FROM [Frame Assignments - Summary];"
            Dim query As String = "SELECT [Frame Section Property Definitions - Concrete Rectangular].[Name],
                               [Frame Section Property Definitions - Concrete Rectangular].[Depth],
                               [Frame Section Property Definitions - Concrete Rectangular].[Width]
                  FROM [Frame Section Property Definitions - Concrete Rectangular]
                  INNER JOIN [Frame Assignments - Summary] ON [Frame Assignments - Summary].[Design Section] = [Frame Section Property Definitions - Concrete Rectangular].[Name]"

            Using command As New OleDbCommand(sqlQuery, connection)
                Using reader As OleDbDataReader = command.ExecuteReader()
                    ' Tạo cột trong DataTable
                    data.Columns.Add("Tầng", GetType(String))
                    data.Columns.Add("Tên dầm", GetType(String))
                    data.Columns.Add("Design Type", GetType(String))
                    data.Columns.Add("Chiều dài dầm", GetType(Double))
                    data.Columns.Add("Design Section", GetType(String))
                    data.Columns.Add("Bề rộng", GetType(Double)) ' Thêm cột mới từ truy vấn thứ hai
                    data.Columns.Add("Chiều cao", GetType(Double)) ' Thêm cột mới từ truy vấn thứ hai

                    While reader.Read()
                        If reader.GetString(2) = "Beam" Then
                            Dim row As DataRow = data.NewRow()
                            row("Tầng") = reader.GetString(0)
                            row("Tên dầm") = reader.GetString(1)
                            row("Chiều dài dầm") = reader.GetDouble(3)
                            row("Design Section") = reader.GetString(4)
                            data.Rows.Add(row)
                        End If
                    End While
                End Using
            End Using

            ' Thực hiện truy vấn thứ hai và thêm dữ liệu vào DataTable
            Using command As New OleDbCommand(query, connection)
                Using reader As OleDbDataReader = command.ExecuteReader()
                    While reader.Read()
                        ' Tìm hàng tương ứng trong DataTable và thêm dữ liệu mới
                        Dim hang_tuongung() As DataRow = data.Select($"[Design Section] = '{reader.GetString(0)}'")
                        For Each hang As DataRow In hang_tuongung
                            hang("Bề rộng") = reader.GetDouble(1)
                            hang("Chiều cao") = reader.GetDouble(2)
                        Next
                    End While
                End Using
            End Using
        End Using
        data.Columns.Remove("Design Type")
        data.Columns.Remove("Design Section")
        Return data
    End Function
    Public Function Unit(path As String) As String
        Dim result As String = String.Empty
        Dim connectionString As String = $"Provider=Microsoft.Jet.OLEDB.4.0;Data Source={path};Persist Security Info=False;"

        Using connection As New OleDbConnection(connectionString)
            connection.Open()

            Dim sqlQuery As String = "SELECT [CurrUnits] FROM [Program Control]"

            Using command As New OleDbCommand(sqlQuery, connection)
                Using reader As OleDbDataReader = command.ExecuteReader()
                    ' Kiểm tra xem có ít nhất một dòng dữ liệu được trả về không
                    If reader.Read() Then
                        ' Đọc giá trị từ cột "CurrUnits" và gán cho biến result
                        result = If(Not reader.IsDBNull(0), reader.GetString(0), String.Empty)
                    End If
                End Using
            End Using
        End Using

        ' Trả về giá trị của biến result
        Return result
    End Function
    Private Function Value_Max(tang As String, hoatTai As String) As Double
        Dim connectionString As String = "Your Connection String"
        Dim query As String = $"SELECT MAX(Column12) AS MaxValue " &
                              $"FROM YourTableName " &
                              $"WHERE Column1 = '{tang}' " &
                              $"AND Column4 = '{hoatTai}' " &
                              "AND Column6 IS NOT NULL " &
                              "AND Column6 > 0;"

        Using connection As New OleDbConnection(connectionString)
            connection.Open()

            Using command As New OleDbCommand(query, connection)
                Using reader As OleDbDataReader = command.ExecuteReader()
                    If reader.Read() Then
                        Return If(reader("MaxValue") IsNot DBNull.Value, Convert.ToDouble(reader("MaxValue")), 0)
                    Else
                        MessageBox.Show("No data found.")
                        Return 0
                    End If
                End Using
            End Using
        End Using
    End Function
End Module
