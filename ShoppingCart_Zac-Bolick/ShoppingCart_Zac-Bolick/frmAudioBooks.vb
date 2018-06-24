Public Class frmAudioBooks
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Try
            frmMain.lstMain.Items.Add(lstAudioBook.SelectedItem)
            Select Case lstAudioBook.SelectedItem
                Case "Learn Calculus in One Day (Audio)"
                    SubTotal += learnCalcAudio
                Case "Relaxation Techniques (Audio)"
                    SubTotal += RelaxationTechAudio
                Case "The History of Scotland (Audio)"
                    SubTotal += theHistoryScotlandAudio
                Case "The Science of Body Languagu (Audio)"
                    SubTotal += theScienceBodyAudio
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
        Select Case lstAudioBook.SelectedItem
            Case ""
                MessageBox.Show("Please Make a Selection", "Selection Needed")
        End Select
    End Sub
End Class