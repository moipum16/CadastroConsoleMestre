using CadastroConsoleMestre.Interface.Pessoa;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CadastroConsoleMestre.Objs.Pessoa
{
    internal class PessoaFisica : iPessoaFisica
    {
        public string ?Name { get; set; } = " ";
        public string ?Documento { get; set; } = " ";

        public double Imposto { get; set; }
        private double rendimento { get; set; }

        public DateTime Date { get; set; }

        public void pergunta()
        {
            try
            {
                Console.WriteLine("");
                Console.WriteLine("Qual o nome?");

                Name = Console.ReadLine();

                Console.WriteLine("");
                Console.WriteLine("Qual sua data de nascimento?");

                Date = Convert.ToDateTime(Console.ReadLine());

                Console.WriteLine("");
                Console.WriteLine("Qual número do CPF?");

                Documento = (Console.ReadLine());

                if (Regex.IsMatch(Documento, @"^\d{3}.\d{3}.\d{3}-\d{2}$"))
                {
                    Console.WriteLine("");
                    Console.WriteLine("Qual número do Rendimento? Ex: 0.00");

                    rendimento = Convert.ToDouble(Console.ReadLine());

                    if (rendimento <= 1500.00)
                    {
                        Imposto = rendimento;

                        Console.WriteLine(value: "");
                        Console.WriteLine("Desconto de 0%");


                    }
                    else if (rendimento > 1501.00 && rendimento < 5000.00)
                    {
                        Imposto = rendimento - (rendimento * 0.03);

                        Console.WriteLine(value: "");
                        Console.WriteLine("Desconto de 3%");

                    }
                    else
                    {
                        Imposto = rendimento - (rendimento * 0.05);

                        Console.WriteLine(value: "");
                        Console.WriteLine("Desconto de 5%");

                    }

                    Console.WriteLine("");
                    Console.WriteLine("Registrado.");

                }
                else
                {
                    Console.WriteLine(value: "");
                    Console.WriteLine("Valor incorreto. Exemplo: 000.000.006-00");

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
