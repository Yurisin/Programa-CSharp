using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ControleEstoque1
{
    public partial class frmProduto : ControleEstoque1.FrmBase
    {
        public frmProduto()
        {
            InitializeComponent();
            BloqueiaCampos();
            CarregarGrid();
        }

        private void CarregarGrid()
        {
            Model get = new Model();
            List<DtoProduto2> lista = get.ListProdutos();
            this.ViewProduto.DataSource = lista;
            this.ViewProduto.Refresh();
        }

        private void bntNovo_Click(object sender, EventArgs e)
        {
            txtNomeProduto.Text = string.Empty; 
            txtCategoriaProduto.Text = string.Empty;
            txtValorProduto.Text = string.Empty;
            LiberaCampos();
            txtNomeProduto.Focus();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                Model set = new Model();
                DtoProduto p = new DtoProduto();
                p.nome = txtNomeProduto.Text;
                p.categoria = txtCategoriaProduto.Text;
                p.valor = txtValorProduto.Text;
                if (txtIDProduto.Text != string.Empty)
                {
                    p.id = int.Parse(txtIDProduto.Text);
                    set.EditarProduto(p);
                }
                else
                {
                    set.SetProduto(p);
                }

                BloqueiaCampos();
                CarregarGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        #region Tratamento Visual
        private void LiberaCampos()
        {
            txtIDProduto.Enabled = true;
            txtNomeProduto.Enabled = true;
            txtCategoriaProduto.Enabled = true;
            txtValorProduto.Enabled = true;

        }
        private void BloqueiaCampos()
        {
            txtIDProduto.Enabled = false;
            txtNomeProduto.Enabled = false;
            txtCategoriaProduto.Enabled = false;
            txtValorProduto.Enabled = false;
        }
        #endregion
        private void ViewProduto_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int ID = (Int32)ViewProduto.CurrentRow.Cells[0].Value;

            Model get = new Model();
            DtoProduto2 pd = get.GetProdutoId(ID);
            txtIDProduto.Text = pd.id.ToString();
            txtNomeProduto.Text = pd.nome;
            LiberaCampos();
            txtNomeProduto.Focus();
        }

        private void btnExcluir_Click_1(object sender, EventArgs e)
        {
            if (txtIDProduto.Text != string.Empty)
            {
                Model del = new Model();

                if(del.DeletarProduto(int.Parse(txtIDProduto.Text))) 
                {   
                    del.DeletarProduto(int.Parse(txtIDProduto.Text));
                    BloqueiaCampos();
                    CarregarGrid();
                }
                else
                {
                    MessageBox.Show("Nao existe ID cadastrado");
                }
                
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            LiberaCampos();
            txtNomeProduto.Focus();
        }

              
	

	

    }
}
