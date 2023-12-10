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
        'Me.WindowState = FormWindowState.Maximized

        'panel_vatlieu.Hide()
        'panel_main.Hide()
        'Panel2.Hide()

        'Dim Gioithieu As New Form_Gioithieu()
        'Gioithieu.TopLevel = False
        'Gioithieu.Dock = DockStyle.Fill
        'Panel1.Controls.Add(Gioithieu)
        'Gioithieu.Show()
    End Sub
    ' Mở file Access
    Private Sub BarButtonItem4_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem4.ItemClick
        Me.WindowState = FormWindowState.Maximized
        ' Hiển thị hộp thoại mở tệp để người dùng chọn tệp Access
        Dim openFileDialog As New OpenFileDialog()
        openFileDialog.Filter = "Tất cả các định dạng Access (*.accdb; *.mdb)|*.accdb; *.mdb|Tệp Access (*.accdb)|*.accdb|Tệp Access 2000-2003 (*.mdb)|*.mdb|Tất cả các tệp (*.*)|*.*"
        openFileDialog.Title = "Chọn tệp Access"

        If openFileDialog.ShowDialog() = DialogResult.OK Then
            Dim filePath As String = openFileDialog.FileName
            SavePathToFile(filePath)
            congtrinh = New Cls_congtrinh

            Dim unit1 As String = Unit(filePath)
            Dim commaIndex As Integer = unit1.IndexOf(",")
            lb_taitrong.Text = "Đơn vị tải trọng: " & unit1.Substring(0, commaIndex)
            Dim firstCommaIndex As Integer = unit1.IndexOf(",")
            Dim secondCommaIndex As Integer = unit1.IndexOf(",", firstCommaIndex + 1)
            lb_chieudai.Text = "Đơn vị chiều dài: " & unit1.Substring(firstCommaIndex + 1, secondCommaIndex - firstCommaIndex - 1)

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

            Dim Vatlieu As New Form_VatLieu()
            Vatlieu.TopLevel = False
            Vatlieu.Dock = DockStyle.Bottom
            panel_vatlieu.Controls.Add(Vatlieu)
            Vatlieu.Show()

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

    Private Sub panel_vatlieu_Paint(sender As Object, e As PaintEventArgs) Handles panel_vatlieu.Paint

    End Sub

    Private Sub BarButtonItem6_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem6.ItemClick
        Form_bangtra.Show()
    End Sub
End Class