using System;
using System.Windows.Forms;
using devoir2_app.Controllers;

namespace devoir2_app
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            LoginController loginController = new LoginController();
        }
    }
}