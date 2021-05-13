using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VaccineDoseApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtName.Text == "" && txtAge.Text == "" && txtEmail.Text == "" && txtMedicine.Text == "")
            {
                MessageBox.Show("Please fill all fields");
            }
            if (Convert.ToDouble(txtMedicine.Text) > 10)
            {
                lblMedicneValidation.Text = "Below 10";
                lblMedicneValidation.ForeColor = Color.Red;
            }
            if (Convert.ToInt32(txtAge.Text)>=4&& Convert.ToInt32(txtAge.Text) <= 18)
            {
                if (rbtnNo.Checked==true&& Convert.ToDouble(txtMedicine.Text)>=1&& Convert.ToDouble(txtMedicine.Text)<=2.2)
                {
                    MessageBox.Show("Your Slot is Booked");
                }
                else if (Convert.ToDouble(txtMedicine.Text) >= 2.0 && Convert.ToDouble(txtMedicine.Text) <= 2.5&&rbtnYes.Checked == true)
                {
                    MessageBox.Show("Your Slot is Booked");
                }
                else
                {
                    MessageBox.Show("Please Enter Medicine dosage between 1 to 2.5 ");
                }
            }
            if (Convert.ToInt32(txtAge.Text) >= 19 && Convert.ToInt32(txtAge.Text) <= 30)
            {
                if (rbtnNo.Checked == true && Convert.ToDouble(txtMedicine.Text) >= 2.3 && Convert.ToDouble(txtMedicine.Text) <= 4.4)
                {
                    MessageBox.Show("Your Slot is Booked");
                }
                else if (Convert.ToDouble(txtMedicine.Text) >= 1.0 && Convert.ToDouble(txtMedicine.Text) < 2.0&& rbtnYes.Checked == true)
                {
                    MessageBox.Show("Your Slot is Booked");
                }
                else
                {
                    MessageBox.Show("Please Enter Medicine dosage between 2.3 to 4.4 ");
                }
            }
            if (Convert.ToInt32(txtAge.Text) >= 31 && Convert.ToInt32(txtAge.Text) <= 55)
            {
                if (rbtnNo.Checked == true && Convert.ToDouble(txtMedicine.Text) >= 4.4 && Convert.ToDouble(txtMedicine.Text) <= 6.0)
                {
                    MessageBox.Show("Your Slot is Booked");
                }
                else if (Convert.ToDouble(txtMedicine.Text) >= 1.0 && Convert.ToDouble(txtMedicine.Text) < 2.0 && rbtnYes.Checked == true)
                {
                    MessageBox.Show("Your Slot is Booked");
                }
                else
                {
                    MessageBox.Show("Please Enter Medicine dosage between 4.4 to 6.0 ");
                }
            }
            if ( Convert.ToInt32(txtAge.Text) >= 55)
            {
                if (rbtnNo.Checked == true && Convert.ToDouble(txtMedicine.Text) >= 3.3 && Convert.ToDouble(txtMedicine.Text) <= 4.5)
                {
                    MessageBox.Show("Your Slot is Booked");
                }
                else if (Convert.ToInt32(txtAge.Text) >= 55 && rbtnYes.Checked == true )
                {
                    MessageBox.Show("No Vaccine");
                }
                else
                {
                    MessageBox.Show("Please Enter Medicine dosage between 3.3 to 4.5 ");
                }
            }
            if (Convert.ToInt32(txtAge.Text) < 4)
            {
                MessageBox.Show("No Vaccine");
            }
            txtName.Clear();
            txtAge.Clear();
            txtEmail.Clear();
            txtMedicine.Clear();
        }
    }
}
