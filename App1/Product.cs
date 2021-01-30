using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace App1
{
    class Product// : INotifyPropertyChanged
    {
        public string name { get; set; }
        public string qty { get; set; }
        public string price { get; set; }

        public Product() { }
        public Product(string name, string qty, string price)
        {
            this.name = name;
            this.qty = qty;
            this.price = price;

        }
    }
}
