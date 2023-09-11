using Exercicio04.Entities;
using Exercicio04.Entities.Enums;
using System.Globalization;


namespace Exercicio04;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> list = new List<Shape>();

        Console.Write("Entre com o números de formas: ");
        int n = int.Parse(Console.ReadLine());

        for (int i = 1; i <= n; i++)
        {
            Console.WriteLine($"Dados da forma nº{i}:");

            Console.Write("Retângulo ou Círculo? (r/c): ");
            char response = char.Parse(Console.ReadLine());

            Console.Write("Digite a cor (Preto, Azul, Vermelho): ");
            Color color = Enum.Parse<Color>(Console.ReadLine());

            if (response == 'r')
            {
                Console.Write("Largura: ");
                double width = double.Parse(Console.ReadLine());

                Console.Write("Altura: ");
                double height = double.Parse(Console.ReadLine());

                list.Add(new Rectangle(width, height, color));
            }
            else
            {
                Console.Write("Raio: ");
                double radius = double.Parse(Console.ReadLine());

                list.Add(new Circle(radius, color));
            }
        }

        Console.WriteLine();
        Console.WriteLine("Área das formas:");
        foreach (Shape shape in list)
        {
            Console.WriteLine(shape.Area().ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
