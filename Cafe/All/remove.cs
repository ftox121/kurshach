using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cafe.All
{
    public partial class remove : UserControl
    {
        private string dataFilePath = "C:\\Users\\FTOX\\source\\repos\\Cafe\\Cafe\\DATA.txt";
        public remove()
        {
            InitializeComponent();
            LoadDataToListBox();
        }
        public void LoadDataToListBox()
        {

            if (!File.Exists(dataFilePath))
            {
                MessageBox.Show("Файл с данными не найден!");
                return;
            }


            List<string> lines = new List<string>();
            using (StreamReader reader = new StreamReader(dataFilePath))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    lines.Add(line);
                }
            }


            listik.Items.Clear();


            foreach (string line in lines)
            {
                listik.Items.Add(line);
            }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {

            if (listik.SelectedItem != null)
            {
                
                string selectedValue = listik.SelectedItem.ToString();

                
                listik.Items.Remove(selectedValue);

                
                RemoveItemFromFile(selectedValue);
            }
        }
        private void RemoveItemFromFile(string itemToRemove)
        {
            string filePath = dataFilePath;

            
            string[] lines = File.ReadAllLines(filePath);

            
            List<string> updatedLines = new List<string>();
            foreach (string line in lines)
            {
                if (line != itemToRemove)
                {
                    updatedLines.Add(line);
                }
            }

            
            File.WriteAllLines(filePath, updatedLines.ToArray());
        }

        private void lastupdate_Click(object sender, EventArgs e)
        {
            LoadDataToListBox();
        }
    }
}
