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
                { RfcConfigParameters.User, "IDES-016" },
                { RfcConfigParameters.Password, "geheim01" },
                { RfcConfigParameters.Client, "902" },
                { RfcConfigParameters.Language, "D" },
                { RfcConfigParameters.Name, "I48" }
            };
            destination = RfcDestinationManager.GetDestination(parameters);
            repo = destination.Repository;
        }

        public void changePassword(String newPW, String verify, String employeeID, String oldPW)
        {

            makeConnection();
            if (counter == 0)
            {
                client.ClientCredentials.UserName.UserName = "IDES-012";
                client.ClientCredentials.UserName.Password = "erpprogrammierung";
                client.Open();
                counter++;
            }

            var func = repo.CreateFunction("BAPI_PAR_EMPLOYEE_CHANGEPASSWO");
            Console.WriteLine("Metadaten+++++: "+ func.Metadata);
                func.SetValue("NEW_PASSWORD", newPW);
                func.SetValue("VERIFY_PASSWORD",verify);
                func.SetValue("PARTNEREMPLOYEEID", employeeID);
                func.SetValue("PASSWORD", oldPW);

            func.Invoke(destination);
           

            Console.WriteLine(func.ToString());

            /*BusPartnerEmployee.BusPartnerEmployeeChangePassword change = new BusPartnerEmployeeChangePassword();
        BusPartnerEmployeeChangePasswordResponse response;

        change.NewPassword = newPW;
        change.PartnerEmployeeId = employeeID;
        change.Password = oldPW;
        change.VerifyPassword = verify;

        response = client.BusPartnerEmployeeChangePassword(change);

        Console.WriteLine("************" + response.Return.Message + "********" + response.Return.Type + "*******");
        */

        }


        public void generatePassword(string employeeId)
        {
            makeConnection();
            if (counter == 0)
            {
                client.ClientCredentials.UserName.UserName = "IDES-012";
                client.ClientCredentials.UserName.Password = "erpprogrammierung";
                client.Open();
                counter++;
            }

            var func = repo.CreateFunction("BAPI_PAR_EMPLOYEE_CREATE_PW_RE");
            Console.WriteLine("Metadaten+++++: " + func.Metadata);
            func.SetValue("PARTNEREMPLOYEEID", employeeId);
         
            func.Invoke(destination);

            Console.WriteLine(func.ToString());

        }

        public void createPassword(string employeeId)
        {
            makeConnection();
            if (counter == 0)
            {
                client.ClientCredentials.UserName.UserName = "IDES-012";
                client.ClientCredentials.UserName.Password = "erpprogrammierung";
                client.Open();
                counter++;
            }

            var func = repo.CreateFunction("BAPI_PAR_EMPLOYEE_INITPASSWORD");
            Console.WriteLine("Metadaten+++++: " + func.Metadata);
            func.SetValue("PARTNEREMPLOYEEID", employeeId);

            func.Invoke(destination);

            Console.WriteLine(func.ToString());


        }

        public void deletePassword(string employeeId)
        {
            makeConnection();
            if (counter == 0)
            {
                client.ClientCredentials.UserName.UserName = "IDES-012";
                client.ClientCredentials.UserName.Password = "erpprogrammierung";
                client.Open();
                counter++;
            }

            var func = repo.CreateFunction("BAPI_PAR_EMPLOYEE_DELETE_PW_RE");
            Console.WriteLine("Metadaten+++++: " + func.Metadata);
            func.SetValue("PARTNEREMPLOYEEID", employeeId);

            func.Invoke(destination);

            Console.WriteLine(func.ToString());

        }

        public void createUser(string customer, String vendor)
        {
            makeConnection();
            if (counter == 0)
            {
                client.ClientCredentials.UserName.UserName = "IDES-012";
                client.ClientCredentials.UserName.Password = "erpprogrammierung";
                client.Open();
                counter++;
            }

            var func = repo.CreateFunction("BAPI_PARTNEREMPLOYEE_CREATE");
            Console.WriteLine("Metadaten+++++: " + func.Metadata);

            func.SetValue("CUSTOMER", "2000");
           // func.SetValue("VENDOR", vendor);
            //func.SetValue("PARTNEREMPLOYEE", "100");
            //func.SetValue("PARTNEREMPLOYEEID", "1");
            //func.SetValue("PARTNEREMPLOYEEID", employeeId);

            func.Invoke(destination);

            Console.WriteLine(func.ToString());

        }

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
