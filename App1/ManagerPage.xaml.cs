using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App1
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ManagerPage : ContentPage
    {
        public ManagerPage()
        {
            InitializeComponent();
        }
        async void History_Clicked(System.Object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new HistoryPage());
        }
        async void Restock_Clicked(System.Object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new Restock());
        }

        async void AddNewProduct_Clicked(System.Object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new AddNewProduct());
        }
    }
}