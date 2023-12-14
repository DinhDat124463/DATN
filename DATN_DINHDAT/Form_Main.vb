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
        ' Tạo và hiển thị form khác
        Form_bangtra.Show()
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
    Private betong1 As String
    Private Noiluc1 As DataTable
    Private Length As DataTable
    Private Tietdien_Dam As DataTable
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

            Tietdien_Dam = Read_Access(filePath)


            ' Nội lực dầm 
            Noiluc1 = Noiluc(filePath)
            Length = Loc_Noiluc(filePath)
            betong1 = Betong(filePath)
            ' Thêm cột "Length" vào DataTable Noiluc1
            Noiluc1.Columns.Add("Length", GetType(Double))
            For Each row1 As DataRow In Noiluc1.Rows
                For Each row2 As DataRow In Length.Rows
                    If row1("Unique Name").ToString() = row2("BeamName").ToString() Then
                        ' Lấy giá trị từ cột "Length" của row2 và thêm vào cột "Length" của row1
                        row1("Length") = row2("Length")
                    End If
                Next
            Next

            ' Tiết diện dầm
            Dim tietdien As New Form_Dulieudam()
            panel_main.Controls.Clear()
            tietdien.TopLevel = False
            tietdien.Dock = DockStyle.Fill
            panel_main.Controls.Add(tietdien)
            tietdien.Show()
            tietdien.dgv_tietdien.DataSource = Tietdien_Dam
            tietdien.dgv_noiluc.DataSource = Noiluc1
            lb_tongdong.Text = Noiluc1.Rows.Count
            ' Vật liệu
            Dim Vatlieu As New Form_VatLieu()
            panel_vatlieu.Controls.Clear()
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

    ' Hàm để trả về giá trị của biến betong1
    Function LayGiaTriBetong() As String
        Return betong1
    End Function


    Private Sub BarButtonItem2_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem2.ItemClick

    End Sub

    Private Sub BarButtonItem6_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem6.ItemClick
        Form_bangtra.Show()
    End Sub

    Private Sub btn_tohop_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_tohop.ItemClick

    End Sub

    Private Sub btn_noiluc_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_noiluc.ItemClick
        ' Tiết diện dầm
        Dim tietdien As New Form_Dulieudam()
        panel_main.Controls.Clear()
        tietdien.TopLevel = False
        tietdien.Dock = DockStyle.Fill
        panel_main.Controls.Add(tietdien)
        tietdien.Show()
        tietdien.dgv_tietdien.DataSource = Tietdien_Dam
        tietdien.dgv_noiluc.DataSource = Noiluc1
    End Sub
End Class