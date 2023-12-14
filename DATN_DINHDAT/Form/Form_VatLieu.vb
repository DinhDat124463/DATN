Imports System.Data
Imports System.Linq
Public Class Form_VatLieu
    Dim capdobenTable As DataTable = Form_bangtra.Capdoben
    Private Sub cbb_capdoben_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbb_capdoben.SelectedIndexChanged
        Dim selectedCapdobenIndex As Integer = cbb_capdoben.SelectedIndex
        If selectedCapdobenIndex >= 0 AndAlso selectedCapdobenIndex < capdobenTable.Columns.Count - 1 Then
            txt_Rb.Text = capdobenTable.Rows(0)(selectedCapdobenIndex + 1).ToString()
            txt_rbt.Text = capdobenTable.Rows(1)(selectedCapdobenIndex + 1).ToString()
            txt_Eb.Text = 200000
        End If
    End Sub
    Private Sub btn_luuvatlieu_Click(sender As Object, e As EventArgs) Handles btn_luuvatlieu.Click

    End Sub
    Private Sub Form_VatLieu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Dim capdobenTable As DataTable = Form_bangtra.Capdoben
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
    End Sub
End Class