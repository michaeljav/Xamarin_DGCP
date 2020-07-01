using ComprasRD.Views;
using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ComprasRD
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

           // MainPage = new MainPage();
           // MainPage = new MasterPageCompra();
            MainPage = new Login();

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
