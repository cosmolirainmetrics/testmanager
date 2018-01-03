using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TestManager.BLL;

namespace TestManager
{
    public partial class frmConfiguracao : Form
    {
        string _noSelecionado = null;

        public frmConfiguracao()
        {
            InitializeComponent();
        }

        private void frmConfiguracao_Load(object sender, EventArgs e)
        {
            this.IniciaTela(true, false, false);
            Configuracao configuracao = new Configuracao();
            var fields = configuracao.CarregarCampos();
            
            foreach(var field in fields)
            {
                TreeNode node = new TreeNode();
                node.Name = field.ToString();
                node.Text = field.ToString();

                foreach (var item in field.Value)
                {                    
                    TreeNode children = new TreeNode();
                    children.Name = item.ToString();
                    children.Text = item.ToString();

                    node.Nodes.Add(children);
                }

                this.trvCampos.Nodes.Add(node);
            }            
        }

        private void trvCampos_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            this._noSelecionado = this.trvCampos.SelectedNode.Text;
            this.lblNoSelecionado.Text = this._noSelecionado;
            this.txtItemSelecionado.Text = this.trvCampos.SelectedNode.Text;
            this.IniciaTela(true, true, true);
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(this.txtItemSelecionado.Text))
            {
                this.txtItemSelecionado.Focus();
            }
            else
            {
                DialogResult resposta = MessageBox.Show("Deseja adicionar o valor ao nó selecionado?", "", MessageBoxButtons.YesNo);

                if (resposta == DialogResult.Yes)
                {
                    if(this.trvCampos.SelectedNode.Parent == null)
                        MessageBox.Show("Selecione um nó", "", MessageBoxButtons.OK);

                    this.trvCampos.SelectedNode.Parent.Nodes.Add(this.txtItemSelecionado.Text);
                    this.txtItemSelecionado.Clear();
                    this._noSelecionado = null;
                }
            }
        }

        private void txtItemSelecionado_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.txtItemSelecionado.Text))
            {
                this.IniciaTela(true, false, false);                
            }
            else
            {
                this.IniciaTela(true, true, true);
            }
        }

        private void IniciaTela(bool adicionar, bool alterar, bool excluir, bool abreControles = false)
        {
            if (abreControles)
            {
                this.btnAdicionar.Enabled = abreControles;
                this.btnAlterar.Enabled = abreControles;
                this.btnExcluir.Enabled = abreControles;
            }
            else
            {
                this.btnAdicionar.Enabled = adicionar;
                this.btnAlterar.Enabled = alterar;
                this.btnExcluir.Enabled = excluir;
            }

            this.lblNoSelecionado.Text = this._noSelecionado;
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            this.trvCampos.SelectedNode.Remove();
            this.txtItemSelecionado.Clear();
            this._noSelecionado = null;
            this.IniciaTela(true, false, false);
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            this.trvCampos.SelectedNode.Text = this.txtItemSelecionado.Text;
            this.txtItemSelecionado.Clear();
            this._noSelecionado = null;
            this.IniciaTela(true, false, false);
        }

        private void btnAcima_Click(object sender, EventArgs e)
        {
            var prevNode = this.trvCampos.SelectedNode.PrevNode;
            TreeNode prev = (TreeNode)prevNode.Clone();
            var node = this.trvCampos.SelectedNode;
            prevNode.Name = node.Name;
            prevNode.Text = node.Text;
            
            node.Name = prev.Name;
            node.Text = prev.Text;

            this.trvCampos.Nodes.Remove(prevNode);

            this.trvCampos.Update();
            this.trvCampos.Refresh();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            TreeNodeCollection col = this.trvCampos.Nodes;

            string json = JsonConvert.SerializeObject(col);

        }
    }
}
