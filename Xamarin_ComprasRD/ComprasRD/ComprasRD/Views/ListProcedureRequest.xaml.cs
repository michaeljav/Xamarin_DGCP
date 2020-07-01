using ComprasRD.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ComprasRD.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ListProcedureRequest : ContentPage
    {
        public ListProcedureRequest()
        {
            InitializeComponent();

            BindingContext = new ListProcedureRequestViewModel();
        }


    }
}