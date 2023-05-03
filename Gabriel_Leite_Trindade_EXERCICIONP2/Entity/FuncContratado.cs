using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gabriel_Leite_Trindade_EXERCICIONP2.Entity
{
    internal class FuncContratado : Funcionario
    {
       public double HealthInsurance { get; set; }
       public double FederalTaxes { get; set; }
       
        public double TotalTaxes { get; set; }

        public FuncContratado() { }

        public FuncContratado(string name, string register, double paybase, double healthInsurance, double federalTaxes)
        {
            HealthInsurance = healthInsurance;
            FederalTaxes = federalTaxes;
        }

        public void setHealthInsurance(double healthInsurance)
        {
            this.HealthInsurance = healthInsurance;
        }

        public void setFederalTaxes(double federalTaxes)
        {
            this.FederalTaxes = federalTaxes;
        }

        public double getPaymentSigned()
        {
            this.FederalTaxes = Paybase - (0.18 * Paybase);
            this.HealthInsurance = FederalTaxes - 392.92;
            return Payment = HealthInsurance;

        }

        public double getTotalTaxes()
        {
            double federalTaxes = Paybase * 0.18;
            double healthInsurance = federalTaxes + 392.92;
            return TotalTaxes = healthInsurance;

        }

    }
}
