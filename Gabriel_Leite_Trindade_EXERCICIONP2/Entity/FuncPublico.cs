using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gabriel_Leite_Trindade_EXERCICIONP2.Entity
{
    internal class FuncPublico : Funcionario
    {
        public double HealthInsurance { get; set; }
        public double totalTaxes { get; set; }

        public FuncPublico() { }

        public FuncPublico(string name, string register, double paybase, double healthInsurance)
        {
            HealthInsurance = healthInsurance;
        }

        public void setHealthInsurance(double healthInsurance)
        {
            this.HealthInsurance = healthInsurance;
        }


        public double getPaymentPublic()
        {
            this.HealthInsurance = Paybase - 329.92;
            return Payment = HealthInsurance;

        }

        public double getTaxes()
        {
            this.HealthInsurance = Paybase - 329.92;
            return totalTaxes = 329.92;
        }
    }
}
