<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class videoPlayer
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(videoPlayer))
        Me.AxWindowsMediaPlayer = New AxWMPLib.AxWindowsMediaPlayer()
        Me.playListListBox = New System.Windows.Forms.ListBox()
        Me.playMetroButton = New MetroFramework.Controls.MetroButton()
        Me.MetroButton2 = New MetroFramework.Controls.MetroButton()
        Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
        Me.Videos = New System.Windows.Forms.Label()
        CType(Me.AxWindowsMediaPlayer, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'AxWindowsMediaPlayer
        '
        Me.AxWindowsMediaPlayer.Enabled = True
        Me.AxWindowsMediaPlayer.Location = New System.Drawing.Point(2, 60)
        Me.AxWindowsMediaPlayer.Name = "AxWindowsMediaPlayer"
        Me.AxWindowsMediaPlayer.OcxState = CType(resources.GetObject("AxWindowsMediaPlayer.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AxWindowsMediaPlayer.Size = New System.Drawing.Size(912, 533)
        Me.AxWindowsMediaPlayer.TabIndex = 0
        '
        'playListListBox
        '
        Me.playListListBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.playListListBox.FormattingEnabled = True
        Me.playListListBox.ItemHeight = 24
        Me.playListListBox.Location = New System.Drawing.Point(920, 62)
        Me.playListListBox.Name = "playListListBox"
        Me.playListListBox.Size = New System.Drawing.Size(382, 316)
        Me.playListListBox.TabIndex = 1
        '
        'playMetroButton
        '
        Me.playMetroButton.Location = New System.Drawing.Point(1218, 430)
        Me.playMetroButton.Name = "playMetroButton"
        Me.playMetroButton.Size = New System.Drawing.Size(84, 44)
        Me.playMetroButton.TabIndex = 2
        Me.playMetroButton.Text = "Play"
        Me.playMetroButton.UseSelectable = True
        '
        'MetroButton2
        '
        Me.MetroButton2.Location = New System.Drawing.Point(1201, 644)
        Me.MetroButton2.Name = "MetroButton2"
        Me.MetroButton2.Size = New System.Drawing.Size(101, 35)
        Me.MetroButton2.TabIndex = 3
        Me.MetroButton2.Text = "Exit"
        Me.MetroButton2.UseSelectable = True
        '
        'MetroLabel1
        '
        Me.MetroLabel1.AutoSize = True
        Me.MetroLabel1.Location = New System.Drawing.Point(965, 29)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(86, 19)
        Me.MetroLabel1.TabIndex = 4
        Me.MetroLabel1.Text = "Other Videos"
        '
        'Videos
        '
        Me.Videos.AutoSize = True
        Me.Videos.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Videos.Location = New System.Drawing.Point(463, 13)
        Me.Videos.Name = "Videos"
        Me.Videos.Size = New System.Drawing.Size(139, 42)
        Me.Videos.TabIndex = 5
        Me.Videos.Text = "Videos"
        '
        'videoPlayer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1325, 695)
        Me.Controls.Add(Me.Videos)
        Me.Controls.Add(Me.MetroLabel1)
        Me.Controls.Add(Me.MetroButton2)
        Me.Controls.Add(Me.playMetroButton)
        Me.Controls.Add(Me.playListListBox)
        Me.Controls.Add(Me.AxWindowsMediaPlayer)
        Me.Name = "videoPlayer"
        Me.Text = "videoPlayer"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.AxWindowsMediaPlayer, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents AxWindowsMediaPlayer As AxWMPLib.AxWindowsMediaPlayer
    Friend WithEvents playListListBox As ListBox
    Friend WithEvents playMetroButton As MetroFramework.Controls.MetroButton
    Friend WithEvents MetroButton2 As MetroFramework.Controls.MetroButton
    Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
    Friend WithEvents Videos As Label
End Class
