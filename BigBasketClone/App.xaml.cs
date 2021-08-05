using BigBasketClone.views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BigBasketClone
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            //MainPage = new NavigationPage(new LoginAndSignupPage());
            MainPage = new HomePage();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
