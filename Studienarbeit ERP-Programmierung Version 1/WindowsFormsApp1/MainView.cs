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

        }


        public void TimerStart()
        {
            timer.Interval = 10000;
            timer.Tick += new EventHandler(hideLabel);
            timer.Start();
        }

        public void TimerStop()
        {
            timer.Stop();
            infoLabel.Text = "";
        }

        void hideLabel(object sender, EventArgs e)
        {
            infoLabel.Text = "";
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

        }

        private void deleteButton_Click(object sender, EventArgs e)
        {

        }

        private void showPWButton_Click(object sender, EventArgs e)
        {

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
    }
}
