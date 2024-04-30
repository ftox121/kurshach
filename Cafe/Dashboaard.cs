using Cafe.All;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cafe
{
    public partial class Dashboaard : Form
    {
        public Dashboaard()
        {
            InitializeComponent();
            
        }
        public Dashboaard(String user)
        {
            InitializeComponent();

            if (user == "Guest")
            {
                btnAddItems.Hide();
                btnRemoveItems.Hide();
                
            }
            else if (user == "Admin")
            {
                btnAddItems.Show();
                btnRemoveItems.Show();
                
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogout_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form1 fm = new Form1();
            this.Hide();
            fm.Show();
        }

        private void btnAddItems_Click(object sender, EventArgs e)
        {
            uC_Additems21.Visible = true;
            uC_Additems21.BringToFront();
        }

        private void Dashboaard_Load(object sender, EventArgs e)
        {
            uC_Additems21.Visible = false;
            uC_PlaceOrder1.Visible = false;
            remove1.Visible = false;

        }

        private void btnPlaceOrder_Click(object sender, EventArgs e)
        {
            uC_Welcome1.SendToBack();
            guna2Transition1.ShowSync(uC_PlaceOrder1);
            uC_PlaceOrder1.Visible = true;
            uC_PlaceOrder1.BringToFront();

        }

        private void btnRemoveItems_Click(object sender, EventArgs e)
        {
            remove1.Visible = true;
            remove1.BringToFront();

        }
    }
}
