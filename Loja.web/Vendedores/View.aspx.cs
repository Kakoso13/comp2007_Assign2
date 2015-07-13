using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Loja.BO;

namespace Loja.web.Vendedores
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
                    Vendedor vendedor = BD.Vendedores.Consultar(id);
                    if (vendedor != null)
                    {
                        lblId.Text = vendedor.Id.ToString();
                        lblNome.Text = vendedor.Nome;
                        lblCpf.Text = vendedor.Cpf;
                        lblEmail.Text = vendedor.Email;
                        lblTelefone.Text = vendedor.Telefone;
                        lblEndereco.Text = vendedor.Endereco;
                        lblComissao.Text = vendedor.Comissao.ToString();
                        lblDataCadastro.Text = vendedor.DataCadastro.ToString("dd/MM/yyyy HH:mm:ss");
                        lblDataAlteracao.Text = vendedor.DataAlteracao.ToString("dd/MM/yyyy HH:mm:ss");
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
            if (BD.Vendedores.Excluir(id))
            {
                Response.Redirect("List.aspx");
            }
        }
    }
}