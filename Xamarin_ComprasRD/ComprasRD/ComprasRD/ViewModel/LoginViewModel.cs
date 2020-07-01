using ComprasRD.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ComprasRD.ViewModel
{
    public class LoginViewModel : INotifyPropertyChanged
    {
        public LoginViewModel()
        {
            // LoginCommand = new Command(Login);
            //esto es en dado caso de que llame un async
            LoginCommand = new Command(async () => await Login());
        }

        private string _user = String.Empty;
        private string _password = string.Empty;
        private bool _isBusy;

        public event PropertyChangedEventHandler PropertyChanged;

        //void OnPropertyChanged(string name)
        //{
        //    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        //}
        void OnPropertyChanged([CallerMemberName] string name = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }

        public bool IsBusy
        {
            get { return _isBusy; }
            set { _isBusy = value; OnPropertyChanged(); }
        }
        public string User
        {

            get { return _user; }
            set
            {
                _user = value;
                // if(_user != value)
                //{
                //OnPropertyChanged(nameof(User));
                OnPropertyChanged();

                OnPropertyChanged(nameof(DisplayMessage));

                //}

            }
        }
        public string Password
        {

            get { return _password; }
            set
            {
                if (_password != value)
                {
                    _password = value;
                    //  NotifyPropertyChanged();
                    //OnPropertyChanged(nameof(Password));
                    OnPropertyChanged();
                }

            }
        }

        public string DisplayMessage {
            get { return /*"Esto estas escribiendo: "+*/_user; }

        }
        public Command LoginCommand { get; }

        async Task Login()
        {

            if (string.IsNullOrEmpty(User))
            {
                await App.Current.MainPage.DisplayAlert("Error", "You must enter User", "Accept");
                return;
            }
            if (string.IsNullOrEmpty(Password))
            {
                await App.Current.MainPage.DisplayAlert("Error", "You must enter Password", "Accept");
                return;
            }
            if (Password != "123" || User != "123")
            {
                await App.Current.MainPage.DisplayAlert("Error", "You  User or Password is Incorrect ", "Accept");
                return;
            }

            IsBusy = true;            
            Application.Current.MainPage = new MasterPageCompra();
            await Task.Delay(3);
            IsBusy = false;
            //Application.Current.MainPage = new NavigationPage(new  MasterPageCompra());
            // await App.Current.MainPage.DisplayAlert("Alert", "Ejecucion", "Ok");
        }

        //async Task Save()
        //{
        //    IsBusy = true;
        //    await Task.Delay(4000);

        //    IsBusy = false;

        //    await App.Current.MainPage.DisplayAlert("Alert", "Saved", "Ok");
        //}











    }
}
