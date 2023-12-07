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

    Public Function Read_Access_ToList(path As String, table_name As String, columnName As String) As List(Of String)

        Dim connectionString As String = $"Provider=Microsoft.Jet.OLEDB.4.0;Data Source={path};Persist Security Info=False;"

        Dim data As New List(Of String)

        Using connection As New OleDbConnection(connectionString)
            connection.Open()

            ' Truy vấn SQL để lấy dữ liệu từ cột cụ thể trong bảng
            Dim sqlQuery As String = $"SELECT [{columnName}] FROM [{table_name}];"

            Using command As New OleDbCommand(sqlQuery, connection)
                Using reader As OleDbDataReader = command.ExecuteReader()
                    ' Đọc dữ liệu từ cột cụ thể
                    While reader.Read()
                        data.Add(reader.GetString(0))
                    End While
                End Using
            End Using
        End Using
        Return data
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
