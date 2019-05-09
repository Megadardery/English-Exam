Module MdlHelp
    Public QuestionsCount As Integer = 10
    Private Const DatabasePassword As String = "H72HDFD93JD8"
    Enum Tables
        Conditions
        Choose
        RightAndWrong
        Correct
    End Enum
    Sub RandomizeTabel(ByRef DataTable As DataTable)

        DataTable.Columns.Add(New DataColumn("RandomValues", GetType(Integer)))


        Randomize()
        Dim Random As New Random()
        For i As Integer = 0 To DataTable.Rows.Count - 1
            DataTable.Rows(i)("RandomValues") = Random.Next(DataTable.Rows.Count)
        Next i
        Dim DataView As DataView = DataTable.DefaultView
        DataView.Sort = "RandomValues"
        DataTable = DataView.ToTable()

    End Sub

    Sub OpenConnection(ByVal Table As Tables, ByRef DataTable As DataTable)


        Using Connection As New OleDb.OleDbConnection With {.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Data.dat;Jet OLEDB:Database Password=" & DatabasePassword}
            'Open The Connection
            Try
                Connection.Open()
            Catch
                MsgBox("Data File Could Not Be Found Or It's Corrupt" & vbCrLf & "Please E-mail Me At Megadardery@yahoo.com And I Will Give You Last Update Of This File." & vbCrLf & "Sorry But The Program Need To Close.", MsgBoxStyle.Critical)
                Application.ExitThread()
            End Try
            Try
                Using DataAdapter As New OleDb.OleDbDataAdapter("Select * FROM " & [Enum].GetName(GetType(Tables), Table), Connection)
                    'Fill The Tabel With Data In The DataAdapter
                    DataAdapter.Fill(DataTable)
                    RandomizeTabel(DataTable)
                End Using
            Catch
                MsgBox("Data File Is Exists But It's Corrupt." & vbCrLf & "Please E-mail Me At Megadardery@yahoo.com And I Will Give You Last Update Of This File." & vbCrLf & "Sorry But The Program Need To Close.", MsgBoxStyle.Critical)
                Application.ExitThread()
            End Try

            'Close The Connection
            Connection.Close()
        End Using
    End Sub
End Module
