using LibraryServices.Data.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DatabaseSample
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

        private void Btn_generate_Click(object sender, EventArgs e)
        {
            //var data = tx_JsonUrl.Text

            City cityParse = JsonConvert.DeserializeObject<City>(tx_JsonUrl.Text);

            tx_CountryCode.Text = cityParse.CountryCode;
            tx_Name.Text = cityParse.Name;
            tx_District.Text = cityParse.District;
            tx_Population.Text = cityParse.Population;
            
        }

        private void Btn_genList_Click(object sender, EventArgs e)
        {

            City cityParse = JsonConvert.DeserializeObject<City>(tx_JsonUrl.Text);
            ListViewItem item = new ListViewItem();
            item.SubItems.Add(cityParse.Id.ToString());
            item.SubItems.Add(cityParse.Name);
            item.SubItems.Add(cityParse.CountryCode);
            item.SubItems.Add(cityParse.District);
            item.SubItems.Add(cityParse.Population);

        }
    }
}
