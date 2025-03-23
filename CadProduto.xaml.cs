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
    }
}