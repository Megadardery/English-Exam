<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmOptions
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmOptions))
        Me.chkWrong = New System.Windows.Forms.CheckBox()
        Me.chkRight = New System.Windows.Forms.CheckBox()
        Me.grbMessages = New System.Windows.Forms.GroupBox()
        Me.lblQuestionsCount = New System.Windows.Forms.Label()
        Me.numQuesionsCount = New System.Windows.Forms.NumericUpDown()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.lblConditions = New System.Windows.Forms.Label()
        Me.lblChoose = New System.Windows.Forms.Label()
        Me.lblRightAndWrong = New System.Windows.Forms.Label()
        Me.lblCorrect = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.grbMessages.SuspendLayout()
        CType(Me.numQuesionsCount, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'chkWrong
        '
        Me.chkWrong.AutoSize = True
        Me.chkWrong.Checked = True
        Me.chkWrong.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkWrong.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkWrong.Location = New System.Drawing.Point(6, 45)
        Me.chkWrong.Name = "chkWrong"
        Me.chkWrong.Size = New System.Drawing.Size(251, 20)
        Me.chkWrong.TabIndex = 7
        Me.chkWrong.Text = "Show message if the answer is wrong"
        Me.chkWrong.UseVisualStyleBackColor = True
        '
        'chkRight
        '
        Me.chkRight.AutoSize = True
        Me.chkRight.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkRight.Location = New System.Drawing.Point(6, 19)
        Me.chkRight.Name = "chkRight"
        Me.chkRight.Size = New System.Drawing.Size(242, 20)
        Me.chkRight.TabIndex = 6
        Me.chkRight.Text = "Show message if the answer is right"
        Me.chkRight.UseVisualStyleBackColor = True
        '
        'grbMessages
        '
        Me.grbMessages.Controls.Add(Me.chkRight)
        Me.grbMessages.Controls.Add(Me.chkWrong)
        Me.grbMessages.Location = New System.Drawing.Point(12, 12)
        Me.grbMessages.Name = "grbMessages"
        Me.grbMessages.Size = New System.Drawing.Size(272, 72)
        Me.grbMessages.TabIndex = 8
        Me.grbMessages.TabStop = False
        Me.grbMessages.Text = "Messages"
        '
        'lblQuestionsCount
        '
        Me.lblQuestionsCount.AutoSize = True
        Me.lblQuestionsCount.Location = New System.Drawing.Point(15, 92)
        Me.lblQuestionsCount.Name = "lblQuestionsCount"
        Me.lblQuestionsCount.Size = New System.Drawing.Size(107, 13)
        Me.lblQuestionsCount.TabIndex = 9
        Me.lblQuestionsCount.Text = "Questions per Mode:"
        '
        'numQuesionsCount
        '
        Me.numQuesionsCount.Location = New System.Drawing.Point(128, 90)
        Me.numQuesionsCount.Minimum = New Decimal(New Integer() {5, 0, 0, 0})
        Me.numQuesionsCount.Name = "numQuesionsCount"
        Me.numQuesionsCount.Size = New System.Drawing.Size(63, 20)
        Me.numQuesionsCount.TabIndex = 10
        Me.numQuesionsCount.Value = New Decimal(New Integer() {15, 0, 0, 0})
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 22)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(139, 13)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Questions count in Correct:"
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.Controls.Add(Me.lblConditions)
        Me.GroupBox2.Controls.Add(Me.lblChoose)
        Me.GroupBox2.Controls.Add(Me.lblRightAndWrong)
        Me.GroupBox2.Controls.Add(Me.lblCorrect)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 144)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(274, 103)
        Me.GroupBox2.TabIndex = 12
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Exam States"
        '
        'lblConditions
        '
        Me.lblConditions.AutoSize = True
        Me.lblConditions.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblConditions.Location = New System.Drawing.Point(183, 76)
        Me.lblConditions.Name = "lblConditions"
        Me.lblConditions.Size = New System.Drawing.Size(15, 15)
        Me.lblConditions.TabIndex = 17
        Me.lblConditions.Text = "0"
        '
        'lblChoose
        '
        Me.lblChoose.AutoSize = True
        Me.lblChoose.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblChoose.Location = New System.Drawing.Point(183, 40)
        Me.lblChoose.Name = "lblChoose"
        Me.lblChoose.Size = New System.Drawing.Size(15, 15)
        Me.lblChoose.TabIndex = 18
        Me.lblChoose.Text = "0"
        '
        'lblRightAndWrong
        '
        Me.lblRightAndWrong.AutoSize = True
        Me.lblRightAndWrong.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblRightAndWrong.Location = New System.Drawing.Point(183, 58)
        Me.lblRightAndWrong.Name = "lblRightAndWrong"
        Me.lblRightAndWrong.Size = New System.Drawing.Size(15, 15)
        Me.lblRightAndWrong.TabIndex = 16
        Me.lblRightAndWrong.Text = "0"
        '
        'lblCorrect
        '
        Me.lblCorrect.AutoSize = True
        Me.lblCorrect.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblCorrect.Location = New System.Drawing.Point(183, 22)
        Me.lblCorrect.Name = "lblCorrect"
        Me.lblCorrect.Size = New System.Drawing.Size(15, 15)
        Me.lblCorrect.TabIndex = 19
        Me.lblCorrect.Text = "0"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 40)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(139, 13)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "Questions count in Choose:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 58)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(173, 13)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "Questions count in Right && Wrong:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 76)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(159, 13)
        Me.Label5.TabIndex = 15
        Me.Label5.Text = "Total verbs count in Conditions:"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(12, 116)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(272, 23)
        Me.Button1.TabIndex = 13
        Me.Button1.Text = "Reset Exam"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'frmOptions
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(298, 259)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.numQuesionsCount)
        Me.Controls.Add(Me.lblQuestionsCount)
        Me.Controls.Add(Me.grbMessages)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmOptions"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Options"
        Me.grbMessages.ResumeLayout(False)
        Me.grbMessages.PerformLayout()
        CType(Me.numQuesionsCount, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents chkWrong As System.Windows.Forms.CheckBox
    Friend WithEvents chkRight As System.Windows.Forms.CheckBox
    Friend WithEvents grbMessages As System.Windows.Forms.GroupBox
    Friend WithEvents lblQuestionsCount As System.Windows.Forms.Label
    Friend WithEvents numQuesionsCount As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents lblRightAndWrong As System.Windows.Forms.Label
    Friend WithEvents lblConditions As System.Windows.Forms.Label
    Friend WithEvents lblChoose As System.Windows.Forms.Label
    Friend WithEvents lblCorrect As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
