using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows;
using WindowsFormsApp1.BusPartnerEmployee;

namespace WindowsFormsApp1
{
    public partial class MainView : Form
    {
        private BusPartnerEmployeeController controller = new BusPartnerEmployeeController();
        private BusPartnerEmployeeDataProvider provider = new BusPartnerEmployeeDataProvider();
        private Timer timer = new Timer();


        public MainView()
        {
            InitializeComponent();
            InitializeElements();
        }

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

        private void detailsButton_Click(object sender, EventArgs e)
        {
            boxReadOnly();
            TimerStop();
            if (employeeListView.SelectedItems.Count > 0)
            {
                boxFill();
            }
            else
            {
                TimerStart();
                infoLabel.Text = "Bitte wählen Sie zuerst einen Eintrag aus!";
            }
        }

        private void changeButton_click(object sender, EventArgs e)
        {
            TimerStop();
            if(employeeListView.SelectedItems.Count >0)
            {
                boxFill();
                boxEditable();
            } else
            {
                TimerStart();
                infoLabel.Text = "Bitte wählen Sie zuerst einen Eintrag aus!";
            }
        }

        private void createButton_click(object sender, EventArgs e)
        {
            boxEditable();
            boxClear();

            provider.createUser("1", "100");


        }

        private void confirmButton_Click(object sender, EventArgs e)
        {

        }

        private void getListButton_Click(object sender, EventArgs e)
        {
            employeeListView.Items.Clear();
            BusPartnerEmployee.BusPartnerEmployeeGetListResponse listResponse = provider.GetList();
            foreach (BusPartnerEmployee.BapicontactAddressdata data in listResponse.AddressData)
            {
                String[] employee = { data.Partneremployeeid, data.Firstname, data.Lastname };
                ListViewItem viewItem = new ListViewItem(employee);
                employeeListView.Items.Add(viewItem);
            }
            employeeListView.Refresh();
            employeeListView.FullRowSelect = true;
        }

        private void logoutButton_Click(object sender, EventArgs e)
        {
            controller.Logout();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            controller.Close();
        }

        private void createButtonPW_Click(object sender, EventArgs e)
        {
            TimerStop();
            pwIDBox.ReadOnly = false;
            confirmPWButton.Enabled = true;
            pwInfoLabel.Text = "Geben Sie nun eine ID ein \nund bestätigen Sie Ihre Eingabe durch den \n'Bestätigen'-Button!";
            TimerStart();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            TimerStop();
            if (passwordListView.SelectedItems.Count > 0)
            {
                String selected = passwordListView.SelectedItems[0].Text;
                provider.deletePassword(selected);
                prepareList();
                boxClear2();
                TimerStart();
                pwInfoLabel.Text = "Der Eintrag wurde erfolgreich gelöscht!";
            }
            else
            {
                TimerStart();
                pwInfoLabel.Text = "Bitte wählen Sie zuerst einen Eintrag aus,\nder gelöscht werden soll!";
            }
        }

        private void showPWButton_Click(object sender, EventArgs e)
        {
            TimerStop();
            pwInfoLabel.Text = "Die Liste wird vorbereitet,\ndies dauert einen Moment...";
            TimerStart();
            prepareList();
        }

        private void logoutPWButton_Click(object sender, EventArgs e)
        {
            controller.Logout();
        }

        private void closePWButton_Click(object sender, EventArgs e)
        {
            controller.Close();
        }

        private void employeeListView_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void boxEditable()
        {
            firstnameBox.ReadOnly = false;
            lastnameBox.ReadOnly = false;
            emailBox.ReadOnly = false;
            telBox.ReadOnly = false;
            faxBox.ReadOnly = false;
            persNrBox.ReadOnly = false;
            functionBox.ReadOnly = false;
            customerBox.ReadOnly = false;
            streetBox.ReadOnly = false;
            plzBox.ReadOnly = false;
            cityBox.ReadOnly = false;
            regionBox.ReadOnly = false;
            countryBox.ReadOnly = false;
            adressCodeBox.ReadOnly = false;
            titleBox.Enabled = true;
        }

