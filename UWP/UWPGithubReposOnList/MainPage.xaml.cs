using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Threading.Tasks;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Popups;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using Newtonsoft.Json;
using UWPGithubReposOnLabel;

// 空白ページのアイテム テンプレートについては、http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409 を参照してください

namespace UWPGithubReposOnList
{
    /// <summary>
    /// それ自体で使用できる空白ページまたはフレーム内に移動できる空白ページ。
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
            this.Button.Click += button_Click;
        }

        private async void button_Click(object sender, RoutedEventArgs e)
        {
            var dialog = new MessageDialog("Get Github repos", "Get Github repos");      // 直接叩きに行く or EditableBlock作ってもいいかも?
            await dialog.ShowAsync();
            var result = await GetGithubRepos("mizune");
            SetListData(result);


        }

        public async void SetListData(string data)
        {
            var sources = JsonConvert.DeserializeObject<List<GithubRepo>>(data);
            Debug.WriteLine("Deserialized object");
            var list = new List<string>();
            sources.ForEach(x =>
            {
                list.Add(x.Url);
            });

            // var res = from x in sources select x.Url;
            foreach (var url in list)
            {             
                this.RepoList.Items.Add(url);
            }

        }

        public async Task<string> GetGithubRepos(string userName) // or not WebClientは使えない
        {
            var httpClient = new HttpClient();
            httpClient.DefaultRequestHeaders.Add("User-Agent", "Mozilla/5.0 (compatible; MSIE 10.0; Windows NT 6.2;WOW64; Trident / 6.0)");
            // Debug.WriteLine(string.Format("https://api.github.com/users/{0}/repos"));

            return await httpClient.GetStringAsync(string.Format("https://api.github.com/users/{0}/repos", userName));

            // this.label.Text = result;

        }
    }
}
