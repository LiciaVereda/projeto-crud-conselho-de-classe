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
using System.IO;

namespace Cadastro
{

    public partial class formCadastro : Form
    {

        public ArrayList idCarreira = new ArrayList();
        public ArrayList nomeCarreira = new ArrayList();
        public ArrayList idProfissional = new ArrayList();
        public ArrayList nomeProfissional = new ArrayList();
        public ArrayList telefoneProfissional = new ArrayList();
        public ArrayList carreiraProfissional = new ArrayList();
        public int linhaSelecionada = 0;

        public formCadastro()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void menuCarreira_Click(object sender, EventArgs e)
        {
            frmConsultarCarreira carreira = new frmConsultarCarreira();
            carreira.Show();
        }

        private void menuProfissional_Click(object sender, EventArgs e)
        {
            frmProfissional profissional = new frmProfissional();
            profissional.Show();
        }
    }

}
