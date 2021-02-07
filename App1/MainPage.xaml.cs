using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Essentials;
using System.Collections.ObjectModel;
//using System.Threading.Tasks;

namespace App1
{
    public partial class MainPage : ContentPage
    {
        ObservableCollection<Product> products;
        int num1, num2;
        public MainPage()
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
        public void Number_Clicked(object sender, EventArgs e)
        {
            Button digit = (Button)sender;
            double num = Double.Parse(digit.Text);
            total.Text = total.Text + ((Button)sender).Text;
        }

        void mylist_ItemSelected(System.Object sender, Xamarin.Forms.SelectedItemChangedEventArgs e)
        {
            prodName.Text = (e.SelectedItem as Product).name;
            prodQty.Text = (e.SelectedItem as Product).qty;

            num1 = Convert.ToInt32(prodQty.Text);
            num2 = Convert.ToInt32((e.SelectedItem as Product).price);

            total.Text = (num1 * num2).ToString();
        }


        void Buy_Clicked(System.Object sender, System.EventArgs e)
        {
            (mylist.SelectedItem as Product).qty = "0";
            total.Text = "Total";
            prodName.Text = "Type";
            prodQty.Text = "Quantity";

            //DisplayAlert("HI THERE", "testing", "OK");
            //    //set => SetValue(products[2].qty, "0");
            //    //num1 = products.Count;
            //    //for (int i = 0; i < products.Count; i++) {
            //    //    if (products[i].name == prodName.Text) {
            //    //        products[i].qty = "0";

            //    //    }
            //    //}
        }
    }
}
