using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WERP.Models.Colaboradores
{
    public class CidadeModel : BaseModel
    {
        public string Descricao { get; set; }
        public string CodigoIBGE { get; set; }
        public UFModel UF { get; set; }
    }
}