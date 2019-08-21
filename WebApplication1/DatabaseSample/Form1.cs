using LibraryServices.Data.Models;
using Newtonsoft.Json;
using System;
using System.Web;
using System.Net;
using System.Net.Http;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WebApplication1.Controllers;

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

        private string selected_ID = "";
        private void Lv_list_SelectedIndexChanged(object sender, EventArgs e)
        {
            selected_ID = lv_list.FocusedItem.Text;
        }

        private void Btn_genList_Click(object sender, EventArgs e)
        {
            if(tx_JsonUrl.Text == "")
            {
                MessageBox.Show("Please enter a Json Url");
            }
            else
            {
                string strJson = new WebClient().DownloadString(tx_JsonUrl.Text);
                City[] cityParse = JsonConvert.DeserializeObject<City[]>(strJson);

                lv_list.Items.Clear();
                for (int x = 0; x < cityParse.Length; x++)
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

        private void Btn_Post_Click(object sender, EventArgs e)
        {
            using (HttpClient client = new HttpClient())
            {
                City c = new City
                {
                    Id = 4100,
                    Name = tx_Name.Text,
                    CountryCode = tx_CountryCode.Text,
                    District = tx_District.Text,
                    Population = tx_Population.Text
                };
                client.BaseAddress = new Uri("http://localhost:58169/");
                var response = client.PostAsJsonAsync("api/DatabaseSample", c).Result;

                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show("Success!");
                }
                else
                {
                    MessageBox.Show("Failed");
                }
            }
        }

        private void Btn_Put_Click(object sender, EventArgs e)
        {
            using (HttpClient client = new HttpClient())
            {
                City c = new City
                {
                    Id = Int32.Parse(selected_ID),
                    Name = tx_Name.Text,
                    CountryCode = tx_CountryCode.Text,
                    District = tx_District.Text,
                    Population = tx_Population.Text
                };
                client.BaseAddress = new Uri("http://localhost:58169/");
                var response = client.PutAsJsonAsync("api/DatabaseSample/" + selected_ID, c).Result;

                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show("Success!");
                }
                else
                {
                    MessageBox.Show("Failed");
                }
            }
        }

        private void Btn_Delete_Click(object sender, EventArgs e)
        {
            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://localhost:58169/");
                var response = client.DeleteAsync("api/DatabaseSample/" + selected_ID).Result;

                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show("Success!");
                }
                else
                {
                    MessageBox.Show("Failed");
                }
            }
        }
    }
}
