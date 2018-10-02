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
        Me.evaluationsListBox.ItemHeight = 24
        Me.evaluationsListBox.Location = New System.Drawing.Point(12, 77)
        Me.evaluationsListBox.Name = "evaluationsListBox"
        Me.evaluationsListBox.Size = New System.Drawing.Size(419, 340)
        Me.evaluationsListBox.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(154, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(62, 33)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(277, 25)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Select Evaluation to start"
        '
        'examDetailsLabel
        '
        Me.examDetailsLabel.AutoSize = True
        Me.examDetailsLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.examDetailsLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(154, Byte), Integer))
        Me.examDetailsLabel.Location = New System.Drawing.Point(643, 34)
        Me.examDetailsLabel.Name = "examDetailsLabel"
        Me.examDetailsLabel.Size = New System.Drawing.Size(131, 24)
        Me.examDetailsLabel.TabIndex = 3
        Me.examDetailsLabel.Text = "Exam Details"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(648, 271)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(89, 20)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Description"
        '
        'hoursLabel
        '
        Me.hoursLabel.AutoSize = True
        Me.hoursLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.hoursLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(154, Byte), Integer))
        Me.hoursLabel.Location = New System.Drawing.Point(770, 483)
        Me.hoursLabel.Name = "hoursLabel"
        Me.hoursLabel.Size = New System.Drawing.Size(0, 20)
        Me.hoursLabel.TabIndex = 7
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(648, 353)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(159, 20)
        Me.Label7.TabIndex = 9
        Me.Label7.Text = "Number of Questions"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(648, 435)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(70, 20)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Duration"
        '
        'noOfQuestionsLabel
        '
        Me.noOfQuestionsLabel.AutoSize = True
        Me.noOfQuestionsLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.noOfQuestionsLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(154, Byte), Integer))
        Me.noOfQuestionsLabel.Location = New System.Drawing.Point(770, 399)
        Me.noOfQuestionsLabel.Name = "noOfQuestionsLabel"
        Me.noOfQuestionsLabel.Size = New System.Drawing.Size(0, 20)
        Me.noOfQuestionsLabel.TabIndex = 15
        '
        'minutesLabel
        '
        Me.minutesLabel.AutoSize = True
        Me.minutesLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.minutesLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(154, Byte), Integer))
        Me.minutesLabel.Location = New System.Drawing.Point(864, 483)
        Me.minutesLabel.Name = "minutesLabel"
        Me.minutesLabel.Size = New System.Drawing.Size(0, 20)
        Me.minutesLabel.TabIndex = 16
        '
        'descriptionLabel
        '
        Me.descriptionLabel.AutoSize = True
        Me.descriptionLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.descriptionLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(154, Byte), Integer))
        Me.descriptionLabel.Location = New System.Drawing.Point(770, 315)
        Me.descriptionLabel.Name = "descriptionLabel"
        Me.descriptionLabel.Size = New System.Drawing.Size(0, 20)
        Me.descriptionLabel.TabIndex = 18
        '
        'hoursNameLabel
        '
        Me.hoursNameLabel.AutoSize = True
        Me.hoursNameLabel.Location = New System.Drawing.Point(806, 488)
        Me.hoursNameLabel.Name = "hoursNameLabel"
        Me.hoursNameLabel.Size = New System.Drawing.Size(35, 13)
        Me.hoursNameLabel.TabIndex = 19
        Me.hoursNameLabel.Text = "Hours"
        Me.hoursNameLabel.Visible = False
        '
        'MinutesNameLabel
        '
        Me.MinutesNameLabel.AutoSize = True
        Me.MinutesNameLabel.Location = New System.Drawing.Point(900, 488)
        Me.MinutesNameLabel.Name = "MinutesNameLabel"
        Me.MinutesNameLabel.Size = New System.Drawing.Size(44, 13)
        Me.MinutesNameLabel.TabIndex = 20
        Me.MinutesNameLabel.Text = "Minutes"
        Me.MinutesNameLabel.Visible = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(648, 107)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(93, 20)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Exam name"
        '
        'examNameLabel
        '
        Me.examNameLabel.AutoSize = True
        Me.examNameLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.examNameLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(154, Byte), Integer))
        Me.examNameLabel.Location = New System.Drawing.Point(770, 147)
        Me.examNameLabel.Name = "examNameLabel"
        Me.examNameLabel.Size = New System.Drawing.Size(0, 20)
        Me.examNameLabel.TabIndex = 17
        '
        'subjectLabel
        '
        Me.subjectLabel.AutoSize = True
        Me.subjectLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.subjectLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(154, Byte), Integer))
        Me.subjectLabel.Location = New System.Drawing.Point(770, 231)
        Me.subjectLabel.Name = "subjectLabel"
        Me.subjectLabel.Size = New System.Drawing.Size(0, 20)
        Me.subjectLabel.TabIndex = 22
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(648, 189)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(63, 20)
        Me.Label9.TabIndex = 21
        Me.Label9.Text = "Subject"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Red
        Me.Label3.Location = New System.Drawing.Point(148, 455)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(283, 24)
        Me.Label3.TabIndex = 23
        Me.Label3.Text = "Select an exam to view its details"
        '
        'startMetroTile
        '
        Me.startMetroTile.ActiveControl = Nothing
        Me.startMetroTile.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(154, Byte), Integer))
        Me.startMetroTile.Location = New System.Drawing.Point(1077, 508)
        Me.startMetroTile.Name = "startMetroTile"
        Me.startMetroTile.Size = New System.Drawing.Size(129, 79)
        Me.startMetroTile.TabIndex = 24
        Me.startMetroTile.Text = "Start Test"
        Me.startMetroTile.UseCustomBackColor = True
        Me.startMetroTile.UseSelectable = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Red
        Me.Label5.Location = New System.Drawing.Point(648, 567)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(190, 24)
        Me.Label5.TabIndex = 25
        Me.Label5.Text = "Click START to begin"
        '
        'evaluationForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1314, 631)
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
