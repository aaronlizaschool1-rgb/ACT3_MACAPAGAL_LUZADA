Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class FormShop

    Dim total As Integer = 0
    Dim cash As Integer = 0
    Dim lastadded As Integer = 0
    Dim change As Integer = 0
    Private Sub FormShop_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub TableLayoutPanel1_Paint(sender As Object, e As PaintEventArgs) Handles TableLayoutPanel1.Paint

    End Sub

    Private Sub CheckedListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CheckedListBox1.ItemCheck

        For Each Item As String In CheckedListBox1.CheckedItems
            Select Case Item
                Case "Pencil"
                    total += (10 * NumericUpDown1.Value)
                    lastadded = 10 * NumericUpDown1.Value
                    ListBox1.Items.Add("Pencil - 10 " & "Quantity: " & NumericUpDown1.Value.ToString() & "pcs"
                        )
                    ListBox2.Items.Add("Reciept " & ListBox1.Items.Count & ": " & "Pencil - 10 " & "Quantity: " & NumericUpDown1.Value.ToString() & "pcs" & " Item Total: " & lastadded.ToString()
                        )

                Case "Eraser"
                    total += (5 * NumericUpDown1.Value)
                    lastadded = 5 * NumericUpDown1.Value
                    ListBox1.Items.Add("Eraser - 5 " & "Quantity: " & NumericUpDown1.Value.ToString() & "pcs"
                                       )
                    ListBox2.Items.Add("Reciept " & ListBox1.Items.Count & ": " & "Eraser - 5 " & "Quantity: " & NumericUpDown1.Value.ToString() & "pcs" & " Item Total: " & lastadded.ToString()
                        )
                Case "Sharpener"
                    total += (10 * NumericUpDown1.Value)
                    lastadded = 10 * NumericUpDown1.Value
                    ListBox1.Items.Add("Sharpener - 10 " & "Quantity: " & NumericUpDown1.Value.ToString() & "pcs"
                                       )
                    ListBox2.Items.Add("Reciept " & ListBox1.Items.Count & ": " & "Sharpener - 10 " & "Quantity: " & NumericUpDown1.Value.ToString() & "pcs" & " Item Total: " & lastadded.ToString()
                        )
                Case "Ballpen"
                    total += (10 * NumericUpDown1.Value)
                    lastadded = 10 * NumericUpDown1.Value
                    ListBox1.Items.Add("Ballpen - 10 " & "Quantity: " & NumericUpDown1.Value.ToString() & "pcs"
                        )
                    ListBox2.Items.Add("Reciept " & ListBox1.Items.Count & ": " & "Ballpen - 10 " & "Quantity: " & NumericUpDown1.Value.ToString() & "pcs" & " Item Total: " & lastadded.ToString()
                        )
                Case "Water Color"
                    total += (30 * NumericUpDown1.Value)
                    lastadded = 30 * NumericUpDown1.Value
                    ListBox1.Items.Add("Water Color - 30 " & "Quantity: " & NumericUpDown1.Value.ToString() & "pcs"
                        )
                    ListBox2.Items.Add("Reciept " & ListBox1.Items.Count & ": " & "Water Color - 30 " & "Quantity: " & NumericUpDown1.Value.ToString() & "pcs" & " Item Total: " & lastadded.ToString()
                        )
                Case "Coloring Pencil"
                    total += (20 * NumericUpDown1.Value)
                    lastadded = 20 * NumericUpDown1.Value
                    ListBox1.Items.Add("Coloring Pencil - 20 " & "Quantity: " & NumericUpDown1.Value.ToString() & "pcs"
                        )
                    ListBox2.Items.Add("Reciept " & ListBox1.Items.Count & ": " & "Coloring Pencil - 20 " & "Quantity: " & NumericUpDown1.Value.ToString() & "pcs" & " Item Total: " & lastadded.ToString()
                        )
                Case "Pencil Case"
                    total += (30 * NumericUpDown1.Value)
                    lastadded = 30 * NumericUpDown1.Value
                    ListBox1.Items.Add("Pencil Case - 30 " & "Quantity: " & NumericUpDown1.Value.ToString() & "pcs"
                        )
                    ListBox2.Items.Add("Reciept " & ListBox1.Items.Count & ": " & "Pencil Case - 30 " & "Quantity: " & NumericUpDown1.Value.ToString() & "pcs" & " Item Total: " & lastadded.ToString()
                        )
                Case "Ruler"
                    total += (10 * NumericUpDown1.Value)
                    lastadded = 10 * NumericUpDown1.Value
                    ListBox1.Items.Add("Ruler - 10 " & "Quantity: " & NumericUpDown1.Value.ToString() & "pcs"
                        )
                    ListBox2.Items.Add("Reciept " & ListBox1.Items.Count & ": " & "Ruler - 10 " & "Quantity: " & NumericUpDown1.Value.ToString() & "pcs" & " Item Total: " & lastadded.ToString()
                        )
                Case "1 Whole Paper"
                    total += (25 * NumericUpDown1.Value)
                    lastadded = 25 * NumericUpDown1.Value
                    ListBox1.Items.Add("1 Whole Paper - 25 " & "Quantity: " & NumericUpDown1.Value.ToString() & "pcs"
                        )
                    ListBox2.Items.Add("Reciept " & ListBox1.Items.Count & ": " & "1 Whole Paper - 25 " & "Quantity: " & NumericUpDown1.Value.ToString() & "pcs" & " Item Total: " & lastadded.ToString()
                        )
                Case "1/2 Paper"
                    total += (20 * NumericUpDown1.Value)
                    lastadded = 20 * NumericUpDown1.Value
                    ListBox1.Items.Add("1/2 Paper - 20 " & "Quantity: " & NumericUpDown1.Value.ToString() & "pcs"
                        )
                    ListBox2.Items.Add("Reciept " & ListBox1.Items.Count & ": " & "1/2 Paper - 20 " & "Quantity: " & NumericUpDown1.Value.ToString() & "pcs" & " Item Total: " & lastadded.ToString()
                        )
                Case "1/4 Paper"
                    total += (15 * NumericUpDown1.Value)
                    lastadded = 15* NumericUpDown1.Value
                    ListBox1.Items.Add("1/4 Paper - 15 " & "Quantity: " & NumericUpDown1.Value.ToString() & "pcs"
                        )
                    ListBox2.Items.Add("Reciept " & ListBox1.Items.Count & ": " & "1/4 Paperm " & "Quantity: " & NumericUpDown1.Value.ToString() & "pcs" & " Item Total: " & lastadded.ToString()
                        )

                Case Else
                    LabelTotal.Text = "Item not found."
            End Select

        Next

        LabelTotal.Text = "Total to Pay: " & total.ToString()
        LabelSelected.Text = "Items Selected: " & CheckedListBox1.CheckedItems.Count.ToString()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        total -= lastadded
        LabelTotal.Text = "Total to Pay: " & total.ToString()

        If ListBox1.Items.Count > 0 Then
            ListBox1.Items.RemoveAt(ListBox1.Items.Count - 1)
            ListBox2.Items.RemoveAt(ListBox2.Items.Count - 1)
            LabelSelected.Text = ListBox1.Items.Count.ToString()



        End If
    End Sub



    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        TextBox1.Text = cash
        change = cash - total
        LabelEnd.Text = "Change: " & change.ToString()
    End Sub

    Private Sub LabelSelected_Click(sender As Object, e As EventArgs) Handles LabelSelected.Click

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        total = 0
        lastadded = 0
        LabelTotal.Text = "Total to Pay: 0"
        ListBox1.Items.Clear()
        ListBox2.Items.Clear()

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        Integer.TryParse(TextBox1.Text, cash)
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Form1.Show()
        Me.Close()
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged

    End Sub

    Private Sub ListBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox2.SelectedIndexChanged

    End Sub

    Private Sub CheckedListBox1_SelectedIndexChanged_1(sender As Object, e As EventArgs) Handles CheckedListBox1.SelectedIndexChanged

    End Sub
End Class