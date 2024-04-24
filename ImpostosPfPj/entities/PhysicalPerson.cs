using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ImpostosPfPj.entities
{
    class PhysicalPerson : Person
    {
        public  double HealthExpenditures{ get; set; }
        public PhysicalPerson()
        {

        }
        public PhysicalPerson(string name, double annualIncome, double healthExpenditures) :base (name, annualIncome)
        {
            HealthExpenditures = healthExpenditures;
        }

        public override double TaxPaid()
        {
            double Tax = 0.15;
            if (AnnualIncome >= 20000.00){
                Tax = 0.25;
            }
            return AnnualIncome * Tax - HealthExpenditures * 0.5;
        }
    }
}