
namespace PIM_IV
{
    partial class TelaInicial
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
            this.btnFolhaPagamento = new System.Windows.Forms.Button();
            this.btnCadastrarFuncionarios = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnFechar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnFolhaPagamento
            // 
            this.btnFolhaPagamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFolhaPagamento.Location = new System.Drawing.Point(13, 212);
            this.btnFolhaPagamento.Name = "btnFolhaPagamento";
            this.btnFolhaPagamento.Size = new System.Drawing.Size(254, 54);
            this.btnFolhaPagamento.TabIndex = 0;
            this.btnFolhaPagamento.Text = "Folha de Pagamento";
            this.btnFolhaPagamento.UseVisualStyleBackColor = true;
            this.btnFolhaPagamento.Click += new System.EventHandler(this.btnFolhaPagamento_Click);
            // 
            // btnCadastrarFuncionarios
            // 
            this.btnCadastrarFuncionarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrarFuncionarios.Location = new System.Drawing.Point(13, 291);
            this.btnCadastrarFuncionarios.Name = "btnCadastrarFuncionarios";
            this.btnCadastrarFuncionarios.Size = new System.Drawing.Size(254, 52);
            this.btnCadastrarFuncionarios.TabIndex = 1;
            this.btnCadastrarFuncionarios.Text = "Cadastrar Funcionários";
            this.btnCadastrarFuncionarios.UseVisualStyleBackColor = true;
            this.btnCadastrarFuncionarios.Click += new System.EventHandler(this.btnCadastrarFuncionarios_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(775, 173);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "RECURSOS HUMANOS";
            // 
            // btnFechar
            // 
            this.btnFechar.BackColor = System.Drawing.Color.Firebrick;
            this.btnFechar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFechar.Location = new System.Drawing.Point(534, 371);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(254, 54);
            this.btnFechar.TabIndex = 4;
            this.btnFechar.Text = "Encerrar Aplicação";
            this.btnFechar.UseVisualStyleBackColor = false;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // TelaInicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.btnFolhaPagamento);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnCadastrarFuncionarios);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "TelaInicial";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tela Inicial";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnFolhaPagamento;
        private System.Windows.Forms.Button btnCadastrarFuncionarios;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnFechar;
    }
}