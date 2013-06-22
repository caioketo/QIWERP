using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WERP.Models.Produtos
{
    public class CodigoModel : BaseModel
    {
        public string Codigo { get; set; }
        public double Multiplicador { get; set; }
        public ProdutoModel Produto { get; set; }
    }
}