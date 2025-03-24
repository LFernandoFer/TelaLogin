using Microsoft.Maui.Devices;
namespace TelaLogin;

public partial class PagCad : ContentPage
{
    public PagCad()
    {
        InitializeComponent();
    }
    

    private void btnCadastrar_Clicked(object sender, EventArgs e)
    {
            var usuarioLogado = UsuarioLogado.Instancia; 
            usuarioLogado.Nome = txtNome.Text;
            usuarioLogado.Email = txtEmail.Text;
            usuarioLogado.Usuario = txtUsuario.Text;
            usuarioLogado.Senha = txtSenha.Text;
            usuarioLogado.Idade = Convert.ToInt32(txtIdade.Text);

            var resp = DisplayAlert("Sucesso!!",
                "Cadastro conclu�do com " +
                "Sucesso", "OK");
            Navigation.PushAsync(new MainPage());
        }
    
    private void btnVoltar_Clicked(object sender, EventArgs e)
    {
        Navigation.PopAsync();
    }

    private void txtIdade_TextChanged(object sender, TextChangedEventArgs e)
    {
        Entry entry = sender as Entry;

        // Se o texto for vazio ou n�o num�rico, bloqueia a altera��o
        if (!string.IsNullOrEmpty(entry?.Text) && !entry.Text.All(char.IsDigit))
        {
            // Remove o �ltimo caractere inserido, que n�o � um n�mero
            entry.Text = entry.Text.Substring(0, entry.Text.Length - 1);
        }
    }

}
