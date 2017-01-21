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
            button.Clicked += (sender, e) =>
            {
                this.labelHelloWorld.Text = "Hello World!";
            };
        }
	}
}
