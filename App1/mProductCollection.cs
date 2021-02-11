using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using Xamarin.Forms;

namespace App1
{
    public class mProductCollection
    {
        static mProductCollection() { }
        public static ObservableCollection<mProduct> getProducts()
        {
            ObservableCollection<mProduct> products = new ObservableCollection<mProduct>() {
                new mProduct("Pants", "20", "50.7"),
                new mProduct("Shoes", "50", "90.0"),
                new mProduct("Hats", "10", "20.5"),
                new mProduct("Tshirts", "10", "10"),
                new mProduct("Dresses", "24", "10"),

            };
            return products;
        }
    }
}
