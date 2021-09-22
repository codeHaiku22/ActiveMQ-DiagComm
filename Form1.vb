Imports System.Threading
Imports Apache.NMS
Imports Apache.NMS.Util
Imports System.Xml.Serialization
Imports System.Data.SqlClient
Imports System.Text.RegularExpressions
Public Class Form1

    'Private message As ITextMessage
    Private tmspnTimeout As TimeSpan = TimeSpan.FromSeconds(10)
    Private mstrSendServerUri As String
    Private mstrReceiveServerUri As String
    Private mstrSendServerQueue As String
    Private mstrReceiveServerQueue As String
    'Protected semaphore As AutoResetEvent = New AutoResetEvent(False)
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load

        dtpExpirationDate.Value = DateTime.Now
        dtpExpirationDate.MinDate = DateTime.Now
        dtpExpirationTime.Value = DateTime.Now
        dtpExpirationTime.MinDate = DateTime.Now

        Dim values As Array = System.Enum.GetValues(GetType(MsgPriority))
        Dim names As Array = System.Enum.GetNames(GetType(MsgPriority))

        Dim i As Integer = 0

        While i <= UBound(values)
            cmbPriority.Items.Add(values(i) & " - " & names(i))
            i += 1
        End While

        chkPersistence.Checked = True
        cmbPriority.SelectedIndex = 0
        txtSendPort.Text = "61616"
        txtReceivePort.Text = "61616"
        chkAcknowledge.Checked = False

    End Sub
    Private Sub cmdSend_Click(sender As Object, e As EventArgs) Handles cmdSend.Click

        Dim strSendServer As String
        Dim strSendPort As String
        Dim factory As IConnectionFactory
        Dim connection As IConnection
        Dim session As ISession
        Dim destination As IDestination
        Dim producer As IMessageProducer
        Dim message As ITextMessage
        Dim intQty As Integer = CInt(nudQty.Value)

        If txtSendServer.Text.Trim = "" Then Exit Sub

        If txtSendQueue.Text.Trim = "" Then Exit Sub

        If txtSendPort.Text.Trim = "" Or (Not IsNumeric(txtSendPort.Text.Trim)) Then Exit Sub

        If intQty <= 0 Then Exit Sub

        strSendServer = txtSendServer.Text.Trim
        strSendPort = txtSendPort.Text.Trim
        mstrSendServerUri = "tcp://" & strSendServer & ":" & strSendPort
        mstrSendServerQueue = txtSendQueue.Text.Trim

        Try
            ShowOutput("########## MESSAGE SEND ##########")
            ShowOutput(Now().ToString)
            ShowOutput("Connecting to: " & mstrSendServerUri.ToString)
            factory = New NMSConnectionFactory(mstrSendServerUri)
            connection = factory.CreateConnection()
            session = connection.CreateSession()
            destination = SessionUtil.GetDestination(session, mstrSendServerQueue)
            ShowOutput("Using destination: " & destination.ToString)
            producer = session.CreateProducer(destination)
            If Not CreateMessage(session, message) Then Exit Sub
            connection.Start()
            producer.DeliveryMode = message.NMSDeliveryMode
            producer.Priority = message.NMSPriority
            producer.RequestTimeout = tmspnTimeout
            For intCnt = 1 To intQty
                producer.Send(message)
                ShowOutput("Message sent with Message Id: " & message.NMSMessageId)
            Next intCnt
            ShowOutput(intQty & " message(s) successfully sent to: " & destination.ToString)
        Catch ex As Exception
            ShowOutput("An error occurred when sending message(s) to: " & mstrSendServerQueue)
            ShowOutput(ex.Message)
        Finally
            ShowOutput("")
            If session IsNot Nothing Then
                session.Close()
                session.Dispose()
            End If
            If connection IsNot Nothing Then
                connection.Stop()
                connection.Dispose()
            End If
            If destination IsNot Nothing Then destination.Dispose()
            If producer IsNot Nothing Then producer.Dispose()
        End Try

    End Sub
    Private Sub cmdCopy_Click(sender As Object, e As EventArgs) Handles cmdCopy.Click

        txtReceiveServer.Text = txtSendServer.Text
        txtReceiveQueue.Text = txtSendQueue.Text
        txtReceivePort.Text = txtSendPort.Text

    End Sub
    Private Sub cmdReceive_Click(sender As Object, e As EventArgs) Handles cmdReceive.Click

        Dim strReceiveServer As String
        Dim strReceivePort As String
        Dim factory As IConnectionFactory
        Dim connection As IConnection
        Dim session As ISession
        Dim source As IDestination
        Dim consumer As IMessageConsumer
        Dim message As ITextMessage

        If txtReceiveServer.Text.Trim = "" Then Exit Sub

        If txtReceiveQueue.Text.Trim = "" Then Exit Sub

        If txtReceivePort.Text.Trim = "" Or (Not IsNumeric(txtReceivePort.Text.Trim)) Then Exit Sub

        strReceiveServer = txtReceiveServer.Text.Trim
        strReceivePort = txtReceivePort.Text.Trim
        mstrReceiveServerUri = "tcp://" & strReceiveServer & ":" & strReceivePort
        mstrReceiveServerQueue = txtReceiveQueue.Text.Trim

        Try
            ShowOutput("########## MESSAGE RECEIVE ##########")
            ShowOutput(Now().ToString)
            ShowOutput("Connecting to: " & mstrReceiveServerUri.ToString)
            factory = New NMSConnectionFactory(mstrReceiveServerUri)
            connection = factory.CreateConnection()
            'session = connection.CreateSession()
            'session = connection.CreateSession(AcknowledgementMode.ClientAcknowledge)
            session = connection.CreateSession(AcknowledgementMode.IndividualAcknowledge)
            source = SessionUtil.GetDestination(session, mstrReceiveServerQueue)
            ShowOutput("Using source: " & source.ToString)
            consumer = session.CreateConsumer(source)
            connection.Start()
            message = consumer.Receive(tmspnTimeout)
            If message Is Nothing Then
                ShowOutput("No message received!")
            Else
                ShowOutput("Messsage with Message Id: " & message.NMSMessageId & " successfully received from: " & source.ToString)
                DisplayMessage(message)
                If chkAcknowledge.Checked Then message.Acknowledge()
            End If
        Catch ex As Exception
            ShowOutput("An error occurred when receiving a message from: " & mstrReceiveServerQueue)
            ShowOutput(ex.Message)
        Finally
            ShowOutput("")
            If session IsNot Nothing Then
                session.Close()
                session.Dispose()
            End If
            If connection IsNot Nothing Then
                connection.Stop()
                connection.Dispose()
            End If
            If source IsNot Nothing Then source.Dispose()
            If consumer IsNot Nothing Then consumer.Dispose()
        End Try

    End Sub
    Private Function CreateMessage(ByVal session As ISession, ByRef message As ITextMessage) As Boolean

        Dim blnError As Boolean

        Try
            message = session.CreateTextMessage()
            Dim tsTimeToLive As TimeSpan = (dtpExpirationDate.Value.Date + dtpExpirationTime.Value.TimeOfDay) - DateTime.Now
            Dim strPriority() As String = cmbPriority.Text.Split("-")
            Dim msgPriority As MsgPriority = CInt(strPriority(0))
            With message
                .NMSCorrelationID = txtCorrelationId.Text.Trim
                .NMSTimeToLive = IIf(tsTimeToLive < New TimeSpan(0, 0, 0, 0, 0), New TimeSpan(0, 0, 0, 0, 0), tsTimeToLive)
                .NMSDeliveryMode = IIf(chkPersistence.Checked, MsgDeliveryMode.Persistent, MsgDeliveryMode.NonPersistent)
                .NMSPriority = msgPriority
                .NMSType = txtType.Text.Trim
                .Text = txtMessageDetails.Text.Trim
            End With
            If Strings.Len(txtReplyTo.Text.Trim) > 0 Then message.NMSReplyTo = SessionUtil.GetDestination(session, txtReplyTo.Text.Trim)
            If Len(txtProperties.Text.Trim) > 0 Then
                Dim i As Integer = 0
                For Each line As String In txtProperties.Lines
                    Dim strProperty() As String = line.Trim.Split("=")
                    'message.Properties(strProperty(0)) = strProperty(1)
                    message.Properties.SetString(strProperty(0), strProperty(1))
                    i += 1
                Next
            End If
        Catch ex As Exception
            blnError = True
            ShowOutput("An error occurred while creating message.")
            ShowOutput(ex.Message)
        Finally
            CreateMessage = Not (blnError)
        End Try


    End Function
    Private Function DisplayMessage(ByVal message As ITextMessage) As Boolean

        Dim blnError As Boolean

        Try
            'Dim tsTimeToLive As TimeSpan = message.NMSTimeToLive - DateTime.Now
            With message
                txtCorrelationId.Text = .NMSCorrelationID
                chkPersistence.Checked = IIf(.NMSDeliveryMode = MsgDeliveryMode.Persistent, True, False)
                dtpExpirationDate.Value = DateTime.Now + .NMSTimeToLive
                dtpExpirationTime.Value = DateTime.Now + .NMSTimeToLive
                txtReplyTo.Text = .NMSReplyTo
                txtType.Text = .NMSType
                txtMessageDetails.Text = .Text
            End With
            Dim intMsgPriority As Integer = message.NMSPriority
            Dim i As Integer = 0
            For Each item In cmbPriority.Items
                Dim strPriority() As String = item.Split("-")
                If strPriority(0) = intMsgPriority Then
                    cmbPriority.SelectedIndex = i
                    Exit For
                End If
                i += 1
            Next
            i = 0
            While i < (message.Properties.Count)
                If i < (message.Properties.Count - 1) Then
                    txtProperties.AppendText(message.Properties.Keys(i).ToString & "=" & message.Properties.Values(i).ToString & Environment.NewLine)
                Else
                    txtProperties.AppendText(message.Properties.Keys(i).ToString & "=" & message.Properties.Values(i).ToString)
                End If
                i += 1
            End While
            txtProperties.Text.Trim()
        Catch ex As Exception
            blnError = True
            ShowOutput("An error occurred while creating message.")
            ShowOutput(ex.Message)
        Finally
            DisplayMessage = Not (blnError)
        End Try


    End Function
    Private Sub cmdClearMessageFields_Click_1(sender As Object, e As EventArgs) Handles cmdClearMessageFields.Click

        txtCorrelationId.Clear()
        dtpExpirationDate.Value = DateTime.Now
        dtpExpirationDate.MinDate = DateTime.Now
        dtpExpirationTime.Value = DateTime.Now
        dtpExpirationTime.MinDate = DateTime.Now
        chkPersistence.Checked = True
        cmbPriority.SelectedIndex = 0
        txtReplyTo.Clear()
        txtType.Clear()
        txtProperties.Clear()
        txtMessageDetails.Clear()

    End Sub
    Private Sub cmdClearOutput_Click(sender As Object, e As EventArgs) Handles cmdClearOutput.Click

        txtOutput.Clear()

    End Sub
    Private Sub ShowOutput(ByVal strMessage As String)

        strMessage = strMessage.Trim

        strMessage = strMessage & vbCrLf

        txtOutput.AppendText(strMessage)

    End Sub

