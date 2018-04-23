using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MessageBoxHelper {
    public partial class MainForm : Form {
        public MainForm() {
            InitializeComponent();
            myXtraMessageArgsBindingSource.DataSource = new MyXtraMessageArgs();
            AutoCloseCheckEdit.Enabled = false;
            ShowCountdownCheckEdit.Enabled = false;
            ButtonsComboBox.Properties.Items.AddEnum(typeof(MessageBoxButtons));
            AutoCloseResultComboBoxEdit.Enabled = AutoCloseCheckEdit.Checked;
            foreach (string iconName in Enum.GetNames(typeof(MessageBoxIcon)))
                IconComboBox.Properties.Items.Add(iconName);
        }

        void UpdateAutoClose() {
            AutoCloseResultComboBoxEdit.Properties.Items.Clear();
            AutoCloseResultComboBoxEdit.EditValue = null;
            if (!AutoCloseResultComboBoxEdit.Enabled)
                return;
            if (ButtonsComboBox.EditValue != null) {
                DialogResult[] buttons = MyXtraMessageBox.GetDialogResultsFromButtons((MessageBoxButtons)ButtonsComboBox.EditValue);
                AutoCloseResultComboBoxEdit.Properties.Items.AddRange(buttons);
            } else
                AutoCloseResultComboBoxEdit.Properties.Items.Add(DialogResult.OK);
        }

        private void ButtonsComboBox_EditValueChanged(object sender, EventArgs e) {
            UpdateAutoClose();
        }

        private void btnShow_Click(object sender, EventArgs e) {
            DialogResult result = MyXtraMessageBox.Show(myXtraMessageArgsBindingSource.DataSource as MyXtraMessageArgs);
            txtResult.Text = result.ToString();
            myXtraMessageArgsBindingSource.ResetBindings(false);
        }

        private void AutoCloseCheckEdit_CheckedChanged(object sender, EventArgs e) {
            AutoCloseResultComboBoxEdit.Enabled = AutoCloseCheckEdit.Checked;
            UpdateAutoClose();
        }

        private void TimeoutSpinEdit_EditValueChanged(object sender, EventArgs e) {
            if (Convert.ToInt32(TimeoutSpinEdit.EditValue) <= 0) {
                AutoCloseCheckEdit.Checked = false;
                AutoCloseCheckEdit.Enabled = false;
                ShowCountdownCheckEdit.Checked = false;
                ShowCountdownCheckEdit.Enabled = false;
            } else {
                AutoCloseCheckEdit.Enabled = true;
                ShowCountdownCheckEdit.Enabled = true;
            }
        }

        private void ShowMessageNextTimeCheckEdit_EditValueChanged(object sender, EventArgs e) {

        }
    }
}
