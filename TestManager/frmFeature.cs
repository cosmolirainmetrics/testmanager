using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TestManager.BLL;
using TestManager.Model;

namespace TestManager
{
    public partial class frmFeature : Form
    {
        Feature feature = new Feature();
        List<Funcionalidade> funcionalidades = new List<Funcionalidade>();

        public frmFeature()
        {
            InitializeComponent();
        }

        private async void btnSelecionar_ClickAsync(object sender, EventArgs e)
        {
            if (this.btnSelecionar.Text == "&Selecionar")
            {
                if (this.lblCaminho.Text == "...")
                {
                    var opf = new OpenFileDialog
                    {
                        Filter = "Planilha Excel|*.xlsx",
                        Title = "Seleione a Planilha"
                        // |Planilha Excel 97 a 2000 |*.xls
                    };

                    DialogResult result = opf.ShowDialog();
                    if (result == DialogResult.OK)
                    {
                        if (!File.Exists(opf.FileName))
                        {
                            MessageBox.Show("O arquivo selecionado é inválido");
                        }
                        else
                        {
                            this.lblCaminho.Text = opf.FileName;
                            this.btnSelecionar.Text = "Visualizar";
                        }
                    }
                }
            }
            else
            {
                this.LockScreen(true);
                
                

                await Task.Run(() =>
                {                   
                    funcionalidades = feature.ImportarPlanilha(this.lblCaminho.Text).Result;                                        
                });               

                this.dgvFeatures.DataSource = funcionalidades;
                this.dgvFeatures.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
                this.dgvFeatures.Refresh();
                this.LockScreen(false);
            }
        }

        private void frmFeature_Load(object sender, EventArgs e)
        {

        }

        private void LimpaTela()
        {
            frmFeature frm = new frmFeature();
            frm.Show();
            this.Dispose(false);            
        }

        private void LockScreen(bool lockControl = true)
        {
            this.pcbAguarde.Visible = lockControl;
            this.btnSelecionar.Enabled = lockControl == true ? false : true;
            this.btnExportar.Enabled = lockControl == true ? false : true; 
        }

        private void dgvFeatures_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void dgvFeatures_SelectionChanged(object sender, EventArgs e)
        {
             if (this.dgvFeatures.SelectedRows != null)
            {
                var dataItem = this.dgvFeatures.SelectedRows;
                Funcionalidade funcionalidade = dataItem.Count > 0 ? (Funcionalidade)dataItem[0].DataBoundItem : null;
                
                this.dgvCenario.DataSource = funcionalidade != null ? funcionalidade.Cenarios : new List<Cenario>();
                this.dgvCenario.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
                this.dgvCenario.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                this.dgvCenario.Refresh();
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Deseja sair do sistema?", "TestManager", MessageBoxButtons.YesNo);
            if(result == DialogResult.Yes)
                this.Close();
        }

        private void frmFeature_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private async void btnExportar_ClickAsync(object sender, EventArgs e)
        {
            var fdb = new FolderBrowserDialog();

            try
            {                
                DialogResult result = fdb.ShowDialog();

                foreach (Funcionalidade funcionalidade in this.funcionalidades)
                {
                    if (!string.IsNullOrEmpty(funcionalidade.Arquivo))
                        funcionalidade.Arquivo = Path.Combine(fdb.SelectedPath, funcionalidade.Arquivo);
                    else
                    {
                        MessageBox.Show("Informe o nome do(s) arquivo(s)", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }

                if (result == DialogResult.OK)
                {
                    if (Directory.Exists(fdb.SelectedPath))
                    {
                        this.LockScreen(true);

                        await Task.Run(() =>
                        {
                            var t = feature.ExportarPlanilha(this.funcionalidades).Result;
                        });

                        MessageBox.Show("Arquivo(s) críado(s) com sucesso!", "TestManager", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.LockScreen(false);
                        this.LimpaTela();
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(string.Format("Erro: {0}\n Inner: {1}", ex.Message, ex.InnerException.Message), "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.LockScreen(false);                
            }
            
        }
    }
}
