using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace App1 
{
    public class mHistory : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private string _hname;
        public string hname
        {
            get { return _hname; }
            set
            {
                if (value == _hname) { return; }
                _hname = value;
                if (PropertyChanged != null)
                {
                    PropertyChanged(this, new PropertyChangedEventArgs(nameof(hname)));
                }
            }
        }

        private string _hqty;
        public string hqty
        {
            get { return _hqty; }
            set
            {
                if (value == _hqty) { return; }
                _hqty = value;
                if (PropertyChanged != null)
                {
                    PropertyChanged(this, new PropertyChangedEventArgs(nameof(hqty)));
                }
            }
        }

        private string _htotalprice;
        public string htotalprice
        {
            get { return _htotalprice; }
            set
            {
                if (value == _htotalprice) { return; }
                _htotalprice = value;
                if (PropertyChanged != null)
                {
                    PropertyChanged(this, new PropertyChangedEventArgs(nameof(htotalprice)));
                }
            }
        }

        private string _hpurchasedate;
        public string hpurchasedate
        {
            get { return _hpurchasedate; }
            set
            {
                if (value == _htotalprice) { return; }
                _hpurchasedate = value;
                if (PropertyChanged != null)
                {
                    PropertyChanged(this, new PropertyChangedEventArgs(nameof(hpurchasedate)));
                }
            }
        }
        public mHistory() { }
        public mHistory(string hname, string hqty, string htotalprice, string hpurchasedate)
        {
            this.hname = hname;
            this.hqty = hqty;
            this.htotalprice = htotalprice;
            this.hpurchasedate = hpurchasedate;

        }

    }
}
