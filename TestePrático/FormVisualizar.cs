using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TestePrático;

namespace TestePrático
{
	public partial class FormVisualizar : Form
	{
		private int turmaId;

		public FormVisualizar(int turmaId)
		{
			InitializeComponent();
			this.turmaId = turmaId;
			this.turmaId = turmaId;

			PreencherDadosTurma();

			this.FormClosing += FormVisualizar_FormClosing;
			PreencherDadosTurma();
		}

		private void PreencherDadosTurma()
		{
			Login database = new Login();
			Turma turma = database.GetTurmaById(turmaId);

			if (turma != null)
			{
				lblTurma.Text = turma.Nome;
				lblProfessor.Text = turma.NomeProfessor; 
			}
			else
			{
				MessageBox.Show("Turma não encontrada.");
				this.Close();
			}
		}

		private void btnExcluir_Click(object sender, EventArgs e)
		{
			Login login = new Login();
			if (login.ExcluirTurma(turmaId))
			{
				MessageBox.Show("Turma excluída com sucesso!");
				this.Close();
			}
			else
			{
				MessageBox.Show("Erro ao excluir a turma.");
			}
		}

		private void btnSair_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void FormVisualizar_FormClosing(object sender, FormClosingEventArgs e)
		{
			FormMain formMain = Application.OpenForms.OfType<FormMain>().FirstOrDefault();
			if (formMain != null)
			{
				formMain.CarregarTurmas();
			}
		}

	}
}




