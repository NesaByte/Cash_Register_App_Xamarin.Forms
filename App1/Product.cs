using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace App1
{
    public class Product : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private string _name;
        public string name
        {
            get { return _name; }
            set
            {
                if (value == _name) { return; } 
                _name = value; 
                if (PropertyChanged != null)
                {
                    PropertyChanged(this, new PropertyChangedEventArgs(nameof(name)));
                }
            }
        }

        private string _qty;
        public string qty
        {
            get { return _qty; }
            set
            {
                if (value == _qty) { return; }
                _qty = value;
                if (PropertyChanged != null)
                {
                    PropertyChanged(this, new PropertyChangedEventArgs(nameof(qty)));
                }
            }
        }

        private string _price;
        public string price
        {
            get { return _price; }
            set
            {
                if (value == _name) { return; }
                _price = value;
                if (PropertyChanged != null)
                {
                    PropertyChanged(this, new PropertyChangedEventArgs(nameof(price)));
                }
            }
        }

        public Product() { }
        public Product(string name, string qty, string price)
        {
            this.name = name;
            this.qty = qty;
            this.price = price;

        }
    }
}
