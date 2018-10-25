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
            Console.WriteLine("FUUUUUUUUUUUCK YYYYYYYYYYYYYYYYYYYYYOUUUUU" + client.ClientCredentials.UserName.UserName + "asdf");
            Console.WriteLine("FUUUUUUUUUUUCK YYYYYYYYYYYYYYYYYYYYYOUUUUU   " + client.ClientCredentials.UserName.UserName == null);
            

            if (counter == 0){
                client.ClientCredentials.UserName.UserName = "IDES-012";
                client.ClientCredentials.UserName.Password = "erpprogrammierung";
                client.Open();
                counter++;
            }
            
            //BapicontactAddressdata adressDaten;
            BusPartnerEmployee.BusPartnerEmployeeGetList busPartnerList = new BusPartnerEmployeeGetList();
            Console.WriteLine("test  test test test test test test est " + busPartnerList.MaxRows);

            busPartnerList.MaxRows = 0;
            busPartnerList.MaxRowsSpecified = true;
            busPartnerList.CommForDisplay = "";
            busPartnerList.Contactpersononly = "";
            BusPartnerEmployee.BusPartnerEmployeeGetListResponse response;
            Console.WriteLine("test  test test test test test test est " + busPartnerList.MaxRows);
            Console.WriteLine("test  test test test test test test est " + busPartnerList.IdRange);

            BapicontactIdrange test2 = new BapicontactIdrange();

            test2.Sign = "E";
            test2.Option = "BT";
            test2.Low = "000100";
            test2.High ="655000";

            busPartnerList.IdRange = new BapicontactIdrange[10];
            busPartnerList.IdRange[1] = test2;
  
            Console.WriteLine(busPartnerList.IdRange[1]);
            Console.WriteLine("heyyyyyyyyyyyyyyyyyy " + busPartnerList.IdRange[1].High);

             response = client.BusPartnerEmployeeGetList(busPartnerList);
         
            BusPartnerEmployee.BapicontactAddressdata t;

            foreach (BusPartnerEmployee.BapicontactAddressdata test in  response.AddressData){
                Console.WriteLine("********************************");
                Console.WriteLine("Adresse: " +test.Address);
                Console.WriteLine("Cityiso: " + test.Countryiso);
                Console.WriteLine("Customer: " + test.Customer);
                Console.WriteLine("FaxNumber: " + test.FaxNumber);
                Console.WriteLine("FirstName: " + test.Firstname);
                Console.WriteLine("Function: " + test.Function);
                Console.WriteLine("LanguP: " + test.LanguP);
                Console.WriteLine("LangupIso: " + test.LangupIso);
                Console.WriteLine("Lastname: " + test.Lastname);
                Console.WriteLine("Partneremployeeid: " + test.Partneremployeeid);
                Console.WriteLine("PersNo: " + test.PersNo);
                Console.WriteLine("Post1Co1: " + test.PostlCod1);
                Console.WriteLine("Region: " + test.Region);
                Console.WriteLine("Sex: " + test.Sex);
                Console.WriteLine("Sort1P: " + test.Sort1P);
                Console.WriteLine("Street: " + test.Street);
                Console.WriteLine("Tel1Numbr: " + test.Tel1Numbr);
                Console.WriteLine("TitleP: " + test.TitleP);
                Console.WriteLine("City: " + test.City);
                Console.WriteLine("Country "+test.Country);
                Console.WriteLine("Email:  " + test.EMail);
                Console.WriteLine("********************************");
            }

           

            return response; 
        }


    }
}
