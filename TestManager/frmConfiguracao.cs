using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using TestManager.BLL;

namespace TestManager
{
    public partial class frmConfiguracao : Form
    {
        Configuracao configuracao = new Configuracao();

        public frmConfiguracao()
        {
            InitializeComponent();
        }

        private void frmConfiguracao_Load(object sender, EventArgs e)
        {                        
            var fields = configuracao.CarregarCampos();

            this.txtConfiguracao.Text = fields.ToString();            
        }       

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!configuracao.IsValidJson(this.txtConfiguracao.Text))
                {
                    MessageBox.Show("Json inválido!");
                    this.txtConfiguracao.Focus();
                }
                else
                {
                    File.Delete(configuracao.GetCaminhoArquivo());

                    using (var str = new StreamWriter(configuracao.GetCaminhoArquivo()))
                    {
                        str.Write(this.txtConfiguracao.Text);
                    }

                    Application.Exit();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro");
            }
        }
    }
}
