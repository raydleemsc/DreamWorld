﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormEmailSetup
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
        Me.components = New System.ComponentModel.Container()
        Me.SMTPSendEmailAccountBox = New System.Windows.Forms.GroupBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.MaxMailSizeTextBox = New System.Windows.Forms.TextBox()
        Me.MaxMailSizeTextBoxLabel = New System.Windows.Forms.Label()
        Me.email_pause_timeTextBox = New System.Windows.Forms.TextBox()
        Me.EmailPauseTimeLabel = New System.Windows.Forms.Label()
        Me.enableEmailToExternalObjectsCheckBox = New System.Windows.Forms.CheckBox()
        Me.MailsToSMTPAddressPerHourTextBox = New System.Windows.Forms.TextBox()
        Me.MailsToSMTPAddressPerHourLabel = New System.Windows.Forms.Label()
        Me.SMTP_MailsPerDayTextBox = New System.Windows.Forms.TextBox()
        Me.MailsPerDayLabel = New System.Windows.Forms.Label()
        Me.MailsToPrimAddressPerHourTextBox = New System.Windows.Forms.TextBox()
        Me.LabelMailsToPrimAddressPerHour = New System.Windows.Forms.Label()
        Me.MailsFromPrimOwnerPerHourLabel = New System.Windows.Forms.Label()
        Me.MailsFromOwnerPerHourTextBox = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.TestButton = New System.Windows.Forms.Button()
        Me.RadioButtonStartTlsWhenAvailable = New System.Windows.Forms.RadioButton()
        Me.RadioButtonNone = New System.Windows.Forms.RadioButton()
        Me.RadioButtonStartTls = New System.Windows.Forms.RadioButton()
        Me.RadioButtonAuto = New System.Windows.Forms.RadioButton()
        Me.RadioButtonSslOnConnect = New System.Windows.Forms.RadioButton()
        Me.VerifyCertificateCheckBox = New System.Windows.Forms.CheckBox()
        Me.EmailEnabledCheckBox = New System.Windows.Forms.CheckBox()
        Me.SmtpPort = New System.Windows.Forms.TextBox()
        Me.EmailPortLabel = New System.Windows.Forms.Label()
        Me.SmtpHost = New System.Windows.Forms.TextBox()
        Me.EmailHostLabel = New System.Windows.Forms.Label()
        Me.EmailPassword = New System.Windows.Forms.TextBox()
        Me.EmailPasswordLabel = New System.Windows.Forms.Label()
        Me.UserNameLabel = New System.Windows.Forms.Label()
        Me.EmailUsername = New System.Windows.Forms.TextBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.SMTPSendEmailAccountBox.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'SMTPSendEmailAccountBox
        '
        Me.SMTPSendEmailAccountBox.Controls.Add(Me.GroupBox1)
        Me.SMTPSendEmailAccountBox.Controls.Add(Me.GroupBox2)
        Me.SMTPSendEmailAccountBox.Controls.Add(Me.EmailEnabledCheckBox)
        Me.SMTPSendEmailAccountBox.Controls.Add(Me.SmtpPort)
        Me.SMTPSendEmailAccountBox.Controls.Add(Me.EmailPortLabel)
        Me.SMTPSendEmailAccountBox.Controls.Add(Me.SmtpHost)
        Me.SMTPSendEmailAccountBox.Controls.Add(Me.EmailHostLabel)
        Me.SMTPSendEmailAccountBox.Controls.Add(Me.EmailPassword)
        Me.SMTPSendEmailAccountBox.Controls.Add(Me.EmailPasswordLabel)
        Me.SMTPSendEmailAccountBox.Controls.Add(Me.UserNameLabel)
        Me.SMTPSendEmailAccountBox.Controls.Add(Me.EmailUsername)
        Me.SMTPSendEmailAccountBox.Location = New System.Drawing.Point(45, 59)
        Me.SMTPSendEmailAccountBox.Margin = New System.Windows.Forms.Padding(4)
        Me.SMTPSendEmailAccountBox.Name = "SMTPSendEmailAccountBox"
        Me.SMTPSendEmailAccountBox.Padding = New System.Windows.Forms.Padding(4)
        Me.SMTPSendEmailAccountBox.Size = New System.Drawing.Size(883, 407)
        Me.SMTPSendEmailAccountBox.TabIndex = 1
        Me.SMTPSendEmailAccountBox.TabStop = False
        Me.SMTPSendEmailAccountBox.Text = "SMTP Send Email Account"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.MaxMailSizeTextBox)
        Me.GroupBox1.Controls.Add(Me.MaxMailSizeTextBoxLabel)
        Me.GroupBox1.Controls.Add(Me.email_pause_timeTextBox)
        Me.GroupBox1.Controls.Add(Me.EmailPauseTimeLabel)
        Me.GroupBox1.Controls.Add(Me.enableEmailToExternalObjectsCheckBox)
        Me.GroupBox1.Controls.Add(Me.MailsToSMTPAddressPerHourTextBox)
        Me.GroupBox1.Controls.Add(Me.MailsToSMTPAddressPerHourLabel)
        Me.GroupBox1.Controls.Add(Me.SMTP_MailsPerDayTextBox)
        Me.GroupBox1.Controls.Add(Me.MailsPerDayLabel)
        Me.GroupBox1.Controls.Add(Me.MailsToPrimAddressPerHourTextBox)
        Me.GroupBox1.Controls.Add(Me.LabelMailsToPrimAddressPerHour)
        Me.GroupBox1.Controls.Add(Me.MailsFromPrimOwnerPerHourLabel)
        Me.GroupBox1.Controls.Add(Me.MailsFromOwnerPerHourTextBox)
        Me.GroupBox1.Location = New System.Drawing.Point(459, 36)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Size = New System.Drawing.Size(412, 354)
        Me.GroupBox1.TabIndex = 9
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Options"
        '
        'MaxMailSizeTextBox
        '
        Me.MaxMailSizeTextBox.Location = New System.Drawing.Point(12, 268)
        Me.MaxMailSizeTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.MaxMailSizeTextBox.Name = "MaxMailSizeTextBox"
        Me.MaxMailSizeTextBox.Size = New System.Drawing.Size(59, 22)
        Me.MaxMailSizeTextBox.TabIndex = 15
        '
        'MaxMailSizeTextBoxLabel
        '
        Me.MaxMailSizeTextBoxLabel.AutoSize = True
        Me.MaxMailSizeTextBoxLabel.Location = New System.Drawing.Point(80, 272)
        Me.MaxMailSizeTextBoxLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.MaxMailSizeTextBoxLabel.Name = "MaxMailSizeTextBoxLabel"
        Me.MaxMailSizeTextBoxLabel.Size = New System.Drawing.Size(93, 17)
        Me.MaxMailSizeTextBoxLabel.TabIndex = 14
        Me.MaxMailSizeTextBoxLabel.Text = "Mail Max Size"
        '
        'email_pause_timeTextBox
        '
        Me.email_pause_timeTextBox.Location = New System.Drawing.Point(12, 235)
        Me.email_pause_timeTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.email_pause_timeTextBox.Name = "email_pause_timeTextBox"
        Me.email_pause_timeTextBox.Size = New System.Drawing.Size(59, 22)
        Me.email_pause_timeTextBox.TabIndex = 13
        '
        'EmailPauseTimeLabel
        '
        Me.EmailPauseTimeLabel.AutoSize = True
        Me.EmailPauseTimeLabel.Location = New System.Drawing.Point(80, 239)
        Me.EmailPauseTimeLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.EmailPauseTimeLabel.Name = "EmailPauseTimeLabel"
        Me.EmailPauseTimeLabel.Size = New System.Drawing.Size(112, 17)
        Me.EmailPauseTimeLabel.TabIndex = 12
        Me.EmailPauseTimeLabel.Text = "Mail Pause Time"
        '
        'enableEmailToExternalObjectsCheckBox
        '
        Me.enableEmailToExternalObjectsCheckBox.AutoSize = True
        Me.enableEmailToExternalObjectsCheckBox.Location = New System.Drawing.Point(12, 35)
        Me.enableEmailToExternalObjectsCheckBox.Margin = New System.Windows.Forms.Padding(4)
        Me.enableEmailToExternalObjectsCheckBox.Name = "enableEmailToExternalObjectsCheckBox"
        Me.enableEmailToExternalObjectsCheckBox.Size = New System.Drawing.Size(193, 21)
        Me.enableEmailToExternalObjectsCheckBox.TabIndex = 10
        Me.enableEmailToExternalObjectsCheckBox.Text = "Email To Objects Enabled"
        Me.enableEmailToExternalObjectsCheckBox.UseVisualStyleBackColor = True
        '
        'MailsToSMTPAddressPerHourTextBox
        '
        Me.MailsToSMTPAddressPerHourTextBox.Location = New System.Drawing.Point(12, 203)
        Me.MailsToSMTPAddressPerHourTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.MailsToSMTPAddressPerHourTextBox.Name = "MailsToSMTPAddressPerHourTextBox"
        Me.MailsToSMTPAddressPerHourTextBox.Size = New System.Drawing.Size(59, 22)
        Me.MailsToSMTPAddressPerHourTextBox.TabIndex = 7
        '
        'MailsToSMTPAddressPerHourLabel
        '
        Me.MailsToSMTPAddressPerHourLabel.AutoSize = True
        Me.MailsToSMTPAddressPerHourLabel.Location = New System.Drawing.Point(80, 207)
        Me.MailsToSMTPAddressPerHourLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.MailsToSMTPAddressPerHourLabel.Name = "MailsToSMTPAddressPerHourLabel"
        Me.MailsToSMTPAddressPerHourLabel.Size = New System.Drawing.Size(220, 17)
        Me.MailsToSMTPAddressPerHourLabel.TabIndex = 6
        Me.MailsToSMTPAddressPerHourLabel.Text = "Mails To SMTP Address Per Hour"
        '
        'SMTP_MailsPerDayTextBox
        '
        Me.SMTP_MailsPerDayTextBox.Location = New System.Drawing.Point(12, 171)
        Me.SMTP_MailsPerDayTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.SMTP_MailsPerDayTextBox.Name = "SMTP_MailsPerDayTextBox"
        Me.SMTP_MailsPerDayTextBox.Size = New System.Drawing.Size(59, 22)
        Me.SMTP_MailsPerDayTextBox.TabIndex = 5
        '
        'MailsPerDayLabel
        '
        Me.MailsPerDayLabel.AutoSize = True
        Me.MailsPerDayLabel.Location = New System.Drawing.Point(80, 174)
        Me.MailsPerDayLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.MailsPerDayLabel.Name = "MailsPerDayLabel"
        Me.MailsPerDayLabel.Size = New System.Drawing.Size(95, 17)
        Me.MailsPerDayLabel.TabIndex = 4
        Me.MailsPerDayLabel.Text = "Mails Per Day"
        '
        'MailsToPrimAddressPerHourTextBox
        '
        Me.MailsToPrimAddressPerHourTextBox.Location = New System.Drawing.Point(12, 139)
        Me.MailsToPrimAddressPerHourTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.MailsToPrimAddressPerHourTextBox.Name = "MailsToPrimAddressPerHourTextBox"
        Me.MailsToPrimAddressPerHourTextBox.Size = New System.Drawing.Size(59, 22)
        Me.MailsToPrimAddressPerHourTextBox.TabIndex = 3
        '
        'LabelMailsToPrimAddressPerHour
        '
        Me.LabelMailsToPrimAddressPerHour.AutoSize = True
        Me.LabelMailsToPrimAddressPerHour.Location = New System.Drawing.Point(80, 142)
        Me.LabelMailsToPrimAddressPerHour.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelMailsToPrimAddressPerHour.Name = "LabelMailsToPrimAddressPerHour"
        Me.LabelMailsToPrimAddressPerHour.Size = New System.Drawing.Size(210, 17)
        Me.LabelMailsToPrimAddressPerHour.TabIndex = 2
        Me.LabelMailsToPrimAddressPerHour.Text = "Mails To Prim Address Per Hour"
        '
        'MailsFromPrimOwnerPerHourLabel
        '
        Me.MailsFromPrimOwnerPerHourLabel.AutoSize = True
        Me.MailsFromPrimOwnerPerHourLabel.Location = New System.Drawing.Point(80, 110)
        Me.MailsFromPrimOwnerPerHourLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.MailsFromPrimOwnerPerHourLabel.Name = "MailsFromPrimOwnerPerHourLabel"
        Me.MailsFromPrimOwnerPerHourLabel.Size = New System.Drawing.Size(182, 17)
        Me.MailsFromPrimOwnerPerHourLabel.TabIndex = 0
        Me.MailsFromPrimOwnerPerHourLabel.Text = "Mails From Owner Per Hour"
        '
        'MailsFromOwnerPerHourTextBox
        '
        Me.MailsFromOwnerPerHourTextBox.Location = New System.Drawing.Point(12, 105)
        Me.MailsFromOwnerPerHourTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.MailsFromOwnerPerHourTextBox.Name = "MailsFromOwnerPerHourTextBox"
        Me.MailsFromOwnerPerHourTextBox.Size = New System.Drawing.Size(59, 22)
        Me.MailsFromOwnerPerHourTextBox.TabIndex = 1
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.TestButton)
        Me.GroupBox2.Controls.Add(Me.RadioButtonStartTlsWhenAvailable)
        Me.GroupBox2.Controls.Add(Me.RadioButtonNone)
        Me.GroupBox2.Controls.Add(Me.RadioButtonStartTls)
        Me.GroupBox2.Controls.Add(Me.RadioButtonAuto)
        Me.GroupBox2.Controls.Add(Me.RadioButtonSslOnConnect)
        Me.GroupBox2.Controls.Add(Me.VerifyCertificateCheckBox)
        Me.GroupBox2.Location = New System.Drawing.Point(25, 207)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Size = New System.Drawing.Size(424, 183)
        Me.GroupBox2.TabIndex = 15
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Security Options"
        '
        'TestButton
        '
        Me.TestButton.Location = New System.Drawing.Point(217, 114)
        Me.TestButton.Margin = New System.Windows.Forms.Padding(4)
        Me.TestButton.Name = "TestButton"
        Me.TestButton.Size = New System.Drawing.Size(135, 28)
        Me.TestButton.TabIndex = 16
        Me.TestButton.Text = "Test"
        Me.TestButton.UseVisualStyleBackColor = True
        '
        'RadioButtonStartTlsWhenAvailable
        '
        Me.RadioButtonStartTlsWhenAvailable.AutoSize = True
        Me.RadioButtonStartTlsWhenAvailable.Location = New System.Drawing.Point(13, 143)
        Me.RadioButtonStartTlsWhenAvailable.Margin = New System.Windows.Forms.Padding(4)
        Me.RadioButtonStartTlsWhenAvailable.Name = "RadioButtonStartTlsWhenAvailable"
        Me.RadioButtonStartTlsWhenAvailable.Size = New System.Drawing.Size(115, 21)
        Me.RadioButtonStartTlsWhenAvailable.TabIndex = 14
        Me.RadioButtonStartTlsWhenAvailable.TabStop = True
        Me.RadioButtonStartTlsWhenAvailable.Text = "RadioButton5"
        Me.RadioButtonStartTlsWhenAvailable.UseVisualStyleBackColor = True
        '
        'RadioButtonNone
        '
        Me.RadioButtonNone.AutoSize = True
        Me.RadioButtonNone.Location = New System.Drawing.Point(8, 30)
        Me.RadioButtonNone.Margin = New System.Windows.Forms.Padding(4)
        Me.RadioButtonNone.Name = "RadioButtonNone"
        Me.RadioButtonNone.Size = New System.Drawing.Size(115, 21)
        Me.RadioButtonNone.TabIndex = 10
        Me.RadioButtonNone.TabStop = True
        Me.RadioButtonNone.Text = "RadioButton1"
        Me.RadioButtonNone.UseVisualStyleBackColor = True
        '
        'RadioButtonStartTls
        '
        Me.RadioButtonStartTls.AutoSize = True
        Me.RadioButtonStartTls.Location = New System.Drawing.Point(13, 114)
        Me.RadioButtonStartTls.Margin = New System.Windows.Forms.Padding(4)
        Me.RadioButtonStartTls.Name = "RadioButtonStartTls"
        Me.RadioButtonStartTls.Size = New System.Drawing.Size(115, 21)
        Me.RadioButtonStartTls.TabIndex = 13
        Me.RadioButtonStartTls.TabStop = True
        Me.RadioButtonStartTls.Text = "RadioButton3"
        Me.RadioButtonStartTls.UseVisualStyleBackColor = True
        '
        'RadioButtonAuto
        '
        Me.RadioButtonAuto.AutoSize = True
        Me.RadioButtonAuto.Location = New System.Drawing.Point(11, 58)
        Me.RadioButtonAuto.Margin = New System.Windows.Forms.Padding(4)
        Me.RadioButtonAuto.Name = "RadioButtonAuto"
        Me.RadioButtonAuto.Size = New System.Drawing.Size(115, 21)
        Me.RadioButtonAuto.TabIndex = 11
        Me.RadioButtonAuto.TabStop = True
        Me.RadioButtonAuto.Text = "RadioButton2"
        Me.RadioButtonAuto.UseVisualStyleBackColor = True
        '
        'RadioButtonSslOnConnect
        '
        Me.RadioButtonSslOnConnect.AutoSize = True
        Me.RadioButtonSslOnConnect.Location = New System.Drawing.Point(11, 86)
        Me.RadioButtonSslOnConnect.Margin = New System.Windows.Forms.Padding(4)
        Me.RadioButtonSslOnConnect.Name = "RadioButtonSslOnConnect"
        Me.RadioButtonSslOnConnect.Size = New System.Drawing.Size(115, 21)
        Me.RadioButtonSslOnConnect.TabIndex = 12
        Me.RadioButtonSslOnConnect.TabStop = True
        Me.RadioButtonSslOnConnect.Text = "RadioButton4"
        Me.RadioButtonSslOnConnect.UseVisualStyleBackColor = True
        '
        'VerifyCertificateCheckBox
        '
        Me.VerifyCertificateCheckBox.AutoSize = True
        Me.VerifyCertificateCheckBox.Location = New System.Drawing.Point(208, 31)
        Me.VerifyCertificateCheckBox.Margin = New System.Windows.Forms.Padding(4)
        Me.VerifyCertificateCheckBox.Name = "VerifyCertificateCheckBox"
        Me.VerifyCertificateCheckBox.Size = New System.Drawing.Size(141, 21)
        Me.VerifyCertificateCheckBox.TabIndex = 8
        Me.VerifyCertificateCheckBox.Text = "Verify Certificate?"
        Me.VerifyCertificateCheckBox.UseVisualStyleBackColor = True
        '
        'EmailEnabledCheckBox
        '
        Me.EmailEnabledCheckBox.AutoSize = True
        Me.EmailEnabledCheckBox.Location = New System.Drawing.Point(25, 36)
        Me.EmailEnabledCheckBox.Margin = New System.Windows.Forms.Padding(4)
        Me.EmailEnabledCheckBox.Name = "EmailEnabledCheckBox"
        Me.EmailEnabledCheckBox.Size = New System.Drawing.Size(120, 21)
        Me.EmailEnabledCheckBox.TabIndex = 9
        Me.EmailEnabledCheckBox.Text = "Email Enabled"
        Me.EmailEnabledCheckBox.UseVisualStyleBackColor = True
        '
        'SmtpPort
        '
        Me.SmtpPort.Location = New System.Drawing.Point(27, 164)
        Me.SmtpPort.Margin = New System.Windows.Forms.Padding(4)
        Me.SmtpPort.Name = "SmtpPort"
        Me.SmtpPort.Size = New System.Drawing.Size(43, 22)
        Me.SmtpPort.TabIndex = 7
        '
        'EmailPortLabel
        '
        Me.EmailPortLabel.AutoSize = True
        Me.EmailPortLabel.Location = New System.Drawing.Point(265, 172)
        Me.EmailPortLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.EmailPortLabel.Name = "EmailPortLabel"
        Me.EmailPortLabel.Size = New System.Drawing.Size(76, 17)
        Me.EmailPortLabel.TabIndex = 6
        Me.EmailPortLabel.Text = "SMTP Port"
        '
        'SmtpHost
        '
        Me.SmtpHost.Location = New System.Drawing.Point(27, 132)
        Me.SmtpHost.Margin = New System.Windows.Forms.Padding(4)
        Me.SmtpHost.Name = "SmtpHost"
        Me.SmtpHost.Size = New System.Drawing.Size(217, 22)
        Me.SmtpHost.TabIndex = 5
        '
        'EmailHostLabel
        '
        Me.EmailHostLabel.AutoSize = True
        Me.EmailHostLabel.Location = New System.Drawing.Point(265, 139)
        Me.EmailHostLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.EmailHostLabel.Name = "EmailHostLabel"
        Me.EmailHostLabel.Size = New System.Drawing.Size(79, 17)
        Me.EmailHostLabel.TabIndex = 4
        Me.EmailHostLabel.Text = "SMTP Host"
        '
        'EmailPassword
        '
        Me.EmailPassword.Location = New System.Drawing.Point(25, 100)
        Me.EmailPassword.Margin = New System.Windows.Forms.Padding(4)
        Me.EmailPassword.Name = "EmailPassword"
        Me.EmailPassword.Size = New System.Drawing.Size(219, 22)
        Me.EmailPassword.TabIndex = 3
        Me.EmailPassword.UseSystemPasswordChar = True
        '
        'EmailPasswordLabel
        '
        Me.EmailPasswordLabel.AutoSize = True
        Me.EmailPasswordLabel.Location = New System.Drawing.Point(263, 106)
        Me.EmailPasswordLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.EmailPasswordLabel.Name = "EmailPasswordLabel"
        Me.EmailPasswordLabel.Size = New System.Drawing.Size(111, 17)
        Me.EmailPasswordLabel.TabIndex = 2
        Me.EmailPasswordLabel.Text = "SMTP Password"
        '
        'UserNameLabel
        '
        Me.UserNameLabel.AutoSize = True
        Me.UserNameLabel.Location = New System.Drawing.Point(265, 76)
        Me.UserNameLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.UserNameLabel.Name = "UserNameLabel"
        Me.UserNameLabel.Size = New System.Drawing.Size(79, 17)
        Me.UserNameLabel.TabIndex = 0
        Me.UserNameLabel.Text = "User Name"
        '
        'EmailUsername
        '
        Me.EmailUsername.Location = New System.Drawing.Point(25, 70)
        Me.EmailUsername.Margin = New System.Windows.Forms.Padding(4)
        Me.EmailUsername.Name = "EmailUsername"
        Me.EmailUsername.Size = New System.Drawing.Size(219, 22)
        Me.EmailUsername.TabIndex = 1
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.HelpToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(949, 28)
        Me.MenuStrip1.TabIndex = 2
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.Image = Global.Outworldz.My.Resources.Resources.about
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(75, 24)
        Me.HelpToolStripMenuItem.Text = "Help"
        '
        'FormEmailSetup
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(949, 481)
        Me.Controls.Add(Me.SMTPSendEmailAccountBox)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "FormEmailSetup"
        Me.Text = "FormEmailSetup"
        Me.SMTPSendEmailAccountBox.ResumeLayout(False)
        Me.SMTPSendEmailAccountBox.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents SMTPSendEmailAccountBox As GroupBox
    Friend WithEvents SmtpPort As TextBox
    Friend WithEvents EmailPortLabel As Label
    Friend WithEvents SmtpHost As TextBox
    Friend WithEvents EmailHostLabel As Label
    Friend WithEvents EmailPassword As TextBox
    Friend WithEvents EmailPasswordLabel As Label
    Friend WithEvents UserNameLabel As Label
    Friend WithEvents EmailUsername As TextBox
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents HelpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents VerifyCertificateCheckBox As CheckBox
    Friend WithEvents MailsToSMTPAddressPerHourTextBox As TextBox
    Friend WithEvents MailsToSMTPAddressPerHourLabel As Label
    Friend WithEvents SMTP_MailsPerDayTextBox As TextBox
    Friend WithEvents MailsPerDayLabel As Label
    Friend WithEvents MailsToPrimAddressPerHourTextBox As TextBox
    Friend WithEvents LabelMailsToPrimAddressPerHour As Label
    Friend WithEvents MailsFromPrimOwnerPerHourLabel As Label
    Friend WithEvents MailsFromOwnerPerHourTextBox As TextBox
    Friend WithEvents EmailEnabledCheckBox As CheckBox
    Friend WithEvents enableEmailToExternalObjectsCheckBox As CheckBox
    Friend WithEvents MaxMailSizeTextBox As TextBox
    Friend WithEvents MaxMailSizeTextBoxLabel As Label
    Friend WithEvents email_pause_timeTextBox As TextBox
    Friend WithEvents EmailPauseTimeLabel As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents RadioButtonStartTlsWhenAvailable As RadioButton
    Friend WithEvents RadioButtonNone As RadioButton
    Friend WithEvents RadioButtonStartTls As RadioButton
    Friend WithEvents RadioButtonAuto As RadioButton
    Friend WithEvents RadioButtonSslOnConnect As RadioButton
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents TestButton As Button
End Class
