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
    public partial class frmConsultarCarreira : Form
    {
        public ArrayList idCarreira = new ArrayList();
        public ArrayList nomeCarreira = new ArrayList();
        public ArrayList idProfissional = new ArrayList();
        public ArrayList nomeProfissional = new ArrayList();
        public ArrayList telefoneProfissional = new ArrayList();
        public ArrayList carreiraProfissional = new ArrayList();
        public int linhaSelecionada = 0;
        public bool novo ;


        public frmConsultarCarreira()
        {
            InitializeComponent();
            btnbNovo.Enabled = false;
            btnSair.Enabled = false;
        }

        private void btnbListarCarreira_Click(object sender, EventArgs e)
        {
            Biblioteca.LerCarreira(idCarreira, nomeCarreira);

            dataGridView1.Rows.Clear();
            btnbNovo.Enabled = true;
            btnCancelar.Enabled = false;
            btnExcluir.Enabled = false;
            btnbEditar.Enabled = false;
            btnSalvar.Enabled = false;
            btnSair.Enabled = true;
            txtCarreiraSelecionada.Enabled = false;
            txtCarreiraSelecionada.Text = "";
            dataGridView1.Enabled = true;

            if (idCarreira.Count > 0)
            {

                for (int i = 0; i < idCarreira.Count; i++)
                {
                    dataGridView1.Rows.Add(Convert.ToString(idCarreira[i]), Convert.ToString(nomeCarreira[i]));       

                }

            }

            else
            {
                MessageBox.Show("Não existem carreiras cadastradas.");
            }


        }

        private void btnbEditar_Click(object sender, EventArgs e)
        {
            Biblioteca.LerCarreira(idCarreira, nomeCarreira);

            btnbListarCarreira.Enabled = false;
            dataGridView1.Enabled = false;
            btnbNovo.Enabled = false;
            btnbEditar.Enabled = false;
            btnExcluir.Enabled = false;


            txtCarreiraSelecionada.Enabled = true;

            btnSalvar.Enabled = true;
            btnCancelar.Enabled = true;


        }
       
        private void btnCancelar_Click(object sender, EventArgs e)
        {

            btnbListarCarreira.PerformClick();
            txtCarreiraSelecionada.Text = "";

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            string nomeAlterado = txtCarreiraSelecionada.Text;
            //Tratando a exceção para o campo em branco

            if (nomeAlterado == "")
            {
                MessageBox.Show("O campo carreira é obrigatório. ");
                txtCarreiraSelecionada.Focus();
                return;
            }

            if (novo==false)
            {
                
                Biblioteca.SalvarCarreira(idCarreira,nomeCarreira, nomeAlterado, linhaSelecionada, novo);
                dataGridView1.Rows.Clear();
                //btnbListarCarreira.Enabled = true;
                //btnbListarCarreira.PerformClick();

               
                //dataGridView1.Enabled = false;
                //btnbEditar.Enabled = false;
                //btnExcluir.Enabled = false;
                //txtCarreiraSelecionada.Enabled = false;
                //txtCarreiraSelecionada.Text = "";
                //btnSalvar.Enabled = false;
                //btnCancelar.Enabled = false;
            }


            else 
            {

                Biblioteca.SalvarCarreira(idCarreira, nomeCarreira, nomeAlterado, linhaSelecionada, novo);
                //btnbNovo.Enabled = false;
                //btnSalvar.Enabled = false;
    
            }

            btnbListarCarreira.Enabled = true;
            btnbListarCarreira.PerformClick();
            novo = false;
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {

            Biblioteca.LerProfissional(idProfissional, nomeProfissional, telefoneProfissional, carreiraProfissional);

            string nomeAnterior = Convert.ToString(nomeCarreira[linhaSelecionada]);

            if (MessageBox.Show("Tem certeza que deseja excluir a carreira " + nomeAnterior + " ?", "CREA INFORMA", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Biblioteca.ExcluirCarreira(idCarreira,carreiraProfissional,nomeCarreira, linhaSelecionada);
                Biblioteca.EscreverCarreira(idCarreira, nomeCarreira);

                //btnbListarCarreira.PerformClick();
            }

            btnbListarCarreira.Enabled = true;
            btnbListarCarreira.PerformClick();
          

            //else
            //{
            //    btnbListarCarreira.Enabled = true;
            //    dataGridView1.Enabled = true;
            //    btnbEditar.Enabled = true;
            //    btnExcluir.Enabled = true;

            //    txtCarreiraSelecionada.Enabled = false;
            //    txtCarreiraSelecionada.Text = "";
            //    btnSalvar.Enabled = false;
            //    btnCancelar.Enabled = false;
            //}

            //Biblioteca.EscreverCarreira(idCarreira, nomeCarreira);
        }

        private void btnbNovo_Click(object sender, EventArgs e)
        {
            novo = true;

            btnSalvar.Enabled = true;
            txtCarreiraSelecionada.Enabled = true;
            btnbNovo.Enabled = false;
            btnCancelar.Enabled = true;

        }

        private void BtnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            linhaSelecionada = Convert.ToInt32(dataGridView1.CurrentRow.Index);

            txtCarreiraSelecionada.Text = Convert.ToString(nomeCarreira[linhaSelecionada]);
            btnbNovo.Enabled = false;
            btnbEditar.Enabled = true;
            btnExcluir.Enabled = true;
            btnbNovo.Enabled = true;
            btnCancelar.Enabled = true;
        }


    }
                 
}

    
    


    

