using System;
using System.Windows.Forms;
using WindowsFormsApp1.BusPartnerEmployee;

namespace WindowsFormsApp1
{
    public partial class MainView : Form
    {
        private BusPartnerEmployeeController controller = new BusPartnerEmployeeController();
        private BusPartnerEmployeeDataProvider provider = new BusPartnerEmployeeDataProvider();
        private Timer timer = new Timer(); //Timer zum Ein- und Ausblenden der Infotexte für den User


        public MainView()
        {
            InitializeComponent();
            InitializeElements();
        }

        /*Initialisieren der Tabellen*/
        private void InitializeElements()
        {
            employeeListView.View = View.Details;

            String[] columnKeys = { "employeeId", "firstName", "lastName" };
            String[] columnTexts = { "ID", "Vorname", "Nachname" };
          
            employeeListView.Columns.Add(columnKeys[0], columnTexts[0]);
            employeeListView.Columns.Add(columnKeys[1], columnTexts[1]);
            employeeListView.Columns.Add(columnKeys[2], columnTexts[2]);

            employeeListView.Columns[0].Width = 100;
            employeeListView.Columns[1].Width = 70;
            employeeListView.Columns[2].Width = 90;


            passwordListView.View = View.Details;

            String[] columnKeys1 = { "employeeId", "firstName", "lastName" };
            String[] columnTexts1 = { "ID", "Vorname", "Nachname" };

            passwordListView.Columns.Add(columnKeys1[0], columnTexts1[0]);
            passwordListView.Columns.Add(columnKeys1[1], columnTexts1[1]);
            passwordListView.Columns.Add(columnKeys1[2], columnTexts1[2]);

            passwordListView.Columns[0].Width = 100;
            passwordListView.Columns[1].Width = 70;
            passwordListView.Columns[2].Width = 90;

        }

        public void TimerStart()
        {
            timer.Interval = 5000;
            timer.Tick += new EventHandler(hideLabel);
            timer.Start();
        }

        public void TimerStop()
        {
            timer.Stop();
            infoLabel.Text = "";
            pwInfoLabel.Text = "";
        }

        void hideLabel(object sender, EventArgs e)
        {
            infoLabel.Text = "";
            pwInfoLabel.Text = "";
        }

        /*Füllt die Ansprechpartner-Liste */
        private void prepareEmployeeList(ListView lv)
        {
            lv.Items.Clear();
            BusPartnerEmployee.BusPartnerEmployeeGetListResponse listResponse = provider.GetList();
            foreach (BusPartnerEmployee.BapicontactAddressdata data in listResponse.AddressData)
            {
                String[] employee = { data.Partneremployeeid, data.Firstname, data.Lastname };
                ListViewItem viewItem = new ListViewItem(employee);
                lv.Items.Add(viewItem);
            }
            lv.Refresh();
            lv.FullRowSelect = true;
        }

        /*füllt die Passwortliste*/
        private void prepareList()
        {
            passwordListView.Items.Clear();
            BusPartnerEmployee.BusPartnerEmployeeGetListResponse listResponse = provider.GetList();
            foreach (BusPartnerEmployee.BapicontactAddressdata data in listResponse.AddressData)
            {
                BusPartnerEmployee.BusPartnerEmployeeGetPasswordResponse passwortRes = provider.getPasswort(data.Partneremployeeid);

                if (passwortRes.Return.Message.Length == 0)
                {
                    String[] employee = { data.Partneremployeeid, data.Firstname, data.Lastname };
                    ListViewItem viewItem = new ListViewItem(employee);
                    passwordListView.Items.Add(viewItem);
                }
            }
            passwordListView.Refresh();
            passwordListView.FullRowSelect = true;
        }



        /**************************************** Übersicht-Tab *******************************************************************************/


        /*Testet, ob ein Nutzer zur eingegeben ID existiert, nachdem der Button gedrückt wurde*/
        private void prüfenButtonClick(object sender, EventArgs e)
        {
            TimerStop();
            String s = textBox11.Text;
            int n;
            bool isNumeric = int.TryParse(s, out n);

            if (isNumeric == true)
            {
                BusPartnerEmployee.BusPartnerEmployeeCheckExistenceResponse res = provider.checkExistence(s);
                if (res.Customer.Length > 0)
                {
                    TimerStart();
                    infoLabel.Text = "Diese ID existiert!";
                }
                else
                {
                    TimerStart();
                    infoLabel.Text = "Diese ID existiert nicht!";
                }
            }
            else
            {
                TimerStart();
                infoLabel.Text = "Bitte geben Sie eine gültige ID ein!";
            }
        }



