<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class thongtinkhachhang
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtMaKH = New System.Windows.Forms.TextBox()
        Me.txtTenkh = New System.Windows.Forms.TextBox()
        Me.txtAdd = New System.Windows.Forms.TextBox()
        Me.txtSDT = New System.Windows.Forms.TextBox()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.dgvKH = New System.Windows.Forms.DataGridView()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtngaysinh = New System.Windows.Forms.TextBox()
        Me.txtphanhoi = New System.Windows.Forms.TextBox()
        Me.Openchonanh = New System.Windows.Forms.OpenFileDialog()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnthemanh = New System.Windows.Forms.Button()
        Me.ptnanhdaidien = New System.Windows.Forms.PictureBox()
        Me.btnquaylai = New System.Windows.Forms.Button()
        Me.btnxoa = New System.Windows.Forms.Button()
        Me.btncapnhat = New System.Windows.Forms.Button()
        Me.btnthem = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.dgvKH, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.ptnanhdaidien, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.Highlight
        Me.Label1.Font = New System.Drawing.Font("Broadway", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.InfoText
        Me.Label1.Location = New System.Drawing.Point(127, 64)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(137, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "MÃ KHÁCH HÀNG"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.SystemColors.Highlight
        Me.Label2.Font = New System.Drawing.Font("Broadway", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.InfoText
        Me.Label2.Location = New System.Drawing.Point(122, 118)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(144, 15)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "TÊN KHÁCH HÀNG"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.SystemColors.Highlight
        Me.Label3.Font = New System.Drawing.Font("Broadway", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.InfoText
        Me.Label3.Location = New System.Drawing.Point(197, 162)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(59, 15)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "ĐỊA CHỈ"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.SystemColors.Highlight
        Me.Label4.Font = New System.Drawing.Font("Broadway", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.InfoText
        Me.Label4.Location = New System.Drawing.Point(150, 209)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(110, 15)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "SỐ ĐIỆN THOẠI"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.SystemColors.Highlight
        Me.Label5.Font = New System.Drawing.Font("Broadway", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.InfoText
        Me.Label5.Location = New System.Drawing.Point(199, 252)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(57, 15)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "EMAIL"
        '
        'txtMaKH
        '
        Me.txtMaKH.BackColor = System.Drawing.SystemColors.Highlight
        Me.txtMaKH.Font = New System.Drawing.Font("Bell MT", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMaKH.ForeColor = System.Drawing.SystemColors.InfoText
        Me.txtMaKH.Location = New System.Drawing.Point(282, 57)
        Me.txtMaKH.Margin = New System.Windows.Forms.Padding(4)
        Me.txtMaKH.Name = "txtMaKH"
        Me.txtMaKH.Size = New System.Drawing.Size(219, 22)
        Me.txtMaKH.TabIndex = 1
        '
        'txtTenkh
        '
        Me.txtTenkh.BackColor = System.Drawing.SystemColors.Highlight
        Me.txtTenkh.Font = New System.Drawing.Font("Bell MT", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTenkh.ForeColor = System.Drawing.SystemColors.InfoText
        Me.txtTenkh.Location = New System.Drawing.Point(282, 111)
        Me.txtTenkh.Margin = New System.Windows.Forms.Padding(4)
        Me.txtTenkh.Name = "txtTenkh"
        Me.txtTenkh.Size = New System.Drawing.Size(219, 22)
        Me.txtTenkh.TabIndex = 1
        '
        'txtAdd
        '
        Me.txtAdd.BackColor = System.Drawing.SystemColors.Highlight
        Me.txtAdd.Font = New System.Drawing.Font("Bell MT", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAdd.ForeColor = System.Drawing.SystemColors.InfoText
        Me.txtAdd.Location = New System.Drawing.Point(282, 159)
        Me.txtAdd.Margin = New System.Windows.Forms.Padding(4)
        Me.txtAdd.Name = "txtAdd"
        Me.txtAdd.Size = New System.Drawing.Size(219, 22)
        Me.txtAdd.TabIndex = 1
        '
        'txtSDT
        '
        Me.txtSDT.BackColor = System.Drawing.SystemColors.Highlight
        Me.txtSDT.Font = New System.Drawing.Font("Bell MT", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSDT.ForeColor = System.Drawing.SystemColors.InfoText
        Me.txtSDT.Location = New System.Drawing.Point(282, 209)
        Me.txtSDT.Margin = New System.Windows.Forms.Padding(4)
        Me.txtSDT.Name = "txtSDT"
        Me.txtSDT.Size = New System.Drawing.Size(219, 22)
        Me.txtSDT.TabIndex = 1
        '
        'txtEmail
        '
        Me.txtEmail.BackColor = System.Drawing.SystemColors.Highlight
        Me.txtEmail.Font = New System.Drawing.Font("Bell MT", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmail.ForeColor = System.Drawing.SystemColors.InfoText
        Me.txtEmail.Location = New System.Drawing.Point(282, 252)
        Me.txtEmail.Margin = New System.Windows.Forms.Padding(4)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(219, 22)
        Me.txtEmail.TabIndex = 1
        '
        'dgvKH
        '
        Me.dgvKH.BackgroundColor = System.Drawing.SystemColors.Highlight
        Me.dgvKH.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgvKH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvKH.Location = New System.Drawing.Point(82, 31)
        Me.dgvKH.Margin = New System.Windows.Forms.Padding(4)
        Me.dgvKH.Name = "dgvKH"
        Me.dgvKH.Size = New System.Drawing.Size(817, 176)
        Me.dgvKH.TabIndex = 2
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.SystemColors.Highlight
        Me.Label6.Font = New System.Drawing.Font("Broadway", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.InfoText
        Me.Label6.Location = New System.Drawing.Point(168, 306)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(90, 15)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "Ngày Sinh "
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.SystemColors.Highlight
        Me.Label7.Font = New System.Drawing.Font("Broadway", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.InfoText
        Me.Label7.Location = New System.Drawing.Point(94, 350)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(172, 15)
        Me.Label7.TabIndex = 4
        Me.Label7.Text = "Phản Hồi Khách Hàng"
        '
        'txtngaysinh
        '
        Me.txtngaysinh.BackColor = System.Drawing.SystemColors.Highlight
        Me.txtngaysinh.Font = New System.Drawing.Font("Bell MT", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtngaysinh.ForeColor = System.Drawing.SystemColors.InfoText
        Me.txtngaysinh.Location = New System.Drawing.Point(282, 303)
        Me.txtngaysinh.Margin = New System.Windows.Forms.Padding(4)
        Me.txtngaysinh.Name = "txtngaysinh"
        Me.txtngaysinh.Size = New System.Drawing.Size(219, 22)
        Me.txtngaysinh.TabIndex = 5
        '
        'txtphanhoi
        '
        Me.txtphanhoi.BackColor = System.Drawing.SystemColors.Highlight
        Me.txtphanhoi.Font = New System.Drawing.Font("Bell MT", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtphanhoi.ForeColor = System.Drawing.SystemColors.InfoText
        Me.txtphanhoi.Location = New System.Drawing.Point(282, 347)
        Me.txtphanhoi.Margin = New System.Windows.Forms.Padding(4)
        Me.txtphanhoi.Name = "txtphanhoi"
        Me.txtphanhoi.Size = New System.Drawing.Size(219, 22)
        Me.txtphanhoi.TabIndex = 5
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtMaKH)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.btnthemanh)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.ptnanhdaidien)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.txtphanhoi)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.txtngaysinh)
        Me.GroupBox1.Controls.Add(Me.txtTenkh)
        Me.GroupBox1.Controls.Add(Me.txtAdd)
        Me.GroupBox1.Controls.Add(Me.txtSDT)
        Me.GroupBox1.Controls.Add(Me.txtEmail)
        Me.GroupBox1.Location = New System.Drawing.Point(95, 304)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(834, 389)
        Me.GroupBox1.TabIndex = 12
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Điền Thông TIn"
        '
        'btnthemanh
        '
        Me.btnthemanh.Font = New System.Drawing.Font("Algerian", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnthemanh.Image = Global.WindowsApplication3.My.Resources.Resources.Update
        Me.btnthemanh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnthemanh.Location = New System.Drawing.Point(653, 293)
        Me.btnthemanh.Margin = New System.Windows.Forms.Padding(4)
        Me.btnthemanh.Name = "btnthemanh"
        Me.btnthemanh.Size = New System.Drawing.Size(112, 40)
        Me.btnthemanh.TabIndex = 10
        Me.btnthemanh.Text = "Thêm Ảnh"
        Me.btnthemanh.UseVisualStyleBackColor = True
        '
        'ptnanhdaidien
        '
        Me.ptnanhdaidien.BackColor = System.Drawing.SystemColors.Highlight
        Me.ptnanhdaidien.BackgroundImage = Global.WindowsApplication3.My.Resources.Resources._11
        Me.ptnanhdaidien.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ptnanhdaidien.Location = New System.Drawing.Point(604, 29)
        Me.ptnanhdaidien.Margin = New System.Windows.Forms.Padding(4)
        Me.ptnanhdaidien.Name = "ptnanhdaidien"
        Me.ptnanhdaidien.Size = New System.Drawing.Size(195, 238)
        Me.ptnanhdaidien.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ptnanhdaidien.TabIndex = 9
        Me.ptnanhdaidien.TabStop = False
        '
        'btnquaylai
        '
        Me.btnquaylai.Font = New System.Drawing.Font("Algerian", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnquaylai.Image = Global.WindowsApplication3.My.Resources.Resources.Go_back
        Me.btnquaylai.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnquaylai.Location = New System.Drawing.Point(723, 235)
        Me.btnquaylai.Margin = New System.Windows.Forms.Padding(4)
        Me.btnquaylai.Name = "btnquaylai"
        Me.btnquaylai.Size = New System.Drawing.Size(111, 36)
        Me.btnquaylai.TabIndex = 11
        Me.btnquaylai.Text = "Quay Lại"
        Me.btnquaylai.UseVisualStyleBackColor = True
        '
        'btnxoa
        '
        Me.btnxoa.Font = New System.Drawing.Font("Algerian", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnxoa.Image = Global.WindowsApplication3.My.Resources.Resources.Delete
        Me.btnxoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnxoa.Location = New System.Drawing.Point(458, 235)
        Me.btnxoa.Margin = New System.Windows.Forms.Padding(4)
        Me.btnxoa.Name = "btnxoa"
        Me.btnxoa.Size = New System.Drawing.Size(102, 36)
        Me.btnxoa.TabIndex = 8
        Me.btnxoa.Text = "Delete"
        Me.btnxoa.UseVisualStyleBackColor = True
        '
        'btncapnhat
        '
        Me.btncapnhat.Font = New System.Drawing.Font("Algerian", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btncapnhat.Image = Global.WindowsApplication3.My.Resources.Resources.Update
        Me.btncapnhat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btncapnhat.Location = New System.Drawing.Point(207, 235)
        Me.btncapnhat.Margin = New System.Windows.Forms.Padding(4)
        Me.btncapnhat.Name = "btncapnhat"
        Me.btncapnhat.Size = New System.Drawing.Size(112, 36)
        Me.btncapnhat.TabIndex = 6
        Me.btncapnhat.Text = "Cập Nhật"
        Me.btncapnhat.UseVisualStyleBackColor = True
        '
        'btnthem
        '
        Me.btnthem.Font = New System.Drawing.Font("Algerian", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnthem.Image = Global.WindowsApplication3.My.Resources.Resources.them
        Me.btnthem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnthem.Location = New System.Drawing.Point(327, 235)
        Me.btnthem.Margin = New System.Windows.Forms.Padding(4)
        Me.btnthem.Name = "btnthem"
        Me.btnthem.Size = New System.Drawing.Size(94, 36)
        Me.btnthem.TabIndex = 3
        Me.btnthem.Text = "Thêm"
        Me.btnthem.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Image = Global.WindowsApplication3.My.Resources.Resources.sua
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(592, 235)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(109, 36)
        Me.Button1.TabIndex = 13
        Me.Button1.Text = "Nhập Lại"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'thongtinkhachhang
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Highlight
        Me.BackgroundImage = Global.WindowsApplication3.My.Resources.Resources._11
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(941, 731)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnquaylai)
        Me.Controls.Add(Me.btnxoa)
        Me.Controls.Add(Me.btncapnhat)
        Me.Controls.Add(Me.dgvKH)
        Me.Controls.Add(Me.btnthem)
        Me.Font = New System.Drawing.Font("Algerian", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.SystemColors.InfoText
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "thongtinkhachhang"
        Me.Text = "Thông Tin Khách Hàng"
        CType(Me.dgvKH, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.ptnanhdaidien, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtMaKH As System.Windows.Forms.TextBox
    Friend WithEvents txtTenkh As System.Windows.Forms.TextBox
    Friend WithEvents txtAdd As System.Windows.Forms.TextBox
    Friend WithEvents txtSDT As System.Windows.Forms.TextBox
    Friend WithEvents txtEmail As System.Windows.Forms.TextBox
    Friend WithEvents dgvKH As System.Windows.Forms.DataGridView
    Friend WithEvents btnthem As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtngaysinh As System.Windows.Forms.TextBox
    Friend WithEvents txtphanhoi As System.Windows.Forms.TextBox
    Friend WithEvents btncapnhat As System.Windows.Forms.Button
    Friend WithEvents btnxoa As System.Windows.Forms.Button
    Friend WithEvents ptnanhdaidien As System.Windows.Forms.PictureBox
    Friend WithEvents Openchonanh As System.Windows.Forms.OpenFileDialog
    Friend WithEvents btnthemanh As System.Windows.Forms.Button
    Friend WithEvents btnquaylai As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
