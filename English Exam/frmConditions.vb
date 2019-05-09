Public Class frmConditions

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        Dim DataTable As New DataTable
        OpenConnection(Tables.Conditions, DataTable)
        If (LCase(TextBox1.Text) = "was" Or LCase(TextBox1.Text) = "were") AndAlso rdbPast.Checked = True Then TextBox1.Text = "was/were"
        Dim a As Byte
        Select Case True
            Case rdbPresent.Checked
                a = 0
            Case rdbPast.Checked
                a = 1
            Case rdbPastParticiple.Checked
                a = 2
        End Select
        DataTable.PrimaryKey = {DataTable.Columns(a)}
        Dim CurrentRow As DataRow = DataTable.Rows.Find(TextBox1.Text)
        If CurrentRow Is Nothing Then
            MsgBox("Sorry The Verb You Entered Is Not Exists", MsgBoxStyle.Exclamation)
            Exit Sub
        End If
        Label2.Text = "Present: " & UCase(CurrentRow(0).ToString.Substring(0, 1)) & CurrentRow(0).ToString.Substring(1)
        Label3.Text = "Past: " & UCase(CurrentRow(1).ToString.Substring(0, 1)) & CurrentRow(1).ToString.Substring(1)
        Label4.Text = "Past Participle: " & UCase(CurrentRow(2).ToString.Substring(0, 1)) & CurrentRow(2).ToString.Substring(1)

    End Sub

    Private Sub frmConditions_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        frmMain.Show()
    End Sub

    Private Sub frmExamConditions_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim DataTable As New DataTable
        OpenConnection(Tables.Conditions, DataTable)
    End Sub
End Class