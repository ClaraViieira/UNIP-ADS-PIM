using System;
using PIM_IV.Controllers;
using PIM_IV.Models;
using PIM_IV.DAO;
using System.Windows.Forms;

namespace PIM_IV
{
    public partial class FolhaPagamento : Form
    {
        FolhaDePagamento folhaDePagamento;
        Descontos descontos;
        Proventos proventos;
        CtrFolhaDePagamento ctrFolhaDePagamento;

        public FolhaPagamento()
        {
            InitializeComponent();
            folhaDePagamento = new FolhaDePagamento();
            descontos = new Descontos();
            proventos = new Proventos();
            ctrFolhaDePagamento = new CtrFolhaDePagamento();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        { 

            if (ValidarCampos())
            {
                folhaDePagamento.CPF = txtCpf.Text;
                bool cpfExists = ctrFolhaDePagamento.validarCpfFuncionario(folhaDePagamento);

                if (cpfExists)
                {

                    folhaDePagamento.CPF = txtCpf.Text;
                    ctrFolhaDePagamento.readFuncionarios(descontos, folhaDePagamento);
                    folhaDePagamento.MesReferencia = txtMesReferencia.Text;
                    proventos.AdicionalNoturno = Convert.ToString(txtAdNoturno.Text);
                    proventos.HorasExtras = Convert.ToString(txtHorasExtras.Text);
                    proventos.Comissao = Convert.ToDecimal(txtComissao.Text);
                    descontos.QtdeDiasFaltas = Convert.ToInt32(txtDiasFaltas.Text);
                    descontos.QtdeDiasTrabalhados = Convert.ToInt32(txtDiasTrabalhados.Text);
                    ctrFolhaDePagamento.createFolhaPagamento(descontos, proventos, folhaDePagamento);
                    LimparDadosTxt();
                }
                else
                {
                    MessageBox.Show("CPF não encontrado no banco de dados.");
                }
            }
            else
            {
                MessageBox.Show("Preencher todos os campos obrigatoriamente.");
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (txtCpf.MaskCompleted && txtMesReferencia.MaskCompleted)
            {
                folhaDePagamento.CPF = txtCpf.Text;
                bool cpfExists = ctrFolhaDePagamento.validarCpfFolhaPagamento(folhaDePagamento);

                if (cpfExists)
                {
                    folhaDePagamento.MesReferencia = txtMesReferencia.Text;
                    ctrFolhaDePagamento.readFolhaPagamento(folhaDePagamento);
                    lblNomeFolha.Text = folhaDePagamento.Nome;
                    lblCpfFolha.Text = folhaDePagamento.CPF;
                    lblMesReferencia.Text = folhaDePagamento.MesReferencia;
                    lblAdicionalNoturno.Text = Convert.ToString(folhaDePagamento.ProventoAdicionalNoturno);
                    lblHorasExtras.Text = Convert.ToString(folhaDePagamento.ProventoHorasExtras);
                    lblComissao.Text = Convert.ToString(folhaDePagamento.ProventoComissao);
                    lblInss.Text = Convert.ToString(folhaDePagamento.DescontoINSS);
                    lblIrrf.Text = Convert.ToString(folhaDePagamento.DescontoIRRF);
                    lblValeTransporte.Text = Convert.ToString(folhaDePagamento.DescontoVT);
                    lblValeAlimentacao.Text = Convert.ToString(folhaDePagamento.DescontoVA);
                    lblValeRefeicao.Text = Convert.ToString(folhaDePagamento.DescontoVR);
                    lblPlanoOdonto.Text = Convert.ToString(folhaDePagamento.DescontoPO);
                    lblPlanoSaude.Text = Convert.ToString(folhaDePagamento.DescontoPS);
                    lblSalarioBase.Text = Convert.ToString(folhaDePagamento.SalarioBase);
                    lblSalarioBruto.Text = Convert.ToString(folhaDePagamento.SalarioBruto);
                    lblSalarioLiquido.Text = Convert.ToString(folhaDePagamento.SalarioLiquido);
                }
                else
                {
                    MessageBox.Show("CPF não encontrado no banco de dados.");
                }
            }
            else
                MessageBox.Show("CPF e datas inválidos");
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            LimparDadosTxt();
        }

        private bool ValidarCampos()
        {
            if (txtCpf.Text != "" && txtMesReferencia.Text != "" && txtAdNoturno.Text != "" && txtHorasExtras.Text != "" &&
                txtComissao.Text != "" && txtDiasTrabalhados.Text != "" && txtDiasFaltas.Text != "")
                return true;
            else return false;
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Deseja realmente fechar o formulário?", "Confirmação de Fechamento", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnLimparDados2_Click(object sender, EventArgs e)
        {
            txtCpf.Text = "";
            txtMesReferencia.Text = "";
            lblNomeFolha.Text = "";
            lblMesReferencia.Text = "";
            lblCpfFolha.Text = "";
            lblAdicionalNoturno.Text = "";
            lblHorasExtras.Text = "";
            lblComissao.Text = "";
            lblInss.Text = "";
            lblIrrf.Text = "";
            lblValeTransporte.Text = "";
            lblValeAlimentacao.Text = "";
            lblValeRefeicao.Text = "";
            lblPlanoOdonto.Text = "";
            lblPlanoSaude.Text = "";
            lblSalarioBase.Text = "";
            lblSalarioBruto.Text = "";
            lblSalarioLiquido.Text = "";
            txtCpf.Focus();
        }

        private void LimparDadosTxt()
        {
            txtCpf.Text = "";
            txtMesReferencia.Text = "";
            txtAdNoturno.Text = "";
            txtHorasExtras.Text = "";
            txtComissao.Text = "";
            txtDiasTrabalhados.Text = "";
            txtDiasFaltas.Text = "";
            txtCpf.Focus();
        }
    }
}
