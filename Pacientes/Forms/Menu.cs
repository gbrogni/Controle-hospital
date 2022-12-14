using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pacientes
{
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
        }

        private void CaminhoCadPaciente_Click(object sender, EventArgs e)
        {
            FormCadPaciente formCadPaciente = new FormCadPaciente();
            formCadPaciente.ShowDialog();
        }

        private void CaminhoCadCentroCusto_Click(object sender, EventArgs e)
        {
            FormCadCentroCusto formCadCentroCusto = new FormCadCentroCusto();
            formCadCentroCusto.ShowDialog();
        }

        private void CaminhoCadInternacao_Click(object sender, EventArgs e)
        {
            FormCadInternacao formCadInternacao = new FormCadInternacao();
            formCadInternacao.ShowDialog();
        }

        private void CaminhoFormMovimentacao_Click(object sender, EventArgs e)
        {
            FormMovimentacao formMovimentacao = new FormMovimentacao();
            formMovimentacao.ShowDialog();
        }

        private void CaminhoConsultaPaciente_Click(object sender, EventArgs e)
        {
            FormConsulta formConsulta = new FormConsulta();
            formConsulta.ShowDialog();
        }
    }
}
