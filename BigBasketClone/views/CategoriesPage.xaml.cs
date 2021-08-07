using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BigBasketClone.views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CategoriesPage : ContentPage
    {
        ObservableCollection<Fruites> fruites { get; set; }
        public CategoriesPage()
        {
            InitializeComponent();
            fruites = new ObservableCollection<Fruites> { 
            
                new Fruites{ Name="F1"},
                new Fruites{ Name="F2"},
                new Fruites{ Name="F3"},
                new Fruites{ Name="F4"},
                new Fruites{ Name="F5"}
            };
            lstoffrutits.ItemsSource = fruites;
            lstoffrutits1.ItemsSource = fruites;
        }

        private void OnExpanderTapped(object sender, EventArgs e)
        {
            Console.WriteLine("Expander tapped.");

        }
    }
}