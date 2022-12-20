using System.Diagnostics;
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

            var data = new Dictionary<string, string>()
            {           
                {"query", "{items(name: \""+item+"\") { id name lastLowPrice }}"}
            };
            using (var httpClient = new HttpClient())
            {

                //Http response message
                var httpResponse = await httpClient.PostAsJsonAsync("https://api.tarkov.dev/graphql", data);

                //Response content
                var responseContent = await httpResponse.Content.ReadAsStringAsync();
                var json = JsonConvert.DeserializeObject<Rootobject>(responseContent);
                NameItem.Text = json.data.items[0].lastLowPrice.ToString();
            }
        }

        private void FindBtn_Click(object sender, EventArgs e)
        {
            Api();
        }
    }
}