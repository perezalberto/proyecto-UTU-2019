Imports System.ComponentModel
Imports System.ComponentModel.Design
Imports System.Runtime.InteropServices

Public Class WindowAction
    Inherits Component

    Private Const WM_NCLBUTTONDOWN As Integer = &HA1
    Private Const HTBOTTOM As Integer = 15
    Private Const HTBOTTOMRIGHT As Integer = 17
    Private Const HTCAPTION As Integer = 2
    Private Const HTRIGHT As Integer = 11

    Private m_hOriginalParent As Integer
    Private Const GWL_HWNDPARENT As Integer = -8

    Private Declare Function GetClassLong Lib "user32" Alias "GetClassLongA" (lngHandler As IntPtr, lngIndex As Integer) As Integer
    Private Declare Function GetDesktopWindow Lib "user32" () As Integer
    Private Declare Function SetClassLong Lib "user32" Alias "SetClassLongA" (lngHandler As IntPtr, lngIndex As Integer, lngNewClassLong As Integer) As Integer
    Private Declare Function SetWindowLong Lib "user32" Alias "SetWindowLongA" (hWnd As IntPtr, nIndex As Integer, dwNewLong As Integer) As Integer

    Private WithEvents ContainerControlForm As Form

    Private Sub ContainerControlForm_Load(sender As Object, e As EventArgs) Handles ContainerControlForm.Activated
        If ShowShadow Then
            ContainerControlForm.SuspendLayout()
            ' NO EJECUTAR LO SIGUIENTE EN EL EVENTO LOAD DEL FORMULARIO
            ContainerControlForm.FormBorderStyle = FormBorderStyle.None
            Const CS_DROPSHADOW As Integer = &H20000
            Const GCL_STYLE As Integer = -26
            m_hOriginalParent = SetWindowLong(ContainerControlForm.Handle, GWL_HWNDPARENT, GetDesktopWindow())
            SetClassLong(ContainerControlForm.Handle, GCL_STYLE, GetClassLong(ContainerControlForm.Handle, GCL_STYLE) Or CS_DROPSHADOW)
            ContainerControlForm.ResumeLayout(False)
        End If
    End Sub

    Private Const ResizeBorderWidth As Integer = 4
    Private resizeDir As Integer = -1

    <Category("Appearance")>
    Public Property MaximizeBitmap As Bitmap

    <Category("Appearance")>
    Public Property RestoreBitmap As Bitmap

    <Category("Appearance")>
    Public Property ShowShadow As Boolean = False

    Private WithEvents TitlebarControl As Control

    <Category("Controls")>
    Public Property TitleBar As Control
        Get
            Return TitlebarControl
        End Get
        Set(value As Control)
            TitlebarControl = value
        End Set
    End Property

    Private WithEvents BtnCloseControl As Button

    <Category("Controls")>
    Public Property CloseButton As Button
        Get
            Return BtnCloseControl
        End Get
        Set(value As Button)
            BtnCloseControl = value
        End Set
    End Property

    Private WithEvents BtnMaxControl As Button

    <Category("Controls")>
    Public Property MaximizeButton As Button
        Get
            Return BtnMaxControl
        End Get
        Set(value As Button)
            BtnMaxControl = value
        End Set
    End Property

    Private WithEvents BtnMinControl As Button

    <Category("Controls")>
    Public Property MinimizeButton As Button
        Get
            Return BtnMinControl
        End Get
        Set(value As Button)
            BtnMinControl = value
        End Set
    End Property

    <Category("Controls")>
    Public Property ContainerControl As Form
        Get
            Return ContainerControlForm
        End Get
        Set(value As Form)
            ContainerControlForm = value
        End Set
    End Property

    Public Overrides Property Site As ISite
        Get
            Return MyBase.Site
        End Get
        Set(ByVal value As ISite)
            MyBase.Site = value

            If value Is Nothing Then
                Return
            End If

            Dim host As IDesignerHost = TryCast(value.GetService(GetType(IDesignerHost)), IDesignerHost)

            If host IsNot Nothing Then
                Dim componentHost As IComponent = host.RootComponent

                If TypeOf componentHost Is ContainerControl Then
                    ContainerControl = TryCast(componentHost, Form)
                End If
            End If
        End Set
    End Property

    <DllImport("user32.dll")>
    Public Shared Function ReleaseCapture() As Boolean
    End Function

    <DllImport("user32.dll")>
    Public Shared Function SendMessage(ByVal hWnd As IntPtr, ByVal Msg As Integer, ByVal wParam As Integer, ByVal lParam As Integer) As Integer
    End Function

    Private Sub DragForm()
        ReleaseCapture()
        SendMessage(ContainerControlForm.Handle, WM_NCLBUTTONDOWN, HTCAPTION, 0)
    End Sub

    Private Sub Titlebar_MouseDown(sender As Object, e As MouseEventArgs) Handles TitlebarControl.MouseDown
        If e.Button = Windows.Forms.MouseButtons.Left And ContainerControlForm.WindowState <> FormWindowState.Maximized Then
            DragForm()
        End If
    End Sub

    Private Sub Titlebar_MouseMove(sender As Object, e As MouseEventArgs) Handles TitlebarControl.MouseMove
        resizeDir = 0
    End Sub

    Private Sub BorderlessForm_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles ContainerControlForm.MouseDown
        If e.Button = Windows.Forms.MouseButtons.Left And ContainerControlForm.WindowState <> FormWindowState.Maximized Then
            If resizeDir <> -1 Then
                ReleaseCapture()
                SendMessage(ContainerControlForm.Handle, WM_NCLBUTTONDOWN, resizeDir, 0)
            End If
        End If
    End Sub

    Private Sub BorderlessForm_MouseMove(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles ContainerControlForm.MouseMove
        If e.Location.X > ContainerControlForm.Width - ResizeBorderWidth And e.Location.Y > ContainerControlForm.Height - ResizeBorderWidth Then
            resizeDir = HTBOTTOMRIGHT
            ContainerControlForm.Cursor = Cursors.SizeNWSE

        ElseIf e.Location.X > ContainerControlForm.Width - ResizeBorderWidth Then
            resizeDir = HTRIGHT
            ContainerControlForm.Cursor = Cursors.SizeWE

        ElseIf e.Location.Y > ContainerControlForm.Height - ResizeBorderWidth Then
            resizeDir = HTBOTTOM
            ContainerControlForm.Cursor = Cursors.SizeNS

        Else
            ContainerControlForm.Cursor = Cursors.Default
            resizeDir = -1
        End If
    End Sub

    Private Sub BorderlessForm_MouseLeave(sender As Object, e As EventArgs) Handles ContainerControlForm.MouseLeave
        ContainerControlForm.Cursor = Cursors.Default
        resizeDir = -1
    End Sub

    Private Sub btnMinimize_Click(sender As Object, e As EventArgs) Handles BtnMinControl.Click
        ContainerControlForm.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub btnMaxRest_Click(sender As Object, e As EventArgs) Handles BtnMaxControl.Click
        If ContainerControlForm.WindowState = FormWindowState.Maximized Then
            ContainerControlForm.WindowState = FormWindowState.Normal
            BtnMaxControl.Image = MaximizeBitmap
        Else
            ContainerControlForm.WindowState = FormWindowState.Maximized
            BtnMaxControl.Image = RestoreBitmap
        End If
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles BtnCloseControl.Click
        ContainerControlForm.Close()
    End Sub
End Class
