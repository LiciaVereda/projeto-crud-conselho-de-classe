namespace Cadastro
{
    partial class frmProfissional
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProfissional));
            this.btnSair = new System.Windows.Forms.Button();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbCarreira = new System.Windows.Forms.ComboBox();
            this.btnbListarProfissional = new System.Windows.Forms.Button();
            this.btnbNovo = new System.Windows.Forms.Button();
            this.btnbEditar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.dgvProfissional = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Carreira = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtProfissional = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTelefone = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProfissional)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(485, 295);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(75, 23);
            this.btnSair.TabIndex = 2;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(72, 9);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(378, 20);
            this.txtNome.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Nome";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Telefone";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.label4.Location = new System.Drawing.Point(17, 61);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Carreira";
            // 
            // cbCarreira
            // 
            this.cbCarreira.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCarreira.Enabled = false;
            this.cbCarreira.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCarreira.FormattingEnabled = true;
            this.cbCarreira.Location = new System.Drawing.Point(72, 61);
            this.cbCarreira.Name = "cbCarreira";
            this.cbCarreira.Size = new System.Drawing.Size(121, 21);
            this.cbCarreira.TabIndex = 11;
            // 
            // btnbListarProfissional
            // 
            this.btnbListarProfissional.BackColor = System.Drawing.SystemColors.Control;
            this.btnbListarProfissional.Location = new System.Drawing.Point(387, 122);
            this.btnbListarProfissional.Name = "btnbListarProfissional";
            this.btnbListarProfissional.Size = new System.Drawing.Size(75, 23);
            this.btnbListarProfissional.TabIndex = 13;
            this.btnbListarProfissional.Text = "Listar";
            this.btnbListarProfissional.UseVisualStyleBackColor = false;
            this.btnbListarProfissional.Click += new System.EventHandler(this.btnbListarProfissional_Click);
            // 
            // btnbNovo
            // 
            this.btnbNovo.Location = new System.Drawing.Point(485, 150);
            this.btnbNovo.Name = "btnbNovo";
            this.btnbNovo.Size = new System.Drawing.Size(75, 23);
            this.btnbNovo.TabIndex = 14;
            this.btnbNovo.Text = "Novo";
            this.btnbNovo.UseVisualStyleBackColor = true;
            this.btnbNovo.Click += new System.EventHandler(this.btnbNovo_Click);
            // 
            // btnbEditar
            // 
            this.btnbEditar.Enabled = false;
            this.btnbEditar.Location = new System.Drawing.Point(485, 179);
            this.btnbEditar.Name = "btnbEditar";
            this.btnbEditar.Size = new System.Drawing.Size(75, 23);
            this.btnbEditar.TabIndex = 15;
            this.btnbEditar.Text = "Editar";
            this.btnbEditar.UseVisualStyleBackColor = true;
            this.btnbEditar.Click += new System.EventHandler(this.btnbEditar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Enabled = false;
            this.btnExcluir.Location = new System.Drawing.Point(485, 208);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(75, 23);
            this.btnExcluir.TabIndex = 16;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Enabled = false;
            this.btnSalvar.Location = new System.Drawing.Point(485, 237);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 17;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Enabled = false;
            this.btnCancelar.Location = new System.Drawing.Point(485, 266);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 18;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // dgvProfissional
            // 
            this.dgvProfissional.AllowUserToAddRows = false;
            this.dgvProfissional.AllowUserToDeleteRows = false;
            this.dgvProfissional.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProfissional.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.Nome,
            this.Telefone,
            this.Carreira});
            this.dgvProfissional.Location = new System.Drawing.Point(20, 151);
            this.dgvProfissional.MultiSelect = false;
            this.dgvProfissional.Name = "dgvProfissional";
            this.dgvProfissional.ReadOnly = true;
            this.dgvProfissional.RowHeadersWidth = 51;
            this.dgvProfissional.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProfissional.Size = new System.Drawing.Size(438, 193);
            this.dgvProfissional.TabIndex = 19;
            this.dgvProfissional.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProfissional_CellClick);
           
            // 
            // id
            // 
            this.id.HeaderText = "id";
            this.id.MinimumWidth = 6;
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Width = 28;
            // 
            // Nome
            // 
            this.Nome.HeaderText = "Nome";
            this.Nome.MinimumWidth = 6;
            this.Nome.Name = "Nome";
            this.Nome.ReadOnly = true;
            this.Nome.Width = 160;
            // 
            // Telefone
            // 
            this.Telefone.HeaderText = "Telefone";
            this.Telefone.MinimumWidth = 6;
            this.Telefone.Name = "Telefone";
            this.Telefone.ReadOnly = true;
            this.Telefone.Width = 80;
            // 
            // Carreira
            // 
            this.Carreira.HeaderText = "Carreira";
            this.Carreira.MinimumWidth = 6;
            this.Carreira.Name = "Carreira";
            this.Carreira.ReadOnly = true;
            this.Carreira.Width = 125;
            // 
            // txtProfissional
            // 
            this.txtProfissional.Location = new System.Drawing.Point(53, 124);
            this.txtProfissional.Name = "txtProfissional";
            this.txtProfissional.Size = new System.Drawing.Size(328, 20);
            this.txtProfissional.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 124);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 22;
            this.label1.Text = "Nome";
            // 
            // txtTelefone
            // 
            this.txtTelefone.Location = new System.Drawing.Point(72, 35);
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Size = new System.Drawing.Size(121, 20);
            this.txtTelefone.TabIndex = 23;
            // 
            // frmProfissional
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(584, 411);
            this.Controls.Add(this.txtTelefone);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtProfissional);
            this.Controls.Add(this.dgvProfissional);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnbEditar);
            this.Controls.Add(this.btnbNovo);
            this.Controls.Add(this.btnbListarProfissional);
            this.Controls.Add(this.cbCarreira);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.btnSair);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.ImeMode = System.Windows.Forms.ImeMode.Alpha;
            this.Name = "frmProfissional";
            this.Text = "Profissional";
            this.Load += new System.EventHandler(this.frmProfissional_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProfissional)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbCarreira;
        private System.Windows.Forms.Button btnbListarProfissional;
        private System.Windows.Forms.Button btnbNovo;
        private System.Windows.Forms.Button btnbEditar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.DataGridView dgvProfissional;
        private System.Windows.Forms.TextBox txtProfissional;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTelefone;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefone;
        private System.Windows.Forms.DataGridViewTextBoxColumn Carreira;
    }
}