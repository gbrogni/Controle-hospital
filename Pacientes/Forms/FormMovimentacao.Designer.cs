
namespace Pacientes
{
    partial class FormMovimentacao
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
            this.txtCodPaciente = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtProntuario = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.dtpData = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.dtpHora = new System.Windows.Forms.DateTimePicker();
            this.comboMotivo = new System.Windows.Forms.ComboBox();
            this.txtLocal = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtLeito = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txtClinica = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtSequencia = new System.Windows.Forms.TextBox();
            this.txtMedico = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtCrm = new System.Windows.Forms.TextBox();
            this.dgvMovimentacao = new System.Windows.Forms.DataGridView();
            this.Salvar = new System.Windows.Forms.Button();
            this.Excluir = new System.Windows.Forms.Button();
            this.Limpar = new System.Windows.Forms.Button();
            this.txtCod = new System.Windows.Forms.TextBox();
            this.dtpNascimento = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtCns = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.dtpEntrada = new System.Windows.Forms.DateTimePicker();
            this.txtCodCentroCusto = new System.Windows.Forms.TextBox();
            this.txtNomePaciente = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txtNomeCentroCusto = new System.Windows.Forms.TextBox();
            this.LupaCentroCusto = new System.Windows.Forms.Button();
            this.LupaPaciente = new System.Windows.Forms.Button();
            this.label17 = new System.Windows.Forms.Label();
            this.comboSituacao = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMovimentacao)).BeginInit();
            this.SuspendLayout();
            // 
            // txtCodPaciente
            // 
            this.txtCodPaciente.AutoSize = true;
            this.txtCodPaciente.Location = new System.Drawing.Point(25, 63);
            this.txtCodPaciente.Name = "txtCodPaciente";
            this.txtCodPaciente.Size = new System.Drawing.Size(97, 13);
            this.txtCodPaciente.TabIndex = 23;
            this.txtCodPaciente.Text = "Nome do paciente:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 229);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 25;
            this.label2.Text = "Sequência:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(409, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 13);
            this.label3.TabIndex = 26;
            this.label3.Text = "Hora da movimentação:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(409, 162);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 27;
            this.label4.Text = "Localização:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(25, 196);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 13);
            this.label6.TabIndex = 34;
            this.label6.Text = "Prontuário:";
            // 
            // txtProntuario
            // 
            this.txtProntuario.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtProntuario.Location = new System.Drawing.Point(143, 196);
            this.txtProntuario.MaximumSize = new System.Drawing.Size(131, 23);
            this.txtProntuario.Multiline = true;
            this.txtProntuario.Name = "txtProntuario";
            this.txtProntuario.ReadOnly = true;
            this.txtProntuario.Size = new System.Drawing.Size(131, 23);
            this.txtProntuario.TabIndex = 6;
            this.txtProntuario.TextChanged += new System.EventHandler(this.txtProntuario_TextChanged);
            this.txtProntuario.Leave += new System.EventHandler(this.txtProntuario_Leave);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(409, 28);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(120, 13);
            this.label8.TabIndex = 36;
            this.label8.Text = "Data de movimentação:";
            // 
            // dtpData
            // 
            this.dtpData.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpData.Location = new System.Drawing.Point(551, 30);
            this.dtpData.Name = "dtpData";
            this.dtpData.Size = new System.Drawing.Size(135, 20);
            this.dtpData.TabIndex = 9;
            this.dtpData.Value = new System.DateTime(2022, 10, 31, 0, 0, 0, 0);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(25, 261);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(42, 13);
            this.label9.TabIndex = 39;
            this.label9.Text = "Motivo:";
            // 
            // dtpHora
            // 
            this.dtpHora.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpHora.Location = new System.Drawing.Point(551, 65);
            this.dtpHora.Name = "dtpHora";
            this.dtpHora.Size = new System.Drawing.Size(135, 20);
            this.dtpHora.TabIndex = 10;
            this.dtpHora.Value = new System.DateTime(2022, 10, 31, 0, 0, 0, 0);
            // 
            // comboMotivo
            // 
            this.comboMotivo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboMotivo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboMotivo.FormattingEnabled = true;
            this.comboMotivo.Items.AddRange(new object[] {
            "",
            "Transferência",
            "Óbito",
            "Alta",
            "Evasão"});
            this.comboMotivo.Location = new System.Drawing.Point(143, 263);
            this.comboMotivo.MaximumSize = new System.Drawing.Size(131, 0);
            this.comboMotivo.Name = "comboMotivo";
            this.comboMotivo.Size = new System.Drawing.Size(131, 21);
            this.comboMotivo.TabIndex = 8;
            // 
            // txtLocal
            // 
            this.txtLocal.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtLocal.Location = new System.Drawing.Point(551, 168);
            this.txtLocal.MaximumSize = new System.Drawing.Size(131, 23);
            this.txtLocal.Multiline = true;
            this.txtLocal.Name = "txtLocal";
            this.txtLocal.Size = new System.Drawing.Size(131, 23);
            this.txtLocal.TabIndex = 13;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(410, 196);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(33, 13);
            this.label11.TabIndex = 59;
            this.label11.Text = "Leito:";
            // 
            // txtLeito
            // 
            this.txtLeito.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtLeito.Location = new System.Drawing.Point(551, 200);
            this.txtLeito.MaximumSize = new System.Drawing.Size(131, 23);
            this.txtLeito.Multiline = true;
            this.txtLeito.Name = "txtLeito";
            this.txtLeito.Size = new System.Drawing.Size(131, 23);
            this.txtLeito.TabIndex = 14;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(409, 97);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(135, 13);
            this.label12.TabIndex = 61;
            this.label12.Text = "Código do centro de custo:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(409, 229);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(80, 13);
            this.label13.TabIndex = 63;
            this.label13.Text = "Clínica médica:";
            // 
            // txtClinica
            // 
            this.txtClinica.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtClinica.Location = new System.Drawing.Point(551, 229);
            this.txtClinica.MaximumSize = new System.Drawing.Size(131, 23);
            this.txtClinica.Multiline = true;
            this.txtClinica.Name = "txtClinica";
            this.txtClinica.Size = new System.Drawing.Size(131, 23);
            this.txtClinica.TabIndex = 15;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(409, 261);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(45, 13);
            this.label14.TabIndex = 65;
            this.label14.Text = "Médico:";
            // 
            // txtSequencia
            // 
            this.txtSequencia.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSequencia.Location = new System.Drawing.Point(143, 229);
            this.txtSequencia.MaximumSize = new System.Drawing.Size(131, 23);
            this.txtSequencia.Multiline = true;
            this.txtSequencia.Name = "txtSequencia";
            this.txtSequencia.ReadOnly = true;
            this.txtSequencia.Size = new System.Drawing.Size(131, 23);
            this.txtSequencia.TabIndex = 7;
            // 
            // txtMedico
            // 
            this.txtMedico.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMedico.Location = new System.Drawing.Point(551, 263);
            this.txtMedico.MaximumSize = new System.Drawing.Size(131, 23);
            this.txtMedico.Multiline = true;
            this.txtMedico.Name = "txtMedico";
            this.txtMedico.Size = new System.Drawing.Size(131, 23);
            this.txtMedico.TabIndex = 16;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(409, 296);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(34, 13);
            this.label15.TabIndex = 68;
            this.label15.Text = "CRM:";
            // 
            // txtCrm
            // 
            this.txtCrm.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCrm.Location = new System.Drawing.Point(551, 296);
            this.txtCrm.MaximumSize = new System.Drawing.Size(131, 23);
            this.txtCrm.Multiline = true;
            this.txtCrm.Name = "txtCrm";
            this.txtCrm.Size = new System.Drawing.Size(131, 23);
            this.txtCrm.TabIndex = 17;
            // 
            // dgvMovimentacao
            // 
            this.dgvMovimentacao.AllowUserToAddRows = false;
            this.dgvMovimentacao.AllowUserToDeleteRows = false;
            this.dgvMovimentacao.AllowUserToResizeColumns = false;
            this.dgvMovimentacao.AllowUserToResizeRows = false;
            this.dgvMovimentacao.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvMovimentacao.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvMovimentacao.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvMovimentacao.BackgroundColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMovimentacao.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvMovimentacao.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMovimentacao.EnableHeadersVisualStyles = false;
            this.dgvMovimentacao.Location = new System.Drawing.Point(12, 330);
            this.dgvMovimentacao.MultiSelect = false;
            this.dgvMovimentacao.Name = "dgvMovimentacao";
            this.dgvMovimentacao.ReadOnly = true;
            this.dgvMovimentacao.RowHeadersVisible = false;
            this.dgvMovimentacao.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMovimentacao.Size = new System.Drawing.Size(857, 279);
            this.dgvMovimentacao.TabIndex = 70;
            // 
            // Salvar
            // 
            this.Salvar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Salvar.Location = new System.Drawing.Point(741, 28);
            this.Salvar.Name = "Salvar";
            this.Salvar.Size = new System.Drawing.Size(128, 23);
            this.Salvar.TabIndex = 18;
            this.Salvar.Text = "Salvar";
            this.Salvar.UseVisualStyleBackColor = true;
            this.Salvar.Click += new System.EventHandler(this.Salvar_Click);
            // 
            // Excluir
            // 
            this.Excluir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Excluir.Location = new System.Drawing.Point(741, 63);
            this.Excluir.Name = "Excluir";
            this.Excluir.Size = new System.Drawing.Size(128, 23);
            this.Excluir.TabIndex = 19;
            this.Excluir.Text = "Excluir";
            this.Excluir.UseVisualStyleBackColor = true;
            this.Excluir.Click += new System.EventHandler(this.Excluir_Click);
            // 
            // Limpar
            // 
            this.Limpar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Limpar.Location = new System.Drawing.Point(741, 97);
            this.Limpar.Name = "Limpar";
            this.Limpar.Size = new System.Drawing.Size(128, 23);
            this.Limpar.TabIndex = 20;
            this.Limpar.Text = "Limpar campos";
            this.Limpar.UseVisualStyleBackColor = true;
            this.Limpar.Click += new System.EventHandler(this.Limpar_Click);
            // 
            // txtCod
            // 
            this.txtCod.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCod.Location = new System.Drawing.Point(143, 30);
            this.txtCod.MaximumSize = new System.Drawing.Size(30, 21);
            this.txtCod.Multiline = true;
            this.txtCod.Name = "txtCod";
            this.txtCod.ReadOnly = true;
            this.txtCod.Size = new System.Drawing.Size(30, 21);
            this.txtCod.TabIndex = 1;
            // 
            // dtpNascimento
            // 
            this.dtpNascimento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNascimento.Location = new System.Drawing.Point(143, 96);
            this.dtpNascimento.MaximumSize = new System.Drawing.Size(89, 20);
            this.dtpNascimento.Name = "dtpNascimento";
            this.dtpNascimento.Size = new System.Drawing.Size(89, 20);
            this.dtpNascimento.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 162);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 77;
            this.label1.Text = "CNS:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 97);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 13);
            this.label5.TabIndex = 78;
            this.label5.Text = "Data de nascimento:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(25, 28);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(102, 13);
            this.label7.TabIndex = 79;
            this.label7.Text = "Código do paciente:";
            // 
            // txtCns
            // 
            this.txtCns.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCns.Location = new System.Drawing.Point(143, 162);
            this.txtCns.MaximumSize = new System.Drawing.Size(131, 23);
            this.txtCns.Multiline = true;
            this.txtCns.Name = "txtCns";
            this.txtCns.ReadOnly = true;
            this.txtCns.Size = new System.Drawing.Size(131, 23);
            this.txtCns.TabIndex = 5;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(25, 131);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(87, 13);
            this.label10.TabIndex = 81;
            this.label10.Text = "Data de entrada:";
            // 
            // dtpEntrada
            // 
            this.dtpEntrada.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpEntrada.Location = new System.Drawing.Point(143, 131);
            this.dtpEntrada.MaximumSize = new System.Drawing.Size(89, 20);
            this.dtpEntrada.Name = "dtpEntrada";
            this.dtpEntrada.Size = new System.Drawing.Size(89, 20);
            this.dtpEntrada.TabIndex = 4;
            // 
            // txtCodCentroCusto
            // 
            this.txtCodCentroCusto.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCodCentroCusto.Location = new System.Drawing.Point(551, 99);
            this.txtCodCentroCusto.MaximumSize = new System.Drawing.Size(30, 21);
            this.txtCodCentroCusto.Multiline = true;
            this.txtCodCentroCusto.Name = "txtCodCentroCusto";
            this.txtCodCentroCusto.ReadOnly = true;
            this.txtCodCentroCusto.Size = new System.Drawing.Size(30, 21);
            this.txtCodCentroCusto.TabIndex = 11;
            this.txtCodCentroCusto.TextChanged += new System.EventHandler(this.txtCodCentroCusto_TextChanged);
            // 
            // txtNomePaciente
            // 
            this.txtNomePaciente.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNomePaciente.Location = new System.Drawing.Point(143, 65);
            this.txtNomePaciente.MaximumSize = new System.Drawing.Size(131, 23);
            this.txtNomePaciente.Multiline = true;
            this.txtNomePaciente.Name = "txtNomePaciente";
            this.txtNomePaciente.ReadOnly = true;
            this.txtNomePaciente.Size = new System.Drawing.Size(131, 23);
            this.txtNomePaciente.TabIndex = 2;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(409, 131);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(130, 13);
            this.label16.TabIndex = 85;
            this.label16.Text = "Nome do centro de custo:";
            // 
            // txtNomeCentroCusto
            // 
            this.txtNomeCentroCusto.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNomeCentroCusto.Location = new System.Drawing.Point(551, 131);
            this.txtNomeCentroCusto.MaximumSize = new System.Drawing.Size(131, 23);
            this.txtNomeCentroCusto.Multiline = true;
            this.txtNomeCentroCusto.Name = "txtNomeCentroCusto";
            this.txtNomeCentroCusto.ReadOnly = true;
            this.txtNomeCentroCusto.Size = new System.Drawing.Size(131, 23);
            this.txtNomeCentroCusto.TabIndex = 12;
            // 
            // LupaCentroCusto
            // 
            this.LupaCentroCusto.FlatAppearance.BorderSize = 0;
            this.LupaCentroCusto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LupaCentroCusto.Image = global::Pacientes.Properties.Resources.lupa;
            this.LupaCentroCusto.Location = new System.Drawing.Point(587, 97);
            this.LupaCentroCusto.Name = "LupaCentroCusto";
            this.LupaCentroCusto.Size = new System.Drawing.Size(62, 23);
            this.LupaCentroCusto.TabIndex = 88;
            this.LupaCentroCusto.UseVisualStyleBackColor = true;
            this.LupaCentroCusto.Click += new System.EventHandler(this.LupaCentroCusto_Click);
            // 
            // LupaPaciente
            // 
            this.LupaPaciente.FlatAppearance.BorderSize = 0;
            this.LupaPaciente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LupaPaciente.Image = global::Pacientes.Properties.Resources.lupa;
            this.LupaPaciente.Location = new System.Drawing.Point(179, 30);
            this.LupaPaciente.Name = "LupaPaciente";
            this.LupaPaciente.Size = new System.Drawing.Size(62, 23);
            this.LupaPaciente.TabIndex = 87;
            this.LupaPaciente.UseVisualStyleBackColor = true;
            this.LupaPaciente.Click += new System.EventHandler(this.LupaPaciente_Click);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(25, 296);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(52, 13);
            this.label17.TabIndex = 89;
            this.label17.Text = "Situação:";
            // 
            // comboSituacao
            // 
            this.comboSituacao.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboSituacao.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboSituacao.FormattingEnabled = true;
            this.comboSituacao.Items.AddRange(new object[] {
            "",
            "Internado",
            "Óbito",
            "Alta"});
            this.comboSituacao.Location = new System.Drawing.Point(143, 296);
            this.comboSituacao.MaximumSize = new System.Drawing.Size(135, 0);
            this.comboSituacao.Name = "comboSituacao";
            this.comboSituacao.Size = new System.Drawing.Size(135, 21);
            this.comboSituacao.TabIndex = 90;
            // 
            // FormMovimentacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(881, 621);
            this.Controls.Add(this.comboSituacao);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.LupaCentroCusto);
            this.Controls.Add(this.LupaPaciente);
            this.Controls.Add(this.txtNomeCentroCusto);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.txtNomePaciente);
            this.Controls.Add(this.txtCodCentroCusto);
            this.Controls.Add(this.dtpEntrada);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtCns);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpNascimento);
            this.Controls.Add(this.txtCod);
            this.Controls.Add(this.Limpar);
            this.Controls.Add(this.Excluir);
            this.Controls.Add(this.Salvar);
            this.Controls.Add(this.dgvMovimentacao);
            this.Controls.Add(this.txtCrm);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.txtMedico);
            this.Controls.Add(this.txtSequencia);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.txtClinica);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtLeito);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtLocal);
            this.Controls.Add(this.comboMotivo);
            this.Controls.Add(this.dtpHora);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.dtpData);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtProntuario);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCodPaciente);
            this.Name = "FormMovimentacao";
            this.Text = "Formulário de controle de movimentação";
            this.Load += new System.EventHandler(this.FormMovimentacao_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMovimentacao)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txtCodPaciente;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.TextBox txtProntuario;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dtpData;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker dtpHora;
        private System.Windows.Forms.ComboBox comboMotivo;
        public System.Windows.Forms.TextBox txtLocal;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtLeito;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtClinica;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtSequencia;
        private System.Windows.Forms.TextBox txtMedico;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtCrm;
        private System.Windows.Forms.DataGridView dgvMovimentacao;
        private System.Windows.Forms.Button Salvar;
        public System.Windows.Forms.Button Excluir;
        public System.Windows.Forms.Button Limpar;
        public System.Windows.Forms.TextBox txtCod;
        private System.Windows.Forms.DateTimePicker dtpNascimento;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.TextBox txtCns;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker dtpEntrada;
        public System.Windows.Forms.TextBox txtCodCentroCusto;
        public System.Windows.Forms.TextBox txtNomePaciente;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtNomeCentroCusto;
        private System.Windows.Forms.Button LupaPaciente;
        private System.Windows.Forms.Button LupaCentroCusto;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.ComboBox comboSituacao;
    }
}