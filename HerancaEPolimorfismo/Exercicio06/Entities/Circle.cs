using Exercicio06.Entities.Enums;

namespace Exercicio06.Entities
{
	class Circle : Shape
	{
        public double Radius { get; set; }

        public Circle(double radius, Color color) : base(color)
        {
            Radius = radius;
        }

        public override double Area()
        {
            return Math.PI * Radius * Radius;
        }
    }
}

