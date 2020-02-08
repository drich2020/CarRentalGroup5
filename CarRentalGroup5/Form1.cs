using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarRentalGroup5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                var customerName = txtCustomerName.Text;
                var cost = Convert.ToDouble(textCost.Text);
                var dateRented = dt_rentdate.Value;
                var dateReturned = dt_returndate.Value;
                var vehicle = CB_carlist.Text;
                var IdNumber = textID.Text;
                var isValid = true;

                if (string.IsNullOrEmpty(customerName) || dateRented == null || string.IsNullOrEmpty(vehicle))
                {
                    isValid = false;
                    MessageBox.Show("You have not completed the form");
                }
                if (dateRented > dateReturned)
                {
                    isValid = false;
                    MessageBox.Show("Invalid date entered");
                }
                if (isValid)
                {
                    MessageBox.Show($"Customer Name: {customerName}\n\r" +
                    $"Cost: {cost}\n\r + " +
                    $"Date Rented: {dateRented}\n\r + " +
                    $"Date Returned: {dateReturned}\n\r" +
                    $"Vehicle: {vehicle}\n\r + " +
                    $"Id Number: {IdNumber}\n\r");

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
            
        }
    }
}
