using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App1
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ListViewUpdate : ContentPage
    {
        ObservableCollection<Product> products;


        public ListViewUpdate()
        {
            InitializeComponent();
            products = new ObservableCollection<Product>
            {
                new Product(){name = "Pants", qty="20", price ="10"},
                new Product(){name = "Shoes", qty="50", price ="10"},
                new Product(){name = "Hats", qty="10", price ="10"},
                new Product(){name = "Tshirts", qty="10", price ="10"},
                new Product(){name = "Dresses", qty="24", price ="10"},
            };
            mylist.ItemsSource = products;
        }

        void mylist_ItemSelected(System.Object sender, Xamarin.Forms.SelectedItemChangedEventArgs e)
        { 
        }

        async void Handle_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            if (e.Item == null)
                return;

            await DisplayAlert("Item Tapped", "An item was tapped.", "OK");

            //Deselect Item
            ((ListView)sender).SelectedItem = null;
        }
    }
}
