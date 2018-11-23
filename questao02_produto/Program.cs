using System;
using System.Collections.Generic;

namespace questao02_produto
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Produto> listaProduto = new List<Produto>();

            Console.WriteLine("Digite a qtdd de produtos que deseja adicionar: ");
            int qtd = Int32.Parse(Console.ReadLine());

            for (int i = 1; i <= 10; i++)
            {
                Produto produto = new Produto();

                Console.WriteLine("\nDigite o nome o produto: ");
                produto.Nome = Console.ReadLine();

                Console.WriteLine("Digite o preco do produto: ");
                produto.Preco = double.Parse(Console.ReadLine());


                Categoria categoria = new Categoria();

                Console.WriteLine("Digite a categoria do produto: ");
                categoria.Tipo = Console.ReadLine();

                produto.Categoria = categoria;

                listaProduto.Add(produto);

            }

            foreach (var e in listaProduto)
            {
                Console.WriteLine("\n" + e.Nome + " - " + e.Categoria.Tipo);
            }
        }
    }
}
