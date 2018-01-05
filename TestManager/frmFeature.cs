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

namespace TestManager
{
    public partial class frmFeature : Form
    {
        public frmFeature()
        {
            InitializeComponent();
        }

        private void btnSelecionar_Click(object sender, EventArgs e)
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
                Feature feature = new Feature();
                feature.ImportarPlanilha(this.lblCaminho.Text);
            }
        }

        private void frmFeature_Load(object sender, EventArgs e)
        {

        }
    }
}
