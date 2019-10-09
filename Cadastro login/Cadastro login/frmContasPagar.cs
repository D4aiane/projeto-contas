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
    public partial class frmContasPagar : Form
    {
        private void habilita()
        {
            cd_contaTextBox.Enabled = false;
            dt_emissaoDateTimePicker.Enabled = true;
            dt_vencimentoDateTimePicker.Enabled = true;
            vl_contaTextBox.Enabled = true;
            id_fornecedorTextBox.Enabled = true;
            dt_pagamentoDateTimePicker.Enabled = true;
            vl_pagoTextBox.Enabled = true;
            ds_obsTextBox.Enabled = true;
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
            cd_contaTextBox.Enabled = false;
            dt_emissaoDateTimePicker.Enabled = false;
            dt_vencimentoDateTimePicker.Enabled = false;
            vl_contaTextBox.Enabled = false;
            id_fornecedorTextBox.Enabled = false;
            dt_pagamentoDateTimePicker.Enabled = false;
            vl_pagoTextBox.Enabled = false;
            ds_obsTextBox.Enabled = false;
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
        public frmContasPagar()
        {
            InitializeComponent();
        }

        private void tbContasPagar__BindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tbContasPagar__BindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.contasDataSet);

        }

        private void frmContasPagar_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'contasDataSet._tbContasPagar__'. Você pode movê-la ou removê-la conforme necessário.
            this.tbContasPagar__TableAdapter.Fill(this.contasDataSet._tbContasPagar__);

        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            tbContasPagar__BindingSource.MovePrevious();
        }

        private void btnProximo_Click(object sender, EventArgs e)
        {
            tbContasPagar__BindingSource.MoveNext();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            habilita();
            tbContasPagar__BindingSource.AddNew();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (tbContasPagar__BindingSource.Count > 0)
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
            if (tbContasPagar__BindingSource.Count > 0)
            {
                tbContasPagar__BindingSource.RemoveCurrent();
                tbContasPagar__TableAdapter.Update(contasDataSet._tbContasPagar__);
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
            tbContasPagar__BindingSource.EndEdit();
            tbContasPagar__TableAdapter.Update(contasDataSet._tbContasPagar__);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            tbContasPagar__BindingSource.CancelEdit();
            desabilita();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
