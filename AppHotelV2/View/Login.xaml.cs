using AppHotelV2.Model;
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
    public partial class Login : ContentPage
    {
        public Login()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            try
            {
                List<DadosUsuario> list_usuarios = new List<DadosUsuario>
                {
                    new DadosUsuario
                    {
                        Usuario = "Gabriel Oliveira",
                        Senha = "dev@2022"
                    },
                    new DadosUsuario
                    {
                        Usuario = "Aluno",
                        Senha = "etecjau"
                    }
                };

                DadosUsuario dados_digitados = new DadosUsuario()
                {
                    Usuario = txt_usuario.Text,
                    Senha = txt_senha.Text
                };

                if(list_usuarios.Any(i => (i.Usuario == dados_digitados.Usuario && i.Senha == dados_digitados.Senha)))
                {
                    App.Current.Properties.Add("usuario_logado", txt_usuario.Text);
                    App.Current.MainPage = new OrcamentoHospedagem();
                } else
                {
                    throw new Exception("Dados Incorretos, tente novamente.");
                }
            } catch (Exception err)
            {
                DisplayAlert("Ooops", err.Message, "OK");
            }
        }
    }
}