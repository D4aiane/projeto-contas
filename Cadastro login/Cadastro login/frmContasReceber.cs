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
    public partial class frmContasReceber : Form
    {
        private void habilita()
        {
            cd_contaTextBox.Enabled = false;
            dt_vencimentoDateTimePicker.Enabled = true;
            id_clienteTextBox.Enabled = true;
            vl_pagoTextBox.Enabled = true;
            dt_emissaoDateTimePicker.Enabled = true;
            vl_contaTextBox.Enabled = true;
            dt_pagamentoDateTimePicker.Enabled = true;
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
            dt_vencimentoDateTimePicker.Enabled = false;
            id_clienteTextBox.Enabled = false;
            vl_pagoTextBox.Enabled = false;
            dt_emissaoDateTimePicker.Enabled = false;
            vl_contaTextBox.Enabled = false;
            dt_pagamentoDateTimePicker.Enabled = false;
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

        public frmContasReceber()
        {
            InitializeComponent();
        }

        private void tbContasReceber__BindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tbContasReceber__BindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.contasDataSet);

        }

        private void frmContasReceber_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'contasDataSet._tbContasReceber__'. Você pode movê-la ou removê-la conforme necessário.
            this.tbContasReceber__TableAdapter.Fill(this.contasDataSet._tbContasReceber__);

        }

        private void dt_pagamentoLabel_Click(object sender, EventArgs e)
        {

        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (tbContasReceber__BindingSource.Count > 0)
            {
                habilita();
            }
            else
            {
                MessageBox.Show("Não há registros a alterar!");
            }
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {

        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            tbContasReceber__BindingSource.MovePrevious();
        }

        private void btnProximo_Click(object sender, EventArgs e)
        {
            tbContasReceber__BindingSource.MoveNext();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            habilita();
            tbContasReceber__BindingSource.AddNew();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (tbContasReceber__BindingSource.Count > 0)
            {
                tbContasReceber__BindingSource.RemoveCurrent();
                tbContasReceber__TableAdapter.Update(contasDataSet._tbContasReceber__);
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
            tbContasReceber__BindingSource.EndEdit();
            tbContasReceber__TableAdapter.Update(contasDataSet._tbContasReceber__);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            tbContasReceber__BindingSource.CancelEdit();
            desabilita();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
