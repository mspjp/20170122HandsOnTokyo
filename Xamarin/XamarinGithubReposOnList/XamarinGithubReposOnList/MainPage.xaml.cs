using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace XamarinGithubReposOnList
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();
            this.Button.Clicked += Button_ClickedAsync;
        }

        private async void Button_ClickedAsync(object sender, EventArgs e)
        {
            var name = this.Entry.Text;
            var result = await GetGithubRepos(name);
            this.List.ItemsSource = result;
        }

        public async Task<IList<string>> GetGithubRepos(string userName)
        {
            var httpClient = new HttpClient();
            httpClient.DefaultRequestHeaders.Add("User-Agent", "Mozilla/5.0 (compatible; MSIE 10.0; Windows NT 6.2;WOW64; Trident / 6.0)");
            var jsonRaw = await httpClient.GetStringAsync(string.Format("https://api.github.com/users/{0}/repos", userName));
            var ret = new List<string>();
            var array = JArray.Parse(jsonRaw);
            foreach (JToken token in array)
            {
                ret.Add(token["name"].Value<string>());
            }
            return ret;
        }
    }
}
