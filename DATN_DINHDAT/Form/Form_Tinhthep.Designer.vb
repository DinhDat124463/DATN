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
        Me.dgv_tinhthep = New System.Windows.Forms.DataGridView()
        CType(Me.dgv_tinhthep, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgv_tinhthep
        '
        Me.dgv_tinhthep.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgv_tinhthep.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_tinhthep.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgv_tinhthep.Location = New System.Drawing.Point(0, 0)
        Me.dgv_tinhthep.Name = "dgv_tinhthep"
        Me.dgv_tinhthep.RowHeadersVisible = False
        Me.dgv_tinhthep.RowHeadersWidth = 51
        Me.dgv_tinhthep.RowTemplate.Height = 24
        Me.dgv_tinhthep.Size = New System.Drawing.Size(1043, 608)
        Me.dgv_tinhthep.TabIndex = 0
        '
        'Form_Tinhthep
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1043, 608)
        Me.Controls.Add(Me.dgv_tinhthep)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form_Tinhthep"
        Me.Text = "Form_Tinhthep"
        CType(Me.dgv_tinhthep, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents dgv_tinhthep As DataGridView
End Class
