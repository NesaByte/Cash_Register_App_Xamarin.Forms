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
        //private ObservableCollection<myProduct> _products;
        //static ObservableCollection<mProduct> products;
        //public ObservableCollection<mHistory> history { get; set; }
        //static ObservableCollection<mHistory> history;// = new ObservableCollection<mHistory>();

        int num1;
        double num2;
        public MainPage()
        {
            InitializeComponent();
            //products = new ObservableCollection<myProduct>
            //{
            //    new myProduct(){name = "Pants", qty="20", price ="50.7"},
            //    new myProduct(){name = "Shoes", qty="50", price ="90"},
            //    new myProduct(){name = "Hats", qty="10", price ="20.5"},
            //    new myProduct(){name = "Tshirts", qty="10", price ="10"},
            //    new myProduct(){name = "Dresses", qty="24", price ="10"},
            //};
            //mylist.ItemsSource = products; 

            //mylist.BindingContext = new myProductCollection(Navigation);
            //history = new ObservableCollection<myHistory> { };
            //BindingContext = myProductCollection.;
            //MainPage.products = myProductCollection.getProducts();
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
            //prodQty.Text = (e.SelectedItem as myProduct).qty;

            if (string.IsNullOrEmpty(prodQty.Text)) {
                num1 = 0;
            } else { 
                num1 = Convert.ToInt32(prodQty.Text);
            }
            
            num2 = Convert.ToDouble((e.SelectedItem as mProduct).price);

            double num3 = num1 * num2;
            total.Text = num3.ToString();
        }


        void Buy_Clicked(System.Object sender, System.EventArgs e)
        {
            //    DisplayAlert("Error  ", "Missing Values", "OK");
            
            //string hn = (mylist.SelectedItem as myProduct).name;
            //string hq = (mylist.SelectedItem as myProduct).qty;

            //var tmphtry = new myHistory() { hname = hn, hqty = hq, htotalprice = total.Text, hpurchasedate = "4 Feb 2021" };
            //history.Add(tmphtry);

            //var hpage = new HistoryPage();
            //hpage.BindingContext = tmphtry;
            //await Navigation.PushAsync(hpage);
            //var tmpprod = new myProduct() { name = "AAAAA", qty = "20", price = "50.7" };
            //products.Add(tmpprod);

            if (string.IsNullOrEmpty(prodQty.Text) || mylist.SelectedItem == null)
            {
                DisplayAlert("Error ", "You have to select an item and provide a quantity", "OK");
            } else {

                var tmpprod = new mProduct() { name = "AAAAA", qty = "20", price = "50.7" };
                ProductModel.products.Add(tmpprod);

                //ObservableCollection<mHistory> history;
                //var tmphistory = new mHistory("TEST", "20", "20", "4 Feb 2021");
                //history.Add(tmphistory);

                //ProductModel.history = mHistoryCollection.getHistory();
                var tmphistory = new mHistory("TESTtttttt", "20", "20", "4 Feb 2021");
                ProductModel.history.Add(tmphistory);


                num2 = Convert.ToDouble((mylist.SelectedItem as mProduct).price);
                double num3 = num1 * num2;
                total.Text = num3.ToString();

                num1 = Convert.ToInt32(prodQty.Text);
                num2 = Convert.ToInt32((mylist.SelectedItem as mProduct).qty);
                (mylist.SelectedItem as mProduct).qty = (num2 - num1).ToString();
                total.Text = "Total";
                prodName.Text = "Type";
                prodQty.Text = "";

            }
        }
        async void Manager_Clicked(System.Object sender, System.EventArgs e)
        {
            await Navigation.PushModalAsync(new ManagerPage());
        }
    }

}
