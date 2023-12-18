Imports System.Data
Imports System.Linq
Imports System.IO
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Form_VatLieu
    Dim capdobenTable As DataTable = Form_Main.Capdoben
    Dim thepdocTable As DataTable = Form_Main.Macthep
    Dim thepngangTable As DataTable = Form_Main.Macthep
    Private Sub cbb_capdoben_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbb_capdoben.SelectedIndexChanged
        Dim selectedCapdobenIndex As Integer = cbb_capdoben.SelectedIndex
        If selectedCapdobenIndex >= 0 AndAlso selectedCapdobenIndex < capdobenTable.Columns.Count - 1 Then
            txt_Rb.Text = capdobenTable.Rows(0)(selectedCapdobenIndex + 1).ToString()
            txt_rbt.Text = capdobenTable.Rows(1)(selectedCapdobenIndex + 1).ToString()
            txt_Eb.Text = 200000
        End If
    End Sub
    Private Sub btn_luuvatlieu_Click(sender As Object, e As EventArgs) Handles btn_luuvatlieu.Click
        Dim filePath As String = $"{Application.StartupPath}\Template\Vatlieu.txt"
        Try
            ' Xóa hết nội dung trong file trước khi ghi mới
            File.WriteAllText(filePath, String.Empty)
            File.AppendAllText(filePath, "Bê tông" & Environment.NewLine)
            File.AppendAllText(filePath, cbb_capdoben.Text & Environment.NewLine)
            File.AppendAllText(filePath, txt_Rb.Text & Environment.NewLine)
            File.AppendAllText(filePath, txt_rbt.Text & Environment.NewLine)
            File.AppendAllText(filePath, txt_Eb.Text & Environment.NewLine)

            File.AppendAllText(filePath, "Thép dọc" & Environment.NewLine)
            File.AppendAllText(filePath, cbb_macthepdoc.Text & Environment.NewLine)
            File.AppendAllText(filePath, txt_Rs_thepdoc.Text & Environment.NewLine)
            File.AppendAllText(filePath, txt_rsc_thepdoc.Text & Environment.NewLine)
            File.AppendAllText(filePath, txt_rsw_thepdoc.Text & Environment.NewLine)

            File.AppendAllText(filePath, "Thép ngang" & Environment.NewLine)
            File.AppendAllText(filePath, cbb_macthepngang.Text & Environment.NewLine)
            File.AppendAllText(filePath, txt_Rs_thepngang.Text & Environment.NewLine)
            File.AppendAllText(filePath, txt_Rsc_thepngang.Text & Environment.NewLine)
            File.AppendAllText(filePath, txt_Rsw_thepngang.Text & Environment.NewLine)

            MessageBox.Show("Khai báo vật liệu thành công.")
        Catch ex As Exception
            MessageBox.Show($"Lỗi: {ex.Message}")
        End Try

    End Sub
    Private Sub Form_VatLieu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cbb_capdoben.Text = Form_Main.LayGiaTriBetong
        Dim selectedCapdobenIndex As Integer = -1
        For i As Integer = 0 To cbb_capdoben.Items.Count - 1
            If cbb_capdoben.Items(i).ToString() = cbb_capdoben.Text Then
                selectedCapdobenIndex = i
                Exit For
            End If
        Next
        If selectedCapdobenIndex >= 0 Then
            txt_Rb.Text = capdobenTable.Rows(0)(selectedCapdobenIndex + 1).ToString()
            txt_rbt.Text = capdobenTable.Rows(1)(selectedCapdobenIndex + 1).ToString()
            txt_Eb.Text = 200000
        End If
        cbb_macthepdoc.SelectedIndex = 3
        cbb_macthepngang.SelectedIndex = 0
    End Sub

    Private Sub cbb_macthepdoc_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbb_macthepdoc.SelectedIndexChanged
        ' Lấy chỉ số đã chọn từ ComboBox
        Dim selectedmacthepdocIndex As Integer = cbb_macthepdoc.SelectedIndex

        ' Kiểm tra xem chỉ số hợp lệ và nằm trong phạm vi cột của DataTable
        If selectedmacthepdocIndex >= 0 Then
            ' Lấy và hiển thị dữ liệu từ dòng đầu tiên của DataTable
            txt_Rs_thepdoc.Text = thepdocTable.Rows(selectedmacthepdocIndex)(1).ToString()

            ' Lấy và hiển thị dữ liệu từ dòng thứ hai của DataTable
            txt_rsc_thepdoc.Text = thepdocTable.Rows(selectedmacthepdocIndex)(2).ToString()

            ' Lấy và hiển thị dữ liệu từ dòng thứ ba của DataTable
            txt_rsw_thepdoc.Text = thepdocTable.Rows(selectedmacthepdocIndex)(3).ToString()
        End If

    End Sub
    Private Sub cbb_macthepngang_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbb_macthepngang.SelectedIndexChanged
        ' Lấy chỉ số đã chọn từ ComboBox
        Dim selectedmacthenngangIndex As Integer = cbb_macthepngang.SelectedIndex

        ' Kiểm tra xem chỉ số hợp lệ và nằm trong phạm vi cột của DataTable
        If selectedmacthenngangIndex >= 0 Then
            ' Lấy và hiển thị dữ liệu từ dòng đầu tiên của DataTable
            txt_Rs_thepngang.Text = thepngangTable.Rows(selectedmacthenngangIndex)(1).ToString()

            ' Lấy và hiển thị dữ liệu từ dòng thứ hai của DataTable
            txt_Rsc_thepngang.Text = thepngangTable.Rows(selectedmacthenngangIndex)(2).ToString()

            ' Lấy và hiển thị dữ liệu từ dòng thứ ba của DataTable
            txt_Rsw_thepngang.Text = thepngangTable.Rows(selectedmacthenngangIndex)(3).ToString()
        End If
    End Sub
End Class