using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SavedItXF.Models;
using Xamarin.Forms;

namespace SavedItXF
{
    public partial class MainPage : ContentPage
    {
        private List<SavedItem> _savedItems  = new List<SavedItem>();
        public MainPage()
        {
            InitializeComponent();
        }

        public void OnSave(object sender, EventArgs e)
        {
            decimal price = 0;
            if (decimal.TryParse(PriceText.Text, out price))
            {
                var item = new SavedItem();
                item.Date = DateTime.Now;
                item.Description = DescriptionText.Text;
                item.Price = price;
                _savedItems.Add(item);
                TotalLabel.Text = _savedItems.Sum(i => i.Price).ToString("C");
                DescriptionText.Text = string.Empty;
                PriceText.Text = string.Empty;
            }

        }

        public void OnDetails(object sender, EventArgs e)
        {
            Navigation.PushAsync(new DetailPage(_savedItems));
        }
    }
}
