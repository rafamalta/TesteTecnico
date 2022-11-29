using System;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class FrmPesquisa : Form
    {
        public FrmPesquisa()
        {
            InitializeComponent();
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void botaoSelecionar1_Click(object sender, EventArgs e)
        {
            var form = new FrmFormulario();
            form.descricao = labelDescricao1.Text;
            form.valorA = labelA1.Text;
            form.valorB = labelB1.Text;

            form.ShowDialog();
        }

        private void botaoSelecionar2_Click(object sender, EventArgs e)
        {
            var form = new FrmFormulario();
            form.descricao = labelDescricao2.Text;
            form.valorA = labelA2.Text;
            form.valorB = labelB2.Text;

            form.ShowDialog();
        }

        private void botaoSelecionar3_Click(object sender, EventArgs e)
        {
            var form = new FrmFormulario();
            form.descricao = labelDescricao3.Text;
            form.valorA = labelA3.Text;
            form.valorB = labelB3.Text;

            form.ShowDialog();
        }

        private void botaoSelecionar4_Click(object sender, EventArgs e)
        {
            var form = new FrmFormulario();
            form.descricao = labelDescricao4.Text;
            form.valorA = labelA4.Text;
            form.valorB = labelB4.Text;

            form.ShowDialog();
        }

        private void botaoSelecionar5_Click(object sender, EventArgs e)
        {
            var form = new FrmFormulario();
            form.descricao = labelDescricao5.Text;
            form.valorA = labelA5.Text;
            form.valorB = labelB5.Text;

            form.ShowDialog();
        }

        private void FrmPesquisa_Load(object sender, EventArgs e)
        {            
            BancoDeDados banco = new BancoDeDados();
            banco.conectar();
            var listaFrutas = banco.selectFrutas();

            int cont = 1;
            foreach (var f in listaFrutas)
            {
                if (cont == 1)
                {
                    labelDescricao1.Text = f.Descricao;
                    labelA1.Text = f.Valor_A.ToString();
                    labelB1.Text = f.Valor_B.ToString();
                }
                else if (cont == 2)
                {
                    labelDescricao2.Text = f.Descricao;
                    labelA2.Text = f.Valor_A.ToString();
                    labelB2.Text = f.Valor_B.ToString();
                }
                else if (cont == 3)
                {
                    labelDescricao3.Text = f.Descricao;
                    labelA3.Text = f.Valor_A.ToString();
                    labelB3.Text = f.Valor_B.ToString();
                }
                else if (cont == 4)
                {
                    labelDescricao4.Text = f.Descricao;
                    labelA4.Text = f.Valor_A.ToString();
                    labelB4.Text = f.Valor_B.ToString();
                }
                else if (cont == 5)
                {
                    labelDescricao5.Text = f.Descricao;
                    labelA5.Text = f.Valor_A.ToString();
                    labelB5.Text = f.Valor_B.ToString();
                }
                cont++;
            }
        }
    }
}
