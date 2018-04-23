Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks
Imports System.Windows.Forms

Namespace MessageBoxHelper
    Partial Public Class MainForm
        Inherits Form

        Public Sub New()
            InitializeComponent()
            myXtraMessageArgsBindingSource.DataSource = New MyXtraMessageArgs()
            AutoCloseCheckEdit.Enabled = False
            ShowCountdownCheckEdit.Enabled = False
            ButtonsComboBox.Properties.Items.AddEnum(GetType(MessageBoxButtons))
            AutoCloseResultComboBoxEdit.Enabled = AutoCloseCheckEdit.Checked
            For Each iconName As String In System.Enum.GetNames(GetType(MessageBoxIcon))
                IconComboBox.Properties.Items.Add(iconName)
            Next iconName
        End Sub

        Private Sub UpdateAutoClose()
            AutoCloseResultComboBoxEdit.Properties.Items.Clear()
            AutoCloseResultComboBoxEdit.EditValue = Nothing
            If Not AutoCloseResultComboBoxEdit.Enabled Then
                Return
            End If
            If ButtonsComboBox.EditValue IsNot Nothing Then
                Dim buttons() As DialogResult = MyXtraMessageBox.GetDialogResultsFromButtons(CType(ButtonsComboBox.EditValue, MessageBoxButtons))
                AutoCloseResultComboBoxEdit.Properties.Items.AddRange(buttons)
            Else
                AutoCloseResultComboBoxEdit.Properties.Items.Add(System.Windows.Forms.DialogResult.OK)
            End If
        End Sub

        Private Sub ButtonsComboBox_EditValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles ButtonsComboBox.EditValueChanged
            UpdateAutoClose()
        End Sub

        Private Sub btnShow_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnShow.Click
            Dim result As DialogResult = MyXtraMessageBox.Show(TryCast(myXtraMessageArgsBindingSource.DataSource, MyXtraMessageArgs))
            txtResult.Text = result.ToString()
            myXtraMessageArgsBindingSource.ResetBindings(False)
        End Sub

        Private Sub AutoCloseCheckEdit_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles AutoCloseCheckEdit.CheckedChanged
            AutoCloseResultComboBoxEdit.Enabled = AutoCloseCheckEdit.Checked
            UpdateAutoClose()
        End Sub

        Private Sub TimeoutSpinEdit_EditValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles TimeoutSpinEdit.EditValueChanged
            If Convert.ToInt32(TimeoutSpinEdit.EditValue) <= 0 Then
                AutoCloseCheckEdit.Checked = False
                AutoCloseCheckEdit.Enabled = False
                ShowCountdownCheckEdit.Checked = False
                ShowCountdownCheckEdit.Enabled = False
            Else
                AutoCloseCheckEdit.Enabled = True
                ShowCountdownCheckEdit.Enabled = True
            End If
        End Sub

        Private Sub ShowMessageNextTimeCheckEdit_EditValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles ShowMessageNextTimeCheckEdit.EditValueChanged

        End Sub
    End Class
End Namespace