        private void boxReadOnly()
        {
            firstnameBox.ReadOnly = true;
            lastnameBox.ReadOnly = true;
            emailBox.ReadOnly = true;
            telBox.ReadOnly = true;
            faxBox.ReadOnly = true;
            persNrBox.ReadOnly = true;
            functionBox.ReadOnly = true;
            customerBox.ReadOnly = true;
            streetBox.ReadOnly = true;
            plzBox.ReadOnly = true;
            cityBox.ReadOnly = true;
            regionBox.ReadOnly = true;
            countryBox.ReadOnly = true;
            adressCodeBox.ReadOnly = true;
            titleBox.Enabled = false;
        }

        private void boxClear()
        {
            firstnameBox.Text = "";
            lastnameBox.Text = "";
            emailBox.Text = "";
            telBox.Text = "";
            faxBox.Text = "";
            persNrBox.Text = "";
            functionBox.Text = "";
            customerBox.Text = "";
            streetBox.Text = "";
            plzBox.Text = "";
            cityBox.Text = "";
            regionBox.Text = "";
            countryBox.Text = "";
            adressCodeBox.Text = "";
            titleBox.SelectedIndex = 0;
        }

        private void boxFill()
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

        private void boxFill2()
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

        private void boxClear2()
        {
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
        }


        private void initButton_Click(object sender, EventArgs e)
        {
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

        private void listLabel_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
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

        private void pwInfoButton_Click(object sender, EventArgs e)
        {
            TimerStop();
            if (passwordListView.SelectedItems.Count > 0)
            {
                boxFill2();
            }
            else
            {
                TimerStart();
                pwInfoLabel.Text = "Bitte wählen Sie zuerst einen Eintrag aus!";
            }
        }

        private void changePWButton_Click(object sender, EventArgs e)
        {
            TimerStop();
            if (passwordListView.SelectedItems.Count > 0)
            {
                passwordBox.ReadOnly = false;
                passwordWdhBox.ReadOnly = false;
                altPWBox.ReadOnly = false;
                confirmPWButton.Enabled = true;
                TimerStart();
                pwInfoLabel.Text = "Bitte geben Sie Ihr altes und neues \nPasswort ein und bestätigen Sie \nIhre Eingabe!";
            } else
            {
                TimerStart();
                pwInfoLabel.Text = "Bitte wählen Sie zuerst einen Eintrag aus!";
            }

        }

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

        private void confirmPWButton_Click(object sender, EventArgs e)
        {
            TimerStop();
            string s = pwIDBox.Text;
            int n;
            if(passwordBox.ReadOnly)
            {
                if(s != "" && int.TryParse(s, out n))
                {
                    BusPartnerEmployee.BusPartnerEmployeeCheckExistenceResponse res = provider.checkExistence(s);
                    if(passwordListView.Items.Count == 1)
                    {
                        prepareList();
                    }
                    if(res.Customer.Length > 0 && passwordListView.FindItemWithText(s.PadLeft(10, '0')) == null)
                    {
                        provider.createPassword(s);
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
                } else
                {
                    pwInfoLabel.Text = "Bitte geben Sie eine gültige ID ein!";
                    TimerStart();
                }
            } else
            {
                string old = altPWBox.Text;
                string newp = passwordBox.Text;
                string wdh = passwordWdhBox.Text;
                String selected = passwordListView.SelectedItems[0].Text;
                if (newp != "" && wdh != "")
                {
                    if (int.TryParse(newp, out n))
                    {
                        if(newp.Equals(wdh))
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
                            } else {
                                pwInfoLabel.Text = "Das alte Passwort ist nicht korrekt oder \ndie ersten drei Zahlen des \nneuen Passwortes sind nicht unterschiedlich!";
                                TimerStart();
                            }
                        } else
                        {
                            pwInfoLabel.Text = "Das neue Passwort und \ndas wiederholte stimmen nicht überein!";
                            TimerStart();
                        }
                    } else
                    {
                        pwInfoLabel.Text = "Das Passwort darf nur Zahlen enthalten!";
                        TimerStart();
                    }
                } else
                {
                    pwInfoLabel.Text = "Bitte geben Sie ein neues Passwort ein!";
                    TimerStart();
                }
            }
        }
    }
}
