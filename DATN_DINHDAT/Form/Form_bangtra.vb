Imports System.IO

Public Class Form_bangtra
    ' Public Capdoben As New DataTable
    Public Sub New()
        InitializeComponent()
    End Sub
    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged
        If ListBox1.SelectedIndex = 0 Then
            dgv_thuvien.DataSource = Form_Main.Capdoben
        ElseIf ListBox1.SelectedIndex = 1 Then
            dgv_thuvien.DataSource = Form_Main.Macthep
        ElseIf ListBox1.SelectedIndex = 2 Then
            dgv_thuvien.DataSource = Form_Main.Tietdienthep
        ElseIf ListBox1.SelectedIndex = 3 Then
            dgv_thuvien.DataSource = Form_Main.Khoangcach
        End If
    End Sub

    Private Sub Form_bangtra_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
        ListBox1.SelectedIndex = 0
    End Sub
End Class