using CadastroConsoleMestre.Interface.Pessoa;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CadastroConsoleMestre.Objs.Pessoa
{
    internal class PessoaJuridica : iPessoaJuridica
    {
        public string ?Name { get; set; } = " ";
        public string ?Documento { get; set; } = " ";

        public double Imposto { get ; set ; }
        private double rendimento { get; set; }

        public DateTime Date { get; set; }

        public void pergunta()
        {

            try 
            {
                Console.WriteLine("");
                Console.WriteLine("Qual o da empresa?");

                Name = Console.ReadLine();

                Console.WriteLine("");
                Console.WriteLine("Qual a data de fundação?");

                Date = Convert.ToDateTime(Console.ReadLine());

                Console.WriteLine("");
                Console.WriteLine("Qual número do CPNJ?");

                Documento = (Console.ReadLine());

                if (Regex.IsMatch(Documento, @"^(\d{2}.\d{3}.\d{3}/\d{4}-\d{2})|(\d{14})$"))
                {
                    Console.WriteLine("");
                    Console.WriteLine("Qual número do Rendimento? Ex: 0.00");

                    rendimento = Convert.ToDouble(Console.ReadLine());

                    if (rendimento <= 5000.00)
                    {
                        Imposto = rendimento - (rendimento * 0.06);

                        Console.WriteLine(value: "");
                        Console.WriteLine("Desconto de 6%");


                    }
                    else if (rendimento > 5001.00 && rendimento < 10000.00)
                    {
                        Imposto = rendimento - (rendimento * 0.08);

                        Console.WriteLine(value: "");
                        Console.WriteLine("Desconto de 8%");

                    }
                    else
                    {
                        Imposto = rendimento - (rendimento * 0.1);

                        Console.WriteLine(value: "");
                        Console.WriteLine("Desconto de 10%");

                    }

                    Console.WriteLine("");
                    Console.WriteLine("Registrado.");
                }
                else
                {
                    Console.WriteLine(value: "");
                    Console.WriteLine("Valor incorreto. Exemplo: XX.XXX.XXX/0001-XX");

                    throw new Exception();
                }

            }
            catch 
            {
                Console.WriteLine("");
                Console.WriteLine("Valor incorreto.");

                pergunta();
            }
        }
    }
}
