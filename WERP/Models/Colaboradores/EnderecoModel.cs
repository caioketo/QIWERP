using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WERP.Models.Colaboradores
{
    public class EnderecoModel : BaseModel
    {
        public string Logradouro { get; set; }
        public string Numero { get; set; }
        public string Complemento { get; set; }
        public string Bairro { get; set; }
        public CidadeModel Cidade { get; set; }
        public string CEP { get; set; }
    }
}