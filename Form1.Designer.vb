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
        Me.txtMessage = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
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
        Me.txtReceivePort = New System.Windows.Forms.TextBox()
        Me.lblReceivePort = New System.Windows.Forms.Label()
        Me.lblReceiveQueue = New System.Windows.Forms.Label()
        Me.lblReceiveServer = New System.Windows.Forms.Label()
        Me.txtReceiveServer = New System.Windows.Forms.TextBox()
        Me.txtReceiveQueue = New System.Windows.Forms.TextBox()
        Me.cmdClearInput = New System.Windows.Forms.Button()
        Me.cmdCopy = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.chkAcknowledge = New System.Windows.Forms.CheckBox()
        CType(Me.nudQty, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
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
        Me.txtOutput.Location = New System.Drawing.Point(13, 474)
        Me.txtOutput.Multiline = True
        Me.txtOutput.Name = "txtOutput"
        Me.txtOutput.ReadOnly = True
        Me.txtOutput.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtOutput.Size = New System.Drawing.Size(983, 218)
        Me.txtOutput.TabIndex = 6
        '
        'txtMessage
        '
        Me.txtMessage.Location = New System.Drawing.Point(13, 29)
        Me.txtMessage.MaxLength = 65534
        Me.txtMessage.Multiline = True
        Me.txtMessage.Name = "txtMessage"
        Me.txtMessage.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtMessage.Size = New System.Drawing.Size(983, 340)
        Me.txtMessage.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(50, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Message"
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
        Me.cmdClearOutput.Location = New System.Drawing.Point(921, 698)
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
        Me.GroupBox1.Location = New System.Drawing.Point(13, 401)
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
        Me.GroupBox2.Location = New System.Drawing.Point(525, 401)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(470, 67)
        Me.GroupBox2.TabIndex = 5
        Me.GroupBox2.TabStop = False
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
        'cmdClearInput
        '
        Me.cmdClearInput.Location = New System.Drawing.Point(921, 375)
        Me.cmdClearInput.Name = "cmdClearInput"
        Me.cmdClearInput.Size = New System.Drawing.Size(75, 23)
        Me.cmdClearInput.TabIndex = 2
        Me.cmdClearInput.Text = "&Clear"
        Me.cmdClearInput.UseVisualStyleBackColor = True
        '
        'cmdCopy
        '
        Me.cmdCopy.Location = New System.Drawing.Point(493, 418)
        Me.cmdCopy.Name = "cmdCopy"
        Me.cmdCopy.Size = New System.Drawing.Size(21, 39)
        Me.cmdCopy.TabIndex = 4
        Me.cmdCopy.Text = ">"
        Me.cmdCopy.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(19, 390)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(32, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Send"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(531, 390)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(47, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Receive"
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
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1008, 729)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cmdCopy)
        Me.Controls.Add(Me.cmdClearInput)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.cmdClearOutput)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtMessage)
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
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cmdSend As Button
    Friend WithEvents txtOutput As TextBox
    Friend WithEvents txtMessage As TextBox
    Friend WithEvents Label1 As Label
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
    Friend WithEvents cmdClearInput As Button
    Friend WithEvents cmdCopy As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtSendPort As TextBox
    Friend WithEvents lblSendPort As Label
    Friend WithEvents txtReceivePort As TextBox
    Friend WithEvents lblReceivePort As Label
    Friend WithEvents chkAcknowledge As CheckBox
End Class
