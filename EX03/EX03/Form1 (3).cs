using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EX03
{
    public partial class frmPrincipal : Form
    {

        int cupomFiscal = 0;
        double valorTotalProdutos = 0, SomatorioProdutos = 0;
        int totalItensComprados = 0;
        String itemSelecionado;

        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void chkNotaPaulista_CheckedChanged(object sender, EventArgs e)
        {
            if (chkNotaPaulista.Checked == true)
            {
                mskCPF.Enabled = true;
                mskCPF.Focus();
            }
            else
                mskCPF.Enabled = false;
        }

        private void btnAbreCupom_Click(object sender, EventArgs e)
        {

            chkNotaPaulista.Enabled = false;
            mskCPF.Enabled = false;
            txtCodigoBarras.Focus();
            grpProdutoAtual.Enabled = true;
            txtCodigoBarras.Focus();
            lblCupomFiscal.Visible = true;
            cupomFiscal += 1;
            lblCupomFiscal.Text = "Cupom Nº: " + cupomFiscal;
            btnAbreCupom.Enabled = false;
        }

        private void btnFinalizaCompra_Click(object sender, EventArgs e)
        {
            grpFormaPagamento.Enabled = true;
            btnPagamento.Enabled = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double troco=0;
            bool compraFinalizada = false;
            if (rdbCredito.Checked == true)
            {
                MessageBox.Show("Pagamento efetuado com cartão de crédito! Compra finalizada com sucesso.", "Finalizado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                compraFinalizada = true;
            }
            else if (rdbDebito.Checked == true)
            {
                MessageBox.Show("Pagamento efetuado com cartão de débito! Compra finalizada com sucesso.", "Finalizado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                compraFinalizada = true;
            }
            else if (rdbDinheiro.Checked == true)
            {
                if (Double.Parse(txtValorRecebido.Text) < SomatorioProdutos)
                {
                    MessageBox.Show("Pagamento NÃO efetuado. Valor menor que o valor da compra.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtValorRecebido.Text = "";
                    txtValorRecebido.Focus();
                    compraFinalizada = false;
                }
                else
                {
                    troco = Double.Parse(txtValorRecebido.Text) - SomatorioProdutos;
                    lblTroco.Text += " " + troco;
                    lblTroco.Visible = true;
                    MessageBox.Show("Pagamento efetuado com dinheiro. Verifique o troco! Compra finalizada com sucesso.", "Finalizado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    compraFinalizada = true;
                }

               }

            //Limpar campos
            if (compraFinalizada == true)
            {
                chkNotaPaulista.Enabled = true;
                btnAbreCupom.Enabled = true;
                lblCupomFiscal.Visible = false;
                lstItensCupom.Items.Clear();
                lblTotalCompra.Visible = false;
                troco = 0;
                lblTroco.Text = "Troco: R$";
                lblQuantidadeItens.Visible = false;
                totalItensComprados = 0;
                SomatorioProdutos = 0;
                lblTotalCompra.Text = "";
                valorTotalProdutos = 0;
                lblTroco.Visible = false;
                txtValorRecebido.Text = "";
                txtValorRecebido.Enabled = false;
                grpProdutoAtual.Enabled = false;
                btnPagamento.Enabled = false;
                rdbDebito.Checked = true;
                grpFormaPagamento.Enabled = false;

            }


        }

        private void rdbDinheiro_CheckedChanged(object sender, EventArgs e)
        {
            lblValorRecebido.Enabled = true;
            txtValorRecebido.Enabled = true;
            txtValorRecebido.Focus();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            itemSelecionado = lstItensCupom.SelectedItem.ToString();

            txtSenha.Enabled = true;
            btnConfirmaSenha.Enabled = true;

            txtSenha.Focus();

        }

        private void lstItensCupom_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnRemoverProduto.Enabled = true;
        }

        private void btnConfirmaSenha_Click(object sender, EventArgs e)
        {
            int senhaPadrao = 1234;
            int senhaDigitada=0;

            //Substring Variáveis
            string[] partes;
            string preco, quantidade;
            double totalRemover=0;

            string itemSelecionadoRemover;
            senhaDigitada = int.Parse(txtSenha.Text);
            if (senhaDigitada != senhaPadrao)
            {
                MessageBox.Show("Senha Inválida. Produto não excluído", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSenha.Text = "";
                txtSenha.Enabled = false;
                btnConfirmaSenha.Enabled = false;
                lstItensCupom.SelectedIndex = -1;
                txtCodigoBarras.Focus();
                btnRemoverProduto.Enabled = false;
            }
            else
            {
                lstItensCupom.Items.Remove(itemSelecionado);
                itemSelecionadoRemover = itemSelecionado;

                //Substring
                partes = itemSelecionadoRemover.Substring(1).Split('|');
                preco = partes[3];
                quantidade = partes[2];
                totalRemover = double.Parse(partes[3]) * double.Parse(partes[2]);
                SomatorioProdutos = SomatorioProdutos - totalRemover;
                lblTotalCompra.Text = "R$ " + SomatorioProdutos.ToString("n2");
                totalItensComprados = totalItensComprados - 1;
                lblQuantidadeItens.Text = "Itens: " + totalItensComprados.ToString();

                if (totalItensComprados == 0)
                    btnPagamento.Enabled = false;
                else
                    btnPagamento.Enabled = true;

                MessageBox.Show("Item removido com sucesso", "Removido", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtSenha.Text = "";
                txtSenha.Enabled = false;
                btnConfirmaSenha.Enabled = false;
                lstItensCupom.SelectedIndex = -1;
                txtCodigoBarras.Focus();
                btnRemoverProduto.Enabled = false;
            }

        }

        private void btnCancelarCupom_Click(object sender, EventArgs e)
        {
            cupomFiscal = cupomFiscal - 1;
            lblCupomFiscal.Text = "Cupom Nº: " + cupomFiscal;
            //Limpar Tudo.

        }

        private void rdbDebito_CheckedChanged(object sender, EventArgs e)
        {
            txtValorRecebido.Enabled = false;
            lblValorRecebido.Enabled = false;
        }

        private void rdbCredito_CheckedChanged(object sender, EventArgs e)
        {
            txtValorRecebido.Enabled = false;
            lblValorRecebido.Enabled = false;


        }

        private void btnAdicionarProduto_Click(object sender, EventArgs e)
        {
            string itemMenu = "";
            btnPagamento.Enabled = true;
            itemMenu = txtCodigoBarras.Text + " | " + txtDescricao.Text + " | " + txtQuantidade.Text + " | " + txtPrecoUnitario.Text + " | ";
            lstItensCupom.Items.Add(itemMenu);
            valorTotalProdutos = Double.Parse(txtPrecoUnitario.Text) * Double.Parse(txtQuantidade.Text);
            SomatorioProdutos = SomatorioProdutos + valorTotalProdutos;
            totalItensComprados += 1;

            txtCodigoBarras.Text = "";
            txtDescricao.Text = "";
            txtQuantidade.Text = "";
            txtPrecoUnitario.Text = "";
            txtCodigoBarras.Focus();

            lblTotalCompra.Visible = true;
            lblQuantidadeItens.Visible = true;
            lblTotalCompra.Text = "R$ " + SomatorioProdutos.ToString("n2");
            lblQuantidadeItens.Text = "Itens: " + totalItensComprados.ToString();

        }
    }
}
