using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using AutomationSystem.Moduls;
using AutomationSystem.AdminPanel;
using AutomationSystem.UserPanel;

namespace AutomationSystem
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmLogin());

            if (PublicVariable.global_UserType == 1)
            {
                frmAdmin adminForm = new frmAdmin();
                adminForm.ShowDialog();
            }
            else
            {
                frmMainUser userForm = new frmMainUser();
                userForm.ShowDialog();
            }
        }
    }
}
