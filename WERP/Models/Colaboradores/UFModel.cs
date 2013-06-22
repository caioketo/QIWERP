using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WERP.Models.Colaboradores
{
    public class UFModel : BaseModel
    {
        public string Codigo { get; set; }
        public string Descricao { get; set; }
        public string CodigoIBGE { get; set; }
    }
}