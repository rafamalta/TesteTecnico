using System;
using System.Windows.Forms;
using System.Globalization;

namespace WindowsFormsApp2
{
    public partial class FrmFormulario : Form
    {
        public string descricao = "";
        public string valorA = "";
        public string valorB = "";

        public FrmFormulario()
        {
            InitializeComponent();
        }

        private void Muliplicar_Click(object sender, EventArgs e)
        {
            try
            {
                double calculo = double.Parse(PrimeiroValor.Text, CultureInfo.InvariantCulture) * double.Parse(SegundoValor.Text, CultureInfo.InvariantCulture);
                Resultado.Text = calculo.ToString("F2");
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
        }

        private void Dividir_Click(object sender, EventArgs e)
        {
            try
            {
                if (PrimeiroValor.Text == "0" || SegundoValor.Text == "0")
                {
                    Resultado.Text = "Não é possível dividir por zero!";
                }
                else
                {
                    double calculo = double.Parse(PrimeiroValor.Text, CultureInfo.InvariantCulture) / double.Parse(SegundoValor.Text, CultureInfo.InvariantCulture);
                    Resultado.Text = calculo.ToString("F2");
                }
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
        }

        private void Limpar_Click(object sender, EventArgs e)
        {
            try
            {
                PrimeiroValor.Text = null;
                SegundoValor.Text = null;
                Resultado.Text = null;
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
        }

        private void FrmFormulario_Load(object sender, EventArgs e)
        {
            try
            {
                textDescricao.Text = descricao;
                PrimeiroValor.Text = valorA;
                SegundoValor.Text = valorB;
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);

            }
        }
    }
}
