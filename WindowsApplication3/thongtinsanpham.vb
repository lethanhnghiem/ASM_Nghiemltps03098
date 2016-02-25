Imports System.Data.SqlClient
Imports System.Data.DataTable

Public Class thongtinsanpham
    Dim db As New DataTable
    Dim chuoiketnoi As String = "workstation id=ASSps03098.mssql.somee.com;packet size=4096;user id=lethanhnghiem_SQLLogin_1;pwd=hbxkau4831;data source=ASSps03098.mssql.somee.com;persist security info=False;initial catalog=ASSps03098"
    Dim conn As SqlConnection = New SqlConnection(chuoiketnoi)
    Private Sub btnthem_Click(sender As Object, e As EventArgs) Handles btnthem.Click
        Dim conn As SqlConnection = New SqlConnection(chuoiketnoi)
        Dim query As String = "insert into SANPHAM values(@MASP,@TENSP,@SOLUONG,@NHASX,@NHACC) insert into LOAISANPHAM values(@MALOAI,@MASP,@TENLOAI,@NGAYSX,@THUONGHIEU,@HANDUNG,@DONGIA)"
        Dim save As SqlCommand = New SqlCommand(query, conn)
        conn.Open()
        Try
            txtMASP.Focus()
            If txtMASP.Text = "" Then
                MessageBox.Show("Bạn chưa nhập mã sản phẩm", "Nhập thiếu", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
            Else
                txtMASP.Focus()
                If txtTENSP.Text = "" Then
                    MessageBox.Show("Bạn chưa nhập tên sản phẩm", "Nhập thiếu", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
                Else
                    txtTENSP.Focus()
                    If txtMALOAI.Text = "" Then
                        MessageBox.Show("Bạn chưa nhập mã loại", "Nhập thiếu", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
                    Else
                        txtMALOAI.Focus()
                        If txtSOLUONG.Text = "" Then
                            MessageBox.Show("Bạn chưa nhập số lượng", "Nhập thiếu", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
                        Else
                            save.Parameters.AddWithValue("@MASP", txtMASP.Text)
                            save.Parameters.AddWithValue("@TENSP", txtTENSP.Text)
                            save.Parameters.AddWithValue("@MALOAI", txtMALOAI.Text)
                            save.Parameters.AddWithValue("@TENLOAI", txtTENLOAI.Text)
                            save.Parameters.AddWithValue("@SOLUONG", txtSOLUONG.Text)
                            save.Parameters.AddWithValue("@NHASX", txtNHASX.Text)
                            save.Parameters.AddWithValue("@NHACC", txtNHACC.Text)
                            save.Parameters.AddWithValue("@NGAYSX", txtNGAYSX.Text)
                            save.Parameters.AddWithValue("@THUONGHIEU", txtTHUONGHIEU.Text)
                            save.Parameters.AddWithValue("@HANDUNG", txtHANDUNG.Text)
                            save.Parameters.AddWithValue("@DONGIA", txtDONGIA.Text)
                            save.ExecuteNonQuery()
                            MessageBox.Show("Lưu thành công")
                            'Sau khi nhập thành công, tự động làm mới các khung textbox, combox và date....
                            txtMASP.Text = Nothing
                            txtMALOAI.Text = Nothing
                            txtSOLUONG.Text = Nothing
                            txtTENSP.Text = Nothing
                            txtTENLOAI.Text = Nothing
                            txtNHASX.Text = Nothing
                            txtNHACC.Text = Nothing
                            txtNGAYSX.Text = Nothing
                            txtTHUONGHIEU.Text = Nothing
                            txtHANDUNG.Text = Nothing
                            txtDONGIA.Text = Nothing

                        End If
                    End If
                End If
            End If
        Catch ex As Exception  'Ngược lại báo lỗi
            MessageBox.Show("Không được trùng mã sản phẩm", "Lỗi", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error)
        End Try

        'Làm mới lại bảng sau khi lưu thành công
        Dim refesh As SqlDataAdapter = New SqlDataAdapter("select SANPHAM.MASP as 'Mã sản phẩm',SANPHAM.TENSP as 'Tên sản phẩm', LOAISANPHAM.MALOAI as 'Mã Loại', LOAISANPHAM.TENLOAI as 'Tên Loại',SANPHAM.SOLUONG as 'Số lượng',SANPHAM.NHASX as 'Nhà Sản Xuất', SANPHAM.NHACC as 'Nhà Cung Cấp', LOAISANPHAM.NGAYSX as 'Ngày Sản Xuất', LOAISANPHAM.THUONGHIEU as 'Thương Hiệu', LOAISANPHAM.HANDUNG as 'Hạn Dùng', LOAISANPHAM.DONGIA as 'Đơn Giá'  from SANPHAM inner join LOAISANPHAM on SANPHAM.MASP = LOAISANPHAM.MASP", conn)
        db.Clear()
        refesh.Fill(db)
        dgvSanpham.DataSource = db.DefaultView
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim refesh As SqlDataAdapter = New SqlDataAdapter("select SANPHAM.MASP as 'Mã sản phẩm',SANPHAM.TENSP as 'Tên sản phẩm', LOAISANPHAM.MALOAI as 'Mã Loại', LOAISANPHAM.TENLOAI as 'Tên Loại',SANPHAM.SOLUONG as 'Số lượng',SANPHAM.NHASX as 'Nhà Sản Xuất', SANPHAM.NHACC as 'Nhà Cung Cấp', LOAISANPHAM.NGAYSX as 'Ngày Sản Xuất', LOAISANPHAM.THUONGHIEU as 'Thương Hiệu', LOAISANPHAM.HANDUNG as 'Hạn Dùng', LOAISANPHAM.DONGIA as 'Đơn Giá'  from SANPHAM inner join LOAISANPHAM on SANPHAM.MASP = LOAISANPHAM.MASP", conn)
        db.Clear()
        refesh.Fill(db)
        dgvSanpham.DataSource = db.DefaultView
    End Sub

    Private Sub btnCapnhat_Click(sender As Object, e As EventArgs) Handles btnCapnhat.Click
        Dim conn As SqlConnection = New SqlConnection(chuoiketnoi)
        Dim updatequery As String = "update SANPHAM set MASP=@MASP, TENSP=@TENSP, SOLUONG=@SOLUONg, NHASX=@NHASX, NHACC=@NHACC where MASP=@MASP update LOAISANPHAM set MALOAI=@MALOAI, MASP=@MASP, TENLOAI=@TENLOAI, NGAYSX=@NGAYSX, THUONGHIEU=@THUONGHIEU, HANDUNG=@HANDUNG, DONGIA=@DONGIA where MASP=@MASP"
        Dim addupdate As SqlCommand = New SqlCommand(updatequery, conn)
        conn.Open()
        Try
            txtMASP.Focus()
            If txtMASP.Text = "" Then
                MessageBox.Show("Bạn chưa nhập mã sản phẩm", "Nhập thiếu", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
            Else
                txtMASP.Focus()
                If txtTENSP.Text = "" Then
                    MessageBox.Show("Bạn chưa nhập tên sản phẩm", "Nhập thiếu", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
                Else
                    txtTENSP.Focus()
                    If txtMALOAI.Text = "" Then
                        MessageBox.Show("Bạn chưa nhập mã loại", "Nhập thiếu", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
                    Else
                        txtMALOAI.Focus()
                        If txtSOLUONG.Text = "" Then
                            MessageBox.Show("Bạn chưa nhập số lượng", "Nhập thiếu", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
                        Else
                            addupdate.Parameters.AddWithValue("@MASP", txtMASP.Text)
                            addupdate.Parameters.AddWithValue("@TENSP", txtTENSP.Text)
                            addupdate.Parameters.AddWithValue("@MALOAI", txtMALOAI.Text)
                            addupdate.Parameters.AddWithValue("@TENLOAI", txtTENLOAI.Text)
                            addupdate.Parameters.AddWithValue("@SOLUONG", txtSOLUONG.Text)
                            addupdate.Parameters.AddWithValue("@NHASX", txtNHASX.Text)
                            addupdate.Parameters.AddWithValue("@NHACC", txtNHACC.Text)
                            addupdate.Parameters.AddWithValue("@NGAYSX", txtNGAYSX.Text)
                            addupdate.Parameters.AddWithValue("@THUONGHIEU", txtTHUONGHIEU.Text)
                            addupdate.Parameters.AddWithValue("@HANDUNG", txtHANDUNG.Text)
                            addupdate.Parameters.AddWithValue("@DONGIA", txtDONGIA.Text)
                            addupdate.ExecuteNonQuery()
                            conn.Close() 'đóng kết nối
                            MessageBox.Show("Cập nhật thành công")
                            txtMASP.Text = Nothing
                            txtTENSP.Text = Nothing
                            txtMALOAI.Text = Nothing
                            txtTENLOAI.Text = Nothing
                            txtSOLUONG.Text = Nothing
                            txtNHASX.Text = Nothing
                            txtNHACC.Text = Nothing
                            txtNGAYSX.Text = Nothing
                            txtTHUONGHIEU.Text = Nothing
                            txtHANDUNG.Text = Nothing
                            txtDONGIA.Text = Nothing
                        End If
                    End If
                End If
            End If
        Catch ex As Exception
            MessageBox.Show("Không thành công", "Lỗi", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error)
        End Try

        'Sau khi cập nhật xong sẽ tự làm mới lại bảng
        db.Clear()
        dgvSanpham.DataSource = db
        dgvSanpham.DataSource = Nothing
        LoadData()
    End Sub
    Private Sub LoadData()
        Dim conn As SqlConnection = New SqlConnection(chuoiketnoi)
        Dim load As SqlDataAdapter = New SqlDataAdapter("select SANPHAM.MASP as 'Mã sản phẩm',SANPHAM.TENSP as 'Tên sản phẩm', LOAISANPHAM.MALOAI as 'Mã Loại', LOAISANPHAM.TENLOAI as 'Tên Loại',SANPHAM.SOLUONG as 'Số lượng',SANPHAM.NHASX as 'Nhà Sản Xuất', SANPHAM.NHACC as 'Nhà Cung Cấp', LOAISANPHAM.NGAYSX as 'Ngày Sản Xuất', LOAISANPHAM.THUONGHIEU as 'Thương Hiệu', LOAISANPHAM.HANDUNG as 'Hạn Dùng', LOAISANPHAM.DONGIA as 'Đơn Giá'  from SANPHAM inner join LOAISANPHAM on SANPHAM.MASP = LOAISANPHAM.MASP", conn)

        conn.Open()
        load.Fill(db)
        dgvSanpham.DataSource = db.DefaultView
    End Sub

    Private Sub btnXoa_Click(sender As Object, e As EventArgs) Handles btnXoa.Click
        Dim delquery As String = "delete from SANPHAM where MASP=@MASP delete from LOAISANPHAM where MASP=@MASP"
        Dim delete As SqlCommand = New SqlCommand(delquery, conn)
        Dim resulft As DialogResult = MessageBox.Show("Bạn muốn xóa không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        conn.Open()
        Try
            If txtMASP.Text = "" Then
                MessageBox.Show("Bạn cần nhập mã khách hàng", "Nhập thiếu", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
                txtMASP.Focus()
            Else
                If resulft = Windows.Forms.DialogResult.Yes Then
                    delete.Parameters.AddWithValue("@MASP", txtMASP.Text)
                    delete.ExecuteNonQuery()
                    conn.Close()
                    MessageBox.Show("Xóa thành công")
                    'Sau khi xóa thành công, tự động làm mới các khung textbox
                    txtMASP.Text = Nothing
                    txtTENSP.Text = Nothing
                    txtMALOAI.Text = Nothing
                    txtTENLOAI.Text = Nothing
                    txtSOLUONG.Text = Nothing
                    txtNHASX.Text = Nothing
                    txtNHACC.Text = Nothing
                    txtNGAYSX.Text = Nothing
                    txtTHUONGHIEU.Text = Nothing
                    txtHANDUNG.Text = Nothing
                    txtDONGIA.Text = Nothing
                    txtMASP.Focus()
                End If
            End If
        Catch ex As Exception
            MessageBox.Show("Nhập đúng mã sản phẩm cần xóa", "Lỗi", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error)
        End Try

        'làm mới bảng
        db.Clear()
        dgvSanpham.DataSource = db
        dgvSanpham.DataSource = Nothing
        LoadData()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        txtMASP.Text = Nothing
        txtTENSP.Text = Nothing
        txtMALOAI.Text = Nothing
        txtTENLOAI.Text = Nothing
        txtSOLUONG.Text = Nothing
        txtNHASX.Text = Nothing
        txtNHACC.Text = Nothing
        txtNGAYSX.Text = Nothing
        txtTHUONGHIEU.Text = Nothing
        txtHANDUNG.Text = Nothing
        txtDONGIA.Text = Nothing
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        Main.Show()

    End Sub
End Class