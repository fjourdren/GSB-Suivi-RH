Public Class BDD
    Public connection As OdbcConnection

    Public Sub New()
        Me.connect()
    End Sub

    Public Sub connect()
        Dim connectionString As String = Config.ODBCConnectionName
        Dim conn As OdbcConnection = New OdbcConnection(connectionString)
        conn.Open()

        Me.connection = conn
    End Sub

    Public Sub nonQuery(ByVal sql)
        Dim myCommand As New System.Data.Odbc.OdbcCommand(sql, Me.connection)

        Try
            myCommand.ExecuteNonQuery()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Public Function query(ByVal sql)
        Dim myCommand As New System.Data.Odbc.OdbcCommand(sql, Me.connection)

        Try
            Dim myReader As System.Data.Odbc.OdbcDataReader = myCommand.ExecuteReader()
            While myReader.Read()
                Debug.WriteLine(myReader.GetString(1))
                MessageBox.Show(myReader.GetString(1))
            End While

            Return myReader
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

        Return -1
    End Function

    Public Sub close()
        Me.connection.Close()
        Me.connection.Dispose()
    End Sub
End Class
