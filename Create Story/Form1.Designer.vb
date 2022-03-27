<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.lblStoryName = New System.Windows.Forms.Label()
        Me.txtStoryName = New System.Windows.Forms.TextBox()
        Me.lblMessageBox = New System.Windows.Forms.Label()
        Me.bntNewStory = New System.Windows.Forms.Button()
        Me.bntUpdateStory = New System.Windows.Forms.Button()
        Me.bntSaveStory = New System.Windows.Forms.Button()
        Me.bntClearStory = New System.Windows.Forms.Button()
        Me.lblLineNumber = New System.Windows.Forms.Label()
        Me.txtLineNumber = New System.Windows.Forms.TextBox()
        Me.txtNewLine = New System.Windows.Forms.TextBox()
        Me.bntAddNewLine = New System.Windows.Forms.Button()
        Me.bntEditLine = New System.Windows.Forms.Button()
        Me.bntDeleteLine = New System.Windows.Forms.Button()
        Me.txtStory = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblStoryName
        '
        Me.lblStoryName.AutoSize = True
        Me.lblStoryName.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblStoryName.Location = New System.Drawing.Point(41, 26)
        Me.lblStoryName.Name = "lblStoryName"
        Me.lblStoryName.Size = New System.Drawing.Size(129, 30)
        Me.lblStoryName.TabIndex = 0
        Me.lblStoryName.Text = "Story Name"
        '
        'txtStoryName
        '
        Me.txtStoryName.Location = New System.Drawing.Point(191, 33)
        Me.txtStoryName.Name = "txtStoryName"
        Me.txtStoryName.Size = New System.Drawing.Size(310, 23)
        Me.txtStoryName.TabIndex = 1
        '
        'lblMessageBox
        '
        Me.lblMessageBox.AutoSize = True
        Me.lblMessageBox.Location = New System.Drawing.Point(65, 73)
        Me.lblMessageBox.Name = "lblMessageBox"
        Me.lblMessageBox.Size = New System.Drawing.Size(205, 15)
        Me.lblMessageBox.TabIndex = 2
        Me.lblMessageBox.Text = "Start a new story or open a exiting file"
        '
        'bntNewStory
        '
        Me.bntNewStory.AccessibleDescription = "Use to start a new story"
        Me.bntNewStory.BackColor = System.Drawing.Color.Lime
        Me.bntNewStory.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.bntNewStory.Location = New System.Drawing.Point(25, 146)
        Me.bntNewStory.Name = "bntNewStory"
        Me.bntNewStory.Size = New System.Drawing.Size(124, 39)
        Me.bntNewStory.TabIndex = 3
        Me.bntNewStory.Text = "New Story"
        Me.bntNewStory.UseVisualStyleBackColor = False
        '
        'bntUpdateStory
        '
        Me.bntUpdateStory.AccessibleDescription = "Use to get a story save to a file"
        Me.bntUpdateStory.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.bntUpdateStory.Location = New System.Drawing.Point(155, 146)
        Me.bntUpdateStory.Name = "bntUpdateStory"
        Me.bntUpdateStory.Size = New System.Drawing.Size(124, 39)
        Me.bntUpdateStory.TabIndex = 4
        Me.bntUpdateStory.Text = "Update Story"
        Me.bntUpdateStory.UseVisualStyleBackColor = False
        '
        'bntSaveStory
        '
        Me.bntSaveStory.AccessibleDescription = "Used to save a story to a file"
        Me.bntSaveStory.BackColor = System.Drawing.Color.Fuchsia
        Me.bntSaveStory.Location = New System.Drawing.Point(285, 146)
        Me.bntSaveStory.Name = "bntSaveStory"
        Me.bntSaveStory.Size = New System.Drawing.Size(124, 39)
        Me.bntSaveStory.TabIndex = 5
        Me.bntSaveStory.Text = "Save Story"
        Me.bntSaveStory.UseVisualStyleBackColor = False
        '
        'bntClearStory
        '
        Me.bntClearStory.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.bntClearStory.Location = New System.Drawing.Point(415, 146)
        Me.bntClearStory.Name = "bntClearStory"
        Me.bntClearStory.Size = New System.Drawing.Size(124, 39)
        Me.bntClearStory.TabIndex = 6
        Me.bntClearStory.Text = "Clear Story"
        Me.bntClearStory.UseVisualStyleBackColor = False
        '
        'lblLineNumber
        '
        Me.lblLineNumber.AutoSize = True
        Me.lblLineNumber.Location = New System.Drawing.Point(554, 109)
        Me.lblLineNumber.Name = "lblLineNumber"
        Me.lblLineNumber.Size = New System.Drawing.Size(76, 15)
        Me.lblLineNumber.TabIndex = 7
        Me.lblLineNumber.Text = "Line Number"
        '
        'txtLineNumber
        '
        Me.txtLineNumber.Location = New System.Drawing.Point(700, 106)
        Me.txtLineNumber.Name = "txtLineNumber"
        Me.txtLineNumber.Size = New System.Drawing.Size(70, 23)
        Me.txtLineNumber.TabIndex = 8
        '
        'txtNewLine
        '
        Me.txtNewLine.Location = New System.Drawing.Point(560, 153)
        Me.txtNewLine.Multiline = True
        Me.txtNewLine.Name = "txtNewLine"
        Me.txtNewLine.Size = New System.Drawing.Size(235, 105)
        Me.txtNewLine.TabIndex = 9
        '
        'bntAddNewLine
        '
        Me.bntAddNewLine.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.bntAddNewLine.Location = New System.Drawing.Point(569, 283)
        Me.bntAddNewLine.Name = "bntAddNewLine"
        Me.bntAddNewLine.Size = New System.Drawing.Size(214, 58)
        Me.bntAddNewLine.TabIndex = 10
        Me.bntAddNewLine.Text = "Add New Line"
        Me.bntAddNewLine.UseVisualStyleBackColor = False
        '
        'bntEditLine
        '
        Me.bntEditLine.BackColor = System.Drawing.Color.DarkOrchid
        Me.bntEditLine.Location = New System.Drawing.Point(569, 360)
        Me.bntEditLine.Name = "bntEditLine"
        Me.bntEditLine.Size = New System.Drawing.Size(214, 58)
        Me.bntEditLine.TabIndex = 11
        Me.bntEditLine.Text = "Edit Line"
        Me.bntEditLine.UseVisualStyleBackColor = False
        '
        'bntDeleteLine
        '
        Me.bntDeleteLine.BackColor = System.Drawing.Color.Red
        Me.bntDeleteLine.Location = New System.Drawing.Point(569, 433)
        Me.bntDeleteLine.Name = "bntDeleteLine"
        Me.bntDeleteLine.Size = New System.Drawing.Size(214, 58)
        Me.bntDeleteLine.TabIndex = 12
        Me.bntDeleteLine.Text = "Delete Line"
        Me.bntDeleteLine.UseVisualStyleBackColor = False
        '
        'txtStory
        '
        Me.txtStory.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtStory.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtStory.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.txtStory.Location = New System.Drawing.Point(25, 204)
        Me.txtStory.Name = "txtStory"
        Me.txtStory.Size = New System.Drawing.Size(514, 287)
        Me.txtStory.TabIndex = 13
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Window
        Me.ClientSize = New System.Drawing.Size(821, 542)
        Me.Controls.Add(Me.txtStory)
        Me.Controls.Add(Me.bntDeleteLine)
        Me.Controls.Add(Me.bntEditLine)
        Me.Controls.Add(Me.bntAddNewLine)
        Me.Controls.Add(Me.txtNewLine)
        Me.Controls.Add(Me.txtLineNumber)
        Me.Controls.Add(Me.lblLineNumber)
        Me.Controls.Add(Me.bntClearStory)
        Me.Controls.Add(Me.bntSaveStory)
        Me.Controls.Add(Me.bntUpdateStory)
        Me.Controls.Add(Me.bntNewStory)
        Me.Controls.Add(Me.lblMessageBox)
        Me.Controls.Add(Me.txtStoryName)
        Me.Controls.Add(Me.lblStoryName)
        Me.Name = "Form1"
        Me.Text = "Ceate A Children's Story"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblStoryName As Label
    Friend WithEvents txtStoryName As TextBox
    Friend WithEvents lblMessageBox As Label
    Friend WithEvents bntNewStory As Button
    Friend WithEvents bntUpdateStory As Button
    Friend WithEvents bntSaveStory As Button
    Friend WithEvents bntClearStory As Button
    Friend WithEvents lblLineNumber As Label
    Friend WithEvents txtLineNumber As TextBox
    Friend WithEvents txtNewLine As TextBox
    Friend WithEvents bntAddNewLine As Button
    Friend WithEvents bntEditLine As Button
    Friend WithEvents bntDeleteLine As Button
    Friend WithEvents txtStory As Label
End Class
