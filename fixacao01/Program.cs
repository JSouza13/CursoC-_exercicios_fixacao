using System;
using System.Globalization;

namespace fixacao01
{
    class Program
    {
        static void Main(string[] args)
        {
            Aluguel[] quartos = new Aluguel[10];

            Console.Write("Quantos aluguéis serão registrados ? ");
            int N = int.Parse(Console.ReadLine());

            for(int i = 0; i<N; i++)
            {
                Console.WriteLine("Dados do " + i + "° aluguel: ");
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("E-mail: ");
                string email = Console.ReadLine();
                Console.Write("Quarto: ");
                int pos = int.Parse(Console.ReadLine());
                quartos[pos] = new Aluguel(nome, email);               
            }

            Console.WriteLine("Quartos ocupados: ");
            for(int i = 0; i<10; i++)
            {
                if(quartos[i] != null)
            }


            Console.ReadLine();
        }
    }
}
