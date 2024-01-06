<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form_Main
    Inherits DevExpress.XtraEditors.XtraForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form_Main))
        Me.RibbonControl1 = New DevExpress.XtraBars.Ribbon.RibbonControl()
        Me.BarButtonItem1 = New DevExpress.XtraBars.BarButtonItem()
        Me.btn_luu = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem3 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem4 = New DevExpress.XtraBars.BarButtonItem()
        Me.btn_tietdien = New DevExpress.XtraBars.BarButtonItem()
        Me.btn_noiluc = New DevExpress.XtraBars.BarButtonItem()
        Me.btn_tohop = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem8 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem9 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem10 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem2 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem5 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem6 = New DevExpress.XtraBars.BarButtonItem()
        Me.RibbonPage1 = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.RibbonPageGroup1 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPageGroup3 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPageGroup5 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPageGroup2 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.panel_main = New System.Windows.Forms.Panel()
        Me.panel_vatlieu = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.lb_taitrong = New System.Windows.Forms.Label()
        Me.lb_chieudai = New System.Windows.Forms.Label()
        Me.BarButtonItem7 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem11 = New DevExpress.XtraBars.BarButtonItem()
        CType(Me.RibbonControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'RibbonControl1
        '
        Me.RibbonControl1.ExpandCollapseItem.Id = 0
        Me.RibbonControl1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.RibbonControl1.ExpandCollapseItem, Me.RibbonControl1.SearchEditItem, Me.BarButtonItem1, Me.btn_luu, Me.BarButtonItem3, Me.BarButtonItem4, Me.btn_tietdien, Me.btn_noiluc, Me.btn_tohop, Me.BarButtonItem8, Me.BarButtonItem9, Me.BarButtonItem10, Me.BarButtonItem2, Me.BarButtonItem5, Me.BarButtonItem6, Me.BarButtonItem7, Me.BarButtonItem11})
        Me.RibbonControl1.Location = New System.Drawing.Point(0, 0)
        Me.RibbonControl1.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.RibbonControl1.MaxItemId = 16
        Me.RibbonControl1.Name = "RibbonControl1"
        Me.RibbonControl1.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() {Me.RibbonPage1})
        Me.RibbonControl1.Size = New System.Drawing.Size(1074, 183)
        '
        'BarButtonItem1
        '
        Me.BarButtonItem1.Caption = "File"
        Me.BarButtonItem1.Id = 1
        Me.BarButtonItem1.ImageOptions.Image = Global.DATN_DINHDAT.My.Resources.Resources.folder
        Me.BarButtonItem1.Name = "BarButtonItem1"
        Me.BarButtonItem1.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large
        '
        'btn_luu
        '
        Me.btn_luu.Caption = "Lưu"
        Me.btn_luu.Id = 2
        Me.btn_luu.ImageOptions.Image = Global.DATN_DINHDAT.My.Resources.Resources.save_file_option
        Me.btn_luu.Name = "btn_luu"
        '
        'BarButtonItem3
        '
        Me.BarButtonItem3.Caption = "BarButtonItem3"
        Me.BarButtonItem3.Id = 3
        Me.BarButtonItem3.Name = "BarButtonItem3"
        '
        'BarButtonItem4
        '
        Me.BarButtonItem4.Caption = ".MDB"
        Me.BarButtonItem4.Id = 4
        Me.BarButtonItem4.ImageOptions.Image = Global.DATN_DINHDAT.My.Resources.Resources.images
        Me.BarButtonItem4.Name = "BarButtonItem4"
        Me.BarButtonItem4.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large
        '
        'btn_tietdien
        '
        Me.btn_tietdien.Caption = "Tiết diện"
        Me.btn_tietdien.Id = 5
        Me.btn_tietdien.ImageOptions.Image = Global.DATN_DINHDAT.My.Resources.Resources.unnamed
        Me.btn_tietdien.Name = "btn_tietdien"
        Me.btn_tietdien.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large
        '
        'btn_noiluc
        '
        Me.btn_noiluc.Caption = "Dữ liệu dầm"
        Me.btn_noiluc.Id = 6
        Me.btn_noiluc.ImageOptions.Image = Global.DATN_DINHDAT.My.Resources.Resources.beam
        Me.btn_noiluc.Name = "btn_noiluc"
        Me.btn_noiluc.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large
        '
        'btn_tohop
        '
        Me.btn_tohop.Caption = "Tổ hợp nội lực"
        Me.btn_tohop.Id = 7
        Me.btn_tohop.ImageOptions.SvgImage = CType(resources.GetObject("btn_tohop.ImageOptions.SvgImage"), DevExpress.Utils.Svg.SvgImage)
        Me.btn_tohop.Name = "btn_tohop"
        Me.btn_tohop.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large
        '
        'BarButtonItem8
        '
        Me.BarButtonItem8.Caption = "Tính thép"
        Me.BarButtonItem8.Id = 8
        Me.BarButtonItem8.ImageOptions.Image = Global.DATN_DINHDAT.My.Resources.Resources.ic_as
        Me.BarButtonItem8.Name = "BarButtonItem8"
        Me.BarButtonItem8.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large
        '
        'BarButtonItem9
        '
        Me.BarButtonItem9.Caption = "Word"
        Me.BarButtonItem9.Id = 9
        Me.BarButtonItem9.ImageOptions.Image = Global.DATN_DINHDAT.My.Resources.Resources.ExportToWord
        Me.BarButtonItem9.Name = "BarButtonItem9"
        Me.BarButtonItem9.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large
        '
        'BarButtonItem10
        '
        Me.BarButtonItem10.Caption = ".dwg"
        Me.BarButtonItem10.Id = 10
        Me.BarButtonItem10.Name = "BarButtonItem10"
        '
        'BarButtonItem2
        '
        Me.BarButtonItem2.Caption = ".dwg"
        Me.BarButtonItem2.Id = 11
        Me.BarButtonItem2.ImageOptions.Image = Global.DATN_DINHDAT.My.Resources.Resources.tải_xuống
        Me.BarButtonItem2.Name = "BarButtonItem2"
        Me.BarButtonItem2.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large
        '
        'BarButtonItem5
        '
        Me.BarButtonItem5.Caption = "BarButtonItem5"
        Me.BarButtonItem5.Id = 12
        Me.BarButtonItem5.Name = "BarButtonItem5"
        '
        'BarButtonItem6
        '
        Me.BarButtonItem6.Caption = "Bảng tra"
        Me.BarButtonItem6.Id = 13
        Me.BarButtonItem6.ImageOptions.Image = Global.DATN_DINHDAT.My.Resources.Resources.Search
        Me.BarButtonItem6.Name = "BarButtonItem6"
        Me.BarButtonItem6.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large
        '
        'RibbonPage1
        '
        Me.RibbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.RibbonPageGroup1, Me.RibbonPageGroup3, Me.RibbonPageGroup5, Me.RibbonPageGroup2})
        Me.RibbonPage1.Name = "RibbonPage1"
        Me.RibbonPage1.Text = "Dầm"
        '
        'RibbonPageGroup1
        '
        Me.RibbonPageGroup1.ItemLinks.Add(Me.BarButtonItem1)
        Me.RibbonPageGroup1.ItemLinks.Add(Me.BarButtonItem4)
        Me.RibbonPageGroup1.ItemLinks.Add(Me.BarButtonItem7)
        Me.RibbonPageGroup1.Name = "RibbonPageGroup1"
        Me.RibbonPageGroup1.Text = "Mở File"
        '
        'RibbonPageGroup3
        '
        Me.RibbonPageGroup3.ItemLinks.Add(Me.btn_noiluc)
        Me.RibbonPageGroup3.ItemLinks.Add(Me.btn_tohop)
        Me.RibbonPageGroup3.ItemLinks.Add(Me.BarButtonItem8)
        Me.RibbonPageGroup3.Name = "RibbonPageGroup3"
        Me.RibbonPageGroup3.Text = "Tính toán"
        '
        'RibbonPageGroup5
        '
        Me.RibbonPageGroup5.ItemLinks.Add(Me.BarButtonItem2)
        Me.RibbonPageGroup5.ItemLinks.Add(Me.BarButtonItem9)
        Me.RibbonPageGroup5.Name = "RibbonPageGroup5"
        Me.RibbonPageGroup5.Text = "Xuất dữ liệu"
        '
        'RibbonPageGroup2
        '
        Me.RibbonPageGroup2.ItemLinks.Add(Me.BarButtonItem6)
        Me.RibbonPageGroup2.Name = "RibbonPageGroup2"
        Me.RibbonPageGroup2.Text = "Thư viện "
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.panel_main)
        Me.Panel1.Controls.Add(Me.panel_vatlieu)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 183)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1074, 459)
        Me.Panel1.TabIndex = 4
        '
        'panel_main
        '
        Me.panel_main.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panel_main.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panel_main.Location = New System.Drawing.Point(307, 0)
        Me.panel_main.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.panel_main.Name = "panel_main"
        Me.panel_main.Size = New System.Drawing.Size(767, 419)
        Me.panel_main.TabIndex = 6
        '
        'panel_vatlieu
        '
        Me.panel_vatlieu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panel_vatlieu.Dock = System.Windows.Forms.DockStyle.Left
        Me.panel_vatlieu.Location = New System.Drawing.Point(0, 0)
        Me.panel_vatlieu.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.panel_vatlieu.Name = "panel_vatlieu"
        Me.panel_vatlieu.Size = New System.Drawing.Size(307, 419)
        Me.panel_vatlieu.TabIndex = 5
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.lb_taitrong)
        Me.Panel2.Controls.Add(Me.lb_chieudai)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 419)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1074, 40)
        Me.Panel2.TabIndex = 0
        '
        'lb_taitrong
        '
        Me.lb_taitrong.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.lb_taitrong.AutoSize = True
        Me.lb_taitrong.Location = New System.Drawing.Point(948, 1)
        Me.lb_taitrong.Name = "lb_taitrong"
        Me.lb_taitrong.Size = New System.Drawing.Size(100, 16)
        Me.lb_taitrong.TabIndex = 0
        Me.lb_taitrong.Text = "Đơn vị tải trọng:"
        '
        'lb_chieudai
        '
        Me.lb_chieudai.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.lb_chieudai.AutoSize = True
        Me.lb_chieudai.Location = New System.Drawing.Point(948, 17)
        Me.lb_chieudai.Name = "lb_chieudai"
        Me.lb_chieudai.Size = New System.Drawing.Size(103, 16)
        Me.lb_chieudai.TabIndex = 1
        Me.lb_chieudai.Text = "Đơn vị chiều dài:"
        '
        'BarButtonItem7
        '
        Me.BarButtonItem7.Caption = "Lưu"
        Me.BarButtonItem7.Id = 14
        Me.BarButtonItem7.Name = "BarButtonItem7"
        '
        'BarButtonItem11
        '
        Me.BarButtonItem11.Caption = "BarButtonItem11"
        Me.BarButtonItem11.Id = 15
        Me.BarButtonItem11.Name = "BarButtonItem11"
        '
        'Form_Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1074, 642)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.RibbonControl1)
        Me.IconOptions.Image = Global.DATN_DINHDAT.My.Resources.Resources.th2
        Me.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.Name = "Form_Main"
        Me.Text = "Tính toán cấu kiện dầm"
        CType(Me.RibbonControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents RibbonControl1 As DevExpress.XtraBars.Ribbon.RibbonControl
    Friend WithEvents RibbonPage1 As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents RibbonPageGroup1 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents BarButtonItem1 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btn_luu As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem3 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem4 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btn_tietdien As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents RibbonPageGroup3 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents btn_noiluc As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btn_tohop As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem8 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem9 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem10 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents RibbonPageGroup5 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents BarButtonItem2 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents Panel1 As Panel
    Friend WithEvents BarButtonItem5 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents panel_main As Panel
    Friend WithEvents panel_vatlieu As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents lb_taitrong As Label
    Friend WithEvents lb_chieudai As Label
    Friend WithEvents RibbonPageGroup2 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents BarButtonItem6 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem7 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem11 As DevExpress.XtraBars.BarButtonItem
End Class
