<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class classRoom
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
        Me.classRoomMetroTabControl.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.classRoomMetroTabControl.Controls.Add(Me.classWorkTabPage)
        Me.classRoomMetroTabControl.Controls.Add(Me.labsTabPage)
        Me.classRoomMetroTabControl.Controls.Add(Me.examsTabPage)
        Me.classRoomMetroTabControl.Location = New System.Drawing.Point(141, 129)
        Me.classRoomMetroTabControl.Margin = New System.Windows.Forms.Padding(4)
        Me.classRoomMetroTabControl.Name = "classRoomMetroTabControl"
        Me.classRoomMetroTabControl.SelectedIndex = 0
        Me.classRoomMetroTabControl.Size = New System.Drawing.Size(1531, 605)
        Me.classRoomMetroTabControl.TabIndex = 0
        Me.classRoomMetroTabControl.UseSelectable = True
        '
        'classWorkTabPage
        '
        Me.classWorkTabPage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.classWorkTabPage.Controls.Add(Me.classWorkListBox)
        Me.classWorkTabPage.HorizontalScrollbarBarColor = True
        Me.classWorkTabPage.HorizontalScrollbarHighlightOnWheel = False
        Me.classWorkTabPage.HorizontalScrollbarSize = 12
        Me.classWorkTabPage.Location = New System.Drawing.Point(4, 38)
        Me.classWorkTabPage.Margin = New System.Windows.Forms.Padding(4)
        Me.classWorkTabPage.Name = "classWorkTabPage"
        Me.classWorkTabPage.Size = New System.Drawing.Size(1523, 563)
        Me.classWorkTabPage.TabIndex = 0
        Me.classWorkTabPage.Text = "                              Class Work                                         " &
    "  |"
        Me.classWorkTabPage.VerticalScrollbarBarColor = True
        Me.classWorkTabPage.VerticalScrollbarHighlightOnWheel = False
        Me.classWorkTabPage.VerticalScrollbarSize = 13
        '
        'classWorkListBox
        '
        Me.classWorkListBox.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.classWorkListBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(233, Byte), Integer), CType(CType(78, Byte), Integer), CType(CType(27, Byte), Integer))
        Me.classWorkListBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.classWorkListBox.FormattingEnabled = True
        Me.classWorkListBox.ItemHeight = 30
        Me.classWorkListBox.Location = New System.Drawing.Point(1, 1)
        Me.classWorkListBox.Margin = New System.Windows.Forms.Padding(4)
        Me.classWorkListBox.Name = "classWorkListBox"
        Me.classWorkListBox.Size = New System.Drawing.Size(1508, 634)
        Me.classWorkListBox.TabIndex = 2
        '
        'labsTabPage
        '
        Me.labsTabPage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.labsTabPage.Controls.Add(Me.labListBox)
        Me.labsTabPage.HorizontalScrollbarBarColor = True
        Me.labsTabPage.HorizontalScrollbarHighlightOnWheel = False
        Me.labsTabPage.HorizontalScrollbarSize = 12
        Me.labsTabPage.Location = New System.Drawing.Point(4, 38)
        Me.labsTabPage.Margin = New System.Windows.Forms.Padding(4)
        Me.labsTabPage.Name = "labsTabPage"
        Me.labsTabPage.Size = New System.Drawing.Size(1504, 528)
        Me.labsTabPage.TabIndex = 1
        Me.labsTabPage.Text = "                                    Lab practicals                               " &
    "           |"
        Me.labsTabPage.VerticalScrollbarBarColor = True
        Me.labsTabPage.VerticalScrollbarHighlightOnWheel = False
        Me.labsTabPage.VerticalScrollbarSize = 13
        '
        'labListBox
        '
        Me.labListBox.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.labListBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(123, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.labListBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labListBox.FormattingEnabled = True
        Me.labListBox.ItemHeight = 30
        Me.labListBox.Location = New System.Drawing.Point(4, 4)
        Me.labListBox.Margin = New System.Windows.Forms.Padding(4)
        Me.labListBox.Name = "labListBox"
        Me.labListBox.Size = New System.Drawing.Size(1491, 604)
        Me.labListBox.TabIndex = 2
        '
        'examsTabPage
        '
        Me.examsTabPage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.examsTabPage.Controls.Add(Me.examsListBox)
        Me.examsTabPage.HorizontalScrollbarBarColor = True
        Me.examsTabPage.HorizontalScrollbarHighlightOnWheel = False
        Me.examsTabPage.HorizontalScrollbarSize = 12
        Me.examsTabPage.Location = New System.Drawing.Point(4, 38)
        Me.examsTabPage.Margin = New System.Windows.Forms.Padding(4)
        Me.examsTabPage.Name = "examsTabPage"
        Me.examsTabPage.Size = New System.Drawing.Size(1504, 528)
        Me.examsTabPage.TabIndex = 2
        Me.examsTabPage.Text = "                                     Exams                           "
        Me.examsTabPage.VerticalScrollbarBarColor = True
        Me.examsTabPage.VerticalScrollbarHighlightOnWheel = False
        Me.examsTabPage.VerticalScrollbarSize = 13
        '
        'examsListBox
        '
        Me.examsListBox.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.examsListBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(154, Byte), Integer))
        Me.examsListBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.examsListBox.FormattingEnabled = True
        Me.examsListBox.ItemHeight = 30
        Me.examsListBox.Location = New System.Drawing.Point(4, 2)
        Me.examsListBox.Margin = New System.Windows.Forms.Padding(4)
        Me.examsListBox.Name = "examsListBox"
        Me.examsListBox.Size = New System.Drawing.Size(1487, 574)
        Me.examsListBox.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(753, 88)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(312, 20)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Select videos / ebooks you want to study"
        '
        'viewMetroButton
        '
        Me.viewMetroButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.viewMetroButton.Location = New System.Drawing.Point(145, 773)
        Me.viewMetroButton.Margin = New System.Windows.Forms.Padding(4)
        Me.viewMetroButton.Name = "viewMetroButton"
        Me.viewMetroButton.Size = New System.Drawing.Size(100, 44)
        Me.viewMetroButton.TabIndex = 3
        Me.viewMetroButton.Text = "View"
        Me.viewMetroButton.UseSelectable = True
        '
        'exitMetroButton
        '
        Me.exitMetroButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.exitMetroButton.Location = New System.Drawing.Point(1555, 760)
        Me.exitMetroButton.Margin = New System.Windows.Forms.Padding(4)
        Me.exitMetroButton.Name = "exitMetroButton"
        Me.exitMetroButton.Size = New System.Drawing.Size(113, 44)
        Me.exitMetroButton.TabIndex = 5
        Me.exitMetroButton.Text = "Exit"
        Me.exitMetroButton.UseSelectable = True
        '
        'subjectLabel
        '
        Me.subjectLabel.AutoSize = True
        Me.subjectLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.subjectLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(154, Byte), Integer))
        Me.subjectLabel.Location = New System.Drawing.Point(807, 11)
        Me.subjectLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.subjectLabel.Name = "subjectLabel"
        Me.subjectLabel.Size = New System.Drawing.Size(0, 39)
        Me.subjectLabel.TabIndex = 6
        Me.subjectLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'studyLevelLabel
        '
        Me.studyLevelLabel.AutoSize = True
        Me.studyLevelLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.studyLevelLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(154, Byte), Integer))
        Me.studyLevelLabel.Location = New System.Drawing.Point(850, 44)
        Me.studyLevelLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.studyLevelLabel.Name = "studyLevelLabel"
        Me.studyLevelLabel.Size = New System.Drawing.Size(108, 32)
        Me.studyLevelLabel.TabIndex = 7
        Me.studyLevelLabel.Text = "Label2"
        '
        'classRoom
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(129, Byte), Integer), CType(CType(113, Byte), Integer), CType(CType(184, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1838, 867)
        Me.Controls.Add(Me.studyLevelLabel)
        Me.Controls.Add(Me.subjectLabel)
        Me.Controls.Add(Me.exitMetroButton)
        Me.Controls.Add(Me.viewMetroButton)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.classRoomMetroTabControl)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "classRoom"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
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
