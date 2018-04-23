Namespace MessageBoxHelper
    Partial Public Class MainForm
        ''' <summary>
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.IContainer = Nothing

        ''' <summary>
        ''' Clean up any resources being used.
        ''' </summary>
        ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (components IsNot Nothing) Then
                components.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub

        #Region "Windows Form Designer generated code"

        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Me.dataLayoutControl1 = New DevExpress.XtraDataLayout.DataLayoutControl()
            Me.btnShow = New DevExpress.XtraEditors.SimpleButton()
            Me.ShowCountdownCheckEdit = New DevExpress.XtraEditors.CheckEdit()
            Me.ShowNextCheckEdit = New DevExpress.XtraEditors.CheckEdit()
            Me.DisableCancelCheckEdit = New DevExpress.XtraEditors.CheckEdit()
            Me.DisableButtonsCheckEdit = New DevExpress.XtraEditors.CheckEdit()
            Me.AutoCloseCheckEdit = New DevExpress.XtraEditors.CheckEdit()
            Me.CenterCheckEdit = New DevExpress.XtraEditors.CheckEdit()
            Me.TimeoutSpinEdit = New DevExpress.XtraEditors.SpinEdit()
            Me.ShowMessageNextTimeCheckEdit = New DevExpress.XtraEditors.CheckEdit()
            Me.TitleTextEdit = New DevExpress.XtraEditors.TextEdit()
            Me.TextTextEdit = New DevExpress.XtraEditors.TextEdit()
            Me.AutoCloseResultComboBoxEdit = New DevExpress.XtraEditors.ComboBoxEdit()
            Me.ButtonsComboBox = New DevExpress.XtraEditors.ImageComboBoxEdit()
            Me.IconComboBox = New DevExpress.XtraEditors.ComboBoxEdit()
            Me.layoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.layoutControlGroup2 = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.layoutControlGroup3 = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.layoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.emptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
            Me.ItemForShowMessageNextTime = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlGroup4 = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.ItemForCaption = New DevExpress.XtraLayout.LayoutControlItem()
            Me.ItemForIcon = New DevExpress.XtraLayout.LayoutControlItem()
            Me.ItemForButtons = New DevExpress.XtraLayout.LayoutControlItem()
            Me.ItemForText = New DevExpress.XtraLayout.LayoutControlItem()
            Me.emptySpaceItem3 = New DevExpress.XtraLayout.EmptySpaceItem()
            Me.layoutControlGroup5 = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.ItemForTimeout = New DevExpress.XtraLayout.LayoutControlItem()
            Me.ItemForDisableButtons = New DevExpress.XtraLayout.LayoutControlItem()
            Me.ItemForDisableCancel = New DevExpress.XtraLayout.LayoutControlItem()
            Me.ItemForCaptionCountdown = New DevExpress.XtraLayout.LayoutControlItem()
            Me.ItemForAutoClose = New DevExpress.XtraLayout.LayoutControlItem()
            Me.ItemForCenter = New DevExpress.XtraLayout.LayoutControlItem()
            Me.ItemForSelectNext = New DevExpress.XtraLayout.LayoutControlItem()
            Me.ItemForTimeoutResult = New DevExpress.XtraLayout.LayoutControlItem()
            Me.txtResult = New DevExpress.XtraEditors.TextEdit()
            Me.layoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.myXtraMessageArgsBindingSource = New System.Windows.Forms.BindingSource()
            DirectCast(Me.dataLayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.dataLayoutControl1.SuspendLayout()
            DirectCast(Me.ShowCountdownCheckEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.ShowNextCheckEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.DisableCancelCheckEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.DisableButtonsCheckEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.AutoCloseCheckEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.CenterCheckEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.TimeoutSpinEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.ShowMessageNextTimeCheckEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.TitleTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.TextTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.AutoCloseResultComboBoxEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.ButtonsComboBox.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.IconComboBox.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.layoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.layoutControlGroup2, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.layoutControlGroup3, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.layoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.emptySpaceItem1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.ItemForShowMessageNextTime, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.layoutControlGroup4, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.ItemForCaption, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.ItemForIcon, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.ItemForButtons, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.ItemForText, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.emptySpaceItem3, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.layoutControlGroup5, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.ItemForTimeout, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.ItemForDisableButtons, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.ItemForDisableCancel, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.ItemForCaptionCountdown, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.ItemForAutoClose, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.ItemForCenter, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.ItemForSelectNext, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.ItemForTimeoutResult, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.txtResult.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.layoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.myXtraMessageArgsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' dataLayoutControl1
            ' 
            Me.dataLayoutControl1.Controls.Add(Me.txtResult)
            Me.dataLayoutControl1.Controls.Add(Me.btnShow)
            Me.dataLayoutControl1.Controls.Add(Me.ShowCountdownCheckEdit)
            Me.dataLayoutControl1.Controls.Add(Me.ShowNextCheckEdit)
            Me.dataLayoutControl1.Controls.Add(Me.DisableCancelCheckEdit)
            Me.dataLayoutControl1.Controls.Add(Me.DisableButtonsCheckEdit)
            Me.dataLayoutControl1.Controls.Add(Me.AutoCloseCheckEdit)
            Me.dataLayoutControl1.Controls.Add(Me.CenterCheckEdit)
            Me.dataLayoutControl1.Controls.Add(Me.TimeoutSpinEdit)
            Me.dataLayoutControl1.Controls.Add(Me.ShowMessageNextTimeCheckEdit)
            Me.dataLayoutControl1.Controls.Add(Me.TitleTextEdit)
            Me.dataLayoutControl1.Controls.Add(Me.TextTextEdit)
            Me.dataLayoutControl1.Controls.Add(Me.AutoCloseResultComboBoxEdit)
            Me.dataLayoutControl1.Controls.Add(Me.ButtonsComboBox)
            Me.dataLayoutControl1.Controls.Add(Me.IconComboBox)
            Me.dataLayoutControl1.DataSource = Me.myXtraMessageArgsBindingSource
            Me.dataLayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.dataLayoutControl1.Location = New System.Drawing.Point(0, 0)
            Me.dataLayoutControl1.Name = "dataLayoutControl1"
            Me.dataLayoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(990, 245, 250, 350)
            Me.dataLayoutControl1.OptionsPrint.AppearanceGroupCaption.BackColor = System.Drawing.Color.LightGray
            Me.dataLayoutControl1.OptionsPrint.AppearanceGroupCaption.Font = New System.Drawing.Font("Tahoma", 10.25F)
            Me.dataLayoutControl1.OptionsPrint.AppearanceGroupCaption.Options.UseBackColor = True
            Me.dataLayoutControl1.OptionsPrint.AppearanceGroupCaption.Options.UseFont = True
            Me.dataLayoutControl1.OptionsPrint.AppearanceGroupCaption.Options.UseTextOptions = True
            Me.dataLayoutControl1.OptionsPrint.AppearanceGroupCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
            Me.dataLayoutControl1.OptionsPrint.AppearanceGroupCaption.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
            Me.dataLayoutControl1.OptionsPrint.AppearanceItemCaption.Options.UseTextOptions = True
            Me.dataLayoutControl1.OptionsPrint.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
            Me.dataLayoutControl1.OptionsPrint.AppearanceItemCaption.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
            Me.dataLayoutControl1.Root = Me.layoutControlGroup1
            Me.dataLayoutControl1.Size = New System.Drawing.Size(589, 362)
            Me.dataLayoutControl1.TabIndex = 0
            Me.dataLayoutControl1.Text = "dataLayoutControl1"
            ' 
            ' btnShow
            ' 
            Me.btnShow.Location = New System.Drawing.Point(289, 12)
            Me.btnShow.Name = "btnShow"
            Me.btnShow.Size = New System.Drawing.Size(288, 113)
            Me.btnShow.StyleController = Me.dataLayoutControl1
            Me.btnShow.TabIndex = 21
            Me.btnShow.Text = "Show"
            ' 
            ' ShowCountdownCheckEdit
            ' 
            Me.ShowCountdownCheckEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.myXtraMessageArgsBindingSource, "ShowCountdown", True))
            Me.ShowCountdownCheckEdit.Location = New System.Drawing.Point(180, 94)
            Me.ShowCountdownCheckEdit.Name = "ShowCountdownCheckEdit"
            Me.ShowCountdownCheckEdit.Properties.Caption = ""
            Me.ShowCountdownCheckEdit.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Center
            Me.ShowCountdownCheckEdit.Size = New System.Drawing.Size(93, 19)
            Me.ShowCountdownCheckEdit.StyleController = Me.dataLayoutControl1
            Me.ShowCountdownCheckEdit.TabIndex = 4
            ' 
            ' ShowNextCheckEdit
            ' 
            Me.ShowNextCheckEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.myXtraMessageArgsBindingSource, "ShowNextTime", True))
            Me.ShowNextCheckEdit.Location = New System.Drawing.Point(180, 187)
            Me.ShowNextCheckEdit.Name = "ShowNextCheckEdit"
            Me.ShowNextCheckEdit.Properties.Caption = ""
            Me.ShowNextCheckEdit.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Center
            Me.ShowNextCheckEdit.Size = New System.Drawing.Size(93, 19)
            Me.ShowNextCheckEdit.StyleController = Me.dataLayoutControl1
            Me.ShowNextCheckEdit.TabIndex = 5
            ' 
            ' DisableCancelCheckEdit
            ' 
            Me.DisableCancelCheckEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.myXtraMessageArgsBindingSource, "DisableCancel", True))
            Me.DisableCancelCheckEdit.Location = New System.Drawing.Point(180, 71)
            Me.DisableCancelCheckEdit.Name = "DisableCancelCheckEdit"
            Me.DisableCancelCheckEdit.Properties.Caption = ""
            Me.DisableCancelCheckEdit.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Center
            Me.DisableCancelCheckEdit.Size = New System.Drawing.Size(93, 19)
            Me.DisableCancelCheckEdit.StyleController = Me.dataLayoutControl1
            Me.DisableCancelCheckEdit.TabIndex = 6
            ' 
            ' DisableButtonsCheckEdit
            ' 
            Me.DisableButtonsCheckEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.myXtraMessageArgsBindingSource, "DisableButtons", True))
            Me.DisableButtonsCheckEdit.Location = New System.Drawing.Point(180, 48)
            Me.DisableButtonsCheckEdit.Name = "DisableButtonsCheckEdit"
            Me.DisableButtonsCheckEdit.Properties.Caption = ""
            Me.DisableButtonsCheckEdit.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Center
            Me.DisableButtonsCheckEdit.Size = New System.Drawing.Size(93, 19)
            Me.DisableButtonsCheckEdit.StyleController = Me.dataLayoutControl1
            Me.DisableButtonsCheckEdit.TabIndex = 7
            ' 
            ' AutoCloseCheckEdit
            ' 
            Me.AutoCloseCheckEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.myXtraMessageArgsBindingSource, "AutoClose", True))
            Me.AutoCloseCheckEdit.Location = New System.Drawing.Point(180, 117)
            Me.AutoCloseCheckEdit.Name = "AutoCloseCheckEdit"
            Me.AutoCloseCheckEdit.Properties.Caption = ""
            Me.AutoCloseCheckEdit.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Center
            Me.AutoCloseCheckEdit.Size = New System.Drawing.Size(93, 19)
            Me.AutoCloseCheckEdit.StyleController = Me.dataLayoutControl1
            Me.AutoCloseCheckEdit.TabIndex = 8
            ' 
            ' CenterCheckEdit
            ' 
            Me.CenterCheckEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.myXtraMessageArgsBindingSource, "Center", True))
            Me.CenterCheckEdit.Location = New System.Drawing.Point(180, 164)
            Me.CenterCheckEdit.Name = "CenterCheckEdit"
            Me.CenterCheckEdit.Properties.Caption = ""
            Me.CenterCheckEdit.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Center
            Me.CenterCheckEdit.Size = New System.Drawing.Size(93, 19)
            Me.CenterCheckEdit.StyleController = Me.dataLayoutControl1
            Me.CenterCheckEdit.TabIndex = 10
            ' 
            ' TimeoutSpinEdit
            ' 
            Me.TimeoutSpinEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.myXtraMessageArgsBindingSource, "Timeout", True))
            Me.TimeoutSpinEdit.EditValue = New Decimal(New Integer() { 0, 0, 0, 0})
            Me.TimeoutSpinEdit.Location = New System.Drawing.Point(180, 24)
            Me.TimeoutSpinEdit.Name = "TimeoutSpinEdit"
            Me.TimeoutSpinEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.TimeoutSpinEdit.Size = New System.Drawing.Size(93, 20)
            Me.TimeoutSpinEdit.StyleController = Me.dataLayoutControl1
            Me.TimeoutSpinEdit.TabIndex = 11
            ' 
            ' ShowMessageNextTimeCheckEdit
            ' 
            Me.ShowMessageNextTimeCheckEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.myXtraMessageArgsBindingSource, "ShowMessageNextTime", True))
            Me.ShowMessageNextTimeCheckEdit.Location = New System.Drawing.Point(445, 129)
            Me.ShowMessageNextTimeCheckEdit.Name = "ShowMessageNextTimeCheckEdit"
            Me.ShowMessageNextTimeCheckEdit.Properties.Caption = "Show Message Next Time"
            Me.ShowMessageNextTimeCheckEdit.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Center
            Me.ShowMessageNextTimeCheckEdit.Size = New System.Drawing.Size(132, 19)
            Me.ShowMessageNextTimeCheckEdit.StyleController = Me.dataLayoutControl1
            Me.ShowMessageNextTimeCheckEdit.TabIndex = 12
            ' 
            ' TitleTextEdit
            ' 
            Me.TitleTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.myXtraMessageArgsBindingSource, "Caption", True))
            Me.TitleTextEdit.Location = New System.Drawing.Point(180, 234)
            Me.TitleTextEdit.Name = "TitleTextEdit"
            Me.TitleTextEdit.Size = New System.Drawing.Size(93, 20)
            Me.TitleTextEdit.StyleController = Me.dataLayoutControl1
            Me.TitleTextEdit.TabIndex = 16
            ' 
            ' TextTextEdit
            ' 
            Me.TextTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.myXtraMessageArgsBindingSource, "Text", True))
            Me.TextTextEdit.Location = New System.Drawing.Point(180, 258)
            Me.TextTextEdit.Name = "TextTextEdit"
            Me.TextTextEdit.Size = New System.Drawing.Size(93, 20)
            Me.TextTextEdit.StyleController = Me.dataLayoutControl1
            Me.TextTextEdit.TabIndex = 17
            ' 
            ' AutoCloseResultComboBoxEdit
            ' 
            Me.AutoCloseResultComboBoxEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.myXtraMessageArgsBindingSource, "AutoCloseResult", True))
            Me.AutoCloseResultComboBoxEdit.Location = New System.Drawing.Point(180, 140)
            Me.AutoCloseResultComboBoxEdit.Name = "AutoCloseResultComboBoxEdit"
            Me.AutoCloseResultComboBoxEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.AutoCloseResultComboBoxEdit.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
            Me.AutoCloseResultComboBoxEdit.Size = New System.Drawing.Size(93, 20)
            Me.AutoCloseResultComboBoxEdit.StyleController = Me.dataLayoutControl1
            Me.AutoCloseResultComboBoxEdit.TabIndex = 9
            ' 
            ' ButtonsComboBox
            ' 
            Me.ButtonsComboBox.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.myXtraMessageArgsBindingSource, "Buttons", True))
            Me.ButtonsComboBox.Location = New System.Drawing.Point(180, 306)
            Me.ButtonsComboBox.Name = "ButtonsComboBox"
            Me.ButtonsComboBox.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.ButtonsComboBox.Size = New System.Drawing.Size(93, 20)
            Me.ButtonsComboBox.StyleController = Me.dataLayoutControl1
            Me.ButtonsComboBox.TabIndex = 20
            ' 
            ' IconComboBox
            ' 
            Me.IconComboBox.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.myXtraMessageArgsBindingSource, "Icon", True))
            Me.IconComboBox.Location = New System.Drawing.Point(180, 282)
            Me.IconComboBox.Name = "IconComboBox"
            Me.IconComboBox.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.IconComboBox.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
            Me.IconComboBox.Size = New System.Drawing.Size(93, 20)
            Me.IconComboBox.StyleController = Me.dataLayoutControl1
            Me.IconComboBox.TabIndex = 15
            Me.IconComboBox.TabStop = False
            ' 
            ' layoutControlGroup1
            ' 
            Me.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True
            Me.layoutControlGroup1.GroupBordersVisible = False
            Me.layoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() { Me.layoutControlGroup2})
            Me.layoutControlGroup1.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlGroup1.Name = "Root"
            Me.layoutControlGroup1.OptionsItemText.AlignControlsWithHiddenText = True
            Me.layoutControlGroup1.Size = New System.Drawing.Size(589, 362)
            Me.layoutControlGroup1.TextVisible = False
            ' 
            ' layoutControlGroup2
            ' 
            Me.layoutControlGroup2.AllowDrawBackground = False
            Me.layoutControlGroup2.GroupBordersVisible = False
            Me.layoutControlGroup2.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() { Me.layoutControlGroup3, Me.layoutControlGroup4, Me.layoutControlGroup5})
            Me.layoutControlGroup2.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlGroup2.Name = "autoGeneratedGroup0"
            Me.layoutControlGroup2.Size = New System.Drawing.Size(569, 342)
            ' 
            ' layoutControlGroup3
            ' 
            Me.layoutControlGroup3.GroupBordersVisible = False
            Me.layoutControlGroup3.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() { Me.layoutControlItem1, Me.emptySpaceItem1, Me.ItemForShowMessageNextTime, Me.layoutControlItem2})
            Me.layoutControlGroup3.Location = New System.Drawing.Point(277, 0)
            Me.layoutControlGroup3.Name = "layoutControlGroup3"
            Me.layoutControlGroup3.Size = New System.Drawing.Size(292, 342)
            Me.layoutControlGroup3.Spacing = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
            Me.layoutControlGroup3.TextVisible = False
            ' 
            ' layoutControlItem1
            ' 
            Me.layoutControlItem1.Control = Me.btnShow
            Me.layoutControlItem1.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlItem1.MinSize = New System.Drawing.Size(82, 26)
            Me.layoutControlItem1.Name = "layoutControlItem1"
            Me.layoutControlItem1.Size = New System.Drawing.Size(292, 117)
            Me.layoutControlItem1.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
            Me.layoutControlItem1.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize
            Me.layoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
            Me.layoutControlItem1.TextToControlDistance = 0
            Me.layoutControlItem1.TextVisible = False
            ' 
            ' emptySpaceItem1
            ' 
            Me.emptySpaceItem1.AllowHotTrack = False
            Me.emptySpaceItem1.Location = New System.Drawing.Point(0, 164)
            Me.emptySpaceItem1.Name = "emptySpaceItem1"
            Me.emptySpaceItem1.Size = New System.Drawing.Size(292, 178)
            Me.emptySpaceItem1.TextSize = New System.Drawing.Size(153, 0)
            ' 
            ' ItemForShowMessageNextTime
            ' 
            Me.ItemForShowMessageNextTime.Control = Me.ShowMessageNextTimeCheckEdit
            Me.ItemForShowMessageNextTime.Location = New System.Drawing.Point(0, 117)
            Me.ItemForShowMessageNextTime.Name = "ItemForShowMessageNextTime"
            Me.ItemForShowMessageNextTime.Size = New System.Drawing.Size(292, 23)
            Me.ItemForShowMessageNextTime.Text = "Show Message Next Time"
            Me.ItemForShowMessageNextTime.TextSize = New System.Drawing.Size(153, 13)
            ' 
            ' layoutControlGroup4
            ' 
            Me.layoutControlGroup4.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() { Me.ItemForCaption, Me.ItemForIcon, Me.ItemForButtons, Me.ItemForText, Me.emptySpaceItem3})
            Me.layoutControlGroup4.Location = New System.Drawing.Point(0, 210)
            Me.layoutControlGroup4.Name = "layoutControlGroup4"
            Me.layoutControlGroup4.Size = New System.Drawing.Size(277, 132)
            Me.layoutControlGroup4.TextVisible = False
            ' 
            ' ItemForCaption
            ' 
            Me.ItemForCaption.Control = Me.TitleTextEdit
            Me.ItemForCaption.Location = New System.Drawing.Point(0, 0)
            Me.ItemForCaption.Name = "ItemForCaption"
            Me.ItemForCaption.Size = New System.Drawing.Size(253, 24)
            Me.ItemForCaption.Text = "Message Title"
            Me.ItemForCaption.TextSize = New System.Drawing.Size(153, 13)
            ' 
            ' ItemForIcon
            ' 
            Me.ItemForIcon.Control = Me.IconComboBox
            Me.ItemForIcon.Location = New System.Drawing.Point(0, 48)
            Me.ItemForIcon.Name = "ItemForIcon"
            Me.ItemForIcon.Size = New System.Drawing.Size(253, 24)
            Me.ItemForIcon.StartNewLine = True
            Me.ItemForIcon.Text = "Message Icon"
            Me.ItemForIcon.TextSize = New System.Drawing.Size(153, 13)
            ' 
            ' ItemForButtons
            ' 
            Me.ItemForButtons.Control = Me.ButtonsComboBox
            Me.ItemForButtons.Location = New System.Drawing.Point(0, 72)
            Me.ItemForButtons.Name = "ItemForButtons"
            Me.ItemForButtons.Size = New System.Drawing.Size(253, 24)
            Me.ItemForButtons.Text = "Message Buttons"
            Me.ItemForButtons.TextSize = New System.Drawing.Size(153, 13)
            ' 
            ' ItemForText
            ' 
            Me.ItemForText.Control = Me.TextTextEdit
            Me.ItemForText.Location = New System.Drawing.Point(0, 24)
            Me.ItemForText.Name = "ItemForText"
            Me.ItemForText.Size = New System.Drawing.Size(253, 24)
            Me.ItemForText.Text = "Message Text"
            Me.ItemForText.TextSize = New System.Drawing.Size(153, 13)
            ' 
            ' emptySpaceItem3
            ' 
            Me.emptySpaceItem3.AllowHotTrack = False
            Me.emptySpaceItem3.Location = New System.Drawing.Point(0, 96)
            Me.emptySpaceItem3.Name = "emptySpaceItem3"
            Me.emptySpaceItem3.Size = New System.Drawing.Size(253, 12)
            Me.emptySpaceItem3.TextSize = New System.Drawing.Size(153, 0)
            ' 
            ' layoutControlGroup5
            ' 
            Me.layoutControlGroup5.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() { Me.ItemForTimeout, Me.ItemForDisableButtons, Me.ItemForDisableCancel, Me.ItemForCaptionCountdown, Me.ItemForAutoClose, Me.ItemForCenter, Me.ItemForSelectNext, Me.ItemForTimeoutResult})
            Me.layoutControlGroup5.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlGroup5.Name = "layoutControlGroup5"
            Me.layoutControlGroup5.Size = New System.Drawing.Size(277, 210)
            Me.layoutControlGroup5.TextVisible = False
            ' 
            ' ItemForTimeout
            ' 
            Me.ItemForTimeout.Control = Me.TimeoutSpinEdit
            Me.ItemForTimeout.Location = New System.Drawing.Point(0, 0)
            Me.ItemForTimeout.Name = "ItemForTimeout"
            Me.ItemForTimeout.Size = New System.Drawing.Size(253, 24)
            Me.ItemForTimeout.Text = "Timeout(sec)"
            Me.ItemForTimeout.TextSize = New System.Drawing.Size(153, 13)
            ' 
            ' ItemForDisableButtons
            ' 
            Me.ItemForDisableButtons.Control = Me.DisableButtonsCheckEdit
            Me.ItemForDisableButtons.Location = New System.Drawing.Point(0, 24)
            Me.ItemForDisableButtons.Name = "ItemForDisableButtons"
            Me.ItemForDisableButtons.Size = New System.Drawing.Size(253, 23)
            Me.ItemForDisableButtons.Text = "Disable Buttons (except Cancel)"
            Me.ItemForDisableButtons.TextSize = New System.Drawing.Size(153, 13)
            ' 
            ' ItemForDisableCancel
            ' 
            Me.ItemForDisableCancel.Control = Me.DisableCancelCheckEdit
            Me.ItemForDisableCancel.Location = New System.Drawing.Point(0, 47)
            Me.ItemForDisableCancel.Name = "ItemForDisableCancel"
            Me.ItemForDisableCancel.Size = New System.Drawing.Size(253, 23)
            Me.ItemForDisableCancel.Text = "Disable Cancel"
            Me.ItemForDisableCancel.TextSize = New System.Drawing.Size(153, 13)
            ' 
            ' ItemForCaptionCountdown
            ' 
            Me.ItemForCaptionCountdown.Control = Me.ShowCountdownCheckEdit
            Me.ItemForCaptionCountdown.Location = New System.Drawing.Point(0, 70)
            Me.ItemForCaptionCountdown.Name = "ItemForCaptionCountdown"
            Me.ItemForCaptionCountdown.Size = New System.Drawing.Size(253, 23)
            Me.ItemForCaptionCountdown.Text = "Show Countdown in Title"
            Me.ItemForCaptionCountdown.TextSize = New System.Drawing.Size(153, 13)
            ' 
            ' ItemForAutoClose
            ' 
            Me.ItemForAutoClose.Control = Me.AutoCloseCheckEdit
            Me.ItemForAutoClose.Location = New System.Drawing.Point(0, 93)
            Me.ItemForAutoClose.Name = "ItemForAutoClose"
            Me.ItemForAutoClose.Size = New System.Drawing.Size(253, 23)
            Me.ItemForAutoClose.Text = "Auto Close"
            Me.ItemForAutoClose.TextSize = New System.Drawing.Size(153, 13)
            ' 
            ' ItemForCenter
            ' 
            Me.ItemForCenter.Control = Me.CenterCheckEdit
            Me.ItemForCenter.Location = New System.Drawing.Point(0, 140)
            Me.ItemForCenter.Name = "ItemForCenter"
            Me.ItemForCenter.Size = New System.Drawing.Size(253, 23)
            Me.ItemForCenter.Text = "Center on Parent"
            Me.ItemForCenter.TextSize = New System.Drawing.Size(153, 13)
            ' 
            ' ItemForSelectNext
            ' 
            Me.ItemForSelectNext.Control = Me.ShowNextCheckEdit
            Me.ItemForSelectNext.Location = New System.Drawing.Point(0, 163)
            Me.ItemForSelectNext.Name = "ItemForSelectNext"
            Me.ItemForSelectNext.Size = New System.Drawing.Size(253, 23)
            Me.ItemForSelectNext.Text = "Show NextTime CheckBox"
            Me.ItemForSelectNext.TextSize = New System.Drawing.Size(153, 13)
            ' 
            ' ItemForTimeoutResult
            ' 
            Me.ItemForTimeoutResult.Control = Me.AutoCloseResultComboBoxEdit
            Me.ItemForTimeoutResult.Location = New System.Drawing.Point(0, 116)
            Me.ItemForTimeoutResult.Name = "ItemForTimeoutResult"
            Me.ItemForTimeoutResult.Size = New System.Drawing.Size(253, 24)
            Me.ItemForTimeoutResult.Text = "Auto-Close Result"
            Me.ItemForTimeoutResult.TextSize = New System.Drawing.Size(153, 13)
            ' 
            ' txtResult
            ' 
            Me.txtResult.Location = New System.Drawing.Point(445, 152)
            Me.txtResult.Name = "txtResult"
            Me.txtResult.Size = New System.Drawing.Size(132, 20)
            Me.txtResult.StyleController = Me.dataLayoutControl1
            Me.txtResult.TabIndex = 22
            ' 
            ' layoutControlItem2
            ' 
            Me.layoutControlItem2.Control = Me.txtResult
            Me.layoutControlItem2.Location = New System.Drawing.Point(0, 140)
            Me.layoutControlItem2.Name = "layoutControlItem2"
            Me.layoutControlItem2.Size = New System.Drawing.Size(292, 24)
            Me.layoutControlItem2.Text = "Message Result"
            Me.layoutControlItem2.TextSize = New System.Drawing.Size(153, 13)
            ' 
            ' myXtraMessageArgsBindingSource
            ' 
            Me.myXtraMessageArgsBindingSource.DataSource = GetType(MessageBoxHelper.MyXtraMessageArgs)
            ' 
            ' MainForm
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(589, 362)
            Me.Controls.Add(Me.dataLayoutControl1)
            Me.Name = "MainForm"
            Me.Text = "MainForm"
            DirectCast(Me.dataLayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.dataLayoutControl1.ResumeLayout(False)
            DirectCast(Me.ShowCountdownCheckEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.ShowNextCheckEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.DisableCancelCheckEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.DisableButtonsCheckEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.AutoCloseCheckEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.CenterCheckEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.TimeoutSpinEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.ShowMessageNextTimeCheckEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.TitleTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.TextTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.AutoCloseResultComboBoxEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.ButtonsComboBox.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.IconComboBox.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.layoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.layoutControlGroup2, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.layoutControlGroup3, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.layoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.emptySpaceItem1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.ItemForShowMessageNextTime, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.layoutControlGroup4, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.ItemForCaption, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.ItemForIcon, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.ItemForButtons, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.ItemForText, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.emptySpaceItem3, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.layoutControlGroup5, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.ItemForTimeout, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.ItemForDisableButtons, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.ItemForDisableCancel, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.ItemForCaptionCountdown, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.ItemForAutoClose, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.ItemForCenter, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.ItemForSelectNext, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.ItemForTimeoutResult, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.txtResult.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.layoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.myXtraMessageArgsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

        #End Region

        Private dataLayoutControl1 As DevExpress.XtraDataLayout.DataLayoutControl
        Private ShowCountdownCheckEdit As DevExpress.XtraEditors.CheckEdit
        Private myXtraMessageArgsBindingSource As System.Windows.Forms.BindingSource
        Private ShowNextCheckEdit As DevExpress.XtraEditors.CheckEdit
        Private DisableCancelCheckEdit As DevExpress.XtraEditors.CheckEdit
        Private DisableButtonsCheckEdit As DevExpress.XtraEditors.CheckEdit
        Private WithEvents AutoCloseCheckEdit As DevExpress.XtraEditors.CheckEdit
        Private CenterCheckEdit As DevExpress.XtraEditors.CheckEdit
        Private WithEvents TimeoutSpinEdit As DevExpress.XtraEditors.SpinEdit
        Private WithEvents ShowMessageNextTimeCheckEdit As DevExpress.XtraEditors.CheckEdit
        Private TitleTextEdit As DevExpress.XtraEditors.TextEdit
        Private TextTextEdit As DevExpress.XtraEditors.TextEdit
        Private layoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
        Private layoutControlGroup2 As DevExpress.XtraLayout.LayoutControlGroup
        Private ItemForCaptionCountdown As DevExpress.XtraLayout.LayoutControlItem
        Private ItemForSelectNext As DevExpress.XtraLayout.LayoutControlItem
        Private ItemForDisableCancel As DevExpress.XtraLayout.LayoutControlItem
        Private ItemForDisableButtons As DevExpress.XtraLayout.LayoutControlItem
        Private ItemForAutoClose As DevExpress.XtraLayout.LayoutControlItem
        Private ItemForTimeoutResult As DevExpress.XtraLayout.LayoutControlItem
        Private ItemForCenter As DevExpress.XtraLayout.LayoutControlItem
        Private ItemForTimeout As DevExpress.XtraLayout.LayoutControlItem
        Private ItemForShowMessageNextTime As DevExpress.XtraLayout.LayoutControlItem
        Private ItemForIcon As DevExpress.XtraLayout.LayoutControlItem
        Private ItemForCaption As DevExpress.XtraLayout.LayoutControlItem
        Private ItemForText As DevExpress.XtraLayout.LayoutControlItem
        Private ItemForButtons As DevExpress.XtraLayout.LayoutControlItem
        Private AutoCloseResultComboBoxEdit As DevExpress.XtraEditors.ComboBoxEdit
        Private WithEvents btnShow As DevExpress.XtraEditors.SimpleButton
        Private layoutControlGroup3 As DevExpress.XtraLayout.LayoutControlGroup
        Private layoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
        Private emptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem
        Private layoutControlGroup4 As DevExpress.XtraLayout.LayoutControlGroup
        Private WithEvents ButtonsComboBox As DevExpress.XtraEditors.ImageComboBoxEdit
        Private IconComboBox As DevExpress.XtraEditors.ComboBoxEdit
        Private emptySpaceItem3 As DevExpress.XtraLayout.EmptySpaceItem
        Private layoutControlGroup5 As DevExpress.XtraLayout.LayoutControlGroup
        Private txtResult As DevExpress.XtraEditors.TextEdit
        Private layoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem

    End Class
End Namespace