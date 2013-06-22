using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WERP.Models.Produtos
{
    public class SubGrupoModel : BaseModel
    {
        public string Descricao { get; set; }
        public GrupoModel Grupo { get; set; }
    }
}