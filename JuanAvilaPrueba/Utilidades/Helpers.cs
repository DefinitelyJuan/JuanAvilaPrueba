using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JuanAvilaPrueba
{
    public class Helpers
    {
        public static void ClearFormControls(Form form)
        {
            foreach (Control control in form.Controls)
            {
                if (control is TextBox)
                {
                    TextBox txtbox = (TextBox)control;
                    txtbox.Text = string.Empty;
                }
                else if (control is CheckBox)
                {
                    CheckBox chkbox = (CheckBox)control;
                    chkbox.Checked = false;
                }
                else if (control is RadioButton)
                {
                    RadioButton rdbtn = (RadioButton)control;
                    rdbtn.Checked = false;
                }
                else if (control is DateTimePicker)
                {
                    DateTimePicker dtp = (DateTimePicker)control;
                    dtp.Value = DateTime.Now;
                }
            }
        }
        public static void WindowProperties(Form form)
        {
            form.ControlBox = false;
            form.WindowState = FormWindowState.Maximized;
            form.FormBorderStyle = FormBorderStyle.FixedSingle;
            form.Icon = Properties.Resources.favicon;
        }

        public static void CloseMdiChild(Form form, Label label1, Label label2)
        {
            if (form.ActiveMdiChild != null)
                form.ActiveMdiChild.Close();
            label1.Dispose();
            label2.Dispose();
        }
    }
}
