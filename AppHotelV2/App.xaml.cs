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

        public List<DadosUsuario> list_usuarios = new List<DadosUsuario>
        {
            new DadosUsuario()
            {
                Email = "eduardo@etec.com",
                Nome = "Eduardo Frasson",
                Senha = "123"
            },
            new DadosUsuario()
            {
                Email = "gabriel@etec.com",
                Nome = "Gabriel Oliveira",
                Senha = "123"
            },
            new DadosUsuario()
            {
                Email = "aluno@etec.com",
                Nome = "Aluno",
                Senha = "123"
            }
        };

        public App()
        {
            InitializeComponent();
            Thread.CurrentThread.CurrentCulture = new CultureInfo("pt-BR");

            if(Properties.ContainsKey("usuario_logado"))
                MainPage = new NavigationPage(new OrcamentoHospedagem());
            else
                MainPage = new NavigationPage(new Login());
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
