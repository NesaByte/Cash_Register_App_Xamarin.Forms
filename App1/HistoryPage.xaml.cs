using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App1
{
    public partial class HistoryPage : ContentPage
    {
        //public ObservableCollection<mHistory> history;

        public HistoryPage()
        {
            InitializeComponent();
            //history = new ObservableCollection<mHistory>
            //{
            //    //(string hname, string hqty, string htotalprice, string hpurchasedate)
            //    new mHistory(){hname = "TEST hname", hqty="20", htotalprice ="10", hpurchasedate="4 Feb 2021"}, 
            //};
            //myhlist.ItemsSource = history;

            //myhlist.BindingContext = new myHistoryCollection(Navigation);
            //ProductModel.history = mHistoryCollection.getHistory();
        }
    }
} 