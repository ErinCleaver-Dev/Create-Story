Imports System.IO
Imports System.Runtime.Serialization.Formatters.Binary

Public Class FileManagement
    Dim message As String = ""
    Public Sub saveFile(filename As String, value As Object)
        Try

            Dim fs As New FileStream(filename, FileMode.Create)
            Dim formatter As New BinaryFormatter()

            formatter.Serialize(fs, value)
            fs.Close()
            message = "File Created: " & filename

        Catch ex As Exception
            message = "Error Message: " & ex.Message
        End Try

    End Sub

    Public Function getMessage()
        Return message
    End Function
    Public Function OpenFile(filename As String)

        Try
            Dim fs As New FileStream(filename, FileMode.Open)
            Dim story As Story = New Story()
            Dim formatter As New BinaryFormatter()

            story = formatter.Deserialize(fs)
            message = "File Opened: " & filename
            fs.Close()
            Return story
        Catch ex As Exception
            message = "Error Message: " & ex.Message
        End Try

        Return False

    End Function


End Class
