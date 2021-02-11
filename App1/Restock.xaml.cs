using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App1
{
    public partial class Restock : ContentPage
    {
        public Restock()
        {
            InitializeComponent();
        }

        void UpdateQty_Clicked(System.Object sender, System.EventArgs e) {

            if (string.IsNullOrEmpty(newQty.Text) || mylist.SelectedItem == null) {
                DisplayAlert("Error ", "You have to select an item and provide a new quantity", "OK");
            } else {
                (mylist.SelectedItem as mProduct).qty = newQty.Text;
                newQty.Text = "";
            }
        }

        async void Cancel_Clicked(System.Object sender, System.EventArgs e) {
            await Navigation.PushAsync(new MainPage());
        }
    }
}