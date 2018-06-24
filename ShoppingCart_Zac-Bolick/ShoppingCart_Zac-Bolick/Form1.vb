Public Class frmMain
    '==========================================================================================
    '                              File Menu
    '==========================================================================================

    ' Reset
    Private Sub ResetCtrlRToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ResetCtrlRToolStripMenuItem.Click
        lstMain.Items.Clear()
        mdlGlobal.ClearCharges()
    End Sub

    ' Exit
    Private Sub ExitCtrlToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitCtrlToolStripMenuItem.Click
        Me.Close()
    End Sub

    ' Print Books
    Private Sub PrintBooksToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PrintBooksToolStripMenuItem.Click
        frmPrintBooks.ShowDialog()
    End Sub

    ' Audio Books
    Private Sub AudioBooksToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AudioBooksToolStripMenuItem.Click
        frmAudioBooks.ShowDialog()
    End Sub

    ' About
    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        MessageBox.Show("Shopping Cart Version 1.1", "About")
    End Sub

    ' Remove Button

    Private Sub btnRemove_Click(sender As Object, e As EventArgs) Handles btnRemove.Click
        ReCalcSub()
        If lstMain.SelectedItem = "" Then
            MessageBox.Show("Please, make a selection from the list in order to remove it", "No Item Selected")
        End If
        lstMain.Items.Remove(lstMain.SelectedItem)
        CalculateTotalCharges()
    End Sub
End Class
