Public Class frmPrintBooks
    ' Close button uses switch case to add correct value to sub total
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Try
            frmMain.lstMain.Items.Add(lstPrintBook.SelectedItem)
            Select Case lstPrintBook.SelectedItem
                Case "I Did it Your Way (Print)"
                    SubTotal += iDidItYourWay
                Case "The History of Scotland (Print)"
                    SubTotal += theHistoryOfScotland
                Case "Learn Calculus in One Day (Print)"
                    SubTotal += learnCalc
                Case "Feel the Stress (Print)"
                    SubTotal += feelTheStress
                Case ""
                    MessageBox.Show("Please Make a Selection", "Selection Needed")
            End Select

            Me.Close()
        Catch ex As Exception
            MessageBox.Show("Please Make a Selection", "Selection Needed")
        End Try

        mdlGlobal.CalculateTotalCharges()
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        ' Select Case for No Selection
        Select Case lstPrintBook.SelectedItem
            Case ""
                MessageBox.Show("Please Make a Selection", "Selection Needed")
        End Select
    End Sub
End Class