
namespace Pacientes
{
    partial class FormCadInternacao
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCadInternacao));
            this.txtCodPaciente = new System.Windows.Forms.Label();
            this.txtCodProntuario = new System.Windows.Forms.Label();
            this.txtProntuario = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.dtpDataEntrada = new System.Windows.Forms.DateTimePicker();
            this.dtpHoraEntrada = new System.Windows.Forms.DateTimePicker();
            this.dtpDataSaida = new System.Windows.Forms.DateTimePicker();
            this.label11 = new System.Windows.Forms.Label();
            this.dtpHoraSaida = new System.Windows.Forms.DateTimePicker();
            this.txtCns = new System.Windows.Forms.TextBox();
            this.txtLocal = new System.Windows.Forms.TextBox();
            this.txtClinica = new System.Windows.Forms.TextBox();
            this.txtHipotese = new System.Windows.Forms.TextBox();
            this.txtCrm = new System.Windows.Forms.TextBox();
            this.txtDiagnostico = new System.Windows.Forms.TextBox();
            this.txtLeito = new System.Windows.Forms.TextBox();
            this.txtMedico = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.comboSituacao = new System.Windows.Forms.ComboBox();
            this.dgvInternacao = new System.Windows.Forms.DataGridView();
            this.Salvar = new System.Windows.Forms.Button();
            this.Excluir = new System.Windows.Forms.Button();
            this.Limpar = new System.Windows.Forms.Button();
            this.txtCod = new System.Windows.Forms.TextBox();
            this.dtpNascimento = new System.Windows.Forms.DateTimePicker();
            this.txtCodCentroCusto = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.txtNomeMae = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.txtNomeCentroCusto = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.txtNomePaciente = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.LupaCentroCusto = new System.Windows.Forms.Button();
            this.btnOpenPacientece = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInternacao)).BeginInit();
            this.SuspendLayout();
            // 
            // txtCodPaciente
            // 
            this.txtCodPaciente.AutoSize = true;
            this.txtCodPaciente.Location = new System.Drawing.Point(21, 64);
            this.txtCodPaciente.Name = "txtCodPaciente";
            this.txtCodPaciente.Size = new System.Drawing.Size(102, 13);
            this.txtCodPaciente.TabIndex = 22;
            this.txtCodPaciente.Text = "Código do paciente:";
            // 
            // txtCodProntuario
            // 
            this.txtCodProntuario.AutoSize = true;
            this.txtCodProntuario.Location = new System.Drawing.Point(21, 28);
            this.txtCodProntuario.Name = "txtCodProntuario";
            this.txtCodProntuario.Size = new System.Drawing.Size(58, 13);
            this.txtCodProntuario.TabIndex = 26;
            this.txtCodProntuario.Text = "Prontuário:";
            // 
            // txtProntuario
            // 
            this.txtProntuario.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtProntuario.Location = new System.Drawing.Point(131, 28);
            this.txtProntuario.MaximumSize = new System.Drawing.Size(135, 23);
            this.txtProntuario.Multiline = true;
            this.txtProntuario.Name = "txtProntuario";
            this.txtProntuario.ReadOnly = true;
            this.txtProntuario.Size = new System.Drawing.Size(135, 23);
            this.txtProntuario.TabIndex = 1;
            this.txtProntuario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtProntuario_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 212);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 28;
            this.label2.Text = "CNS:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 248);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 13);
            this.label3.TabIndex = 29;
            this.label3.Text = "Data de entrada:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(316, 172);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 30;
            this.label4.Text = "Localização:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(316, 64);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 13);
            this.label5.TabIndex = 31;
            this.label5.Text = "Data de saída:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(316, 139);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 13);
            this.label6.TabIndex = 32;
            this.label6.Text = "Clínica médica:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(316, 28);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 13);
            this.label7.TabIndex = 33;
            this.label7.Text = "Hora de entrada:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(316, 212);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(33, 13);
            this.label8.TabIndex = 34;
            this.label8.Text = "Leito:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(633, 139);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(135, 13);
            this.label9.TabIndex = 35;
            this.label9.Text = "Código do centro de custo:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(633, 64);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(109, 13);
            this.label10.TabIndex = 36;
            this.label10.Text = "Hipótese diagnóstica:";
            // 
            // dtpDataEntrada
            // 
            this.dtpDataEntrada.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataEntrada.Location = new System.Drawing.Point(131, 245);
            this.dtpDataEntrada.MaximumSize = new System.Drawing.Size(135, 20);
            this.dtpDataEntrada.Name = "dtpDataEntrada";
            this.dtpDataEntrada.Size = new System.Drawing.Size(135, 20);
            this.dtpDataEntrada.TabIndex = 7;
            this.dtpDataEntrada.Value = new System.DateTime(2022, 10, 31, 0, 0, 0, 0);
            // 
            // dtpHoraEntrada
            // 
            this.dtpHoraEntrada.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpHoraEntrada.Location = new System.Drawing.Point(426, 25);
            this.dtpHoraEntrada.MaximumSize = new System.Drawing.Size(135, 20);
            this.dtpHoraEntrada.Name = "dtpHoraEntrada";
            this.dtpHoraEntrada.Size = new System.Drawing.Size(135, 20);
            this.dtpHoraEntrada.TabIndex = 8;
            this.dtpHoraEntrada.Value = new System.DateTime(2022, 11, 7, 10, 27, 7, 0);
            // 
            // dtpDataSaida
            // 
            this.dtpDataSaida.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataSaida.Location = new System.Drawing.Point(426, 63);
            this.dtpDataSaida.MaximumSize = new System.Drawing.Size(135, 20);
            this.dtpDataSaida.Name = "dtpDataSaida";
            this.dtpDataSaida.Size = new System.Drawing.Size(135, 20);
            this.dtpDataSaida.TabIndex = 9;
            this.dtpDataSaida.Value = new System.DateTime(2022, 11, 8, 0, 0, 0, 0);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(316, 101);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(78, 13);
            this.label11.TabIndex = 40;
            this.label11.Text = "Hora de saída:";
            // 
            // dtpHoraSaida
            // 
            this.dtpHoraSaida.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpHoraSaida.Location = new System.Drawing.Point(426, 99);
            this.dtpHoraSaida.MaximumSize = new System.Drawing.Size(135, 20);
            this.dtpHoraSaida.Name = "dtpHoraSaida";
            this.dtpHoraSaida.Size = new System.Drawing.Size(135, 20);
            this.dtpHoraSaida.TabIndex = 10;
            this.dtpHoraSaida.Value = new System.DateTime(2022, 11, 8, 9, 37, 46, 0);
            // 
            // txtCns
            // 
            this.txtCns.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCns.Location = new System.Drawing.Point(131, 209);
            this.txtCns.MaximumSize = new System.Drawing.Size(135, 23);
            this.txtCns.Multiline = true;
            this.txtCns.Name = "txtCns";
            this.txtCns.ReadOnly = true;
            this.txtCns.Size = new System.Drawing.Size(135, 23);
            this.txtCns.TabIndex = 6;
            this.txtCns.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCns_KeyPress);
            // 
            // txtLocal
            // 
            this.txtLocal.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtLocal.Location = new System.Drawing.Point(426, 169);
            this.txtLocal.MaximumSize = new System.Drawing.Size(135, 23);
            this.txtLocal.Multiline = true;
            this.txtLocal.Name = "txtLocal";
            this.txtLocal.Size = new System.Drawing.Size(135, 23);
            this.txtLocal.TabIndex = 12;
            // 
            // txtClinica
            // 
            this.txtClinica.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtClinica.Location = new System.Drawing.Point(426, 133);
            this.txtClinica.MaximumSize = new System.Drawing.Size(135, 23);
            this.txtClinica.Multiline = true;
            this.txtClinica.Name = "txtClinica";
            this.txtClinica.Size = new System.Drawing.Size(135, 23);
            this.txtClinica.TabIndex = 11;
            // 
            // txtHipotese
            // 
            this.txtHipotese.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtHipotese.Location = new System.Drawing.Point(775, 61);
            this.txtHipotese.MaximumSize = new System.Drawing.Size(135, 23);
            this.txtHipotese.Multiline = true;
            this.txtHipotese.Name = "txtHipotese";
            this.txtHipotese.Size = new System.Drawing.Size(135, 23);
            this.txtHipotese.TabIndex = 16;
            // 
            // txtCrm
            // 
            this.txtCrm.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCrm.Location = new System.Drawing.Point(775, 28);
            this.txtCrm.MaximumSize = new System.Drawing.Size(135, 23);
            this.txtCrm.Multiline = true;
            this.txtCrm.Name = "txtCrm";
            this.txtCrm.Size = new System.Drawing.Size(135, 23);
            this.txtCrm.TabIndex = 15;
            // 
            // txtDiagnostico
            // 
            this.txtDiagnostico.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDiagnostico.Location = new System.Drawing.Point(775, 98);
            this.txtDiagnostico.MaximumSize = new System.Drawing.Size(135, 23);
            this.txtDiagnostico.Multiline = true;
            this.txtDiagnostico.Name = "txtDiagnostico";
            this.txtDiagnostico.Size = new System.Drawing.Size(135, 23);
            this.txtDiagnostico.TabIndex = 17;
            // 
            // txtLeito
            // 
            this.txtLeito.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtLeito.Location = new System.Drawing.Point(426, 209);
            this.txtLeito.MaximumSize = new System.Drawing.Size(135, 23);
            this.txtLeito.Multiline = true;
            this.txtLeito.Name = "txtLeito";
            this.txtLeito.Size = new System.Drawing.Size(135, 23);
            this.txtLeito.TabIndex = 13;
            // 
            // txtMedico
            // 
            this.txtMedico.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMedico.Location = new System.Drawing.Point(426, 245);
            this.txtMedico.MaximumSize = new System.Drawing.Size(135, 23);
            this.txtMedico.Multiline = true;
            this.txtMedico.Name = "txtMedico";
            this.txtMedico.Size = new System.Drawing.Size(135, 23);
            this.txtMedico.TabIndex = 14;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(316, 248);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(45, 13);
            this.label12.TabIndex = 57;
            this.label12.Text = "Médico:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(633, 212);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(52, 13);
            this.label13.TabIndex = 58;
            this.label13.Text = "Situação:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(633, 28);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(34, 13);
            this.label14.TabIndex = 59;
            this.label14.Text = "CRM:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(633, 102);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(66, 13);
            this.label15.TabIndex = 60;
            this.label15.Text = "Diagnóstico:";
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
            this.comboSituacao.Location = new System.Drawing.Point(775, 212);
            this.comboSituacao.MaximumSize = new System.Drawing.Size(135, 0);
            this.comboSituacao.Name = "comboSituacao";
            this.comboSituacao.Size = new System.Drawing.Size(135, 21);
            this.comboSituacao.TabIndex = 20;
            // 
            // dgvInternacao
            // 
            this.dgvInternacao.AllowUserToAddRows = false;
            this.dgvInternacao.AllowUserToDeleteRows = false;
            this.dgvInternacao.AllowUserToResizeColumns = false;
            this.dgvInternacao.AllowUserToResizeRows = false;
            this.dgvInternacao.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvInternacao.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvInternacao.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvInternacao.BackgroundColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvInternacao.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvInternacao.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInternacao.EnableHeadersVisualStyles = false;
            this.dgvInternacao.Location = new System.Drawing.Point(12, 326);
            this.dgvInternacao.MultiSelect = false;
            this.dgvInternacao.Name = "dgvInternacao";
            this.dgvInternacao.ReadOnly = true;
            this.dgvInternacao.RowHeadersVisible = false;
            this.dgvInternacao.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvInternacao.Size = new System.Drawing.Size(1125, 294);
            this.dgvInternacao.TabIndex = 62;
            this.dgvInternacao.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvInternacao_CellMouseDoubleClick);
            this.dgvInternacao.SelectionChanged += new System.EventHandler(this.dgvInternacao_SelectionChanged);
            // 
            // Salvar
            // 
            this.Salvar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Salvar.Location = new System.Drawing.Point(1009, 28);
            this.Salvar.Name = "Salvar";
            this.Salvar.Size = new System.Drawing.Size(128, 23);
            this.Salvar.TabIndex = 21;
            this.Salvar.Text = "Salvar";
            this.Salvar.UseVisualStyleBackColor = true;
            this.Salvar.Click += new System.EventHandler(this.Salvar_Click);
            // 
            // Excluir
            // 
            this.Excluir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Excluir.Location = new System.Drawing.Point(1009, 64);
            this.Excluir.Name = "Excluir";
            this.Excluir.Size = new System.Drawing.Size(128, 23);
            this.Excluir.TabIndex = 22;
            this.Excluir.Text = "Excluir";
            this.Excluir.UseVisualStyleBackColor = true;
            this.Excluir.Click += new System.EventHandler(this.Excluir_Click);
            // 
            // Limpar
            // 
            this.Limpar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Limpar.Location = new System.Drawing.Point(1009, 98);
            this.Limpar.Name = "Limpar";
            this.Limpar.Size = new System.Drawing.Size(128, 23);
            this.Limpar.TabIndex = 23;
            this.Limpar.Text = "Limpar campos";
            this.Limpar.UseVisualStyleBackColor = true;
            this.Limpar.Click += new System.EventHandler(this.Limpar_Click);
            // 
            // txtCod
            // 
            this.txtCod.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCod.Location = new System.Drawing.Point(131, 66);
            this.txtCod.MaximumSize = new System.Drawing.Size(37, 21);
            this.txtCod.Multiline = true;
            this.txtCod.Name = "txtCod";
            this.txtCod.ReadOnly = true;
            this.txtCod.Size = new System.Drawing.Size(37, 21);
            this.txtCod.TabIndex = 2;
            this.txtCod.TextChanged += new System.EventHandler(this.txtCod_TextChanged);
            // 
            // dtpNascimento
            // 
            this.dtpNascimento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNascimento.Location = new System.Drawing.Point(131, 136);
            this.dtpNascimento.MaximumSize = new System.Drawing.Size(135, 20);
            this.dtpNascimento.Name = "dtpNascimento";
            this.dtpNascimento.Size = new System.Drawing.Size(135, 20);
            this.dtpNascimento.TabIndex = 4;
            // 
            // txtCodCentroCusto
            // 
            this.txtCodCentroCusto.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCodCentroCusto.Location = new System.Drawing.Point(775, 136);
            this.txtCodCentroCusto.MaximumSize = new System.Drawing.Size(37, 21);
            this.txtCodCentroCusto.Multiline = true;
            this.txtCodCentroCusto.Name = "txtCodCentroCusto";
            this.txtCodCentroCusto.ReadOnly = true;
            this.txtCodCentroCusto.Size = new System.Drawing.Size(37, 21);
            this.txtCodCentroCusto.TabIndex = 18;
            this.txtCodCentroCusto.TextChanged += new System.EventHandler(this.txtCodCentroCusto_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 139);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 73;
            this.label1.Text = "Nascimento:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(21, 172);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(76, 13);
            this.label16.TabIndex = 74;
            this.label16.Text = "Nome da mãe:";
            // 
            // txtNomeMae
            // 
            this.txtNomeMae.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNomeMae.Location = new System.Drawing.Point(131, 171);
            this.txtNomeMae.MaximumSize = new System.Drawing.Size(135, 23);
            this.txtNomeMae.Multiline = true;
            this.txtNomeMae.Name = "txtNomeMae";
            this.txtNomeMae.ReadOnly = true;
            this.txtNomeMae.Size = new System.Drawing.Size(135, 23);
            this.txtNomeMae.TabIndex = 5;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(633, 172);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(130, 13);
            this.label17.TabIndex = 76;
            this.label17.Text = "Nome do centro de custo:";
            // 
            // txtNomeCentroCusto
            // 
            this.txtNomeCentroCusto.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNomeCentroCusto.Location = new System.Drawing.Point(775, 169);
            this.txtNomeCentroCusto.MaximumSize = new System.Drawing.Size(135, 23);
            this.txtNomeCentroCusto.Multiline = true;
            this.txtNomeCentroCusto.Name = "txtNomeCentroCusto";
            this.txtNomeCentroCusto.ReadOnly = true;
            this.txtNomeCentroCusto.Size = new System.Drawing.Size(135, 23);
            this.txtNomeCentroCusto.TabIndex = 19;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(21, 101);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(97, 13);
            this.label18.TabIndex = 78;
            this.label18.Text = "Nome do paciente:";
            // 
            // txtNomePaciente
            // 
            this.txtNomePaciente.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNomePaciente.Location = new System.Drawing.Point(131, 99);
            this.txtNomePaciente.MaximumSize = new System.Drawing.Size(135, 23);
            this.txtNomePaciente.Multiline = true;
            this.txtNomePaciente.Name = "txtNomePaciente";
            this.txtNomePaciente.ReadOnly = true;
            this.txtNomePaciente.Size = new System.Drawing.Size(135, 23);
            this.txtNomePaciente.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(818, 134);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(59, 23);
            this.button1.TabIndex = 72;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // LupaCentroCusto
            // 
            this.LupaCentroCusto.FlatAppearance.BorderSize = 0;
            this.LupaCentroCusto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LupaCentroCusto.Image = ((System.Drawing.Image)(resources.GetObject("LupaCentroCusto.Image")));
            this.LupaCentroCusto.Location = new System.Drawing.Point(818, 134);
            this.LupaCentroCusto.Name = "LupaCentroCusto";
            this.LupaCentroCusto.Size = new System.Drawing.Size(62, 23);
            this.LupaCentroCusto.TabIndex = 80;
            this.LupaCentroCusto.UseVisualStyleBackColor = true;
            this.LupaCentroCusto.Click += new System.EventHandler(this.LupaCentroCusto_Click);
            // 
            // btnOpenPacientece
            // 
            this.btnOpenPacientece.FlatAppearance.BorderSize = 0;
            this.btnOpenPacientece.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOpenPacientece.Image = global::Pacientes.Properties.Resources.lupa;
            this.btnOpenPacientece.Location = new System.Drawing.Point(176, 64);
            this.btnOpenPacientece.Name = "btnOpenPacientece";
            this.btnOpenPacientece.Size = new System.Drawing.Size(62, 23);
            this.btnOpenPacientece.TabIndex = 71;
            this.btnOpenPacientece.UseVisualStyleBackColor = true;
            this.btnOpenPacientece.Click += new System.EventHandler(this.btnOpenPacientece_Click);
            // 
            // FormCadInternacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1149, 632);
            this.Controls.Add(this.LupaCentroCusto);
            this.Controls.Add(this.txtNomePaciente);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.txtNomeCentroCusto);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.txtNomeMae);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnOpenPacientece);
            this.Controls.Add(this.txtCodCentroCusto);
            this.Controls.Add(this.dtpNascimento);
            this.Controls.Add(this.txtCod);
            this.Controls.Add(this.Limpar);
            this.Controls.Add(this.Excluir);
            this.Controls.Add(this.Salvar);
            this.Controls.Add(this.dgvInternacao);
            this.Controls.Add(this.comboSituacao);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtMedico);
            this.Controls.Add(this.txtLeito);
            this.Controls.Add(this.txtDiagnostico);
            this.Controls.Add(this.txtCrm);
            this.Controls.Add(this.txtHipotese);
            this.Controls.Add(this.txtLocal);
            this.Controls.Add(this.txtCns);
            this.Controls.Add(this.txtClinica);
            this.Controls.Add(this.dtpHoraSaida);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.dtpDataSaida);
            this.Controls.Add(this.dtpHoraEntrada);
            this.Controls.Add(this.dtpDataEntrada);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtProntuario);
            this.Controls.Add(this.txtCodProntuario);
            this.Controls.Add(this.txtCodPaciente);
            this.Name = "FormCadInternacao";
            this.Text = "Formulário de cadastro de internação";
            this.Load += new System.EventHandler(this.FormCadInternacao_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvInternacao)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txtCodPaciente;
        private System.Windows.Forms.Label txtCodProntuario;
        public System.Windows.Forms.TextBox txtProntuario;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker dtpDataEntrada;
        private System.Windows.Forms.DateTimePicker dtpHoraEntrada;
        private System.Windows.Forms.DateTimePicker dtpDataSaida;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DateTimePicker dtpHoraSaida;
        private System.Windows.Forms.TextBox txtCns;
        private System.Windows.Forms.TextBox txtLocal;
        private System.Windows.Forms.TextBox txtClinica;
        private System.Windows.Forms.TextBox txtHipotese;
        private System.Windows.Forms.TextBox txtCrm;
        private System.Windows.Forms.TextBox txtDiagnostico;
        private System.Windows.Forms.TextBox txtLeito;
        private System.Windows.Forms.TextBox txtMedico;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox comboSituacao;
        private System.Windows.Forms.DataGridView dgvInternacao;
        private System.Windows.Forms.Button Salvar;
        public System.Windows.Forms.Button Excluir;
        public System.Windows.Forms.Button Limpar;
        public System.Windows.Forms.TextBox txtCod;
        private System.Windows.Forms.DateTimePicker dtpNascimento;
        public System.Windows.Forms.TextBox txtCodCentroCusto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label16;
        public System.Windows.Forms.TextBox txtNomeMae;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtNomeCentroCusto;
        private System.Windows.Forms.Label label18;
        public System.Windows.Forms.TextBox txtNomePaciente;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnOpenPacientece;
        private System.Windows.Forms.Button LupaCentroCusto;
    }
}