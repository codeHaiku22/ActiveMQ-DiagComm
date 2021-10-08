<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.cmdSend = New System.Windows.Forms.Button()
        Me.txtOutput = New System.Windows.Forms.TextBox()
        Me.cmdReceive = New System.Windows.Forms.Button()
        Me.nudSendQty = New System.Windows.Forms.NumericUpDown()
        Me.cmdClearOutput = New System.Windows.Forms.Button()
        Me.txtSendDestination = New System.Windows.Forms.TextBox()
        Me.grpbxSend = New System.Windows.Forms.GroupBox()
        Me.cmdSendReset = New System.Windows.Forms.Button()
        Me.lblSendSeconds = New System.Windows.Forms.Label()
        Me.lblSendThrottle = New System.Windows.Forms.Label()
        Me.nudSendThrottle = New System.Windows.Forms.NumericUpDown()
        Me.txtSendPort = New System.Windows.Forms.TextBox()
        Me.lblSendPort = New System.Windows.Forms.Label()
        Me.lblSendQty = New System.Windows.Forms.Label()
        Me.lblSendQueue = New System.Windows.Forms.Label()
        Me.lblSendServer = New System.Windows.Forms.Label()
        Me.txtSendServer = New System.Windows.Forms.TextBox()
        Me.grpbxReceive = New System.Windows.Forms.GroupBox()
        Me.cmdReceiveReset = New System.Windows.Forms.Button()
        Me.lblReceiveMinutes = New System.Windows.Forms.Label()
        Me.nudReceiveDuration = New System.Windows.Forms.NumericUpDown()
        Me.lblReceiveDuration = New System.Windows.Forms.Label()
        Me.chkReceiveAcknowledge = New System.Windows.Forms.CheckBox()
        Me.txtReceivePort = New System.Windows.Forms.TextBox()
        Me.lblReceivePort = New System.Windows.Forms.Label()
        Me.lblReceiveQueue = New System.Windows.Forms.Label()
        Me.lblReceiveServer = New System.Windows.Forms.Label()
        Me.txtReceiveServer = New System.Windows.Forms.TextBox()
        Me.txtReceiveDestination = New System.Windows.Forms.TextBox()
        Me.cmdCopyRight = New System.Windows.Forms.Button()
        Me.lblSend = New System.Windows.Forms.Label()
        Me.lblReceive = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.cmdClearMessageFields = New System.Windows.Forms.Button()
        Me.txtProperties = New System.Windows.Forms.TextBox()
        Me.cmbPriority = New System.Windows.Forms.ComboBox()
        Me.lblProperties = New System.Windows.Forms.Label()
        Me.lblDetails = New System.Windows.Forms.Label()
        Me.chkPersistence = New System.Windows.Forms.CheckBox()
        Me.lblPersistence = New System.Windows.Forms.Label()
        Me.txtType = New System.Windows.Forms.TextBox()
        Me.lblType = New System.Windows.Forms.Label()
        Me.txtReplyTo = New System.Windows.Forms.TextBox()
        Me.lblReplyTo = New System.Windows.Forms.Label()
        Me.lblPriority = New System.Windows.Forms.Label()
        Me.dtpExpirationTime = New System.Windows.Forms.DateTimePicker()
        Me.dtpExpirationDate = New System.Windows.Forms.DateTimePicker()
        Me.lblExpiration = New System.Windows.Forms.Label()
        Me.lblCorrelationId = New System.Windows.Forms.Label()
        Me.txtCorrelationId = New System.Windows.Forms.TextBox()
        Me.txtMessageDetails = New System.Windows.Forms.TextBox()
        Me.cmdCopyLeft = New System.Windows.Forms.Button()
        CType(Me.nudSendQty, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpbxSend.SuspendLayout()
        CType(Me.nudSendThrottle, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpbxReceive.SuspendLayout()
        CType(Me.nudReceiveDuration, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'cmdSend
        '
        Me.cmdSend.Location = New System.Drawing.Point(356, 66)
        Me.cmdSend.Name = "cmdSend"
        Me.cmdSend.Size = New System.Drawing.Size(108, 25)
        Me.cmdSend.TabIndex = 12
        Me.cmdSend.Text = "&Send"
        Me.cmdSend.UseVisualStyleBackColor = True
        '
        'txtOutput
        '
        Me.txtOutput.Location = New System.Drawing.Point(13, 631)
        Me.txtOutput.Multiline = True
        Me.txtOutput.Name = "txtOutput"
        Me.txtOutput.ReadOnly = True
        Me.txtOutput.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtOutput.Size = New System.Drawing.Size(983, 243)
        Me.txtOutput.TabIndex = 7
        '
        'cmdReceive
        '
        Me.cmdReceive.Location = New System.Drawing.Point(356, 66)
        Me.cmdReceive.Name = "cmdReceive"
        Me.cmdReceive.Size = New System.Drawing.Size(108, 25)
        Me.cmdReceive.TabIndex = 11
        Me.cmdReceive.Text = "&Receive"
        Me.cmdReceive.UseVisualStyleBackColor = True
        '
        'nudSendQty
        '
        Me.nudSendQty.Location = New System.Drawing.Point(356, 41)
        Me.nudSendQty.Name = "nudSendQty"
        Me.nudSendQty.Size = New System.Drawing.Size(108, 20)
        Me.nudSendQty.TabIndex = 7
        Me.nudSendQty.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'cmdClearOutput
        '
        Me.cmdClearOutput.Location = New System.Drawing.Point(921, 880)
        Me.cmdClearOutput.Name = "cmdClearOutput"
        Me.cmdClearOutput.Size = New System.Drawing.Size(75, 23)
        Me.cmdClearOutput.TabIndex = 8
        Me.cmdClearOutput.Text = "C&lear"
        Me.cmdClearOutput.UseVisualStyleBackColor = True
        '
        'txtSendDestination
        '
        Me.txtSendDestination.Location = New System.Drawing.Point(75, 40)
        Me.txtSendDestination.Name = "txtSendDestination"
        Me.txtSendDestination.Size = New System.Drawing.Size(220, 20)
        Me.txtSendDestination.TabIndex = 5
        '
        'grpbxSend
        '
        Me.grpbxSend.Controls.Add(Me.cmdSendReset)
        Me.grpbxSend.Controls.Add(Me.lblSendSeconds)
        Me.grpbxSend.Controls.Add(Me.lblSendThrottle)
        Me.grpbxSend.Controls.Add(Me.nudSendThrottle)
        Me.grpbxSend.Controls.Add(Me.txtSendPort)
        Me.grpbxSend.Controls.Add(Me.lblSendPort)
        Me.grpbxSend.Controls.Add(Me.lblSendQty)
        Me.grpbxSend.Controls.Add(Me.lblSendQueue)
        Me.grpbxSend.Controls.Add(Me.lblSendServer)
        Me.grpbxSend.Controls.Add(Me.txtSendServer)
        Me.grpbxSend.Controls.Add(Me.txtSendDestination)
        Me.grpbxSend.Controls.Add(Me.nudSendQty)
        Me.grpbxSend.Controls.Add(Me.cmdSend)
        Me.grpbxSend.Location = New System.Drawing.Point(13, 515)
        Me.grpbxSend.Name = "grpbxSend"
        Me.grpbxSend.Size = New System.Drawing.Size(470, 100)
        Me.grpbxSend.TabIndex = 3
        Me.grpbxSend.TabStop = False
        '
        'cmdSendReset
        '
        Me.cmdSendReset.Location = New System.Drawing.Point(307, 66)
        Me.cmdSendReset.Name = "cmdSendReset"
        Me.cmdSendReset.Size = New System.Drawing.Size(43, 25)
        Me.cmdSendReset.TabIndex = 11
        Me.cmdSendReset.Text = "Reset"
        Me.cmdSendReset.UseVisualStyleBackColor = True
        '
        'lblSendSeconds
        '
        Me.lblSendSeconds.AutoSize = True
        Me.lblSendSeconds.Location = New System.Drawing.Point(189, 68)
        Me.lblSendSeconds.Name = "lblSendSeconds"
        Me.lblSendSeconds.Size = New System.Drawing.Size(47, 13)
        Me.lblSendSeconds.TabIndex = 10
        Me.lblSendSeconds.Text = "seconds"
        '
        'lblSendThrottle
        '
        Me.lblSendThrottle.AutoSize = True
        Me.lblSendThrottle.Location = New System.Drawing.Point(22, 68)
        Me.lblSendThrottle.Name = "lblSendThrottle"
        Me.lblSendThrottle.Size = New System.Drawing.Size(46, 13)
        Me.lblSendThrottle.TabIndex = 8
        Me.lblSendThrottle.Text = "Throttle:"
        '
        'nudSendThrottle
        '
        Me.nudSendThrottle.Location = New System.Drawing.Point(75, 66)
        Me.nudSendThrottle.Maximum = New Decimal(New Integer() {60, 0, 0, 0})
        Me.nudSendThrottle.Name = "nudSendThrottle"
        Me.nudSendThrottle.Size = New System.Drawing.Size(108, 20)
        Me.nudSendThrottle.TabIndex = 9
        Me.nudSendThrottle.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtSendPort
        '
        Me.txtSendPort.Location = New System.Drawing.Point(356, 13)
        Me.txtSendPort.Name = "txtSendPort"
        Me.txtSendPort.Size = New System.Drawing.Size(108, 20)
        Me.txtSendPort.TabIndex = 3
        '
        'lblSendPort
        '
        Me.lblSendPort.AutoSize = True
        Me.lblSendPort.Location = New System.Drawing.Point(321, 16)
        Me.lblSendPort.Name = "lblSendPort"
        Me.lblSendPort.Size = New System.Drawing.Size(29, 13)
        Me.lblSendPort.TabIndex = 2
        Me.lblSendPort.Text = "Port:"
        '
        'lblSendQty
        '
        Me.lblSendQty.AutoSize = True
        Me.lblSendQty.Location = New System.Drawing.Point(304, 43)
        Me.lblSendQty.Name = "lblSendQty"
        Me.lblSendQty.Size = New System.Drawing.Size(49, 13)
        Me.lblSendQty.TabIndex = 6
        Me.lblSendQty.Text = "Quantity:"
        '
        'lblSendQueue
        '
        Me.lblSendQueue.AutoSize = True
        Me.lblSendQueue.Location = New System.Drawing.Point(6, 43)
        Me.lblSendQueue.Name = "lblSendQueue"
        Me.lblSendQueue.Size = New System.Drawing.Size(63, 13)
        Me.lblSendQueue.TabIndex = 4
        Me.lblSendQueue.Text = "Destination:"
        '
        'lblSendServer
        '
        Me.lblSendServer.AutoSize = True
        Me.lblSendServer.Location = New System.Drawing.Point(13, 17)
        Me.lblSendServer.Name = "lblSendServer"
        Me.lblSendServer.Size = New System.Drawing.Size(56, 13)
        Me.lblSendServer.TabIndex = 0
        Me.lblSendServer.Text = "Server/IP:"
        '
        'txtSendServer
        '
        Me.txtSendServer.Location = New System.Drawing.Point(75, 13)
        Me.txtSendServer.Name = "txtSendServer"
        Me.txtSendServer.Size = New System.Drawing.Size(220, 20)
        Me.txtSendServer.TabIndex = 1
        '
        'grpbxReceive
        '
        Me.grpbxReceive.Controls.Add(Me.cmdReceiveReset)
        Me.grpbxReceive.Controls.Add(Me.lblReceiveMinutes)
        Me.grpbxReceive.Controls.Add(Me.nudReceiveDuration)
        Me.grpbxReceive.Controls.Add(Me.lblReceiveDuration)
        Me.grpbxReceive.Controls.Add(Me.chkReceiveAcknowledge)
        Me.grpbxReceive.Controls.Add(Me.txtReceivePort)
        Me.grpbxReceive.Controls.Add(Me.lblReceivePort)
        Me.grpbxReceive.Controls.Add(Me.lblReceiveQueue)
        Me.grpbxReceive.Controls.Add(Me.lblReceiveServer)
        Me.grpbxReceive.Controls.Add(Me.txtReceiveServer)
        Me.grpbxReceive.Controls.Add(Me.cmdReceive)
        Me.grpbxReceive.Controls.Add(Me.txtReceiveDestination)
        Me.grpbxReceive.Location = New System.Drawing.Point(525, 515)
        Me.grpbxReceive.Name = "grpbxReceive"
        Me.grpbxReceive.Size = New System.Drawing.Size(470, 100)
        Me.grpbxReceive.TabIndex = 6
        Me.grpbxReceive.TabStop = False
        '
        'cmdReceiveReset
        '
        Me.cmdReceiveReset.Location = New System.Drawing.Point(307, 66)
        Me.cmdReceiveReset.Name = "cmdReceiveReset"
        Me.cmdReceiveReset.Size = New System.Drawing.Size(43, 25)
        Me.cmdReceiveReset.TabIndex = 10
        Me.cmdReceiveReset.Text = "Reset"
        Me.cmdReceiveReset.UseVisualStyleBackColor = True
        '
        'lblReceiveMinutes
        '
        Me.lblReceiveMinutes.AutoSize = True
        Me.lblReceiveMinutes.Location = New System.Drawing.Point(189, 68)
        Me.lblReceiveMinutes.Name = "lblReceiveMinutes"
        Me.lblReceiveMinutes.Size = New System.Drawing.Size(43, 13)
        Me.lblReceiveMinutes.TabIndex = 9
        Me.lblReceiveMinutes.Text = "minutes"
        '
        'nudReceiveDuration
        '
        Me.nudReceiveDuration.Location = New System.Drawing.Point(75, 67)
        Me.nudReceiveDuration.Maximum = New Decimal(New Integer() {60, 0, 0, 0})
        Me.nudReceiveDuration.Name = "nudReceiveDuration"
        Me.nudReceiveDuration.Size = New System.Drawing.Size(108, 20)
        Me.nudReceiveDuration.TabIndex = 8
        Me.nudReceiveDuration.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblReceiveDuration
        '
        Me.lblReceiveDuration.AutoSize = True
        Me.lblReceiveDuration.Location = New System.Drawing.Point(19, 68)
        Me.lblReceiveDuration.Name = "lblReceiveDuration"
        Me.lblReceiveDuration.Size = New System.Drawing.Size(50, 13)
        Me.lblReceiveDuration.TabIndex = 7
        Me.lblReceiveDuration.Text = "Duration:"
        '
        'chkReceiveAcknowledge
        '
        Me.chkReceiveAcknowledge.AutoSize = True
        Me.chkReceiveAcknowledge.Location = New System.Drawing.Point(324, 42)
        Me.chkReceiveAcknowledge.Name = "chkReceiveAcknowledge"
        Me.chkReceiveAcknowledge.Size = New System.Drawing.Size(142, 17)
        Me.chkReceiveAcknowledge.TabIndex = 6
        Me.chkReceiveAcknowledge.Text = "Acknowledge Messsage"
        Me.chkReceiveAcknowledge.UseVisualStyleBackColor = True
        '
        'txtReceivePort
        '
        Me.txtReceivePort.Location = New System.Drawing.Point(356, 14)
        Me.txtReceivePort.Name = "txtReceivePort"
        Me.txtReceivePort.Size = New System.Drawing.Size(108, 20)
        Me.txtReceivePort.TabIndex = 3
        '
        'lblReceivePort
        '
        Me.lblReceivePort.AutoSize = True
        Me.lblReceivePort.Location = New System.Drawing.Point(321, 17)
        Me.lblReceivePort.Name = "lblReceivePort"
        Me.lblReceivePort.Size = New System.Drawing.Size(29, 13)
        Me.lblReceivePort.TabIndex = 2
        Me.lblReceivePort.Text = "Port:"
        '
        'lblReceiveQueue
        '
        Me.lblReceiveQueue.AutoSize = True
        Me.lblReceiveQueue.Location = New System.Drawing.Point(25, 43)
        Me.lblReceiveQueue.Name = "lblReceiveQueue"
        Me.lblReceiveQueue.Size = New System.Drawing.Size(44, 13)
        Me.lblReceiveQueue.TabIndex = 4
        Me.lblReceiveQueue.Text = "Source:"
        '
        'lblReceiveServer
        '
        Me.lblReceiveServer.AutoSize = True
        Me.lblReceiveServer.Location = New System.Drawing.Point(13, 16)
        Me.lblReceiveServer.Name = "lblReceiveServer"
        Me.lblReceiveServer.Size = New System.Drawing.Size(56, 13)
        Me.lblReceiveServer.TabIndex = 0
        Me.lblReceiveServer.Text = "Server/IP:"
        '
        'txtReceiveServer
        '
        Me.txtReceiveServer.Location = New System.Drawing.Point(75, 14)
        Me.txtReceiveServer.Name = "txtReceiveServer"
        Me.txtReceiveServer.Size = New System.Drawing.Size(220, 20)
        Me.txtReceiveServer.TabIndex = 1
        '
        'txtReceiveDestination
        '
        Me.txtReceiveDestination.Location = New System.Drawing.Point(75, 41)
        Me.txtReceiveDestination.Name = "txtReceiveDestination"
        Me.txtReceiveDestination.Size = New System.Drawing.Size(220, 20)
        Me.txtReceiveDestination.TabIndex = 5
        '
        'cmdCopyRight
        '
        Me.cmdCopyRight.Location = New System.Drawing.Point(493, 532)
        Me.cmdCopyRight.Name = "cmdCopyRight"
        Me.cmdCopyRight.Size = New System.Drawing.Size(21, 30)
        Me.cmdCopyRight.TabIndex = 4
        Me.cmdCopyRight.Text = ">"
        Me.cmdCopyRight.UseVisualStyleBackColor = True
        '
        'lblSend
        '
        Me.lblSend.AutoSize = True
        Me.lblSend.Location = New System.Drawing.Point(19, 504)
        Me.lblSend.Name = "lblSend"
        Me.lblSend.Size = New System.Drawing.Size(32, 13)
        Me.lblSend.TabIndex = 3
        Me.lblSend.Text = "Send"
        '
        'lblReceive
        '
        Me.lblReceive.AutoSize = True
        Me.lblReceive.Location = New System.Drawing.Point(531, 504)
        Me.lblReceive.Name = "lblReceive"
        Me.lblReceive.Size = New System.Drawing.Size(47, 13)
        Me.lblReceive.TabIndex = 6
        Me.lblReceive.Text = "Receive"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.cmdClearMessageFields)
        Me.GroupBox3.Controls.Add(Me.txtProperties)
        Me.GroupBox3.Controls.Add(Me.cmbPriority)
        Me.GroupBox3.Controls.Add(Me.lblProperties)
        Me.GroupBox3.Controls.Add(Me.lblDetails)
        Me.GroupBox3.Controls.Add(Me.chkPersistence)
        Me.GroupBox3.Controls.Add(Me.lblPersistence)
        Me.GroupBox3.Controls.Add(Me.txtType)
        Me.GroupBox3.Controls.Add(Me.lblType)
        Me.GroupBox3.Controls.Add(Me.txtReplyTo)
        Me.GroupBox3.Controls.Add(Me.lblReplyTo)
        Me.GroupBox3.Controls.Add(Me.lblPriority)
        Me.GroupBox3.Controls.Add(Me.dtpExpirationTime)
        Me.GroupBox3.Controls.Add(Me.dtpExpirationDate)
        Me.GroupBox3.Controls.Add(Me.lblExpiration)
        Me.GroupBox3.Controls.Add(Me.lblCorrelationId)
        Me.GroupBox3.Controls.Add(Me.txtCorrelationId)
        Me.GroupBox3.Controls.Add(Me.txtMessageDetails)
        Me.GroupBox3.Location = New System.Drawing.Point(13, 12)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(982, 480)
        Me.GroupBox3.TabIndex = 0
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Message"
        '
        'cmdClearMessageFields
        '
        Me.cmdClearMessageFields.Location = New System.Drawing.Point(901, 451)
        Me.cmdClearMessageFields.Name = "cmdClearMessageFields"
        Me.cmdClearMessageFields.Size = New System.Drawing.Size(75, 23)
        Me.cmdClearMessageFields.TabIndex = 17
        Me.cmdClearMessageFields.Text = "&Clear"
        Me.cmdClearMessageFields.UseVisualStyleBackColor = True
        '
        'txtProperties
        '
        Me.txtProperties.Location = New System.Drawing.Point(395, 19)
        Me.txtProperties.Multiline = True
        Me.txtProperties.Name = "txtProperties"
        Me.txtProperties.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtProperties.Size = New System.Drawing.Size(571, 130)
        Me.txtProperties.TabIndex = 14
        '
        'cmbPriority
        '
        Me.cmbPriority.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbPriority.FormattingEnabled = True
        Me.cmbPriority.Location = New System.Drawing.Point(177, 75)
        Me.cmbPriority.Name = "cmbPriority"
        Me.cmbPriority.Size = New System.Drawing.Size(136, 21)
        Me.cmbPriority.TabIndex = 8
        '
        'lblProperties
        '
        Me.lblProperties.AutoSize = True
        Me.lblProperties.Location = New System.Drawing.Point(333, 22)
        Me.lblProperties.Name = "lblProperties"
        Me.lblProperties.Size = New System.Drawing.Size(57, 13)
        Me.lblProperties.TabIndex = 13
        Me.lblProperties.Text = "Properties:"
        '
        'lblDetails
        '
        Me.lblDetails.AutoSize = True
        Me.lblDetails.Location = New System.Drawing.Point(13, 162)
        Me.lblDetails.Name = "lblDetails"
        Me.lblDetails.Size = New System.Drawing.Size(42, 13)
        Me.lblDetails.TabIndex = 15
        Me.lblDetails.Text = "Details:"
        '
        'chkPersistence
        '
        Me.chkPersistence.AutoSize = True
        Me.chkPersistence.Location = New System.Drawing.Point(93, 78)
        Me.chkPersistence.Name = "chkPersistence"
        Me.chkPersistence.Size = New System.Drawing.Size(15, 14)
        Me.chkPersistence.TabIndex = 6
        Me.chkPersistence.UseVisualStyleBackColor = True
        '
        'lblPersistence
        '
        Me.lblPersistence.AutoSize = True
        Me.lblPersistence.Location = New System.Drawing.Point(22, 78)
        Me.lblPersistence.Name = "lblPersistence"
        Me.lblPersistence.Size = New System.Drawing.Size(65, 13)
        Me.lblPersistence.TabIndex = 5
        Me.lblPersistence.Text = "Persistence:"
        '
        'txtType
        '
        Me.txtType.Location = New System.Drawing.Point(93, 129)
        Me.txtType.Name = "txtType"
        Me.txtType.Size = New System.Drawing.Size(220, 20)
        Me.txtType.TabIndex = 12
        '
        'lblType
        '
        Me.lblType.AutoSize = True
        Me.lblType.Location = New System.Drawing.Point(50, 134)
        Me.lblType.Name = "lblType"
        Me.lblType.Size = New System.Drawing.Size(34, 13)
        Me.lblType.TabIndex = 11
        Me.lblType.Text = "Type:"
        '
        'txtReplyTo
        '
        Me.txtReplyTo.Location = New System.Drawing.Point(93, 103)
        Me.txtReplyTo.Name = "txtReplyTo"
        Me.txtReplyTo.Size = New System.Drawing.Size(220, 20)
        Me.txtReplyTo.TabIndex = 10
        '
        'lblReplyTo
        '
        Me.lblReplyTo.AutoSize = True
        Me.lblReplyTo.Location = New System.Drawing.Point(31, 106)
        Me.lblReplyTo.Name = "lblReplyTo"
        Me.lblReplyTo.Size = New System.Drawing.Size(53, 13)
        Me.lblReplyTo.TabIndex = 9
        Me.lblReplyTo.Text = "Reply To:"
        '
        'lblPriority
        '
        Me.lblPriority.AutoSize = True
        Me.lblPriority.Location = New System.Drawing.Point(130, 78)
        Me.lblPriority.Name = "lblPriority"
        Me.lblPriority.Size = New System.Drawing.Size(41, 13)
        Me.lblPriority.TabIndex = 7
        Me.lblPriority.Text = "Priority:"
        '
        'dtpExpirationTime
        '
        Me.dtpExpirationTime.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.dtpExpirationTime.Location = New System.Drawing.Point(205, 45)
        Me.dtpExpirationTime.Name = "dtpExpirationTime"
        Me.dtpExpirationTime.ShowUpDown = True
        Me.dtpExpirationTime.Size = New System.Drawing.Size(108, 20)
        Me.dtpExpirationTime.TabIndex = 4
        '
        'dtpExpirationDate
        '
        Me.dtpExpirationDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpExpirationDate.Location = New System.Drawing.Point(93, 45)
        Me.dtpExpirationDate.Name = "dtpExpirationDate"
        Me.dtpExpirationDate.Size = New System.Drawing.Size(108, 20)
        Me.dtpExpirationDate.TabIndex = 3
        '
        'lblExpiration
        '
        Me.lblExpiration.AutoSize = True
        Me.lblExpiration.Location = New System.Drawing.Point(31, 50)
        Me.lblExpiration.Name = "lblExpiration"
        Me.lblExpiration.Size = New System.Drawing.Size(56, 13)
        Me.lblExpiration.TabIndex = 2
        Me.lblExpiration.Text = "Expiration:"
        '
        'lblCorrelationId
        '
        Me.lblCorrelationId.AutoSize = True
        Me.lblCorrelationId.Location = New System.Drawing.Point(13, 22)
        Me.lblCorrelationId.Name = "lblCorrelationId"
        Me.lblCorrelationId.Size = New System.Drawing.Size(74, 13)
        Me.lblCorrelationId.TabIndex = 0
        Me.lblCorrelationId.Text = "Correlation ID:"
        '
        'txtCorrelationId
        '
        Me.txtCorrelationId.Location = New System.Drawing.Point(93, 19)
        Me.txtCorrelationId.Name = "txtCorrelationId"
        Me.txtCorrelationId.Size = New System.Drawing.Size(220, 20)
        Me.txtCorrelationId.TabIndex = 1
        '
        'txtMessageDetails
        '
        Me.txtMessageDetails.Location = New System.Drawing.Point(9, 178)
        Me.txtMessageDetails.MaxLength = 65534
        Me.txtMessageDetails.Multiline = True
        Me.txtMessageDetails.Name = "txtMessageDetails"
        Me.txtMessageDetails.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtMessageDetails.Size = New System.Drawing.Size(967, 267)
        Me.txtMessageDetails.TabIndex = 16
        '
        'cmdCopyLeft
        '
        Me.cmdCopyLeft.Location = New System.Drawing.Point(493, 571)
        Me.cmdCopyLeft.Name = "cmdCopyLeft"
        Me.cmdCopyLeft.Size = New System.Drawing.Size(21, 30)
        Me.cmdCopyLeft.TabIndex = 5
        Me.cmdCopyLeft.Text = "<"
        Me.cmdCopyLeft.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1008, 911)
        Me.Controls.Add(Me.cmdCopyLeft)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.lblReceive)
        Me.Controls.Add(Me.lblSend)
        Me.Controls.Add(Me.cmdCopyRight)
        Me.Controls.Add(Me.grpbxReceive)
        Me.Controls.Add(Me.grpbxSend)
        Me.Controls.Add(Me.cmdClearOutput)
        Me.Controls.Add(Me.txtOutput)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.Text = "ActiveMQ DiagComm"
        CType(Me.nudSendQty, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpbxSend.ResumeLayout(False)
        Me.grpbxSend.PerformLayout()
        CType(Me.nudSendThrottle, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpbxReceive.ResumeLayout(False)
        Me.grpbxReceive.PerformLayout()
        CType(Me.nudReceiveDuration, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cmdSend As Button
    Friend WithEvents txtOutput As TextBox
    Friend WithEvents cmdReceive As Button
    Friend WithEvents nudSendQty As NumericUpDown
    Friend WithEvents cmdClearOutput As Button
    Friend WithEvents txtSendDestination As TextBox
    Friend WithEvents grpbxSend As GroupBox
    Friend WithEvents lblSendQty As Label
    Friend WithEvents lblSendQueue As Label
    Friend WithEvents lblSendServer As Label
    Friend WithEvents txtSendServer As TextBox
    Friend WithEvents grpbxReceive As GroupBox
    Friend WithEvents lblReceiveQueue As Label
    Friend WithEvents lblReceiveServer As Label
    Friend WithEvents txtReceiveServer As TextBox
    Friend WithEvents txtReceiveDestination As TextBox
    Friend WithEvents cmdCopyRight As Button
    Friend WithEvents lblSend As Label
    Friend WithEvents lblReceive As Label
    Friend WithEvents txtSendPort As TextBox
    Friend WithEvents lblSendPort As Label
    Friend WithEvents txtReceivePort As TextBox
    Friend WithEvents lblReceivePort As Label
    Friend WithEvents chkReceiveAcknowledge As CheckBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents dtpExpirationDate As DateTimePicker
    Friend WithEvents lblExpiration As Label
    Friend WithEvents lblCorrelationId As Label
    Friend WithEvents txtCorrelationId As TextBox
    Friend WithEvents txtMessageDetails As TextBox
    Friend WithEvents dtpExpirationTime As DateTimePicker
    Friend WithEvents lblPersistence As Label
    Friend WithEvents txtType As TextBox
    Friend WithEvents lblType As Label
    Friend WithEvents txtReplyTo As TextBox
    Friend WithEvents lblReplyTo As Label
    Friend WithEvents lblPriority As Label
    Friend WithEvents lblProperties As Label
    Friend WithEvents lblDetails As Label
    Friend WithEvents chkPersistence As CheckBox
    Friend WithEvents cmbPriority As ComboBox
    Friend WithEvents txtProperties As TextBox
    Friend WithEvents cmdClearMessageFields As Button
    Friend WithEvents lblSendSeconds As Label
    Friend WithEvents lblSendThrottle As Label
    Friend WithEvents nudSendThrottle As NumericUpDown
    Friend WithEvents lblReceiveDuration As Label
    Friend WithEvents lblReceiveMinutes As Label
    Friend WithEvents nudReceiveDuration As NumericUpDown
    Friend WithEvents cmdCopyLeft As Button
    Friend WithEvents cmdSendReset As Button
    Friend WithEvents cmdReceiveReset As Button
End Class
