//------------------------------------------------------------------------------
// <auto-generated>
//     Dieser Code wurde von einem Tool generiert.
//     Laufzeitversion:4.0.30319.42000
//
//     Änderungen an dieser Datei können falsches Verhalten verursachen und gehen verloren, wenn
//     der Code erneut generiert wird.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SavedItXF {
    using System;
    using Xamarin.Forms;
    using Xamarin.Forms.Xaml;
    
    
    public partial class MainPage : ContentPage {
        
        private Entry DescriptionText;
        
        private Entry PriceText;
        
        private Button saveButton;
        
        private Label TotalLabel;
        
        private Button detailButton;
        
        private void InitializeComponent() {
            this.LoadFromXaml(typeof(MainPage));
            DescriptionText = this.FindByName<Entry>("DescriptionText");
            PriceText = this.FindByName<Entry>("PriceText");
            saveButton = this.FindByName<Button>("saveButton");
            TotalLabel = this.FindByName<Label>("TotalLabel");
            detailButton = this.FindByName<Button>("detailButton");
        }
    }
}
