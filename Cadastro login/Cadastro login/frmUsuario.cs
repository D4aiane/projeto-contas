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
    public partial class frmUsuario : Form
    {
        private void habilita()
        {
            cd_usuarioTextBox.Enabled = false;
            nm_usuarioTextBox.Enabled = true;
            sg_nivelTextBox.Enabled = true;
            nm_loginTextBox.Enabled = true;
            ds_senhaTextBox.Enabled = true;
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
            cd_usuarioTextBox.Enabled = false;
            nm_usuarioTextBox.Enabled = false;
            sg_nivelTextBox.Enabled = false;
            nm_loginTextBox.Enabled = false;
            ds_senhaTextBox.Enabled = false;
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
        public frmUsuario()
        {
            InitializeComponent();
        }

        private void frmUsuario_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'contasDataSet._tbUsuario__'. Você pode movê-la ou removê-la conforme necessário.
            this.tbUsuario__TableAdapter.Fill(this.contasDataSet._tbUsuario__);
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            habilita();
            tbUsuario__BindingSource.AddNew();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            desabilita();
            Validate();
            tbUsuario__BindingSource.EndEdit();
            tbUsuario__TableAdapter.Update(contasDataSet._tbUsuario__);
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            tbUsuario__BindingSource.MovePrevious();
        }

        private void btnProximo_Click(object sender, EventArgs e)
        {
            tbUsuario__BindingSource.MoveNext();
        }

        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void tbUsuario__BindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tbUsuario__BindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.contasDataSet);

        }

        private void tbUsuario__BindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            tbUsuario__BindingSource.CancelEdit();
            desabilita();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (tbUsuario__BindingSource.Count > 0)
            {
                habilita();
            }
            else
            {
                MessageBox.Show("Não há registros a alterar!");
            }
        }

        private void ds_senhaLabel_Click(object sender, EventArgs e)
        {

        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (tbUsuario__BindingSource.Count > 0)
            {
                tbUsuario__BindingSource.RemoveCurrent();
                tbUsuario__TableAdapter.Update(contasDataSet._tbUsuario__);
            }
            else
            {
                MessageBox.Show("Não há registros a excluir!");
            }
        }

        private void cd_usuarioLabel_Click(object sender, EventArgs e)
        {

        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {

        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
