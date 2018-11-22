using System;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class LogIn : Form
    {
        public LogIn()
        {
            InitializeComponent();
        }

        private void loginButton_click(object sender, EventArgs e)
        {
            BusPartnerEmployeeController controller = new BusPartnerEmployeeController();
            controller.Login();
        }
    }
}
