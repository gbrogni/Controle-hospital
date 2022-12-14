
namespace Pacientes
{
    partial class FormMenu
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.CaminhoCadPaciente = new System.Windows.Forms.Button();
            this.CaminhoCadCentroCusto = new System.Windows.Forms.Button();
            this.CaminhoCadInternacao = new System.Windows.Forms.Button();
            this.CaminhoFormMovimentacao = new System.Windows.Forms.Button();
            this.CaminhoConsultaPaciente = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CaminhoCadPaciente
            // 
            this.CaminhoCadPaciente.Location = new System.Drawing.Point(56, 31);
            this.CaminhoCadPaciente.Name = "CaminhoCadPaciente";
            this.CaminhoCadPaciente.Size = new System.Drawing.Size(319, 43);
            this.CaminhoCadPaciente.TabIndex = 0;
            this.CaminhoCadPaciente.Text = "Formulário de cadastro de paciente";
            this.CaminhoCadPaciente.UseVisualStyleBackColor = true;
            this.CaminhoCadPaciente.Click += new System.EventHandler(this.CaminhoCadPaciente_Click);
            // 
            // CaminhoCadCentroCusto
            // 
            this.CaminhoCadCentroCusto.Location = new System.Drawing.Point(438, 31);
            this.CaminhoCadCentroCusto.Name = "CaminhoCadCentroCusto";
            this.CaminhoCadCentroCusto.Size = new System.Drawing.Size(319, 43);
            this.CaminhoCadCentroCusto.TabIndex = 1;
            this.CaminhoCadCentroCusto.Text = "Formulário de cadastro de centro de custo";
            this.CaminhoCadCentroCusto.UseVisualStyleBackColor = true;
            this.CaminhoCadCentroCusto.Click += new System.EventHandler(this.CaminhoCadCentroCusto_Click);
            // 
            // CaminhoCadInternacao
            // 
            this.CaminhoCadInternacao.Location = new System.Drawing.Point(56, 120);
            this.CaminhoCadInternacao.Name = "CaminhoCadInternacao";
            this.CaminhoCadInternacao.Size = new System.Drawing.Size(319, 43);
            this.CaminhoCadInternacao.TabIndex = 2;
            this.CaminhoCadInternacao.Text = "Formulário de cadastro de internação";
            this.CaminhoCadInternacao.UseVisualStyleBackColor = true;
            this.CaminhoCadInternacao.Click += new System.EventHandler(this.CaminhoCadInternacao_Click);
            // 
            // CaminhoFormMovimentacao
            // 
            this.CaminhoFormMovimentacao.Location = new System.Drawing.Point(438, 120);
            this.CaminhoFormMovimentacao.Name = "CaminhoFormMovimentacao";
            this.CaminhoFormMovimentacao.Size = new System.Drawing.Size(319, 43);
            this.CaminhoFormMovimentacao.TabIndex = 3;
            this.CaminhoFormMovimentacao.Text = "Formulário de movimentação";
            this.CaminhoFormMovimentacao.UseVisualStyleBackColor = true;
            this.CaminhoFormMovimentacao.Click += new System.EventHandler(this.CaminhoFormMovimentacao_Click);
            // 
            // CaminhoConsultaPaciente
            // 
            this.CaminhoConsultaPaciente.Location = new System.Drawing.Point(241, 204);
            this.CaminhoConsultaPaciente.Name = "CaminhoConsultaPaciente";
            this.CaminhoConsultaPaciente.Size = new System.Drawing.Size(319, 43);
            this.CaminhoConsultaPaciente.TabIndex = 4;
            this.CaminhoConsultaPaciente.Text = "Formulário de consulta de paciente";
            this.CaminhoConsultaPaciente.UseVisualStyleBackColor = true;
            this.CaminhoConsultaPaciente.Click += new System.EventHandler(this.CaminhoConsultaPaciente_Click);
            // 
            // FormMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CaminhoConsultaPaciente);
            this.Controls.Add(this.CaminhoFormMovimentacao);
            this.Controls.Add(this.CaminhoCadInternacao);
            this.Controls.Add(this.CaminhoCadCentroCusto);
            this.Controls.Add(this.CaminhoCadPaciente);
            this.Name = "FormMenu";
            this.Text = "Menu Principal";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button CaminhoCadPaciente;
        private System.Windows.Forms.Button CaminhoCadCentroCusto;
        private System.Windows.Forms.Button CaminhoCadInternacao;
        private System.Windows.Forms.Button CaminhoFormMovimentacao;
        private System.Windows.Forms.Button CaminhoConsultaPaciente;
    }
}

