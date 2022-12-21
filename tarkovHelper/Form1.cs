using System.Diagnostics;
using System.Net;
using System.Net.Http.Json;
using Newtonsoft.Json;


namespace tarkovHelper
{
    public partial class Form1 : Form
    {



        public Form1()
        {
            InitializeComponent();
        }
        private async void Api()
        {
            string item = InputItem.Text;
            NameItem.Text = "";

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
                NameItem.Text += $"Name: {json.data.items[0].name} Price: {json.data.items[0].lastLowPrice} \n";
                SetImage(json.data.items[0].gridImageLink);
                
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
    }
}