using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace webapp
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
         Web.Source = "https://mardplay.com/feed";
        }

        async void OnBackButtonClicked(object sender, EventArgs e)
        {
            if (Web.CanGoBack)
            {
                Web.GoBack();
            }
            else
            {
                await Navigation.PopAsync();
            }
        }

        void OnForwardButtonClicked(object sender, EventArgs e)
        {
            if (Web.CanGoForward)
            {
                Web.GoForward();
            }
        }
    }
}
