using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using System.Net;
using Windows.UI.Popups;
using System.Net.Http;
using System.Diagnostics;

// 空白ページのアイテム テンプレートについては、http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409 を参照してください

namespace UWPGithubReposOnLabel
{
    /// <summary>
    /// それ自体で使用できる空白ページまたはフレーム内に移動できる空白ページ。
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
            this.button.Click += button_Click;
        }

        private async void button_Click(object sender, RoutedEventArgs e)
        {
            var dialog = new MessageDialog("Get Github repos", "Get Github repos");      // 直接叩きに行く or EditableBlock作ってもいいかも?
            await dialog.ShowAsync();
            GetGithubRepos();


        }
        public async void GetGithubRepos(/* string userName */) // or not WebClientは使えない
        {
            var httpClient = new HttpClient();
            // Debug.WriteLine(string.Format("https://api.github.com/users/{0}/repos"));

            var content = await  httpClient.GetStringAsync("https://api.github.com/users/r-ralph/repos");
            
            // this.label.Text = result;

        }
    }
}
