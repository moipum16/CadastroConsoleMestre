using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroConsoleMestre.Interface.Pessoa
{
    internal interface iPessoaFisica
    {
        public abstract void pergunta();

        public abstract string? Name { get; set; }

        public abstract string? Documento { get; set; }

        public abstract double Imposto { get; set; }

        public abstract DateTime Date { get; set; }
    }
}
