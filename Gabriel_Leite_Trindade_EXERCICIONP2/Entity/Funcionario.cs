using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gabriel_Leite_Trindade_EXERCICIONP2.Entity
{
    internal class Funcionario
    {
        public string Name { get; private set; }

        public string Register { get; private set; }

        public double Paybase { get; private set; }

        public double Payment { get; protected set; }



        public Funcionario() { }

        public Funcionario(string name, string register, double paybase)
        {
            Name = name; 
            Register = register; 
            Paybase = paybase;
        }

        public string getName()
        {
            return this.Name;      
        
        }
        public string getRegister()
        {
            return this.Register;

        }
        public double getPaybase()
        {
            return this.Paybase;

        }
        public double getPayment() {
            return this.Payment;
        }

        public void setName(string name)
        {
            this.Name = name;
        }

        public void setRegister(string register)
        {
            this.Register = register;
        }

        public void setPaybase(double paybase)
        {
            this.Paybase = paybase;
        }

        public void setPayment(double payment)
        {
            this.Payment = payment;
        }


    }
}
