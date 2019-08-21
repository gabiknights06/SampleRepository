using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibraryServices.Data.Models;
using LibraryServices.Data.Interfaces;
using LibraryServices.Data.Repositories;

namespace myRestAPI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            displayAllCaller();
        }

        void displayCity(List<City> cities)
        {
            dgv_cityList.Rows.Clear();
            if (cities.Count != 0)
            {
                foreach(var city in cities)
                {
                    int row = dgv_cityList.Rows.Add();
                    dgv_cityList.Rows[row].Cells["Id"].Value = city.Id;
                    dgv_cityList.Rows[row].Cells["cityName"].Value = city.Name;
                    dgv_cityList.Rows[row].Cells["countryCode"].Value = city.CountryCode;
                    dgv_cityList.Rows[row].Cells["district"].Value = city.District;
                    dgv_cityList.Rows[row].Cells["population"].Value = city.Population;
                    dgv_cityList.Rows[row].Tag = city;
                }
            }
        }
        void displayCity(City city)
        {
            dgv_cityList.Rows.Clear();
            int row = dgv_cityList.Rows.Add();
            dgv_cityList.Rows[row].Cells["Id"].Value = city.Id;
            dgv_cityList.Rows[row].Cells["cityName"].Value = city.Name;
            dgv_cityList.Rows[row].Cells["countryCode"].Value = city.CountryCode;
            dgv_cityList.Rows[row].Cells["district"].Value = city.District;
            dgv_cityList.Rows[row].Cells["population"].Value = city.Population;
            dgv_cityList.Rows[row].Tag = city;
        }
        void displayAllCaller()
        {
            var cityCaller = new myAPIcaller();
            var info = cityCaller.GetAllCity();
            displayCity(info);
        }

        private void Tx_Search_TextChanged(object sender, EventArgs e)
        {
            var cityCaller = new myAPIcaller();

            if (tx_Search.Text == "" || tx_Search.Text == null)
            {
                var cityInfo = cityCaller.GetAllCity();
                displayCity(cityInfo);
            }
            else
            {
                try
                {
                    var cityInfo = cityCaller.GetCity(Int32.Parse(tx_Search.Text));
                    displayCity(cityInfo);
                }
                catch
                {
                    MessageBox.Show("Id does not exist!");
                }
            }
        }

        private void Btn_Create_Click(object sender, EventArgs e)
        {
            City c = new City();
            c.Name = tx_CityName.Text;
            c.CountryCode = tx_CountryCode.Text;
            c.District = tx_District.Text;
            c.Population = tx_Population.Text;

            var caller = new myAPIcaller();
            caller.AddCity(c);
            displayAllCaller();

            foreach (Control tx in panel1.Controls)
            {
                if (tx is TextBox)
                {
                    tx.Text = "";
                }
            }
        }

        private void Btn_Update_Click(object sender, EventArgs e)
        {
            City c = new City();
            c.Id = selectedId;
            c.Name = tx_CityName.Text;
            c.CountryCode = tx_CountryCode.Text;
            c.District = tx_District.Text;
            c.Population = tx_Population.Text;

            var caller = new myAPIcaller();
            caller.UpdateCity(c);

            displayAllCaller();
            
            foreach(Control tx in panel1.Controls)
            {
                if(tx is TextBox)
                {
                    tx.Text = "";
                }
            }
        }

        private void Btn_Delete_Click(object sender, EventArgs e)
        {
            var caller = new myAPIcaller();
            caller.DeleteCity(selectedId);

            displayAllCaller();

            foreach (Control tx in panel1.Controls)
            {
                if (tx is TextBox)
                {
                    tx.Text = "";
                }
            }
        }

        int selectedId = 0;
        private void Dgv_cityList_SelectionChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgv_cityList.SelectedRows)
            {
                if (row.Cells[0].Value != null)
                {
                    selectedId = Int32.Parse(row.Cells[0].Value.ToString());
                    tx_CityName.Text = row.Cells[1].Value.ToString();
                    tx_CountryCode.Text = row.Cells[2].Value.ToString();
                    tx_District.Text = row.Cells[3].Value.ToString();
                    tx_Population.Text = row.Cells[4].Value.ToString();
                }
            }
        }

        private void Btn_Clear_Click(object sender, EventArgs e)
        {
            foreach (Control tx in panel1.Controls)
            {
                if (tx is TextBox)
                {
                    tx.Text = "";
                }
            }
            displayAllCaller();
        }
    }
}
