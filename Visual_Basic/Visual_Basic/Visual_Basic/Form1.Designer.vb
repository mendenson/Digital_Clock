<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmClocks
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
        Me.components = New System.ComponentModel.Container()
        Me.Clock1 = New System.Windows.Forms.Label()
        Me.Clock2 = New System.Windows.Forms.Label()
        Me.tmrTimer = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'Clock1
        '
        Me.Clock1.AutoSize = True
        Me.Clock1.Font = New System.Drawing.Font("Digital-7", 71.99999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Clock1.ForeColor = System.Drawing.Color.Red
        Me.Clock1.Location = New System.Drawing.Point(236, 69)
        Me.Clock1.Name = "Clock1"
        Me.Clock1.Size = New System.Drawing.Size(321, 96)
        Me.Clock1.TabIndex = 0
        Me.Clock1.Text = "12:00:00"
        '
        'Clock2
        '
        Me.Clock2.AutoSize = True
        Me.Clock2.Font = New System.Drawing.Font("Digital-7", 71.99999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Clock2.ForeColor = System.Drawing.Color.Red
        Me.Clock2.Location = New System.Drawing.Point(183, 186)
        Me.Clock2.Name = "Clock2"
        Me.Clock2.Size = New System.Drawing.Size(440, 96)
        Me.Clock2.TabIndex = 1
        Me.Clock2.Text = "12:00:00 AM"
        '
        'tmrTimer
        '
        Me.tmrTimer.Enabled = True
        Me.tmrTimer.Interval = 1000
        '
        'frmClocks
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Clock2)
        Me.Controls.Add(Me.Clock1)
        Me.Name = "frmClocks"
        Me.Text = "DIgital CLock"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Clock1 As Label
    Friend WithEvents Clock2 As Label
    Friend WithEvents tmrTimer As Timer
End Class
