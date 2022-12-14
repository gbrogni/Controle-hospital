
namespace Pacientes
{
    partial class FormCadCentroCusto
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
            this.txtCod = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.Salvar = new System.Windows.Forms.Button();
            this.Excluir = new System.Windows.Forms.Button();
            this.Limpar = new System.Windows.Forms.Button();
            this.dgvCentroCusto = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCentroCusto)).BeginInit();
            this.SuspendLayout();
            // 
            // txtCodPaciente
            // 
            this.txtCodPaciente.AutoSize = true;
            this.txtCodPaciente.Location = new System.Drawing.Point(34, 39);
            this.txtCodPaciente.Name = "txtCodPaciente";
            this.txtCodPaciente.Size = new System.Drawing.Size(135, 13);
            this.txtCodPaciente.TabIndex = 22;
            this.txtCodPaciente.Text = "Código do centro de custo:";
            // 
            // txtCod
            // 
            this.txtCod.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCod.Location = new System.Drawing.Point(183, 39);
            this.txtCod.MaximumSize = new System.Drawing.Size(29, 23);
            this.txtCod.Multiline = true;
            this.txtCod.Name = "txtCod";
            this.txtCod.ReadOnly = true;
            this.txtCod.Size = new System.Drawing.Size(29, 23);
            this.txtCod.TabIndex = 23;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 13);
            this.label1.TabIndex = 24;
            this.label1.Text = "Nome do centro de custo:";
            // 
            // txtNome
            // 
            this.txtNome.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNome.Location = new System.Drawing.Point(183, 88);
            this.txtNome.MaximumSize = new System.Drawing.Size(184, 23);
            this.txtNome.Multiline = true;
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(184, 23);
            this.txtNome.TabIndex = 25;
            // 
            // Salvar
            // 
            this.Salvar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Salvar.Location = new System.Drawing.Point(554, 39);
            this.Salvar.Name = "Salvar";
            this.Salvar.Size = new System.Drawing.Size(176, 23);
            this.Salvar.TabIndex = 26;
            this.Salvar.Text = "Salvar";
            this.Salvar.UseVisualStyleBackColor = true;
            this.Salvar.Click += new System.EventHandler(this.Salvar_Click);
            // 
            // Excluir
            // 
            this.Excluir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Excluir.Location = new System.Drawing.Point(554, 88);
            this.Excluir.Name = "Excluir";
            this.Excluir.Size = new System.Drawing.Size(176, 23);
            this.Excluir.TabIndex = 27;
            this.Excluir.Text = "Excluir";
            this.Excluir.UseVisualStyleBackColor = true;
            this.Excluir.Click += new System.EventHandler(this.Excluir_Click_1);
            // 
            // Limpar
            // 
            this.Limpar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Limpar.Location = new System.Drawing.Point(554, 135);
            this.Limpar.Name = "Limpar";
            this.Limpar.Size = new System.Drawing.Size(176, 23);
            this.Limpar.TabIndex = 29;
            this.Limpar.Text = "Limpar campos";
            this.Limpar.UseVisualStyleBackColor = true;
            this.Limpar.Click += new System.EventHandler(this.Limpar_Click);
            // 
            // dgvCentroCusto
            // 
            this.dgvCentroCusto.AllowUserToAddRows = false;
            this.dgvCentroCusto.AllowUserToDeleteRows = false;
            this.dgvCentroCusto.AllowUserToResizeColumns = false;
            this.dgvCentroCusto.AllowUserToResizeRows = false;
            this.dgvCentroCusto.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvCentroCusto.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvCentroCusto.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvCentroCusto.BackgroundColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCentroCusto.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvCentroCusto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCentroCusto.EnableHeadersVisualStyles = false;
            this.dgvCentroCusto.Location = new System.Drawing.Point(12, 196);
            this.dgvCentroCusto.MultiSelect = false;
            this.dgvCentroCusto.Name = "dgvCentroCusto";
            this.dgvCentroCusto.ReadOnly = true;
            this.dgvCentroCusto.RowHeadersVisible = false;
            this.dgvCentroCusto.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCentroCusto.Size = new System.Drawing.Size(776, 242);
            this.dgvCentroCusto.TabIndex = 30;
            this.dgvCentroCusto.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvCentroCusto_CellMouseDoubleClick);
            this.dgvCentroCusto.SelectionChanged += new System.EventHandler(this.dgvCentroCusto_SelectionChanged);
            // 
            // FormCadCentroCusto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvCentroCusto);
            this.Controls.Add(this.Limpar);
            this.Controls.Add(this.Excluir);
            this.Controls.Add(this.Salvar);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCod);
            this.Controls.Add(this.txtCodPaciente);
            this.Name = "FormCadCentroCusto";
            this.Text = "Formulário de cadastro de centro de custo";
            this.Load += new System.EventHandler(this.FormCadCentroCusto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCentroCusto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txtCodPaciente;
        public System.Windows.Forms.TextBox txtCod;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Button Salvar;
        public System.Windows.Forms.Button Excluir;
        public System.Windows.Forms.Button Limpar;
        private System.Windows.Forms.DataGridView dgvCentroCusto;
    }
}