<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class classRoom
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.classRoomMetroTabControl = New MetroFramework.Controls.MetroTabControl()
        Me.classWorkTabPage = New MetroFramework.Controls.MetroTabPage()
        Me.classWorkListBox = New System.Windows.Forms.ListBox()
        Me.labsTabPage = New MetroFramework.Controls.MetroTabPage()
        Me.labListBox = New System.Windows.Forms.ListBox()
        Me.examsTabPage = New MetroFramework.Controls.MetroTabPage()
        Me.examsListBox = New System.Windows.Forms.ListBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.viewMetroButton = New MetroFramework.Controls.MetroButton()
        Me.exitMetroButton = New MetroFramework.Controls.MetroButton()
        Me.subjectLabel = New System.Windows.Forms.Label()
        Me.studyLevelLabel = New System.Windows.Forms.Label()
        Me.classRoomMetroTabControl.SuspendLayout()
        Me.classWorkTabPage.SuspendLayout()
        Me.labsTabPage.SuspendLayout()
        Me.examsTabPage.SuspendLayout()
        Me.SuspendLayout()
        '
        'classRoomMetroTabControl
        '
        Me.classRoomMetroTabControl.Controls.Add(Me.classWorkTabPage)
        Me.classRoomMetroTabControl.Controls.Add(Me.labsTabPage)
        Me.classRoomMetroTabControl.Controls.Add(Me.examsTabPage)
        Me.classRoomMetroTabControl.Location = New System.Drawing.Point(96, 145)
        Me.classRoomMetroTabControl.Name = "classRoomMetroTabControl"
        Me.classRoomMetroTabControl.SelectedIndex = 0
        Me.classRoomMetroTabControl.Size = New System.Drawing.Size(1134, 463)
        Me.classRoomMetroTabControl.TabIndex = 0
        Me.classRoomMetroTabControl.UseSelectable = True
        '
        'classWorkTabPage
        '
        Me.classWorkTabPage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.classWorkTabPage.Controls.Add(Me.classWorkListBox)
        Me.classWorkTabPage.HorizontalScrollbarBarColor = True
        Me.classWorkTabPage.HorizontalScrollbarHighlightOnWheel = False
        Me.classWorkTabPage.HorizontalScrollbarSize = 10
        Me.classWorkTabPage.Location = New System.Drawing.Point(4, 38)
        Me.classWorkTabPage.Name = "classWorkTabPage"
        Me.classWorkTabPage.Size = New System.Drawing.Size(1126, 421)
        Me.classWorkTabPage.TabIndex = 0
        Me.classWorkTabPage.Text = "                              Class Work                                         " &
    "  |"
        Me.classWorkTabPage.VerticalScrollbarBarColor = True
        Me.classWorkTabPage.VerticalScrollbarHighlightOnWheel = False
        Me.classWorkTabPage.VerticalScrollbarSize = 10
        '
        'classWorkListBox
        '
        Me.classWorkListBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.classWorkListBox.FormattingEnabled = True
        Me.classWorkListBox.ItemHeight = 25
        Me.classWorkListBox.Location = New System.Drawing.Point(1, 1)
        Me.classWorkListBox.Name = "classWorkListBox"
        Me.classWorkListBox.Size = New System.Drawing.Size(1118, 504)
        Me.classWorkListBox.TabIndex = 2
        '
        'labsTabPage
        '
        Me.labsTabPage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.labsTabPage.Controls.Add(Me.labListBox)
        Me.labsTabPage.HorizontalScrollbarBarColor = True
        Me.labsTabPage.HorizontalScrollbarHighlightOnWheel = False
        Me.labsTabPage.HorizontalScrollbarSize = 10
        Me.labsTabPage.Location = New System.Drawing.Point(4, 38)
        Me.labsTabPage.Name = "labsTabPage"
        Me.labsTabPage.Size = New System.Drawing.Size(1126, 421)
        Me.labsTabPage.TabIndex = 1
        Me.labsTabPage.Text = "                                    Lab practicals                               " &
    "           |"
        Me.labsTabPage.VerticalScrollbarBarColor = True
        Me.labsTabPage.VerticalScrollbarHighlightOnWheel = False
        Me.labsTabPage.VerticalScrollbarSize = 10
        '
        'labListBox
        '
        Me.labListBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labListBox.FormattingEnabled = True
        Me.labListBox.ItemHeight = 25
        Me.labListBox.Location = New System.Drawing.Point(3, 3)
        Me.labListBox.Name = "labListBox"
        Me.labListBox.Size = New System.Drawing.Size(1119, 504)
        Me.labListBox.TabIndex = 2
        '
        'examsTabPage
        '
        Me.examsTabPage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.examsTabPage.Controls.Add(Me.examsListBox)
        Me.examsTabPage.HorizontalScrollbarBarColor = True
        Me.examsTabPage.HorizontalScrollbarHighlightOnWheel = False
        Me.examsTabPage.HorizontalScrollbarSize = 10
        Me.examsTabPage.Location = New System.Drawing.Point(4, 38)
        Me.examsTabPage.Name = "examsTabPage"
        Me.examsTabPage.Size = New System.Drawing.Size(1126, 421)
        Me.examsTabPage.TabIndex = 2
        Me.examsTabPage.Text = "                                     Exams                           "
        Me.examsTabPage.VerticalScrollbarBarColor = True
        Me.examsTabPage.VerticalScrollbarHighlightOnWheel = False
        Me.examsTabPage.VerticalScrollbarSize = 10
        '
        'examsListBox
        '
        Me.examsListBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.examsListBox.FormattingEnabled = True
        Me.examsListBox.ItemHeight = 37
        Me.examsListBox.Location = New System.Drawing.Point(3, 2)
        Me.examsListBox.Name = "examsListBox"
        Me.examsListBox.Size = New System.Drawing.Size(1116, 485)
        Me.examsListBox.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(557, 115)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(250, 16)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Select videos / ebooks you want to study"
        '
        'viewMetroButton
        '
        Me.viewMetroButton.Location = New System.Drawing.Point(105, 627)
        Me.viewMetroButton.Name = "viewMetroButton"
        Me.viewMetroButton.Size = New System.Drawing.Size(75, 36)
        Me.viewMetroButton.TabIndex = 3
        Me.viewMetroButton.Text = "View"
        Me.viewMetroButton.UseSelectable = True
        '
        'exitMetroButton
        '
        Me.exitMetroButton.Location = New System.Drawing.Point(1155, 627)
        Me.exitMetroButton.Name = "exitMetroButton"
        Me.exitMetroButton.Size = New System.Drawing.Size(85, 36)
        Me.exitMetroButton.TabIndex = 5
        Me.exitMetroButton.Text = "Exit"
        Me.exitMetroButton.UseSelectable = True
        '
        'subjectLabel
        '
        Me.subjectLabel.AutoSize = True
        Me.subjectLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.subjectLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(154, Byte), Integer))
        Me.subjectLabel.Location = New System.Drawing.Point(585, 9)
        Me.subjectLabel.Name = "subjectLabel"
        Me.subjectLabel.Size = New System.Drawing.Size(0, 31)
        Me.subjectLabel.TabIndex = 6
        Me.subjectLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'studyLevelLabel
        '
        Me.studyLevelLabel.AutoSize = True
        Me.studyLevelLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.studyLevelLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(154, Byte), Integer))
        Me.studyLevelLabel.Location = New System.Drawing.Point(620, 74)
        Me.studyLevelLabel.Name = "studyLevelLabel"
        Me.studyLevelLabel.Size = New System.Drawing.Size(72, 24)
        Me.studyLevelLabel.TabIndex = 7
        Me.studyLevelLabel.Text = "Label2"
        '
        'classRoom
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1322, 673)
        Me.Controls.Add(Me.studyLevelLabel)
        Me.Controls.Add(Me.subjectLabel)
        Me.Controls.Add(Me.exitMetroButton)
        Me.Controls.Add(Me.viewMetroButton)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.classRoomMetroTabControl)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "classRoom"
        Me.Text = "classRoom"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.classRoomMetroTabControl.ResumeLayout(False)
        Me.classWorkTabPage.ResumeLayout(False)
        Me.labsTabPage.ResumeLayout(False)
        Me.examsTabPage.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents classRoomMetroTabControl As MetroFramework.Controls.MetroTabControl
    Friend WithEvents classWorkTabPage As MetroFramework.Controls.MetroTabPage
    Friend WithEvents labsTabPage As MetroFramework.Controls.MetroTabPage
    Friend WithEvents examsTabPage As MetroFramework.Controls.MetroTabPage
    Friend WithEvents classWorkListBox As ListBox
    Friend WithEvents labListBox As ListBox
    Friend WithEvents examsListBox As ListBox
    Friend WithEvents Label1 As Label
    Friend WithEvents viewMetroButton As MetroFramework.Controls.MetroButton
    Friend WithEvents exitMetroButton As MetroFramework.Controls.MetroButton
    Friend WithEvents subjectLabel As Label
    Friend WithEvents studyLevelLabel As Label
End Class
