using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cadastro_login
{
    public partial class frmFornecedor : Form
    {
        private void habilita()
        {
            cd_fornecedorTextBox.Enabled = false;
            nm_fornecedorTextBox.Enabled = true;
            ds_enderecoTextBox.Enabled = true;
            nm_cidadeTextBox.Enabled = true;
            nm_bairroTextBox.Enabled = true;
            cd_cepTextBox.Enabled = true;
            ds_telefoneTextBox.Enabled = true;
            ds_emailTextBox.Enabled = true;
            sg_tipoTextBox.Enabled = true;
            cd_cpfTextBox.Enabled = true;
            sg_estadoTextBox.Enabled = true;
            cd_cnpjTextBox.Enabled = true;
            cd_ieTextBox.Enabled = true;
            cd_rgTextBox.Enabled = true;
            btnSalvar.Enabled = true;
            btnCancelar.Enabled = true;
            btnAlterar.Enabled = false;
            btnProximo.Enabled = false;
            btnNovo.Enabled = false;
            btnAlterar.Enabled = false;
            btnExcluir.Enabled = false;
            btnPesquisar.Enabled = false;
            btnImprimir.Enabled = false;
            btnSair.Enabled = false;
        }

        private void desabilita()
        {
            cd_fornecedorTextBox.Enabled = false;
            nm_fornecedorTextBox.Enabled = false;
            ds_enderecoTextBox.Enabled = false;
            nm_cidadeTextBox.Enabled = false;
            nm_bairroTextBox.Enabled = false;
            cd_cepTextBox.Enabled = false;
            ds_telefoneTextBox.Enabled = false;
            ds_emailTextBox.Enabled = false;
            sg_tipoTextBox.Enabled = false;
            cd_cpfTextBox.Enabled = false;
            sg_estadoTextBox.Enabled = false;
            cd_cnpjTextBox.Enabled = false;
            cd_ieTextBox.Enabled = false;
            cd_rgTextBox.Enabled = false;
            btnSalvar.Enabled = false;
            btnCancelar.Enabled = false;
            btnAlterar.Enabled = true;
            btnProximo.Enabled = true;
            btnNovo.Enabled = true;
            btnAlterar.Enabled = true;
            btnExcluir.Enabled = true;
            btnPesquisar.Enabled = true;
            btnImprimir.Enabled = true;
            btnSair.Enabled = true;
        }
        public frmFornecedor()
        {
            InitializeComponent();
        }

        private void tbFornecedor__BindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tbFornecedor__BindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.contasDataSet);

        }

        private void frmFornecedor_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'contasDataSet._tbFornecedor__'. Você pode movê-la ou removê-la conforme necessário.
            this.tbFornecedor__TableAdapter.Fill(this.contasDataSet._tbFornecedor__);

        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            tbFornecedor__BindingSource.MovePrevious();
        }

        private void btnProximo_Click(object sender, EventArgs e)
        {
            tbFornecedor__BindingSource.MoveNext();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            habilita();
            tbFornecedor__BindingSource.AddNew();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (tbFornecedor__BindingSource.Count > 0)
            {
                habilita();
            }
            else
            {
                MessageBox.Show("Não há registros a alterar!");
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
           if(tbFornecedor__BindingSource.Count > 0)
            {
                tbFornecedor__BindingSource.RemoveCurrent();
                tbFornecedor__TableAdapter.Update(contasDataSet._tbFornecedor__);
            }
            else
            {
                MessageBox.Show("Não há registros a excluir!");
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            desabilita();
            Validate();
            tbFornecedor__BindingSource.EndEdit();
            tbFornecedor__TableAdapter.Update(contasDataSet._tbFornecedor__);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            tbFornecedor__BindingSource.CancelEdit();
            desabilita();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void cd_fornecedorLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
