Imports System.ComponentModel
Imports System.Runtime.InteropServices
Imports ACT3_MACAPAGAL_LUZADA.FormTeacher
Public Class FormTeacher

    Const MAX_TEACHERS As Integer = 10

    Dim teachers As New BindingList(Of Teacher_Structure)
    Class Teacher_Structure
        Public Property Name As String
        Public Property Specialization As String
        Public Property WorkingHours As Integer = 0
        Public Property WorkingHours_Max As Integer = 7
        Public Property AssignedClasses As New List(Of String)
        Public Property IsOnLeave As Boolean = False

        Public Sub New(name As String, specialization As String)
            Me.Name = name
            Me.Specialization = specialization
        End Sub

        Public Sub AssignClass(className As String, hours As Integer)
            If IsOnLeave Then
                MessageBox.Show($"{Name} is currently on leave.")
                Exit Sub
            End If

            If WorkingHours + hours <= WorkingHours_Max Then
                AssignedClasses.Add(className)
                WorkingHours += hours
            Else
                MessageBox.Show($"Cannot assign {className} to {Name}. Exceeds maximum working hours.")
            End If
        End Sub
    End Class


    Private Sub RefreshDisplay()

        Dim displayList = teachers.Select(Function(t) New With {
            Key .Name = t.Name,
            Key .Specialization = t.Specialization,
            Key .WorkingHours_Max = t.WorkingHours_Max,
            Key .WorkingHours = t.WorkingHours,
            Key .Status = If(t.IsOnLeave, "On Leave", "Active"),
            Key .AssignedClasses = String.Join(", ", t.AssignedClasses)
        }).ToList()

        DataGridView1.DataSource = Nothing
        DataGridView1.DataSource = displayList


        ListBox1.DataSource = Nothing
        ListBox1.DataSource = teachers
        ListBox1.DisplayMember = "Name"


        For Each subject As String In teachers.SelectMany(Function(t) t.AssignedClasses).Distinct()
            If Not ListBox2.Items.Contains(subject) Then
                ListBox2.DataSource = Nothing

                ListBox2.Items.Add(subject)
            End If
        Next



    End Sub

    ' Current Button +++++
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        teachers.Clear()
        teachers.Add(New Teacher_Structure("Clara G. Bascon", "Mathematics"))
        teachers.Add(New Teacher_Structure("Maria Elda V. Romero", "Science"))
        teachers.Add(New Teacher_Structure("Helen L. Cayetano", "English"))
        teachers.Add(New Teacher_Structure("Joy Marie T. Panaga", "Filipino"))
        teachers.Add(New Teacher_Structure("Rene B. Ocson", "Social Studies"))
        teachers.Add(New Teacher_Structure("Riza C. Dailo", "Physical Education"))
        teachers.Add(New Teacher_Structure("Edna B. Arriola", "Music"))

        RefreshDisplay()
    End Sub

    'assign class button +++++++
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        If ListBox1.SelectedIndex = -1 Then
            MessageBox.Show("Select a teacher first.")
            Exit Sub
        End If

        Dim subject As String = InputBox("Enter the subject to assign:", "Assign Class")
        If String.IsNullOrWhiteSpace(subject) Then
            MessageBox.Show("Subject cannot be empty.")
            Exit Sub
        End If

        If subject.Length > 20 Then
            MessageBox.Show("Subject name is too long. Please limit to 20 characters.")
            Exit Sub
        End If

        If subject.Any(Function(c) Not Char.IsLetterOrDigit(c) AndAlso Not Char.IsWhiteSpace(c)) Then
            MessageBox.Show("Subject name can only contain letters, numbers, and spaces.")
            Exit Sub
        End If

        If teachers.Any(Function(t) t.AssignedClasses.Contains(subject)) Then
            MessageBox.Show("This subject is already assigned to another teacher.")
            Exit Sub
        End If


        Dim hoursInput = InputBox("Enter hours for the subject:", "Assign Class")
        Dim hours As Integer
        If Not Integer.TryParse(hoursInput, hours) Then
            MessageBox.Show("Invalid input for hours.")
            Exit Sub
        End If

        Dim selectedTeacher As Teacher_Structure = CType(ListBox1.SelectedItem, Teacher_Structure)
        selectedTeacher.AssignClass(subject, hours)


        RefreshDisplay()
    End Sub




    ' Status Button for Leave/Active +++++++
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        If ListBox1.SelectedIndex = -1 Then
            MessageBox.Show("Select a teacher first.")
            Exit Sub
        End If

        Dim selectedTeacher As Teacher_Structure = CType(ListBox1.SelectedItem, Teacher_Structure)


        selectedTeacher.IsOnLeave = Not selectedTeacher.IsOnLeave
        MessageBox.Show($"{selectedTeacher.Name} is now {(If(selectedTeacher.IsOnLeave, "On Leave", "Active"))}.")
        RefreshDisplay()
    End Sub

    ' Delete teacher button +++++++
    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        If ListBox1.SelectedIndex = -1 Then
            MessageBox.Show("Select a teacher to delete.")
            Exit Sub
        End If

        Dim selectedTeacher As Teacher_Structure = CType(ListBox1.SelectedItem, Teacher_Structure)
        teachers.Remove(selectedTeacher)
        MessageBox.Show("Teacher deleted successfully.")
        RefreshDisplay()
    End Sub
    ' Remove subject from teacher button +++++++
    Private Sub button2_click(sender As Object, e As EventArgs) Handles Button2.Click
        If ListBox2.SelectedIndex = -1 Then

            MessageBox.Show("Select a subject to remove.")
            Exit Sub
        End If

        Dim selectedSubject As String = ListBox2.SelectedItem.ToString()
        Dim hours As Integer
        hours = InputBox("Enter hours to remove from the subject:", "Remove Class")
        For Each teacher As Teacher_Structure In teachers
            If hours = teacher.WorkingHours Then


                If teacher.AssignedClasses.Contains(selectedSubject) Then
                    teacher.AssignedClasses.Remove(selectedSubject)
                    teacher.WorkingHours -= hours
                End If

            End If
            If hours < teacher.WorkingHours Then
                MessageBox.Show($"Cannot remove {hours} hours from {teacher.Name}. Not enough working hours assigned.")
            End If
        Next


        MessageBox.Show("Subject removed from teachers")
        ListBox2.Items.Remove(selectedSubject)
        RefreshDisplay()

    End Sub
    'add new teacher button +++++++
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If teachers.Count >= MAX_TEACHERS Then
            MessageBox.Show("Maximum number of teachers reached!")
            Exit Sub
        End If


        Dim name = InputBox("Enter the new teacher's name:", "New Teacher")
        If String.IsNullOrWhiteSpace(name) Then
            MessageBox.Show("Name cannot be empty.")
            Exit Sub
        End If


        Dim specialization = InputBox("Enter the new teacher's specialization:", "New Teacher")
        If String.IsNullOrWhiteSpace(specialization) Then
            MessageBox.Show("Specialization cannot be empty.")
            Exit Sub
        End If


        teachers.Add(New Teacher_Structure(name, specialization))


        RefreshDisplay()
    End Sub


End Class