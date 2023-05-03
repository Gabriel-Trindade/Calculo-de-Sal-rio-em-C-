using Gabriel_Leite_Trindade_EXERCICIONP2.Entity;

namespace Gabriel_Leite_Trindade_EXERCICIONP2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(cmboxType.SelectedIndex == 0)
            {
                FuncPublico func1 = new FuncPublico();

                func1.setName(txtNome.Text);
                func1.setRegister(txtRegister.Text);
                func1.setPaybase(double.Parse(txtPaybase.Text));

                double payment = func1.getPaymentPublic();

                double taxes = func1.getTaxes();

                txtPayment.Text = payment.ToString("C");
                txtTaxes.Text = taxes.ToString("C");


                rTxtBox.Text = " " +  " Funcionário: " + func1.Name 
                    + " Registro: " + func1.Register + 
                    " Salário base: " + func1.Paybase +
                    " Salário Total: " + payment.ToString("C") +
                    " Impostos: " + taxes.ToString("C") + " " + " ";

            }

            if (cmboxType.SelectedIndex == 1)
            {
                FuncContratado func1 = new FuncContratado();

                func1.setName(txtNome.Text);
                func1.setRegister(txtRegister.Text);
                func1.setPaybase(double.Parse(txtPaybase.Text));

                double payment = func1.getPaymentSigned();

                double taxes = func1.getTotalTaxes();

                txtPayment.Text = payment.ToString("C");
                txtTaxes.Text = taxes.ToString("C");


                rTxtBox.Text += " " + " Funcionário: " + func1.Name
                    + " Registro: " + func1.Register +
                    " Salário base: " + func1.Paybase +
                    " Salário Total: " + payment.ToString("C") +
                    " Impostos: " + taxes.ToString("C") + " " + " ";

            }
        }
    }
}