End Class

'Parking LOT

'Example connection strings
'activemq:tcp://activemqhost:61616
'stomp:tcp://activemqhost:61613

'Private Sub cmdReceive_Click(sender As Object, e As EventArgs) Handles cmdReceive.Click

'    Dim strReceiveServer As String
'    Dim strReceivePort As String
'    Dim factory As IConnectionFactory
'    Dim connection As IConnection
'    Dim session As ISession
'    Dim source As IDestination
'    Dim consumer As IMessageConsumer
'    Dim message As ITextMessage

'    If txtReceiveServer.Text.Trim = "" Then Exit Sub

'    If txtReceiveQueue.Text.Trim = "" Then Exit Sub

'    If txtReceivePort.Text.Trim = "" Or (Not IsNumeric(txtReceivePort.Text.Trim)) Then Exit Sub

'    strReceiveServer = txtReceiveServer.Text.Trim
'    strReceivePort = txtReceivePort.Text.Trim
'    mstrReceiveServerUri = "tcp://" & strReceiveServer & ":" & strReceivePort
'    mstrReceiveServerQueue = txtReceiveQueue.Text.Trim

'    Try
'        ShowOutput("########## MESSAGE RECEIVE ##########")
'        ShowOutput(Now().ToString)
'        ShowOutput("Connecting to: " & mstrReceiveServerUri.ToString)
'        factory = New NMSConnectionFactory(mstrReceiveServerUri)
'        connection = factory.CreateConnection()
'        'session = connection.CreateSession()
'        'session = connection.CreateSession(AcknowledgementMode.ClientAcknowledge)
'        session = connection.CreateSession(AcknowledgementMode.IndividualAcknowledge)
'        source = SessionUtil.GetDestination(session, mstrReceiveServerQueue)
'        ShowOutput("Using source: " & source.ToString)
'        consumer = session.CreateConsumer(source)
'        connection.Start()
'        'message = consumer.Receive(tmspnTimeout)
'        AddHandler() consumer.Listener, AddressOf OnMessage
'        semaphore.WaitOne(tmspnTimeout, True)
'        If message Is Nothing Then
'            ShowOutput("No message received!")
'        Else
'            ShowOutput("Messsage successfully received from: " & source.ToString)
'            ShowOutput("Message text:")
'            ShowOutput(message.Text)
'            If chkAcknowledge.Checked Then message.Acknowledge()
'        End If
'    Catch ex As Exception
'        ShowOutput("An error occurred when receiving a message from: " & mstrReceiveServerQueue)
'        ShowOutput(ex.Message)
'    Finally
'        ShowOutput("")
'        session.Close()
'        connection.Stop()
'    End Try

'End Sub
'Private Sub OnMessage(ByVal receivedMsg As IMessage)

'    Dim message As ITextMessage = receivedMsg

'    semaphore.Set()

'End Sub