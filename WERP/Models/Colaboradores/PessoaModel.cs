using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WERP.Models.Colaboradores
{
    public class PessoaModel : BaseModel
    {
        public bool Fisica
        {
            get
            {
                return (this is PessoaFisicaModel);
            }
        }

        public bool Juridica
        {
            get
            {
                return (this is PessoaJuridicaModel);
            }
        }

        public string NomeRazao
        {
            get
            {
                if (this.Fisica)
                {
                    return ((PessoaFisicaModel)this).Nome;
                }
                else
                {
                    return ((PessoaJuridicaModel)this).RazaoSocial;
                }
            }
        }
    }
}