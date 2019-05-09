Public Class frmMain
    Public ChooseGrade, CorrectGrade, Right_WrongGrade As Double

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Time.Text = "Time: " & Now
    End Sub


    Private Sub btnCorrect_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCorrect.Click
        Me.Hide()
        frmCorrect.Show()
    End Sub

    Private Sub btnRight_Wrong_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRight_Wrong.Click
        Me.Hide()
        frmRight_Wrong.Show()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        MsgBox("Welcome to the overly easy English exam. Choose a question type, and start answering." & vbCrLf & "If you are curious, your grades are calculated by (100 / Number of questions) * (Correct answers - (Wrong answers/2)) " & vbCrLf & "To pass you'll need to achive marks higher than 70%.", MsgBoxStyle.Information)
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Hide()
        frmchoose.show()
    End Sub

    Private Sub btnAbout_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAbout.Click
        frmAbout.ShowDialog()
    End Sub

    Public Sub PrintGrades()
        lblChoose.Text = FormatPercent(ChooseGrade)
        lblCorrect.Text = FormatPercent(CorrectGrade)
        lblRight_Wrong.Text = FormatPercent(Right_WrongGrade)
        If (ChooseGrade + CorrectGrade + Right_WrongGrade) / 3 > 0.7 Then
            lblTotal.ForeColor = Color.Green
        Else
            lblTotal.ForeColor = Color.Red
        End If
        lblTotal.Text = FormatPercent((ChooseGrade + CorrectGrade + Right_WrongGrade) / 3)
        frmOptions.lblQuestionsCount.Enabled = False
        frmOptions.numQuesionsCount.Enabled = False
    End Sub

    Private Sub lblTotal_ForeColorChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblTotal.ForeColorChanged
        If lblTotal.ForeColor = Color.Green Then
            If (ChooseGrade + CorrectGrade + Right_WrongGrade) / 3 = 1 Then
                MsgBox("Congratulations! Full marks? Awesome!", MsgBoxStyle.Information)
            End If

        End If
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        If (ChooseGrade + CorrectGrade + Right_WrongGrade) / 3 > 0.7 Then
            Me.Hide()
            frmConditions.Show()
        Else
            MsgBox("Conditons are unavailable currently, you'll need to pass this simple exam first.", MsgBoxStyle.Exclamation)
        End If
    End Sub

    Private Sub frmMain_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        Application.Exit()
    End Sub

    Private Sub frmMain_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyUp
        If (ChooseGrade + CorrectGrade + Right_WrongGrade) / 3 < 1 Then
            Static Count As Integer
            Select Case Count
                Case 0, 1
                    If e.KeyCode = Keys.Up Then Count += 1 Else Count = 0
                Case 2, 3
                    If e.KeyCode = Keys.Down Then Count += 1 Else Count = 0
                Case 4, 6
                    If e.KeyCode = Keys.Left Then Count += 1 Else Count = 0
                Case 5, 7
                    If e.KeyCode = Keys.Right Then Count += 1 Else Count = 0
                Case 8
                    If e.KeyCode = Keys.B Then Count += 1 Else Count = 0
                Case 9
                    If e.KeyCode = Keys.A Then
                        MsgBox("Huh? I thought that Konami code is very old and no one would guess it.. You cheater! Congratulations on your unearned full marks. Oh by the way: ""H72HDFD93JD8"" is a code that you may find useful.", MsgBoxStyle.Exclamation)
                        ChooseGrade = 1
                        CorrectGrade = 1
                        Right_WrongGrade = 1
                        PrintGrades()
                        lblChoose.ForeColor = Color.Green
                        lblRight_Wrong.ForeColor = Color.Green
                        lblCorrect.ForeColor = Color.Green
                    End If
                    Count = 0
            End Select

        End If
    End Sub

    Private Sub chkRight_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub frmMain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnOptions_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOptions.Click
        frmOptions.ShowDialog()
    End Sub
End Class
