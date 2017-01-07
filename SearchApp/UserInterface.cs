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
using Model;

namespace SearchApp
{
    public partial class UserInterface : Form
    {
        private ElasticCtr elastic;
        private SolrCtr solr;
        private DataController dCtr;
        public UserInterface()
        {
            InitializeComponent();
            elastic = new ElasticCtr();
            solr = new SolrCtr();
            dCtr = new DataController();
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
            if (textBoxDoc.Text != null && textBoxIndex.Text != null)
            {
                responseBox.Text = elastic.AddDocToIndex(textBoxIndex.Text, textBoxDoc.Text);
            }
        }

        private void ElasticClearResponseBox(object sender, EventArgs e)
        {
            responseBox.Text = "";
        }

        private void createIndexBtn_Click(object sender, EventArgs e)
        {
            if (elastic.CreateIndex(textBoxIndex.Text) != -1)
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
            if (elastic.DeleteIndex(textBoxIndex.Text) != -1)
            {
                responseBox.Text = "Deleted! Maybe.";
            }
            else
            {
                responseBox.Text = "Failed";
            }
        }

        private void BulkButton_Click(object sender, EventArgs e)
        {
            string response = elastic.InsertBulk(textBoxIndex.Text);
            responseBox.Text = response;
        }

        private void SolrInsert_Click(object sender, EventArgs e)
        {
            string res = solr.BulkInsert();
            if (res.Equals("0"))
            {
                solrResponseBox.Text = "Success!";
            }
            else
            {
                solrResponseBox.Text = res;
            }
        }

        private void solrSearch_Click(object sender, EventArgs e)
        {
            string res = "";
            List<Product> products = solr.Search(solrQueryBox.Text);
            if (products != null)
            {
                foreach (Product p in products)
                {
                    res += p.ToString() + "\n";
                }
            }
            else
            {
                res = "Returned 'Null'.. So shit didnt work!";
            }
            solrResponseBox.Text = res;

        }

        private void SolrDeleteAllButton_Click(object sender, EventArgs e)
        {
            string res = solr.DeleteAllDocuments();
            if (res.Equals("0"))
            {
                solrResponseBox.Text = "Deleted everything muhahah!";
            }
            else
            {
                solrResponseBox.Text = res;
            }
        }

        private void solrDeleteByQueryButton_Click(object sender, EventArgs e)
        {
            string res = solr.DeleteDocByQuery(solrQueryBox.Text);
            if (res.Equals("0"))
            {
                solrResponseBox.Text = "Deleted!";
            }
            else
            {
                solrResponseBox.Text = res;
            }

        }

        private void solrFacetButton_Click(object sender, EventArgs e)
        {
            string boxString = "";
            if (solrFacetQuery.Text.Length == 0)
            {
                Dictionary<string, int> res = solr.FacetSearchGetAll();
                if (res.Count != 0)
                {
                    foreach (KeyValuePair<string, int> facet in res)
                    {
                        boxString += facet.Key + " (" + facet.Value + ")\n";
                    }
                }
                else
                {
                    boxString = "FAILED!";
                }
            }
            else
            {
                List<Product> res = solr.FacetSearchWithQuery(solrFacetQuery.Text);

                foreach (Product p in res)
                {
                    boxString += p.ToString() + "\n";
                }
            }

            solrFacetBox.Text = boxString;
        }

        private void solrFacetView_AfterSelect(object sender, TreeViewEventArgs e)
        {
        }

        private void deleteIndexBtn_Click_1(object sender, EventArgs e)
        {
            if(elastic.DeleteIndex(textBoxIndex.Text) > -1)
            {
                responseBox.Text = "success";
            } else
            {
                responseBox.Text = "Failed";
            }
        }

        private void searchSQL_Click(object sender, EventArgs e)
        {
            List<Product> list = dCtr.searchFullText(sqlSearchBox.Text.Split(null).ToList<string>());

            string response = "";
            foreach (Product p in list)
            {
                response += p.name + "\n";
                response += p.description + "\n\n";
            }

            sqlResponseBox.Text = response;
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void facet1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void BulkText_Click(object sender, EventArgs e)
        {
            string response = elastic.InsertBulkText(textBoxIndex.Text);
            responseBox.Text = response;
        }

        private void createIndexSQL_Click(object sender, EventArgs e)
        {
            dCtr.createFullTextIndex("Perfion");
        }
    }
}