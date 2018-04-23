using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.ComponentModel;

namespace MessageBoxHelper {
    public class MyXtraMessageArgs : XtraMessageBoxArgs {
        public bool ShowCountdown { get; set; }
        public bool ShowNextTime { get; set; }
        public bool DisableCancel { get; set; }
        public bool DisableButtons { get; set; }
        public bool AutoClose { get; set; }
        public DialogResult AutoCloseResult { get; set; }
        public bool Center { get; set; }
        public int Timeout { get; set; }
        public bool ShowMessageNextTime { get; set; }
        private MessageBoxButtons fButtons;
        public new MessageBoxButtons Buttons {
            get {
                return this.fButtons;
            }
            set {
                base.Buttons = MyXtraMessageBox.GetDialogResultsFromButtons(value);
                this.fButtons = value;
            }
        }

        private string fIcon;
        public new string Icon {
            get {
                return fIcon;
            }
            set {
                fIcon = value;
                base.Icon = MyXtraMessageBox.GetIcon(value);
            }
        }

        public MyXtraMessageArgs()
            : base() {
            this.Buttons = MessageBoxButtons.OK;
            this.ShowCountdown = false;
            this.ShowNextTime = false;
            this.DisableButtons = false;
            this.DisableCancel = false;
            this.AutoClose = false;
            this.Center = false;
            this.Timeout = 0;
            this.ShowMessageNextTime = false;
        }
    }
}
