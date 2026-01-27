Public Class FormAbout

    Dim Place As String = " "
    Private Sub FormAbout_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub TableLayoutPanel1_Paint(sender As Object, e As PaintEventArgs) Handles TableLayoutPanel1.Paint

    End Sub

    Private Sub Button1_ClickMission(sender As Object, e As EventArgs) Handles Button1.Click
        Place = "Mission"
        PictureBox1.Image = My.Resources.MISSION



    End Sub

    Private Sub Button4_ClickPledge(sender As Object, e As EventArgs) Handles Button4.Click
        Place = "Pledge"
        PictureBox1.Image = My.Resources.PLEDGE
    End Sub

    Private Sub Button5_ClickExit(sender As Object, e As EventArgs) Handles Button5.Click
        Form1.Show()
        Me.Hide()

    End Sub

    Private Sub Button2_ClickVision(sender As Object, e As EventArgs) Handles Button2.Click
        Place = "Vision"
        PictureBox1.Image = My.Resources.VISION
    End Sub

    Private Sub Button3_ClickHymn(sender As Object, e As EventArgs) Handles Button3.Click
        Place = "Hymn"
        PictureBox1.Image = My.Resources.HYMN
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Select Case Place
            Case "Mission"



        End Select
    End Sub
End Class