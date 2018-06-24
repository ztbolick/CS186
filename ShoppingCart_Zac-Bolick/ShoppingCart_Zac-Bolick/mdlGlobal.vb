Module mdlGlobal
    ' Variables
    Public SubTotal As Double = 0
    Public Const TAX As Double = 0.08
    Public Shipping As Double = 0
    Public Total As Double = 0

    ' Print Books
    Public iDidItYourWay As Double = 11.95
    Public theHistoryOfScotland As Double = 15.5
    Public learnCalc As Double = 29.95
    Public feelTheStress As Double = 18.5

    ' Audio Books
    Public learnCalcAudio As Double = 29.95
    Public RelaxationTechAudio As Double = 11.5
    Public theHistoryScotlandAudio As Double = 14.5
    Public theScienceBodyAudio As Double = 12.95

    ' =============================================================================================
    '               Define Functions for Individual Calculations
    '==============================================================================================
    Public Function CalculateSubTotal() As Double
        Return SubTotal
    End Function

    Public Function ReCalcSub()
        Select Case frmMain.lstMain.SelectedItem
            Case "I Did it Your Way (Print)"
                SubTotal = SubTotal - iDidItYourWay
            Case "The History of Scotland (Print)"
                SubTotal -= theHistoryOfScotland
            Case "Learn Calculus in One Day (Print)"
                SubTotal -= learnCalc
            Case "Feel the Stress (Print)"
                SubTotal -= feelTheStress
            Case "Learn Calculus in One Day (Audio)"
                SubTotal -= learnCalcAudio
            Case "Relaxation Techniques (Audio)"
                SubTotal -= RelaxationTechAudio
            Case "The History of Scotland (Audio)"
                SubTotal -= theHistoryScotlandAudio
            Case "The Science of Body Languagu (Audio)"
                SubTotal -= theScienceBodyAudio
        End Select

        Return SubTotal
    End Function

    Public Function CalculateShipping() As Double
        For iCnt = 0 To frmMain.lstMain.Items.Count
            Shipping = frmMain.lstMain.Items.Count * 2
        Next iCnt
        Return Shipping
    End Function

    Public Function CalculateTax() As Double
        Dim Amount = (TAX * SubTotal)
        Return Amount
    End Function

    Public Function CalculateTotal() As Double
        Total = CalculateTax() + CalculateShipping() + SubTotal
        Return Total
    End Function

    '==============================================================================================
    '               Call Functions for Calculations
    '==============================================================================================

    Public Sub TotalChargesToString()
        frmMain.lblSubTotal.Text = SubTotal.ToString("C")               ' Calculate SubTotal
        frmMain.lblTax.Text = CalculateTax().ToString("C")              ' Calculate TAX
        frmMain.lblShipping.Text = CalculateShipping().ToString("C")    ' Calculate Shipping
        frmMain.lblTotal.Text = CalculateTotal().ToString("C")          ' Calculate Total
    End Sub

    Public Sub CalculateTotalCharges()
        TotalChargesToString()
    End Sub

    '==============================================================================================
    '               Clear Charges
    '==============================================================================================

    Public Sub ClearCharges()
        SubTotal = 0
        Shipping = 0
        Total = 0
        frmMain.lblSubTotal.Text = SubTotal.ToString("C")
        frmMain.lblTax.Text = (TAX * SubTotal).ToString("C")
        frmMain.lblShipping.Text = shipping.ToString("C")
        frmMain.lblTotal.Text = ((SubTotal * TAX) + SubTotal + Shipping).ToString("C")
    End Sub

End Module
