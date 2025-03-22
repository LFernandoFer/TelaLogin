
using System.Security.Principal;

namespace TelaLogin
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
        }

        private void btnEntrar_Clicked(object sender, EventArgs e)
        {
            
            if (ValidarUsuario(txtUsuario.Text, txtSenha.Text))
            {
                //atribuir valores aos atributos da classe singleton
                {
                    Application.Current.MainPage.
                    Navigation.PushAsync(new pgPrincipal());
                }
            }
            else
                DisplayAlert("Atenção",
                    "Usuário ou Senha inválido.",
                    "OK");
            }

        private bool ValidarUsuario(
            string usuario, string senha)
        {
            var usuarioLogado = UsuarioLogado.Instancia;
            return (((usuarioLogado.Usuario == txtUsuario.Text &&
                    usuarioLogado.Senha == txtSenha.Text)
                    && (!(string.IsNullOrEmpty(txtUsuario.Text)) && (!string.IsNullOrEmpty(txtSenha.Text))
                    )));

        }

        private void cbxMostrarSenha_CheckedChage(object sender, CheckedChangedEventArgs e)
        {
            MostrarSenha();
        }

        private void tapMostrarSenha_Tapped(object sender, TappedEventArgs e)
        {
            cbxMostrarSenha.IsChecked =
                !cbxMostrarSenha.IsChecked;
            MostrarSenha();
        }

        private void MostrarSenha()
        {
            txtSenha.IsPassword = !cbxMostrarSenha.IsChecked;
        }

        private void tapCadastrar_Tapped(object sender, TappedEventArgs e)
        {
            Navigation.PushAsync(new PagCad());
        }
    }
}