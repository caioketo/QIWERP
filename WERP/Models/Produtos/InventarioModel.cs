using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WERP.Models.Produtos
{
    public class InventarioModel : BaseModel
    {
        public EstoqueModel Estoque { get; set; }
        public ProdutoModel Produto { get; set; }
        public double Quantidade { get; set; }
    }
}