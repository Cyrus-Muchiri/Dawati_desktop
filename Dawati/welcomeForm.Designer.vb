<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class welcomeForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(welcomeForm))
        Me.MetroButton3 = New MetroFramework.Controls.MetroButton()
        Me.signInMetroTile = New MetroFramework.Controls.MetroTile()
        Me.signUpMetroTile = New MetroFramework.Controls.MetroTile()
        Me.welcomeFormPanel = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.welcomeFormPanel.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MetroButton3
        '
        Me.MetroButton3.Location = New System.Drawing.Point(1188, 569)
        Me.MetroButton3.Name = "MetroButton3"
        Me.MetroButton3.Size = New System.Drawing.Size(75, 44)
        Me.MetroButton3.TabIndex = 3
        Me.MetroButton3.Text = "&Exit"
        Me.MetroButton3.UseSelectable = True
        '
        'signInMetroTile
        '
        Me.signInMetroTile.ActiveControl = Nothing
        Me.signInMetroTile.Location = New System.Drawing.Point(1168, 158)
        Me.signInMetroTile.Name = "signInMetroTile"
        Me.signInMetroTile.Size = New System.Drawing.Size(119, 74)
        Me.signInMetroTile.Style = MetroFramework.MetroColorStyle.Purple
        Me.signInMetroTile.TabIndex = 12
        Me.signInMetroTile.Text = "SIGN IN"
        Me.signInMetroTile.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular
        Me.signInMetroTile.UseSelectable = True
        '
        'signUpMetroTile
        '
        Me.signUpMetroTile.ActiveControl = Nothing
        Me.signUpMetroTile.Location = New System.Drawing.Point(1168, 27)
        Me.signUpMetroTile.Name = "signUpMetroTile"
        Me.signUpMetroTile.Size = New System.Drawing.Size(119, 80)
        Me.signUpMetroTile.Style = MetroFramework.MetroColorStyle.Silver
        Me.signUpMetroTile.TabIndex = 11
        Me.signUpMetroTile.Text = "SIGN UP"
        Me.signUpMetroTile.UseSelectable = True
        '
        'welcomeFormPanel
        '
        Me.welcomeFormPanel.BackColor = System.Drawing.Color.Transparent
        Me.welcomeFormPanel.BackgroundImage = CType(resources.GetObject("welcomeFormPanel.BackgroundImage"), System.Drawing.Image)
        Me.welcomeFormPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.welcomeFormPanel.Controls.Add(Me.Panel1)
        Me.welcomeFormPanel.Location = New System.Drawing.Point(-2, -1)
        Me.welcomeFormPanel.Name = "welcomeFormPanel"
        Me.welcomeFormPanel.Size = New System.Drawing.Size(1122, 703)
        Me.welcomeFormPanel.TabIndex = 13
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label1.Location = New System.Drawing.Point(430, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(437, 55)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Dawati E-Learning"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label2.Location = New System.Drawing.Point(332, 81)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(496, 29)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Studying on the comfort of your computer."
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label3.Location = New System.Drawing.Point(1182, 195)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(154, 25)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Works Offline"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(549, 588)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(117, 15)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Carrel Technologies"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(589, 619)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(44, 16)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "©2018"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(3, 13)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1116, 674)
        Me.Panel1.TabIndex = 14
        '
        'welcomeForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ClientSize = New System.Drawing.Size(1299, 707)
        Me.Controls.Add(Me.welcomeFormPanel)
        Me.Controls.Add(Me.signInMetroTile)
        Me.Controls.Add(Me.signUpMetroTile)
        Me.Controls.Add(Me.MetroButton3)
        Me.Name = "welcomeForm"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.welcomeFormPanel.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents MetroButton3 As MetroFramework.Controls.MetroButton
    Friend WithEvents signInMetroTile As MetroFramework.Controls.MetroTile
    Friend WithEvents signUpMetroTile As MetroFramework.Controls.MetroTile
    Friend WithEvents welcomeFormPanel As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
End Class
