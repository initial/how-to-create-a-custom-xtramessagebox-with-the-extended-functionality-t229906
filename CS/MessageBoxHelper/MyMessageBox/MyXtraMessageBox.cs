

using DevExpress.XtraEditors;
using MessageBoxHelper.Internal;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MessageBoxHelper {
    public static class MyXtraMessageBox {
        public static DialogResult Show(MyXtraMessageArgs options) {
            MyXtraMessageBoxForm messageForm = new MyXtraMessageBoxForm();
            DialogResult result = messageForm.ShowForm(options);
            options.ShowMessageNextTime = messageForm.ShowMessageNextTime;
            return result;
        }

        public static DialogResult[] GetDialogResultsFromButtons(MessageBoxButtons buttons) {
            MethodInfo xtraMessageBoxInfo = typeof(XtraMessageBox).GetMethod("MessageBoxButtonsToDialogResults", BindingFlags.Static | BindingFlags.NonPublic | BindingFlags.Public);
            return (DialogResult[])xtraMessageBoxInfo.Invoke(null, new object[] { buttons });
        }

        public static Icon GetIcon(string iconInfo) {
            object icon = Enum.Parse(typeof(MessageBoxIcon), iconInfo);
            MethodInfo xtraMessageBoxInfo = typeof(XtraMessageBox).GetMethod("MessageBoxIconToIcon", BindingFlags.Static | BindingFlags.NonPublic | BindingFlags.Public);
            icon = xtraMessageBoxInfo.Invoke(null, new object[] { icon });
            return (Icon)icon;
        }
    }
}
