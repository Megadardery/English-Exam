Imports System.Data.OleDb

Public Class frmchoose
    Dim DataTabel As New DataTable
    Dim CurrentQuestion As Integer = -1
    Dim RightAnswers As Integer = 0
    Dim WrongAnswers As Integer = 0
    Dim NoAnswers As Integer = 0

    Private Sub frmChoose_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
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

    Private Sub frmchoose_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        OpenConnection(Tables.Choose, DataTabel)

        PrintNew()
        lblTimeLeft.Text = "Time left:" & (QuestionsCount * 10) & " second(s)"

    End Sub

    Private Sub PrintNew()

        If CurrentQuestion + 1 = QuestionsCount Then
            frmMain.ChooseGrade = (1 / QuestionsCount) * (RightAnswers - (WrongAnswers / 2))
            frmMain.PrintGrades()
            If (100 / QuestionsCount) * (RightAnswers - (WrongAnswers / 2)) > 60 Then
                If (100 / QuestionsCount) * (RightAnswers - (WrongAnswers / 2)) = 100 Then
                    MsgBox("Congratulations, you got the best grade ever! All your answers were correct!", MsgBoxStyle.Information)

                Else

                    MsgBox(String.Format("Congratulations, You passed the English exam (Choose) with {0} correct answer(s), and {1} incorrect answer(s). There were {2} unanswered question(s).", RightAnswers, WrongAnswers, NoAnswers), MsgBoxStyle.Information)
                End If
                frmMain.lblChoose.ForeColor = Color.Green
                CurrentQuestion = -1
                RightAnswers = 0
                WrongAnswers = 0
                NoAnswers = 0
            Else
                MsgBox("Sorry, but you didn't get pass the English Exam (Choose). Please try again." & vbCrLf & String.Format("You got {0} correct answer(s), and {1} incorrect answer(s). There were {2} unanswered question(s).", RightAnswers, WrongAnswers, NoAnswers), MsgBoxStyle.Exclamation)
                frmMain.lblChoose.ForeColor = Color.Red
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

        rdb1.Text = DataTabel.Rows(CurrentQuestion)(1).ToString()
        rdb2.Text = DataTabel.Rows(CurrentQuestion)(2).ToString()
        rdb3.Text = DataTabel.Rows(CurrentQuestion)(3).ToString()
        rdb4.Text = DataTabel.Rows(CurrentQuestion)(4).ToString()

        Randomize()
        Dim Random As New Random

        Select Case Random.Next(1, 7)
            Case 1
                Dim Location1, Location2 As Point
                Location1 = rdb1.Location
                Location2 = rdb2.Location
                rdb1.Location = Location2
                rdb2.Location = Location1
            Case 2
                Dim Location1, Location3 As Point
                Location1 = rdb1.Location
                Location3 = rdb3.Location
                rdb1.Location = Location3
                rdb3.Location = Location1
            Case 3
                Dim Location1, Location4 As Point
                Location1 = rdb1.Location
                Location4 = rdb4.Location
                rdb1.Location = Location4
                rdb4.Location = Location1
            Case 4
                Dim Location2, Location3 As Point
                Location2 = rdb2.Location
                Location3 = rdb3.Location
                rdb2.Location = Location3
                rdb3.Location = Location2
            Case 5
                Dim Location2, Location4 As Point
                Location2 = rdb2.Location
                Location4 = rdb4.Location
                rdb2.Location = Location4
                rdb4.Location = Location2
            Case 6
                Dim Location3, Location4 As Point
                Location3 = rdb3.Location
                Location4 = rdb4.Location
                rdb3.Location = Location4
                rdb4.Location = Location3

        End Select
    End Sub

    Private Sub btnNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNew.Click
        If MessageBox.Show("New question?", "English Exam", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then

            PrintNew()

            NoAnswers += 1
        End If
    End Sub

    Private Sub btnNext_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNext.Click


        Dim RadioButtonCheckedText As String
        'Check The Answer
        If rdb1.Checked = True Then
            RadioButtonCheckedText = rdb1.Text
        ElseIf rdb2.Checked = True Then
            RadioButtonCheckedText = rdb2.Text
        ElseIf rdb3.Checked = True Then
            RadioButtonCheckedText = rdb3.Text
        ElseIf rdb4.Checked = True Then
            RadioButtonCheckedText = rdb4.Text
        Else
            btnNew.PerformClick()
            Exit Sub
        End If

        rdb1.Checked = False
        rdb2.Checked = False
        rdb3.Checked = False
        rdb4.Checked = False
        If RadioButtonCheckedText = DataTabel.Rows(CurrentQuestion)(5).ToString() Then
            RightAnswers += 1
            If frmOptions.chkRight.Checked = True Then MsgBox("Amazing! you answered correctly!", MsgBoxStyle.Information)
        Else
            WrongAnswers += 1
            If frmOptions.chkWrong.Checked = True Then MsgBox("Shame! that was an incorrect answer. The correct answer is " & DataTabel.Rows(CurrentQuestion)(5).ToString(), MsgBoxStyle.Exclamation)
        End If

        PrintNew()
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Static Ticks As Integer
        Ticks += 1
        lblTimeLeft.Text = "Time left:" & (QuestionsCount * 15) - Ticks & " second(s)"
        If ((QuestionsCount * 15) - Ticks) = 0 Then
            NoAnswers += (QuestionsCount + 1) - (CurrentQuestion + 1)
            CurrentQuestion = QuestionsCount - 1
            MsgBox("Time Up", MsgBoxStyle.Information)
            PrintNew()
            frmMain.Show()
        End If
    End Sub
End Class