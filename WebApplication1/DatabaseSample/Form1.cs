using LibraryServices.Data.Models;
using Newtonsoft.Json;
using System;
using System.Net;
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
            string strJson = new WebClient().DownloadString(tx_JsonUrl.Text);
            City cityParse = JsonConvert.DeserializeObject<City>(strJson);

            tx_CountryCode.Text = cityParse.CountryCode;
            tx_Name.Text = cityParse.Name;
            tx_District.Text = cityParse.District;
            tx_Population.Text = cityParse.Population;
            
        }

        private void Btn_genList_Click(object sender, EventArgs e)
        {
            string strJson = new WebClient().DownloadString(tx_JsonUrl.Text);
            City[] cityParse = JsonConvert.DeserializeObject<City[]>(strJson);

            for(int x = 0; x < cityParse.Length; x++)
            {
                try
                {
                    ListViewItem items = new ListViewItem();
                    items.Text = cityParse[x].Id.ToString();
                    items.SubItems.Add(cityParse[x].Name.ToString());
                    items.SubItems.Add(cityParse[x].CountryCode.ToString());
                    items.SubItems.Add(cityParse[x].District.ToString());
                    items.SubItems.Add(cityParse[x].Population.ToString());
                    lv_list.Items.Add(items);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                }
                
            }
            

        }
    }
}
