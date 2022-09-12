using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using AppHotelV2.Model;
using AppHotelV2.View;


namespace AppHotelV2.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class OrcamentoHospedagem : ContentPage
    {

        App PropriedadesApp;

        public OrcamentoHospedagem()
        {
            InitializeComponent();
            PropriedadesApp = (App)Application.Current;
            NavigationPage.SetHasNavigationBar(this, false);

            pck_quarto.ItemsSource = PropriedadesApp.lista_quartos;

            dtpck_checkin.MinimumDate = DateTime.Now;
            dtpck_checkin.MaximumDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month + 1, DateTime.Now.Day);

            dtpck_checkout.MinimumDate = dtpck_checkin.Date.AddDays(1);
            dtpck_checkout.MaximumDate = dtpck_checkin.Date.AddMonths(6);
        }

        private void dtpck_checkin_DateSelected(object sender, DateChangedEventArgs e)
        {
            DatePicker elemento = (DatePicker)sender;
            DateTime data_selecionada_checkin = elemento.Date;

            dtpck_checkout.MinimumDate = data_selecionada_checkin.AddDays(1);
            dtpck_checkout.MaximumDate = data_selecionada_checkin.Date.AddMonths(6);
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            try
            {
                Navigation.PushAsync(new ExtratoHospedagem()
                {
                    BindingContext = new Hospedagem()
                    {
                        QntAdultos = Convert.ToInt32(stp_adultos.Value),
                        QntCriancas = Convert.ToInt32(stp_criancas.Value),
                        Suite = (Quarto)pck_quarto.SelectedItem,
                        DataCheckIn = dtpck_checkin.Date,
                        DataCheckOut = dtpck_checkout.Date
                    }
                });
            } catch (Exception err)
            {
                DisplayAlert("Ops", err.Message, "OK");
            }
        }

        private async void btn_desconectar(object sender, EventArgs e)
        {
            bool confirmacao = await DisplayAlert($"{App.Current.Properties["usuario_logado"].ToString()} você tem certeza?", "Sair do App?", "Sim", "Não");

            if (confirmacao)
            {
                App.Current.Properties.Remove("usuario_logado");

                App.Current.MainPage = new Login();
            }
        }
    }
}