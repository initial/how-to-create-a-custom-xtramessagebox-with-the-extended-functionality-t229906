Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Drawing
Imports System.Text
Imports System.Threading.Tasks
Imports System.Windows.Forms
Imports DevExpress.XtraEditors

Namespace MessageBoxHelper.Internal
    Public Class MyXtraMessageBoxForm
        Inherits DevExpress.XtraEditors.XtraMessageBoxForm

        Private CountdownTimer As Timer
        Private countDownCaption As Boolean
        Private autoClose As Boolean
        Private timeout As Integer
        Private timeoutResult As DialogResult
        Private baseCaption As String
        Private captionWasCoped As Boolean
        Private selectNext As Boolean
        Private disablebttns As Boolean
        Private disableCancel As Boolean
        Private center As Boolean
        Public ShowMessageNextTime As Boolean

        Private cbShowNextTime As CheckEdit
        Public Sub New()
            MyBase.New()
            baseCaption = ""
            CountdownTimer = New Timer()
            CountdownTimer.Tag = Me
            CountdownTimer.Interval = 1000
            AddHandler CountdownTimer.Tick, AddressOf MyTimer_Tick
            captionWasCoped = False
        End Sub

        Protected Overrides Sub OnShown(ByVal e As EventArgs)
            If countDownCaption Then
                Me.Text = "Remain " & timeout & " sec"
            End If
            If selectNext Then
                ShowNextTime()
            End If
            Dim btnCancel As IButtonControl = Nothing
            If (Me.CancelButton IsNot Nothing) AndAlso (Me.CancelButton.DialogResult = DialogResult.Cancel) Then
                btnCancel = Me.CancelButton
            End If
            If disablebttns Then
                DisableAllExceptCancel(TryCast(btnCancel, SimpleButton))
            End If
            If (disableCancel) AndAlso (btnCancel IsNot Nothing) Then
                TryCast(btnCancel, SimpleButton).Enabled = False
            End If
            If center Then
                CenterOnParent()
            End If
            If Me.timeout > 0 Then
                Me.CountdownTimer.Enabled = True
                Me.CountdownTimer.Start()
            End If
            MyBase.OnShown(e)
        End Sub

        Private Sub DisableAllExceptCancel(ByVal btnCancel As SimpleButton)
            For Each cont As Control In Me.Controls
                If (TypeOf cont Is BaseButton) AndAlso (cont IsNot (TryCast(btnCancel, SimpleButton))) Then
                    cont.Enabled = False
                End If
            Next cont
        End Sub

        Private Sub MyTimer_Tick(ByVal sender As Object, ByVal e As EventArgs)
            If Not captionWasCoped Then
                baseCaption = Me.Message.Caption
                captionWasCoped = True
            End If
            Dim messageTimer As Timer = (TryCast(sender, Timer))
            timeout -= 1
            If (countDownCaption) AndAlso (timeout > 0) Then
                Me.Text = "Remain " & timeout & " sec"
            ElseIf countDownCaption Then
                Me.Text = baseCaption
            End If
            If timeout <= 0 Then
                Me.Message.Caption = baseCaption
                messageTimer.Stop()
                messageTimer.Enabled = False
                If autoClose Then
                    Me.DialogResult = timeoutResult
                    MyBase.Close()
                End If
            End If
        End Sub

        Public Function ShowForm(ByVal messageArgs As MyXtraMessageArgs) As DialogResult
            selectNext = messageArgs.ShowNextTime
            disablebttns = messageArgs.DisableButtons
            disableCancel = messageArgs.DisableCancel
            autoClose = messageArgs.AutoClose
            countDownCaption = messageArgs.ShowCountdown
            timeout = messageArgs.Timeout
            center = messageArgs.Center
            timeoutResult = messageArgs.AutoCloseResult

            Return MyBase.ShowMessageBoxDialog(messageArgs)
        End Function

        Protected Overrides Sub OnClosing(ByVal e As System.ComponentModel.CancelEventArgs)
            If cbShowNextTime IsNot Nothing Then
                Me.ShowMessageNextTime = cbShowNextTime.Checked
            End If
            Me.CountdownTimer.Stop()
            Me.CountdownTimer.Dispose()
            MyBase.OnClosing(e)
        End Sub

        Private Sub ShowNextTime()
            cbShowNextTime = New CheckEdit()
            cbShowNextTime.Checked = True
            cbShowNextTime.Text = "Show this dialog again?"
            cbShowNextTime.Properties.AutoWidth = True
            cbShowNextTime.Properties.AutoHeight = True
            Me.Height += cbShowNextTime.Height
            cbShowNextTime.Location = New Point(1, Me.ClientSize.Height - cbShowNextTime.Height - 1)
            Me.Controls.Add(cbShowNextTime)
        End Sub

        Private Sub CenterOnParent()
            Dim y As Integer = Me.Owner.Height - Me.Height
            Dim x As Integer = Me.Owner.Width - Me.Width
            Me.Location = New Point(x \ 2 + Me.Owner.Location.X, y \ 2 + Me.Owner.Location.Y)
        End Sub
    End Class
End Namespace
