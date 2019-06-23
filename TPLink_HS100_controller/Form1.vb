﻿Imports System
Imports System.Net
Imports System.Text
Imports System.IO
Imports Newtonsoft.Json.Linq

Public Class Form1
    Dim g As Guid
    Dim accountid As String
    Private trayicon As NotifyIcon
    Private Shared WM_QUERYENDSESSION As Integer = &H11
    Dim cmdflag = False
    Dim GracefulExitFlag = False


    Private Sub btnUpdatelist_Click(sender As Object, e As EventArgs) Handles btnUpdatelist.Click

        'get the list of devices
        Dim lstresp = (sendreq("https://wap.tplinkcloud.com?token=" & gettoken(), "{""method"": ""getDeviceList""}"))
        Dim lsto As JObject = JObject.Parse(lstresp)
        If (lsto("error_code").ToString) = "0" Then
            Dim devices As JArray = lsto("result")("deviceList")
            listviewDevices.Items.Clear() 'clear all old devices from listbox
            clearAllNotifyicons() 'clear all old device notifyicons from taskbar
            Dim i As Integer = 0
            For Each child As JObject In devices
                listviewDevices.Items.Add(child("alias").ToString)
                listviewDevices.Items(i).SubItems.Add(child("status").ToString)
                listviewDevices.Items(i).SubItems.Add(child("deviceId").ToString)
                listviewDevices.Items(i).SubItems.Add(child("appServerUrl").ToString)
                If (child("status").ToString = "1") Then listviewDevices.Items(i).SubItems.Add(getstate(child("deviceId").ToString, child("appServerUrl").ToString).ToString)

                If (child("status").ToString = "1") Then
                    trayicon = New NotifyIcon
                    Me.components.Add(trayicon) ' add the trayicon to the form components so it can be managed later
                    trayicon.Text = child("alias").ToString
                    If getstate(child("deviceId").ToString, child("appServerUrl").ToString) Then
                        trayicon.Icon = My.Resources.icoOn
                    Else
                        trayicon.Icon = My.Resources.icoOff
                    End If
                    trayicon.Tag = child("deviceId").ToString
                    AddHandler trayicon.MouseClick, AddressOf OnIconMouseClick
                    trayicon.Visible = True
                End If

                i += 1
            Next
            If dbgMode.Checked Then MsgBox(lsto.ToString)

            'if there are no objects, give the application its own notifyicon. If there are objects, do not give application its own notifyicon (as the objects will have their own)
            If listviewDevices.Items.Count = 0 Then
                NotifyIcon1.Visible = True
            Else
                NotifyIcon1.Visible = False
            End If

        Else
            MsgBox("An error occured while getting the list of devices" & Environment.NewLine & lsto.ToString)
        End If

    End Sub

    Function sendreq(url As String, data As String) As String
        Dim s As HttpWebRequest
        Dim enc As UTF8Encoding
        Dim postdata As String = data
        Dim postdatabytes As Byte()
        s = HttpWebRequest.Create(url)
        enc = New System.Text.UTF8Encoding()
        postdatabytes = enc.GetBytes(postdata)
        s.Method = "POST"
        s.ContentType = "application/json"
        s.ContentLength = postdatabytes.Length
        Using stream = s.GetRequestStream()
            stream.Write(postdatabytes, 0, postdatabytes.Length)
        End Using
        Dim result = s.GetResponse()
        Dim ReceiveStream As Stream = result.GetResponseStream()
        Dim encode As Encoding = System.Text.Encoding.GetEncoding("utf-8")
        Dim readStream As New StreamReader(ReceiveStream, encode)
        Dim response As String = readStream.ReadToEnd()
        readStream.Close()
        ReceiveStream.Close()
        result.Close()
        Return response.ToString
    End Function

    Function gettoken() As String
        'log in and get a token
        g = Guid.NewGuid()
        Dim txttosend As String = "{""method"": ""login"",""params"": {""appType"": ""Kasa_Android"",""cloudUserName"": """ & txtEmail.Text & """,""cloudPassword"": """ & txtPassword.Text & """,""terminalUUID"": """ & g.ToString & """}}"
        Dim resp As String = (sendreq("https://wap.tplinkcloud.com", txttosend))
        Dim o As JObject = JObject.Parse(resp)
        If (o("error_code").ToString) = "0" Then
            Return (o("result")("token").ToString)
        Else
            MsgBox("An error occured while logging in or getting a token" & Environment.NewLine & o.ToString)
            Return "-1"
        End If
    End Function

    Private Sub btnOn_Click(sender As Object, e As EventArgs) Handles btnOn.Click
        'turn the selected item on using its deviceId and appServerUrl
        Dim command As String = "{""method"":""passthrough"",""params"": {""deviceId"": """ & listviewDevices.Items(listviewDevices.FocusedItem.Index).SubItems(2).Text & """,""requestData"": ""{\""system\"":{\""set_relay_state\"":{\""state\"":1}}}"" }}"
        Dim serverresp As String = (sendreq(listviewDevices.Items(listviewDevices.FocusedItem.Index).SubItems(3).Text & "?token=" & gettoken(), command))
    End Sub

    Private Sub btnOff_Click(sender As Object, e As EventArgs) Handles btnOff.Click
        'turn the selected item off using its deviceId and appServerUrl
        Dim command As String = "{""method"":""passthrough"",""params"": {""deviceId"": """ & listviewDevices.Items(listviewDevices.FocusedItem.Index).SubItems(2).Text & """,""requestData"": ""{\""system\"":{\""set_relay_state\"":{\""state\"":0}}}"" }}"
        Dim serverresp As String = (sendreq(listviewDevices.Items(listviewDevices.FocusedItem.Index).SubItems(3).Text & "?token=" & gettoken(), command))

    End Sub

    Private Sub txtEmail_TextChanged(sender As Object, e As EventArgs) Handles txtEmail.TextChanged
        If cmdflag = False Then
            Settings1.Default.email = txtEmail.Text
            Settings1.Default.Save()
        End If
    End Sub

    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If GracefulExitFlag = False Then
            e.Cancel = True
            Me.WindowState = FormWindowState.Minimized
            Me.FormBorderStyle = Windows.Forms.FormBorderStyle.SizableToolWindow
            Me.ShowInTaskbar = False
            ContextMenuStrip1.Enabled = True
            NotifyIcon1.Visible = True
            NotifyIcon1.ShowBalloonTip(5000, "TPLink HS100 Controller", "Right click the tray icon to re-open. Click button in lower right to quit.", ToolTipIcon.Info)
            If listviewDevices.Items.Count = 0 Then
                NotifyIcon1.Visible = True
            Else
                Timer1.Start()
            End If
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = Me.Text + " " + My.Application.Info.Version.ToString
        'load settings
        txtEmail.Text = Settings1.Default.email
        txtPassword.Text = Settings1.Default.password
        StartInTray.Checked = Settings1.Default.startintraystg

        'check if being used in command line mode
        Dim inputMode As String = ""
        Dim inputemail As String = ""
        Dim inputpass As String = ""
        Dim inputID As String = ""

        For Each s As String In My.Application.CommandLineArgs
            If s.ToLower.StartsWith("/mode=") Then
                inputMode = s.Remove(0, "/mode=".Length)
            End If
            If s.ToLower.StartsWith("/email=") Then
                inputemail = s.Remove(0, "/email=".Length)
            End If
            If s.ToLower.StartsWith("/pass=") Then
                inputpass = s.Remove(0, "/pass=".Length)
            End If
            If s.ToLower.StartsWith("/id=") Then
                inputID = s.Remove(0, "/id=".Length)
            End If
        Next

        If inputMode <> "" Then
            'command line mode is in use
            cmdflag = True
            If inputID = "" Then
                MsgBox("Error: Device ID must be specified as command line parameter.")
                gracefulexit()
            End If

            If inputMode <> "1" And inputMode <> "0" And inputMode <> "T" Then
                MsgBox("Error: Invalid mode input. Try /mode=1 (on) or /mode=0 (off) or /mode=T (toggle).")
                gracefulexit()
            End If

            'Override login info if set
            If inputemail <> "" And inputpass <> "" Then
                txtEmail.Text = inputemail
                txtPassword.Text = inputpass
            End If


            'get token & url
            Dim tkn As String = gettoken()
            If tkn = "-1" Then End
            Dim lstresp = (sendreq("https://wap.tplinkcloud.com?token=" & tkn, "{""method"": ""getDeviceList""}"))
            Dim lsto As JObject = JObject.Parse(lstresp)
            Dim deviceserver As String = ""
            If (lsto("error_code").ToString) = "0" Then
                Dim devices As JArray = lsto("result")("deviceList")
                Dim devfound As Boolean = False
                For Each child As JObject In devices
                    If (child("status").ToString = "1" And child("deviceId").ToString() = inputID) Then
                        'device found
                        deviceserver = child("appServerUrl").ToString()
                        devfound = True
                    End If
                Next
                If devfound = False Then
                    MsgBox("Error: device not online / not found.")
                    'End
                    gracefulexit()
                End If
            Else
                MsgBox("An error occured while getting the list of devices from the server" & Environment.NewLine & lsto.ToString)
            End If

            'If mode is toggle, get current state
            If inputMode = "T" Then
                If getstate(inputID, deviceserver) Then
                    inputMode = "0"
                Else
                    inputMode = "1"
                End If
            End If

            'send command
            Dim command As String = "{""method"":""passthrough"",""params"": {""deviceId"": """ & inputID & """,""requestData"": ""{\""system\"":{\""set_relay_state\"":{\""state\"":" & inputMode & "}}}"" }}"
            Dim serverresp As String = (sendreq(deviceserver & "?token=" & tkn, command))
            gracefulexit()
        Else
            'GUI mode is in use, do nothing and move on
        End If


        'normal mode, continue
        If Settings1.Default.startintraystg Then
            Me.WindowState = FormWindowState.Minimized
            Me.FormBorderStyle = Windows.Forms.FormBorderStyle.SizableToolWindow
            Me.ShowInTaskbar = False
            ContextMenuStrip1.Enabled = True
            If listviewDevices.Items.Count = 0 Then
                NotifyIcon1.Visible = True
            Else
                NotifyIcon1.Visible = False
            End If

        End If

        If txtEmail.Text <> "" And txtPassword.Text <> "" Then
            btnUpdatelist_Click(sender, e)
        End If
    End Sub

    Private Sub txtPassword_TextChanged(sender As Object, e As EventArgs) Handles txtPassword.TextChanged
        If cmdflag = False Then
            Settings1.Default.password = txtPassword.Text
            Settings1.Default.Save()
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnCreateSettings.Click
        Form2.Show()
    End Sub

    Private Sub OpenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenToolStripMenuItem.Click
        Me.WindowState = FormWindowState.Normal
        Me.FormBorderStyle = Windows.Forms.FormBorderStyle.Sizable
        Me.ShowInTaskbar = True
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        gracefulexit()
    End Sub

    Private Sub Form1_SizeChanged(sender As Object, e As EventArgs) Handles Me.SizeChanged
        If Me.WindowState = FormWindowState.Minimized Then
            ShowInTaskbar = False
            ContextMenuStrip1.Enabled = True
        End If
    End Sub

    Private Sub NotifyIcon1_DoubleClick(sender As Object, e As EventArgs) Handles NotifyIcon1.DoubleClick
        Me.WindowState = FormWindowState.Normal
        Me.FormBorderStyle = Windows.Forms.FormBorderStyle.Sizable
        Me.ShowInTaskbar = True
    End Sub

    Private Sub OnIconMouseClick(ByVal sender As Object, ByVal e As MouseEventArgs)
        'if left click, toggle switch state
        If (e.Button = Windows.Forms.MouseButtons.Left) Then
            Dim tempnotify As NotifyIcon = CType(sender, NotifyIcon) 'get the sender object to extract tag (deviceid)

            For Each row As ListViewItem In listviewDevices.Items
                If row.SubItems(2).Text = tempnotify.Tag Then
                    If getstate(tempnotify.Tag, row.SubItems(3).Text) Then
                        'currently on, turn off
                        Dim command As String = "{""method"":""passthrough"",""params"": {""deviceId"": """ & tempnotify.Tag & """,""requestData"": ""{\""system\"":{\""set_relay_state\"":{\""state\"":0}}}"" }}"
                        Dim serverresp As String = (sendreq(row.SubItems(3).Text & "?token=" & gettoken(), command))
                        DirectCast(sender, NotifyIcon).Icon = My.Resources.icoOff
                    Else
                        'currently off, turn on
                        Dim command As String = "{""method"":""passthrough"",""params"": {""deviceId"": """ & tempnotify.Tag & """,""requestData"": ""{\""system\"":{\""set_relay_state\"":{\""state\"":1}}}"" }}"
                        Dim serverresp As String = (sendreq(row.SubItems(3).Text & "?token=" & gettoken(), command))
                        DirectCast(sender, NotifyIcon).Icon = My.Resources.icoOn
                    End If

                End If
            Next
        End If

        'if right click, open app window
        If (e.Button = Windows.Forms.MouseButtons.Right) Then
            Me.WindowState = FormWindowState.Normal
            Me.FormBorderStyle = Windows.Forms.FormBorderStyle.Sizable
            Me.ShowInTaskbar = True
        End If
    End Sub

    Function getstate(deviceid As String, appserverurl As String) As Boolean
        'Check the state using deviceId and appServerUrl
        Dim command As String = "{""method"":""passthrough"", ""params"": {""deviceId"": """ & deviceid & """, ""requestData"": ""{\""system\"":{\""get_sysinfo\"":null},\""emeter\"":{\""get_realtime\"":null}}"" }}"
        Dim serverresp As String = (sendreq(appserverurl & "?token=" & gettoken(), command))
        Dim joresponse As JObject = JObject.Parse(serverresp)
        If (joresponse("error_code").ToString) = "0" Then
            Dim jorespdta As JObject = JObject.Parse(joresponse("result")("responseData"))
            Return (jorespdta("system")("get_sysinfo")("relay_state").ToString)
        Else
            MsgBox("An error occured while logging in or getting a token" & Environment.NewLine & joresponse.ToString)
            Return "-1"
        End If
    End Function

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnQuit.Click
        gracefulexit()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        NotifyIcon1.Visible = False
        Timer1.Stop()
    End Sub

    Private Sub StartInTray_CheckedChanged(sender As Object, e As EventArgs) Handles StartInTray.CheckedChanged
        Settings1.Default.startintraystg = StartInTray.Checked
        Settings1.Default.Save()
    End Sub
    Protected Overrides Sub WndProc(ByRef m As System.Windows.Forms.Message)
        ' Listen for operating system messages (windows is shutting down)
        If m.Msg = WM_QUERYENDSESSION Then
            ' Close the application
            MyBase.WndProc(m)
            gracefulexit()
        End If
        ' Handle the message
        MyBase.WndProc(m)
    End Sub

    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem1.Click
        My.Computer.Clipboard.SetText(listviewDevices.Items(listviewDevices.FocusedItem.Index).SubItems(2).Text)
    End Sub

    Sub gracefulexit()
        GracefulExitFlag = True
        Me.Close()
        Application.Exit()
        End
    End Sub

    Sub clearAllNotifyicons()
        ' loop through all components on form, find notifyicons with tags (device switches)
        For Each c As Object In Me.components.Components
            If TypeOf c Is NotifyIcon Then
                Dim tempnotify2 As NotifyIcon = CType(c, NotifyIcon)
                If tempnotify2.Tag <> "" Then
                    'MsgBox("Device Name: " + tempnotify2.Text + ", Device ID: " + tempnotify2.Tag)
                    tempnotify2.Visible = False
                End If
            End If
        Next
    End Sub
End Class

