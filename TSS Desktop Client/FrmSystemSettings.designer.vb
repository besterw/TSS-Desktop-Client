<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmSystemSettings
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.rdo5min = New System.Windows.Forms.RadioButton()
        Me.rdo10min = New System.Windows.Forms.RadioButton()
        Me.rdo30min = New System.Windows.Forms.RadioButton()
        Me.txtInterval = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtConfirmPassword = New System.Windows.Forms.TextBox()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtAccountUsername = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnUpdateWebAddress = New System.Windows.Forms.Button()
        Me.txtWebAddress = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.chkGSMOnly = New System.Windows.Forms.CheckBox()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.chkGSMOnly)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.rdo5min)
        Me.GroupBox1.Controls.Add(Me.rdo10min)
        Me.GroupBox1.Controls.Add(Me.rdo30min)
        Me.GroupBox1.Controls.Add(Me.txtInterval)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txtConfirmPassword)
        Me.GroupBox1.Controls.Add(Me.txtPassword)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtAccountUsername)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.btnUpdateWebAddress)
        Me.GroupBox1.Controls.Add(Me.txtWebAddress)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(585, 169)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Web Server"
        '
        'rdo5min
        '
        Me.rdo5min.AutoSize = True
        Me.rdo5min.Location = New System.Drawing.Point(529, 81)
        Me.rdo5min.Name = "rdo5min"
        Me.rdo5min.Size = New System.Drawing.Size(50, 17)
        Me.rdo5min.TabIndex = 13
        Me.rdo5min.TabStop = True
        Me.rdo5min.Text = "5 min"
        Me.rdo5min.UseVisualStyleBackColor = True
        '
        'rdo10min
        '
        Me.rdo10min.AutoSize = True
        Me.rdo10min.Location = New System.Drawing.Point(467, 81)
        Me.rdo10min.Name = "rdo10min"
        Me.rdo10min.Size = New System.Drawing.Size(56, 17)
        Me.rdo10min.TabIndex = 12
        Me.rdo10min.TabStop = True
        Me.rdo10min.Text = "10 min"
        Me.rdo10min.UseVisualStyleBackColor = True
        '
        'rdo30min
        '
        Me.rdo30min.AutoSize = True
        Me.rdo30min.Checked = True
        Me.rdo30min.Location = New System.Drawing.Point(405, 81)
        Me.rdo30min.Name = "rdo30min"
        Me.rdo30min.Size = New System.Drawing.Size(56, 17)
        Me.rdo30min.TabIndex = 11
        Me.rdo30min.TabStop = True
        Me.rdo30min.Text = "30 min"
        Me.rdo30min.UseVisualStyleBackColor = True
        '
        'txtInterval
        '
        Me.txtInterval.Enabled = False
        Me.txtInterval.Location = New System.Drawing.Point(481, 106)
        Me.txtInterval.Name = "txtInterval"
        Me.txtInterval.Size = New System.Drawing.Size(86, 20)
        Me.txtInterval.TabIndex = 10
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(402, 109)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(71, 13)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Timer Interval"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(16, 109)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(91, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Confirm Password"
        '
        'txtConfirmPassword
        '
        Me.txtConfirmPassword.Location = New System.Drawing.Point(113, 106)
        Me.txtConfirmPassword.Name = "txtConfirmPassword"
        Me.txtConfirmPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtConfirmPassword.Size = New System.Drawing.Size(174, 20)
        Me.txtConfirmPassword.TabIndex = 7
        '
        'txtPassword
        '
        Me.txtPassword.Location = New System.Drawing.Point(113, 80)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPassword.Size = New System.Drawing.Size(174, 20)
        Me.txtPassword.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(16, 83)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(53, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Password"
        '
        'txtAccountUsername
        '
        Me.txtAccountUsername.Location = New System.Drawing.Point(113, 53)
        Me.txtAccountUsername.Name = "txtAccountUsername"
        Me.txtAccountUsername.Size = New System.Drawing.Size(174, 20)
        Me.txtAccountUsername.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(16, 57)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(98, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Account Username"
        '
        'btnUpdateWebAddress
        '
        Me.btnUpdateWebAddress.Location = New System.Drawing.Point(481, 135)
        Me.btnUpdateWebAddress.Name = "btnUpdateWebAddress"
        Me.btnUpdateWebAddress.Size = New System.Drawing.Size(98, 28)
        Me.btnUpdateWebAddress.TabIndex = 2
        Me.btnUpdateWebAddress.Text = "Update"
        Me.btnUpdateWebAddress.UseVisualStyleBackColor = True
        '
        'txtWebAddress
        '
        Me.txtWebAddress.Location = New System.Drawing.Point(113, 27)
        Me.txtWebAddress.Name = "txtWebAddress"
        Me.txtWebAddress.Size = New System.Drawing.Size(466, 20)
        Me.txtWebAddress.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(16, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(71, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Web Address"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(16, 135)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(98, 13)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "GSM Modules Only"
        '
        'chkGSMOnly
        '
        Me.chkGSMOnly.AutoSize = True
        Me.chkGSMOnly.Location = New System.Drawing.Point(120, 135)
        Me.chkGSMOnly.Name = "chkGSMOnly"
        Me.chkGSMOnly.Size = New System.Drawing.Size(15, 14)
        Me.chkGSMOnly.TabIndex = 15
        Me.chkGSMOnly.UseVisualStyleBackColor = True
        '
        'FrmSystemSettings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(609, 337)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "FrmSystemSettings"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "System Settings"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtWebAddress As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnUpdateWebAddress As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtConfirmPassword As System.Windows.Forms.TextBox
    Friend WithEvents txtPassword As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtAccountUsername As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtInterval As System.Windows.Forms.TextBox
    Friend WithEvents rdo5min As System.Windows.Forms.RadioButton
    Friend WithEvents rdo10min As System.Windows.Forms.RadioButton
    Friend WithEvents rdo30min As System.Windows.Forms.RadioButton
    Friend WithEvents chkGSMOnly As System.Windows.Forms.CheckBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
End Class
