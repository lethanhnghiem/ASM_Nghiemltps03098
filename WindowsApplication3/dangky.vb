Imports System.Data.SqlClient
Imports System.Data.DataTable

Public Class FromDangKy
    Dim db As New DataTable
    Dim chuoiketnoi As String = "workstation id=ASSps03098.mssql.somee.com;packet size=4096;user id=lethanhnghiem_SQLLogin_1;pwd=hbxkau4831;data source=ASSps03098.mssql.somee.com;persist security info=False;initial catalog=ASSps03098"
    Dim conn As SqlConnection = New SqlConnection(chuoiketnoi)

    Private Sub txtID_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btndangky.Click
        Dim conn As SqlConnection = New SqlConnection(chuoiketnoi)
        Dim query As String = "insert into dangnhap values(@Uid,@Pwd)"
        Dim save As SqlCommand = New SqlCommand(query, conn)
        conn.Open()
        Try
            txtID.Focus()
            If txtID.Text = "" Then
                MessageBox.Show("Bạn chưa nhập UserName", "Nhập thiếu", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
            Else
                txtID.Focus()
                If txtPWD.Text = "" Then
                    MessageBox.Show("Bạn chưa nhập PassWord", "Nhập thiếu", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)

                Else
                    save.Parameters.AddWithValue("@Uid", txtID.Text)
                    save.Parameters.AddWithValue("@Pwd", txtPWD.Text)


                    save.ExecuteNonQuery()
                    MessageBox.Show("Đăng Ký Thành Công , Quay Lại để Đăng Nhập ^^!")
                    'Sau khi nhập thành công, tự động làm mới các khung textbox, combox và date....
                    txtID.Text = Nothing
                    txtPWD.Text = Nothing
                    txtdiachi.Text = Nothing

                    txtsodienthoai.Text = Nothing




                End If
            End If


        Catch ex As Exception  'Ngược lại báo lỗi
            MessageBox.Show("trùng Tên Đăng Nhập", "Lỗi", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        Login.Show()

    End Sub
End Class