        /*zeigt auf Wunsch die nächste freie ID an*/
        private void serachButton_Click(object sender, EventArgs e)
        {
            BusPartnerEmployeeGetInternalNumberResponse res = provider.InternalNumber(1);
            nextIDBox.Text = res.ContactId;
        }


        /*Füllt drei Felder mit den Details des ausgewählten Nutzers, nachdem der 'Detail'-Button betätigt wurde*/
        private void detailsButton_Click(object sender, EventArgs e)
        {
             TimerStop();
            if (employeeListView.SelectedItems.Count > 0)
            {
                String selected = employeeListView.SelectedItems[0].Text;
                BusPartnerEmployee.BusPartnerEmployeeGetListResponse listResponse = provider.GetList();
                foreach (BusPartnerEmployee.BapicontactAddressdata data in listResponse.AddressData)
                {
                    if (data.Partneremployeeid == selected)
                    {
                        firstnameBox.Text = data.Firstname;
                        lastnameBox.Text = data.Lastname;
                        emailBox.Text = data.EMail;
                        telBox.Text = data.Tel1Numbr;
                        faxBox.Text = data.FaxNumber;
                        persNrBox.Text = data.PersNo;
                        functionBox.Text = data.Function;
                        customerBox.Text = data.Customer;
                        streetBox.Text = data.Street;
                        plzBox.Text = data.PostlCod1;
                        cityBox.Text = data.City;
                        regionBox.Text = data.Region;
                        countryBox.Text = data.Country;
                        adressCodeBox.Text = data.Address;
                        titleBox.SelectedIndex = titleBox.FindStringExact(data.TitleP);
                    }
                }
            }
            else
            {
                TimerStart();
                infoLabel.Text = "Bitte wählen Sie zuerst einen Eintrag aus!";
            }
        }


        /*Füllt die Ansprechpartner-List, nachdem der 'Anzeigen'-Button betätigt wurde*/
        private void getListButton_Click(object sender, EventArgs e)
        {
            prepareEmployeeList(employeeListView);
        }

        /*Ausloggen*/
        private void logoutButton_Click(object sender, EventArgs e)
        {
            controller.Logout();
        }

        /*schließen*/
        private void closeButton_Click(object sender, EventArgs e)
        {
            controller.Close();
        }
        


        /******************************************************** Passwort-Tab **************************************************************************************/

        /*leert alle Felder und macht diese nicht editierbar*/
        private void MakeUnable()
        {
            pwIDBox.Text =  "";
            altPWBox.Text = "";
            passwordBox.Text = "";
            passwordWdhBox.Text = "";
            pwIDBox.ReadOnly = true;
            altPWBox.ReadOnly = true;
            passwordBox.ReadOnly = true;
            passwordWdhBox.ReadOnly = true;
        }  
            
        /*ermöglicht das Passwortändern, nachdem der 'Ändern'-Button betätigt wurde*/
        private void changePWButton_Click(object sender, EventArgs e)
        {
            MakeUnable();
            TimerStop();
            if (passwordListView.SelectedItems.Count > 0)
            {
                passwordBox.ReadOnly = false;
                passwordWdhBox.ReadOnly = false;
                altPWBox.ReadOnly = false;
                confirmPWButton.Enabled = true;
                TimerStart();
                pwInfoLabel.Text = "Bitte geben Sie Ihr altes und neues \nPasswort ein und bestätigen Sie \nIhre Eingabe!";
            }
            else
            {
                TimerStart();
                pwInfoLabel.Text = "Bitte wählen Sie zuerst einen Eintrag aus!";
            }

        }

