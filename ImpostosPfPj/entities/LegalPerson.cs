using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ImpostosPfPj.entities
{
    class LegalPerson : Person
    {
        public int Employees { get; set; }

        public LegalPerson()
        {

        }

        public LegalPerson(string name, double annualIncome, int employees) :base(name, annualIncome)
        {
            Employees = employees;
        }

        public override double TaxPaid()
        {
            double Tax = 0.0;
           if(Employees > 10)
            {
                Tax = 0.14;
            }
           else
            {
                Tax = 0.16;
            }
            return AnnualIncome * Tax;
        }

    }
}