using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SAP.Middleware.Connector; 


namespace WindowsFormsApp1
{
    class Class1
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
    }
}
