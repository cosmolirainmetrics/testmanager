namespace TestManager
{
    partial class frmFeature
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSelecionar = new System.Windows.Forms.Button();
            this.lblCaminho = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.pcbAguarde = new System.Windows.Forms.PictureBox();
            this.dgvFeatures = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dgvCenario = new System.Windows.Forms.DataGridView();
            this.btnExportar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbAguarde)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFeatures)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCenario)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSelecionar);
            this.groupBox1.Controls.Add(this.lblCaminho);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(645, 50);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Planilha a ser importada";
            // 
            // btnSelecionar
            // 
            this.btnSelecionar.Image = global::TestManager.Properties.Resources._7183_32x32;
            this.btnSelecionar.Location = new System.Drawing.Point(532, 7);
            this.btnSelecionar.Name = "btnSelecionar";
            this.btnSelecionar.Size = new System.Drawing.Size(108, 42);
            this.btnSelecionar.TabIndex = 1;
            this.btnSelecionar.Text = "&Selecionar";
            this.btnSelecionar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSelecionar.UseVisualStyleBackColor = true;
            this.btnSelecionar.Click += new System.EventHandler(this.btnSelecionar_ClickAsync);
            // 
            // lblCaminho
            // 
            this.lblCaminho.AutoSize = true;
            this.lblCaminho.Location = new System.Drawing.Point(7, 20);
            this.lblCaminho.Name = "lblCaminho";
            this.lblCaminho.Size = new System.Drawing.Size(16, 13);
            this.lblCaminho.TabIndex = 0;
            this.lblCaminho.Text = "...";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.pcbAguarde);
            this.groupBox2.Controls.Add(this.dgvFeatures);
            this.groupBox2.Location = new System.Drawing.Point(12, 68);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(645, 164);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Features";
            // 
            // pcbAguarde
            // 
            this.pcbAguarde.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pcbAguarde.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pcbAguarde.Image = global::TestManager.Properties.Resources.carregando_pacotes;
            this.pcbAguarde.Location = new System.Drawing.Point(186, 86);
            this.pcbAguarde.Name = "pcbAguarde";
            this.pcbAguarde.Size = new System.Drawing.Size(304, 78);
            this.pcbAguarde.TabIndex = 1;
            this.pcbAguarde.TabStop = false;
            this.pcbAguarde.Visible = false;
            // 
            // dgvFeatures
            // 
            this.dgvFeatures.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFeatures.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvFeatures.Location = new System.Drawing.Point(3, 16);
            this.dgvFeatures.MultiSelect = false;
            this.dgvFeatures.Name = "dgvFeatures";
            this.dgvFeatures.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvFeatures.Size = new System.Drawing.Size(639, 145);
            this.dgvFeatures.TabIndex = 0;
            this.dgvFeatures.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFeatures_CellContentClick);
            this.dgvFeatures.SelectionChanged += new System.EventHandler(this.dgvFeatures_SelectionChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dgvCenario);
            this.groupBox3.Location = new System.Drawing.Point(15, 238);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(645, 177);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Cenários por Feature";
            // 
            // dgvCenario
            // 
            this.dgvCenario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCenario.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCenario.Location = new System.Drawing.Point(3, 16);
            this.dgvCenario.Name = "dgvCenario";
            this.dgvCenario.Size = new System.Drawing.Size(639, 158);
            this.dgvCenario.TabIndex = 0;
            // 
            // btnExportar
            // 
            this.btnExportar.Enabled = false;
            this.btnExportar.Image = global::TestManager.Properties.Resources._7182_32x32;
            this.btnExportar.Location = new System.Drawing.Point(15, 425);
            this.btnExportar.Name = "btnExportar";
            this.btnExportar.Size = new System.Drawing.Size(111, 44);
            this.btnExportar.TabIndex = 4;
            this.btnExportar.Text = "Exportar ";
            this.btnExportar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnExportar.UseVisualStyleBackColor = true;
            this.btnExportar.Click += new System.EventHandler(this.btnExportar_ClickAsync);
            // 
            // btnSair
            // 
            this.btnSair.Image = global::TestManager.Properties.Resources._2934_32x32;
            this.btnSair.Location = new System.Drawing.Point(546, 424);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(111, 44);
            this.btnSair.TabIndex = 5;
            this.btnSair.Text = "Sair";
            this.btnSair.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // frmFeature
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(669, 477);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnExportar);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmFeature";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gerador de BDD";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmFeature_FormClosed);
            this.Load += new System.EventHandler(this.frmFeature_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pcbAguarde)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFeatures)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCenario)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblCaminho;
        private System.Windows.Forms.Button btnSelecionar;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvFeatures;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dgvCenario;
        private System.Windows.Forms.PictureBox pcbAguarde;
        private System.Windows.Forms.Button btnExportar;
        private System.Windows.Forms.Button btnSair;
    }
}