Public Class frmAbout
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Process.Start("https://www.pixiv.net/member_illust.php?mode=medium&illust_id=70623640")
    End Sub
    Private Sub BtnInfo_Click(sender As Object, e As EventArgs) Handles btnInfo.Click
        Dim line1 As String
        Dim line2 As String

        line1 = My.Application.Info.Copyright.ToString()
        line2 = My.Application.Info.Version.ToString()
        MsgBox(line1 + vbNewLine + "Version: " & line2)
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Process.Start("https://twitter.com/frzvoid")
    End Sub
End Class