<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form_Banve
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form_Banve))
        Me.AxVDPro1 = New AxVDProLib5.AxVDPro()
        Me.Panel1 = New System.Windows.Forms.Panel()
        CType(Me.AxVDPro1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'AxVDPro1
        '
        Me.AxVDPro1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.AxVDPro1.Enabled = True
        Me.AxVDPro1.Location = New System.Drawing.Point(0, 0)
        Me.AxVDPro1.Name = "AxVDPro1"
        Me.AxVDPro1.OcxState = CType(resources.GetObject("AxVDPro1.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AxVDPro1.Size = New System.Drawing.Size(969, 583)
        Me.AxVDPro1.TabIndex = 1
        '
        'Panel1
        '
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(969, 30)
        Me.Panel1.TabIndex = 2
        '
        'Form_Banve
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(969, 583)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.AxVDPro1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form_Banve"
        Me.Text = "Form_Banve"
        CType(Me.AxVDPro1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents AxVDPro1 As AxVDProLib5.AxVDPro
    Friend WithEvents Panel1 As Panel
End Class
