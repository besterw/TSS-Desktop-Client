Public Class FrmSystemSettings

    Private Sub FrmSystemSettings_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.txtWebAddress.Text = My.Settings.Item("WebServerpath")
        Me.txtAccountUsername.Text = My.Settings.Item("ServerAccount")
        Me.txtPassword.Text = New ENDEC().decryptString(My.Settings.Item("ServerAccountPassword"))
        Me.txtConfirmPassword.Text = New ENDEC().decryptString(My.Settings.Item("ServerAccountPassword"))
        Me.txtInterval.Text = My.Settings.Item("Interval")

        If Me.txtInterval.Text = "600000" Then
            Me.rdo10min.Checked = True
        ElseIf Me.txtInterval.Text = "1800000" Then
            Me.rdo30min.Checked = True
        ElseIf Me.txtInterval.Text = "300000" Then
            Me.rdo5min.Checked = True
        End If

        Me.chkGSMOnly.Checked = My.Settings.GSMModulesOnly

    End Sub

    Private Sub btnUpdateWebAddress_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpdateWebAddress.Click
        Dim ws As New ClockIntegration.ClockIntegeration

        My.Settings.Item("WebServerpath") = Me.txtWebAddress.Text
        My.Settings.Item("ServerAccount") = Me.txtAccountUsername.Text
        My.Settings.Item("ServerAccountPassword") = New ENDEC().encryptString(Me.txtPassword.Text)

        If Me.rdo10min.Checked Then
            Me.txtInterval.Text = "600000"
        ElseIf Me.rdo30min.Checked Then
            Me.txtInterval.Text = "1800000"
        ElseIf Me.rdo5min.Checked Then
            Me.txtInterval.Text = "300000"
        End If


        If IsNumeric(Me.txtInterval.Text) Then
            If CInt(Me.txtInterval.Text) >= 120000 Then
                My.Settings.Item("Interval") = CInt(Me.txtInterval.Text)
            Else
                My.Settings.Item("Interval") = 120000
                Me.txtInterval.Text = 12000
                MsgBox("The interval for the timer must be greater than 2 minutes (120 000 ms)")
            End If
        Else
            My.Settings.Item("Interval") = 120000
            Me.txtInterval.Text = 12000
            MsgBox("The interval for the timer must be greater than 2 minutes (120 000 ms)")
        End If

        If Me.txtPassword.Text <> Me.txtConfirmPassword.Text Then
            MsgBox("Passwords do not match. Update Failed")
        Else
            My.Settings.Save()
            MsgBox("Updates where successful", vbOK, "Success")
            Me.Close()
        End If

        My.Settings.GSMModulesOnly = Me.chkGSMOnly.Checked

    End Sub

    Private Sub rdo30min_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdo30min.CheckedChanged
        Me.txtInterval.Text = "1800000"
    End Sub

    Private Sub rdo10min_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdo10min.CheckedChanged
        Me.txtInterval.Text = "600000"
    End Sub

    Private Sub RadioButton1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdo5min.CheckedChanged
        Me.txtInterval.Text = "300000"
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles chkGSMOnly.CheckedChanged

    End Sub
End Class