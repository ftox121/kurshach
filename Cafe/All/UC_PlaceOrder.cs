using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Text.RegularExpressions;

namespace Cafe.All
{
    public partial class UC_PlaceOrder : UserControl
    {
        private string dataFilePath = "C:\\Users\\FTOX\\source\\repos\\Cafe\\Cafe\\DATA.txt";
        public UC_PlaceOrder()
        {
            InitializeComponent();
            InitializeComboBox();
            LoadDataToListBox();

        }

        public void LoadDataToListBox()
        {

            listBox1.Items.Clear();

            
            string[] lines = File.ReadAllLines(dataFilePath);
            foreach (string line in lines)
            {
                listBox1.Items.Add(line);
            }
        }


        private void InitializeComboBox()
        {
            ComboCategory.Items.Add("Выпечка");
            ComboCategory.Items.Add("Горячее");
            ComboCategory.Items.Add("Напитки");

            ComboCategory.SelectedIndex = 0;
        }
        private void ComboCategory_SelectedIndexChanged(object sender, EventArgs e)
        {

            listBox1.Items.Clear();


            string selectedCategory = ComboCategory.SelectedItem.ToString();


            string dataFilePath = "C:\\Users\\FTOX\\source\\repos\\Cafe\\Cafe\\DATA.txt";

            try
            {

                string[] lines = File.ReadAllLines(dataFilePath);


                foreach (string line in lines)
                {

                    if (line.StartsWith(selectedCategory, StringComparison.OrdinalIgnoreCase))
                    {

                        listBox1.Items.Add(line);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при загрузке данных: {ex.Message}");
            }
        }

        private void ButtonToSearch_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();


            string selectedCategory = ComboCategory.SelectedItem.ToString();


            string dataFilePath = "C:\\Users\\FTOX\\source\\repos\\Cafe\\Cafe\\DATA.txt";

            try
            {

                string[] lines = File.ReadAllLines(dataFilePath);


                foreach (string line in lines)
                {

                    if (line.StartsWith(selectedCategory, StringComparison.OrdinalIgnoreCase))
                    {

                        listBox1.Items.Add(line);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при загрузке данных: {ex.Message}");
            }
        }

        private void btnAddToCart_Click(object sender, EventArgs e)
        {
            string dishName = txtItemname.Text;
            decimal dishPrice = decimal.Parse(txtPrice.Text);
            int quantity = (int)txtQuantity.Value;



            guna2DataGridView1.Rows.Add(dishName, dishPrice, quantity);
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {

                string selectedItem = listBox1.SelectedItem.ToString();


                Regex regex = new Regex(@"^(?<category>.+): (?<name>.+), Стоимость: (?<price>\d+)");
                Match match = regex.Match(selectedItem);


                if (match.Success)
                {

                    string dishName = match.Groups["name"].Value;
                    string dishPrice = match.Groups["price"].Value;


                    txtItemname.Text = dishName;
                    txtPrice.Text = dishPrice;
                }
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (guna2DataGridView1.SelectedRows.Count > 0)
            {

                int selectedIndex = guna2DataGridView1.SelectedRows[0].Index;


                guna2DataGridView1.Rows.RemoveAt(selectedIndex);
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            decimal totalCost = 0;


            foreach (DataGridViewRow row in guna2DataGridView1.Rows)
            {

                if (row.Cells["Цена"].Value != null && row.Cells["Количество"].Value != null)
                {
                    decimal price, quantity;
                    if (decimal.TryParse(row.Cells["Цена"].Value.ToString(), out price) &&
                        decimal.TryParse(row.Cells["Количество"].Value.ToString(), out quantity))
                    {

                        totalCost += price * quantity;
                    }
                }
            }

            
            MessageBox.Show($"Общая стоимость чека: {totalCost} руб.");
        }

        private void gunaUpdate_Click(object sender, EventArgs e)
        {
            LoadDataToListBox();
        }
    }
}