        /*führt je nachdem, was zuvor gemacht wurde, die passende Aktion / Überprüfung durch*/
        private void confirmPWButton_Click_1(object sender, EventArgs e)
        {
            TimerStop();
            string s = pwIDBox.Text;
            int n;
            if (passwordBox.ReadOnly)
            {
                if (s != "" && int.TryParse(s, out n))
                {
                    BusPartnerEmployee.BusPartnerEmployeeCheckExistenceResponse res = provider.checkExistence(s);
                    if (passwordListView.Items.Count == 1)
                    {
                        pwInfoLabel.Text = "Die Liste wird vorbereitet,\ndies dauert einen Moment...";
                        TimerStart();
                        prepareList();
                    }
                    if (res.Customer.Length > 0 && passwordListView.FindItemWithText(s.PadLeft(10, '0')) == null)
                    {
                        provider.createPassword(s);
                        pwInfoLabel.Text = "Die Liste wird vorbereitet,\ndies dauert einen Moment...";
                        TimerStart();
                        prepareList();
                        confirmPWButton.Enabled = false;
                        pwIDBox.Text = "";
                        pwIDBox.ReadOnly = true;
                        pwInfoLabel.Text = "Der User wurder erfolgreich in der \nPasswort-Datenbank angelegt!";
                        TimerStart();
                    }
                    else
                    {
                        pwInfoLabel.Text = "Diese ID existiert entweder schon in der \nDatenbank oder sie ist ungültig!";
                        TimerStart();
                    }
                }
                else
                {
                    pwInfoLabel.Text = "Bitte geben Sie eine gültige ID ein!";
                    TimerStart();
                }
            }
            else if (passwordWdhBox.ReadOnly)
            {
                if (provider.checkPassword(passwordListView.SelectedItems[0].Text, passwordBox.Text))
                {
                    pwInfoLabel.Text = "Das Passwort stimmt!";
                    TimerStart();
                }
                else
                {
                    pwInfoLabel.Text = "Das Passwort stimmt nicht!";
                    TimerStart();

                }
                confirmPWButton.Enabled = false;
                passwordBox.ReadOnly = true;
                passwordBox.Text = "";
            }
            else
            {
                string old = altPWBox.Text;
                string newp = passwordBox.Text;
                string wdh = passwordWdhBox.Text;
                String selected = passwordListView.SelectedItems[0].Text;
                if (newp != "" && wdh != "" && newp.Length > 6)
                {
                    if (int.TryParse(newp, out n))
                    {
                        if (newp.Equals(wdh))
                        {
                            if (provider.changePassword(newp, wdh, selected, old))
                            {
                                confirmPWButton.Enabled = false;
                                altPWBox.ReadOnly = true;
                                passwordBox.ReadOnly = true;
                                passwordWdhBox.ReadOnly = true;
                                altPWBox.Text = "";
                                passwordBox.Text = "";
                                passwordWdhBox.Text = "";
                                pwInfoLabel.Text = "Das Passwort wurde erfolgreich geändert!";
                                TimerStart();
                            }
                            else
                            {
                                pwInfoLabel.Text = "Das alte Passwort ist nicht korrekt oder \ndie ersten drei Zahlen des \nneuen Passwortes sind nicht unterschiedlich!";
                                TimerStart();
                            }
                        }
                        else
                        {
                            pwInfoLabel.Text = "Das neue Passwort und \ndas wiederholte stimmen nicht überein!";
                            TimerStart();
                        }
                    }
                    else
                    {
                        pwInfoLabel.Text = "Das Passwort darf nur Zahlen enthalten (Länge > 6)!";
                        TimerStart();
                    }
                }
                else
                {
                    pwInfoLabel.Text = "Bitte geben Sie ein neues Passwort ein!";
                    TimerStart();
                }
            }
        }

        /*Ermöglicht das Passwort-Ändern, nachdem der 'Ändern'-Button gedrückt wurde*/
        private void createButtonPW_Click(object sender, EventArgs e)
        {
            MakeUnable();
            TimerStop();
            pwIDBox.ReadOnly = false;
            confirmPWButton.Enabled = true;
            pwInfoLabel.Text = "Geben Sie nun eine ID ein \nund bestätigen Sie Ihre Eingabe durch den \n'Bestätigen'-Button!";
            TimerStart();
        }


