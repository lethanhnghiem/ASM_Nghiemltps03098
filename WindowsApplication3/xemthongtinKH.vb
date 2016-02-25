Imports System.Data.SqlClient
Imports System.Data

Public Class xemthongtinKH
    Dim db As New DataTable
    Dim chuoiketnoi As String = "workstation id=ASSps03098.mssql.somee.com;packet size=4096;user id=lethanhnghiem_SQLLogin_1;pwd=hbxkau4831;data source=ASSps03098.mssql.somee.com;persist security info=False;initial catalog=ASSps03098"
    Dim connect As SqlConnection = New SqlConnection(chuoiketnoi)
    Private Sub xemthongtinKH_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnxem_Click(sender As Object, e As EventArgs) Handles btnxem.Click
        Dim connect As SqlConnection = New SqlConnection(chuoiketnoi)
        connect.Open()
        Dim xem As SqlDataAdapter = New SqlDataAdapter("select MAKH as 'Mã KH' ,TENKH as 'Tên Khách Hàng', DIACHI as 'Địa chỉ', SDT as 'SĐT', NGAYSINH, PHANHOIKH, EMAIL from KHACHHANG where MAKH='" & txtMAKH.Text & "'", connect)
        Try
            If txtMAKH.Text = "" Then
                MessageBox.Show("Bạn cần nhập MAKH", "Nhập thiếu", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)

            Else
                db.Clear()
                dgvxemkh.DataSource = Nothing
                xem.Fill(db)
                If db.Rows.Count > 0 Then
                    dgvxemkh.DataSource = db.DefaultView
                    txtMAKH.Text = Nothing
                Else
                    MessageBox.Show("Không tìm thấy")
                    txtMAKH.Text = Nothing
                End If
            End If
            connect.Close()
        Catch ex As Exception
        End Try

    End Sub

    Private Sub btnxemall_Click(sender As Object, e As EventArgs) Handles btnxemall.Click
        Dim hienthi As New Class1
        dgvxemkh.DataSource = hienthi.Loadkhachang.Tables(0)
    End Sub

    Private Sub btnquaylai_Click(sender As Object, e As EventArgs) Handles btnquaylai.Click
        Main.Show()
        Me.Hide()
    End Sub

    Private Sub txtMAKH_TextChanged(sender As Object, e As EventArgs) Handles txtMAKH.TextChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        txtMAKH = Nothing
    End Sub
End Class