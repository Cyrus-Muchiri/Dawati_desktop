<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class selectStudyLevel
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
        Me.form1MetroTile = New MetroFramework.Controls.MetroTile()
        Me.form2MetroTile = New MetroFramework.Controls.MetroTile()
        Me.form3MetroTile = New MetroFramework.Controls.MetroTile()
        Me.form4MetroTile = New MetroFramework.Controls.MetroTile()
        Me.cancelMetroButton = New MetroFramework.Controls.MetroButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'form1MetroTile
        '
        Me.form1MetroTile.ActiveControl = Nothing
        Me.form1MetroTile.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(154, Byte), Integer))
        Me.form1MetroTile.Location = New System.Drawing.Point(40, 85)
        Me.form1MetroTile.Name = "form1MetroTile"
        Me.form1MetroTile.Size = New System.Drawing.Size(107, 63)
        Me.form1MetroTile.TabIndex = 0
        Me.form1MetroTile.Text = "Form 1"
        Me.form1MetroTile.UseCustomBackColor = True
        Me.form1MetroTile.UseSelectable = True
        '
        'form2MetroTile
        '
        Me.form2MetroTile.ActiveControl = Nothing
        Me.form2MetroTile.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(154, Byte), Integer))
        Me.form2MetroTile.Location = New System.Drawing.Point(184, 85)
        Me.form2MetroTile.Name = "form2MetroTile"
        Me.form2MetroTile.Size = New System.Drawing.Size(104, 63)
        Me.form2MetroTile.TabIndex = 1
        Me.form2MetroTile.Text = "Form 2"
        Me.form2MetroTile.UseCustomBackColor = True
        Me.form2MetroTile.UseSelectable = True
        '
        'form3MetroTile
        '
        Me.form3MetroTile.ActiveControl = Nothing
        Me.form3MetroTile.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(154, Byte), Integer))
        Me.form3MetroTile.Location = New System.Drawing.Point(40, 180)
        Me.form3MetroTile.Name = "form3MetroTile"
        Me.form3MetroTile.Size = New System.Drawing.Size(107, 60)
        Me.form3MetroTile.TabIndex = 2
        Me.form3MetroTile.Text = "Form 3"
        Me.form3MetroTile.UseCustomBackColor = True
        Me.form3MetroTile.UseSelectable = True
        '
        'form4MetroTile
        '
        Me.form4MetroTile.ActiveControl = Nothing
        Me.form4MetroTile.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(154, Byte), Integer))
        Me.form4MetroTile.Location = New System.Drawing.Point(184, 180)
        Me.form4MetroTile.Name = "form4MetroTile"
        Me.form4MetroTile.Size = New System.Drawing.Size(104, 60)
        Me.form4MetroTile.TabIndex = 3
        Me.form4MetroTile.Text = "Form 4"
        Me.form4MetroTile.UseCustomBackColor = True
        Me.form4MetroTile.UseSelectable = True
        '
        'cancelMetroButton
        '
        Me.cancelMetroButton.Highlight = True
        Me.cancelMetroButton.Location = New System.Drawing.Point(184, 254)
        Me.cancelMetroButton.Name = "cancelMetroButton"
        Me.cancelMetroButton.Size = New System.Drawing.Size(75, 34)
        Me.cancelMetroButton.TabIndex = 4
        Me.cancelMetroButton.Text = "Cancel"
        Me.cancelMetroButton.UseSelectable = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Tai Le", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(49, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(227, 34)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Select Study Level"
        '
        'selectStudyLevel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(314, 315)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cancelMetroButton)
        Me.Controls.Add(Me.form4MetroTile)
        Me.Controls.Add(Me.form3MetroTile)
        Me.Controls.Add(Me.form2MetroTile)
        Me.Controls.Add(Me.form1MetroTile)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "selectStudyLevel"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents form1MetroTile As MetroFramework.Controls.MetroTile
    Friend WithEvents form2MetroTile As MetroFramework.Controls.MetroTile
    Friend WithEvents form3MetroTile As MetroFramework.Controls.MetroTile
    Friend WithEvents form4MetroTile As MetroFramework.Controls.MetroTile
    Friend WithEvents cancelMetroButton As MetroFramework.Controls.MetroButton
    Friend WithEvents Label1 As Label
End Class
