Imports System.Data.OleDb
Imports System.Data
Imports DevExpress.Xpo.DB.Helpers
Imports DevExpress.XtraEditors
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar
Imports System.Text
Imports DevExpress.Internal.WinApi.Windows.UI.Notifications

Module cls_access
    ' Đọc thông số dầm
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
    ' Đọc đơn vị xuất từ etap ra 
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
    Public Function Betong(path As String) As String
        Dim result As New StringBuilder()
        Dim connectionString As String = $"Provider=Microsoft.Jet.OLEDB.4.0;Data Source={path};Persist Security Info=False;"

        Using connection As New OleDbConnection(connectionString)
            connection.Open()

            Dim sqlQuery As String = "SELECT [Material] FROM [Material List by Object Type] WHERE [Object Type] = 'beam'"

            Using command As New OleDbCommand(sqlQuery, connection)
                Using reader As OleDbDataReader = command.ExecuteReader()
                    While reader.Read()
                        result.Append(reader("Material").ToString()).Append(",")
                    End While
                End Using
            End Using
        End Using

        ' Remove the trailing comma if there are values
        If result.Length > 0 Then
            result.Length -= 1
        End If

        Return result.ToString()
    End Function


    Public Function Noiluc(path As String) As DataTable
        Dim result As New DataTable()
        Dim connectionString As String = $"Provider=Microsoft.Jet.OLEDB.4.0;Data Source={path};Persist Security Info=False;"

        Using connection As New OleDbConnection(connectionString)
            connection.Open()

            Dim sqlQuery As String = "SELECT [Story],[Unique Name],[Output Case],[Station],[V2],[M3] FROM [Element Forces - Beams]"

            Using command As New OleDbCommand(sqlQuery, connection)
                Using adapter As New OleDbDataAdapter(command)
                    adapter.Fill(result)
                End Using
            End Using
        End Using
        Return result
    End Function
    Public Function Loc_Noiluc(path As String) As DataTable
        ' Tạo DataTable để lưu trữ kết quả truy vấn
        Dim result As New DataTable()

        ' Chuỗi kết nối đến tệp cơ sở dữ liệu Jet (Access)
        Dim connectionString As String = $"Provider=Microsoft.Jet.OLEDB.4.0;Data Source={path};Persist Security Info=False;"

        ' Mở kết nối đến cơ sở dữ liệu
        Using connection As New OleDbConnection(connectionString)
            connection.Open()

            ' Câu truy vấn SQL để lấy thông tin từ các bảng
            Dim sqlQuery As String = "SELECT [Beam Object Connectivity].[Unique Name] AS ConnectivityName, [Beam Object Connectivity].Length, [Element Forces - Beams].[Unique Name] AS BeamName " &
                         "FROM [Beam Object Connectivity] INNER JOIN [Element Forces - Beams] ON [Beam Object Connectivity].[Unique Name] = [Element Forces - Beams].[Unique Name];"

            ' Tạo đối tượng OleDbCommand để thực hiện câu truy vấn
            Using command As New OleDbCommand(sqlQuery, connection)
                ' Sử dụng OleDbDataAdapter để điền kết quả vào DataTable
                Using adapter As New OleDbDataAdapter(command)
                    adapter.Fill(result)
                End Using
            End Using
        End Using

        ' Trả về DataTable chứa kết quả truy vấn
        Return result
    End Function

    Public Function List(path As String, column As String, table As String) As List(Of String)
        Dim result As New List(Of String)
        Dim connectionString As String = $"Provider=Microsoft.Jet.OLEDB.4.0;Data Source={path};Persist Security Info=False;"

        Using connection As New OleDbConnection(connectionString)
            connection.Open()

            Dim sqlQuery As String = $"SELECT [{column}] FROM [{table}]"

            Using command As New OleDbCommand(sqlQuery, connection)
                Using reader As OleDbDataReader = command.ExecuteReader()
                    While reader.Read()
                        ' Assuming "Output Case" is a string; adjust type if needed
                        result.Add(reader(column).ToString())
                    End While
                End Using
            End Using
        End Using

        Return result
    End Function

End Module
