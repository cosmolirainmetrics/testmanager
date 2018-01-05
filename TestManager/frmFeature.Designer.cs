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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFeature));
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
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Controls.Add(this.btnSelecionar);
            this.groupBox1.Controls.Add(this.lblCaminho);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // btnSelecionar
            // 
            resources.ApplyResources(this.btnSelecionar, "btnSelecionar");
            this.btnSelecionar.Image = global::TestManager.Properties.Resources._7183_32x32;
            this.btnSelecionar.Name = "btnSelecionar";
            this.btnSelecionar.UseVisualStyleBackColor = true;
            this.btnSelecionar.Click += new System.EventHandler(this.btnSelecionar_ClickAsync);
            // 
            // lblCaminho
            // 
            resources.ApplyResources(this.lblCaminho, "lblCaminho");
            this.lblCaminho.Name = "lblCaminho";
            // 
            // groupBox2
            // 
            resources.ApplyResources(this.groupBox2, "groupBox2");
            this.groupBox2.Controls.Add(this.pcbAguarde);
            this.groupBox2.Controls.Add(this.dgvFeatures);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.TabStop = false;
            // 
            // pcbAguarde
            // 
            resources.ApplyResources(this.pcbAguarde, "pcbAguarde");
            this.pcbAguarde.Image = global::TestManager.Properties.Resources.carregando_pacotes;
            this.pcbAguarde.Name = "pcbAguarde";
            this.pcbAguarde.TabStop = false;
            // 
            // dgvFeatures
            // 
            resources.ApplyResources(this.dgvFeatures, "dgvFeatures");
            this.dgvFeatures.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFeatures.MultiSelect = false;
            this.dgvFeatures.Name = "dgvFeatures";
            this.dgvFeatures.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvFeatures.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFeatures_CellContentClick);
            this.dgvFeatures.SelectionChanged += new System.EventHandler(this.dgvFeatures_SelectionChanged);
            // 
            // groupBox3
            // 
            resources.ApplyResources(this.groupBox3, "groupBox3");
            this.groupBox3.Controls.Add(this.dgvCenario);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.TabStop = false;
            // 
            // dgvCenario
            // 
            resources.ApplyResources(this.dgvCenario, "dgvCenario");
            this.dgvCenario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCenario.Name = "dgvCenario";
            // 
            // btnExportar
            // 
            resources.ApplyResources(this.btnExportar, "btnExportar");
            this.btnExportar.Image = global::TestManager.Properties.Resources._7182_32x32;
            this.btnExportar.Name = "btnExportar";
            this.btnExportar.UseVisualStyleBackColor = true;
            this.btnExportar.Click += new System.EventHandler(this.btnExportar_ClickAsync);
            // 
            // btnSair
            // 
            resources.ApplyResources(this.btnSair, "btnSair");
            this.btnSair.Image = global::TestManager.Properties.Resources._2934_32x32;
            this.btnSair.Name = "btnSair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // frmFeature
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnExportar);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.Name = "frmFeature";
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