Public Class Form1
    Dim story As Story = New Story()
    Dim fileManagement As FileManagement = New FileManagement()
    Dim lineNumber As Integer = 0

    Private Sub updateStoryField()
        Dim updatedStory As List(Of String) = story.UpdateStory()

        txtStory.Text = ""
        For Each line In updatedStory
            txtStory.Text += line & vbCrLf & vbCrLf
        Next
    End Sub

    Private Sub ClearFields()
        txtStory.Text = ""
        txtLineNumber.Text = ""
        txtNewLine.Text = ""
        story.ClearStory()
    End Sub
    Private Sub bntNewStory_Click(sender As Object, e As EventArgs) Handles bntNewStory.Click
        If (txtStoryName.Text = "") Then
            lblMessageBox.Text = "Please provided a Title for your New Story."
        Else
            ClearFields()
            lblMessageBox.Text = story.GetStoryName(txtStoryName.Text)
        End If
    End Sub

    Private Sub bntAddNewLine_Click(sender As Object, e As EventArgs) Handles bntAddNewLine.Click

        If txtLineNumber.Text <> "" And txtNewLine.Text <> "" And txtStoryName.Text <> "" Then
            If Integer.TryParse(txtLineNumber.Text, lineNumber) Then
                lblMessageBox.Text = story.AddLine(lineNumber, txtNewLine.Text)
                updateStoryField()
            Else
                lblMessageBox.Text = "Please provide a number for the line number"
            End If
        Else
            lblMessageBox.Text = "Please provide a line number and new line to be added to the story."
        End If
    End Sub

    Private Sub bntEditLine_Click(sender As Object, e As EventArgs) Handles bntEditLine.Click
        If txtLineNumber.Text <> "" And txtNewLine.Text <> "" And txtStoryName.Text <> "" Then
            If Integer.TryParse(txtLineNumber.Text, lineNumber) Then
                lblMessageBox.Text = story.EditLine(lineNumber, txtNewLine.Text)
                updateStoryField()
            Else
                lblMessageBox.Text = "Please provide a number for the line number"
            End If
        Else
            lblMessageBox.Text = "Please provide a line number and new line to be added to the story."
        End If
    End Sub

    Private Sub bntDeleteLine_Click(sender As Object, e As EventArgs) Handles bntDeleteLine.Click
        If txtLineNumber.Text <> "" And txtStoryName.Text <> "" Then
            If Integer.TryParse(txtLineNumber.Text, lineNumber) Then
                lblMessageBox.Text = story.DeleteLine(lineNumber)
                updateStoryField()
            Else
                lblMessageBox.Text = "Please provide a number for the line number"
            End If
        Else
            lblMessageBox.Text = "Please provide a line number and new line to be added to the story."
        End If
    End Sub

    Private Sub bntUpdateStory_Click(sender As Object, e As EventArgs) Handles bntUpdateStory.Click
        Try
            Dim filename = txtStoryName.Text.ToString().Trim() & ".dat"

            story = fileManagement.OpenFile(filename)
            lblMessageBox.Text = fileManagement.getMessage
            updateStoryField()
        Catch ex As Exception
            lblMessageBox.Text = fileManagement.getMessage
            'lblMessageBox.Text = "Failed to open file."'
        End Try

    End Sub

    Private Sub bntSaveStory_Click(sender As Object, e As EventArgs) Handles bntSaveStory.Click
        Try
            Dim filename = txtStoryName.Text.ToString().Trim() & ".dat"
            fileManagement.saveFile(filename, story)
            lblMessageBox.Text = fileManagement.getMessage
        Catch ex As Exception
            lblMessageBox.Text = fileManagement.getMessage
        End Try

    End Sub

    Private Sub bntClearStory_Click(sender As Object, e As EventArgs) Handles bntClearStory.Click
        txtStoryName.Text = ""
        ClearFields()
    End Sub
End Class
