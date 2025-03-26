namespace TelaLogin;

public partial class ViewProd : ContentPage
{
	public ViewProd()
	{
		InitializeComponent();

        RecuperarProduto();
    }

    
    void RecuperarProduto()
    {
        var produto = Produto.Instancia;
        txtNome.Text += produto.Nome;
        txtDescricao.Text += produto.Descricao;
        txtMarca.Text += produto.Marca;
        txtPreco.Text += produto.Preco.ToString();
        txtCodBar.Text += produto.CodBar;
        txtQtd.Text += produto.Quantidade.ToString();
        txtUnMed.Text += produto.UnMed;

        txtUsuario.Text += produto.LogUsuario.ToString();
        txtData.Text += produto.DataCad.ToString();

        imgCarro.Source = produto.DiretorioImagem;
    }

    private void btnCadProd_Clicked(object sender, EventArgs e)
    {
		Navigation.PushAsync(new CadProduto());
    }

    private void btnVoltar_Clicked(object sender, EventArgs e)
    {
        Navigation.PopAsync();  
    }
}