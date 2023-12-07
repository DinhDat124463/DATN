Imports System.Data.OleDb
Imports System.IO
Public Class Form_Main
    Private Sub BarButtonItem8_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem8.ItemClick

    End Sub

    Private Sub BarButtonItem9_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem9.ItemClick

    End Sub

    Private Sub Form_Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
    End Sub
    ' Mở file Access
    Private Sub BarButtonItem4_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem4.ItemClick
        ' Hiển thị hộp thoại mở tệp để người dùng chọn tệp Access
        Dim openFileDialog As New OpenFileDialog()
        openFileDialog.Filter = "Tất cả các định dạng Access (*.accdb; *.mdb)|*.accdb; *.mdb|Tệp Access (*.accdb)|*.accdb|Tệp Access 2000-2003 (*.mdb)|*.mdb|Tất cả các tệp (*.*)|*.*"
        openFileDialog.Title = "Chọn tệp Access"

        If openFileDialog.ShowDialog() = DialogResult.OK Then
            Dim filePath As String = openFileDialog.FileName
            SavePathToFile(filePath)
            Read_Access(filePath, "Element Forces - Beams")
        End If

    End Sub

    Private Sub SavePathToFile(filePath As String)
        ' Đường dẫn tới tệp tin text để lưu đường dẫn
        Dim filePathTxt As String = $"{Application.StartupPath}\Template\Path_Access.txt"

        ' Ghi đường dẫn vào tệp tin text
        File.WriteAllText(filePathTxt, filePath)
    End Sub

    Private Sub BarButtonItem2_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem2.ItemClick

    End Sub
End Class