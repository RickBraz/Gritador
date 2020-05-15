using System;

namespace Gritador
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ola Usuario por favor digite uma frase!");
 
            string frase = Console.ReadLine();
            string mensagem = frase .ToUpper();

            Console.WriteLine(mensagem);
        }
    }
}
