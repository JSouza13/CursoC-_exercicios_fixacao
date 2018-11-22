using System;
using System.Collections.Generic;
using System.Globalization;
using fixacao01.dominio;

namespace fixacao01
{
    class Tela
    {

        // Classe responsável por conter operações  que interagem com o usuário no modo console

        public static void mostrarMenu()
        {
            Console.WriteLine("1 - Listar produtos ordenadamente");
            Console.WriteLine("2 - Cadastrar produto");
            Console.WriteLine("3 - Cadastrar pedido");
            Console.WriteLine("4 - Mostrar dados de um pedido");
            Console.WriteLine("5 - Sair");
            Console.Write("\nDigite uma opção: ");
        }

        public static void mostrarProdutos()
        {
            Console.WriteLine("\nLISTAGEM DE PRODUTOS: \n");
            for(int i=0;i<Program.produtos.Count; i++)
            {
                Console.WriteLine(Program.produtos[i]);
            }
        }

        public static void cadastrarProduto()
        {
            Console.WriteLine("\nDigite os dados do produto: \n");
            Console.Write("Código: ");
            int codigo = int.Parse(Console.ReadLine());
            Console.Write("Descrição: ");
            string descricao = Console.ReadLine();
            Console.Write("Preço: ");
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Produto novoProduto = new Produto(codigo, descricao, preco);
            Program.produtos.Add(novoProduto);
            Program.produtos.Sort();
        }
    }
}
