Imports System.Data.SqlClient
Imports System.Data.DataTable

Public Class thongtinkhachhang
    Dim db As New DataTable
    Dim chuoiketnoi As String = "workstation id=ASSps03098.mssql.somee.com;packet size=4096;user id=lethanhnghiem_SQLLogin_1;pwd=hbxkau4831;data source=ASSps03098.mssql.somee.com;persist security info=False;initial catalog=ASSps03098"
    Dim conn As SqlConnection = New SqlConnection(chuoiketnoi)

    Private Sub thongtinkhachhang_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ' Load Du lIeu khi khoi dong
        Dim refesh As SqlDataAdapter = New SqlDataAdapter("select MAKH as 'Mã KH' ,TENKH as 'Tên Khách Hàng', DIACHI as 'Địa chỉ', SDT as 'SĐT', NGAYSINH , PHANHOIKH, EMAIL  from KHACHHANG", conn)
        db.Clear()
        refesh.Fill(db)
        dgvKH.DataSource = db.DefaultView
    End Sub

    Private Sub dgvKH_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvKH.CellContentClick
        Dim click As Integer = dgvKH.CurrentCell.RowIndex
        txtMaKH.Text = dgvKH.Item(0, click).Value
        txtTenkh.Text = dgvKH.Item(1, click).Value
        txtAdd.Text = dgvKH.Item(2, click).Value
        txtSDT.Text = dgvKH.Item(3, click).Value
        txtEmail.Text = dgvKH.Item(4, click).Value
        txtngaysinh.Text = dgvKH.Item(5, click).Value
        txtphanhoi.Text = dgvKH.Item(6, click).Value
    End Sub

    Private Sub btnthem_Click(sender As Object, e As EventArgs) Handles btnthem.Click
        Dim conn As SqlConnection = New SqlConnection(chuoiketnoi)
        Dim query As String = "insert into KHACHHANG values(@MAKH,@TENKH,@DIACHI,@SDT,@EMAIL,@NGAYSINH,@PHANHOIKH)"
        Dim save As SqlCommand = New SqlCommand(query, conn)
        conn.Open()
        Try
            txtMaKH.Focus()
            If txtMaKH.Text = "" Then
                MessageBox.Show("Bạn chưa nhập Mã Khách hàng", "Nhập thiếu", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
            Else
                txtMaKH.Focus()
                If txtTenkh.Text = "" Then
                    MessageBox.Show("Bạn chưa nhập tên khách hàng", "Nhập thiếu", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
                Else
                    txtAdd.Focus()
                    If txtSDT.Text = "" Then
                        MessageBox.Show("Bạn chưa nhập số điện thoại", "Nhập thiếu", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
                    Else
                        txtSDT.Focus()
                        If txtEmail.Text = "" Then
                            MessageBox.Show("Bạn chưa nhập email", "Nhập thiếu", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
                            txtEmail.Focus()
                        Else
                            save.Parameters.AddWithValue("@MAKH", txtMaKH.Text)
                            save.Parameters.AddWithValue("@TENKH", txtTenkh.Text)
                            save.Parameters.AddWithValue("@DIACHI", txtAdd.Text)
                            save.Parameters.AddWithValue("@SDT", txtSDT.Text)
                            save.Parameters.AddWithValue("@EMAIL", txtEmail.Text)
                            save.Parameters.AddWithValue("@NGAYSINH", txtngaysinh.Text)
                            save.Parameters.AddWithValue("@PHANHOIKH", txtphanhoi.Text)

                            save.ExecuteNonQuery()
                            MessageBox.Show("Lưu thành công")
                            'Sau khi nhập thành công, tự động làm mới các khung textbox, combox và date....
                            txtMaKH.Text = Nothing
                            txtTenkh.Text = Nothing
                            txtAdd.Text = Nothing
                            txtSDT.Text = Nothing
                            txtEmail.Text = Nothing
                            txtngaysinh.Text = Nothing
                            txtphanhoi.Text = Nothing
                            ptnanhdaidien.BackgroundImage = Nothing


                        End If
                    End If
                End If
            End If
        Catch ex As Exception  'Ngược lại báo lỗi
            MessageBox.Show("Không được trùng mã khách hàng", "Lỗi", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error)
        End Try

        'Làm mới lại bảng sau khi lưu thành công
        Dim refesh As SqlDataAdapter = New SqlDataAdapter("select MAKH as 'Mã KH' ,TENKH as 'Tên Khách Hàng', DIACHI as 'Địa chỉ', SDT as 'SĐT', NGAYSINH , PHANHOIKH, EMAIL  from KHACHHANG", conn)
        db.Clear()
        refesh.Fill(db)
        dgvKH.DataSource = db.DefaultView
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtngaysinh.TextChanged, txtphanhoi.TextChanged

    End Sub

    Private Sub btncapnhat_Click(sender As Object, e As EventArgs) Handles btncapnhat.Click
        Dim conn As SqlConnection = New SqlConnection(chuoiketnoi)
        Dim updatequery As String = "update KHACHHANG set MAKH=@MAKH, TENKH=@TENKH, DIACHI=@DIACHI, SDT=@SDT, EMAIL=@EMAIL, NGAYSINH=@NGAYSINH, PHANHOIKH=@PHANHOIKH where MAKH=@MAKH"
        Dim addupdate As SqlCommand = New SqlCommand(updatequery, conn)
        conn.Open()
        Try
            txtMaKH.Focus()
            If txtMaKH.Text = "" Then
                MessageBox.Show("Bạn chưa nhập mã khách hàng", "Nhập thiếu", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
            Else
                txtMaKH.Focus()
                If txtTenkh.Text = "" Then
                    MessageBox.Show("Bạn chưa nhập tên khách hàng", "Nhập thiếu", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
                Else
                    txtTenkh.Focus()
                    If txtAdd.Text = "" Then
                        MessageBox.Show("Bạn chưa nhập địa chỉ khách hàng", "Nhập thiếu", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
                    Else
                        txtAdd.Focus()
                        If txtSDT.Text = "" Then
                            MessageBox.Show("Bạn chưa nhập số điện thoại", "Nhập thiếu", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
                        Else
                            txtSDT.Focus()
                            If txtEmail.Text = "" Then
                                MessageBox.Show("Bạn chưa nhập email", "Nhập thiếu", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
                            Else

                                addupdate.Parameters.AddWithValue("@MAKH", txtMaKH.Text)
                                addupdate.Parameters.AddWithValue("@TENKH", txtTenkh.Text)
                                addupdate.Parameters.AddWithValue("@DIACHI", txtAdd.Text)
                                addupdate.Parameters.AddWithValue("@SDT", txtSDT.Text)
                                addupdate.Parameters.AddWithValue("@EMAIL", txtEmail.Text)
                                addupdate.Parameters.AddWithValue("@NGAYSINH", txtngaysinh.Text)
                                addupdate.Parameters.AddWithValue("@PHANHOIKH", txtphanhoi.Text)
                                addupdate.ExecuteNonQuery()
                                conn.Close() 'đóng kết nối
                                MessageBox.Show("Cập nhật thành công")
                                txtMaKH.Text = Nothing
                                txtTenkh.Text = Nothing
                                txtAdd.Text = Nothing
                                txtSDT.Text = Nothing
                                txtEmail.Text = Nothing
                                txtngaysinh.Text = Nothing
                                txtphanhoi.Text = Nothing
                                ptnanhdaidien.BackgroundImage = Nothing

                            End If
                        End If
                    End If
                End If
            End If
        Catch ex As Exception
            MessageBox.Show("Không thành công -pS03098", "Lỗi", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error)
        End Try

        'Sau khi cập nhật xong sẽ tự làm mới lại bảng
        db.Clear()
        dgvKH.DataSource = db
        dgvKH.DataSource = Nothing

        LoadData()

    End Sub

    'Private Sub btnLoad_Click(sender As Object, e As EventArgs) Handles btnLoad.Click
    '    Dim connect As SqlConnection = New SqlConnection(chuoiketnoi)
    '    connect.Open()
    '    Dim xem As SqlDataAdapter = New SqlDataAdapter("select MAKH as 'Mã KH' ,TENKH as 'Tên Khách Hàng', DIACHI as 'Địa chỉ', SDT as 'SĐT, NGAYSINH, PHANHOIKH, EMAIL from KHACHHANG where MAKH='" & txtMaKH.Text & "'", connect)
    '    Try
    '        If txtMaKH.Text = "" Then
    '            MessageBox.Show("Bạn cần nhập MAKH", "Nhập thiếu", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)

    '        Else
    '            db.Clear()
    '            dgvKH.DataSource = Nothing
    '            xem.Fill(db)
    '            If db.Rows.Count > 1 Then
    '                dgvKH.DataSource = db.DefaultView
    '                txtMaKH.Text = Nothing
    '                btnxoa.Enabled = True
    '            Else
    '                MessageBox.Show("Không tìm thấy")
    '                txtMaKH.Text = Nothing
    '            End If
    '        End If
    '        connect.Close()
    '    Catch ex As Exception
    '    End Try
    'End Sub

    Private Sub btnxoa_Click(sender As Object, e As EventArgs) Handles btnxoa.Click
        Dim delquery As String = "delete from KHACHHANG where MAKH=@MAKH"
        Dim delete As SqlCommand = New SqlCommand(delquery, conn)
        Dim resulft As DialogResult = MessageBox.Show("Bạn muốn xóa không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        conn.Open()
        Try
            If txtMaKH.Text = "" Then
                MessageBox.Show("Bạn cần nhập mã khách hàng", "Nhập thiếu", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
                txtMaKH.Focus()
            Else
                If resulft = Windows.Forms.DialogResult.Yes Then
                    delete.Parameters.AddWithValue("@MAKH", txtMaKH.Text)
                    delete.ExecuteNonQuery()
                    conn.Close()
                    MessageBox.Show("Xóa thành công")
                    'Sau khi xóa thành công, tự động làm mới các khung textbox, combox và date....
                    txtMaKH.Text = Nothing
                    txtTenkh.Text = Nothing
                    txtAdd.Text = Nothing
                    txtSDT.Text = Nothing
                    txtEmail.Text = Nothing
                    txtngaysinh.Text = Nothing
                    txtphanhoi.Text = Nothing
                    ptnanhdaidien.BackgroundImage = Nothing
                    txtMaKH.Focus()
                End If
            End If
        Catch ex As Exception
            MessageBox.Show("Nhập MAKH chính Xác Nhá!!", "Lỗi", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error)
        End Try

        'làm mới bảng
        db.Clear()
        dgvKH.DataSource = db
        dgvKH.DataSource = Nothing
        LoadData()
    End Sub
    ' định nghĩa sự kiện làm mới YEah!!
    Private Sub LoadData()
        Dim conn As SqlConnection = New SqlConnection(chuoiketnoi)
        Dim load As SqlDataAdapter = New SqlDataAdapter("select MAKH as 'Mã KH' ,TENKH as 'Tên Khách Hàng', DIACHI as 'Địa chỉ', SDT as 'SĐT', NGAYSINH, PHANHOIKH EMAIL from KHACHHANG", conn)

        conn.Open()
        load.Fill(db)
        dgvKH.DataSource = db.DefaultView
    End Sub

    Private Sub btnthemanh_Click(sender As Object, e As EventArgs) Handles btnthemanh.Click
        Openchonanh = New OpenFileDialog()
        Openchonanh.Filter = "all file(*.*)|*.*"
        Openchonanh.Title = "chọn Ảnh"
        If (Openchonanh.ShowDialog() = Windows.Forms.DialogResult.OK) Then

            ptnanhdaidien.BackgroundImage = Image.FromFile(Openchonanh.FileName)

            'txtchuaanh.Text = "image\anhdaidien\" & Path.GetFileName(Openchonanh.FileName)

        End If
    End Sub

    Private Sub btnquaylai_Click(sender As Object, e As EventArgs) Handles btnquaylai.Click
        Main.Show()
        Me.Hide()

    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click

    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub txtEmail_TextChanged(sender As Object, e As EventArgs) Handles txtEmail.TextChanged

    End Sub

    Private Sub txtSDT_TextChanged(sender As Object, e As EventArgs) Handles txtSDT.TextChanged

    End Sub

    Private Sub txtAdd_TextChanged(sender As Object, e As EventArgs) Handles txtAdd.TextChanged

    End Sub

    Private Sub txtTenkh_TextChanged(sender As Object, e As EventArgs) Handles txtTenkh.TextChanged

    End Sub

    Private Sub txtMaKH_TextChanged(sender As Object, e As EventArgs) Handles txtMaKH.TextChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        txtMaKH.Text = Nothing
        txtTenkh.Text = Nothing
        txtAdd.Text = Nothing
        txtSDT.Text = Nothing
        txtEmail.Text = Nothing
        txtngaysinh.Text = Nothing
        txtphanhoi.Text = Nothing
        ptnanhdaidien.BackgroundImage = Nothing
    End Sub
End Class