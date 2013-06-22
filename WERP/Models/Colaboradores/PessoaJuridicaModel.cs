using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WERP.Models.Colaboradores
{
    public class PessoaJuridicaModel : PessoaModel
    {
        public string Cnpj { get; set; }
        public string RazaoSocial { get; set; }
        public string NomeFantasia { get; set; }
        public string Ie { get; set; }
        public string Im { get; set; }
        public bool Simples { get; set; }
    }
}