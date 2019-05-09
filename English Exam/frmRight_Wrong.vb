Imports System.Data.OleDb

Public Class frmRight_Wrong
    Dim DataTabel As New DataTable
    Dim CurrentQuestion As Integer = -1
    Dim RightAnswers As Integer = 0
    Dim WrongAnswers As Integer = 0
    Dim NoAnswers As Integer = 0

    Private Sub frmRight_Wrong_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If CurrentQuestion <= 0 Then
            frmMain.Show()
        Else
            If MessageBox.Show("Are you sure you want to stop the exam? Note that all remaining questions are counted as unanswered.", "English Exam", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then
                NoAnswers += (QuestionsCount + 1) - (CurrentQuestion + 1)
                CurrentQuestion = QuestionsCount - 1
                PrintNew()
                frmMain.Show()
            Else
                e.Cancel = True
            End If
        End If
    End Sub

    Private Sub frmRight_Wrong_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        OpenConnection(Tables.RightAndWrong, DataTabel)
        PrintNew()
    End Sub

    Private Sub btnNext_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNext.Click
        'Check The Answer
        If rdbRight.Checked = False And rdbWrong.Checked = False Then
            btnNew.PerformClick()
            Exit Sub
        End If
        Timer1.Enabled = False
        If (rdbRight.Checked = True And LCase(DataTabel.Rows(CurrentQuestion)(1).ToString()) = "right") Or _
            (rdbWrong.Checked = True And LCase(DataTabel.Rows(CurrentQuestion)(1).ToString()) = "wrong") Then
            RightAnswers += 1
            If frmOptions.chkRight.Checked = True Then MsgBox("Amazing! you answered correctly!", MsgBoxStyle.Information)
        Else
            WrongAnswers += 1
            If frmOptions.chkWrong.Checked = True Then MsgBox("Shame! that was an incorrect answer.", MsgBoxStyle.Exclamation)
        End If
        rdbRight.Checked = False
        rdbWrong.Checked = False
        Timer1.Enabled = True
        PrintNew()

    End Sub

    Private Sub btnNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNew.Click
        If MessageBox.Show("New question?", "English Exam", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then

            PrintNew()

            NoAnswers += 1
        End If
    End Sub

    Private Sub PrintNew()
        If CurrentQuestion + 1 = QuestionsCount Then
            frmMain.Right_WrongGrade = (1 / QuestionsCount) * (RightAnswers - (WrongAnswers / 2))
            frmMain.PrintGrades()
            If (100 / QuestionsCount) * (RightAnswers - (WrongAnswers / 2)) > 60 Then
                If (100 / QuestionsCount) * (RightAnswers - (WrongAnswers / 2)) = 100 Then
                    MsgBox("Congratulations, you got the best grade ever! All your answers were correct!", MsgBoxStyle.Information)

                Else

                    MsgBox(String.Format("Congratulations, You passed the English exam (Right & Wrong) with {0} correct answer(s), and {1} incorrect answer(s). There were {2} unanswered question(s).", RightAnswers, WrongAnswers, NoAnswers), MsgBoxStyle.Information)
                End If
                frmMain.lblRight_Wrong.ForeColor = Color.Green
                CurrentQuestion = -1
                RightAnswers = 0
                WrongAnswers = 0
                NoAnswers = 0
            Else
                MsgBox("Sorry, but you didn't get pass the English Exam (Right & Wrong). Please try again." & vbCrLf & String.Format("You got {0} correct answer(s), and {1} incorrect answer(s). There were {2} unanswered question(s).", RightAnswers, WrongAnswers, NoAnswers), MsgBoxStyle.Exclamation)
                frmMain.lblRight_Wrong.ForeColor = Color.Red
                CurrentQuestion = -1
                RightAnswers = 0
                WrongAnswers = 0
                NoAnswers = 0
            End If
            Close()
        End If

        CurrentQuestion += 1
        lblQ.Text = DataTabel.Rows(CurrentQuestion)(0).ToString()
        lblCurrent.Text = CurrentQuestion + 1 & " Of " & QuestionsCount


    End Sub
    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Static Ticks As Integer
        Ticks += 1
        lblTimeLeft.Text = "Time left:" & (QuestionsCount * 10) - Ticks & " second(s)"
        If ((QuestionsCount * 10) - Ticks) = 0 Then
            NoAnswers += (QuestionsCount + 1) - (CurrentQuestion + 1)
            CurrentQuestion = QuestionsCount - 1
            MsgBox("Time Up", MsgBoxStyle.Information)
            PrintNew()
            frmMain.Show()
        End If
    End Sub
End Class