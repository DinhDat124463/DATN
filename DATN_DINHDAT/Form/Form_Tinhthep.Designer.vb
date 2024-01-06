<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_Tinhthep
    Inherits DevExpress.XtraEditors.XtraForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.dgv_tinhthep = New System.Windows.Forms.DataGridView()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.dgv_chonthep = New System.Windows.Forms.DataGridView()
        Me.tang = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tendam = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.vitri = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.theploai1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ø = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.theploai2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ø2 = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.Astt = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.μ = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Astc = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.kiemtra = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.dgv_tinhthep, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        CType(Me.dgv_chonthep, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(0, 37)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1043, 571)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage3
        '
        Me.TabPage3.Location = New System.Drawing.Point(4, 25)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(1035, 542)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Tính cốt đai"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.dgv_tinhthep)
        Me.TabPage1.Location = New System.Drawing.Point(4, 25)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(1035, 542)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Tính As"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'dgv_tinhthep
        '
        Me.dgv_tinhthep.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Tahoma", 7.8!)
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_tinhthep.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgv_tinhthep.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Tahoma", 7.8!)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgv_tinhthep.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgv_tinhthep.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgv_tinhthep.Location = New System.Drawing.Point(3, 3)
        Me.dgv_tinhthep.Name = "dgv_tinhthep"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Tahoma", 7.8!)
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_tinhthep.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.dgv_tinhthep.RowHeadersVisible = False
        Me.dgv_tinhthep.RowHeadersWidth = 51
        Me.dgv_tinhthep.RowTemplate.Height = 24
        Me.dgv_tinhthep.Size = New System.Drawing.Size(1029, 536)
        Me.dgv_tinhthep.TabIndex = 1
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.dgv_chonthep)
        Me.TabPage2.Location = New System.Drawing.Point(4, 25)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(1035, 542)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Chọn thép"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'dgv_chonthep
        '
        Me.dgv_chonthep.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Tahoma", 7.8!)
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_chonthep.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.dgv_chonthep.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_chonthep.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.tang, Me.tendam, Me.vitri, Me.theploai1, Me.ø, Me.theploai2, Me.ø2, Me.Astt, Me.μ, Me.Astc, Me.kiemtra})
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Tahoma", 7.8!)
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgv_chonthep.DefaultCellStyle = DataGridViewCellStyle5
        Me.dgv_chonthep.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgv_chonthep.Location = New System.Drawing.Point(3, 3)
        Me.dgv_chonthep.Name = "dgv_chonthep"
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Tahoma", 7.8!)
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_chonthep.RowHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.dgv_chonthep.RowHeadersVisible = False
        Me.dgv_chonthep.RowHeadersWidth = 51
        Me.dgv_chonthep.RowTemplate.Height = 24
        Me.dgv_chonthep.Size = New System.Drawing.Size(1029, 536)
        Me.dgv_chonthep.TabIndex = 1
        '
        'tang
        '
        Me.tang.FillWeight = 62.94118!
        Me.tang.HeaderText = "Tầng"
        Me.tang.MinimumWidth = 6
        Me.tang.Name = "tang"
        '
        'tendam
        '
        Me.tendam.FillWeight = 62.94118!
        Me.tendam.HeaderText = "Tên dầm"
        Me.tendam.MinimumWidth = 6
        Me.tendam.Name = "tendam"
        '
        'vitri
        '
        Me.vitri.FillWeight = 62.94118!
        Me.vitri.HeaderText = "Vị trí"
        Me.vitri.MinimumWidth = 6
        Me.vitri.Name = "vitri"
        '
        'theploai1
        '
        Me.theploai1.FillWeight = 62.94118!
        Me.theploai1.HeaderText = "Thép lớp 1"
        Me.theploai1.MinimumWidth = 6
        Me.theploai1.Name = "theploai1"
        '
        'ø
        '
        Me.ø.FillWeight = 40.0!
        Me.ø.HeaderText = "ø"
        Me.ø.Items.AddRange(New Object() {"6", "8", "10", "12", "14", "16", "18", "20", "22", "25", "28", "30", "32", "34", "36", "40"})
        Me.ø.MinimumWidth = 6
        Me.ø.Name = "ø"
        '
        'theploai2
        '
        Me.theploai2.FillWeight = 62.94118!
        Me.theploai2.HeaderText = "Thép lớp 2"
        Me.theploai2.MinimumWidth = 6
        Me.theploai2.Name = "theploai2"
        '
        'ø2
        '
        Me.ø2.FillWeight = 40.0!
        Me.ø2.HeaderText = "ø"
        Me.ø2.Items.AddRange(New Object() {"6", "8", "10", "12", "14", "16", "18", "20", "22", "25", "28", "30", "32", "34", "36", "40"})
        Me.ø2.MinimumWidth = 6
        Me.ø2.Name = "ø2"
        Me.ø2.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.ø2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'Astt
        '
        Me.Astt.FillWeight = 62.94118!
        Me.Astt.HeaderText = "Astt"
        Me.Astt.MinimumWidth = 6
        Me.Astt.Name = "Astt"
        '
        'μ
        '
        Me.μ.FillWeight = 62.94118!
        Me.μ.HeaderText = "μ(%)"
        Me.μ.MinimumWidth = 6
        Me.μ.Name = "μ"
        '
        'Astc
        '
        Me.Astc.FillWeight = 62.94118!
        Me.Astc.HeaderText = "Astc"
        Me.Astc.MinimumWidth = 6
        Me.Astc.Name = "Astc"
        '
        'kiemtra
        '
        Me.kiemtra.FillWeight = 62.94118!
        Me.kiemtra.HeaderText = "Kiểm tra"
        Me.kiemtra.MinimumWidth = 6
        Me.kiemtra.Name = "kiemtra"
        '
        'Button1
        '
        Me.Button1.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Button1.Location = New System.Drawing.Point(912, 1)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(127, 36)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Lưu cốt thép"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1043, 37)
        Me.Panel1.TabIndex = 2
        '
        'Form_Tinhthep
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1043, 608)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form_Tinhthep"
        Me.Text = "Form_Tinhthep"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        CType(Me.dgv_tinhthep, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        CType(Me.dgv_chonthep, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents dgv_tinhthep As DataGridView
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents dgv_chonthep As DataGridView
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents tang As DataGridViewTextBoxColumn
    Friend WithEvents tendam As DataGridViewTextBoxColumn
    Friend WithEvents vitri As DataGridViewTextBoxColumn
    Friend WithEvents theploai1 As DataGridViewTextBoxColumn
    Friend WithEvents ø As DataGridViewComboBoxColumn
    Friend WithEvents theploai2 As DataGridViewTextBoxColumn
    Friend WithEvents ø2 As DataGridViewComboBoxColumn
    Friend WithEvents Astt As DataGridViewTextBoxColumn
    Friend WithEvents μ As DataGridViewTextBoxColumn
    Friend WithEvents Astc As DataGridViewTextBoxColumn
    Friend WithEvents kiemtra As DataGridViewTextBoxColumn
    Friend WithEvents Button1 As Button
    Friend WithEvents Panel1 As Panel
End Class
