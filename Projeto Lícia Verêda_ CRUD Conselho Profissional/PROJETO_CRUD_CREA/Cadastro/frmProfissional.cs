using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cadastro
{
    public partial class frmProfissional : Form
    {
        public ArrayList idCarreira = new ArrayList();
        public ArrayList nomeCarreira = new ArrayList();
        public ArrayList idProfissional = new ArrayList();
        public ArrayList nomeProfissional = new ArrayList();
        public ArrayList telefoneProfissional = new ArrayList();
        public ArrayList carreiraProfissional = new ArrayList();
        public ArrayList nomeCarreiraProfissional = new ArrayList();
        public bool novo;
        public int linhaSelecionada = 0;

        private void frmProfissional_Load(object sender, EventArgs e)
        {

              
            
        }
        public frmProfissional()
        {
            InitializeComponent();
            txtNome.Enabled = false;
            txtTelefone.Enabled = false;
            cbCarreira.Enabled = false;
            
            Biblioteca.LerProfissional(idProfissional, nomeProfissional, telefoneProfissional, carreiraProfissional);
            Biblioteca.LerCarreira(idCarreira, nomeCarreira);

            
            
            
            if (idCarreira.Count > 0)
            {
                for (int i = 0; i < idCarreira.Count; i++)
                {
                    cbCarreira.Items.Add(Convert.ToString(idCarreira[i]) + " - " + Convert.ToString(nomeCarreira[i]));
                }

                cbCarreira.Enabled = true;
            }
            else
            {
                MessageBox.Show("Não existem carreiras cadastradas.");
            }

        }

        private void btnbListarProfissional_Click(object sender, EventArgs e)
        {
           
            Biblioteca.LerProfissional(idProfissional, nomeProfissional, telefoneProfissional, carreiraProfissional);
            Biblioteca.LerCarreira(idCarreira, nomeCarreira);
            Biblioteca.PopularNomeCarreira(idCarreira, nomeCarreira, carreiraProfissional, nomeCarreiraProfissional);

            dgvProfissional.Rows.Clear();

            btnbNovo.Enabled = true;
            btnCancelar.Enabled = false;
            btnExcluir.Enabled = false;
            btnbEditar.Enabled = false;
            btnSalvar.Enabled = false;
            btnSair.Enabled = true;
            dgvProfissional.Enabled = true;
            txtProfissional.Enabled = true;


            if (txtProfissional.Text != "")
            {
                for (int i = 0; i < idProfissional.Count; i++)
                {
                    if (Convert.ToString(nomeProfissional[i]).Contains(txtProfissional.Text))
                    {

                        dgvProfissional.Rows.Add(Convert.ToString(idProfissional[i]), Convert.ToString(nomeProfissional[i]), Convert.ToString(telefoneProfissional[i]), Convert.ToString(carreiraProfissional[i]) + " - " + Convert.ToString(nomeCarreiraProfissional[i]));
                    }
                }
            }

            else
            {
                for (int i = 0; i < idProfissional.Count; i++)
                {
                    dgvProfissional.Rows.Add(Convert.ToString(idProfissional[i]), Convert.ToString(nomeProfissional[i]), Convert.ToString(telefoneProfissional[i]), Convert.ToString(carreiraProfissional[i]) + " - " + Convert.ToString(nomeCarreiraProfissional[i]));

                }
            }
        }


        private void btnbEditar_Click(object sender, EventArgs e)
        {
            Biblioteca.LerProfissional(idProfissional, nomeProfissional, telefoneProfissional, carreiraProfissional);

            btnbListarProfissional.Enabled = false;
            dgvProfissional.Enabled = false;
            btnbNovo.Enabled = false;
            btnbEditar.Enabled = false;
            btnExcluir.Enabled = false;
            
            txtProfissional.Enabled = true;

            btnSalvar.Enabled = true;
            btnCancelar.Enabled = true;
            txtNome.Enabled = true;
            txtTelefone.Enabled = true;

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            string nomeAlterado = txtNome.Text;
            string telefoneAlterado = txtTelefone.Text;
            string carreiraAlterada = cbCarreira.Text;
            long telefoneTratamento;

            //Tratando a exceção para o campo em branco

            if (nomeAlterado == "")
            {
                MessageBox.Show("O campo NOME é obrigatório para o cadastro.");
                txtNome.Focus(); 
                return;
            }

            if (telefoneAlterado == "")
            {
                MessageBox.Show("O campo TELEFONE é obrigatório para o cadastro. ");
                txtTelefone.Focus();
                return;
            }

            if (cbCarreira.SelectedIndex == -1)
            {
                MessageBox.Show("O campo CARREIRA é obrigatório para o cadastro. ");
                cbCarreira.Focus();
                return;

            }

            //Tratamento fora do formato

            if (nomeAlterado.Length < 10) 
            {
                MessageBox.Show("O campo NOME deve ter no mínimo 10 caracteres para o cadastro.");
                txtNome.Focus();
                return;

            }

            if (telefoneAlterado.Length < 11)
            {
                MessageBox.Show("Digite o campo TELEFONE no formato XX9999-9999 para o cadastro.");
                txtTelefone.Focus();
                return;
            }

            //Tratamentos com try e catch

            try
            {
                telefoneTratamento = Convert.ToInt64(txtTelefone.Text);

               

            }
            catch
            {
                MessageBox.Show("Digite um TELEFONE válido, apenas números. O formato de ser DDD9999-9999.");
                txtTelefone.Focus();
                return;
            }


            if (novo == false)
            {
                Biblioteca.SalvarProfissional(idProfissional, nomeProfissional, telefoneProfissional, carreiraProfissional, nomeAlterado,telefoneAlterado, carreiraAlterada, linhaSelecionada, novo);
            }
            else
            {
                Biblioteca.SalvarProfissional(idProfissional, nomeProfissional, telefoneProfissional, carreiraProfissional, nomeAlterado, telefoneAlterado, carreiraAlterada, linhaSelecionada, novo);             
            }

            txtNome.Text = "";
            txtTelefone.Text = "";
            cbCarreira.SelectedIndex = -1;

            btnbListarProfissional.Enabled = true;
            btnbListarProfissional.PerformClick();

            novo = false;

        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            Biblioteca.LerProfissional(idProfissional, nomeProfissional, telefoneProfissional, carreiraProfissional);

            string nomeAnterior = Convert.ToString(nomeProfissional[linhaSelecionada]);

            if (MessageBox.Show("Tem certeza que deseja excluir o profissional " + nomeAnterior + " ?", "CREA INFORMA", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                Biblioteca.ExcluirProfissional(idProfissional, nomeProfissional, telefoneProfissional, carreiraProfissional, linhaSelecionada);
                
                btnbListarProfissional.PerformClick();
            }

            txtNome.Text = "";
            txtTelefone.Text = "";
            cbCarreira.SelectedIndex = -1;

            btnbListarProfissional.Enabled = true;
            btnbListarProfissional.PerformClick();

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            
            txtNome.Text = "";
            txtTelefone.Text = "";
            cbCarreira.SelectedIndex = -1;
            btnbListarProfissional.Enabled = true;
            btnbListarProfissional.PerformClick();

            dgvProfissional.Rows.Clear();

        }

        private void btnbNovo_Click(object sender, EventArgs e)
        {
            novo = true;

            btnbListarProfissional.Enabled = false;
            btnSalvar.Enabled = true;
            txtNome.Enabled = true;
            txtTelefone.Enabled = true;
            txtProfissional.Enabled = false;
            cbCarreira.Enabled = true;
            btnbNovo.Enabled = false;
            btnCancelar.Enabled = true;
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvProfissional_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            txtNome.Text = "";
            txtTelefone.Text = "";
            cbCarreira.SelectedIndex = -1;

            string nomeSelecionado=(Convert.ToString(dgvProfissional.CurrentRow.Cells[1].Value));
            txtNome.Text = nomeSelecionado;

            string telefoneSelecionado = (Convert.ToString(dgvProfissional.CurrentRow.Cells[2].Value));
            txtTelefone.Text = telefoneSelecionado;

            //algoritmo para popular o combobox na seleção da linha
            int posicaoTraco = Convert.ToString(dgvProfissional.CurrentRow.Cells[3].Value).IndexOf("-");
            string idSelecionado = Convert.ToString(dgvProfissional.CurrentRow.Cells[3].Value).Substring(0, posicaoTraco).Trim();
            for (int i = 0; i < idCarreira.Count; i++)
            {
                if (Convert.ToString(idCarreira[i]) == idSelecionado)
                {
                    cbCarreira.SelectedIndex = i;
                    break;
                }
            }

            //algoritmo para popular a variável linhaSelecionada
            string idProfissionalSelecionado = Convert.ToString(dgvProfissional.CurrentRow.Cells[0].Value);
            for (int i = 0; i < idProfissional.Count; i++)
            {
                if (idProfissionalSelecionado == Convert.ToString(idProfissional[i]))
                {
                    linhaSelecionada = i;
                    break;
                }
            }


            btnbNovo.Enabled = false;
            btnbEditar.Enabled = true;
            btnExcluir.Enabled = true;
            btnbNovo.Enabled = false;
            btnSalvar.Enabled = true;
            btnCancelar.Enabled = true;
            //btnbListarProfissional.PerformClick();
            
        }

        
    }
}
