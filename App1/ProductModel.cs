using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace App1
{
    public static class ProductModel
    {
        public static ObservableCollection<mProduct> products { get; set; }
        public static ObservableCollection<mHistory> history { get; set; }

        static ProductModel()
        {
            ProductModel.products = mProductCollection.getProducts();

            ProductModel.history = mHistoryCollection.getHistory();

        }
    }
}
