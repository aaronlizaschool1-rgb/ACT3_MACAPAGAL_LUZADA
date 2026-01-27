Public Class FormEnroll

    Dim TuitionFee As Integer = 28000


    Private Function CalculateTotal() As Integer
        Dim total As Integer = TuitionFee


        If chkmath.Checked Then total += 1000
        If chkscience.Checked Then total += 1000
        If chkenglish.Checked Then total += 700
        If chkfilipino.Checked Then total += 900
        If chkap.Checked Then total += 800
        If chkesp.Checked Then total += 700
        If chkcomputer.Checked Then total += 600


        If chkPolosmall.Checked Then total += 500 * PoloQuantity.Value
        If chkPolomed.Checked Then total += 550 * PoloQuantity.Value
        If chkPololarge.Checked Then total += 600 * PoloQuantity.Value
        If chkPoloxl.Checked Then total += 650 * PoloQuantity.Value


        If chkpantssmall.Checked Then total += 700 * PantsQuantity.Value
        If chkpantsmed.Checked Then total += 750 * PantsQuantity.Value
        If chkpantslarge.Checked Then total += 800 * PantsQuantity.Value
        If chkpantsxl.Checked Then total += 850 * PantsQuantity.Value


        If chkskirtsmall.Checked Then total += 700 * SkirtQuantity.Value
        If chkskirtmed.Checked Then total += 750 * SkirtQuantity.Value
        If chkskirtlarge.Checked Then total += 800 * SkirtQuantity.Value
        If chkskirtxl.Checked Then total += 850 * SkirtQuantity.Value


        If chkbus.Checked Then total += 1500
        If chklab.Checked Then total += 2300

        Return total
    End Function

    Private Sub UpdateTotalLabel()
        Dim total As Integer = CalculateTotal()

        If chktlc.Checked Then
            lblTotal.Text = "₱0.00"
        Else
            lblTotal.Text = "₱" & total.ToString("N2")
        End If
    End Sub


    Private Sub Any_CheckedChanged(sender As Object, e As EventArgs) Handles _
        chkmath.CheckedChanged, chkscience.CheckedChanged, chkenglish.CheckedChanged,
        chkfilipino.CheckedChanged, chkap.CheckedChanged, chkesp.CheckedChanged,
        chkcomputer.CheckedChanged, chkPolosmall.CheckedChanged, chkPolomed.CheckedChanged,
        chkPololarge.CheckedChanged, chkPoloxl.CheckedChanged,
        chkpantssmall.CheckedChanged, chkpantsmed.CheckedChanged,
        chkpantslarge.CheckedChanged, chkpantsxl.CheckedChanged,
        chkskirtsmall.CheckedChanged, chkskirtmed.CheckedChanged,
        chkskirtlarge.CheckedChanged, chkskirtxl.CheckedChanged,
        chkbus.CheckedChanged, chklab.CheckedChanged, chktlc.CheckedChanged,
        chkreferral.CheckedChanged

        UpdateTotalLabel()
    End Sub

    Private Sub PoloQuantity_ValueChanged(sender As Object, e As EventArgs) Handles PoloQuantity.ValueChanged
        UpdateTotalLabel()
    End Sub

    Private Sub PantsQuantity_ValueChanged(sender As Object, e As EventArgs) Handles PantsQuantity.ValueChanged
        UpdateTotalLabel()
    End Sub

    Private Sub SkirtQuantity_ValueChanged(sender As Object, e As EventArgs) Handles SkirtQuantity.ValueChanged
        UpdateTotalLabel()
    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim total As Integer = CalculateTotal()
        Dim discountAmount As Double = 0
        Dim discountText As String = ""

        If chktlc.Checked Then
            discountAmount = total
            discountText = "TLC SCHOLAR (100%)"
        ElseIf chkreferral.Checked Then
            discountAmount = total * 0.1
            discountText = "REFERRAL (10%)"
        End If

        total -= discountAmount

        If Not IsNumeric(txtPayment.Text) Then
            MessageBox.Show("Please enter a valid payment amount.")
            Exit Sub
        End If

        Dim payment As Double = CDbl(txtPayment.Text)

        If payment < total Then
            MessageBox.Show("Insufficient payment.")
            Exit Sub
        End If

        Dim change As Double = payment - total

        Dim message As String =
            "Tuition Fee: ₱" & TuitionFee.ToString("N2") & vbCrLf &
            If(discountAmount > 0, "Discount (" & discountText & "): -₱" & discountAmount.ToString("N2") & vbCrLf, "") &
            "Total Due: ₱" & total.ToString("N2") & vbCrLf &
            "Cash Given: ₱" & payment.ToString("N2") & vbCrLf &
            "Change: ₱" & change.ToString("N2")

        MessageBox.Show(message, "Payment Summary")
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Form1.Show()
        Me.Hide()
    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TextBox3.TextChanged

    End Sub
End Class