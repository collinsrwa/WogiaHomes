using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WogiaHomes.Model;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace WogiaHomes
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DetailsPage : ContentPage
    {
        public Property Property { get; set; }
        public DetailsPage(Property property)
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);
            this.Property = property;
            this.BindingContext = this;
        }
        private void GoBack(object sender, EventArgs e)
        {
            this.Navigation.PopAsync();
        }
        protected override void OnAppearing()
        {
            base.OnAppearing();
            DetailsView.TranslationY = 600;
            DetailsView.TranslateTo(0, 0, 500, Easing.SinInOut);
        }
    }
}