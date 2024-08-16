using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n1, n2, soma;
            string nome;
            Console.WriteLine("digite seu nome: ");
            nome = Console.ReadLine();
            Console.WriteLine("digite o primeiro numero");
            n1 = int.Parse(Console.ReadLine());
            
            Console.WriteLine("digite o segundo numero");
            n2 = int.Parse(Console.ReadLine());
            soma = n1 + n2;
            Console.WriteLine(nome + ", a soma dos numeros é " + soma );



        }
    }
}
