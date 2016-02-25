Public Class Main

    Private Sub KHToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles KHToolStripMenuItem.Click
        thongtinkhachhang.Show()
        Me.Hide()

    End Sub

    Private Sub XenThongTInKHToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles XenThongTInKHToolStripMenuItem.Click
        Me.Hide()
        xemthongtinKH.Show()

    End Sub

    Private Sub SPToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SPToolStripMenuItem.Click
        Me.Hide()
        thongtinsanpham.Show()

    End Sub

    Private Sub XemTHongTinSPToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles XemTHongTinSPToolStripMenuItem.Click
        Me.Hide()
        xemthongtinsanpham.Show()


    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        thongtinsanpham.Show()
        Me.Hide()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        thongtinkhachhang.Show()
        Me.Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        xemthongtinKH.Show()
        Me.Hide()

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        xemthongtinsanpham.Show()
        Me.Hide()

    End Sub

    Private Sub Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class