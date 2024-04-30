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

namespace Cafe.All
{
    public partial class UC_Additems2 : UserControl
    {
       
        public UC_Additems2()
        {
            InitializeComponent();
            InitializeComboBox();
        }

        private void btnAdditem_Click(object sender, EventArgs e)
        {
            string dishName = CafeLogger.Text;

            string newData = CafeLogger.Text;

            string category = txtCategory.Text;
            string dishPrice = txtPrice.Text;

            if (!string.IsNullOrEmpty(dishName))
            {
                try
                {
                    
                    string filePath = "C:\\Users\\FTOX\\source\\repos\\Cafe\\Cafe\\DATA.txt";

                    
                    if (!File.Exists(filePath))
                    {
                       
                        using (FileStream fs = File.Create(filePath))
                        {
                           
                            File.SetAttributes(filePath, FileAttributes.Normal);
                        }
                    }

                        
                    using (StreamWriter writer = new StreamWriter(filePath, true))
                    {
                        writer.WriteLine($"{category}: {newData}, Стоимость: {dishPrice}");
                    }

                    MessageBox.Show("Блюдо успешно сохранено.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Произошла ошибка при записи в файл: {ex.Message}");
                }
            }
            else
            {
                MessageBox.Show("Сначала введите название блюда.");
            }
        }
        private void InitializeComboBox()
        {
            txtCategory.Items.Add("Выпечка");
            txtCategory.Items.Add("Горячее");
            txtCategory.Items.Add("Напитки");

            txtCategory.SelectedIndex = 0;
        }
    }
}
