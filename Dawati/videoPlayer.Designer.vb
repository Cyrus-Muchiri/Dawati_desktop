<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class videoPlayer
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(videoPlayer))
        Me.AxWindowsMediaPlayer = New AxWMPLib.AxWindowsMediaPlayer()
        Me.playListListBox = New System.Windows.Forms.ListBox()
        Me.playMetroButton = New MetroFramework.Controls.MetroButton()
        Me.exitMetroButton = New MetroFramework.Controls.MetroButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.videoLabel = New System.Windows.Forms.Label()
        Me.ViewsCounter = New System.Windows.Forms.Label()
        Me.viewsLabel = New System.Windows.Forms.Label()
        CType(Me.AxWindowsMediaPlayer, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'AxWindowsMediaPlayer
        '
        Me.AxWindowsMediaPlayer.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.AxWindowsMediaPlayer.Enabled = True
        Me.AxWindowsMediaPlayer.Location = New System.Drawing.Point(31, 90)
        Me.AxWindowsMediaPlayer.Margin = New System.Windows.Forms.Padding(4)
        Me.AxWindowsMediaPlayer.MaximumSize = New System.Drawing.Size(1188, 677)
        Me.AxWindowsMediaPlayer.Name = "AxWindowsMediaPlayer"
        Me.AxWindowsMediaPlayer.OcxState = CType(resources.GetObject("AxWindowsMediaPlayer.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AxWindowsMediaPlayer.Size = New System.Drawing.Size(1094, 677)
        Me.AxWindowsMediaPlayer.TabIndex = 0
        '
        'playListListBox
        '
        Me.playListListBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.playListListBox.BackColor = System.Drawing.SystemColors.ControlLight
        Me.playListListBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.playListListBox.FormattingEnabled = True
        Me.playListListBox.ItemHeight = 29
        Me.playListListBox.Location = New System.Drawing.Point(1356, 108)
        Me.playListListBox.Margin = New System.Windows.Forms.Padding(4)
        Me.playListListBox.Name = "playListListBox"
        Me.playListListBox.Size = New System.Drawing.Size(443, 410)
        Me.playListListBox.TabIndex = 1
        '
        'playMetroButton
        '
        Me.playMetroButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.playMetroButton.Location = New System.Drawing.Point(1688, 603)
        Me.playMetroButton.Margin = New System.Windows.Forms.Padding(4)
        Me.playMetroButton.Name = "playMetroButton"
        Me.playMetroButton.Size = New System.Drawing.Size(112, 54)
        Me.playMetroButton.TabIndex = 2
        Me.playMetroButton.Text = "Play"
        Me.playMetroButton.UseSelectable = True
        '
        'exitMetroButton
        '
        Me.exitMetroButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.exitMetroButton.Location = New System.Drawing.Point(1664, 800)
        Me.exitMetroButton.Margin = New System.Windows.Forms.Padding(4)
        Me.exitMetroButton.Name = "exitMetroButton"
        Me.exitMetroButton.Size = New System.Drawing.Size(135, 43)
        Me.exitMetroButton.TabIndex = 3
        Me.exitMetroButton.Text = "Exit"
        Me.exitMetroButton.UseSelectable = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(154, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(1467, 60)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(212, 31)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Related Videos"
        '
        'videoLabel
        '
        Me.videoLabel.AutoSize = True
        Me.videoLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.videoLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(154, Byte), Integer))
        Me.videoLabel.Location = New System.Drawing.Point(420, 41)
        Me.videoLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.videoLabel.Name = "videoLabel"
        Me.videoLabel.Size = New System.Drawing.Size(120, 39)
        Me.videoLabel.TabIndex = 7
        Me.videoLabel.Text = "Label1"
        '
        'ViewsCounter
        '
        Me.ViewsCounter.AutoSize = True
        Me.ViewsCounter.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ViewsCounter.Location = New System.Drawing.Point(31, 813)
        Me.ViewsCounter.Name = "ViewsCounter"
        Me.ViewsCounter.Size = New System.Drawing.Size(0, 20)
        Me.ViewsCounter.TabIndex = 8
        '
        'viewsLabel
        '
        Me.viewsLabel.AutoSize = True
        Me.viewsLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.viewsLabel.Location = New System.Drawing.Point(92, 813)
        Me.viewsLabel.Name = "viewsLabel"
        Me.viewsLabel.Size = New System.Drawing.Size(54, 20)
        Me.viewsLabel.TabIndex = 9
        Me.viewsLabel.Text = "Views"
        '
        'videoPlayer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1816, 896)
        Me.ControlBox = False
        Me.Controls.Add(Me.viewsLabel)
        Me.Controls.Add(Me.ViewsCounter)
        Me.Controls.Add(Me.videoLabel)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.exitMetroButton)
        Me.Controls.Add(Me.playMetroButton)
        Me.Controls.Add(Me.playListListBox)
        Me.Controls.Add(Me.AxWindowsMediaPlayer)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "videoPlayer"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Videos"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.AxWindowsMediaPlayer, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents AxWindowsMediaPlayer As AxWMPLib.AxWindowsMediaPlayer
    Friend WithEvents playListListBox As ListBox
    Friend WithEvents playMetroButton As MetroFramework.Controls.MetroButton
    Friend WithEvents exitMetroButton As MetroFramework.Controls.MetroButton
    Friend WithEvents Label1 As Label
    Friend WithEvents videoLabel As Label
    Friend WithEvents ViewsCounter As Label
    Friend WithEvents viewsLabel As Label
End Class
