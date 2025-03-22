using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelaLogin
{
    public sealed class UsuarioLogado
    {
        //classe SingleTon para armazenar o usuario logado
        //Variavel que vai apontar a memoria 
        static UsuarioLogado _instancia;
        //método para retorno da instancia
        public static UsuarioLogado Instancia
        {
            get
            {
                //Retorna o apontamento da instancia em memorai
                //se nao existir cria um apontamento novo 
                return _instancia ?? (_instancia = new UsuarioLogado());
            }
        }
        //Criar o construtor da classe
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Usuario { get; set; }
        //Ira armazenar o nome do usuario logado
        public string Senha { get; set; }
        public int Idade { get; set; }
    public UsuarioLogado(/*string Nome, string Email,string Login
        ,string Senha, int Idade*/) 
        {
           /* Instancia.Nome = Nome;
            Instancia.Email = Email;
            Instancia.Login = Login;
            Instancia.Senha = Senha;
            Instancia.Idade = Idade;
        */
       }

    }
}

