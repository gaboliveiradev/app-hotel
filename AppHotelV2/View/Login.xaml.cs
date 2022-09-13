using AppHotelV2.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using AppHotelV2.Model;

namespace AppHotelV2.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Login : ContentPage
    {
        App PropriedadesApp;

        public Login()
        {
            InitializeComponent();
            PropriedadesApp = (App)Application.Current;
            NavigationPage.SetHasNavigationBar(this, false);
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            try
            {
                string email = txt_email.Text;
                string senha = txt_senha.Text;

                if (PropriedadesApp.list_usuarios.Any(i => (i.Email == email && i.Senha == senha)))
                {
                    App.Current.Properties.Add("usuario_logado", email);
                    App.Current.MainPage = new OrcamentoHospedagem();
                } else throw new Exception("Dados incorretos, tente novamente.");
            } catch (Exception err)
            {
                DisplayAlert("Ooops", err.Message, "OK");
            }
        }
    }
}