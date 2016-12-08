using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Controller;

namespace SearchApp
{
    public partial class UserInterface : Form
    {
        private ElasticCtr elastic; 
        public UserInterface()
        {
            InitializeComponent();
            elastic = new ElasticCtr();

        }

        private void Form13_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBoxDoc.Text != null && textBoxIndex.Text != null)
            {
                responseBox.Text = elastic.AddDocToIndex(textBoxIndex.Text, textBoxDoc.Text);
            } 
        }

        private void button2_Click(object sender, EventArgs e)
        {
            responseBox.Text = "";
        }

        private void createIndexBtn_Click(object sender, EventArgs e)
        {
            if(elastic.CreateIndex(textBoxIndex.Text) != -1)
            {
                responseBox.Text = "Created. Maybe";
            }
            else
            {
                responseBox.Text = "Faield";
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            string res = elastic.SimpleSearch(textboxQueryTerm.Text, textboxField.Text);
            if (res != "")
            {
                responseBox.Text = res;
            }
            else
            {
                responseBox.Text = "Didnt work. Fuck wit!";
            }
        }

        private void deleteIndexBtn_Click(object sender, EventArgs e)
        {
            if(elastic.DeleteIndex(textBoxIndex.Text) != -1)
            {
                responseBox.Text = "Deleted! Maybe.";
            }
            else
            {
                responseBox.Text = "Failed";
            }
        }
    }
}