        /*Überprüfung, ob ein Passwort zu dem ausgewählten Nutzer gehört*/
        private void button1_Click(object sender, EventArgs e)
        {
            MakeUnable();
            TimerStop();
            if (passwordListView.SelectedItems.Count > 0)
            {
                passwordBox.ReadOnly = false;
                confirmPWButton.Enabled = true;
                TimerStart();
                pwInfoLabel.Text = "Bitte geben Sie das zu überprüfende Passwort ein!";
            }
            else
            {
                TimerStart();
                pwInfoLabel.Text = "Bitte wählen Sie zuerst einen Eintrag aus!";
            }
        }




        /*löscht den ausgewählten Nutzer aus der Passwort-Datenbank*/
        private void deleteButton_Click(object sender, EventArgs e)
        {
            MakeUnable();
            TimerStop();
            if (passwordListView.SelectedItems.Count > 0)
            {
                String selected = passwordListView.SelectedItems[0].Text;
                provider.deletePassword(selected);
                pwInfoLabel.Text = "Die Liste wird vorbereitet,\ndies dauert einen Moment...";
                TimerStart();
                prepareList();

                TypTextBox.Text = "";
                IDTextBox.Text = "";
                ServiceTextBox.Text = "";
                StatusTextBox.Text = "";
                AnlegeTextbox.Text = "";
                GueltigTextbox.Text = "";
                LCNTTextBox.Text = "";
                LDateTextBox.Text = "";
                LTimeTextbox.Text = "";
                UpdpassTextbox.Text = "";

                TimerStart();
                pwInfoLabel.Text = "Der Eintrag wurde erfolgreich gelöscht!";
            }
            else
            {
                TimerStart();
                pwInfoLabel.Text = "Bitte wählen Sie zuerst einen Eintrag aus,\nder gelöscht werden soll!";
            }
        }

        /*Die Passwort-Liste wird gefüllt, nachdem der 'Anzeigen'-Button gedrückt wurde*/
        private void showPWButton_Click(object sender, EventArgs e)
        {
            MakeUnable();
            TimerStop();
            pwInfoLabel.Text = "Die Liste wird vorbereitet,\ndies dauert einen Moment...";
            TimerStart();
            prepareList();
        }

        /*generiert ein Initialpasswort, nachdem der 'Generieren'-Button betätigt wurde*/
        private void initButton_Click(object sender, EventArgs e)
        {
            MakeUnable();
            TimerStop();
            if (passwordListView.SelectedItems.Count > 0)
            {
                String selected = passwordListView.SelectedItems[0].Text;
                provider.generatePassword(selected);
                TimerStart();
                pwInfoLabel.Text = "Für den Nutzer wurde erfolgreich \nein neues Passwort generiert!";
            }
            else
            {
                TimerStart();
                pwInfoLabel.Text = "Bitte wählen Sie zuerst einen Nutzer aus,\ndessen Passwort generiert werden soll!";
            }
        }

        /*Füllt die Boxen mit den passenden Daten zu dem ausgwählten Eintrag*/
        private void pwInfoButton_Click(object sender, EventArgs e)
        {
            MakeUnable();
            TimerStop();
            if (passwordListView.SelectedItems.Count > 0)
            {
                String selected = passwordListView.SelectedItems[0].Text;
                BusPartnerEmployee.BusPartnerEmployeeGetPasswordResponse res = provider.getPasswort(selected);

                TypTextBox.Text = res.Statusinfo[0].Objtype;
                IDTextBox.Text = res.Statusinfo[0].Objid;
                ServiceTextBox.Text = res.Statusinfo[0].Service.ToString();
                StatusTextBox.Text = res.Statusinfo[0].State;
                AnlegeTextbox.Text = res.Statusinfo[0].Uiddate;
                GueltigTextbox.Text = res.Statusinfo[0].Validto;
                LCNTTextBox.Text = res.Statusinfo[0].Lcnt.ToString();
                LDateTextBox.Text = res.Statusinfo[0].Ldate;
                LTimeTextbox.Text = res.Statusinfo[0].Ltime.ToString();
                UpdpassTextbox.Text = res.Statusinfo[0].Updpass;
            }
            else
            {
                TimerStart();
                pwInfoLabel.Text = "Bitte wählen Sie zuerst einen Eintrag aus!";
            }
        }

        /*schließen*/
        private void closePWButton_Click(object sender, EventArgs e)
        {
            controller.Close();
        }

        /*Logout*/
        private void logoutPWButton_Click(object sender, EventArgs e)
        {
            controller.Logout();
        }

        
    }
}
