using Ezmobile_Futures.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Ezmobile_Futures
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, true);
            MainPage = new TabbedView();
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
