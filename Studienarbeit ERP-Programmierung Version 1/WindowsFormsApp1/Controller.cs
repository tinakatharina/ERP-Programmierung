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
        private BusPartnerEmployeeDataProvider dataProvider = new BusPartnerEmployeeDataProvider();

        public void Login()
        {
            dataProvider.Login();
            MainView mainView = new MainView();
            Form activeForm = Form.ActiveForm;
            activeForm.Hide();
            mainView.Show();  
        }

        public void Logout()
        {
         //   Form activeForm = Form.ActiveForm;
         //   activeForm.Close();
         // Müssten wir noch iwie machen 

        }

        public void Close()
        {
            Application.Exit();
        }

        public void GetList()
        {
            BusPartnerEmployee.BusPartnerEmployeeGetListResponse response = dataProvider.GetList();





        }


    }
}
