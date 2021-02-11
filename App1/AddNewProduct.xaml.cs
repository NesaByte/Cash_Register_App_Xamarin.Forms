using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App1
{
    public partial class AddNewProduct : ContentPage
    {
        public AddNewProduct()
        {
            InitializeComponent();
        }

        async void Save_Clicked(System.Object sender, System.EventArgs e)
        {
            if (string.IsNullOrEmpty(newPrice.Text) || string.IsNullOrEmpty(newQty.Text) || string.IsNullOrEmpty(newProd.Text))
            {
                await DisplayAlert("Error ", "You have to completely fill up the form", "OK");
            }
            else {

                var tmpprd = new mProduct(newProd.Text, newQty.Text, newPrice.Text);
                ProductModel.products.Add(tmpprd);
                newProd.Text = "";
                newQty.Text = "";
                newPrice.Text = "";
                await Navigation.PushAsync(new ManagerPage());
                await DisplayAlert("Done ", "New Product Successfully Added", "OK");
                

            }
        }

        async void Cancel_Clicked(System.Object sender, System.EventArgs e) { 
                await Navigation.PushAsync(new MainPage());
        }
    }
}