using System.Globalization;
namespace Exercicio03.Entities
{
	class UsedProduct : Product
	{
		public DateTime ManufactureDate { get; set; }

		public UsedProduct()
		{
		}

        public UsedProduct(string name, double price, DateTime manufactureDate) : base (name, price)
        {
            ManufactureDate = manufactureDate;
        }

        public override string PriceTag()
        {
            return Name
                + " (usado) R$ "
                + Price.ToString("F2", CultureInfo.InvariantCulture)
                + " (Data de Fabricação: "
                + ManufactureDate.ToString("MM/dd/yyyy")
                + ")";
        }
    }
}

