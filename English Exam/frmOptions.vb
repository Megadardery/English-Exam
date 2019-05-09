Public Class frmOptions

    Private Sub frmOptions_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim datatable As New DataTable
        Dim integers(3) As Integer
        OpenConnection(Tables.Correct, datatable)
        integers(0) = datatable.Rows.Count
        datatable = New DataTable
        OpenConnection(Tables.Choose, datatable)
        integers(1) = datatable.Rows.Count
        datatable = New DataTable
        OpenConnection(Tables.RightAndWrong, datatable)
        integers(2) = datatable.Rows.Count
        datatable = New DataTable
        OpenConnection(Tables.Conditions, datatable)
        integers(3) = datatable.Rows.Count
        datatable.Dispose()
        numQuesionsCount.Maximum = Math.Min(Math.Min(integers(0), integers(1)), integers(2))
        lblCorrect.Text = integers(0)
        lblChoose.Text = integers(1)
        lblRightAndWrong.Text = integers(2)
        lblConditions.Text = integers(3)
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If MsgBox("Are you sure?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            frmMain.ChooseGrade = 0
            frmMain.CorrectGrade = 0
            frmMain.Right_WrongGrade = 0
            frmMain.PrintGrades()
            lblQuestionsCount.Enabled = True
            numQuesionsCount.Enabled = True
        End If
    End Sub

    Private Sub NumericUpDown1_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles numQuesionsCount.ValueChanged
        QuestionsCount = numQuesionsCount.Value
    End Sub

    Private Sub chkWrong_CheckedChanged(sender As Object, e As EventArgs) Handles chkWrong.CheckedChanged

    End Sub
End Class