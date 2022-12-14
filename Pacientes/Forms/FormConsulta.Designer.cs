
namespace Pacientes
{
    partial class FormConsulta
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtCodProntuario = new System.Windows.Forms.Label();
            this.txtProntuario = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.txtNomePaciente = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCpf = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtRg = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboTop = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboTipo = new System.Windows.Forms.ComboBox();
            this.Consultar = new System.Windows.Forms.Button();
            this.dgvConsulta = new System.Windows.Forms.DataGridView();
            this.txtCodPaciente = new System.Windows.Forms.Label();
            this.txtCod = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtSituacao = new System.Windows.Forms.TextBox();
            this.Limpar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsulta)).BeginInit();
            this.SuspendLayout();
            // 
            // txtCodProntuario
            // 
            this.txtCodProntuario.AutoSize = true;
            this.txtCodProntuario.Location = new System.Drawing.Point(355, 36);
            this.txtCodProntuario.Name = "txtCodProntuario";
            this.txtCodProntuario.Size = new System.Drawing.Size(58, 13);
            this.txtCodProntuario.TabIndex = 27;
            this.txtCodProntuario.Text = "Prontuário:";
            // 
            // txtProntuario
            // 
            this.txtProntuario.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtProntuario.Location = new System.Drawing.Point(460, 33);
            this.txtProntuario.MaximumSize = new System.Drawing.Size(135, 23);
            this.txtProntuario.Multiline = true;
            this.txtProntuario.Name = "txtProntuario";
            this.txtProntuario.ReadOnly = true;
            this.txtProntuario.Size = new System.Drawing.Size(135, 23);
            this.txtProntuario.TabIndex = 5;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(24, 75);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(97, 13);
            this.label19.TabIndex = 82;
            this.label19.Text = "Nome do paciente:";
            // 
            // txtNomePaciente
            // 
            this.txtNomePaciente.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNomePaciente.Location = new System.Drawing.Point(142, 75);
            this.txtNomePaciente.MaximumSize = new System.Drawing.Size(135, 21);
            this.txtNomePaciente.Multiline = true;
            this.txtNomePaciente.Name = "txtNomePaciente";
            this.txtNomePaciente.Size = new System.Drawing.Size(135, 21);
            this.txtNomePaciente.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 84;
            this.label2.Text = "CPF:";
            // 
            // txtCpf
            // 
            this.txtCpf.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCpf.Location = new System.Drawing.Point(142, 112);
            this.txtCpf.MaximumSize = new System.Drawing.Size(135, 23);
            this.txtCpf.Multiline = true;
            this.txtCpf.Name = "txtCpf";
            this.txtCpf.ReadOnly = true;
            this.txtCpf.Size = new System.Drawing.Size(86, 23);
            this.txtCpf.TabIndex = 3;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(24, 154);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(26, 13);
            this.label8.TabIndex = 86;
            this.label8.Text = "RG:";
            // 
            // txtRg
            // 
            this.txtRg.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtRg.Location = new System.Drawing.Point(142, 151);
            this.txtRg.MaximumSize = new System.Drawing.Size(135, 23);
            this.txtRg.Multiline = true;
            this.txtRg.Name = "txtRg";
            this.txtRg.ReadOnly = true;
            this.txtRg.Size = new System.Drawing.Size(86, 23);
            this.txtRg.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(355, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 88;
            this.label1.Text = "Exibir top:";
            // 
            // comboTop
            // 
            this.comboTop.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboTop.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboTop.FormattingEnabled = true;
            this.comboTop.Items.AddRange(new object[] {
            "",
            "TOP 50",
            "TOP 100",
            "TOP 200"});
            this.comboTop.Location = new System.Drawing.Point(460, 115);
            this.comboTop.MaximumSize = new System.Drawing.Size(86, 0);
            this.comboTop.Name = "comboTop";
            this.comboTop.Size = new System.Drawing.Size(86, 21);
            this.comboTop.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(355, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 13);
            this.label3.TabIndex = 90;
            this.label3.Text = "Exibir pacientes:";
            // 
            // comboTipo
            // 
            this.comboTipo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboTipo.FormattingEnabled = true;
            this.comboTipo.Items.AddRange(new object[] {
            "",
            "Internados",
            "Óbito",
            "Alta"});
            this.comboTipo.Location = new System.Drawing.Point(460, 154);
            this.comboTipo.MaximumSize = new System.Drawing.Size(86, 0);
            this.comboTipo.Name = "comboTipo";
            this.comboTipo.Size = new System.Drawing.Size(86, 21);
            this.comboTipo.TabIndex = 7;
            // 
            // Consultar
            // 
            this.Consultar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Consultar.Location = new System.Drawing.Point(660, 33);
            this.Consultar.Name = "Consultar";
            this.Consultar.Size = new System.Drawing.Size(128, 23);
            this.Consultar.TabIndex = 8;
            this.Consultar.Text = "Consultar";
            this.Consultar.UseVisualStyleBackColor = true;
            this.Consultar.Click += new System.EventHandler(this.Consultar_Click);
            // 
            // dgvConsulta
            // 
            this.dgvConsulta.AllowUserToAddRows = false;
            this.dgvConsulta.AllowUserToDeleteRows = false;
            this.dgvConsulta.AllowUserToResizeColumns = false;
            this.dgvConsulta.AllowUserToResizeRows = false;
            this.dgvConsulta.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvConsulta.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvConsulta.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvConsulta.BackgroundColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvConsulta.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvConsulta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConsulta.EnableHeadersVisualStyles = false;
            this.dgvConsulta.Location = new System.Drawing.Point(12, 200);
            this.dgvConsulta.MultiSelect = false;
            this.dgvConsulta.Name = "dgvConsulta";
            this.dgvConsulta.ReadOnly = true;
            this.dgvConsulta.RowHeadersVisible = false;
            this.dgvConsulta.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvConsulta.Size = new System.Drawing.Size(776, 238);
            this.dgvConsulta.TabIndex = 93;
            // 
            // txtCodPaciente
            // 
            this.txtCodPaciente.AutoSize = true;
            this.txtCodPaciente.Location = new System.Drawing.Point(24, 36);
            this.txtCodPaciente.Name = "txtCodPaciente";
            this.txtCodPaciente.Size = new System.Drawing.Size(105, 13);
            this.txtCodPaciente.TabIndex = 94;
            this.txtCodPaciente.Text = "Código do paciente: ";
            // 
            // txtCod
            // 
            this.txtCod.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCod.Location = new System.Drawing.Point(142, 33);
            this.txtCod.MaximumSize = new System.Drawing.Size(29, 23);
            this.txtCod.Multiline = true;
            this.txtCod.Name = "txtCod";
            this.txtCod.Size = new System.Drawing.Size(29, 23);
            this.txtCod.TabIndex = 1;
            this.txtCod.Leave += new System.EventHandler(this.txtCod_Leave);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(355, 75);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(52, 13);
            this.label13.TabIndex = 95;
            this.label13.Text = "Situação:";
            // 
            // txtSituacao
            // 
            this.txtSituacao.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSituacao.Location = new System.Drawing.Point(460, 75);
            this.txtSituacao.MaximumSize = new System.Drawing.Size(135, 23);
            this.txtSituacao.Multiline = true;
            this.txtSituacao.Name = "txtSituacao";
            this.txtSituacao.ReadOnly = true;
            this.txtSituacao.Size = new System.Drawing.Size(135, 23);
            this.txtSituacao.TabIndex = 96;
            // 
            // Limpar
            // 
            this.Limpar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Limpar.Location = new System.Drawing.Point(660, 75);
            this.Limpar.Name = "Limpar";
            this.Limpar.Size = new System.Drawing.Size(128, 23);
            this.Limpar.TabIndex = 97;
            this.Limpar.Text = "Limpar campos";
            this.Limpar.UseVisualStyleBackColor = true;
            this.Limpar.Click += new System.EventHandler(this.Limpar_Click);
            // 
            // FormConsulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Limpar);
            this.Controls.Add(this.txtSituacao);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txtCod);
            this.Controls.Add(this.txtCodPaciente);
            this.Controls.Add(this.dgvConsulta);
            this.Controls.Add(this.Consultar);
            this.Controls.Add(this.comboTipo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboTop);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtRg);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtCpf);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNomePaciente);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.txtProntuario);
            this.Controls.Add(this.txtCodProntuario);
            this.Name = "FormConsulta";
            this.Text = "Formulário de consulta de paciente";
            this.Load += new System.EventHandler(this.FormConsulta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsulta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txtCodProntuario;
        public System.Windows.Forms.TextBox txtProntuario;
        private System.Windows.Forms.Label label19;
        public System.Windows.Forms.TextBox txtNomePaciente;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCpf;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtRg;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboTop;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Consultar;
        private System.Windows.Forms.DataGridView dgvConsulta;
        private System.Windows.Forms.Label txtCodPaciente;
        public System.Windows.Forms.TextBox txtCod;
        public System.Windows.Forms.ComboBox comboTipo;
        private System.Windows.Forms.Label label13;
        public System.Windows.Forms.TextBox txtSituacao;
        public System.Windows.Forms.Button Limpar;
    }
}