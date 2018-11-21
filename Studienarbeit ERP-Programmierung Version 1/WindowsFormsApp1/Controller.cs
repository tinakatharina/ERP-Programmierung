using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    class BusPartnerEmployeeController
    {

        public void Login()
        {
            MainView mainView = new MainView();
            mainView.ShowDialog();
        }

        public void Logout()
        {
            Form activeForm = Form.ActiveForm;
            activeForm.Close();
        }

        public void Close()
        {
            Application.Exit();
        }



    }
}
