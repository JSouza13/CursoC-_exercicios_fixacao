using System;
using System.Globalization;
using System.Collections.Generic;
using fixacao01.dominio;
namespace fixacao01
{
    class Program
    {

        public static List<Produto> produtos = new List<Produto>();


        static void Main(string[] args)
        {
            int opcaoMenu = 0;

            produtos.Add(new Produto(1001, "Cadeira simples", 500.00));
            produtos.Add(new Produto(1002, "Cadeira acolchoada", 900.00));
            produtos.Add(new Produto(1003, "Sofá de três lugares", 2000.00));
            produtos.Add(new Produto(1004, "Mesa retangular", 1500.00));
            produtos.Add(new Produto(1005, "Mesa retangular", 2000.00));
            produtos.Sort();

            while (opcaoMenu != 5)
            {
                Console.Clear();
                Tela.mostrarMenu();

                try
                {
                    opcaoMenu = int.Parse(Console.ReadLine());
                }
                catch (Exception e)
                {
                    Console.WriteLine("Erro inesperado: " + e.Message);
                    opcaoMenu = 0;
                }

                if (opcaoMenu == 1)
                {
                    Tela.mostrarProdutos();
                }
                else if (opcaoMenu == 2)
                {
                    try
                    {
                        Tela.cadastrarProduto();
                    }
                    catch(Exception e)
                    {
                        Console.WriteLine("Erro inesperado: "+e.Message);
                    }
                }
                else if (opcaoMenu == 3)
                {

                }
                else if (opcaoMenu == 4)
                {

                }
                else if (opcaoMenu == 5)
                {
                    Console.WriteLine("Fim do programa!");
                }
                else
                {
                    Console.WriteLine("Opção inválida!");
                }
                Console.ReadLine();
            }

            
        }        
    }
}
