Public Class Form1
    Dim serviceLabor As Double
    Dim Parts As Double
    Dim total As Double
    Dim taxTotal As Double

    Dim GroupTotals As Double
    Const tax As Double = 0.06

    '==========================================================================================
    '                                           Check box functions
    '==========================================================================================

    ' Calculates the Oil and Lube section returning the value if the boolen evaluates to true
    Private Function CalcOilLubeCharges() As Decimal
        If (chkOilChange.Checked And chkLube.Checked) Then
            Return 64.0
        ElseIf (chkOilChange.Checked) Then
            Return 36.0
        ElseIf (chkLube.Checked) Then
            Return 28.0
        End If
        Return 0
    End Function

    ' Calculates the Flush and Transmission section returning the value if the boolen evaluates to true
    Private Function CalcFlushCharges() As Decimal
        If (chkRadiatorFlush.Checked And chkTransmission.Checked) Then
            Return 170.0
        ElseIf (chkRadiatorFlush.Checked) Then
            Return 50.0
        ElseIf (chkTransmission.Checked) Then
            Return 120.0
        End If
        Return 0
    End Function

    ' Calculates the Miscelaneous section returning the value if the boolen evaluates to true
    Private Function CalcMiscCharges() As Decimal
        If (chkInspection.Checked And chkReplaceMuffler.Checked And chkTireRotation.Checked) Then
            Return 235.0
        ElseIf (chkInspection.Checked And chkReplaceMuffler.Checked) Then
            Return 215.0
        ElseIf (chkInspection.Checked And chkTireRotation.Checked) Then
            Return 35.0
        ElseIf (chkReplaceMuffler.Checked And chkTireRotation.Checked) Then
            Return 220.0
        ElseIf (chkInspection.Checked) Then
            Return 15.0
        ElseIf (chkReplaceMuffler.Checked) Then
            Return 200
        ElseIf (chkTireRotation.Checked) Then
            Return 20
        End If
        Return 0
    End Function

    '==========================================================================================
    '                                           Clear Check Boxes Sub Routine
    '==========================================================================================

    ' Clear section by making checked property false
    Private Sub ClearOilLube()
        chkOilChange.Checked = False
        chkLube.Checked = False
    End Sub

    ' Clear section by making checked property false
    Private Sub ClearFlushes()
        chkRadiatorFlush.Checked = False
        chkTransmission.Checked = False
    End Sub

    ' Clear section by making checked property false
    Private Sub ClearMisc()
        chkInspection.Checked = False
        chkReplaceMuffler.Checked = False
        chkTireRotation.Checked = False
    End Sub

    ' Clear section by making checked property false
    Private Sub ClearOther()
        txtLabor.Text = ""
        txtParts.Text = ""
    End Sub

    Private Sub ClearFees()
        lblServiceTotal.Text = ""
        lblPartsTotal.Text = ""
        lblTaxTotal.Text = ""
        lblTotalTotal.Text = ""
    End Sub

    '==========================================================================================
    '                              Calculation , Clear, Close BUTTONS
    '==========================================================================================

    ' Uses the above functions to calculate the total charges and pass it to the ____ variable
    Private Function CalculateGroupTotal() As Double
        Return (CalcOilLubeCharges() + CalcFlushCharges() + CalcMiscCharges())
    End Function

    Private Sub CalculateTotalCharges()
        Try
            serviceLabor = txtLabor.Text + CalculateGroupTotal()
            lblServiceTotal.Text = serviceLabor.ToString("C")

            Parts = txtParts.Text
            lblPartsTotal.Text = Parts.ToString("C")

            taxTotal = txtParts.Text * tax
            lblTaxTotal.Text = taxTotal.ToString("c")

            total = Parts + serviceLabor + taxTotal
            lblTotalTotal.Text = total.ToString("c")
        Catch ex As Exception
            MessageBox.Show("Please enter a positive real number for parts and labor!")
        End Try
    End Sub



    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        CalculateTotalCharges()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ClearOilLube()
        ClearFlushes()
        ClearMisc()
        ClearOther()
        ClearFees()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class
