<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class xemthongtinKH
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(xemthongtinKH))
        Me.dgvxemkh = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtMAKH = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnquaylai = New System.Windows.Forms.Button()
        Me.btnxemall = New System.Windows.Forms.Button()
        Me.btnxem = New System.Windows.Forms.Button()
        CType(Me.dgvxemkh, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvxemkh
        '
        Me.dgvxemkh.BackgroundColor = System.Drawing.SystemColors.Highlight
        Me.dgvxemkh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvxemkh.GridColor = System.Drawing.SystemColors.Highlight
        Me.dgvxemkh.Location = New System.Drawing.Point(41, 206)
        Me.dgvxemkh.Name = "dgvxemkh"
        Me.dgvxemkh.Size = New System.Drawing.Size(722, 199)
        Me.dgvxemkh.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.Highlight
        Me.Label1.Font = New System.Drawing.Font("Algerian", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(65, 42)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(135, 18)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Mã Khách Hàng"
        '
        'txtMAKH
        '
        Me.txtMAKH.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMAKH.Location = New System.Drawing.Point(216, 31)
        Me.txtMAKH.Name = "txtMAKH"
        Me.txtMAKH.Size = New System.Drawing.Size(187, 29)
        Me.txtMAKH.TabIndex = 2
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Image = Global.WindowsApplication3.My.Resources.Resources.Trackback
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(522, 123)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(114, 33)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "Nhập Lại"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'btnquaylai
        '
        Me.btnquaylai.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnquaylai.Image = Global.WindowsApplication3.My.Resources.Resources.Go_back
        Me.btnquaylai.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnquaylai.Location = New System.Drawing.Point(374, 123)
        Me.btnquaylai.Name = "btnquaylai"
        Me.btnquaylai.Size = New System.Drawing.Size(114, 33)
        Me.btnquaylai.TabIndex = 3
        Me.btnquaylai.Text = "Quay Lại"
        Me.btnquaylai.UseVisualStyleBackColor = True
        '
        'btnxemall
        '
        Me.btnxemall.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnxemall.Image = Global.WindowsApplication3.My.Resources.Resources.Text_preview
        Me.btnxemall.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnxemall.Location = New System.Drawing.Point(237, 123)
        Me.btnxemall.Name = "btnxemall"
        Me.btnxemall.Size = New System.Drawing.Size(116, 33)
        Me.btnxemall.TabIndex = 3
        Me.btnxemall.Text = "Xem All"
        Me.btnxemall.UseVisualStyleBackColor = True
        '
        'btnxem
        '
        Me.btnxem.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnxem.Image = Global.WindowsApplication3.My.Resources.Resources.tim
        Me.btnxem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnxem.Location = New System.Drawing.Point(116, 123)
        Me.btnxem.Name = "btnxem"
        Me.btnxem.Size = New System.Drawing.Size(105, 33)
        Me.btnxem.TabIndex = 3
        Me.btnxem.Text = "Xem"
        Me.btnxem.UseVisualStyleBackColor = True
        '
        'xemthongtinKH
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.WindowsApplication3.My.Resources.Resources._11
        Me.ClientSize = New System.Drawing.Size(798, 427)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnquaylai)
        Me.Controls.Add(Me.btnxemall)
        Me.Controls.Add(Me.btnxem)
        Me.Controls.Add(Me.txtMAKH)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dgvxemkh)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "xemthongtinKH"
        Me.Text = "Thông Tin Khách Hàng"
        CType(Me.dgvxemkh, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgvxemkh As System.Windows.Forms.DataGridView
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtMAKH As System.Windows.Forms.TextBox
    Friend WithEvents btnxem As System.Windows.Forms.Button
    Friend WithEvents btnxemall As System.Windows.Forms.Button
    Friend WithEvents btnquaylai As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
