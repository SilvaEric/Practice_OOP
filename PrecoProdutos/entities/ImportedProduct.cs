using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

namespace PrecoProdutos.entities
{
    public class ImportedProduct : Product
    {
        public double CustomsFee { get; set; }

        public ImportedProduct()
        {

        }
        public ImportedProduct(string name, double price, double customsFee) :base (name, price){
            CustomsFee = customsFee;
        }

        public override string PriceTag()
        {
            Price += CustomsFee;
            return Name 
            + " $ "
            + Price.ToString("F2", CultureInfo.InvariantCulture) 
            + " (Customs fee: $ " 
            + CustomsFee.ToString("F2", CultureInfo.InvariantCulture) 
            + ")";
        }
    }
}