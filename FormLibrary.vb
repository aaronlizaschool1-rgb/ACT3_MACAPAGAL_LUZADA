Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class FormLibrary
    Private Date_Today As Date = Date.Today
    Private addeddays As Integer = 0

    Private Due_Date As Date = Date_Today.AddDays(addeddays)




    Private Sub CheckedListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CheckedListBox1.ItemCheck

        Select Case CheckedListBox1.SelectedItem

            Case "Mathematics Textbook"
                DataGridView1.Rows.Add("Mathematics Textbook", " Basic Mathematics", "Rex Book Store", Date_Today.ToString())
                DataGridView1.Rows.Add("Mathematics Textbook", " New Mathematics Today", "Vibal Group", Date_Today.ToString())
                DataGridView1.Rows.Add("Mathematics Textbook", " College Algebra", "Corazon D. Villamin et al.", Date_Today.ToString())

            Case "English Textbook"
                DataGridView1.Rows.Add("English Textbook", " Language in Literature", "Phoenix Publishing", Date_Today.ToString())
                DataGridView1.Rows.Add("English Textbook", " English for Academic and Professional Purposes", "Rex Book Store", Date_Today.ToString())
                DataGridView1.Rows.Add("English Textbook", "Oral Communication in Context ", "Vibal Group ", Date_Today.ToString())
                DataGridView1.Rows.Add("English Textbook", "Reading and Writing Skills ", " CHED SHS textbook", Date_Today.ToString())

            Case "English Literature"
                DataGridView1.Rows.Add("English Literature", "The Norton Anthology of English Literature", "W. W. Norton & Company", Date_Today.ToString())
                DataGridView1.Rows.Add("English Literature", "Pride and Prejudice", "Jane Austen", Date_Today.ToString())
                DataGridView1.Rows.Add("English Literature", "Hamlet", "William Shakespeare", Date_Today.ToString())

            Case "Filipino Textbook"
                DataGridView1.Rows.Add("Filipino Textbook", "Pagbasa at Pagsulat Tungo sa Pananaliksik", "C & E Publishing", Date_Today.ToString())
                DataGridView1.Rows.Add("Filipino Textbook", "Filipino sa Piling Larang", "Rex Book Store", Date_Today.ToString())
                DataGridView1.Rows.Add("Filipino Textbook", "Wika at Kultura", "Vibal Group", Date_Today.ToString())

            Case "Mapeh Textbook"
                DataGridView1.Rows.Add("Mapeh Textbook", "Understanding Arts", "Rex Book Store", Date_Today.ToString())
                DataGridView1.Rows.Add("Mapeh Textbook", "Physical Education and Health", "Vibal Group", Date_Today.ToString())
                DataGridView1.Rows.Add("Mapeh Textbook", "Music and Dance", "C & E Publishing", Date_Today.ToString())

            Case "Science Textbook"
                DataGridView1.Rows.Add("Science Textbook", "General Biology ", "CHED SHS ", Date_Today.ToString())
                DataGridView1.Rows.Add("Science Textbook", "Earth and Life Science ", " Rex Book Store", Date_Today.ToString())
                DataGridView1.Rows.Add("Science Textbook", "Physical Science ", "Phoenix Publishing ", Date_Today.ToString())
                DataGridView1.Rows.Add("Science Textbook", "Science, Technology, and Society ", "CHED-aligned ", Date_Today.ToString())

            Case "Local Scientific Journal"
                DataGridView1.Rows.Add("Local Scientific Journal", "Philippine Journal of Science", "Department of Science and Technology", Date_Today.ToString())
                DataGridView1.Rows.Add("Local Scientific Journal", "Asian Journal of Agriculture and Development", "Asian Society of Agricultural Economists", Date_Today.ToString())
                DataGridView1.Rows.Add("Local Scientific Journal", "Philippine Journal of Crop Science", "Crop Science Society of the Philippines", Date_Today.ToString())

            Case "Science International Journal"
                DataGridView1.Rows.Add("Science International Journal", "Nature", "Nature Publishing Group", Date_Today.ToString())
                DataGridView1.Rows.Add("Science International Journal", "Science", "American Association for the Advancement of Science", Date_Today.ToString())
                DataGridView1.Rows.Add("Science International Journal", "The Lancet", "Elsevier", Date_Today.ToString())
        End Select


    End Sub

    Private Sub DomainUpDown1_SelectedItemChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        If e.RowIndex >= 0 AndAlso e.ColumnIndex = 5 Then

            addeddays = NumericUpDown1.Value


            Dim Due_Date As Date = Date_Today.AddDays(addeddays)



            DataGridView1.Rows(e.RowIndex).Cells(4).Value = Due_Date.ToString()






        End If



    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick

    End Sub
    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        If DataGridView1.CurrentRow Is Nothing Then Exit Sub

        ListBox1.Items.Add(DataGridView1.CurrentRow.Cells(1).Value.ToString() & " - " &
                            DataGridView1.CurrentRow.Cells(2).Value.ToString() & " - " &
                            DataGridView1.CurrentRow.Cells(3).Value.ToString() & " - " &
                            DataGridView1.CurrentRow.Cells(4).Value.ToString() & " - " &
                            DataGridView1.CurrentRow.Cells(5).Value.ToString()
                            )
    End Sub

    Private Sub MenuStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ListBox1.Items.Clear()

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Form1.Show()
        Me.Close()
    End Sub
End Class