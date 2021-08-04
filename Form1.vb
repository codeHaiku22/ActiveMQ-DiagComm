Imports System.Threading
Imports Apache.NMS
Imports Apache.NMS.Util
Imports System.Data.SqlClient
Imports System.Text.RegularExpressions
Imports System.Xml
Public Class Form1

    Protected semaphore As AutoResetEvent = New AutoResetEvent(False)
    Protected message As ITextMessage
    Protected tmspnTimeout As TimeSpan = TimeSpan.FromSeconds(10)
    Private mstrSendServerUri As String
    Private mstrReceiveServerUri As String
    Private mstrSendServerQueue As String
    Private mstrReceiveServerQueue As String
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load

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
            message = session.CreateTextMessage(txtMessage.Text)
            connection.Start()
            producer.DeliveryMode = MsgDeliveryMode.Persistent
            producer.RequestTimeout = tmspnTimeout
            For intCnt = 1 To intQty
                producer.Send(message)
            Next intCnt
            ShowOutput(intQty & " message(s) successfully sent to: " & destination.ToString)
        Catch ex As Exception
            ShowOutput("An error occurred when sending message(s) to: " & mstrSendServerQueue)
            ShowOutput(ex.Message)
        Finally
            ShowOutput("")
            session.Close()
            connection.Stop()
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
                ShowOutput("Messsage successfully received from: " & source.ToString)
                ShowOutput("Message text:")
                ShowOutput(message.Text)
                If chkAcknowledge.Checked Then message.Acknowledge()
            End If
        Catch ex As Exception
            ShowOutput("An error occurred when receiving a message from: " & mstrReceiveServerQueue)
            ShowOutput(ex.Message)
        Finally
            ShowOutput("")
            session.Close()
            connection.Stop()
        End Try

    End Sub
    Private Sub cmdClearInput_Click(sender As Object, e As EventArgs) Handles cmdClearInput.Click

        txtMessage.Clear()

    End Sub
    Private Sub cmdClearOutput_Click(sender As Object, e As EventArgs) Handles cmdClearOutput.Click

        txtOutput.Clear()

    End Sub
    Private Sub ShowOutput(ByVal strMessage As String)

        strMessage = strMessage.Trim

        strMessage = strMessage & vbCrLf

        txtOutput.Text = txtOutput.Text + strMessage

    End Sub

End Class

'Parking LOT

'Example connection strings
'activemq:tcp://activemqhost:61616
'stomp:tcp://activemqhost:61613

'With request
'.NMSCorrelationID = "abc"
'.NMSDeliveryMode = MsgDeliveryMode.Persistent
'.NMSDestination = destination
'.NMSMessageId = "100"
'.NMSPriority = MsgPriority.Normal
'.NMSRedelivered = False
'.NMSReplyTo = destination
'.NMSTimestamp = DateTime.Today
'.NMSTimeToLive = New TimeSpan(0, 0, 30) 'Hours, Minutes, Seconds
'.NMSType = "SomeNMSType"
'.Properties("NMSXGroupId") = "Cheese"
'.Properties("myHeader") = "Cheddar"
'End With

'Private Sub parseXML()

'    Dim strXML As String = DB_Get_XML()
'    Dim strPattern As String = "\s.*=.*\""" 'Removes namespaces and makes string easy to parse

'    For Each strLine As String In strXML.Split(vbLf) ', StringSplitOptions.RemoveEmptyEntries)
'        strLine = LTrim(strLine)
'        Dim strResult As String = Regex.Replace(strLine, strPattern, "")
'        ShowOutput(strResult)
'    Next

'    'Each line ends with vbLf or Char(10)

'End Sub
'Private Sub OnMessage(ByVal receivedMsg As IMessage)

'    Dim message As ITextMessage = receivedMsg

'    semaphore.Set()

'End Sub