using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Loja.BO;

namespace Loja.web.Produtos
{
    public partial class view : System.Web.UI.Page
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
                        lblDescricao.Text = produto.Descricao;
                        lblQuantidade.Text = produto.Quantidade.ToString();
                        lblValor.Text = produto.Valor.ToString();
                        lblCategoria.Text = produto.Categoria;  
                        lblDataCadastro.Text = produto.DataCadastro.ToString("dd/MM/yyyy HH:mm:ss");
                        lblDataAlteracao.Text = produto.DataAlteracao.ToString("dd/MM/yyyy HH:mm:ss");
                    }
                }
            }
        }

        protected void btnEditar_Click(object sender, EventArgs e)
        {
            Response.Redirect(string.Format("Edit.aspx?Id={0}", lblId.Text));
        }

        protected void btnExcluir_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(lblId.Text);
            if (BD.Produtos.Excluir(id))
            {
                Response.Redirect("List.aspx");
            }
        }
    }
}