using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CommonFunctions
{
    public class Form
    {
        public void Setup_Form_TopRight(System.Windows.Forms.Form form)
        {
            Screen scr = Screen.FromPoint(form.Location);
            form.Location = new Point(scr.WorkingArea.Width / 2, scr.WorkingArea.Top);
            form.Width = scr.WorkingArea.Width / 2;
            form.Height = scr.WorkingArea.Height;
        }
        public static void Setup_Form_Right_2K(System.Windows.Forms.Form form)
        {
            form.Location = new Point(1275, 0);
            form.Width = 1292;
            form.Height = 1407;
        }
    }
}

