using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App1
{
    public partial class HistoryPageDetails : ContentPage
    {
        public HistoryPageDetails(mHistory h)
        {
            InitializeComponent();

            tit.Text = h.hname;
            dhn.Text = h.hname;
            dhq.Text = h.hqty;
            dht.Text = h.htotalprice;
            dhd.Text = h.hpurchasedate;
        }
    }
}