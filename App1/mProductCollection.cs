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
                new mProduct("Shoes", "20", "50.7"),
                new mProduct("Hats", "20", "50.7"),
                new mProduct("Tshirts", "20", "50.7"),
                new mProduct("Dresses", "20", "50.7"),

            };
            return products;
        }

        //public static myProductCollection(INavigation navigation)
        //{
        //    products = new ObservableCollection<myProduct>();
        //    products.Add(new myProduct() { name = "Pants", qty = "20", price = "50.7" });
        //    products.Add(new myProduct() { name = "Shoes", qty = "50", price = "90.0" });
        //    products.Add(new myProduct() { name = "Hats", qty = "10", price = "20.5" });
        //    products.Add(new myProduct() { name = "Tshirts", qty = "10", price = "10.0" });
        //    products.Add(new myProduct() { name = "Dresses", qty = "24", price = "10.0" });

        //}
        //public myProductCollection() { }
    }


}
