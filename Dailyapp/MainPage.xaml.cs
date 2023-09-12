using Dailyapp.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Dailyapp
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        async void registerButton_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new View.Register());
        }

        async void loginButton_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new View.Login());
        }
    }
}
