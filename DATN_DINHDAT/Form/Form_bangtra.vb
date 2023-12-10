Imports System.IO

Public Class Form_bangtra
    Private TTGH1 As DataTable
    Private TTGH2 As DataTable
    Private Tietdienthep As DataTable
    Private Khoangcach As DataTable
    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged
        If ListBox1.SelectedIndex = 0 Then
            dgv_thuvien.DataSource = TTGH1
        ElseIf ListBox1.SelectedIndex = 1 Then
            dgv_thuvien.DataSource = TTGH2
        ElseIf ListBox1.SelectedIndex = 2 Then
            dgv_thuvien.DataSource = Tietdienthep
        ElseIf ListBox1.SelectedIndex = 3 Then
            dgv_thuvien.DataSource = Khoangcach
        End If
    End Sub

    Private Sub Form_bangtra_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
        Dim path_TTGH1 As String = $"{Application.StartupPath}\Template\TTGH1.txt"
        Dim path_TTGH2 As String = $"{Application.StartupPath}\Template\TTGH2.txt"
        Dim path_tietdienthep As String = $"{Application.StartupPath}\Template\Tietdienthep.txt"
        Dim path_khoangcach As String = $"{Application.StartupPath}\Template\Khoangcach.txt"
        TTGH1 = Read_txt(path_TTGH1)
        TTGH2 = Read_txt(path_TTGH2)
        Tietdienthep = Read_txt(path_tietdienthep)
        Khoangcach = Read_txt(path_khoangcach)
    End Sub
    Private Function Read_txt(path As String) As DataTable
        If File.Exists(path) Then
            Dim dataTable As New DataTable()
            Using reader As New StreamReader(path)
                If Not reader.EndOfStream Then
                    Dim headerLine As String = reader.ReadLine()
                    Dim columnNames As String() = headerLine.Split("@"c)
                    For Each columnName As String In columnNames
                        dataTable.Columns.Add(columnName, GetType(String))
                    Next
                    Do While Not reader.EndOfStream
                        Dim line As String = reader.ReadLine()
                        Dim values As String() = line.Split("@"c)
                        Dim newRow As DataRow = dataTable.NewRow()
                        For i As Integer = 0 To Math.Min(values.Length - 1, dataTable.Columns.Count - 1)
                            newRow(i) = values(i)
                        Next
                        dataTable.Rows.Add(newRow)
                    Loop
                End If
            End Using
            Return dataTable
        Else
            Return Nothing
        End If
    End Function
End Class