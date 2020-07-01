using ComprasRD.Views;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ComprasRD.ViewModel
{
    public class HomePageViewModel : INotifyCollectionChanged
    {
        public HomePageViewModel()
        {
            btnListProcedureCommand = new Command(async () => await btnListProcedure());
        }
        public Command btnListProcedureCommand { get; }

        public async Task btnListProcedure()
        {
            await Task.Delay(1);
            //await Navigation.pU






            //var masterDetailPage = Application.Current.MainPage as MasterDetailPage;
            var masterDetailPage = App.Current.MainPage as MasterDetailPage;
            var TargetType = typeof(ListProcedureRequest);
            var page = (Page)Activator.CreateInstance(TargetType);
            page.Title = "Lista de Proceseos";
            await masterDetailPage.Detail.Navigation.PushAsync(new ListProcedureRequest());

        
        }

        public event NotifyCollectionChangedEventHandler CollectionChanged;


    }
}
