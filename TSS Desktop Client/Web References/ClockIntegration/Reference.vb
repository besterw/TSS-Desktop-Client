﻿'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by a tool.
'     Runtime Version:4.0.30319.34014
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict Off
Option Explicit On

Imports System
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Web.Services
Imports System.Web.Services.Protocols
Imports System.Xml.Serialization

'
'This source code was auto-generated by Microsoft.VSDesigner, Version 4.0.30319.34014.
'
Namespace ClockIntegration
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.33440"),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Web.Services.WebServiceBindingAttribute(Name:="ClockIntegerationSoap", [Namespace]:="http://tempuri.org/")>  _
    Partial Public Class ClockIntegeration
        Inherits System.Web.Services.Protocols.SoapHttpClientProtocol
        
        Private GetActiveSessionOperationCompleted As System.Threading.SendOrPostCallback
        
        Private GetListOfMachinesOperationCompleted As System.Threading.SendOrPostCallback
        
        Private GetListOfMachinesForUserOperationCompleted As System.Threading.SendOrPostCallback
        
        Private GetListOfMachinesForUserGSMOnlyOperationCompleted As System.Threading.SendOrPostCallback
        
        Private GetMachineCnInfoOperationCompleted As System.Threading.SendOrPostCallback
        
        Private WriteClockRecordOperationCompleted As System.Threading.SendOrPostCallback
        
        Private WriteClockRecordWithDetailOperationCompleted As System.Threading.SendOrPostCallback
        
        Private useDefaultCredentialsSetExplicitly As Boolean
        
        '''<remarks/>
        Public Sub New()
            MyBase.New
            Me.Url = Global.TSS_Desktop_Client.My.MySettings.Default.TSS_Desktop_Client_ClockIntegration_ClockIntegeration
            If (Me.IsLocalFileSystemWebService(Me.Url) = true) Then
                Me.UseDefaultCredentials = true
                Me.useDefaultCredentialsSetExplicitly = false
            Else
                Me.useDefaultCredentialsSetExplicitly = true
            End If
        End Sub
        
        Public Shadows Property Url() As String
            Get
                Return MyBase.Url
            End Get
            Set
                If (((Me.IsLocalFileSystemWebService(MyBase.Url) = true)  _
                            AndAlso (Me.useDefaultCredentialsSetExplicitly = false))  _
                            AndAlso (Me.IsLocalFileSystemWebService(value) = false)) Then
                    MyBase.UseDefaultCredentials = false
                End If
                MyBase.Url = value
            End Set
        End Property
        
        Public Shadows Property UseDefaultCredentials() As Boolean
            Get
                Return MyBase.UseDefaultCredentials
            End Get
            Set
                MyBase.UseDefaultCredentials = value
                Me.useDefaultCredentialsSetExplicitly = true
            End Set
        End Property
        
        '''<remarks/>
        Public Event GetActiveSessionCompleted As GetActiveSessionCompletedEventHandler
        
        '''<remarks/>
        Public Event GetListOfMachinesCompleted As GetListOfMachinesCompletedEventHandler
        
        '''<remarks/>
        Public Event GetListOfMachinesForUserCompleted As GetListOfMachinesForUserCompletedEventHandler
        
        '''<remarks/>
        Public Event GetListOfMachinesForUserGSMOnlyCompleted As GetListOfMachinesForUserGSMOnlyCompletedEventHandler
        
        '''<remarks/>
        Public Event GetMachineCnInfoCompleted As GetMachineCnInfoCompletedEventHandler
        
        '''<remarks/>
        Public Event WriteClockRecordCompleted As WriteClockRecordCompletedEventHandler
        
        '''<remarks/>
        Public Event WriteClockRecordWithDetailCompleted As WriteClockRecordWithDetailCompletedEventHandler
        
        '''<remarks/>
        <System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/GetActiveSession", RequestNamespace:="http://tempuri.org/", ResponseNamespace:="http://tempuri.org/", Use:=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle:=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)>  _
        Public Function GetActiveSession(ByVal username As String, ByVal password As String) As String
            Dim results() As Object = Me.Invoke("GetActiveSession", New Object() {username, password})
            Return CType(results(0),String)
        End Function
        
        '''<remarks/>
        Public Overloads Sub GetActiveSessionAsync(ByVal username As String, ByVal password As String)
            Me.GetActiveSessionAsync(username, password, Nothing)
        End Sub
        
        '''<remarks/>
        Public Overloads Sub GetActiveSessionAsync(ByVal username As String, ByVal password As String, ByVal userState As Object)
            If (Me.GetActiveSessionOperationCompleted Is Nothing) Then
                Me.GetActiveSessionOperationCompleted = AddressOf Me.OnGetActiveSessionOperationCompleted
            End If
            Me.InvokeAsync("GetActiveSession", New Object() {username, password}, Me.GetActiveSessionOperationCompleted, userState)
        End Sub
        
        Private Sub OnGetActiveSessionOperationCompleted(ByVal arg As Object)
            If (Not (Me.GetActiveSessionCompletedEvent) Is Nothing) Then
                Dim invokeArgs As System.Web.Services.Protocols.InvokeCompletedEventArgs = CType(arg,System.Web.Services.Protocols.InvokeCompletedEventArgs)
                RaiseEvent GetActiveSessionCompleted(Me, New GetActiveSessionCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState))
            End If
        End Sub
        
        '''<remarks/>
        <System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/GetListOfMachines", RequestNamespace:="http://tempuri.org/", ResponseNamespace:="http://tempuri.org/", Use:=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle:=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)>  _
        Public Function GetListOfMachines() As String
            Dim results() As Object = Me.Invoke("GetListOfMachines", New Object(-1) {})
            Return CType(results(0),String)
        End Function
        
        '''<remarks/>
        Public Overloads Sub GetListOfMachinesAsync()
            Me.GetListOfMachinesAsync(Nothing)
        End Sub
        
        '''<remarks/>
        Public Overloads Sub GetListOfMachinesAsync(ByVal userState As Object)
            If (Me.GetListOfMachinesOperationCompleted Is Nothing) Then
                Me.GetListOfMachinesOperationCompleted = AddressOf Me.OnGetListOfMachinesOperationCompleted
            End If
            Me.InvokeAsync("GetListOfMachines", New Object(-1) {}, Me.GetListOfMachinesOperationCompleted, userState)
        End Sub
        
        Private Sub OnGetListOfMachinesOperationCompleted(ByVal arg As Object)
            If (Not (Me.GetListOfMachinesCompletedEvent) Is Nothing) Then
                Dim invokeArgs As System.Web.Services.Protocols.InvokeCompletedEventArgs = CType(arg,System.Web.Services.Protocols.InvokeCompletedEventArgs)
                RaiseEvent GetListOfMachinesCompleted(Me, New GetListOfMachinesCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState))
            End If
        End Sub
        
        '''<remarks/>
        <System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/GetListOfMachinesForUser", RequestNamespace:="http://tempuri.org/", ResponseNamespace:="http://tempuri.org/", Use:=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle:=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)>  _
        Public Function GetListOfMachinesForUser(ByVal activeSession As String) As String
            Dim results() As Object = Me.Invoke("GetListOfMachinesForUser", New Object() {activeSession})
            Return CType(results(0),String)
        End Function
        
        '''<remarks/>
        Public Overloads Sub GetListOfMachinesForUserAsync(ByVal activeSession As String)
            Me.GetListOfMachinesForUserAsync(activeSession, Nothing)
        End Sub
        
        '''<remarks/>
        Public Overloads Sub GetListOfMachinesForUserAsync(ByVal activeSession As String, ByVal userState As Object)
            If (Me.GetListOfMachinesForUserOperationCompleted Is Nothing) Then
                Me.GetListOfMachinesForUserOperationCompleted = AddressOf Me.OnGetListOfMachinesForUserOperationCompleted
            End If
            Me.InvokeAsync("GetListOfMachinesForUser", New Object() {activeSession}, Me.GetListOfMachinesForUserOperationCompleted, userState)
        End Sub
        
        Private Sub OnGetListOfMachinesForUserOperationCompleted(ByVal arg As Object)
            If (Not (Me.GetListOfMachinesForUserCompletedEvent) Is Nothing) Then
                Dim invokeArgs As System.Web.Services.Protocols.InvokeCompletedEventArgs = CType(arg,System.Web.Services.Protocols.InvokeCompletedEventArgs)
                RaiseEvent GetListOfMachinesForUserCompleted(Me, New GetListOfMachinesForUserCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState))
            End If
        End Sub
        
        '''<remarks/>
        <System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/GetListOfMachinesForUserGSMOnly", RequestNamespace:="http://tempuri.org/", ResponseNamespace:="http://tempuri.org/", Use:=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle:=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)>  _
        Public Function GetListOfMachinesForUserGSMOnly(ByVal activeSession As String) As String
            Dim results() As Object = Me.Invoke("GetListOfMachinesForUserGSMOnly", New Object() {activeSession})
            Return CType(results(0),String)
        End Function
        
        '''<remarks/>
        Public Overloads Sub GetListOfMachinesForUserGSMOnlyAsync(ByVal activeSession As String)
            Me.GetListOfMachinesForUserGSMOnlyAsync(activeSession, Nothing)
        End Sub
        
        '''<remarks/>
        Public Overloads Sub GetListOfMachinesForUserGSMOnlyAsync(ByVal activeSession As String, ByVal userState As Object)
            If (Me.GetListOfMachinesForUserGSMOnlyOperationCompleted Is Nothing) Then
                Me.GetListOfMachinesForUserGSMOnlyOperationCompleted = AddressOf Me.OnGetListOfMachinesForUserGSMOnlyOperationCompleted
            End If
            Me.InvokeAsync("GetListOfMachinesForUserGSMOnly", New Object() {activeSession}, Me.GetListOfMachinesForUserGSMOnlyOperationCompleted, userState)
        End Sub
        
        Private Sub OnGetListOfMachinesForUserGSMOnlyOperationCompleted(ByVal arg As Object)
            If (Not (Me.GetListOfMachinesForUserGSMOnlyCompletedEvent) Is Nothing) Then
                Dim invokeArgs As System.Web.Services.Protocols.InvokeCompletedEventArgs = CType(arg,System.Web.Services.Protocols.InvokeCompletedEventArgs)
                RaiseEvent GetListOfMachinesForUserGSMOnlyCompleted(Me, New GetListOfMachinesForUserGSMOnlyCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState))
            End If
        End Sub
        
        '''<remarks/>
        <System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/GetMachineCnInfo", RequestNamespace:="http://tempuri.org/", ResponseNamespace:="http://tempuri.org/", Use:=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle:=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)>  _
        Public Function GetMachineCnInfo(ByVal serialNumber As String) As String
            Dim results() As Object = Me.Invoke("GetMachineCnInfo", New Object() {serialNumber})
            Return CType(results(0),String)
        End Function
        
        '''<remarks/>
        Public Overloads Sub GetMachineCnInfoAsync(ByVal serialNumber As String)
            Me.GetMachineCnInfoAsync(serialNumber, Nothing)
        End Sub
        
        '''<remarks/>
        Public Overloads Sub GetMachineCnInfoAsync(ByVal serialNumber As String, ByVal userState As Object)
            If (Me.GetMachineCnInfoOperationCompleted Is Nothing) Then
                Me.GetMachineCnInfoOperationCompleted = AddressOf Me.OnGetMachineCnInfoOperationCompleted
            End If
            Me.InvokeAsync("GetMachineCnInfo", New Object() {serialNumber}, Me.GetMachineCnInfoOperationCompleted, userState)
        End Sub
        
        Private Sub OnGetMachineCnInfoOperationCompleted(ByVal arg As Object)
            If (Not (Me.GetMachineCnInfoCompletedEvent) Is Nothing) Then
                Dim invokeArgs As System.Web.Services.Protocols.InvokeCompletedEventArgs = CType(arg,System.Web.Services.Protocols.InvokeCompletedEventArgs)
                RaiseEvent GetMachineCnInfoCompleted(Me, New GetMachineCnInfoCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState))
            End If
        End Sub
        
        '''<remarks/>
        <System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/WriteClockRecord", RequestNamespace:="http://tempuri.org/", ResponseNamespace:="http://tempuri.org/", Use:=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle:=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)>  _
        Public Function WriteClockRecord(ByVal SerialNumber As String, ByVal activeSession As String, ByVal payrollId As String, ByVal Year_ As String, ByVal month_ As String, ByVal day_ As String, ByVal hour_ As String, ByVal min_ As String, ByVal sec_ As String, ByVal site_ As String) As String
            Dim results() As Object = Me.Invoke("WriteClockRecord", New Object() {SerialNumber, activeSession, payrollId, Year_, month_, day_, hour_, min_, sec_, site_})
            Return CType(results(0),String)
        End Function
        
        '''<remarks/>
        Public Overloads Sub WriteClockRecordAsync(ByVal SerialNumber As String, ByVal activeSession As String, ByVal payrollId As String, ByVal Year_ As String, ByVal month_ As String, ByVal day_ As String, ByVal hour_ As String, ByVal min_ As String, ByVal sec_ As String, ByVal site_ As String)
            Me.WriteClockRecordAsync(SerialNumber, activeSession, payrollId, Year_, month_, day_, hour_, min_, sec_, site_, Nothing)
        End Sub
        
        '''<remarks/>
        Public Overloads Sub WriteClockRecordAsync(ByVal SerialNumber As String, ByVal activeSession As String, ByVal payrollId As String, ByVal Year_ As String, ByVal month_ As String, ByVal day_ As String, ByVal hour_ As String, ByVal min_ As String, ByVal sec_ As String, ByVal site_ As String, ByVal userState As Object)
            If (Me.WriteClockRecordOperationCompleted Is Nothing) Then
                Me.WriteClockRecordOperationCompleted = AddressOf Me.OnWriteClockRecordOperationCompleted
            End If
            Me.InvokeAsync("WriteClockRecord", New Object() {SerialNumber, activeSession, payrollId, Year_, month_, day_, hour_, min_, sec_, site_}, Me.WriteClockRecordOperationCompleted, userState)
        End Sub
        
        Private Sub OnWriteClockRecordOperationCompleted(ByVal arg As Object)
            If (Not (Me.WriteClockRecordCompletedEvent) Is Nothing) Then
                Dim invokeArgs As System.Web.Services.Protocols.InvokeCompletedEventArgs = CType(arg,System.Web.Services.Protocols.InvokeCompletedEventArgs)
                RaiseEvent WriteClockRecordCompleted(Me, New WriteClockRecordCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState))
            End If
        End Sub
        
        '''<remarks/>
        <System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/WriteClockRecordWithDetail", RequestNamespace:="http://tempuri.org/", ResponseNamespace:="http://tempuri.org/", Use:=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle:=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)>  _
        Public Function WriteClockRecordWithDetail(ByVal SerialNumber As String, ByVal activeSession As String, ByVal payrollId As String, ByVal Year_ As String, ByVal month_ As String, ByVal day_ As String, ByVal hour_ As String, ByVal min_ As String, ByVal sec_ As String, ByVal site_ As String, ByVal verifyMode_ As String, ByVal inOutMode_ As String, ByVal wc_ As String) As String
            Dim results() As Object = Me.Invoke("WriteClockRecordWithDetail", New Object() {SerialNumber, activeSession, payrollId, Year_, month_, day_, hour_, min_, sec_, site_, verifyMode_, inOutMode_, wc_})
            Return CType(results(0),String)
        End Function
        
        '''<remarks/>
        Public Overloads Sub WriteClockRecordWithDetailAsync(ByVal SerialNumber As String, ByVal activeSession As String, ByVal payrollId As String, ByVal Year_ As String, ByVal month_ As String, ByVal day_ As String, ByVal hour_ As String, ByVal min_ As String, ByVal sec_ As String, ByVal site_ As String, ByVal verifyMode_ As String, ByVal inOutMode_ As String, ByVal wc_ As String)
            Me.WriteClockRecordWithDetailAsync(SerialNumber, activeSession, payrollId, Year_, month_, day_, hour_, min_, sec_, site_, verifyMode_, inOutMode_, wc_, Nothing)
        End Sub
        
        '''<remarks/>
        Public Overloads Sub WriteClockRecordWithDetailAsync(ByVal SerialNumber As String, ByVal activeSession As String, ByVal payrollId As String, ByVal Year_ As String, ByVal month_ As String, ByVal day_ As String, ByVal hour_ As String, ByVal min_ As String, ByVal sec_ As String, ByVal site_ As String, ByVal verifyMode_ As String, ByVal inOutMode_ As String, ByVal wc_ As String, ByVal userState As Object)
            If (Me.WriteClockRecordWithDetailOperationCompleted Is Nothing) Then
                Me.WriteClockRecordWithDetailOperationCompleted = AddressOf Me.OnWriteClockRecordWithDetailOperationCompleted
            End If
            Me.InvokeAsync("WriteClockRecordWithDetail", New Object() {SerialNumber, activeSession, payrollId, Year_, month_, day_, hour_, min_, sec_, site_, verifyMode_, inOutMode_, wc_}, Me.WriteClockRecordWithDetailOperationCompleted, userState)
        End Sub
        
        Private Sub OnWriteClockRecordWithDetailOperationCompleted(ByVal arg As Object)
            If (Not (Me.WriteClockRecordWithDetailCompletedEvent) Is Nothing) Then
                Dim invokeArgs As System.Web.Services.Protocols.InvokeCompletedEventArgs = CType(arg,System.Web.Services.Protocols.InvokeCompletedEventArgs)
                RaiseEvent WriteClockRecordWithDetailCompleted(Me, New WriteClockRecordWithDetailCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState))
            End If
        End Sub
        
        '''<remarks/>
        Public Shadows Sub CancelAsync(ByVal userState As Object)
            MyBase.CancelAsync(userState)
        End Sub
        
        Private Function IsLocalFileSystemWebService(ByVal url As String) As Boolean
            If ((url Is Nothing)  _
                        OrElse (url Is String.Empty)) Then
                Return false
            End If
            Dim wsUri As System.Uri = New System.Uri(url)
            If ((wsUri.Port >= 1024)  _
                        AndAlso (String.Compare(wsUri.Host, "localHost", System.StringComparison.OrdinalIgnoreCase) = 0)) Then
                Return true
            End If
            Return false
        End Function
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.33440")>  _
    Public Delegate Sub GetActiveSessionCompletedEventHandler(ByVal sender As Object, ByVal e As GetActiveSessionCompletedEventArgs)
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.33440"),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code")>  _
    Partial Public Class GetActiveSessionCompletedEventArgs
        Inherits System.ComponentModel.AsyncCompletedEventArgs
        
        Private results() As Object
        
        Friend Sub New(ByVal results() As Object, ByVal exception As System.Exception, ByVal cancelled As Boolean, ByVal userState As Object)
            MyBase.New(exception, cancelled, userState)
            Me.results = results
        End Sub
        
        '''<remarks/>
        Public ReadOnly Property Result() As String
            Get
                Me.RaiseExceptionIfNecessary
                Return CType(Me.results(0),String)
            End Get
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.33440")>  _
    Public Delegate Sub GetListOfMachinesCompletedEventHandler(ByVal sender As Object, ByVal e As GetListOfMachinesCompletedEventArgs)
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.33440"),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code")>  _
    Partial Public Class GetListOfMachinesCompletedEventArgs
        Inherits System.ComponentModel.AsyncCompletedEventArgs
        
        Private results() As Object
        
        Friend Sub New(ByVal results() As Object, ByVal exception As System.Exception, ByVal cancelled As Boolean, ByVal userState As Object)
            MyBase.New(exception, cancelled, userState)
            Me.results = results
        End Sub
        
        '''<remarks/>
        Public ReadOnly Property Result() As String
            Get
                Me.RaiseExceptionIfNecessary
                Return CType(Me.results(0),String)
            End Get
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.33440")>  _
    Public Delegate Sub GetListOfMachinesForUserCompletedEventHandler(ByVal sender As Object, ByVal e As GetListOfMachinesForUserCompletedEventArgs)
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.33440"),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code")>  _
    Partial Public Class GetListOfMachinesForUserCompletedEventArgs
        Inherits System.ComponentModel.AsyncCompletedEventArgs
        
        Private results() As Object
        
        Friend Sub New(ByVal results() As Object, ByVal exception As System.Exception, ByVal cancelled As Boolean, ByVal userState As Object)
            MyBase.New(exception, cancelled, userState)
            Me.results = results
        End Sub
        
        '''<remarks/>
        Public ReadOnly Property Result() As String
            Get
                Me.RaiseExceptionIfNecessary
                Return CType(Me.results(0),String)
            End Get
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.33440")>  _
    Public Delegate Sub GetListOfMachinesForUserGSMOnlyCompletedEventHandler(ByVal sender As Object, ByVal e As GetListOfMachinesForUserGSMOnlyCompletedEventArgs)
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.33440"),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code")>  _
    Partial Public Class GetListOfMachinesForUserGSMOnlyCompletedEventArgs
        Inherits System.ComponentModel.AsyncCompletedEventArgs
        
        Private results() As Object
        
        Friend Sub New(ByVal results() As Object, ByVal exception As System.Exception, ByVal cancelled As Boolean, ByVal userState As Object)
            MyBase.New(exception, cancelled, userState)
            Me.results = results
        End Sub
        
        '''<remarks/>
        Public ReadOnly Property Result() As String
            Get
                Me.RaiseExceptionIfNecessary
                Return CType(Me.results(0),String)
            End Get
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.33440")>  _
    Public Delegate Sub GetMachineCnInfoCompletedEventHandler(ByVal sender As Object, ByVal e As GetMachineCnInfoCompletedEventArgs)
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.33440"),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code")>  _
    Partial Public Class GetMachineCnInfoCompletedEventArgs
        Inherits System.ComponentModel.AsyncCompletedEventArgs
        
        Private results() As Object
        
        Friend Sub New(ByVal results() As Object, ByVal exception As System.Exception, ByVal cancelled As Boolean, ByVal userState As Object)
            MyBase.New(exception, cancelled, userState)
            Me.results = results
        End Sub
        
        '''<remarks/>
        Public ReadOnly Property Result() As String
            Get
                Me.RaiseExceptionIfNecessary
                Return CType(Me.results(0),String)
            End Get
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.33440")>  _
    Public Delegate Sub WriteClockRecordCompletedEventHandler(ByVal sender As Object, ByVal e As WriteClockRecordCompletedEventArgs)
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.33440"),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code")>  _
    Partial Public Class WriteClockRecordCompletedEventArgs
        Inherits System.ComponentModel.AsyncCompletedEventArgs
        
        Private results() As Object
        
        Friend Sub New(ByVal results() As Object, ByVal exception As System.Exception, ByVal cancelled As Boolean, ByVal userState As Object)
            MyBase.New(exception, cancelled, userState)
            Me.results = results
        End Sub
        
        '''<remarks/>
        Public ReadOnly Property Result() As String
            Get
                Me.RaiseExceptionIfNecessary
                Return CType(Me.results(0),String)
            End Get
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.33440")>  _
    Public Delegate Sub WriteClockRecordWithDetailCompletedEventHandler(ByVal sender As Object, ByVal e As WriteClockRecordWithDetailCompletedEventArgs)
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.33440"),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code")>  _
    Partial Public Class WriteClockRecordWithDetailCompletedEventArgs
        Inherits System.ComponentModel.AsyncCompletedEventArgs
        
        Private results() As Object
        
        Friend Sub New(ByVal results() As Object, ByVal exception As System.Exception, ByVal cancelled As Boolean, ByVal userState As Object)
            MyBase.New(exception, cancelled, userState)
            Me.results = results
        End Sub
        
        '''<remarks/>
        Public ReadOnly Property Result() As String
            Get
                Me.RaiseExceptionIfNecessary
                Return CType(Me.results(0),String)
            End Get
        End Property
    End Class
End Namespace