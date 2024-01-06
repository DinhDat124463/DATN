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
        Me.Vecto = New AxVDProLib5.AxVDPro()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btn_ve = New System.Windows.Forms.Button()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        CType(Me.Vecto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Vecto
        '
        Me.Vecto.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Vecto.Enabled = True
        Me.Vecto.Location = New System.Drawing.Point(0, 0)
        Me.Vecto.Name = "Vecto"
        Me.Vecto.OcxState = CType(resources.GetObject("Vecto.OcxState"), System.Windows.Forms.AxHost.State)
        Me.Vecto.Size = New System.Drawing.Size(969, 583)
        Me.Vecto.TabIndex = 1
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Button2)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.btn_ve)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(969, 54)
        Me.Panel1.TabIndex = 2
        '
        'Button2
        '
        Me.Button2.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Button2.Location = New System.Drawing.Point(745, 3)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(103, 48)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "Mặt cắt ngang"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Button1.Location = New System.Drawing.Point(854, 3)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(103, 48)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Xuất dwg"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'btn_ve
        '
        Me.btn_ve.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.btn_ve.Location = New System.Drawing.Point(636, 3)
        Me.btn_ve.Name = "btn_ve"
        Me.btn_ve.Size = New System.Drawing.Size(103, 48)
        Me.btn_ve.TabIndex = 0
        Me.btn_ve.Text = "Mặt cắt dọc"
        Me.btn_ve.UseVisualStyleBackColor = True
        '
        'Form_Banve
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(969, 583)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Vecto)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form_Banve"
        Me.Text = "Form_Banve"
        CType(Me.Vecto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Vecto As AxVDProLib5.AxVDPro
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btn_ve As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents SaveFileDialog1 As SaveFileDialog
End Class
