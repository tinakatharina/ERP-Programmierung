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

            range.Sign = "I";
            range.Option = "BT";
            range.High ="130";

            busPartnerList.IdRange = new BapicontactIdrange[10];
            busPartnerList.IdRange[1] = range;

            response = client.BusPartnerEmployeeGetList(busPartnerList);

            return response; 
        }

       public BusPartnerEmployeeGetPasswordResponse getPasswort(string employeeId)
        {
             if (counter == 0)
            {
                client.ClientCredentials.UserName.UserName = "IDES-012";
                client.ClientCredentials.UserName.Password = "erpprogrammierung";
                client.Open();
                counter++;
            }

            BusPartnerEmployee.BusPartnerEmployeeGetPassword passwort = new BusPartnerEmployeeGetPassword();
            BusPartnerEmployee.BusPartnerEmployeeGetPasswordResponse response;

            
                     passwort.PartnerEmployeeId = employeeId;

                        passwort.Statusinfo = new Bapiuswsta[10];
                        
            
            response = client.BusPartnerEmployeeGetPassword(passwort);

                      //  Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                       //Console.WriteLine(response.Statusinfo[0].Objid);

                        // Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");

            return response;
          
        }

        public BusPartnerEmployeeCheckExistenceResponse checkExistence(string id)
        {
            if (counter == 0)
            {
                client.ClientCredentials.UserName.UserName = "IDES-012";
                client.ClientCredentials.UserName.Password = "erpprogrammierung";
                client.Open();
                counter++;
            }

            BusPartnerEmployee.BusPartnerEmployeeCheckExistence check = new BusPartnerEmployeeCheckExistence();
            BusPartnerEmployee.BusPartnerEmployeeCheckExistenceResponse response;

            check.PartnerEmployeeId = id;

            response = client.BusPartnerEmployeeCheckExistence(check);

            Console.WriteLine(response.Customer);



            return response;
        }


    }
    }
