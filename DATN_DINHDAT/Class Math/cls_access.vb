Imports System.Data.OleDb
Imports System.Data

Module cls_access
    Public Function Read_Access(path As String, table_name As String) As DataTable
        Dim dataTable As New DataTable()

        Dim connectionString As String = $"Provider=Microsoft.Jet.OLEDB.4.0;Data Source={path};Persist Security Info=False;"

        Dim query As String = $"SELECT * FROM [{table_name}]"


        Using connection As New OleDbConnection(connectionString)
            connection.Open()

            Using command As New OleDbCommand(query, connection)
                Using reader As OleDbDataReader = command.ExecuteReader()
                    ' Tạo các cột cho DataTable tương ứng với cấu trúc của bảng
                    For i As Integer = 0 To reader.FieldCount - 1
                        dataTable.Columns.Add(reader.GetName(i))
                    Next

                    ' Đọc dữ liệu từ cột cụ thể và thêm vào DataTable
                    While reader.Read()
                        Dim newRow As DataRow = dataTable.NewRow()
                        For i As Integer = 0 To reader.FieldCount - 1
                            newRow(i) = reader(i)
                        Next
                        dataTable.Rows.Add(newRow)
                    End While
                End Using
            End Using
        End Using

        Return dataTable
    End Function
End Module
