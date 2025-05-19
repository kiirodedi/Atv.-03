using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atv._03
{
    public partial class CadastroLivros : Form
    {

        private int proximoId = 1;
        public CadastroLivros()
        {
            InitializeComponent();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void calculadoraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("calc.exe");
        }

        private void blocoDeNotasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("notepad.exe");
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            tspData.Text = DateTime.Now.ToString("dd/MM/yyyy");
            tspHora.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void cadastroToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }

        private void tspHora_Click(object sender, EventArgs e)
        {

        }

        private void dtpDataNasc_ValueChanged(object sender, EventArgs e)
        {

        }

        private void lblDataNasc_Click(object sender, EventArgs e)
        {

        }

        private void tabPageCadastrar_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridViewLista.Rows.Add("1", "Nome");
            dataGridViewLista.Rows.Add("2", "CPF");
            dataGridViewLista.Rows.Add("3", "Data de Nascimento");
            dataGridViewLista.Rows.Add("4", "Sexo");
        }

        private void lblCPF_Click(object sender, EventArgs e)
        {

        }

        private void txtBoxCPF_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblDataNasc_Click_1(object sender, EventArgs e)
        {

        }

        private void sairToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnCarregarImagem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                pctBoxCapa.ImageLocation = openFileDialog1.FileName;
            }
        }

        private void btnLimparImagem_Click(object sender, EventArgs e)
        {
            pctBoxCapa.Image = null;
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtBoxNome.Text = "";
            txtBoxAutor.Text = "";
            dtpDataLanc.Text = "";
            radioFantasia.Checked = false;
            radioTerror.Checked = false;
            radioBiografia.Checked = false;
            radioRomance.Checked = false;
            radioPoesia.Checked = false;
            radioMedieval.Checked = false;
            radioButtonMaior18.Checked = false;
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {

            int id = proximoId;
            proximoId++;

            string nome = txtBoxNome.Text;
            string autor = txtBoxAutor.Text;
            string dataLanc = dtpDataLanc.Value.ToString("dd/MM/yyyy");

            string classificacao = "";
            foreach (Control control in groupBoxClassificacao.Controls)
            {
                if (control is RadioButton radioButton && radioButton.Checked)
                {
                    classificacao = radioButton.Text;
                    break;
                }
            }

            string genero = "";
            foreach (Control control in groupBoxGeneros.Controls)
            {
                if (control is RadioButton radioButton && radioButton.Checked)
                {
                    genero = radioButton.Text;
                    break;
                }
            }

            dataGridViewLista.Rows.Add(nome, autor, dataLanc, genero, classificacao);

            tabCrtlLista.SelectedTab = tabPageLista;

            LimparFormulario();
        }

        private void LimparFormulario()
        {
            txtBoxNome.Clear();
            txtBoxAutor.Clear();
            dtpDataLanc.Value = DateTime.Now;

            foreach (Control control in groupBoxGeneros.Controls)
            {
                if (control is RadioButton radioButton)
                {
                    radioButton.Checked = false;
                }
            }

            radioButtonMaior18.Checked = false;
            radioButtonLivre.Checked = false;
        }
    }
}
