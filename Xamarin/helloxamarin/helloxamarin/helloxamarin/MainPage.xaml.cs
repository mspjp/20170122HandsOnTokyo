using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace helloxamarin
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            this.Button.Clicked += Button_Clicked;
        }
        private void Button_Clicked(object sender, EventArgs e)
        {
            this.Label.Text = "Hello World!";
        }
    }
}
