using CadastroConsoleMestre.Interface.Master;
using CadastroConsoleMestre.Objs.Pessoa;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroConsoleMestre.Objs.Master
{
    internal class Master : iMaster
    {
        public List<PessoaFisica>? PessoaFisica { get; set; }
        public List<PessoaJuridica>? PessoaJuridica { get; set; }

        private bool CriarPessoas { get; set; }
        private bool PessoaFisicas { get; set; }

        public void init()
        {

            PessoaFisica = new List<PessoaFisica>();
            PessoaJuridica = new List<PessoaJuridica>();

            CriarPessoa();

        }

        public void CriarPessoa()
        {
            try
            {
                Console.WriteLine("");
                Console.WriteLine("Criar mais uma pessoa? true ou false.");

                CriarPessoas = Convert.ToBoolean(Console.ReadLine());

                if (CriarPessoas != true) 
                {
                    Console.WriteLine("===== Pessoas Físicas =====");
                    Console.WriteLine("");

                    foreach (var x in PessoaFisica) 
                    {
                        Console.WriteLine($"Nome: {x.Name}, Data de Nascimento: {x.Date} CPF: {x.Documento}, Imposto para pagar: R$: {Convert.ToDouble(x.Imposto)}");
                    }

                    Console.WriteLine("");
                    Console.WriteLine("===== Pessoas Jurídicas =====");
                    Console.WriteLine("");

                    foreach (var x in PessoaJuridica)
                    {
                        Console.WriteLine($"Nome: {x.Name}, CPNJ: {x.Documento}, Data de Fundação: {x.Date} Imposto para pagar: R$: {Convert.ToDouble(x.Imposto)}");
                    }

                    Console.WriteLine("");

                    Console.WriteLine("Pressione qualquer tecla para sair.");

                    Console.ReadKey();

                    Environment.Exit(0);

                }
                else
                {
                    Console.WriteLine("");
                    Console.WriteLine("É Pessoa física? true ou false.");

                    PessoaFisicas = Convert.ToBoolean(Console.ReadLine());

                    if (PessoaFisicas == true)
                    {
                        PessoaFisica.Add(new PessoaFisica());
                        PessoaFisica[PessoaFisica.Count - 1].pergunta();

                        CriarPessoa();
                    }
                    else
                    {
                        PessoaJuridica.Add(new PessoaJuridica());
                        PessoaJuridica[PessoaJuridica.Count - 1].pergunta();

                        CriarPessoa();
                    }
                }
            }
            catch
            {
                Console.WriteLine("");
                Console.WriteLine("Valor incorreto!");

                CriarPessoa();
            }
        }
    }
}
