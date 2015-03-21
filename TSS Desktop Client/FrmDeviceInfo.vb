
Public Class FrmDeviceInfo

    Dim m_stop As Boolean = False
    Dim m_frmSystemSettings As FrmSystemSettings

    Public Event updateUser(ByVal msg As String)


    Private Function createAuthentencation() As String
        Try


            Dim _ws As New ClockIntegration.ClockIntegeration

            ' ensure that we use the correct web service
            _ws.Url = My.Settings.WebServerpath

            Dim _actSession As String = ""
            _actSession = _ws.GetActiveSession(My.Settings.ServerAccount, New ENDEC().decryptString(My.Settings.ServerAccountPassword))

            If _actSession.StartsWith("Failure") Then
                Me.TextBox1.Text = _actSession & vbCrLf & vbCrLf & TextBox1.Text

                Throw New Exception(_actSession)
            Else
                Return _actSession
            End If
        Catch ex As Exception
            ' Write to log and ignore
            Me.TextBox1.Text = ex.Message & vbCrLf & vbCrLf & TextBox1.Text
            ' ensure that the timer is started
            Me.Timer1.Start()
        End Try
    End Function

    Private Sub UploadClockData(ByVal actSession As String)
        Try
            RaiseEvent updateUser("Start...")


            Dim _ws As New ClockIntegration.ClockIntegeration

            ' ensure that we use the correct web service
            _ws.Url = My.Settings.WebServerpath

            Dim _listOfmachines As String

            If My.Settings.GSMModulesOnly Then
                _listOfmachines = _ws.GetListOfMachinesForUserGSMOnly(actSession)
            Else
                _listOfmachines = _ws.GetListOfMachinesForUser(actSession)
            End If

            RaiseEvent updateUser(Now() & vbCrLf & "List Of Devices: " & _listOfmachines & vbCrLf)
            ''''Application.DoEvents()
            Dim _devices() As String = _listOfmachines.Split("|")

            Dim _i As Integer = 0

            For _i = 0 To _devices.Length - 1

                Dim _deviceInfo As String = _ws.GetMachineCnInfo(_devices(_i))


                Dim _ip As String = _deviceInfo.Split("|")(0)
                Dim _port As String = _deviceInfo.Split("|")(1)
                Dim _deviceSerialNumber As String = _devices(_i)
                Dim _AllocatedSiteId As Integer = _deviceInfo.Split("|")(2)
                Dim _DeviceName As String = _deviceInfo.Split("|")(3)
                Dim _machineNumber As Int32 = _deviceInfo.Split("|")(4)
                Dim _password As String = _deviceInfo.Split("|")(5)

                RaiseEvent updateUser("Connecting to: " & _DeviceName & " ip:" & _ip & " Port:" & _port & vbCrLf)
                ''''Application.DoEvents()

                ' test if the machine is visible on the network
                Dim _ping As New Net.NetworkInformation.Ping
                Dim _pingReply As Net.NetworkInformation.PingReply
                _pingReply = _ping.Send(_ip)


                ' Declare Variables to hold clock data
                Dim _arrClockRecords As New ArrayList

                ' Ping the IP
                If _pingReply.Status = Net.NetworkInformation.IPStatus.Success Then

                    'Connect to the device
                    Dim axCZKEM1 As New zkemkeeper.CZKEM
                    axCZKEM1.SetCommPassword(_password)
                    If axCZKEM1.Connect_Net(_ip, Convert.ToInt32(_port)) Then

                        RaiseEvent updateUser("Connected to _ip." & vbCrLf + Me.TextBox1.Text)

                        ''''Application.DoEvents()

                        RaiseEvent updateUser(_ws.GetMachineCnInfo(_devices(_i)) & vbCrLf)

                        ''''Application.DoEvents()
                        ' Get the clock data
                        '==============================================================
                        axCZKEM1.EnableDevice(_machineNumber, False) 'disable the device

                        Dim enrollnumber_ As String = ""
                        Dim verifyMode_ As Integer
                        Dim inOutMode_ As Integer
                        Dim year_ As Integer
                        Dim month_ As Integer
                        Dim day_ As Integer
                        Dim hr_ As Integer
                        Dim min_ As Integer
                        Dim sec_ As Integer
                        Dim wc As Integer
                        Dim idwErrorCode As Integer

                        Dim s As String = ""
                        Dim ts As String = ""
                        Try ' Talk to the machine


                            If axCZKEM1.ReadGeneralLogData(_machineNumber) Then
                                While axCZKEM1.SSR_GetGeneralLogData(_machineNumber, _
                                                                 enrollnumber_, _
                                                                 verifyMode_, _
                                                                 inOutMode_, _
                                                                 year_, _
                                                                  month_, _
                                                                   day_, _
                                                                    hr_, _
                                                                     min_, _
                                                                      sec_, _
                                                                      wc)
                                    ' Begin to loop through the clock Records
                                    Try



                                        ' Write the data from the clock machine to an array list
                                        Dim _cc As New ClockRecord
                                        With _cc
                                            .verifyMode = verifyMode_
                                            .enrollnumber = enrollnumber_
                                            .inOutMode = inOutMode_
                                            .hr_ = hr_
                                            .min_ = min_
                                            .sec_ = sec_
                                            .year_ = year_
                                            .month_ = month_
                                            .day_ = day_
                                            .wc = wc
                                            .deviceSerialNumber = _devices(_i)
                                        End With
                                        _arrClockRecords.Add(_cc)

                                        RaiseEvent updateUser("Reading :" & _
                                                    _cc.enrollnumber & "|Y:" & _cc.year_ & "|M:" & _cc.month_ & "|D:" & _cc.day_ & _
                                                    "|H:" & _cc.hr_ & "|M:" & _cc.min_ & "|S:" & _cc.sec_ & ")" & vbCrLf)
                                    Catch ex As Exception
                                        RaiseEvent updateUser("Error Occured:" & vbCrLf & ex.Message & vbCrLf)
                                        ''''Application.DoEvents()
                                    End Try

                                    ''If m_stop Then
                                    ''    Me.TextBox1.Text = "Manually Stopped..." & vbCrLf + Me.TextBox1.Text
                                    ''    ''''Application.DoEvents()
                                    ''    Exit While
                                    ''End If

                                End While ' Finished reading the clock records from the clock machine




                            Else
                                Cursor = Cursors.Default
                                axCZKEM1.GetLastError(idwErrorCode)
                                If idwErrorCode <> 0 Then
                                    RaiseEvent updateUser("Reading data from terminal failed,ErrorCode: " & idwErrorCode & vbCrLf)
                                Else
                                    RaiseEvent updateUser("No data from terminal returns!" & vbCrLf)
                                End If
                            End If ' Read all attendanse logs to memory
                        Catch ex As Exception
                            RaiseEvent updateUser(ex.Message + Me.TextBox1.Text)
                        Finally

                            RaiseEvent updateUser("Writing Clock Data to file ...")

                            If _arrClockRecords.Count > 0 Then
                                'Create a Log File
                                '=========================================================
                                Dim fp As System.IO.StreamWriter
                                Dim cnt As Int32 = 0

                                fp = System.IO.File.CreateText(My.Application.Info.DirectoryPath & "\" & _machineNumber & "_" & Now.ToFileTime & ".dat")
                                For cnt = 0 To _arrClockRecords.Count - 1
                                    fp.WriteLine(CType(_arrClockRecords.Item(cnt), ClockRecord).ToString())
                                Next
                                fp.Close()
                                '=========================================================
                                RaiseEvent updateUser("File complete")

                                'Update the todo file
                                '=========================================================
                                RaiseEvent updateUser("Writing Clock Data to file ...")

                                'Save the records to a text file
                                Dim toDoFile As System.IO.StreamWriter

                                toDoFile = System.IO.File.AppendText(My.Application.Info.DirectoryPath & "\RecordsToUpload.dat")
                                For cnt = 0 To _arrClockRecords.Count - 1
                                    toDoFile.WriteLine(CType(_arrClockRecords.Item(cnt), ClockRecord).ToString())
                                Next
                                toDoFile.Close()
                                '========================================================
                                RaiseEvent updateUser("File complete")
                            End If
                            ''''Application.DoEvents()

                        End Try

                        axCZKEM1.ClearGLog(_machineNumber)

                        axCZKEM1.EnableDevice(_machineNumber, True) 'enable the device

                        RaiseEvent updateUser("Disconnecting..." & vbCrLf)

                        ' Disconnect from the device
                        axCZKEM1.Disconnect()

                        '==============================================================

                    Else
                        RaiseEvent updateUser("Connection failed." & vbCrLf)
                        ''''Application.DoEvents()
                    End If
                    Me.WriteClockDataToWebServer(actSession)
                Else
                    RaiseEvent updateUser("Machine with IP Address: " & _ip & " is not available on the network." & vbCrLf)
                    ''''Application.DoEvents()
                End If ' Ping IP

                ' 20130919
                ' Write log file to server
                Me.WriteClockDataToWebServer(actSession)

            Next ' each machine

        Catch ex As Exception
            RaiseEvent updateUser(ex.Message & vbCrLf & vbCrLf)

            ' ensure that the timer is started
            Me.Timer1.Start()
        Finally

            Me.m_stop = False

            RaiseEvent updateUser("Complete")

        End Try

    End Sub

    Private Sub WriteClockDataToWebServer(ByVal _actSession As String)
        Try
            ' Start: Attempt to write the data to the web server
            '===============================================================================================

            'Open the local file containing the data
            Dim toDoFile As New System.IO.StreamReader(My.Application.Info.DirectoryPath & "\RecordsToUpload.dat")
            Dim _arrClockRecords As New ArrayList
            ' Strart: load the file to an array
            Do While Not toDoFile.EndOfStream

                Dim _arr() As String = toDoFile.ReadLine().Split(",")

                Dim _cc As New ClockRecord
                With _cc
                    .enrollnumber = _arr(0).Trim()
                    .verifyMode = _arr(1).Trim()
                    .inOutMode = _arr(2).Trim()
                    .year_ = _arr(3).Trim()
                    .month_ = _arr(4).Trim()
                    .day_ = _arr(5).Trim()

                    .hr_ = _arr(6).Trim()
                    .min_ = _arr(7).Trim()
                    .sec_ = _arr(8).Trim()

                    .wc = _arr(9).Trim()
                    .alocatedSiteId = _arr(10).Trim()
                    .deviceSerialNumber = _arr(11).Trim()
                End With
                _arrClockRecords.Add(_cc)

            Loop
            toDoFile.Close()
            ' End: load the file to an array

            Dim _b As Int32
            Dim _ts As String = ""

            RaiseEvent updateUser("Start writing records to web server: " & vbCrLf)


            Dim _ws As New ClockIntegration.ClockIntegeration

            ' ensure that we use the correct web service
            _ws.Url = My.Settings.WebServerpath


            For _b = 0 To _arrClockRecords.Count - 1

                ''''Application.DoEvents()

                With CType(_arrClockRecords.Item(_b), ClockRecord)

                    RaiseEvent updateUser("Writing " & _b + 1 & " of " & _arrClockRecords.Count & ": " & _ts & _
                                        .enrollnumber & "|Y:" & .year_ & "|M:" & .month_ & "|D:" & .day_ & _
                                        "|H:" & .hr_ & "|M:" & .min_ & "|S:" & .sec_ & "|IO:" & .inOutMode & ")" _
                                        & vbCrLf)

                    ''''Application.DoEvents()
                    Try
                        _ts = _ws.WriteClockRecordWithDetail(CType(_arrClockRecords(_b), ClockRecord).deviceSerialNumber, _actSession, .enrollnumber, .year_, _
                                                                                              .month_, _
                                                                                                .day_, _
                                                                                                 .hr_, _
                                                                                                  .min_, _
                                                                                                   .sec_, _
                                                                                                    CType(_arrClockRecords(_b), ClockRecord).alocatedSiteId, _
                                                                                                   .verifyMode, _
                                                                                                    .inOutMode, _
                                                                                                   .wc)
                        RaiseEvent updateUser(_ts)
                        If _ts.StartsWith("Suc") Then
                            CType(_arrClockRecords(_b), ClockRecord).Success = "1"
                        Else
                            CType(_arrClockRecords(_b), ClockRecord).Success = "0"
                        End If

                        ' Update the todofile, If someting goes wrong
                        Me.UpdateTodoFile(_arrClockRecords)
                    Catch ex As Exception
                        RaiseEvent updateUser("Failure: " & ex.Message & vbCrLf)
                    End Try

                    ''''Application.DoEvents()
                End With

            Next ' Records in the array
            ' End: Attempt to write the data to the web server
            '===============================================================================================
        Catch ex As Exception

        End Try
    End Sub

    Private Sub UpdateTodoFile(ByVal arr As ArrayList)
        Dim cnt As Int32 = 0


        With New System.IO.FileInfo(My.Application.Info.DirectoryPath & "\RecordsToUpload.dat")
            .Delete()
        End With


        Dim toDoFile As System.IO.StreamWriter
        toDoFile = System.IO.File.CreateText(My.Application.Info.DirectoryPath & "\RecordsToUpload.dat")

        For cnt = 0 To arr.Count - 1
            If CType(arr.Item(cnt), ClockRecord).Success = "0" Then
                toDoFile.WriteLine(CType(arr.Item(cnt), ClockRecord).ToString())
            End If
        Next
        toDoFile.Close()
    End Sub

    Private Sub Timer1_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Try
            Me.Timer1.Stop()

            Me.Timer1.Interval = My.Settings.Interval

            Me.UploadClockData(Me.createAuthentencation)

            Me.Timer1.Start()

        Catch ex As Exception
            Me.TextBox1.Text = ex.Message & vbCrLf & vbCrLf & TextBox1.Text
            ' Do nothing and ensure that the timer is started
            Me.Timer1.Start()
        End Try
    End Sub

    Private Sub FrmDeviceInfo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Me.Text = "ENI Supplies, Time & Attendance, Version: " & My.Application.Info.Version.ToString()

            If CInt(My.Settings.Interval) >= 120000 Then
                Me.Timer1.Interval = My.Settings.Interval
                Me.Timer1.Enabled = True
            Else
                My.Settings.Interval = 180000
                Me.Timer1.Interval = My.Settings.Interval
                Me.Timer1.Enabled = True
            End If
            Me.Timer1.Start()

            Me.Timer2.Start()
        Catch ex As Exception
            Me.TextBox1.Text = ex.Message & vbCrLf & vbCrLf & TextBox1.Text
            ' ensure that the timer is started
            Me.Timer1.Start()
        End Try
    End Sub

    Protected Overrides Sub Finalize()
        MyBase.Finalize()

        Me.Timer1.Stop()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Me.m_stop = True
        'this is a comment
    End Sub

    Private Sub CloseSeverToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CloseSeverToolStripMenuItem.Click
        Try

            Me.m_stop = True

            'My.''''Application.DoEvents()
            'My.''''Application.DoEvents()
            'My.''''Application.DoEvents()
            'My.''''Application.DoEvents()
            'My.''''Application.DoEvents()
            'My.''''Application.DoEvents()

            Me.Close()
        Catch ex As Exception
            Me.TextBox1.Text = ex.Message & vbCrLf & vbCrLf & TextBox1.Text
            ' do nothing 
            Me.Timer1.Start()
        End Try
    End Sub

    Private Sub SettingsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SettingsToolStripMenuItem.Click
        Try
            m_frmSystemSettings = New FrmSystemSettings

            Me.m_frmSystemSettings.ShowDialog(Me)
        Catch ex As Exception
            Me.TextBox1.Text = ex.Message & vbCrLf & vbCrLf & TextBox1.Text
            ' do nothing 
            Me.Timer1.Start()
        End Try
    End Sub

    Private Sub Timer2_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Timer2.Tick
        Try
            If Me.Timer1.Enabled Then
                Me.ToolStripStatusLabel1.Text = "Main Timer is enabled."
            Else
                Me.ToolStripStatusLabel1.Text = "Main Timer is Disabled."
            End If
        Catch ex As Exception
            Me.TextBox1.Text = ex.Message & vbCrLf & vbCrLf & TextBox1.Text
            ' do nothing 
            Me.Timer1.Start()
        End Try
    End Sub

    Private Sub ImportDataFromAvailableDevicesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ImportDataFromAvailableDevicesToolStripMenuItem.Click
        Try
            Dim s As String = createAuthentencation()

            Me.UploadClockData(s)

        Catch ex As Exception
            Me.TextBox1.Text = ex.Message & vbCrLf & vbCrLf & TextBox1.Text
            ' do nothing 
            Me.Timer1.Start()
        End Try
    End Sub

    Private Sub handleUpdateScreenEvent(ByVal msg As String) Handles Me.updateUser
        Me.TextBox1.Text = vbCrLf & msg & Me.TextBox1.Text
        Application.DoEvents()
    End Sub

End Class

Friend Class ClockRecord

    Friend enrollnumber As String = ""
    Friend verifyMode As Integer = "0"
    Friend inOutMode As Integer = "0"
    Friend year_ As Integer = 0
    Friend month_ As Integer = 0
    Friend day_ As Integer = 0
    Friend hr_ As Integer = 0
    Friend min_ As Integer = 0
    Friend sec_ As Integer = 0
    Friend wc As Integer = 0
    Friend alocatedSiteId As Int32 = 0
    Friend deviceSerialNumber As String
    Friend Success As String = "0"

    Public Overrides Function ToString() As String

        Return enrollnumber & ", " & verifyMode & ", " & inOutMode & ", " & year_ & ", " & month_ & ", " & day_ & ", " & hr_ & ", " & min_ & ", " & sec_ & ", " & wc & ", " & alocatedSiteId & ", " & deviceSerialNumber & ", " & Success '

    End Function

End Class