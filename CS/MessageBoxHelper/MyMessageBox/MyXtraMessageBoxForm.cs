using System;
using System.Collections.Generic;
using System.Linq;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace MessageBoxHelper.Internal {
    public class MyXtraMessageBoxForm : DevExpress.XtraEditors.XtraMessageBoxForm {
        private Timer CountdownTimer;
        private bool countDownCaption;
        private bool autoClose;
        private int timeout;
        private DialogResult timeoutResult;
        private string baseCaption;
        private bool captionWasCoped;
        private bool selectNext;
        private bool disablebttns;
        private bool disableCancel;
        private bool center;
        public bool ShowMessageNextTime;

        private CheckEdit cbShowNextTime;
        public MyXtraMessageBoxForm()
            : base() {
            baseCaption = "";
            CountdownTimer = new Timer();
            CountdownTimer.Tag = this;
            CountdownTimer.Interval = 1000;
            CountdownTimer.Tick += MyTimer_Tick;
            captionWasCoped = false;
        }

        protected override void OnShown(EventArgs e) {            
            if (countDownCaption)
                this.Text = "Remain " + timeout + " sec";
            if (selectNext) {
                ShowNextTime();
            }
            IButtonControl btnCancel = null;
            if ((this.CancelButton != null) && (this.CancelButton.DialogResult == DialogResult.Cancel))
                btnCancel = this.CancelButton;
            if (disablebttns)
                DisableAllExceptCancel(btnCancel as SimpleButton);
            if ((disableCancel) && (btnCancel != null))
                (btnCancel as SimpleButton).Enabled = false;
            if (center)
                CenterOnParent();
            if (this.timeout > 0) {
                this.CountdownTimer.Enabled = true;
                this.CountdownTimer.Start();
            }
            base.OnShown(e);
        }

        void DisableAllExceptCancel(SimpleButton btnCancel) {
            foreach (Control cont in this.Controls)
                if ((cont is BaseButton) && (cont != (btnCancel as SimpleButton)))
                    cont.Enabled = false;
        }

        void MyTimer_Tick(object sender, EventArgs e) {
            if (!captionWasCoped) {
                baseCaption = this.Message.Caption;
                captionWasCoped = true;
            }
            Timer messageTimer = (sender as Timer);
            timeout--;
            if ((countDownCaption) && (timeout > 0)) {
                this.Text = "Remain " + timeout + " sec";
            } else if (countDownCaption)
                this.Text = baseCaption;
            if (timeout <= 0) {
                this.Message.Caption = baseCaption;
                messageTimer.Stop();
                messageTimer.Enabled = false;
                if (autoClose) {
                    this.DialogResult = timeoutResult;
                    base.Close();
                }
            }
        }

        public DialogResult ShowForm(MyXtraMessageArgs messageArgs) {
            selectNext = messageArgs.ShowNextTime;
            disablebttns = messageArgs.DisableButtons;
            disableCancel = messageArgs.DisableCancel;
            autoClose = messageArgs.AutoClose;
            countDownCaption = messageArgs.ShowCountdown;
            timeout = messageArgs.Timeout;
            center = messageArgs.Center;
            timeoutResult = messageArgs.AutoCloseResult;

            return base.ShowMessageBoxDialog(messageArgs);
        }

        protected override void OnClosing(System.ComponentModel.CancelEventArgs e) {
            if (cbShowNextTime != null)
                this.ShowMessageNextTime = cbShowNextTime.Checked;
            this.CountdownTimer.Stop();
            this.CountdownTimer.Dispose();
            base.OnClosing(e);
        }

        void ShowNextTime() {
            cbShowNextTime = new CheckEdit();
            cbShowNextTime.Checked = true;
            cbShowNextTime.Text = "Show this dialog again?";
            cbShowNextTime.Properties.AutoWidth = true;
            cbShowNextTime.Properties.AutoHeight = true;
            this.Height += cbShowNextTime.Height;
            cbShowNextTime.Location = new Point(1, this.ClientSize.Height - cbShowNextTime.Height - 1);
            this.Controls.Add(cbShowNextTime);
        }

        void CenterOnParent() {
            int y = this.Owner.Height - this.Height;
            int x = this.Owner.Width - this.Width;
            this.Location = new Point(x / 2 + this.Owner.Location.X, y / 2 + this.Owner.Location.Y);
        }
    }
}
