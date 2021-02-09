using App1.myClasses;
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
            //mylist.BindingContext = new myProductCollection(Navigation);

        }

        void UpdateQty_Clicked(System.Object sender, System.EventArgs e) {

            if (string.IsNullOrEmpty(newQty.Text) || mylist.SelectedItem == null) {
                DisplayAlert("Error ", "You have to select an item and provide a new quantity", "OK");
            } else {
                (mylist.SelectedItem as mProduct).qty = newQty.Text;
            }
            
        }

        async void Cancel_Clicked(System.Object sender, System.EventArgs e) {
            await Navigation.PushModalAsync(new MainPage());
        }

        void mylist_ItemSelected(System.Object sender, Xamarin.Forms.SelectedItemChangedEventArgs e)
        {
            //prodName.Text = (e.SelectedItem as myProduct).name;
            //prodQty.Text = (e.SelectedItem as myProduct).qty;

            //if (string.IsNullOrEmpty(prodQty.Text))
            //{
            //    num1 = 0;
            //}
            //else
            //{
            //    num1 = Convert.ToInt32(prodQty.Text);
            //}

            //num2 = Convert.ToDouble((e.SelectedItem as myProduct).price);

            //double num3 = num1 * num2;
            //total.Text = num3.ToString();

            //newQty;
        }
    }
}