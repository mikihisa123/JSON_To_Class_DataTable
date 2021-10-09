using System;
using System.Data;
using System.Net.Http;
using System.Net.Http.Json;
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

        // ***************** Global Variables *****************

        bool showHideWatcher = true;

        // ******************** Methods **********************

        string[] UriCutter(string uri)
        {
            int size = uri.Length;
            int lastPos = uri.LastIndexOf('/');
            
            string[] result = new string[2];
            if(lastPos > size) // Checking, if there is no empty text after '/' char. If there is, '/''s index does not count as last and finding another one
            {
                uri = uri.Remove(size - 2);
                lastPos = uri.LastIndexOf('/');
            }
            result[0] = uri.Substring(0, lastPos - 1); // returns baseAddress
            result[1] = uri.Substring(lastPos + 1); // returns supplement

            return result;
        }

        DataTable GeneratePostTable()
        {
            DataTable dt = new DataTable();

            dt.Columns.Add("userId", typeof(int));
            dt.Columns.Add("id", typeof(int));
            dt.Columns.Add("title", typeof(string));
            dt.Columns.Add("body", typeof(string));

            return dt;
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
                }
                catch (Exception Ex)
                {
                    break;
                }
            }
            return resultGrid;

        }

        

        // ****************** Form Controls ***************************

        private async void GenerateButton_Click(object sender, EventArgs e)
        {
            string Url = JsonUrlTextBox.Text.ToString();
            if (Url == null || Url == "")
            {
                MessageBox.Show("No input is provided. Action aborted.\n\nPlease add link to the text box and try again.", "No value in text box", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                GenerateButton.Enabled = false;
                Task<DataTable> task = CollectData("test");
                this.enhancedADGV_JSON.DataSource = await task;
                GenerateButton.Enabled = true;
            }
        }




        private void SHButton_Click(object sender, EventArgs e)
        {
            if (showHideWatcher)
            {
                showHideWatcher = false;
                SHButton.ButtonText = "V SHOW V";
                
            } else
            {
                showHideWatcher = true;
                SHButton.ButtonText = "^ HIDE ^";
            }

            SHPanel.Visible = showHideWatcher;
            GenerateButton.Enabled = showHideWatcher;
        }
    }
}


