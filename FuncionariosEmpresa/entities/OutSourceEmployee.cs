using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FuncionariosEmpresa.entities
{
    public class OutSourceEmployee : Employee
    {
        public double AdditionalCharge { get; set; }

        public OutSourceEmployee()
        {

        }
        public OutSourceEmployee(string name, int hours, double valuePerHour, double additionalCharge) : base(name, hours, valuePerHour)
        {
            AdditionalCharge = additionalCharge;
        }

        public override double Payment()
        {
            return base.Payment() + AdditionalCharge * 1.1;
        }
    }
}