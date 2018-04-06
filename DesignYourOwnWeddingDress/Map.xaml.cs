using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace DesignYourOwnWeddingDress
{
    public partial class Map : ContentPage
    {
        public Map()
        {
            InitializeComponent();
        }

        void Open_StockistWebPage(object sender, System.EventArgs e)
        {
            Device.OpenUri(new Uri("http://www.houseofmooshki.com/stockists/"));
        }
    }
}
