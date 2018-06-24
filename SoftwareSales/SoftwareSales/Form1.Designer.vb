<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SoftwareSales
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
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.btnOneTimePurchase = New System.Windows.Forms.RadioButton()
        Me.btnYearly = New System.Windows.Forms.RadioButton()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.chkCloudBackup = New System.Windows.Forms.CheckBox()
        Me.chkLevel3 = New System.Windows.Forms.CheckBox()
        Me.chkOnSite = New System.Windows.Forms.CheckBox()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.lblCOF = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblCoSL = New System.Windows.Forms.Label()
        Me.Panel4.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(259, 376)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(120, 50)
        Me.btnClear.TabIndex = 26
        Me.btnClear.Text = "Cl&ear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(430, 376)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(120, 50)
        Me.btnExit.TabIndex = 25
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(100, 376)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(120, 50)
        Me.btnCalculate.TabIndex = 24
        Me.btnCalculate.Text = "&Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'btnOneTimePurchase
        '
        Me.btnOneTimePurchase.AutoSize = True
        Me.btnOneTimePurchase.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOneTimePurchase.Location = New System.Drawing.Point(60, 102)
        Me.btnOneTimePurchase.Name = "btnOneTimePurchase"
        Me.btnOneTimePurchase.Size = New System.Drawing.Size(159, 22)
        Me.btnOneTimePurchase.TabIndex = 2
        Me.btnOneTimePurchase.TabStop = True
        Me.btnOneTimePurchase.Text = "One-Time Purchase"
        Me.btnOneTimePurchase.UseVisualStyleBackColor = True
        '
        'btnYearly
        '
        Me.btnYearly.AutoSize = True
        Me.btnYearly.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnYearly.Location = New System.Drawing.Point(60, 59)
        Me.btnYearly.Name = "btnYearly"
        Me.btnYearly.Size = New System.Drawing.Size(66, 22)
        Me.btnYearly.TabIndex = 1
        Me.btnYearly.TabStop = True
        Me.btnYearly.Text = "Yearly"
        Me.btnYearly.UseVisualStyleBackColor = True
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.Panel4.Controls.Add(Me.GroupBox2)
        Me.Panel4.Controls.Add(Me.GroupBox1)
        Me.Panel4.Controls.Add(Me.btnExit)
        Me.Panel4.Controls.Add(Me.btnClear)
        Me.Panel4.Controls.Add(Me.btnCalculate)
        Me.Panel4.Controls.Add(Me.Panel5)
        Me.Panel4.Location = New System.Drawing.Point(-9, -1)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(652, 471)
        Me.Panel4.TabIndex = 30
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.GroupBox2.Controls.Add(Me.btnOneTimePurchase)
        Me.GroupBox2.Controls.Add(Me.btnYearly)
        Me.GroupBox2.Location = New System.Drawing.Point(28, 39)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(290, 182)
        Me.GroupBox2.TabIndex = 32
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Licensing Options"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.GroupBox1.Controls.Add(Me.chkCloudBackup)
        Me.GroupBox1.Controls.Add(Me.chkLevel3)
        Me.GroupBox1.Controls.Add(Me.chkOnSite)
        Me.GroupBox1.Location = New System.Drawing.Point(341, 39)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(290, 182)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Optional Features (Yearly)"
        '
        'chkCloudBackup
        '
        Me.chkCloudBackup.AutoSize = True
        Me.chkCloudBackup.Location = New System.Drawing.Point(34, 114)
        Me.chkCloudBackup.Name = "chkCloudBackup"
        Me.chkCloudBackup.Size = New System.Drawing.Size(93, 17)
        Me.chkCloudBackup.TabIndex = 4
        Me.chkCloudBackup.Text = "Cloud Backup"
        Me.chkCloudBackup.UseVisualStyleBackColor = True
        '
        'chkLevel3
        '
        Me.chkLevel3.AutoSize = True
        Me.chkLevel3.Location = New System.Drawing.Point(34, 47)
        Me.chkLevel3.Name = "chkLevel3"
        Me.chkLevel3.Size = New System.Drawing.Size(129, 17)
        Me.chkLevel3.TabIndex = 2
        Me.chkLevel3.Text = "Level-3 Tech Support"
        Me.chkLevel3.UseVisualStyleBackColor = True
        '
        'chkOnSite
        '
        Me.chkOnSite.AutoSize = True
        Me.chkOnSite.Location = New System.Drawing.Point(34, 81)
        Me.chkOnSite.Name = "chkOnSite"
        Me.chkOnSite.Size = New System.Drawing.Size(102, 17)
        Me.chkOnSite.TabIndex = 3
        Me.chkOnSite.Text = "On-Site Training"
        Me.chkOnSite.UseVisualStyleBackColor = True
        '
        'Panel5
        '
        Me.Panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel5.Controls.Add(Me.Panel6)
        Me.Panel5.Controls.Add(Me.Label4)
        Me.Panel5.Controls.Add(Me.Label3)
        Me.Panel5.Controls.Add(Me.Panel1)
        Me.Panel5.Location = New System.Drawing.Point(100, 241)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(450, 120)
        Me.Panel5.TabIndex = 31
        '
        'Panel6
        '
        Me.Panel6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel6.Controls.Add(Me.lblCOF)
        Me.Panel6.Location = New System.Drawing.Point(245, 63)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(165, 29)
        Me.Panel6.TabIndex = 1
        '
        'lblCOF
        '
        Me.lblCOF.AutoSize = True
        Me.lblCOF.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.lblCOF.Location = New System.Drawing.Point(4, 6)
        Me.lblCOF.Name = "lblCOF"
        Me.lblCOF.Size = New System.Drawing.Size(0, 15)
        Me.lblCOF.TabIndex = 0
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label4.Location = New System.Drawing.Point(44, 69)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(173, 17)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Cost of Optional Features:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label3.Location = New System.Drawing.Point(38, 32)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(175, 17)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Cost of Sofware Licensing:"
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.lblCoSL)
        Me.Panel1.Location = New System.Drawing.Point(245, 23)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(165, 29)
        Me.Panel1.TabIndex = 0
        '
        'lblCoSL
        '
        Me.lblCoSL.AutoSize = True
        Me.lblCoSL.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.lblCoSL.Location = New System.Drawing.Point(5, 6)
        Me.lblCoSL.Name = "lblCoSL"
        Me.lblCoSL.Size = New System.Drawing.Size(0, 15)
        Me.lblCoSL.TabIndex = 1
        '
        'SoftwareSales
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(634, 461)
        Me.Controls.Add(Me.Panel4)
        Me.Name = "SoftwareSales"
        Me.Text = "Software Sales"
        Me.Panel4.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnClear As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents btnCalculate As Button
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnOneTimePurchase As RadioButton
    Friend WithEvents btnYearly As RadioButton
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lblCOF As Label
    Friend WithEvents lblCoSL As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents chkCloudBackup As CheckBox
    Friend WithEvents chkLevel3 As CheckBox
    Friend WithEvents chkOnSite As CheckBox
End Class
