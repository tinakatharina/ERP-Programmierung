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
            BusPartnerEmployee.BusPartnerEmployeeGetListResponse listResponse = provider.GetList();
            foreach (BusPartnerEmployee.BapicontactAddressdata data in listResponse.AddressData)
            {
                String[] employee = { data.Partneremployeeid, data.Firstname, data.Lastname };
                ListViewItem viewItem = new ListViewItem(employee);
                listView1.Items.Add(viewItem);
            }
            listView1.Refresh();
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

            listView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
  
        }



        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {




        }
    }
}
