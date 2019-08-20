using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SampleAPIConsumer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            comboBox1.SelectedIndex = 0;
        }

        private void btn_get_Click(object sender, EventArgs e)
        {
            var caller = new APICaller();
            var data = caller.GetAllToDo();
            DisplayValue(data);
        }

        void DisplayValue(IEnumerable<Post> data)
        {
            dataGridView1.Rows.Clear();

            if (data.Count() != 0)
            {
                foreach (var d in data)
                {
                    int row = dataGridView1.Rows.Add();
                    dataGridView1.Rows[row].Cells["id"].Value = d.id;
                    dataGridView1.Rows[row].Cells["userId"].Value = d.userId;
                    dataGridView1.Rows[row].Cells["title"].Value = d.title;
                    dataGridView1.Rows[row].Cells["completed"].Value = d.completed;
                    dataGridView1.Rows[row].Tag = d;
                }
            }            
        }

        void DisplayValue(Post data)
        {
                    dataGridView1.Rows.Clear();
                    int row = dataGridView1.Rows.Add();
                    dataGridView1.Rows[row].Cells["id"].Value = data.id;
                    dataGridView1.Rows[row].Cells["userId"].Value = data.userId;
                    dataGridView1.Rows[row].Cells["title"].Value = data.title;
                    dataGridView1.Rows[row].Cells["completed"].Value = data.completed;
                    dataGridView1.Rows[row].Tag = data;
              
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var caller = new APICaller();
            var id = Convert.ToInt32(textBox1.Text);
            var data = caller.GetTodoById(id);
            DisplayValue(data);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var caller = new APICaller();
            var p = new Post();
            p.id = Convert.ToInt32(txt_id.Text);
            p.userId = Convert.ToInt32(txt_userId.Text);
            p.title = txt_title.Text;
            p.completed = comboBox1.SelectedIndex == 0 ? true : false;

            caller.RegisterRecord(p);
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count != 0)
            {
                var caller = new APICaller();
                var p = (Post)dataGridView1.CurrentRow.Tag;
                caller.RemoveRecord(p);
            }
            else
            {
                MessageBox.Show("Please select a record in view.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
