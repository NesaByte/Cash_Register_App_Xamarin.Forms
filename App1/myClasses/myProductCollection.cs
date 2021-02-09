using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using Xamarin.Forms;

namespace App1.myClasses
{
    public class myProductCollection
    {
        private ObservableCollection<myProduct> _products;

        public ObservableCollection<myProduct> products
        {

            get
            {
                return _products ?? (_products = new ObservableCollection<myProduct>());
            }

            set { }
        }
        public myProductCollection(INavigation navigation)
        {
            products = new ObservableCollection<myProduct>();
            products.Add(new myProduct() { name = "Pants", qty = "20", price = "50.7" });
            products.Add(new myProduct() { name = "Shoes", qty = "50", price = "90.0" });
            products.Add(new myProduct() { name = "Hats", qty = "10", price = "20.5" });
            products.Add(new myProduct() { name = "Tshirts", qty = "10", price = "10.0" });
            products.Add(new myProduct() { name = "Dresses", qty = "24", price = "10.0" });

        }
    }
}
