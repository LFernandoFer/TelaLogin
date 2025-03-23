namespace TelaLogin;

public partial class pgPrincipal : ContentPage
{
    public pgPrincipal()
    {
        InitializeComponent();

        var usuarioLogado = UsuarioLogado.Instancia;
        txtUsuarioLogado.Text =
        "Olá " + usuarioLogado.Usuario + ". Seja bem-vindo!";
    }
    private void btnCadProd_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new CadProduto());
    }

    private void btnVoltar_Cliked(object sender, EventArgs e)
    {
        Application.Current.MainPage.
                 Navigation.PopAsync();
    }

    private void btnView_Cliked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new ViewProd());
    }
}