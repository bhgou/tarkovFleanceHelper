using System.Diagnostics;
using System.Net;
using System.Net.Http.Json;
using Newtonsoft.Json;


namespace tarkovHelper
{
    public partial class Form1 : Form
    {

        private int index = 0;


        private void ShowElements()
        {
            pictureBox1.Show();
            NameItem.Show();
            PriceItem.Show();
            pictureBox3.Show();
            pictureBox2.Show();
        }
        private void HideElements()
        {
            pictureBox1.Hide();
            NameItem.Hide();
            PriceItem.Hide();
            pictureBox3.Hide();
            pictureBox2.Hide();
        }

        public Form1()
        {
            InitializeComponent();
            HideElements();
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
                if(index < json.data.items.Length-1 && index >= 0)
                {
                    CountFind.Text = "Find: " + json.data.items.Length.ToString();
                    NameItem.Text = $"Name: {json.data.items[index].name}";
                    PriceItem.Text = $"Price: {json.data.items[index].lastLowPrice} ";
                    SetImage(json.data.items[index].gridImageLink);
                    ShowElements();                   
                }
                else
                {
                    index = 0;
                }
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
            index = 0;
            Api();
        }
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Api();
            index--;
            Count.Text = index.ToString();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Api();
            index++;
            Count.Text = index.ToString();
        }
    }
}