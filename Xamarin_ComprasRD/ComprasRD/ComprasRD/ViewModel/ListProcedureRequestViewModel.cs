using ComprasRD.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;

namespace ComprasRD.ViewModel
{
    public class ListProcedureRequestViewModel //: INotifyPropertyChanged
    {
        public ObservableCollection<ProcedureRequest> ProcedureRequests { get; set; }
        public ListProcedureRequestViewModel()
        {
            ProcedureRequests = new ObservableCollection<ProcedureRequest>();
            //{
             
            //    new ProcedureRequest
            //    {
            //        Id     = 1,
            //        Reference        = "PR-M584TD-845"

            //    },
            //    new ProcedureRequest
            //    {
            //        Id     = 2,
            //        Reference        = "PR-M584TD-999"

            //    }
            //};
            for (int i = 1; i < 5; i++)
            {
                ProcedureRequests.Add(new ProcedureRequest
                {
                    Id = i,
                    Reference = "PR-" +RandomString(5)+"-"+ RandomString(6)

                }
                );
            }
        }

        private static Random random = new Random();
        public static string RandomString(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            return new string(Enumerable.Repeat(chars, length)
              .Select(s => s[random.Next(s.Length)]).ToArray());
        }

       // public event PropertyChangedEventHandler PropertyChanged;


        //void OnPropertyChanged([CallerMemberName] string name = "")
        //{
        //    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        //}

        //private int _id = 1;
        //private String _reference ="MICAHE";
        //public int Id
        //{
        //    get { return _id; }
        //    set
        //    {
        //        _id = value;
        //        OnPropertyChanged();   
        //    }
        //}
    
        //public string Reference
        //{
        //    get { return _reference; }
        //    set
        //    {
        //        _reference = value;
        //        OnPropertyChanged();
        //    }
        //}

        

       

        

    }
}
