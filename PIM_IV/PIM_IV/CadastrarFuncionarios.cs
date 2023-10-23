using System;
using PIM_IV.Models;
using PIM_IV.Controllers;
using System.Windows.Forms;

namespace PIM_IV
{
    public partial class CadastrarFuncionarios : Form
    {

        Funcionarios funcionarios;
        CtrFuncionarios ctrFuncionarios;

        public CadastrarFuncionarios()
        {
            InitializeComponent();
            txtCpf.TabIndex = 0;
            funcionarios = new Funcionarios();
            ctrFuncionarios = new CtrFuncionarios();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (ValidarCampos())
            {
                funcionarios.Nome = txtNome.Text;
                funcionarios.CPF = txtCpf.Text;
                funcionarios.RG = txtRg.Text;
                funcionarios.EstadoCivil = cbEstadoCivil.SelectedItem.ToString();
                funcionarios.DataNascimento = txtDtNascimento.Text;
                funcionarios.EnderecoCompleto = txtEnderecoCompleto.Text;
                funcionarios.PIS = txtPis.Text;
                funcionarios.TituloEleitor = txtTituloEleitor.Text;
                funcionarios.CTPS = txtCtps.Text;
                funcionarios.Reservista = txtReservista.Text;
                funcionarios.Cargo = txtCargo.Text;
                funcionarios.SalarioBase = Convert.ToDecimal(txtSalario.Text);
                funcionarios.IndicadorPlanoSaude = cbPs.SelectedItem.ToString();
                funcionarios.IndicadorPlanoOdonto = cbPo.SelectedItem.ToString();
                funcionarios.IndicadorValeTransporte = cbVt.SelectedItem.ToString();
                funcionarios.IndicadorValeRefeicao = cbVr.SelectedItem.ToString();
                funcionarios.IndicadorValeAlimentacao = cbVa.SelectedItem.ToString();
                funcionarios.Banco = txtBanco.Text;
                funcionarios.Agencia = txtAgencia.Text;
                funcionarios.Conta = txtConta.Text;
                ctrFuncionarios.createFuncionarios(funcionarios);
                LimparDados();
            }
            else
            {
                MessageBox.Show("Preencher todos os campos obrigatoriamente.");
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (txtCpf.MaskCompleted)
            {
                funcionarios.CPF = txtCpf.Text;
                bool cpfExists = ctrFuncionarios.validarFuncionario(funcionarios);

                if (cpfExists)
                {
                    funcionarios.CPF = txtCpf.Text;
                    ctrFuncionarios.readFuncionarios(funcionarios);
                    txtNome.Text = funcionarios.Nome;
                    txtCpf.Text = funcionarios.CPF;
                    txtRg.Text = funcionarios.RG;
                    cbEstadoCivil.SelectedItem = funcionarios.EstadoCivil;
                    txtDtNascimento.Text = funcionarios.DataNascimento;
                    txtEnderecoCompleto.Text = funcionarios.EnderecoCompleto;
                    txtPis.Text = funcionarios.PIS;
                    txtTituloEleitor.Text = funcionarios.TituloEleitor;
                    txtCtps.Text = funcionarios.CTPS;
                    txtReservista.Text = funcionarios.Reservista;
                    txtCargo.Text = funcionarios.Cargo;
                    txtSalario.Text = Convert.ToString(funcionarios.SalarioBase);
                    cbPs.SelectedItem = funcionarios.IndicadorPlanoSaude;
                    cbPo.SelectedItem = funcionarios.IndicadorPlanoOdonto;
                    cbVt.SelectedItem = funcionarios.IndicadorValeTransporte;
                    cbVr.SelectedItem = funcionarios.IndicadorValeRefeicao;
                    cbVa.SelectedItem = funcionarios.IndicadorValeAlimentacao;
                    txtBanco.Text = funcionarios.Banco;
                    txtAgencia.Text = funcionarios.Agencia;
                    txtConta.Text = funcionarios.Conta;
                }
                else
                {
                    MessageBox.Show("CPF não encontrado no banco de dados.");
                }
            }
            else
                MessageBox.Show("CPF inválido");
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (txtCpf.MaskCompleted)
            {
                funcionarios.CPF = txtCpf.Text;
                bool cpfExists = ctrFuncionarios.validarFuncionario(funcionarios);

                if (cpfExists)
                {
                    DialogResult result = MessageBox.Show("Tem certeza de que deseja excluir este funcionário?", "Confirmação de Exclusão", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (result == DialogResult.Yes)
                    {
                        ctrFuncionarios.deleteFuncionarios(funcionarios);
                        LimparDados();
                    }
                    else
                    {
                        LimparDados();
                    }
                }
                else
                {
                    MessageBox.Show("CPF não encontrado no banco de dados.");
                }
            }
            else
                MessageBox.Show("CPF inválido");
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            if (ValidarCampos())
            {
                funcionarios.CPF = txtCpf.Text;
                bool cpfExists = ctrFuncionarios.validarFuncionario(funcionarios);

                if (cpfExists)
                {
                    funcionarios.Nome = txtNome.Text;
                    funcionarios.RG = txtRg.Text;
                    funcionarios.EstadoCivil = cbEstadoCivil.SelectedItem.ToString();
                    funcionarios.DataNascimento = txtDtNascimento.Text;
                    funcionarios.EnderecoCompleto = txtEnderecoCompleto.Text;
                    funcionarios.PIS = txtPis.Text;
                    funcionarios.TituloEleitor = txtTituloEleitor.Text;
                    funcionarios.CTPS = txtCtps.Text;
                    funcionarios.Reservista = txtReservista.Text;
                    funcionarios.Cargo = txtCargo.Text;
                    funcionarios.SalarioBase = Convert.ToDecimal(txtSalario.Text);
                    funcionarios.IndicadorPlanoSaude = cbPs.SelectedItem.ToString();
                    funcionarios.IndicadorPlanoOdonto = cbPo.SelectedItem.ToString();
                    funcionarios.IndicadorValeTransporte = cbVt.SelectedItem.ToString();
                    funcionarios.IndicadorValeRefeicao = cbVr.SelectedItem.ToString();
                    funcionarios.IndicadorValeAlimentacao = cbVa.SelectedItem.ToString();
                    funcionarios.Banco = txtBanco.Text;
                    funcionarios.Agencia = txtAgencia.Text;
                    funcionarios.Conta = txtConta.Text;
                    ctrFuncionarios.updateFuncionarios(funcionarios);
                    LimparDados();
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

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            LimparDados();
        }

        private void LimparDados()
        {
            txtNome.Text = "";
            txtCpf.Text = "";
            txtRg.Text = "";
            cbEstadoCivil.SelectedItem = null;
            txtDtNascimento.Text = "";
            txtEnderecoCompleto.Text = "";
            txtPis.Text = "";
            txtTituloEleitor.Text = "";
            txtCtps.Text = "";
            txtReservista.Text = "";
            txtCargo.Text = "";
            txtSalario.Text = "";
            cbPs.SelectedItem = null;
            cbPo.SelectedItem = null;
            cbVt.SelectedItem = null;
            cbVr.SelectedItem = null;
            cbVa.SelectedItem = null;
            txtBanco.Text = "";
            txtAgencia.Text = "";
            txtConta.Text = "";
            txtCpf.Focus();
        }

        private bool ValidarCampos()
        {
            if (txtNome.Text != "" && txtCpf.Text != "" && txtRg.Text != "" && cbEstadoCivil.SelectedItem != null && txtDtNascimento.Text != "" &&
                txtEnderecoCompleto.Text != "" && txtPis.Text != "" && txtTituloEleitor.Text != "" && txtCtps.Text != "" && txtReservista.Text != "" &&
                txtCargo.Text != "" && txtCargo.Text != "" && txtSalario.Text != "" && cbPs.SelectedItem != null && cbPo.SelectedItem != null &&
                cbVt.SelectedItem != null && cbVr.SelectedItem != null && cbVa.SelectedItem != null && txtBanco.Text != "" && txtAgencia.Text != "" && txtConta.Text != "")
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
    }
}
