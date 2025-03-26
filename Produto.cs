using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace TelaLogin
{
    public sealed class Produto
    {

        static Produto _instancia;

        public static Produto Instancia
        {
            get
            {
                return _instancia ?? (_instancia = new Produto());
            }
        }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public string CodBar { get; set; }
        public int Quantidade{ get; set; }
        public string Marca{ get; set; }
        public string UnMed{ get; set; }
        public decimal Preco{ get; set; }
        public string LogUsuario { get; set; }
        public string DataCad { get; set; }

        public string DiretorioImagem { get; set; }

}
}


