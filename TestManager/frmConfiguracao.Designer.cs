namespace TestManager
{
    partial class frmConfiguracao
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
            this.trvCampos = new System.Windows.Forms.TreeView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblNoSelecionado = new System.Windows.Forms.Label();
            this.txtItemSelecionado = new System.Windows.Forms.TextBox();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.btnAcima = new System.Windows.Forms.Button();
            this.btnAbaixo = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // trvCampos
            // 
            this.trvCampos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.trvCampos.Location = new System.Drawing.Point(3, 16);
            this.trvCampos.Name = "trvCampos";
            this.trvCampos.Size = new System.Drawing.Size(317, 426);
            this.trvCampos.TabIndex = 1;
            this.trvCampos.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.trvCampos_NodeMouseDoubleClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.trvCampos);
            this.groupBox1.Location = new System.Drawing.Point(8, 7);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(323, 445);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Estrutura da Planilha";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblNoSelecionado);
            this.groupBox2.Controls.Add(this.txtItemSelecionado);
            this.groupBox2.Location = new System.Drawing.Point(337, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(318, 71);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Item Selecionado";
            // 
            // lblNoSelecionado
            // 
            this.lblNoSelecionado.AutoSize = true;
            this.lblNoSelecionado.Location = new System.Drawing.Point(7, 20);
            this.lblNoSelecionado.Name = "lblNoSelecionado";
            this.lblNoSelecionado.Size = new System.Drawing.Size(16, 13);
            this.lblNoSelecionado.TabIndex = 1;
            this.lblNoSelecionado.Text = "...";
            // 
            // txtItemSelecionado
            // 
            this.txtItemSelecionado.Location = new System.Drawing.Point(6, 42);
            this.txtItemSelecionado.Name = "txtItemSelecionado";
            this.txtItemSelecionado.Size = new System.Drawing.Size(309, 20);
            this.txtItemSelecionado.TabIndex = 0;
            this.txtItemSelecionado.TextChanged += new System.EventHandler(this.txtItemSelecionado_TextChanged);
            // 
            // btnAlterar
            // 
            this.btnAlterar.Image = global::TestManager.Properties.Resources._7182_32x32;
            this.btnAlterar.Location = new System.Drawing.Point(449, 91);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(50, 48);
            this.btnAlterar.TabIndex = 6;
            this.btnAlterar.Tag = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Image = global::TestManager.Properties.Resources._2934_32x32;
            this.btnExcluir.Location = new System.Drawing.Point(393, 91);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(50, 48);
            this.btnExcluir.TabIndex = 5;
            this.btnExcluir.Tag = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Image = global::TestManager.Properties.Resources._7183_32x32;
            this.btnAdicionar.Location = new System.Drawing.Point(337, 91);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(50, 48);
            this.btnAdicionar.TabIndex = 4;
            this.btnAdicionar.Tag = "Adicionar";
            this.btnAdicionar.UseVisualStyleBackColor = true;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // btnAcima
            // 
            this.btnAcima.BackColor = System.Drawing.Color.White;
            this.btnAcima.Image = global::TestManager.Properties.Resources._8470_16x16;
            this.btnAcima.Location = new System.Drawing.Point(335, 176);
            this.btnAcima.Name = "btnAcima";
            this.btnAcima.Size = new System.Drawing.Size(31, 32);
            this.btnAcima.TabIndex = 7;
            this.btnAcima.UseVisualStyleBackColor = false;
            this.btnAcima.Click += new System.EventHandler(this.btnAcima_Click);
            // 
            // btnAbaixo
            // 
            this.btnAbaixo.BackColor = System.Drawing.Color.White;
            this.btnAbaixo.Image = global::TestManager.Properties.Resources._8464_16x16;
            this.btnAbaixo.Location = new System.Drawing.Point(335, 215);
            this.btnAbaixo.Name = "btnAbaixo";
            this.btnAbaixo.Size = new System.Drawing.Size(31, 35);
            this.btnAbaixo.TabIndex = 8;
            this.btnAbaixo.UseVisualStyleBackColor = false;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(566, 401);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(86, 48);
            this.btnSalvar.TabIndex = 9;
            this.btnSalvar.Text = "Salvar e Fechar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // frmConfiguracao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(665, 464);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.btnAbaixo);
            this.Controls.Add(this.btnAcima);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnAdicionar);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmConfiguracao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmConfiguracao";
            this.Load += new System.EventHandler(this.frmConfiguracao_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView trvCampos;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtItemSelecionado;
        private System.Windows.Forms.Label lblNoSelecionado;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnAcima;
        private System.Windows.Forms.Button btnAbaixo;
        private System.Windows.Forms.Button btnSalvar;
    }
}