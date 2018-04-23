Imports DevExpress.XtraEditors
Imports MessageBoxHelper.Internal
Imports System
Imports System.Collections.Generic
Imports System.Drawing
Imports System.Linq
Imports System.Reflection
Imports System.Text
Imports System.Threading.Tasks
Imports System.Windows.Forms

Namespace MessageBoxHelper
    Public NotInheritable Class MyXtraMessageBox

        Private Sub New()
        End Sub

        Public Shared Function Show(ByVal options As MyXtraMessageArgs) As DialogResult
            Dim messageForm As New MyXtraMessageBoxForm()
            Dim result As DialogResult = messageForm.ShowForm(options)
            options.ShowMessageNextTime = messageForm.ShowMessageNextTime
            Return result
        End Function

        Public Shared Function GetDialogResultsFromButtons(ByVal buttons As MessageBoxButtons) As DialogResult()
            Dim xtraMessageBoxInfo As MethodInfo = GetType(XtraMessageBox).GetMethod("MessageBoxButtonsToDialogResults", BindingFlags.Static Or BindingFlags.NonPublic Or BindingFlags.Public)
            Return DirectCast(xtraMessageBoxInfo.Invoke(Nothing, New Object() { buttons }), DialogResult())
        End Function

        Public Shared Function GetIcon(ByVal iconInfo As String) As Icon
            Dim icon As Object = System.Enum.Parse(GetType(MessageBoxIcon), iconInfo)
            Dim xtraMessageBoxInfo As MethodInfo = GetType(XtraMessageBox).GetMethod("MessageBoxIconToIcon", BindingFlags.Static Or BindingFlags.NonPublic Or BindingFlags.Public)
            icon = xtraMessageBoxInfo.Invoke(Nothing, New Object() { icon })
            Return DirectCast(icon, Icon)
        End Function
    End Class
End Namespace
