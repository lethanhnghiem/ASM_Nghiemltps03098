Imports System.Data.SqlClient
Imports System.Data

Public Class Class1
    Public Function Loadkhachang() As DataSet
        'copy tu Host vao Ung dung cua chung ta
        Dim chuoiketnoi As String = "workstation id=ASSps03098.mssql.somee.com;packet size=4096;user id=lethanhnghiem_SQLLogin_1;pwd=hbxkau4831;data source=ASSps03098.mssql.somee.com;persist security info=False;initial catalog=ASSps03098"
        Dim conn As SqlConnection = New SqlConnection(chuoiketnoi)
        Dim LoadKH As New SqlDataAdapter("select MAKH as 'Mã KH' ,TENKH as 'Tên Khách Hàng', DIACHI as 'Địa chỉ', SDT as 'SĐT', NGAYSINH, PHANHOIKH, EMAIL from KHACHHANG", conn)
        Dim db As New DataSet
        conn.Open()
        LoadKH.Fill(db)
        conn.Close()
        Return db
    End Function
    Public Function Loadsanpham() As DataSet
        Dim chuoiketnoi As String = "workstation id=ASSps03098.mssql.somee.com;packet size=4096;user id=lethanhnghiem_SQLLogin_1;pwd=hbxkau4831;data source=ASSps03098.mssql.somee.com;persist security info=False;initial catalog=ASSps03098"
        Dim conn As SqlConnection = New SqlConnection(chuoiketnoi)
        Dim LoadSP As New SqlDataAdapter("select SANPHAM.MASP as 'Mã sản phẩm',SANPHAM.TENSP as 'Tên sản phẩm', LOAISANPHAM.MALOAI as 'Mã Loại', LOAISANPHAM.TENLOAI as 'Tên Loại',SANPHAM.SOLUONG as 'Số lượng',SANPHAM.NHASX as 'Nhà Sản Xuất', SANPHAM.NHACC as 'Nhà Cung Cấp', LOAISANPHAM.NGAYSX as 'Ngày Sản Xuất', LOAISANPHAM.THUONGHIEU as 'Thương Hiệu', LOAISANPHAM.HANDUNG as 'Hạn Dùng', LOAISANPHAM.DONGIA as 'Đơn Giá'  from SANPHAM inner join LOAISANPHAM on SANPHAM.MASP = LOAISANPHAM.MASP", conn)
        Dim db As New DataSet
        conn.Open()
        LoadSP.Fill(db)
        conn.Close()
        Return db
    End Function
End Class
