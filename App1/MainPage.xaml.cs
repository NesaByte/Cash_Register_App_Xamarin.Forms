using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Essentials;
using System.Collections.ObjectModel;
using App1.myClasses;

namespace App1
{
    public partial class MainPage : ContentPage
    {
        //private ObservableCollection<myProduct> _products;

        public ObservableCollection<myProduct> products { get; set; } 
        public ObservableCollection<myHistory> history { get; set; }

        double num1;
        double num2;
        public MainPage()
        {
            InitializeComponent();
            products = new ObservableCollection<myProduct>
            {
                new myProduct(){name = "Pants", qty="20", price ="50.7"},
                new myProduct(){name = "Shoes", qty="50", price ="90"},
                new myProduct(){name = "Hats", qty="10", price ="20.5"},
                new myProduct(){name = "Tshirts", qty="10", price ="10"},
                new myProduct(){name = "Dresses", qty="24", price ="10"},
            };
            mylist.ItemsSource = products; 

            //mylist.BindingContext = new myProductCollection(Navigation);
            //history = new ObservableCollection<myHistory> { };

        }
        public void Number_Clicked(object sender, EventArgs e)
        {
            Button digit = (Button)sender;
            double num = Double.Parse(digit.Text);
            total.Text = total.Text + ((Button)sender).Text;
        }

        void mylist_ItemSelected(System.Object sender, Xamarin.Forms.SelectedItemChangedEventArgs e)
        {
            prodName.Text = (e.SelectedItem as myProduct).name;
            prodQty.Text = (e.SelectedItem as myProduct).qty;

            num1 = Convert.ToDouble(prodQty.Text);
            num2 = Convert.ToDouble((e.SelectedItem as myProduct).price);

            total.Text = (num1 * num2).ToString();
        }


        void Buy_Clicked(System.Object sender, System.EventArgs e)
        {
            string hn = (mylist.SelectedItem as myProduct).name;
            string hq = (mylist.SelectedItem as myProduct).qty;

            var tmphtry = new myHistory() { hname = hn, hqty = hq, htotalprice = total.Text, hpurchasedate = "4 Feb 2021" };
            history.Add(tmphtry);

            //var hpage = new HistoryPage();
            //hpage.BindingContext = tmphtry;
            //await Navigation.PushAsync(hpage);
            //var tmpprod = new myProduct() { name = "AAAAA", qty = "20", price = "50.7" };
            //products.Add(tmpprod);

            (mylist.SelectedItem as myProduct).qty = "0";
            total.Text = "Total";
            prodName.Text = "Type";
            prodQty.Text = "Quantity";

        }
        async void Manager_Clicked(System.Object sender, System.EventArgs e)
        {
            await Navigation.PushModalAsync(new ManagerPage());
        }
    }

}
