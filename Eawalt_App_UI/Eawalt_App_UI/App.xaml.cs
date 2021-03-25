using Eawalt_App_UI.View;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Eawalt_App_UI
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            MainPage = new TransferPaymentView();
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
