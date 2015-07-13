using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Loja.BO;

namespace Loja.web.Produtos
{
    public partial class Add : System.Web.UI.Page
    {
        //caracteristics 
        public BD BD
        {
            get { return (BD)Application["BD"]; }
        }

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSalvar_Click(object sender, EventArgs e)
        {
            Produto produto = new Produto();
            produto.Id = Convert.ToInt32(txtId.Text);
            produto.Descricao = txtDescricao.Text;
            produto.Quantidade = txtQuantidade.Text;
            produto.Valor = txtValor.Text;
            produto.Categoria = txtCategoria.Text;
            produto.DataCadastro = DateTime.Now;
            produto.DataAlteracao = DateTime.Now;

            if (BD.Produtos.Adicionar(produto))
            {
                lblMenssagen.Text = "Item adicionado com sucesso!";
            }
            else
            {
                lblMenssagen.Text = "Item nao adicionado";
            }
            
        }

        protected void btnNovo_Click(object sender, EventArgs e)
        {
            txtId.Text = "";
            txtDescricao.Text = "";
            txtQuantidade.Text = "";
            txtValor.Text = "";
            txtCategoria.Text = "";

            lblMenssagen.Text = "";
        }
    }
}