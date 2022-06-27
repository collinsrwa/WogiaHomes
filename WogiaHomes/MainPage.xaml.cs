using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using WogiaHomes.Model;

namespace WogiaHomes
{
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);
            this.BindingContext = this;
        }
       
       public List<Property> PropertyList => GetPropertyTypes();
       public List<PropertType> PropertyTypeList => GetPropertyTypeList();

        private static List<PropertType> GetPropertyTypeList()
        {
            return new List<PropertType>
            {
                new PropertType { TypeName = "All"},
                new PropertType { TypeName = "Studio"},
                new PropertType { TypeName = "4 Bdm"},
                new PropertType { TypeName = "3 Bdm"},
                new PropertType { TypeName = "Office "}
            };
        }

        private static List<Property> GetPropertyTypes()
        {
            return new List<Property>
            {
                new Property{PropertyName ="Luxury Homes", Image="Apt1.jpg", Address="Beijing Road", Location="Syokimau", Bath="2 Bath", Bed="2 Bed", Price="$ 1500/Mo", Space="100 sqft",Details="Featuring free WiFi, this is an all-suite hotel located in Nairobi. Free private parking and 24-hour security is available at the property."},
                new Property{PropertyName ="Luxury Inn", Image="Apt2.jpg", Address="Mombasa Road", Location="Syokimau", Bath="2 Bath", Bed="2 Bed", Price="$ 900/Mo", Space="80 sqft",Details="Featuring free WiFi, this is an all-suite hotel located in Nairobi. Free private parking and 24-hour security is available at the property."},
                new Property{PropertyName ="Luxury Appartments", Image="Apt3.jpg", Address="Katani Road", Location="Syokimau", Bath="3 Bath", Bed="3 Bed", Price="$ 1800/Mo", Space="150 sqft",Details="Featuring free WiFi, this is an all-suite hotel located in Nairobi. Free private parking and 24-hour security is available at the property."}
            };
        }
        private async void PropertySelected(object sender, EventArgs e)
        {
            var property = (sender as View).BindingContext as Property;
            if (property != null)
                await this.Navigation.PushAsync(new DetailsPage(property));
        }


    }
}
