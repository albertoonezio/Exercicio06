using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio06
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1, n2 = 0;
            //Solicita o primeiro número
            //depois converte (string/int) e
            //armazena na variavel n1
            Console.Write("Digite o 1º Número: ");
            n1 = int.Parse(Console.ReadLine());

            Console.Write("Digite o 2º Número: ");
            n2 = int.Parse(Console.ReadLine());

            //imprimindo os números
            Console.WriteLine("Você digitou: {0} e {1}", n1, n2);
        }
    }
}
