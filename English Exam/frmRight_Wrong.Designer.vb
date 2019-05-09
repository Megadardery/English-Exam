<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRight_Wrong
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRight_Wrong))
        Me.lblCurrent = New System.Windows.Forms.Label()
        Me.btnNew = New System.Windows.Forms.Button()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.rdbWrong = New System.Windows.Forms.RadioButton()
        Me.rdbRight = New System.Windows.Forms.RadioButton()
        Me.lblQ = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.lblTimeLeft = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblCurrent
        '
        Me.lblCurrent.AutoSize = True
        Me.lblCurrent.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCurrent.Location = New System.Drawing.Point(391, 9)
        Me.lblCurrent.Name = "lblCurrent"
        Me.lblCurrent.Size = New System.Drawing.Size(33, 16)
        Me.lblCurrent.TabIndex = 6
        Me.lblCurrent.Text = "  Of  "
        '
        'btnNew
        '
        Me.btnNew.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnNew.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNew.Location = New System.Drawing.Point(132, 96)
        Me.btnNew.Name = "btnNew"
        Me.btnNew.Size = New System.Drawing.Size(102, 23)
        Me.btnNew.TabIndex = 4
        Me.btnNew.Text = "New &Question"
        Me.btnNew.UseVisualStyleBackColor = True
        '
        'btnNext
        '
        Me.btnNext.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNext.Location = New System.Drawing.Point(240, 96)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(102, 23)
        Me.btnNext.TabIndex = 5
        Me.btnNext.Text = "&Next"
        Me.btnNext.UseVisualStyleBackColor = True
        '
        'rdbWrong
        '
        Me.rdbWrong.AutoSize = True
        Me.rdbWrong.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdbWrong.Location = New System.Drawing.Point(246, 54)
        Me.rdbWrong.Name = "rdbWrong"
        Me.rdbWrong.Size = New System.Drawing.Size(67, 20)
        Me.rdbWrong.TabIndex = 3
        Me.rdbWrong.Text = "&Wrong"
        Me.rdbWrong.UseVisualStyleBackColor = True
        '
        'rdbRight
        '
        Me.rdbRight.AutoSize = True
        Me.rdbRight.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdbRight.Location = New System.Drawing.Point(161, 54)
        Me.rdbRight.Name = "rdbRight"
        Me.rdbRight.Size = New System.Drawing.Size(59, 20)
        Me.rdbRight.TabIndex = 2
        Me.rdbRight.Text = "&Right"
        Me.rdbRight.UseVisualStyleBackColor = True
        '
        'lblQ
        '
        Me.lblQ.AutoSize = True
        Me.lblQ.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblQ.Location = New System.Drawing.Point(84, 29)
        Me.lblQ.Name = "lblQ"
        Me.lblQ.Size = New System.Drawing.Size(89, 16)
        Me.lblQ.TabIndex = 1
        Me.lblQ.Text = "The Question"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(11, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(67, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Question:"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1000
        '
        'lblTimeLeft
        '
        Me.lblTimeLeft.AutoSize = True
        Me.lblTimeLeft.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTimeLeft.Location = New System.Drawing.Point(11, 9)
        Me.lblTimeLeft.Name = "lblTimeLeft"
        Me.lblTimeLeft.Size = New System.Drawing.Size(73, 16)
        Me.lblTimeLeft.TabIndex = 10
        Me.lblTimeLeft.Text = "Time Left :"
        '
        'frmRight_Wrong
        '
        Me.AcceptButton = Me.btnNext
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnNew
        Me.ClientSize = New System.Drawing.Size(475, 134)
        Me.Controls.Add(Me.lblTimeLeft)
        Me.Controls.Add(Me.lblCurrent)
        Me.Controls.Add(Me.btnNew)
        Me.Controls.Add(Me.btnNext)
        Me.Controls.Add(Me.rdbWrong)
        Me.Controls.Add(Me.rdbRight)
        Me.Controls.Add(Me.lblQ)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmRight_Wrong"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Right And Wrong"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblCurrent As System.Windows.Forms.Label
    Friend WithEvents btnNew As System.Windows.Forms.Button
    Friend WithEvents btnNext As System.Windows.Forms.Button
    Friend WithEvents rdbWrong As System.Windows.Forms.RadioButton
    Friend WithEvents rdbRight As System.Windows.Forms.RadioButton
    Friend WithEvents lblQ As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents lblTimeLeft As System.Windows.Forms.Label
End Class
