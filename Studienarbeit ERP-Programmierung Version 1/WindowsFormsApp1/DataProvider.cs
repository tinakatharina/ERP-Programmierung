using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.BusPartnerEmployee;

namespace WindowsFormsApp1
{
    class BusPartnerEmployeeDataProvider
    {
        private Z_HH_BusPartnerEmployee_01Client client = new Z_HH_BusPartnerEmployee_01Client();
        int counter = 0;

        public void Login()
        {
            client.ClientCredentials.UserName.UserName = "IDES-012";
            client.ClientCredentials.UserName.Password = "erpprogrammierung";
            client.Open();
        }

        public BusPartnerEmployeeGetListResponse GetList (int maxRows = 0, BusPartnerEmployee.BapicontactIdrange[] idRange = null)
        {
            if (counter == 0){
                client.ClientCredentials.UserName.UserName = "IDES-012";
                client.ClientCredentials.UserName.Password = "erpprogrammierung";
                client.Open();
                counter++;
            }
            
            //BapicontactAddressdata adressDaten;
            BusPartnerEmployee.BusPartnerEmployeeGetList busPartnerList = new BusPartnerEmployeeGetList();

            busPartnerList.MaxRows = 0;
            busPartnerList.MaxRowsSpecified = true;
            busPartnerList.CommForDisplay = "";
            busPartnerList.Contactpersononly = "";
            BusPartnerEmployee.BusPartnerEmployeeGetListResponse response;

            BapicontactIdrange range = new BapicontactIdrange();

            range.Sign = "E";
            range.Option = "BT";
            range.Low = "000100";
            range.High ="655000";

            busPartnerList.IdRange = new BapicontactIdrange[10];
            busPartnerList.IdRange[1] = range;

            response = client.BusPartnerEmployeeGetList(busPartnerList);

            return response; 
        }


    }
}
