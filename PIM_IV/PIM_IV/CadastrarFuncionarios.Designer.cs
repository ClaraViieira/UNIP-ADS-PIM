
namespace PIM_IV
{
    partial class CadastrarFuncionarios
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gbDadosPessoais = new System.Windows.Forms.GroupBox();
            this.txtReservista = new System.Windows.Forms.MaskedTextBox();
            this.txtCtps = new System.Windows.Forms.MaskedTextBox();
            this.txtTituloEleitor = new System.Windows.Forms.MaskedTextBox();
            this.txtPis = new System.Windows.Forms.MaskedTextBox();
            this.txtDtNascimento = new System.Windows.Forms.MaskedTextBox();
            this.txtRg = new System.Windows.Forms.MaskedTextBox();
            this.txtCpf = new System.Windows.Forms.MaskedTextBox();
            this.txtEnderecoCompleto = new System.Windows.Forms.TextBox();
            this.lblEnderecoCompleto = new System.Windows.Forms.Label();
            this.lblReservista = new System.Windows.Forms.Label();
            this.lblCtps = new System.Windows.Forms.Label();
            this.lblTituloEleitor = new System.Windows.Forms.Label();
            this.lblPis = new System.Windows.Forms.Label();
            this.cbEstadoCivil = new System.Windows.Forms.ComboBox();
            this.lblEstadoCivil = new System.Windows.Forms.Label();
            this.lblDtNascimento = new System.Windows.Forms.Label();
            this.lblRg = new System.Windows.Forms.Label();
            this.lblCpf = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.gbDadosCargo = new System.Windows.Forms.GroupBox();
            this.txtSalario = new System.Windows.Forms.TextBox();
            this.cbPo = new System.Windows.Forms.ComboBox();
            this.cbPs = new System.Windows.Forms.ComboBox();
            this.cbVt = new System.Windows.Forms.ComboBox();
            this.cbVr = new System.Windows.Forms.ComboBox();
            this.cbVa = new System.Windows.Forms.ComboBox();
            this.lblPs = new System.Windows.Forms.Label();
            this.lblPo = new System.Windows.Forms.Label();
            this.lblVr = new System.Windows.Forms.Label();
            this.lblVt = new System.Windows.Forms.Label();
            this.lblVa = new System.Windows.Forms.Label();
            this.lblSalario = new System.Windows.Forms.Label();
            this.txtCargo = new System.Windows.Forms.TextBox();
            this.lblCargo = new System.Windows.Forms.Label();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnAtualizar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.gbDadosBancarios = new System.Windows.Forms.GroupBox();
            this.txtConta = new System.Windows.Forms.TextBox();
            this.txtBanco = new System.Windows.Forms.TextBox();
            this.txtAgencia = new System.Windows.Forms.TextBox();
            this.lblAgencia = new System.Windows.Forms.Label();
            this.lblConta = new System.Windows.Forms.Label();
            this.lblBanco = new System.Windows.Forms.Label();
            this.btnFechar = new System.Windows.Forms.Button();
            this.gbDadosPessoais.SuspendLayout();
            this.gbDadosCargo.SuspendLayout();
            this.gbDadosBancarios.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbDadosPessoais
            // 
            this.gbDadosPessoais.BackColor = System.Drawing.Color.LightGray;
            this.gbDadosPessoais.Controls.Add(this.txtReservista);
            this.gbDadosPessoais.Controls.Add(this.txtCtps);
            this.gbDadosPessoais.Controls.Add(this.txtTituloEleitor);
            this.gbDadosPessoais.Controls.Add(this.txtPis);
            this.gbDadosPessoais.Controls.Add(this.txtDtNascimento);
            this.gbDadosPessoais.Controls.Add(this.txtRg);
            this.gbDadosPessoais.Controls.Add(this.txtCpf);
            this.gbDadosPessoais.Controls.Add(this.txtEnderecoCompleto);
            this.gbDadosPessoais.Controls.Add(this.lblEnderecoCompleto);
            this.gbDadosPessoais.Controls.Add(this.lblReservista);
            this.gbDadosPessoais.Controls.Add(this.lblCtps);
            this.gbDadosPessoais.Controls.Add(this.lblTituloEleitor);
            this.gbDadosPessoais.Controls.Add(this.lblPis);
            this.gbDadosPessoais.Controls.Add(this.cbEstadoCivil);
            this.gbDadosPessoais.Controls.Add(this.lblEstadoCivil);
            this.gbDadosPessoais.Controls.Add(this.lblDtNascimento);
            this.gbDadosPessoais.Controls.Add(this.lblRg);
            this.gbDadosPessoais.Controls.Add(this.lblCpf);
            this.gbDadosPessoais.Controls.Add(this.txtNome);
            this.gbDadosPessoais.Controls.Add(this.lblNome);
            this.gbDadosPessoais.Location = new System.Drawing.Point(3, 12);
            this.gbDadosPessoais.Name = "gbDadosPessoais";
            this.gbDadosPessoais.Size = new System.Drawing.Size(793, 140);
            this.gbDadosPessoais.TabIndex = 1;
            this.gbDadosPessoais.TabStop = false;
            this.gbDadosPessoais.Text = "Dados Pessoais";
            // 
            // txtReservista
            // 
            this.txtReservista.Location = new System.Drawing.Point(662, 80);
            this.txtReservista.Mask = "00.000.000000.0";
            this.txtReservista.Name = "txtReservista";
            this.txtReservista.Size = new System.Drawing.Size(125, 22);
            this.txtReservista.TabIndex = 9;
            // 
            // txtCtps
            // 
            this.txtCtps.Location = new System.Drawing.Point(408, 80);
            this.txtCtps.Mask = "00000 / 0000";
            this.txtCtps.Name = "txtCtps";
            this.txtCtps.Size = new System.Drawing.Size(101, 22);
            this.txtCtps.TabIndex = 8;
            // 
            // txtTituloEleitor
            // 
            this.txtTituloEleitor.Location = new System.Drawing.Point(115, 80);
            this.txtTituloEleitor.Mask = "0000.0000.0000 / 000 / 000";
            this.txtTituloEleitor.Name = "txtTituloEleitor";
            this.txtTituloEleitor.Size = new System.Drawing.Size(189, 22);
            this.txtTituloEleitor.TabIndex = 7;
            // 
            // txtPis
            // 
            this.txtPis.Location = new System.Drawing.Point(220, 47);
            this.txtPis.Mask = "000.00000.00-0";
            this.txtPis.Name = "txtPis";
            this.txtPis.Size = new System.Drawing.Size(113, 22);
            this.txtPis.TabIndex = 4;
            // 
            // txtDtNascimento
            // 
            this.txtDtNascimento.Location = new System.Drawing.Point(480, 47);
            this.txtDtNascimento.Mask = "00/00/0000";
            this.txtDtNascimento.Name = "txtDtNascimento";
            this.txtDtNascimento.Size = new System.Drawing.Size(89, 22);
            this.txtDtNascimento.TabIndex = 5;
            // 
            // txtRg
            // 
            this.txtRg.Location = new System.Drawing.Point(54, 47);
            this.txtRg.Mask = "00.000.000-0";
            this.txtRg.Name = "txtRg";
            this.txtRg.Size = new System.Drawing.Size(100, 22);
            this.txtRg.TabIndex = 3;
            // 
            // txtCpf
            // 
            this.txtCpf.Location = new System.Drawing.Point(54, 20);
            this.txtCpf.Mask = "000.000.000-00";
            this.txtCpf.Name = "txtCpf";
            this.txtCpf.Size = new System.Drawing.Size(113, 22);
            this.txtCpf.TabIndex = 1;
            // 
            // txtEnderecoCompleto
            // 
            this.txtEnderecoCompleto.Location = new System.Drawing.Point(147, 112);
            this.txtEnderecoCompleto.Name = "txtEnderecoCompleto";
            this.txtEnderecoCompleto.Size = new System.Drawing.Size(640, 22);
            this.txtEnderecoCompleto.TabIndex = 10;
            // 
            // lblEnderecoCompleto
            // 
            this.lblEnderecoCompleto.AutoSize = true;
            this.lblEnderecoCompleto.Location = new System.Drawing.Point(10, 113);
            this.lblEnderecoCompleto.Name = "lblEnderecoCompleto";
            this.lblEnderecoCompleto.Size = new System.Drawing.Size(140, 17);
            this.lblEnderecoCompleto.TabIndex = 18;
            this.lblEnderecoCompleto.Text = "Endereço Completo: ";
            // 
            // lblReservista
            // 
            this.lblReservista.AutoSize = true;
            this.lblReservista.Location = new System.Drawing.Point(577, 83);
            this.lblReservista.Name = "lblReservista";
            this.lblReservista.Size = new System.Drawing.Size(79, 17);
            this.lblReservista.TabIndex = 16;
            this.lblReservista.Text = "Reservista:";
            // 
            // lblCtps
            // 
            this.lblCtps.AutoSize = true;
            this.lblCtps.Location = new System.Drawing.Point(354, 83);
            this.lblCtps.Name = "lblCtps";
            this.lblCtps.Size = new System.Drawing.Size(48, 17);
            this.lblCtps.TabIndex = 14;
            this.lblCtps.Text = "CTPS:";
            // 
            // lblTituloEleitor
            // 
            this.lblTituloEleitor.AutoSize = true;
            this.lblTituloEleitor.Location = new System.Drawing.Point(10, 83);
            this.lblTituloEleitor.Name = "lblTituloEleitor";
            this.lblTituloEleitor.Size = new System.Drawing.Size(91, 17);
            this.lblTituloEleitor.TabIndex = 12;
            this.lblTituloEleitor.Text = "Título Eleitor:";
            // 
            // lblPis
            // 
            this.lblPis.AutoSize = true;
            this.lblPis.Location = new System.Drawing.Point(181, 51);
            this.lblPis.Name = "lblPis";
            this.lblPis.Size = new System.Drawing.Size(33, 17);
            this.lblPis.TabIndex = 10;
            this.lblPis.Text = "PIS:";
            // 
            // cbEstadoCivil
            // 
            this.cbEstadoCivil.FormattingEnabled = true;
            this.cbEstadoCivil.Items.AddRange(new object[] {
            "Casado(a)",
            "Solteiro(a)",
            "Viúvo(a)",
            "Separado(a)",
            "Divorciado(a)"});
            this.cbEstadoCivil.Location = new System.Drawing.Point(666, 47);
            this.cbEstadoCivil.Name = "cbEstadoCivil";
            this.cbEstadoCivil.Size = new System.Drawing.Size(121, 24);
            this.cbEstadoCivil.TabIndex = 6;
            // 
            // lblEstadoCivil
            // 
            this.lblEstadoCivil.AutoSize = true;
            this.lblEstadoCivil.Location = new System.Drawing.Point(575, 50);
            this.lblEstadoCivil.Name = "lblEstadoCivil";
            this.lblEstadoCivil.Size = new System.Drawing.Size(85, 17);
            this.lblEstadoCivil.TabIndex = 8;
            this.lblEstadoCivil.Text = "Estado Civil:";
            // 
            // lblDtNascimento
            // 
            this.lblDtNascimento.AutoSize = true;
            this.lblDtNascimento.Location = new System.Drawing.Point(354, 51);
            this.lblDtNascimento.Name = "lblDtNascimento";
            this.lblDtNascimento.Size = new System.Drawing.Size(120, 17);
            this.lblDtNascimento.TabIndex = 6;
            this.lblDtNascimento.Text = "Data Nascimento:";
            // 
            // lblRg
            // 
            this.lblRg.AutoSize = true;
            this.lblRg.Location = new System.Drawing.Point(10, 51);
            this.lblRg.Name = "lblRg";
            this.lblRg.Size = new System.Drawing.Size(33, 17);
            this.lblRg.TabIndex = 4;
            this.lblRg.Text = "RG:";
            // 
            // lblCpf
            // 
            this.lblCpf.AutoSize = true;
            this.lblCpf.Location = new System.Drawing.Point(10, 25);
            this.lblCpf.Name = "lblCpf";
            this.lblCpf.Size = new System.Drawing.Size(38, 17);
            this.lblCpf.TabIndex = 2;
            this.lblCpf.Text = "CPF:";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(242, 20);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(543, 22);
            this.txtNome.TabIndex = 2;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(183, 25);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(53, 17);
            this.lblNome.TabIndex = 0;
            this.lblNome.Text = "Nome: ";
            // 
            // gbDadosCargo
            // 
            this.gbDadosCargo.BackColor = System.Drawing.Color.LightGray;
            this.gbDadosCargo.Controls.Add(this.txtSalario);
            this.gbDadosCargo.Controls.Add(this.cbPo);
            this.gbDadosCargo.Controls.Add(this.cbPs);
            this.gbDadosCargo.Controls.Add(this.cbVt);
            this.gbDadosCargo.Controls.Add(this.cbVr);
            this.gbDadosCargo.Controls.Add(this.cbVa);
            this.gbDadosCargo.Controls.Add(this.lblPs);
            this.gbDadosCargo.Controls.Add(this.lblPo);
            this.gbDadosCargo.Controls.Add(this.lblVr);
            this.gbDadosCargo.Controls.Add(this.lblVt);
            this.gbDadosCargo.Controls.Add(this.lblVa);
            this.gbDadosCargo.Controls.Add(this.lblSalario);
            this.gbDadosCargo.Controls.Add(this.txtCargo);
            this.gbDadosCargo.Controls.Add(this.lblCargo);
            this.gbDadosCargo.Location = new System.Drawing.Point(3, 159);
            this.gbDadosCargo.Name = "gbDadosCargo";
            this.gbDadosCargo.Size = new System.Drawing.Size(793, 127);
            this.gbDadosCargo.TabIndex = 2;
            this.gbDadosCargo.TabStop = false;
            this.gbDadosCargo.Text = "Dados Cargo";
            // 
            // txtSalario
            // 
            this.txtSalario.Location = new System.Drawing.Point(626, 25);
            this.txtSalario.Name = "txtSalario";
            this.txtSalario.Size = new System.Drawing.Size(159, 22);
            this.txtSalario.TabIndex = 12;
            // 
            // cbPo
            // 
            this.cbPo.FormattingEnabled = true;
            this.cbPo.Items.AddRange(new object[] {
            "Sim",
            "Não"});
            this.cbPo.Location = new System.Drawing.Point(422, 88);
            this.cbPo.Name = "cbPo";
            this.cbPo.Size = new System.Drawing.Size(112, 24);
            this.cbPo.TabIndex = 17;
            // 
            // cbPs
            // 
            this.cbPs.FormattingEnabled = true;
            this.cbPs.Items.AddRange(new object[] {
            "Sim",
            "Não"});
            this.cbPs.Location = new System.Drawing.Point(141, 88);
            this.cbPs.Name = "cbPs";
            this.cbPs.Size = new System.Drawing.Size(112, 24);
            this.cbPs.TabIndex = 16;
            // 
            // cbVt
            // 
            this.cbVt.FormattingEnabled = true;
            this.cbVt.Items.AddRange(new object[] {
            "Sim",
            "Não"});
            this.cbVt.Location = new System.Drawing.Point(673, 58);
            this.cbVt.Name = "cbVt";
            this.cbVt.Size = new System.Drawing.Size(112, 24);
            this.cbVt.TabIndex = 15;
            // 
            // cbVr
            // 
            this.cbVr.FormattingEnabled = true;
            this.cbVr.Items.AddRange(new object[] {
            "Sim",
            "Não"});
            this.cbVr.Location = new System.Drawing.Point(390, 58);
            this.cbVr.Name = "cbVr";
            this.cbVr.Size = new System.Drawing.Size(112, 24);
            this.cbVr.TabIndex = 14;
            // 
            // cbVa
            // 
            this.cbVa.FormattingEnabled = true;
            this.cbVa.Items.AddRange(new object[] {
            "Sim",
            "Não"});
            this.cbVa.Location = new System.Drawing.Point(141, 58);
            this.cbVa.Name = "cbVa";
            this.cbVa.Size = new System.Drawing.Size(112, 24);
            this.cbVa.TabIndex = 13;
            // 
            // lblPs
            // 
            this.lblPs.AutoSize = true;
            this.lblPs.Location = new System.Drawing.Point(10, 90);
            this.lblPs.Name = "lblPs";
            this.lblPs.Size = new System.Drawing.Size(117, 17);
            this.lblPs.TabIndex = 27;
            this.lblPs.Text = "Plano de Saúde: ";
            // 
            // lblPo
            // 
            this.lblPo.AutoSize = true;
            this.lblPo.Location = new System.Drawing.Point(280, 93);
            this.lblPo.Name = "lblPo";
            this.lblPo.Size = new System.Drawing.Size(136, 17);
            this.lblPo.TabIndex = 26;
            this.lblPo.Text = "Plano Odontológico:";
            // 
            // lblVr
            // 
            this.lblVr.AutoSize = true;
            this.lblVr.Location = new System.Drawing.Point(280, 61);
            this.lblVr.Name = "lblVr";
            this.lblVr.Size = new System.Drawing.Size(104, 17);
            this.lblVr.TabIndex = 25;
            this.lblVr.Text = "Vale Refeição: ";
            // 
            // lblVt
            // 
            this.lblVt.AutoSize = true;
            this.lblVt.Location = new System.Drawing.Point(559, 61);
            this.lblVt.Name = "lblVt";
            this.lblVt.Size = new System.Drawing.Size(114, 17);
            this.lblVt.TabIndex = 24;
            this.lblVt.Text = "Vale Transporte:";
            // 
            // lblVa
            // 
            this.lblVa.AutoSize = true;
            this.lblVa.Location = new System.Drawing.Point(10, 61);
            this.lblVa.Name = "lblVa";
            this.lblVa.Size = new System.Drawing.Size(125, 17);
            this.lblVa.TabIndex = 23;
            this.lblVa.Text = "Vale Alimentação: ";
            // 
            // lblSalario
            // 
            this.lblSalario.AutoSize = true;
            this.lblSalario.Location = new System.Drawing.Point(564, 28);
            this.lblSalario.Name = "lblSalario";
            this.lblSalario.Size = new System.Drawing.Size(56, 17);
            this.lblSalario.TabIndex = 21;
            this.lblSalario.Text = "Salário:";
            // 
            // txtCargo
            // 
            this.txtCargo.Location = new System.Drawing.Point(58, 25);
            this.txtCargo.Name = "txtCargo";
            this.txtCargo.Size = new System.Drawing.Size(500, 22);
            this.txtCargo.TabIndex = 11;
            // 
            // lblCargo
            // 
            this.lblCargo.AutoSize = true;
            this.lblCargo.Location = new System.Drawing.Point(10, 28);
            this.lblCargo.Name = "lblCargo";
            this.lblCargo.Size = new System.Drawing.Size(50, 17);
            this.lblCargo.TabIndex = 20;
            this.lblCargo.Text = "Cargo:";
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(12, 377);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(108, 46);
            this.btnSalvar.TabIndex = 21;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(179, 377);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(108, 46);
            this.btnBuscar.TabIndex = 22;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.Location = new System.Drawing.Point(346, 377);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(108, 46);
            this.btnAtualizar.TabIndex = 23;
            this.btnAtualizar.Text = "Atualizar";
            this.btnAtualizar.UseVisualStyleBackColor = true;
            this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(515, 377);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(108, 46);
            this.btnExcluir.TabIndex = 24;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(682, 308);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(108, 46);
            this.btnLimpar.TabIndex = 25;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // gbDadosBancarios
            // 
            this.gbDadosBancarios.BackColor = System.Drawing.Color.LightGray;
            this.gbDadosBancarios.Controls.Add(this.txtConta);
            this.gbDadosBancarios.Controls.Add(this.txtBanco);
            this.gbDadosBancarios.Controls.Add(this.txtAgencia);
            this.gbDadosBancarios.Controls.Add(this.lblAgencia);
            this.gbDadosBancarios.Controls.Add(this.lblConta);
            this.gbDadosBancarios.Controls.Add(this.lblBanco);
            this.gbDadosBancarios.Location = new System.Drawing.Point(3, 293);
            this.gbDadosBancarios.Name = "gbDadosBancarios";
            this.gbDadosBancarios.Size = new System.Drawing.Size(671, 67);
            this.gbDadosBancarios.TabIndex = 14;
            this.gbDadosBancarios.TabStop = false;
            this.gbDadosBancarios.Text = "Dados Bancários";
            // 
            // txtConta
            // 
            this.txtConta.Location = new System.Drawing.Point(562, 27);
            this.txtConta.Name = "txtConta";
            this.txtConta.Size = new System.Drawing.Size(100, 22);
            this.txtConta.TabIndex = 20;
            // 
            // txtBanco
            // 
            this.txtBanco.Location = new System.Drawing.Point(66, 27);
            this.txtBanco.Name = "txtBanco";
            this.txtBanco.Size = new System.Drawing.Size(170, 22);
            this.txtBanco.TabIndex = 18;
            // 
            // txtAgencia
            // 
            this.txtAgencia.Location = new System.Drawing.Point(327, 27);
            this.txtAgencia.Name = "txtAgencia";
            this.txtAgencia.Size = new System.Drawing.Size(100, 22);
            this.txtAgencia.TabIndex = 19;
            // 
            // lblAgencia
            // 
            this.lblAgencia.AutoSize = true;
            this.lblAgencia.Location = new System.Drawing.Point(258, 32);
            this.lblAgencia.Name = "lblAgencia";
            this.lblAgencia.Size = new System.Drawing.Size(63, 17);
            this.lblAgencia.TabIndex = 3;
            this.lblAgencia.Text = "Agência:";
            // 
            // lblConta
            // 
            this.lblConta.AutoSize = true;
            this.lblConta.Location = new System.Drawing.Point(507, 30);
            this.lblConta.Name = "lblConta";
            this.lblConta.Size = new System.Drawing.Size(49, 17);
            this.lblConta.TabIndex = 2;
            this.lblConta.Text = "Conta:";
            // 
            // lblBanco
            // 
            this.lblBanco.AutoSize = true;
            this.lblBanco.Location = new System.Drawing.Point(8, 32);
            this.lblBanco.Name = "lblBanco";
            this.lblBanco.Size = new System.Drawing.Size(52, 17);
            this.lblBanco.TabIndex = 0;
            this.lblBanco.Text = "Banco:";
            // 
            // btnFechar
            // 
            this.btnFechar.BackColor = System.Drawing.Color.Firebrick;
            this.btnFechar.Location = new System.Drawing.Point(680, 377);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(108, 46);
            this.btnFechar.TabIndex = 26;
            this.btnFechar.Text = "Fechar";
            this.btnFechar.UseVisualStyleBackColor = false;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // CadastrarFuncionarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.gbDadosBancarios);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnAtualizar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.gbDadosCargo);
            this.Controls.Add(this.gbDadosPessoais);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "CadastrarFuncionarios";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastrar Funcionários";
            this.gbDadosPessoais.ResumeLayout(false);
            this.gbDadosPessoais.PerformLayout();
            this.gbDadosCargo.ResumeLayout(false);
            this.gbDadosCargo.PerformLayout();
            this.gbDadosBancarios.ResumeLayout(false);
            this.gbDadosBancarios.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbDadosPessoais;
        private System.Windows.Forms.Label lblCpf;
        private System.Windows.Forms.MaskedTextBox txtCpf;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblRg;
        private System.Windows.Forms.MaskedTextBox txtRg;
        private System.Windows.Forms.Label lblPis;
        private System.Windows.Forms.MaskedTextBox txtPis;
        private System.Windows.Forms.Label lblDtNascimento;
        private System.Windows.Forms.MaskedTextBox txtDtNascimento;
        private System.Windows.Forms.Label lblEstadoCivil;
        private System.Windows.Forms.ComboBox cbEstadoCivil;
        private System.Windows.Forms.Label lblTituloEleitor;
        private System.Windows.Forms.MaskedTextBox txtTituloEleitor;
        private System.Windows.Forms.Label lblCtps;
        private System.Windows.Forms.MaskedTextBox txtCtps;
        private System.Windows.Forms.Label lblReservista;
        private System.Windows.Forms.MaskedTextBox txtReservista;
        private System.Windows.Forms.Label lblEnderecoCompleto;
        private System.Windows.Forms.TextBox txtEnderecoCompleto;
        private System.Windows.Forms.GroupBox gbDadosCargo;
        private System.Windows.Forms.Label lblCargo;
        private System.Windows.Forms.TextBox txtCargo;
        private System.Windows.Forms.Label lblSalario;
        private System.Windows.Forms.TextBox txtSalario;
        private System.Windows.Forms.ComboBox cbVa;
        private System.Windows.Forms.ComboBox cbVr;
        private System.Windows.Forms.ComboBox cbVt;
        private System.Windows.Forms.ComboBox cbPs;
        private System.Windows.Forms.ComboBox cbPo;
        private System.Windows.Forms.Label lblVa;
        private System.Windows.Forms.Label lblVr;
        private System.Windows.Forms.Label lblVt;
        private System.Windows.Forms.Label lblPs;
        private System.Windows.Forms.Label lblPo;
        private System.Windows.Forms.GroupBox gbDadosBancarios;
        private System.Windows.Forms.Label lblBanco;
        private System.Windows.Forms.Label lblAgencia;
        private System.Windows.Forms.Label lblConta;
        private System.Windows.Forms.TextBox txtBanco;
        private System.Windows.Forms.TextBox txtAgencia;
        private System.Windows.Forms.TextBox txtConta;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnAtualizar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnFechar;
    }
}

