using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Essentials;
using System.Collections.ObjectModel; 

namespace App1
{
    public partial class MainPage : ContentPage
    { 
        int num1;
        double num2;
        public MainPage()
        {
            InitializeComponent(); 
        }
        public void Number_Clicked(object sender, EventArgs e)
        {
            Button digit = (Button)sender;
            double num = Double.Parse(digit.Text);
            prodQty.Text = prodQty.Text + ((Button)sender).Text;

            if (string.IsNullOrEmpty(prodQty.Text)) {
                num1 = 0;
            } else {
                num1 = Convert.ToInt32(prodQty.Text);
            }
        }

        void mylist_ItemSelected(System.Object sender, Xamarin.Forms.SelectedItemChangedEventArgs e)
        {
            prodName.Text = (e.SelectedItem as mProduct).name; 

            if (string.IsNullOrEmpty(prodQty.Text)) {
                num1 = 0;
            } else { 
                num1 = Convert.ToInt32(prodQty.Text);
            }
            
            num2 = Convert.ToDouble((e.SelectedItem as mProduct).price);

            double num3 = num1 * num2;
            total.Text = num3.ToString();
        }


        void Buy_Clicked(System.Object sender, System.EventArgs e) { 
            if (string.IsNullOrEmpty(prodQty.Text) || mylist.SelectedItem == null)
            {
                DisplayAlert("Error ", "You have to select an item and provide a quantity", "OK");
            } else {
                string hn = (mylist.SelectedItem as mProduct).name;

                num2 = Convert.ToDouble((mylist.SelectedItem as mProduct).price);
                double num3 = num1 * num2;
                total.Text = num3.ToString();

                num1 = Convert.ToInt32(prodQty.Text);
                num2 = Convert.ToInt32((mylist.SelectedItem as mProduct).qty);
                (mylist.SelectedItem as mProduct).qty = (num2 - num1).ToString();
                string hq = (mylist.SelectedItem as mProduct).qty;

                var tmphistory = new mHistory(hn, num1.ToString(), total.Text, DateTime.Now.ToString());
                ProductModel.history.Add(tmphistory);

                total.Text = "Total";
                prodName.Text = "Type";
                prodQty.Text = "";
            }
        }
        async void Manager_Clicked(System.Object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new ManagerPage());
        }
    }

}
