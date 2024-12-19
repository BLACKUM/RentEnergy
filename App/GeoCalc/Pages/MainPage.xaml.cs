using GeoCalc.Models;
using GeoCalc.PageModels;

namespace GeoCalc.Pages
{
    public partial class MainPage : ContentPage
    {
        public MainPage(MainPageModel model)
        {
            InitializeComponent();
            BindingContext = model;
        }
    }
}