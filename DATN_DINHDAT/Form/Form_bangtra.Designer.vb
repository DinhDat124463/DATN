<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_bangtra
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
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.dgv_thuvien = New System.Windows.Forms.DataGridView()
        CType(Me.dgv_thuvien, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ListBox1
        '
        Me.ListBox1.Dock = System.Windows.Forms.DockStyle.Left
        Me.ListBox1.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 21
        Me.ListBox1.Items.AddRange(New Object() {"Cấp độ bền", "Mác thép", "Diện tích thép", "Khoảng cách"})
        Me.ListBox1.Location = New System.Drawing.Point(0, 0)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(179, 630)
        Me.ListBox1.TabIndex = 0
        '
        'dgv_thuvien
        '
        Me.dgv_thuvien.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgv_thuvien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_thuvien.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgv_thuvien.Location = New System.Drawing.Point(179, 0)
        Me.dgv_thuvien.Name = "dgv_thuvien"
        Me.dgv_thuvien.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.dgv_thuvien.RowHeadersVisible = False
        Me.dgv_thuvien.RowHeadersWidth = 51
        Me.dgv_thuvien.RowTemplate.Height = 24
        Me.dgv_thuvien.Size = New System.Drawing.Size(743, 630)
        Me.dgv_thuvien.TabIndex = 1
        '
        'Form_bangtra
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(922, 630)
        Me.Controls.Add(Me.dgv_thuvien)
        Me.Controls.Add(Me.ListBox1)
        Me.IconOptions.Image = Global.DATN_DINHDAT.My.Resources.Resources.Search
        Me.Name = "Form_bangtra"
        Me.Text = "Bảng tra"
        CType(Me.dgv_thuvien, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents dgv_thuvien As DataGridView
End Class
