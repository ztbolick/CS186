<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.gbOilAndLube = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.chkLube = New System.Windows.Forms.CheckBox()
        Me.chkOilChange = New System.Windows.Forms.CheckBox()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.gbRadiatorAndTransmission = New System.Windows.Forms.GroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.chkTransmission = New System.Windows.Forms.CheckBox()
        Me.chkRadiatorFlush = New System.Windows.Forms.CheckBox()
        Me.gbMiscellaneous = New System.Windows.Forms.GroupBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.chkTireRotation = New System.Windows.Forms.CheckBox()
        Me.chkReplaceMuffler = New System.Windows.Forms.CheckBox()
        Me.chkInspection = New System.Windows.Forms.CheckBox()
        Me.gbPartsAndLabor = New System.Windows.Forms.GroupBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.lblParts = New System.Windows.Forms.Label()
        Me.lblLabor = New System.Windows.Forms.Label()
        Me.txtLabor = New System.Windows.Forms.TextBox()
        Me.txtParts = New System.Windows.Forms.TextBox()
        Me.gbSummaryOfCharges = New System.Windows.Forms.GroupBox()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.lblTotalTotal = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.lblTaxTotal = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.lblPartsTotal = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.lblServiceTotal = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.lblServiceAndLabor = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.gbOilAndLube.SuspendLayout()
        Me.gbRadiatorAndTransmission.SuspendLayout()
        Me.gbMiscellaneous.SuspendLayout()
        Me.gbPartsAndLabor.SuspendLayout()
        Me.gbSummaryOfCharges.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbOilAndLube
        '
        Me.gbOilAndLube.BackColor = System.Drawing.SystemColors.Control
        Me.gbOilAndLube.Controls.Add(Me.Label2)
        Me.gbOilAndLube.Controls.Add(Me.Label1)
        Me.gbOilAndLube.Controls.Add(Me.chkLube)
        Me.gbOilAndLube.Controls.Add(Me.chkOilChange)
        Me.gbOilAndLube.Location = New System.Drawing.Point(19, 19)
        Me.gbOilAndLube.Name = "gbOilAndLube"
        Me.gbOilAndLube.Size = New System.Drawing.Size(268, 100)
        Me.gbOilAndLube.TabIndex = 0
        Me.gbOilAndLube.TabStop = False
        Me.gbOilAndLube.Text = "Oil and Lubrication"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(192, 63)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(40, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "$28.00"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(192, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "$36.00"
        '
        'chkLube
        '
        Me.chkLube.AutoSize = True
        Me.chkLube.Location = New System.Drawing.Point(27, 64)
        Me.chkLube.Name = "chkLube"
        Me.chkLube.Size = New System.Drawing.Size(70, 17)
        Me.chkLube.TabIndex = 1
        Me.chkLube.Text = "Lube Job"
        Me.chkLube.UseVisualStyleBackColor = True
        '
        'chkOilChange
        '
        Me.chkOilChange.AutoSize = True
        Me.chkOilChange.Location = New System.Drawing.Point(27, 32)
        Me.chkOilChange.Name = "chkOilChange"
        Me.chkOilChange.Size = New System.Drawing.Size(78, 17)
        Me.chkOilChange.TabIndex = 0
        Me.chkOilChange.Text = "Oil Change"
        Me.chkOilChange.UseVisualStyleBackColor = True
        '
        'gbRadiatorAndTransmission
        '
        Me.gbRadiatorAndTransmission.BackColor = System.Drawing.SystemColors.Control
        Me.gbRadiatorAndTransmission.Controls.Add(Me.Label4)
        Me.gbRadiatorAndTransmission.Controls.Add(Me.Label3)
        Me.gbRadiatorAndTransmission.Controls.Add(Me.chkTransmission)
        Me.gbRadiatorAndTransmission.Controls.Add(Me.chkRadiatorFlush)
        Me.gbRadiatorAndTransmission.Location = New System.Drawing.Point(317, 19)
        Me.gbRadiatorAndTransmission.Name = "gbRadiatorAndTransmission"
        Me.gbRadiatorAndTransmission.Size = New System.Drawing.Size(279, 100)
        Me.gbRadiatorAndTransmission.TabIndex = 1
        Me.gbRadiatorAndTransmission.TabStop = False
        Me.gbRadiatorAndTransmission.Text = "Radiator and Transmission"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(214, 63)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(46, 13)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "$120.00"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(214, 30)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(40, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "$50.00"
        '
        'chkTransmission
        '
        Me.chkTransmission.AutoSize = True
        Me.chkTransmission.Location = New System.Drawing.Point(20, 63)
        Me.chkTransmission.Name = "chkTransmission"
        Me.chkTransmission.Size = New System.Drawing.Size(115, 17)
        Me.chkTransmission.TabIndex = 3
        Me.chkTransmission.Text = "Transmission Flush"
        Me.chkTransmission.UseVisualStyleBackColor = True
        '
        'chkRadiatorFlush
        '
        Me.chkRadiatorFlush.AutoSize = True
        Me.chkRadiatorFlush.Location = New System.Drawing.Point(20, 29)
        Me.chkRadiatorFlush.Name = "chkRadiatorFlush"
        Me.chkRadiatorFlush.Size = New System.Drawing.Size(94, 17)
        Me.chkRadiatorFlush.TabIndex = 2
        Me.chkRadiatorFlush.Text = "Radiator Flush"
        Me.chkRadiatorFlush.UseVisualStyleBackColor = True
        '
        'gbMiscellaneous
        '
        Me.gbMiscellaneous.BackColor = System.Drawing.SystemColors.Control
        Me.gbMiscellaneous.Controls.Add(Me.Label7)
        Me.gbMiscellaneous.Controls.Add(Me.Label6)
        Me.gbMiscellaneous.Controls.Add(Me.Label5)
        Me.gbMiscellaneous.Controls.Add(Me.chkTireRotation)
        Me.gbMiscellaneous.Controls.Add(Me.chkReplaceMuffler)
        Me.gbMiscellaneous.Controls.Add(Me.chkInspection)
        Me.gbMiscellaneous.Location = New System.Drawing.Point(19, 141)
        Me.gbMiscellaneous.Name = "gbMiscellaneous"
        Me.gbMiscellaneous.Size = New System.Drawing.Size(268, 126)
        Me.gbMiscellaneous.TabIndex = 2
        Me.gbMiscellaneous.TabStop = False
        Me.gbMiscellaneous.Text = "Miscellaneous"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(192, 89)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(40, 13)
        Me.Label7.TabIndex = 8
        Me.Label7.Text = "$20.00"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(192, 59)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(46, 13)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "$200.00"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(192, 29)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(40, 13)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "$15.00"
        '
        'chkTireRotation
        '
        Me.chkTireRotation.AutoSize = True
        Me.chkTireRotation.Location = New System.Drawing.Point(27, 85)
        Me.chkTireRotation.Name = "chkTireRotation"
        Me.chkTireRotation.Size = New System.Drawing.Size(87, 17)
        Me.chkTireRotation.TabIndex = 6
        Me.chkTireRotation.Text = "Tire Rotation"
        Me.chkTireRotation.UseVisualStyleBackColor = True
        '
        'chkReplaceMuffler
        '
        Me.chkReplaceMuffler.AutoSize = True
        Me.chkReplaceMuffler.Location = New System.Drawing.Point(27, 55)
        Me.chkReplaceMuffler.Name = "chkReplaceMuffler"
        Me.chkReplaceMuffler.Size = New System.Drawing.Size(101, 17)
        Me.chkReplaceMuffler.TabIndex = 5
        Me.chkReplaceMuffler.Text = "Replace Muffler"
        Me.chkReplaceMuffler.UseVisualStyleBackColor = True
        '
        'chkInspection
        '
        Me.chkInspection.AutoSize = True
        Me.chkInspection.Location = New System.Drawing.Point(27, 25)
        Me.chkInspection.Name = "chkInspection"
        Me.chkInspection.Size = New System.Drawing.Size(75, 17)
        Me.chkInspection.TabIndex = 4
        Me.chkInspection.Text = "Inspection"
        Me.chkInspection.UseVisualStyleBackColor = True
        '
        'gbPartsAndLabor
        '
        Me.gbPartsAndLabor.BackColor = System.Drawing.SystemColors.Control
        Me.gbPartsAndLabor.Controls.Add(Me.Label11)
        Me.gbPartsAndLabor.Controls.Add(Me.Label10)
        Me.gbPartsAndLabor.Controls.Add(Me.lblParts)
        Me.gbPartsAndLabor.Controls.Add(Me.lblLabor)
        Me.gbPartsAndLabor.Controls.Add(Me.txtLabor)
        Me.gbPartsAndLabor.Controls.Add(Me.txtParts)
        Me.gbPartsAndLabor.Location = New System.Drawing.Point(317, 141)
        Me.gbPartsAndLabor.Name = "gbPartsAndLabor"
        Me.gbPartsAndLabor.Size = New System.Drawing.Size(279, 126)
        Me.gbPartsAndLabor.TabIndex = 2
        Me.gbPartsAndLabor.TabStop = False
        Me.gbPartsAndLabor.Text = "Parts and Labor"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(147, 81)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(44, 13)
        Me.Label11.TabIndex = 8
        Me.Label11.Text = "Minutes"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(147, 39)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(39, 13)
        Me.Label10.TabIndex = 7
        Me.Label10.Text = "Dollars"
        '
        'lblParts
        '
        Me.lblParts.AutoSize = True
        Me.lblParts.Location = New System.Drawing.Point(30, 39)
        Me.lblParts.Name = "lblParts"
        Me.lblParts.Size = New System.Drawing.Size(31, 13)
        Me.lblParts.TabIndex = 6
        Me.lblParts.Text = "Parts"
        '
        'lblLabor
        '
        Me.lblLabor.AutoSize = True
        Me.lblLabor.Location = New System.Drawing.Point(27, 80)
        Me.lblLabor.Name = "lblLabor"
        Me.lblLabor.Size = New System.Drawing.Size(34, 13)
        Me.lblLabor.TabIndex = 5
        Me.lblLabor.Text = "Labor"
        '
        'txtLabor
        '
        Me.txtLabor.Location = New System.Drawing.Point(74, 77)
        Me.txtLabor.Name = "txtLabor"
        Me.txtLabor.Size = New System.Drawing.Size(65, 20)
        Me.txtLabor.TabIndex = 5
        '
        'txtParts
        '
        Me.txtParts.Location = New System.Drawing.Point(74, 36)
        Me.txtParts.Name = "txtParts"
        Me.txtParts.Size = New System.Drawing.Size(65, 20)
        Me.txtParts.TabIndex = 4
        '
        'gbSummaryOfCharges
        '
        Me.gbSummaryOfCharges.BackColor = System.Drawing.SystemColors.Control
        Me.gbSummaryOfCharges.Controls.Add(Me.Panel5)
        Me.gbSummaryOfCharges.Controls.Add(Me.Panel4)
        Me.gbSummaryOfCharges.Controls.Add(Me.Panel3)
        Me.gbSummaryOfCharges.Controls.Add(Me.Panel2)
        Me.gbSummaryOfCharges.Controls.Add(Me.Label17)
        Me.gbSummaryOfCharges.Controls.Add(Me.Label16)
        Me.gbSummaryOfCharges.Controls.Add(Me.Label13)
        Me.gbSummaryOfCharges.Controls.Add(Me.lblServiceAndLabor)
        Me.gbSummaryOfCharges.Location = New System.Drawing.Point(19, 301)
        Me.gbSummaryOfCharges.Name = "gbSummaryOfCharges"
        Me.gbSummaryOfCharges.Size = New System.Drawing.Size(577, 115)
        Me.gbSummaryOfCharges.TabIndex = 3
        Me.gbSummaryOfCharges.TabStop = False
        Me.gbSummaryOfCharges.Text = "Summary of Charges"
        '
        'Panel5
        '
        Me.Panel5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel5.Controls.Add(Me.lblTotalTotal)
        Me.Panel5.Location = New System.Drawing.Point(372, 65)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(100, 25)
        Me.Panel5.TabIndex = 19
        '
        'lblTotalTotal
        '
        Me.lblTotalTotal.AutoSize = True
        Me.lblTotalTotal.Location = New System.Drawing.Point(6, 4)
        Me.lblTotalTotal.Name = "lblTotalTotal"
        Me.lblTotalTotal.Size = New System.Drawing.Size(45, 13)
        Me.lblTotalTotal.TabIndex = 16
        Me.lblTotalTotal.Text = "Label19"
        '
        'Panel4
        '
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel4.Controls.Add(Me.lblTaxTotal)
        Me.Panel4.Location = New System.Drawing.Point(372, 34)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(100, 25)
        Me.Panel4.TabIndex = 19
        '
        'lblTaxTotal
        '
        Me.lblTaxTotal.AutoSize = True
        Me.lblTaxTotal.Location = New System.Drawing.Point(6, 4)
        Me.lblTaxTotal.Name = "lblTaxTotal"
        Me.lblTaxTotal.Size = New System.Drawing.Size(45, 13)
        Me.lblTaxTotal.TabIndex = 15
        Me.lblTaxTotal.Text = "Label18"
        '
        'Panel3
        '
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel3.Controls.Add(Me.lblPartsTotal)
        Me.Panel3.Location = New System.Drawing.Point(168, 65)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(100, 25)
        Me.Panel3.TabIndex = 18
        '
        'lblPartsTotal
        '
        Me.lblPartsTotal.AutoSize = True
        Me.lblPartsTotal.Location = New System.Drawing.Point(6, 4)
        Me.lblPartsTotal.Name = "lblPartsTotal"
        Me.lblPartsTotal.Size = New System.Drawing.Size(45, 13)
        Me.lblPartsTotal.TabIndex = 12
        Me.lblPartsTotal.Text = "Label15"
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel2.Controls.Add(Me.lblServiceTotal)
        Me.Panel2.Location = New System.Drawing.Point(168, 34)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(100, 25)
        Me.Panel2.TabIndex = 17
        '
        'lblServiceTotal
        '
        Me.lblServiceTotal.AutoSize = True
        Me.lblServiceTotal.Location = New System.Drawing.Point(6, 4)
        Me.lblServiceTotal.Name = "lblServiceTotal"
        Me.lblServiceTotal.Size = New System.Drawing.Size(45, 13)
        Me.lblServiceTotal.TabIndex = 11
        Me.lblServiceTotal.Text = "Label14"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(303, 71)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(57, 13)
        Me.Label17.TabIndex = 14
        Me.Label17.Text = "Total Fees"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(288, 40)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(72, 13)
        Me.Label16.TabIndex = 13
        Me.Label16.Text = "Tax (on parts)"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(128, 71)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(31, 13)
        Me.Label13.TabIndex = 10
        Me.Label13.Text = "Parts"
        '
        'lblServiceAndLabor
        '
        Me.lblServiceAndLabor.AutoSize = True
        Me.lblServiceAndLabor.Location = New System.Drawing.Point(64, 40)
        Me.lblServiceAndLabor.Name = "lblServiceAndLabor"
        Me.lblServiceAndLabor.Size = New System.Drawing.Size(95, 13)
        Me.lblServiceAndLabor.TabIndex = 9
        Me.lblServiceAndLabor.Text = "Service And Labor"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Panel1.Location = New System.Drawing.Point(19, 281)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(577, 10)
        Me.Panel1.TabIndex = 4
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(56, 433)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(132, 41)
        Me.btnCalculate.TabIndex = 12
        Me.btnCalculate.Text = "&Calculate Total"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(238, 433)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(132, 41)
        Me.btnClear.TabIndex = 13
        Me.btnClear.Text = "C&lear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(420, 433)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(132, 41)
        Me.btnExit.TabIndex = 14
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDark
        Me.ClientSize = New System.Drawing.Size(618, 486)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.gbSummaryOfCharges)
        Me.Controls.Add(Me.gbPartsAndLabor)
        Me.Controls.Add(Me.gbMiscellaneous)
        Me.Controls.Add(Me.gbRadiatorAndTransmission)
        Me.Controls.Add(Me.gbOilAndLube)
        Me.Name = "Form1"
        Me.Text = "TG Automotive"
        Me.gbOilAndLube.ResumeLayout(False)
        Me.gbOilAndLube.PerformLayout()
        Me.gbRadiatorAndTransmission.ResumeLayout(False)
        Me.gbRadiatorAndTransmission.PerformLayout()
        Me.gbMiscellaneous.ResumeLayout(False)
        Me.gbMiscellaneous.PerformLayout()
        Me.gbPartsAndLabor.ResumeLayout(False)
        Me.gbPartsAndLabor.PerformLayout()
        Me.gbSummaryOfCharges.ResumeLayout(False)
        Me.gbSummaryOfCharges.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents gbOilAndLube As GroupBox
    Friend WithEvents chkLube As CheckBox
    Friend WithEvents chkOilChange As CheckBox
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents gbRadiatorAndTransmission As GroupBox
    Friend WithEvents chkRadiatorFlush As CheckBox
    Friend WithEvents gbMiscellaneous As GroupBox
    Friend WithEvents chkTireRotation As CheckBox
    Friend WithEvents chkReplaceMuffler As CheckBox
    Friend WithEvents chkInspection As CheckBox
    Friend WithEvents gbPartsAndLabor As GroupBox
    Friend WithEvents chkTransmission As CheckBox
    Friend WithEvents gbSummaryOfCharges As GroupBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents lblParts As Label
    Friend WithEvents lblLabor As Label
    Friend WithEvents txtLabor As TextBox
    Friend WithEvents txtParts As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents lblTotalTotal As Label
    Friend WithEvents lblTaxTotal As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents lblPartsTotal As Label
    Friend WithEvents lblServiceTotal As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents lblServiceAndLabor As Label
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btnCalculate As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnExit As Button
End Class
