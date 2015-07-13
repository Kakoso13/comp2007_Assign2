using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Loja.BO;

namespace Loja.web.Vendedores
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
                    Vendedor vendedor = BD.Vendedores.Consultar(id);
                    if (vendedor != null)
                    {
                        lblId.Text = vendedor.Id.ToString();
                        txtNome.Text = vendedor.Nome;
                        txtCpf.Text = vendedor.Cpf;
                        txtEmail.Text = vendedor.Email;
                        txtTelefone.Text = vendedor.Telefone;
                        txtEndereco.Text = vendedor.Endereco;
                        txtComissao.Text = vendedor.Comissao.ToString();
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
            Vendedor vendedor = BD.Vendedores.Consultar(id);
            if (vendedor != null)
            {
                vendedor.Nome = txtNome.Text;
                vendedor.Cpf = txtCpf.Text;
                vendedor.Email = txtEmail.Text;
                vendedor.Telefone = txtTelefone.Text;
                vendedor.Endereco = txtEndereco.Text;
                vendedor.Comissao = Convert.ToDecimal(txtComissao.Text);
                vendedor.DataAlteracao = DateTime.Now;
                lblMenssagen.Text = "Dados alterados com sucesso";
            }
        }
    }
}