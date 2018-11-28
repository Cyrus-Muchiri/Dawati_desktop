<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class evaluationForm
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
        Me.evaluationsListBox = New System.Windows.Forms.ListBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.examDetailsLabel = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.hoursLabel = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.noOfQuestionsLabel = New System.Windows.Forms.Label()
        Me.minutesLabel = New System.Windows.Forms.Label()
        Me.descriptionLabel = New System.Windows.Forms.Label()
        Me.hoursNameLabel = New System.Windows.Forms.Label()
        Me.MinutesNameLabel = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.examNameLabel = New System.Windows.Forms.Label()
        Me.subjectLabel = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.startMetroTile = New MetroFramework.Controls.MetroTile()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'evaluationsListBox
        '
        Me.evaluationsListBox.ColumnWidth = 10
        Me.evaluationsListBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.evaluationsListBox.FormattingEnabled = True
        Me.evaluationsListBox.ItemHeight = 29
        Me.evaluationsListBox.Location = New System.Drawing.Point(16, 95)
        Me.evaluationsListBox.Margin = New System.Windows.Forms.Padding(4)
        Me.evaluationsListBox.Name = "evaluationsListBox"
        Me.evaluationsListBox.Size = New System.Drawing.Size(557, 410)
        Me.evaluationsListBox.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(154, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(83, 41)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(341, 31)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Select Evaluation to start"
        '
        'examDetailsLabel
        '
        Me.examDetailsLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.examDetailsLabel.AutoSize = True
        Me.examDetailsLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.examDetailsLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(154, Byte), Integer))
        Me.examDetailsLabel.Location = New System.Drawing.Point(857, 42)
        Me.examDetailsLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.examDetailsLabel.Name = "examDetailsLabel"
        Me.examDetailsLabel.Size = New System.Drawing.Size(165, 29)
        Me.examDetailsLabel.TabIndex = 3
        Me.examDetailsLabel.Text = "Exam Details"
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(864, 334)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(109, 25)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Description"
        '
        'hoursLabel
        '
        Me.hoursLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.hoursLabel.AutoSize = True
        Me.hoursLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.hoursLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(154, Byte), Integer))
        Me.hoursLabel.Location = New System.Drawing.Point(1027, 594)
        Me.hoursLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.hoursLabel.Name = "hoursLabel"
        Me.hoursLabel.Size = New System.Drawing.Size(0, 25)
        Me.hoursLabel.TabIndex = 7
        '
        'Label7
        '
        Me.Label7.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(864, 434)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(196, 25)
        Me.Label7.TabIndex = 9
        Me.Label7.Text = "Number of Questions"
        '
        'Label6
        '
        Me.Label6.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(864, 535)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(85, 25)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Duration"
        '
        'noOfQuestionsLabel
        '
        Me.noOfQuestionsLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.noOfQuestionsLabel.AutoSize = True
        Me.noOfQuestionsLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.noOfQuestionsLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(154, Byte), Integer))
        Me.noOfQuestionsLabel.Location = New System.Drawing.Point(1027, 491)
        Me.noOfQuestionsLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.noOfQuestionsLabel.Name = "noOfQuestionsLabel"
        Me.noOfQuestionsLabel.Size = New System.Drawing.Size(0, 25)
        Me.noOfQuestionsLabel.TabIndex = 15
        '
        'minutesLabel
        '
        Me.minutesLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.minutesLabel.AutoSize = True
        Me.minutesLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.minutesLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(154, Byte), Integer))
        Me.minutesLabel.Location = New System.Drawing.Point(1152, 594)
        Me.minutesLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.minutesLabel.Name = "minutesLabel"
        Me.minutesLabel.Size = New System.Drawing.Size(0, 25)
        Me.minutesLabel.TabIndex = 16
        '
        'descriptionLabel
        '
        Me.descriptionLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.descriptionLabel.AutoSize = True
        Me.descriptionLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.descriptionLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(154, Byte), Integer))
        Me.descriptionLabel.Location = New System.Drawing.Point(1027, 388)
        Me.descriptionLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.descriptionLabel.Name = "descriptionLabel"
        Me.descriptionLabel.Size = New System.Drawing.Size(0, 25)
        Me.descriptionLabel.TabIndex = 18
        '
        'hoursNameLabel
        '
        Me.hoursNameLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.hoursNameLabel.AutoSize = True
        Me.hoursNameLabel.Location = New System.Drawing.Point(1075, 601)
        Me.hoursNameLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.hoursNameLabel.Name = "hoursNameLabel"
        Me.hoursNameLabel.Size = New System.Drawing.Size(46, 17)
        Me.hoursNameLabel.TabIndex = 19
        Me.hoursNameLabel.Text = "Hours"
        Me.hoursNameLabel.Visible = False
        '
        'MinutesNameLabel
        '
        Me.MinutesNameLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MinutesNameLabel.AutoSize = True
        Me.MinutesNameLabel.Location = New System.Drawing.Point(1200, 601)
        Me.MinutesNameLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.MinutesNameLabel.Name = "MinutesNameLabel"
        Me.MinutesNameLabel.Size = New System.Drawing.Size(57, 17)
        Me.MinutesNameLabel.TabIndex = 20
        Me.MinutesNameLabel.Text = "Minutes"
        Me.MinutesNameLabel.Visible = False
        '
        'Label4
        '
        Me.Label4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(864, 132)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(116, 25)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Exam name"
        '
        'examNameLabel
        '
        Me.examNameLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.examNameLabel.AutoSize = True
        Me.examNameLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.examNameLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(154, Byte), Integer))
        Me.examNameLabel.Location = New System.Drawing.Point(1027, 181)
        Me.examNameLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.examNameLabel.Name = "examNameLabel"
        Me.examNameLabel.Size = New System.Drawing.Size(0, 25)
        Me.examNameLabel.TabIndex = 17
        '
        'subjectLabel
        '
        Me.subjectLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.subjectLabel.AutoSize = True
        Me.subjectLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.subjectLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(154, Byte), Integer))
        Me.subjectLabel.Location = New System.Drawing.Point(1027, 284)
        Me.subjectLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.subjectLabel.Name = "subjectLabel"
        Me.subjectLabel.Size = New System.Drawing.Size(0, 25)
        Me.subjectLabel.TabIndex = 22
        '
        'Label9
        '
        Me.Label9.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(864, 233)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(78, 25)
        Me.Label9.TabIndex = 21
        Me.Label9.Text = "Subject"
        '
        'Label3
        '
        Me.Label3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Red
        Me.Label3.Location = New System.Drawing.Point(11, 535)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(365, 29)
        Me.Label3.TabIndex = 23
        Me.Label3.Text = "Select an exam to view its details"
        '
        'startMetroTile
        '
        Me.startMetroTile.ActiveControl = Nothing
        Me.startMetroTile.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.startMetroTile.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(154, Byte), Integer))
        Me.startMetroTile.Location = New System.Drawing.Point(1436, 625)
        Me.startMetroTile.Margin = New System.Windows.Forms.Padding(4)
        Me.startMetroTile.Name = "startMetroTile"
        Me.startMetroTile.Size = New System.Drawing.Size(172, 97)
        Me.startMetroTile.TabIndex = 24
        Me.startMetroTile.Text = "Start Test"
        Me.startMetroTile.UseCustomBackColor = True
        Me.startMetroTile.UseSelectable = True
        '
        'Label5
        '
        Me.Label5.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Red
        Me.Label5.Location = New System.Drawing.Point(864, 698)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(245, 29)
        Me.Label5.TabIndex = 25
        Me.Label5.Text = "Click START to begin"
        '
        'evaluationForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1752, 777)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.startMetroTile)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.subjectLabel)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.MinutesNameLabel)
        Me.Controls.Add(Me.hoursNameLabel)
        Me.Controls.Add(Me.descriptionLabel)
        Me.Controls.Add(Me.examNameLabel)
        Me.Controls.Add(Me.minutesLabel)
        Me.Controls.Add(Me.noOfQuestionsLabel)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.hoursLabel)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.examDetailsLabel)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.evaluationsListBox)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "evaluationForm"
        Me.Text = "evaluationForm"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents evaluationsListBox As ListBox
    Friend WithEvents Label1 As Label
    Friend WithEvents examDetailsLabel As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents hoursLabel As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents noOfQuestionsLabel As Label
    Friend WithEvents minutesLabel As Label
    Friend WithEvents descriptionLabel As Label
    Friend WithEvents hoursNameLabel As Label
    Friend WithEvents MinutesNameLabel As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents examNameLabel As Label
    Friend WithEvents subjectLabel As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents startMetroTile As MetroFramework.Controls.MetroTile
    Friend WithEvents Label5 As Label
End Class
