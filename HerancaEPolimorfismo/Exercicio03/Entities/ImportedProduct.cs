using System.Globalization;
namespace Exercicio03.Entities
{
	class ImportedProduct : Product
	{
		public double CustomsFee { get; set; }

		public ImportedProduct()
		{
		}

        public ImportedProduct(string name, double price, double customsFee) : base (name, price)
        {
            CustomsFee = customsFee;
        }

        public override string PriceTag()
        {
            return Name
                + " R$ "
                + Price.ToString("F2", CultureInfo.InvariantCulture)
                + " ( Taxa Alfandegária: R$ "
                + CustomsFee.ToString("F2", CultureInfo.InvariantCulture)
                + ")";
        }
    }
}

