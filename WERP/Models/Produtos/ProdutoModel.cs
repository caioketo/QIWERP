using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WERP.Models.Produtos
{
    public class ProdutoModel : BaseModel
    {
        public string Descricao { get; set; }
        public string Apelido { get; set; }
        public MarcaModel Marca { get; set; }
        public GrupoModel Grupo { get; set; }
        public SubGrupoModel SubGrupo { get; set; }
        public List<InventarioModel> Inventarios { get; set; }
        public List<PrecoModel> Precos { get; set; }
        public List<CodigoModel> Codigos { get; set; }
    }
}