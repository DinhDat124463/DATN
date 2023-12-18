<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_Dulieudam
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
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.dgv_tietdien = New System.Windows.Forms.DataGridView()
        Me.dgv_noiluc = New System.Windows.Forms.DataGridView()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        CType(Me.dgv_tietdien, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgv_noiluc, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1055, 583)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.dgv_tietdien)
        Me.TabPage1.Location = New System.Drawing.Point(4, 25)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(1047, 554)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Tiết diện dầm"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.dgv_noiluc)
        Me.TabPage2.Location = New System.Drawing.Point(4, 25)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(1047, 554)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Nội lực dầm"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'dgv_tietdien
        '
        Me.dgv_tietdien.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgv_tietdien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_tietdien.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgv_tietdien.Location = New System.Drawing.Point(3, 3)
        Me.dgv_tietdien.Name = "dgv_tietdien"
        Me.dgv_tietdien.RowHeadersVisible = False
        Me.dgv_tietdien.RowHeadersWidth = 51
        Me.dgv_tietdien.RowTemplate.Height = 24
        Me.dgv_tietdien.Size = New System.Drawing.Size(1041, 548)
        Me.dgv_tietdien.TabIndex = 0
        '
        'dgv_noiluc
        '
        Me.dgv_noiluc.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgv_noiluc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_noiluc.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgv_noiluc.Location = New System.Drawing.Point(3, 3)
        Me.dgv_noiluc.Name = "dgv_noiluc"
        Me.dgv_noiluc.RowHeadersVisible = False
        Me.dgv_noiluc.RowHeadersWidth = 51
        Me.dgv_noiluc.RowTemplate.Height = 24
        Me.dgv_noiluc.Size = New System.Drawing.Size(1041, 548)
        Me.dgv_noiluc.TabIndex = 0
        '
        'Form_Dulieudam
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1055, 583)
        Me.Controls.Add(Me.TabControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form_Dulieudam"
        Me.Text = "Form_Dulieudam"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        CType(Me.dgv_tietdien, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgv_noiluc, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents dgv_tietdien As DataGridView
    Friend WithEvents dgv_noiluc As DataGridView
End Class
