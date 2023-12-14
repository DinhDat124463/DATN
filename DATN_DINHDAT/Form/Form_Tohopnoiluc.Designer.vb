<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_Tohopnoiluc
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.dgv_tohopnoiluc = New System.Windows.Forms.DataGridView()
        Me.Panel1.SuspendLayout()
        CType(Me.dgv_tohopnoiluc, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.dgv_tohopnoiluc)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(923, 560)
        Me.Panel1.TabIndex = 0
        '
        'dgv_tohopnoiluc
        '
        Me.dgv_tohopnoiluc.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgv_tohopnoiluc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_tohopnoiluc.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgv_tohopnoiluc.Location = New System.Drawing.Point(0, 0)
        Me.dgv_tohopnoiluc.Name = "dgv_tohopnoiluc"
        Me.dgv_tohopnoiluc.RowHeadersVisible = False
        Me.dgv_tohopnoiluc.RowHeadersWidth = 51
        Me.dgv_tohopnoiluc.RowTemplate.Height = 24
        Me.dgv_tohopnoiluc.Size = New System.Drawing.Size(923, 560)
        Me.dgv_tohopnoiluc.TabIndex = 0
        '
        'Form_Tohopnoiluc
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(923, 560)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form_Tohopnoiluc"
        Me.Text = "Form_Tohopnoiluc"
        Me.Panel1.ResumeLayout(False)
        CType(Me.dgv_tohopnoiluc, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents dgv_tohopnoiluc As DataGridView
End Class
