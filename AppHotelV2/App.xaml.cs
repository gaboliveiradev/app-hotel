using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using System.Collections.Generic;
using System.Globalization;
using System.Threading;

using AppHotelV2.Model;
using AppHotelV2.View;

namespace AppHotelV2
{
    public partial class App : Application
    {
        public List<Quarto> lista_quartos = new List<Quarto>
        {
            new Quarto()
            {
                Descricao = "Suíte Premium",
                ValorDiariaAdulto = 110.0,
                ValorDiariaCrianca = 55.0
            },
            new Quarto()
            {
                Descricao = "Suíte Confort",
                ValorDiariaAdulto = 240.0,
                ValorDiariaCrianca = 120.0
            },
            new Quarto()
            {
                Descricao = "Suíte Deluxe",
                ValorDiariaAdulto = 380.0,
                ValorDiariaCrianca = 160.0
            }
        };

        public App()
        {
            InitializeComponent();
            Thread.CurrentThread.CurrentCulture = new CultureInfo("pt-BR");

            MainPage = new NavigationPage(new OrcamentoHospedagem());
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
