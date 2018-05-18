Public Class BDD
    Public connection As OdbcConnection

    Public Sub New()
        Me.connect()
    End Sub

    Public Sub connect()
        Dim connectionString As String = Config.ODBCConnectionName
        Try
            Dim conn As OdbcConnection = New OdbcConnection(connectionString)
            conn.Open()

            Me.connection = conn
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Application.Exit()
        End Try
    End Sub

    Public Sub nonQuery(ByVal sql)
        Dim myCommand As New System.Data.Odbc.OdbcCommand(sql, Me.connection)

        Try
            myCommand.ExecuteNonQuery()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Application.Exit()
        End Try
    End Sub

    Public Function query(ByVal sql)
        Dim myCommand As New System.Data.Odbc.OdbcCommand(sql, Me.connection)

        Try
            Dim myReader As System.Data.Odbc.OdbcDataReader = myCommand.ExecuteReader()
            Return myReader
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Application.Exit()
        End Try

        Return -1
    End Function

    Public Sub close()
        Me.connection.Close()
        Me.connection.Dispose()
    End Sub
End Class
