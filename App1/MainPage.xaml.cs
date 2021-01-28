using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App1
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            //List<string> names = new List<string> { "A", "B", "C" };
            mylist.ItemSource = names;

            List<Product> products = new List<Product> {
            new Product(){ prod_name = "Hats", prod_qty = "10"};
            }
        }
    }
}
