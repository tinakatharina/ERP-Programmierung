using System;
using WindowsFormsApp1.BusPartnerEmployee;
using SAP.Middleware.Connector;


namespace WindowsFormsApp1
{
    class BusPartnerEmployeeDataProvider
    {
        private Z_HH_BusPartnerEmployee_01Client client = new Z_HH_BusPartnerEmployee_01Client();
        private Connector connect = new Connector();
        private RfcRepository repo;
        private RfcDestination destination;

        public BusPartnerEmployeeDataProvider()
        {
            Login();
            connect.makeConnection();
            repo = connect.getRepo();
            destination = connect.getDes();
        }

        //Login mit wsdl-Datei
        public void Login()
        {
            client.ClientCredentials.UserName.UserName = "IDES-012";
            client.ClientCredentials.UserName.Password = "erpprogrammierung";
            client.Open();
        }

        /************************* lesende Zugriffe **************************/


        /*Passwort Check:
        * Hier wird geprüft ob das eingegebene Passwort zum Nutzer gehört*/
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

        /*Liste ausgeben:
         * Gibt die Liste aller Geschäftspartner Mitarbeiter zurück*/
        public BusPartnerEmployeeGetListResponse GetList(int maxRows = 0, BusPartnerEmployee.BapicontactIdrange[] idRange = null)
        {
            BusPartnerEmployee.BusPartnerEmployeeGetList busPartnerList = new BusPartnerEmployeeGetList();

            busPartnerList.MaxRows = 0;
            busPartnerList.MaxRowsSpecified = true;
            busPartnerList.CommForDisplay = "";
            busPartnerList.Contactpersononly = "";
            BusPartnerEmployee.BusPartnerEmployeeGetListResponse response;

            BapicontactIdrange range = new BapicontactIdrange();

            range.Sign = "I";
            range.Option = "BT";
            range.High = "130";

            busPartnerList.IdRange = new BapicontactIdrange[10];
            busPartnerList.IdRange[1] = range;

            response = client.BusPartnerEmployeeGetList(busPartnerList);

            return response;
        }

        /*Passwort-Details ausgeben:
         * Hier werden alle Details zu einem in der Passwort-Datenbank angelegten Nutzer ausgegeben*/
        public BusPartnerEmployeeGetPasswordResponse getPasswort(string employeeId)
        {
            BusPartnerEmployee.BusPartnerEmployeeGetPassword passwort = new BusPartnerEmployeeGetPassword();
            BusPartnerEmployee.BusPartnerEmployeeGetPasswordResponse response;

            passwort.PartnerEmployeeId = employeeId;
            passwort.Statusinfo = new Bapiuswsta[10];

            response = client.BusPartnerEmployeeGetPassword(passwort);

            return response;
        }

        /*Mitarbeiter Check:
         * Hier wird getestet, ob ein Nutzer mit der eingegeben ID existiert*/
        public BusPartnerEmployeeCheckExistenceResponse checkExistence(string id)
        {
            BusPartnerEmployee.BusPartnerEmployeeCheckExistence check = new BusPartnerEmployeeCheckExistence();
            BusPartnerEmployee.BusPartnerEmployeeCheckExistenceResponse response;

            check.PartnerEmployeeId = id;

            response = client.BusPartnerEmployeeCheckExistence(check);

            return response;
        }

        /*Nächste Nummer:
         * gibt die nächste freie Ansprechpartner-ID aus*/
        public BusPartnerEmployeeGetInternalNumberResponse InternalNumber(byte Id)
        {
            BusPartnerEmployee.BusPartnerEmployeeGetInternalNumber internalNumber = new BusPartnerEmployeeGetInternalNumber();
            BusPartnerEmployee.BusPartnerEmployeeGetInternalNumberResponse response = new BusPartnerEmployeeGetInternalNumberResponse();

            internalNumber.Quantity = Id;
            internalNumber.QuantitySpecified = true;

            response = client.BusPartnerEmployeeGetInternalNumber(internalNumber);

            return response;
        }



        /************************ schreibende Zugriffe *************************/


        /*Passwort ändern:
         *Hier wird das Passwort des ausgewählten Nutzers druch ein neues Passwort ersetzt*/
        public bool changePassword(String newPW, String verify, String employeeID, String oldPW)
        {
            bool worked = true;

            var func = repo.CreateFunction("BAPI_PAR_EMPLOYEE_CHANGEPASSWO");
            func.SetValue("NEW_PASSWORD", newPW);
            func.SetValue("VERIFY_PASSWORD", verify);
            func.SetValue("PARTNEREMPLOYEEID", employeeID);
            func.SetValue("PASSWORD", oldPW);

            func.Invoke(destination);

            if (func.ToString().Contains("nicht korrekt") || func.ToString().Contains("ersten drei"))
            {
                worked = false;
            }

            return worked;
        }

        /*Passwort erstellen:
         *Hier wird ein neuer Nutzer in die Passwort-Datenbank angelegt, 
         *allerdings besitzt dieser noch kein Passwort */
        public void createPassword(string employeeId)
        {
            var func = repo.CreateFunction("BAPI_PAR_EMPLOYEE_CREATE_PW_RE");
            func.SetValue("PARTNEREMPLOYEEID", employeeId);

            func.Invoke(destination);
        }

        /*Init-Passwort generieren:
         * Hier wird ein Initial-Passwort zu einem bereits in der Passwort-Datenbank erstellten Nutzer
         * neu generiert */
        public void generatePassword(string employeeId)
        {
            var func = repo.CreateFunction("BAPI_PAR_EMPLOYEE_INITPASSWORD");
            func.SetValue("PARTNEREMPLOYEEID", employeeId);

            func.Invoke(destination);
        }

        /*Passwort löschen:
         * Der Nutzer wird aus der Passwort-Datenbank gelöscht*/
        public void deletePassword(string employeeId)
        {
            var func = repo.CreateFunction("BAPI_PAR_EMPLOYEE_DELETE_PW_RE");
            func.SetValue("PARTNEREMPLOYEEID", employeeId);

            func.Invoke(destination);
        }
        
    }
}
