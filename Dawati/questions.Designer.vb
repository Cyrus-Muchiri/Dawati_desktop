<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class questions
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
        Me.questionsPanel = New System.Windows.Forms.Panel()
        Me.ExamTitleLabel = New System.Windows.Forms.Label()
        Me.submitMetroTile = New MetroFramework.Controls.MetroTile()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.timeLeftLabel = New System.Windows.Forms.Label()
        Me.scoreTextLabel = New System.Windows.Forms.Label()
        Me.scoreLabel = New System.Windows.Forms.Label()
        Me.commentsTextLabel = New System.Windows.Forms.Label()
        Me.comentsLabel = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'questionsPanel
        '
        Me.questionsPanel.BackColor = System.Drawing.Color.Gainsboro
        Me.questionsPanel.Location = New System.Drawing.Point(157, 112)
        Me.questionsPanel.Name = "questionsPanel"
        Me.questionsPanel.Size = New System.Drawing.Size(1012, 487)
        Me.questionsPanel.TabIndex = 0
        '
        'ExamTitleLabel
        '
        Me.ExamTitleLabel.AutoSize = True
        Me.ExamTitleLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ExamTitleLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(154, Byte), Integer))
        Me.ExamTitleLabel.Location = New System.Drawing.Point(503, 52)
        Me.ExamTitleLabel.Name = "ExamTitleLabel"
        Me.ExamTitleLabel.Size = New System.Drawing.Size(111, 37)
        Me.ExamTitleLabel.TabIndex = 1
        Me.ExamTitleLabel.Text = "Label1"
        '
        'submitMetroTile
        '
        Me.submitMetroTile.ActiveControl = Nothing
        Me.submitMetroTile.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(154, Byte), Integer))
        Me.submitMetroTile.Location = New System.Drawing.Point(1186, 535)
        Me.submitMetroTile.Name = "submitMetroTile"
        Me.submitMetroTile.Size = New System.Drawing.Size(115, 74)
        Me.submitMetroTile.TabIndex = 2
        Me.submitMetroTile.Text = "Submit"
        Me.submitMetroTile.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall
        Me.submitMetroTile.UseCustomBackColor = True
        Me.submitMetroTile.UseSelectable = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(1051, 87)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(77, 20)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "TIme Left"
        '
        'timeLeftLabel
        '
        Me.timeLeftLabel.AutoSize = True
        Me.timeLeftLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.timeLeftLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(154, Byte), Integer))
        Me.timeLeftLabel.Location = New System.Drawing.Point(1130, 87)
        Me.timeLeftLabel.Name = "timeLeftLabel"
        Me.timeLeftLabel.Size = New System.Drawing.Size(39, 20)
        Me.timeLeftLabel.TabIndex = 4
        Me.timeLeftLabel.Text = "time"
        '
        'scoreTextLabel
        '
        Me.scoreTextLabel.AutoSize = True
        Me.scoreTextLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.scoreTextLabel.Location = New System.Drawing.Point(12, 112)
        Me.scoreTextLabel.Name = "scoreTextLabel"
        Me.scoreTextLabel.Size = New System.Drawing.Size(60, 24)
        Me.scoreTextLabel.TabIndex = 5
        Me.scoreTextLabel.Text = "Score"
        Me.scoreTextLabel.Visible = False
        '
        'scoreLabel
        '
        Me.scoreLabel.AutoSize = True
        Me.scoreLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.scoreLabel.Location = New System.Drawing.Point(65, 156)
        Me.scoreLabel.Name = "scoreLabel"
        Me.scoreLabel.Size = New System.Drawing.Size(49, 16)
        Me.scoreLabel.TabIndex = 6
        Me.scoreLabel.Text = "Label3"
        Me.scoreLabel.Visible = False
        '
        'commentsTextLabel
        '
        Me.commentsTextLabel.AutoSize = True
        Me.commentsTextLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.commentsTextLabel.Location = New System.Drawing.Point(13, 191)
        Me.commentsTextLabel.Name = "commentsTextLabel"
        Me.commentsTextLabel.Size = New System.Drawing.Size(66, 24)
        Me.commentsTextLabel.TabIndex = 7
        Me.commentsTextLabel.Text = "Label4"
        Me.commentsTextLabel.Visible = False
        '
        'comentsLabel
        '
        Me.comentsLabel.AutoSize = True
        Me.comentsLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.comentsLabel.Location = New System.Drawing.Point(68, 235)
        Me.comentsLabel.Name = "comentsLabel"
        Me.comentsLabel.Size = New System.Drawing.Size(49, 16)
        Me.comentsLabel.TabIndex = 8
        Me.comentsLabel.Text = "Label5"
        Me.comentsLabel.Visible = False
        '
        'questions
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1313, 635)
        Me.Controls.Add(Me.comentsLabel)
        Me.Controls.Add(Me.commentsTextLabel)
        Me.Controls.Add(Me.scoreLabel)
        Me.Controls.Add(Me.scoreTextLabel)
        Me.Controls.Add(Me.timeLeftLabel)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.submitMetroTile)
        Me.Controls.Add(Me.ExamTitleLabel)
        Me.Controls.Add(Me.questionsPanel)
        Me.Name = "questions"
        Me.Text = "questions"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents questionsPanel As Panel
    Friend WithEvents ExamTitleLabel As Label
    Friend WithEvents submitMetroTile As MetroFramework.Controls.MetroTile
    Friend WithEvents Label1 As Label
    Friend WithEvents timeLeftLabel As Label
    Friend WithEvents scoreTextLabel As Label
    Friend WithEvents scoreLabel As Label
    Friend WithEvents commentsTextLabel As Label
    Friend WithEvents comentsLabel As Label
End Class
