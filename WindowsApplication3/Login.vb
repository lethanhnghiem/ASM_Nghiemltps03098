Imports System.Data.SqlClient


Public Class Login

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim conn As New SqlConnection("workstation id=ASSps03098.mssql.somee.com;packet size=4096;user id=lethanhnghiem_SQLLogin_1;pwd=hbxkau4831;data source=ASSps03098.mssql.somee.com;persist security info=False;initial catalog=ASSps03098")
        Dim sqladap = New SqlDataAdapter("select * from dangnhap where uid='" & txtuser.Text & "' and pwd='" & txtpassword.Text & "'", conn)
        Dim tb As New DataTable()
        Try
            conn.Open()
            sqladap.Fill(tb)
        Catch ex As Exception

        End Try
        If (tb.Rows.Count > 0) Then
            Dim f As New Loading()
            f.Show()
            Me.Hide()
        Else
            MessageBox.Show(" Nhập Sai Or Thiếu")
        End If


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        FromDangKy.Show()

    End Sub
End Class
