using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Loja.BO;

namespace Loja.web.Produtos
{
    public partial class Edit : System.Web.UI.Page
    {
        //caracteristics 
        public BD BD
        {
            get { return (BD)Application["BD"]; }
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                if (Request.QueryString["Id"] != null)
                {
                    int id = Convert.ToInt32(Request.QueryString["Id"]);
                    Produto produto = BD.Produtos.Consultar(id);
                    if (produto != null)
                    {
                        lblId.Text = produto.Id.ToString();
                        txtDescricao.Text = produto.Categoria;
                        txtQuantidade.Text = txtQuantidade.Text;
                        txtValor.Text = txtValor.Text;
                        txtCategoria.Text = txtCategoria.Text;
                    }
                }
            }
        }

        protected void btnNovo_Click(object sender, EventArgs e)
        {
            Response.Redirect("Add.aspx");
        }

        protected void btnSalvar_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(lblId.Text);
            Produto produto = BD.Produtos.Consultar(id);
            if (produto != null)
            {
                produto.Descricao = txtDescricao.Text;
                produto.Quantidade = txtQuantidade.Text;
                produto.Valor = txtValor.Text;
                produto.Categoria = txtCategoria.Text;
                produto.DataAlteracao = DateTime.Now;
                lblMenssagen.Text = "Dados alterados com sucesso";
            }
        }
    }
}