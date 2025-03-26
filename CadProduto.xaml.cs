namespace TelaLogin;

public partial class CadProduto : ContentPage
{
	public CadProduto()
	{
		InitializeComponent();
	}

	private void btnCadastrar_Clicked(object sender, EventArgs e)
	{
		var produto = Produto.Instancia;
		var usuarioLogado = UsuarioLogado.Instancia;

		produto.Nome = txtNome.Text;
		produto.Descricao = txtDescricao.Text;
		produto.Marca = txtMarca.Text;
		produto.Preco = Convert.ToDecimal(txtPreco.Text);
		produto.CodBar = txtCodBar.Text;
		produto.UnMed = txtUnMed.Text;
		produto.Quantidade = Convert.ToInt32(txtQtd.Text);

		produto.LogUsuario = usuarioLogado.Usuario;
		produto.DataCad = DateTime.Now.ToString();

        produto.DiretorioImagem = DirImagem;

    DisplayAlert("Sucesso!!", "Produto cadastrado com Sucesso"
			, "OK");

        Navigation.PopAsync();
    }

    void ValidarNumero(object sender, TextChangedEventArgs e)
	{
        Entry entry = sender as Entry;

        // Se o texto for vazio ou não numérico, bloqueia a alteração
        if (!string.IsNullOrEmpty(entry?.Text) && !entry.Text.All(char.IsDigit))
        {
            // Remove o último caractere inserido, que não é um número
            entry.Text = entry.Text.Substring(0, entry.Text.Length - 1);
        }
    }

    private void btnVoltar_Clicked(object sender, EventArgs e)
    {
		Navigation.PopAsync();
    }
    string DirImagem;
    private async void btnAddImg_Clicked(object sender, EventArgs e)
    {
        //variavel para armazenar a imagem

        //Utilizar o componente padrao de seleçao de imagem
        var imagemSelecionada =
            await MediaPicker.PickPhotoAsync();

        //Validar se uma imagem foi selecionada
        if (imagemSelecionada != null)
        {
            //Recupero o Dir da imagem selecionada 
            DirImagem = imagemSelecionada.FullPath;
            imgCarro.Source = DirImagem;
        }
    }
    #region TextChanged

    private void txtPreco_TextChanged(object sender, TextChangedEventArgs e)
    {
		ValidarNumero(sender, e);
    }

    private void txtQtd_TextChanged(object sender, TextChangedEventArgs e)
    {
        ValidarNumero(sender, e);
    }
    #endregion  
}