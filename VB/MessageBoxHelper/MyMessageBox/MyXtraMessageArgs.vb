Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Windows.Forms
Imports DevExpress.XtraEditors
Imports System.ComponentModel

Namespace MessageBoxHelper
    Public Class MyXtraMessageArgs
        Inherits XtraMessageBoxArgs

        Public Property ShowCountdown() As Boolean
        Public Property ShowNextTime() As Boolean
        Public Property DisableCancel() As Boolean
        Public Property DisableButtons() As Boolean
        Public Property AutoClose() As Boolean
        Public Property AutoCloseResult() As DialogResult
        Public Property Center() As Boolean
        Public Property Timeout() As Integer
        Public Property ShowMessageNextTime() As Boolean
        Private fButtons As MessageBoxButtons
        Public Shadows Property Buttons() As MessageBoxButtons
            Get
                Return Me.fButtons
            End Get
            Set(ByVal value As MessageBoxButtons)
                MyBase.Buttons = MyXtraMessageBox.GetDialogResultsFromButtons(value)
                Me.fButtons = value
            End Set
        End Property

        Private fIcon As String
        Public Shadows Property Icon() As String
            Get
                Return fIcon
            End Get
            Set(ByVal value As String)
                fIcon = value
                MyBase.Icon = MyXtraMessageBox.GetIcon(value)
            End Set
        End Property

        Public Sub New()
            MyBase.New()
            Me.Buttons = MessageBoxButtons.OK
            Me.ShowCountdown = False
            Me.ShowNextTime = False
            Me.DisableButtons = False
            Me.DisableCancel = False
            Me.AutoClose = False
            Me.Center = False
            Me.Timeout = 0
            Me.ShowMessageNextTime = False
        End Sub
    End Class
End Namespace
