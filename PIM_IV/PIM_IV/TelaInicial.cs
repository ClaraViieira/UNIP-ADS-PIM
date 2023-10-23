using System;
using System.Windows.Forms;

namespace PIM_IV
{
    public partial class TelaInicial : Form
    {
        public TelaInicial()
        {
            InitializeComponent();
        }

        private void btnCadastrarFuncionarios_Click(object sender, EventArgs e)
        {
            CadastrarFuncionarios cadastrarFuncionarios = new CadastrarFuncionarios();
            cadastrarFuncionarios.ShowDialog();
        }

        private void btnFolhaPagamento_Click(object sender, EventArgs e)
        {
            FolhaPagamento folhaPagamento = new FolhaPagamento();
            folhaPagamento.ShowDialog(); 
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Deseja realmente fechar o formulário?", "Confirmação de Fechamento", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
