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
        Me.nudQty = New System.Windows.Forms.NumericUpDown()
        Me.cmdClearOutput = New System.Windows.Forms.Button()
        Me.txtSendQueue = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtSendPort = New System.Windows.Forms.TextBox()
        Me.lblSendPort = New System.Windows.Forms.Label()
        Me.lblSendQty = New System.Windows.Forms.Label()
        Me.lblSendQueue = New System.Windows.Forms.Label()
        Me.lblSendServer = New System.Windows.Forms.Label()
        Me.txtSendServer = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.chkAcknowledge = New System.Windows.Forms.CheckBox()
        Me.txtReceivePort = New System.Windows.Forms.TextBox()
        Me.lblReceivePort = New System.Windows.Forms.Label()
        Me.lblReceiveQueue = New System.Windows.Forms.Label()
        Me.lblReceiveServer = New System.Windows.Forms.Label()
        Me.txtReceiveServer = New System.Windows.Forms.TextBox()
        Me.txtReceiveQueue = New System.Windows.Forms.TextBox()
        Me.cmdCopy = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
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
        CType(Me.nudQty, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'cmdSend
        '
        Me.cmdSend.Location = New System.Drawing.Point(389, 38)
        Me.cmdSend.Name = "cmdSend"
        Me.cmdSend.Size = New System.Drawing.Size(75, 23)
        Me.cmdSend.TabIndex = 8
        Me.cmdSend.Text = "&Send"
        Me.cmdSend.UseVisualStyleBackColor = True
        '
        'txtOutput
        '
        Me.txtOutput.Location = New System.Drawing.Point(13, 588)
        Me.txtOutput.Multiline = True
        Me.txtOutput.Name = "txtOutput"
        Me.txtOutput.ReadOnly = True
        Me.txtOutput.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtOutput.Size = New System.Drawing.Size(983, 232)
        Me.txtOutput.TabIndex = 6
        '
        'cmdReceive
        '
        Me.cmdReceive.Location = New System.Drawing.Point(389, 38)
        Me.cmdReceive.Name = "cmdReceive"
        Me.cmdReceive.Size = New System.Drawing.Size(75, 23)
        Me.cmdReceive.TabIndex = 7
        Me.cmdReceive.Text = "&Receive"
        Me.cmdReceive.UseVisualStyleBackColor = True
        '
        'nudQty
        '
        Me.nudQty.Location = New System.Drawing.Point(336, 41)
        Me.nudQty.Name = "nudQty"
        Me.nudQty.Size = New System.Drawing.Size(47, 20)
        Me.nudQty.TabIndex = 7
        Me.nudQty.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'cmdClearOutput
        '
        Me.cmdClearOutput.Location = New System.Drawing.Point(921, 826)
        Me.cmdClearOutput.Name = "cmdClearOutput"
        Me.cmdClearOutput.Size = New System.Drawing.Size(75, 23)
        Me.cmdClearOutput.TabIndex = 7
        Me.cmdClearOutput.Text = "C&lear"
        Me.cmdClearOutput.UseVisualStyleBackColor = True
        '
        'txtSendQueue
        '
        Me.txtSendQueue.Location = New System.Drawing.Point(75, 40)
        Me.txtSendQueue.Name = "txtSendQueue"
        Me.txtSendQueue.Size = New System.Drawing.Size(220, 20)
        Me.txtSendQueue.TabIndex = 5
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtSendPort)
        Me.GroupBox1.Controls.Add(Me.lblSendPort)
        Me.GroupBox1.Controls.Add(Me.lblSendQty)
        Me.GroupBox1.Controls.Add(Me.lblSendQueue)
        Me.GroupBox1.Controls.Add(Me.lblSendServer)
        Me.GroupBox1.Controls.Add(Me.txtSendServer)
        Me.GroupBox1.Controls.Add(Me.txtSendQueue)
        Me.GroupBox1.Controls.Add(Me.nudQty)
        Me.GroupBox1.Controls.Add(Me.cmdSend)
        Me.GroupBox1.Location = New System.Drawing.Point(13, 515)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(470, 67)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        '
        'txtSendPort
        '
        Me.txtSendPort.Location = New System.Drawing.Point(336, 13)
        Me.txtSendPort.Name = "txtSendPort"
        Me.txtSendPort.Size = New System.Drawing.Size(128, 20)
        Me.txtSendPort.TabIndex = 3
        '
        'lblSendPort
        '
        Me.lblSendPort.AutoSize = True
        Me.lblSendPort.Location = New System.Drawing.Point(301, 16)
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
        Me.lblSendQty.Size = New System.Drawing.Size(26, 13)
        Me.lblSendQty.TabIndex = 6
        Me.lblSendQty.Text = "Qty:"
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
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.chkAcknowledge)
        Me.GroupBox2.Controls.Add(Me.txtReceivePort)
        Me.GroupBox2.Controls.Add(Me.lblReceivePort)
        Me.GroupBox2.Controls.Add(Me.lblReceiveQueue)
        Me.GroupBox2.Controls.Add(Me.lblReceiveServer)
        Me.GroupBox2.Controls.Add(Me.txtReceiveServer)
        Me.GroupBox2.Controls.Add(Me.cmdReceive)
        Me.GroupBox2.Controls.Add(Me.txtReceiveQueue)
        Me.GroupBox2.Location = New System.Drawing.Point(525, 515)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(470, 67)
        Me.GroupBox2.TabIndex = 5
        Me.GroupBox2.TabStop = False
        '
        'chkAcknowledge
        '
        Me.chkAcknowledge.AutoSize = True
        Me.chkAcknowledge.Location = New System.Drawing.Point(315, 42)
        Me.chkAcknowledge.Name = "chkAcknowledge"
        Me.chkAcknowledge.Size = New System.Drawing.Size(68, 17)
        Me.chkAcknowledge.TabIndex = 6
        Me.chkAcknowledge.Text = "Ack Msg"
        Me.chkAcknowledge.UseVisualStyleBackColor = True
        '
        'txtReceivePort
        '
        Me.txtReceivePort.Location = New System.Drawing.Point(336, 14)
        Me.txtReceivePort.Name = "txtReceivePort"
        Me.txtReceivePort.Size = New System.Drawing.Size(128, 20)
        Me.txtReceivePort.TabIndex = 3
        '
        'lblReceivePort
        '
        Me.lblReceivePort.AutoSize = True
        Me.lblReceivePort.Location = New System.Drawing.Point(301, 17)
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
        'txtReceiveQueue
        '
        Me.txtReceiveQueue.Location = New System.Drawing.Point(75, 41)
        Me.txtReceiveQueue.Name = "txtReceiveQueue"
        Me.txtReceiveQueue.Size = New System.Drawing.Size(220, 20)
        Me.txtReceiveQueue.TabIndex = 5
        '
        'cmdCopy
        '
        Me.cmdCopy.Location = New System.Drawing.Point(493, 532)
        Me.cmdCopy.Name = "cmdCopy"
        Me.cmdCopy.Size = New System.Drawing.Size(21, 39)
        Me.cmdCopy.TabIndex = 4
        Me.cmdCopy.Text = ">"
        Me.cmdCopy.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(19, 504)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(32, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Send"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(531, 504)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(47, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Receive"
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
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1008, 861)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cmdCopy)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.cmdClearOutput)
        Me.Controls.Add(Me.txtOutput)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.Text = "ActiveMQ DiagComm"
        CType(Me.nudQty, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cmdSend As Button
    Friend WithEvents txtOutput As TextBox
    Friend WithEvents cmdReceive As Button
    Friend WithEvents nudQty As NumericUpDown
    Friend WithEvents cmdClearOutput As Button
    Friend WithEvents txtSendQueue As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents lblSendQty As Label
    Friend WithEvents lblSendQueue As Label
    Friend WithEvents lblSendServer As Label
    Friend WithEvents txtSendServer As TextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents lblReceiveQueue As Label
    Friend WithEvents lblReceiveServer As Label
    Friend WithEvents txtReceiveServer As TextBox
    Friend WithEvents txtReceiveQueue As TextBox
    Friend WithEvents cmdCopy As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtSendPort As TextBox
    Friend WithEvents lblSendPort As Label
    Friend WithEvents txtReceivePort As TextBox
    Friend WithEvents lblReceivePort As Label
    Friend WithEvents chkAcknowledge As CheckBox
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
End Class
