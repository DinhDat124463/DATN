Imports System.Data.OleDb
Imports System.IO
Imports DevExpress.Utils.Html.Internal

Public Class Form_Main
    Private Sub BarButtonItem8_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem8.ItemClick

    End Sub

    Private Sub BarButtonItem9_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem9.ItemClick

    End Sub

    Private Sub Form_Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
        Me.WindowState = FormWindowState.Maximized
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
            congtrinh = New Cls_congtrinh

            Access_Tang(filePath)
            Access_Dam(filePath)
            ' Tiết diện dầm
            Dim Tietdien_Dam As DataTable = Read_Access(filePath)
            Dim tietdien As New Form_Dulieudam()
            panel_main.Controls.Clear()
            tietdien.TopLevel = False
            tietdien.Dock = DockStyle.Fill
            panel_main.Controls.Add(tietdien)
            tietdien.Show()
            tietdien.dgv_tietdien.DataSource = Tietdien_Dam
            '' Nội lực dầm
            '' Dim Noiluc_Dam As DataTable = Read_Access(filePath, "Element Forces - Beams", "Story,Station,V2,V3,T,M2,M3")
            'tietdien.TopLevel = False
            'tietdien.Dock = DockStyle.Fill
            'panel_main.Controls.Add(tietdien)
            'tietdien.Show()
            ''tietdien.dgv_noiluc.DataSource = Noiluc_Dam

            '' lấy tên các tầng 
            'Dim list_tang As List(Of String) = Read_Access_ToList(filePath, "Element Forces - Beams", "Story")
            'Dim list_TaiTrong As List(Of String) = Read_Access_ToList(filePath, "Element Forces - Beams", "Output Case")
            'list_tang = list_tang.Distinct().ToList()
            'list_TaiTrong = list_TaiTrong.Distinct().ToList()
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