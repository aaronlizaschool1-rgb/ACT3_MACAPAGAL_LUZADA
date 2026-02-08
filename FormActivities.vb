Imports System.Reflection.Emit

Public Class FormActivities
    Private Total As Integer = 0

    Private Sub formactivities_load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim NAME As String
        NAME = InputBox("Enter your name", "Name", "STUDENT")
        Label1.Text = "Hello " & NAME
        If NAME = "Aaron" Then
            Label1.Text = "Welcome back Aaron"
        ElseIf NAME = "John" Then
            Label1.Text = "Welcome to Visual Basic"
        ElseIf NAME = "" Then
            Label1.Text = "Please enter your name"

        ElseIf NAME = "Berto" Then
            Label1.Text = "Good morning/Good afternoon Ma'am"

        End If

    End Sub



    Private Sub CheckedListBox1_ItemCheck(sender As Object, e As ItemCheckEventArgs) Handles CheckedListBox1.ItemCheck
        Dim selectedItem As String = CheckedListBox1.Items(e.Index).ToString()
        Dim Date_Today As Date = Date.Today
        Dim KarateTotal As Integer = 0
        Dim KarateDate As New List(Of String)
        Dim BoxingTotal As Integer = 0
        Dim BoxingDate As New List(Of String)
        Dim SwimmingTotal As Integer = 0
        Dim swimmingDate As New List(Of String)
        Dim HorsebackTotal As Integer = 0
        Dim HorsebackDate As New List(Of String)
        Dim DanceSportTotal As Integer = 0
        Dim DanceSportDate As New List(Of String)


        Label1.Text = "You selected: " & selectedItem

        Select Case selectedItem

            Case "KARATE"
                KarateTotal = Val(InputBox("Enter the number of KARATE classes you want to enroll in:", " KARATE IS ONCE A WEEK ONLY", "0"))



                For i As Integer = 0 To KarateTotal - 1
                    KarateDate.Add(Date_Today.AddDays(2 + (7 * i)).ToShortDateString())

                Next
                KarateTotal *= 1000
                Total += KarateTotal
                ListBox1.Items.Add("KARATE DATES: " & String.Join(", ", KarateDate))
                ListBox1.Items.Add("KARATE: " & KarateTotal.ToString("C"))

            Case "BOXING"
                BoxingTotal = Val(InputBox("Enter the number of BOXING classes you want to enroll in:", "BOXING IS ONCE A WEEK ONLY", "0"))
                For i As Integer = 0 To BoxingTotal - 1
                    BoxingDate.Add(Date_Today.AddDays(3 + (7 * i)).ToShortDateString())
                Next
                BoxingTotal *= 1500
                Total += BoxingTotal
                ListBox1.Items.Add("BOXING DATES: " & String.Join(", ", BoxingDate))
                ListBox1.Items.Add("BOXING: " & BoxingTotal.ToString("C"))
            Case "SWIMMING"
                SwimmingTotal = Val(InputBox("Enter the number of SWIMMING classes you want to enroll in:", "SWIMMING IS ONCE A WEEK ONLY", "0"))
                For i As Integer = 0 To SwimmingTotal - 1
                    swimmingDate.Add(Date_Today.AddDays(4 + (7 * i)).ToShortDateString())
                Next
                SwimmingTotal *= 2000
                Total += SwimmingTotal
                ListBox1.Items.Add("SWIMMING DATES: " & String.Join(", ", swimmingDate))
                ListBox1.Items.Add("SWIMMING: " & SwimmingTotal.ToString("C"))

            Case "HORSEBACK"
                HorsebackTotal = Val(InputBox("Enter the number of HORSEBACK RIDING classes you want to enroll in:", "HORSEBACK RIDING IS ONCE A WEEK ONLY", "0"))
                For i As Integer = 0 To HorsebackTotal - 1
                    HorsebackDate.Add(Date_Today.AddDays(5 + (7 * i)).ToShortDateString())
                Next
                HorsebackTotal *= 2500
                Total += HorsebackTotal
                ListBox1.Items.Add("HORSEBACK RIDING DATES: " & String.Join(", ", HorsebackDate))
                ListBox1.Items.Add("HORSEBACK RIDING: " & HorsebackTotal.ToString("C"))
            Case "DANCESPORT"
                DanceSportTotal = Val(InputBox("Enter the number of DANCESPORT classes you want to enroll in:", "DANCESPORT IS ONCE A WEEK ONLY", "0"))
                For i As Integer = 0 To DanceSportTotal - 1
                    DanceSportDate.Add(Date_Today.AddDays(6 + (7 * i)).ToShortDateString())
                Next
                DanceSportTotal *= 3000
                Total += DanceSportTotal
                ListBox1.Items.Add("DANCESPORT DATES: " & String.Join(", ", DanceSportDate))
                ListBox1.Items.Add("DANCESPORT: " & DanceSportTotal.ToString("C"))

        End Select


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Payment As Double = 0
        Dim Change As Double = 0
        Payment = Val(InputBox("To Pay: " & Total.ToString(), "Enter your payment amount:", "0"))
        Change = Payment - Total
        If Payment < Total Then
            MessageBox.Show("Insufficient payment. Please enter a valid amount.")
        Else
            MessageBox.Show("Payment successful! Your change is: " & Change.ToString("C"))
        End If
    End Sub

    Private Sub ToolStripComboBox1_Click(sender As Object, e As EventArgs) Handles ToolStripComboBox1.SelectedIndexChanged


        Dim selectedForm As String = ToolStripComboBox1.SelectedItem.ToString()
        Select Case selectedForm
            Case "Home"
                Dim homeForm As New Form1()
                Me.Show()
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

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ListBox1.Items.Clear()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        FormEnroll.Show()
        Me.Hide()
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged

    End Sub
End Class
