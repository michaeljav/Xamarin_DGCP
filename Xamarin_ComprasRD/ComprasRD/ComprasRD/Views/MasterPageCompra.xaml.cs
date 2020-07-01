﻿using ComprasRD.Models;
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
    public partial class MasterPageCompra : MasterDetailPage
    {
        public List<MasterPageItem> menuList { get; set; }
        public MasterPageCompra()
        {
            InitializeComponent();
            menuList = new List<MasterPageItem>();

            // Adding menu items to menuList and you can define title ,page and icon
            menuList.Add(new MasterPageItem() { Title = "Home", Icon = "home.png", TargetType = typeof(HomePage) });
            menuList.Add(new MasterPageItem() { Title = "About", Icon = "setting.png", TargetType = typeof(About) });
            

            // Setting our list to be ItemSource for ListView in MainPage.xaml
            navigationDrawerList.ItemsSource = menuList;

            // Initial navigation, this can be used for our home page
            Detail = new NavigationPage((Page)Activator.CreateInstance(typeof(HomePage)));
        }

        // Event for Menu Item selection, here we are going to handle navigation based
        // on user selection in menu ListView
        private void OnMenuItemSelected(object sender, SelectedItemChangedEventArgs e)
        {

            var item = (MasterPageItem)e.SelectedItem;
            Type page = item.TargetType;

            Detail = new NavigationPage((Page)Activator.CreateInstance(page));
            
            IsPresented = false;
        }
    }
}