using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.BusPartnerEmployee;
using SAP.Middleware.Connector;


namespace WindowsFormsApp1
{
    class BusPartnerEmployeeDataProvider
    {

        private RfcRepository repo;
        private RfcDestination destination;
        private Z_HH_BusPartnerEmployee_01Client client = new Z_HH_BusPartnerEmployee_01Client();

        public BusPartnerEmployeeDataProvider()
        {
            Login();
        }

        public void Login()
        {
            client.ClientCredentials.UserName.UserName = "IDES-012";
            client.ClientCredentials.UserName.Password = "erpprogrammierung";
            client.Open();
        }

        private void makeConnection()
        {
            var parameters = new RfcConfigParameters
            {
                {RfcConfigParameters.LogonGroup, "SPACE"},
                {RfcConfigParameters.MessageServerHost, "I48Z"},
                { RfcConfigParameters.SAPRouter, "/H/proxy.hof-university.de/S/3299/H/saprouter.hcc.in.tum.de/S/3299/H/" },
                { RfcConfigParameters.OnCharacterConversionError, "0" },
                { RfcConfigParameters.PoolSize, "10" },
                { RfcConfigParameters.CharacterFaultIndicatorToken, "0x0023" },
                { RfcConfigParameters.SystemID, "I48" },
                { RfcConfigParameters.User, "IDES-012" },
                { RfcConfigParameters.Password, "erpprogrammierung" },
                { RfcConfigParameters.Client, "902" },
                { RfcConfigParameters.Language, "D" },
                { RfcConfigParameters.Name, "I48" }
            };
            destination = RfcDestinationManager.GetDestination(parameters);
            repo = destination.Repository;
        }

        public bool changePassword(String newPW, String verify, String employeeID, String oldPW)
        {
            bool worked = true;

            makeConnection();

            var func = repo.CreateFunction("BAPI_PAR_EMPLOYEE_CHANGEPASSWO");
                func.SetValue("NEW_PASSWORD", newPW);
                func.SetValue("VERIFY_PASSWORD",verify);
                func.SetValue("PARTNEREMPLOYEEID", employeeID);
                func.SetValue("PASSWORD", oldPW);

            func.Invoke(destination);
           
            if (func.ToString().Contains("nicht korrekt") || func.ToString().Contains("ersten drei")) {
                worked = false;
            }

            return worked;
        }


        public void createPassword(string employeeId)
        {
            makeConnection();

            var func = repo.CreateFunction("BAPI_PAR_EMPLOYEE_CREATE_PW_RE");
            func.SetValue("PARTNEREMPLOYEEID", employeeId);
         
            func.Invoke(destination);
        }

        public void generatePassword(string employeeId)
        {
            makeConnection();

            var func = repo.CreateFunction("BAPI_PAR_EMPLOYEE_INITPASSWORD");
            func.SetValue("PARTNEREMPLOYEEID", employeeId);

            func.Invoke(destination);
        }

        public void deletePassword(string employeeId)
        {
            makeConnection();

            var func = repo.CreateFunction("BAPI_PAR_EMPLOYEE_DELETE_PW_RE");
            func.SetValue("PARTNEREMPLOYEEID", employeeId);

            func.Invoke(destination);
        }

        public void createUser(string customer, String vendor)
        {
              makeConnection();

              var func = repo.CreateFunction("BAPI_PARTNEREMPLOYEE_CREATE");
              Console.WriteLine("Metadaten+++++: " + func.Metadata);

              func.SetValue("CUSTOMER", "2000");
              func.SetValue("VENDOR", "");
              //func.SetValue("PARTNEREMPLOYEE", "100");
              //func.SetValue("PARTNEREMPLOYEEID", "1");
              //func.SetValue("PARTNEREMPLOYEEID", employeeId);

              func.Invoke(destination);

              Console.WriteLine(func.ToString());

        }

        public void editUser(string employeeID)
        {
            makeConnection();

            var func = repo.CreateFunction("BAPI_PARTNEREMPLOYEE_EDIT");
            Console.WriteLine("Metadaten+++++: " + func.Metadata);

            func.SetValue("PARTNEREMPLOYEEID", "3");
            //func.SetValue("PARTNEREMPLOYEE", "100");
            //func.SetValue("PARTNEREMPLOYEEID", "1");
            //func.SetValue("PARTNEREMPLOYEEID", employeeId);

            func.Invoke(destination);

            Console.WriteLine(func.ToString());
        }

        public bool checkPassword(string id, string password)
        {
            bool worked = false;
             BusPartnerEmployee.BusPartnerEmployeeCheckPassword check = new BusPartnerEmployeeCheckPassword();
             BusPartnerEmployee.BusPartnerEmployeeCheckPasswordResponse response;

             check.PartnerEmployeeId = id;
             check.Password = password;

             response = client.BusPartnerEmployeeCheckPassword(check);
            if (response.Return.Type.Equals("S"))
                worked = true;
            return worked;
        }

        public BusPartnerEmployeeGetListResponse GetList (int maxRows = 0, BusPartnerEmployee.BapicontactIdrange[] idRange = null)
        {
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
            BusPartnerEmployee.BusPartnerEmployeeGetPassword passwort = new BusPartnerEmployeeGetPassword();
            BusPartnerEmployee.BusPartnerEmployeeGetPasswordResponse response;

            passwort.PartnerEmployeeId = employeeId;
            passwort.Statusinfo = new Bapiuswsta[10];
                        
            response = client.BusPartnerEmployeeGetPassword(passwort);

            return response;
        }

        public BusPartnerEmployeeCheckExistenceResponse checkExistence(string id)
        {
            BusPartnerEmployee.BusPartnerEmployeeCheckExistence check = new BusPartnerEmployeeCheckExistence();
            BusPartnerEmployee.BusPartnerEmployeeCheckExistenceResponse response;

            check.PartnerEmployeeId = id;

            response = client.BusPartnerEmployeeCheckExistence(check);

            return response;
        }





    }
}
