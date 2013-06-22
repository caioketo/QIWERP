using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WERP.Models.Produtos
{
    public class PrecoModel : BaseModel
    {
        public TabelaModel Tabela { get; set; }
        public ProdutoModel Produto { get; set; }
        public double Venda { get; set; }
        public double Custo { get; set; }

        public double MarkUp
        {
            get
            {
                return ((this.Venda / this.Custo) - 1) * 100;
            }
        }
    }
}