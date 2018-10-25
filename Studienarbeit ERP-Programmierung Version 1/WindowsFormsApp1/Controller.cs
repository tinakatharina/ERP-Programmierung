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
            Form2 f = new Form2();
            Form f1 = Form.ActiveForm;
            f1.Hide();
            f.Show();  
        }

        public void Logout()
        {
         //   Form f1 = Form.ActiveForm;
         //   f1.Close();
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
