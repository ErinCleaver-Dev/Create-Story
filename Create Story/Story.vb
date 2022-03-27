<Serializable>
Public Class Story
    Private story As New Dictionary(Of Integer, String)
    Private message As String = ""
    Private storyName As String = ""

    Function GetStoryName(name)
        storyName = name
        Return "Starting a new Story"
    End Function

    Function ClearStory()
        message = ""
        storyName = ""
        story = New Dictionary(Of Integer, String)
        Return "Created a new story"
    End Function

    Function AddLine(lineNumber As Integer, line As String)
        Try
            story.Add(lineNumber, line)
            message = "Adding lines to " & storyName
        Catch ex As Exception
            message = "Failed to add item. Error Message: " & ex.Message
        End Try
        Return message
    End Function
    Function DeleteLine(lineNumber As Integer)
        Try
            story.Remove(lineNumber)
            message = "Deleted the line " & lineNumber & " from the story"
        Catch ex As Exception
            message = "Failed to remove item.  Error Message: " & ex.Message
        End Try
        Return message
    End Function
    Public Function EditLine(lineNumber As Integer, line As String)
        Try
            story(lineNumber) = line
            message = "Updated line " & lineNumber & " for " & storyName
        Catch ex As Exception
            message = "Failed to update line number.  Error Message: " & ex.Message
        End Try
        Return message
    End Function

    Function UpdateStory()
        Return story.Values.ToList()
    End Function
End Class
