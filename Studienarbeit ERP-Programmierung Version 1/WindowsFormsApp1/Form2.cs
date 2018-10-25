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
    public partial class Form2 : Form
    {
        private BusPartnerEmployeeController controller = new BusPartnerEmployeeController();
        private BusPartnerEmployeeDataProvider provider = new BusPartnerEmployeeDataProvider();
        private Timer timer = new Timer();


        public Form2()
        {
            InitializeComponent();
            InitializeElements();
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void button13_Click(object sender, EventArgs e)
        {
            controller.Close();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            controller.Logout();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            controller.Close();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            controller.Logout();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            provider.GetList();
        }

        private void listView2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {
           
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Löschen");
        }

        private void button5_Click(object sender, EventArgs e)
        {

           

       
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            BusPartnerEmployee.BusPartnerEmployeeGetListResponse listResponse = provider.GetList();
            foreach (BusPartnerEmployee.BapicontactAddressdata data in listResponse.AddressData)
            {
                String[] employee = { data.Partneremployeeid, data.Firstname, data.Lastname };
                ListViewItem viewItem = new ListViewItem(employee);
                listView1.Items.Add(viewItem);
            }
            listView1.Refresh();
            listView1.FullRowSelect = true;
        }

        private void Mitarbeiter_Click(object sender, EventArgs e)
        {

        }

        private void InitializeElements()
        {
            listView1.View = View.Details;

            String[] columnKeys = { "employeeId", "firstName", "lastName" };
            String[] columnTexts = { "ID", "Vorname", "Nachname" };
          
            listView1.Columns.Add(columnKeys[0], columnTexts[0]);
            listView1.Columns.Add(columnKeys[1], columnTexts[1]);
            listView1.Columns.Add(columnKeys[2], columnTexts[2]);

            listView1.Columns[0].Width = 100;
            listView1.Columns[1].Width = 70;
            listView1.Columns[2].Width = 90;

        }



        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {




        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            TimerStop();
            if (listView1.SelectedItems.Count > 0)
            {
                String selected = listView1.SelectedItems[0].Text;
                BusPartnerEmployee.BusPartnerEmployeeGetListResponse listResponse = provider.GetList();
                foreach (BusPartnerEmployee.BapicontactAddressdata data in listResponse.AddressData)
                {
                    if(data.Partneremployeeid == selected)
                    {
                        textBox4.Text = data.Firstname;
                        textBox2.Text = data.Lastname;
                        textBox3.Text = data.EMail;
                        textBox12.Text = data.Tel1Numbr;
                        textBox11.Text = data.FaxNumber;
                        textBox10.Text = data.PersNo;
                        textBox9.Text = data.Function;
                        textBox1.Text = data.Customer;
                        textBox19.Text = data.Street;
                        textBox8.Text = data.PostlCod1;
                        textBox7.Text = data.City;
                        textBox14.Text = data.Region;
                        textBox17.Text = data.Country;
                        textBox18.Text = data.Countryiso;
                        textBox16.Text = data.Address;
                        comboBox1.SelectedIndex = comboBox1.FindStringExact(data.TitleP);
                    }
                }

            } else
            {
                TimerStart();
                infoLabel.Text = "Bitte wählen Sie zuerst einen Eintrag aus!";
            }
        }

        private void label22_Click(object sender, EventArgs e)
        {

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

    }
}
