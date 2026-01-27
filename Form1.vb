Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim formEnroll As New FormEnroll()
        formEnroll.show()
        Me.Hide()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim formAbout As New FormAbout()
        formAbout.Show()
        Me.Hide()

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim FormEvent As New FormEvent()
        FormEvent.Show()
        Me.Hide()
    End Sub

    Private Sub TableLayoutPanel1_Paint(sender As Object, e As PaintEventArgs) Handles TableLayoutPanel1.Paint

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim formShop As New FormShop()
        formShop.Show()
        Me.Hide()
    End Sub

    Private Sub ToolStripComboBox1_Click(sender As Object, e As EventArgs) Handles ToolStripComboBox1.SelectedIndexChanged


        Dim selectedForm As String = ToolStripComboBox1.SelectedItem.ToString()
        Select Case selectedForm
            Case "Home"
                Dim homeForm As New Form1()
                homeForm.Show()
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

    Private Sub ToolStripComboBox1_Click_1(sender As Object, e As EventArgs) Handles ToolStripComboBox1.Click

    End Sub
End Class
