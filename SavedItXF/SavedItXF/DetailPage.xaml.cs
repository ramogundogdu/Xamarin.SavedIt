using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SavedItXF.Models;
using Xamarin.Forms;

namespace SavedItXF
{
    public partial class DetailPage : ContentPage
    {
        public DetailPage(List<SavedItem> savedItems )
        {
            InitializeComponent();
            SavedItemsListView.ItemsSource = savedItems;
        }
    }
}
