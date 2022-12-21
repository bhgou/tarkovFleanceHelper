using System.Diagnostics;
using System.Net;
using System.Net.Http.Json;
using Newtonsoft.Json;


namespace tarkovHelper
{
    public partial class Form1 : Form
    {

        private int index = 0;

        public Form1()
        {
            InitializeComponent();
        }
        private async void Api()
        {
            string item = InputItem.Text;
            var data = new Dictionary<string, string>()
            {           
                {"query", "{items(name: \""+item+"\") {name lastLowPrice gridImageLink}}"}
            };
            using (var httpClient = new HttpClient())
            {

                //Http response message
                var httpResponse = await httpClient.PostAsJsonAsync("https://api.tarkov.dev/graphql", data);

                //Response content
                var responseContent = await httpResponse.Content.ReadAsStringAsync();
                var json = JsonConvert.DeserializeObject<Rootobject>(responseContent);

                if(index > json.data.items.Length)
                {
                    index = json.data.items.Length;
                }
                if(index < 0)
                {
                    index = 0;
                }
                CountFind.Text =  "Find: " + json.data.items.Length.ToString();
                NameItem.Text = $"Name: {json.data.items[index].name}";
                PriceItem.Text = $"Price: {json.data.items[index].lastLowPrice} ";
                SetImage(json.data.items[index].gridImageLink);
                
            }
        }

        private async void SetImage(string url) {
            var request = WebRequest.Create(url);

            using (var response = request.GetResponse())
            using (var stream = response.GetResponseStream())
            {
                pictureBox1.Image = Bitmap.FromStream(stream);
            }
        }


        private void FindBtn_Click_1(object sender, EventArgs e)
        {
            Api();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Api();
            index++;
            Count.Text = index.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Api();
            index--;
            Count.Text = index.ToString();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}