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


    Private Sub ToolStripComboBox1_Click(sender As Object, e As EventArgs) Handles ToolStripComboBox1.SelectedIndexChanged


        Dim selectedForm As String = ToolStripComboBox1.SelectedItem.ToString()
        Select Case selectedForm
            Case "Home"
                Dim homeForm As New Form1()
                Form1.Show()
                Me.Hide()
            Case "Enroll"
                Dim enrollForm As New FormEnroll()
                enrollForm.Show()
                Me.Hide()
            Case "Shop"
                Dim shopForm As New FormShop()
                shopForm.Show()
                Me.Hide()
            Case "Events"
                Dim eventsForm As New FormEvent()
                eventsForm.Show()
                Me.Hide()
            Case "About Us"
                Dim aboutForm As New FormAbout()
                aboutForm.Show()
                Me.Hide()
            Case "Library"
                Dim libraryForm As New FormLibrary()
                libraryForm.Show()
                Me.Hide()
        End Select

    End Sub


End Class