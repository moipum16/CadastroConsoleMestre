using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CadastroConsoleMestre.Objs.Pessoa;

namespace CadastroConsoleMestre.Interface.Master
{
    internal interface iMaster
    {
        public abstract void init();

        public abstract List<PessoaFisica> ?PessoaFisica { get; set; }

        public abstract List<PessoaJuridica> ?PessoaJuridica { get; set; }

    }
}
