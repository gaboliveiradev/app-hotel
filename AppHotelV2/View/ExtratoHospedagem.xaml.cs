using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppHotelV2.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ExtratoHospedagem : ContentPage
    {
        App PropriedadesApp;

        public ExtratoHospedagem()
        {
            InitializeComponent();
            PropriedadesApp = (App)Application.Current;
            NavigationPage.SetHasNavigationBar(this, false);
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            try
            {
                App.Current.MainPage = new OrcamentoHospedagem();
            }
            catch (Exception ex)
            {
                DisplayAlert("Ops", ex.Message, "OK");
            }
        }
    }
}