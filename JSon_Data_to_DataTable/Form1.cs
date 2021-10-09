using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace JSon_Data_to_DataTable
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void GenerateButton_Click(object sender, EventArgs e)
        {
            string Url = JsonUrlTextBox.Text.ToString();
            if (Url == null || Url == "")
            {
                MessageBox.Show("No input is provided. Action aborted.\n\nPlease add link to the text box and try again.", "No value in text box", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } else
            {
                GenerateButton.Enabled = false;
                Task<DataTable> task = CollectData("test");
                this.enhancedADGV_JSON.DataSource = await task;
                GenerateButton.Enabled = true;
            }
        }

         async Task<DataTable> CollectData(string url)
        {
            
            DataTable resultGrid = GeneratePostTable();
            HttpClient client = new HttpClient()
            {
                BaseAddress = new Uri("https://jsonplaceholder.typicode.com")
            };
            int i = 1;
            while (true)
            {
                try
                {
                    Post post = await client.GetFromJsonAsync<Post>($"posts/{i}");
                    
                    resultGrid.Rows.Add(post.userId, post.id, post.title, post.body);
                    i++;
                } catch(Exception Ex)
                {
                    break;
                }
                
                
                
                
                
            }
            
            return resultGrid;
            
            
        }
        DataTable GeneratePostTable()
        {
            DataTable dt =  new DataTable();

            dt.Columns.Add("userId", typeof(int));
            dt.Columns.Add("id", typeof(int));
            dt.Columns.Add("title", typeof(string));
            dt.Columns.Add("body", typeof(string));

            return dt;
        }
        
       
    }
}

/*
 * this.GenerateButton.Enabled = false;
            DataTable dt = new DataTable();

            List <Post> resultList = new List<Post>();
            var reader = new JsonTextReader(
                new StreamReader())
 */
