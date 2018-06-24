Public Class frmTheaterRevenue
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ' Clear user input fields
        txtPPTAdult.Text = ""
        txtTSAdult.Text = ""
        txtPPTChild.Text = ""
        txtTSChild.Text = ""

        'Clear Gross Total Revelue labels
        lblGTRAdult.Text = ""
        lblGTRChild.Text = ""
        lblGTRTotal.Text = ""

        ' Clear Net Ticket Revenue
        lblNTRAdult.Text = ""
        lblNTRChild.Text = ""
        lblNTRTotal.Text = ""
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Try
            ' Initialize the variables entered by the user so that they can be calculated
            Dim PPTAdult As Double = CDbl(txtPPTAdult.Text)
            Dim TSAdult As Double = CDbl(txtTSAdult.Text)
            Dim PPTChild As Double = CDbl(txtPPTChild.Text)
            Dim TSChild As Double = CDbl(txtTSChild.Text)

            ' Make calculations for Gross Revenue with the variable
            Dim GTRAdult As Double = PPTAdult * TSAdult
            Dim GTRChild As Double = PPTChild * TSChild
            Dim GTRTotal As Double = GTRAdult + GTRChild

            ' Pass Calculations back as strings to labels
            lblGTRAdult.Text = (GTRAdult.ToString("C"))
            lblGTRChild.Text = (GTRChild.ToString("C"))
            lblGTRTotal.Text = (GTRTotal.ToString("C"))

            ' Innitialize and calculate Net Ticket Revenue
            Const Margin As Double = 0.2
            Dim NTRAdult As Double = GTRAdult * Margin
            Dim NTRChild As Double = GTRChild * Margin
            Dim NTRTotal As Double = GTRTotal * Margin

            ' Pass Net Ticket Revenue back to labels
            lblNTRAdult.Text = (NTRAdult.ToString("C"))
            lblNTRChild.Text = (NTRChild.ToString("C"))
            lblNTRTotal.Text = (NTRTotal.ToString("C"))
        Catch ex As System.InvalidCastException
            MessageBox.Show("Please enter only numbers into EACH of the input boxes" & Microsoft.VisualBasic.Chr(13) & "in order to calculate ticket revenue!", "Invalid or missing input")
        Catch ex As Exception
            MessageBox.Show("Yikes! An unknown error occured! Check the error log for more information.", "Fatal Error")
        End Try

    End Sub

End Class
