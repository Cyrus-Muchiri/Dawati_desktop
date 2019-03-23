<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class attemptReports
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
        Me.commentsTextLabel = New System.Windows.Forms.Label()
        Me.scoreLabel = New System.Windows.Forms.Label()
        Me.scoreTextLabel = New System.Windows.Forms.Label()
        Me.ExamTitleLabel = New System.Windows.Forms.Label()
        Me.questionsPanel = New System.Windows.Forms.Panel()
        Me.label10 = New System.Windows.Forms.Label()
        Me.label3 = New System.Windows.Forms.Label()
        Me.totalScoreLabel = New System.Windows.Forms.Label()
        Me.percentageScoreLabel = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'commentsTextLabel
        '
        Me.commentsTextLabel.AutoSize = True
        Me.commentsTextLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.commentsTextLabel.Location = New System.Drawing.Point(-157, 123)
        Me.commentsTextLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.commentsTextLabel.Name = "commentsTextLabel"
        Me.commentsTextLabel.Size = New System.Drawing.Size(86, 29)
        Me.commentsTextLabel.TabIndex = 17
        Me.commentsTextLabel.Text = "Label4"
        Me.commentsTextLabel.Visible = False
        '
        'scoreLabel
        '
        Me.scoreLabel.AutoSize = True
        Me.scoreLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.scoreLabel.Location = New System.Drawing.Point(-88, 80)
        Me.scoreLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.scoreLabel.Name = "scoreLabel"
        Me.scoreLabel.Size = New System.Drawing.Size(59, 20)
        Me.scoreLabel.TabIndex = 16
        Me.scoreLabel.Text = "Label3"
        Me.scoreLabel.Visible = False
        '
        'scoreTextLabel
        '
        Me.scoreTextLabel.AutoSize = True
        Me.scoreTextLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.scoreTextLabel.Location = New System.Drawing.Point(-159, 26)
        Me.scoreTextLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.scoreTextLabel.Name = "scoreTextLabel"
        Me.scoreTextLabel.Size = New System.Drawing.Size(77, 29)
        Me.scoreTextLabel.TabIndex = 15
        Me.scoreTextLabel.Text = "Score"
        Me.scoreTextLabel.Visible = False
        '
        'ExamTitleLabel
        '
        Me.ExamTitleLabel.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ExamTitleLabel.AutoSize = True
        Me.ExamTitleLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ExamTitleLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(154, Byte), Integer))
        Me.ExamTitleLabel.Location = New System.Drawing.Point(348, 50)
        Me.ExamTitleLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.ExamTitleLabel.Name = "ExamTitleLabel"
        Me.ExamTitleLabel.Size = New System.Drawing.Size(139, 46)
        Me.ExamTitleLabel.TabIndex = 11
        Me.ExamTitleLabel.Text = "Label1"
        '
        'questionsPanel
        '
        Me.questionsPanel.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.questionsPanel.BackColor = System.Drawing.Color.Gainsboro
        Me.questionsPanel.Location = New System.Drawing.Point(294, 100)
        Me.questionsPanel.Margin = New System.Windows.Forms.Padding(4)
        Me.questionsPanel.Name = "questionsPanel"
        Me.questionsPanel.Size = New System.Drawing.Size(1481, 712)
        Me.questionsPanel.TabIndex = 10
        '
        'label10
        '
        Me.label10.AutoSize = True
        Me.label10.Location = New System.Drawing.Point(12, 131)
        Me.label10.Name = "label10"
        Me.label10.Size = New System.Drawing.Size(45, 17)
        Me.label10.TabIndex = 18
        Me.label10.Text = "Score"
        '
        'label3
        '
        Me.label3.AutoSize = True
        Me.label3.Location = New System.Drawing.Point(12, 199)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(81, 17)
        Me.label3.TabIndex = 19
        Me.label3.Text = "Percentage"
        '
        'totalScoreLabel
        '
        Me.totalScoreLabel.AutoSize = True
        Me.totalScoreLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.totalScoreLabel.ForeColor = System.Drawing.Color.Teal
        Me.totalScoreLabel.Location = New System.Drawing.Point(149, 131)
        Me.totalScoreLabel.Name = "totalScoreLabel"
        Me.totalScoreLabel.Size = New System.Drawing.Size(66, 24)
        Me.totalScoreLabel.TabIndex = 20
        Me.totalScoreLabel.Text = "Label1"
        '
        'percentageScoreLabel
        '
        Me.percentageScoreLabel.AutoSize = True
        Me.percentageScoreLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.percentageScoreLabel.ForeColor = System.Drawing.Color.Teal
        Me.percentageScoreLabel.Location = New System.Drawing.Point(149, 199)
        Me.percentageScoreLabel.Name = "percentageScoreLabel"
        Me.percentageScoreLabel.Size = New System.Drawing.Size(66, 24)
        Me.percentageScoreLabel.TabIndex = 21
        Me.percentageScoreLabel.Text = "Label2"
        '
        'attemptReports
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1780, 812)
        Me.Controls.Add(Me.percentageScoreLabel)
        Me.Controls.Add(Me.totalScoreLabel)
        Me.Controls.Add(Me.label3)
        Me.Controls.Add(Me.label10)
        Me.Controls.Add(Me.commentsTextLabel)
        Me.Controls.Add(Me.scoreLabel)
        Me.Controls.Add(Me.scoreTextLabel)
        Me.Controls.Add(Me.ExamTitleLabel)
        Me.Controls.Add(Me.questionsPanel)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "attemptReports"
        Me.Text = "attemptReports"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents commentsTextLabel As Label
    Friend WithEvents scoreLabel As Label
    Friend WithEvents scoreTextLabel As Label
    Friend WithEvents ExamTitleLabel As Label
    Friend WithEvents questionsPanel As Panel
    Friend WithEvents label10 As Label
    Friend WithEvents label3 As Label
    Friend WithEvents totalScoreLabel As Label
    Friend WithEvents percentageScoreLabel As Label
End Class
