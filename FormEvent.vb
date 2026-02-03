Public Class FormEvent
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form1.Show()
        Me.Hide()
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