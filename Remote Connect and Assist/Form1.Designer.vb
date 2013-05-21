<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RemoteControl
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tbHostName = New System.Windows.Forms.TextBox()
        Me.btnRemoteConnect = New System.Windows.Forms.Button()
        Me.cbKill = New System.Windows.Forms.CheckBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(387, 24)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Hostname or asset that you are connecting to"
        '
        'tbHostName
        '
        Me.tbHostName.Location = New System.Drawing.Point(105, 57)
        Me.tbHostName.Name = "tbHostName"
        Me.tbHostName.Size = New System.Drawing.Size(155, 20)
        Me.tbHostName.TabIndex = 1
        '
        'btnRemoteConnect
        '
        Me.btnRemoteConnect.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRemoteConnect.Location = New System.Drawing.Point(89, 106)
        Me.btnRemoteConnect.Name = "btnRemoteConnect"
        Me.btnRemoteConnect.Size = New System.Drawing.Size(195, 32)
        Me.btnRemoteConnect.TabIndex = 3
        Me.btnRemoteConnect.Text = "Connect"
        Me.btnRemoteConnect.UseVisualStyleBackColor = True
        '
        'cbKill
        '
        Me.cbKill.AutoSize = True
        Me.cbKill.Checked = True
        Me.cbKill.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cbKill.Location = New System.Drawing.Point(89, 83)
        Me.cbKill.Name = "cbKill"
        Me.cbKill.Size = New System.Drawing.Size(198, 17)
        Me.cbKill.TabIndex = 2
        Me.cbKill.Text = "Kill running remote connect windows"
        Me.cbKill.UseVisualStyleBackColor = True
        '
        'RemoteControl
        '
        Me.AcceptButton = Me.btnRemoteConnect
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(401, 144)
        Me.Controls.Add(Me.cbKill)
        Me.Controls.Add(Me.btnRemoteConnect)
        Me.Controls.Add(Me.tbHostName)
        Me.Controls.Add(Me.Label1)
        Me.Name = "RemoteControl"
        Me.Text = "Remote Control and Assist"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents tbHostName As System.Windows.Forms.TextBox
    Friend WithEvents btnRemoteConnect As System.Windows.Forms.Button
    Friend WithEvents cbKill As System.Windows.Forms.CheckBox

End Class
