using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WERP.Models.Colaboradores
{
    public class PessoaFisicaModel : PessoaModel
    {
        public string Cpf { get; set; }
        public string Nome { get; set; }
        public string Rg { get; set; }
    }
}