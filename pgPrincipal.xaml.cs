namespace TelaLogin;

public partial class pgPrincipal : ContentPage
{
    public pgPrincipal()
    {
        InitializeComponent();
        var usuarioLogado = UsuarioLogado.Instancia;
        txtUsuarioLogado.Text =
            "Olá " + usuarioLogado.Usuario + ". Seja bem-vindo!";
        txtNome.Text = "Nome: " + usuarioLogado.Nome;
        txtIdade.Text = (usuarioLogado.Idade == 0) ? 
        "Idade não definida" : "Idade: "+ usuarioLogado.Idade.ToString();
        txtEmail.Text = "Email: " + usuarioLogado.Email;
        }

    private void btnVoltar_Cliked(object sender, EventArgs e)
    {
        Application.Current.MainPage.
                 Navigation.PopAsync();
    }
}