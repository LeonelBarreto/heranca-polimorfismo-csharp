using System.Globalization;
using Exercicio03.Entities;

namespace Exercicio03;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Entre com o número de produtos: ");
        int n = int.Parse(Console.ReadLine());

        List<Product> list = new List<Product>();

        for (int i = 1; i <= n; i++)
        {
            Console.WriteLine($"Dados do produto #{i}:");
            Console.Write("Nome: ");
            string name = Console.ReadLine();

            Console.Write("Preço: R$ ");
            double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine();
            Console.Write("Produto é Comum, Usado ou Importado? (c/u/i): ");
            char category = char.Parse(Console.ReadLine());

            if (category == 'i')
            {
                Console.Write("Taxa Alfandegária: R$ ");
                double fee = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                list.Add(new ImportedProduct(name, price, fee));
            }
            else if (category == 'u')
            {
                Console.Write("Data de Fabricação (MM/dd/yyyy): ");
                DateTime date = DateTime.Parse(Console.ReadLine());
                list.Add(new UsedProduct(name, price, date));
            }
            else
            {
                list.Add(new Product(name, price));
            }
        }

        Console.WriteLine();

        Console.WriteLine("Preço dos produtos:");

        foreach (Product product in list)
        {
            Console.WriteLine(product.PriceTag());
        }
    }
}

