using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Loja.BO;

namespace Loja.web.Clientes
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
                    Cliente cliente = BD.Clientes.Consultar(id);
                    if (cliente != null)
                    {
                        lblId.Text = cliente.Id.ToString();
                        txtNome.Text = cliente.Nome;
                        txtCpf.Text = cliente.Cpf;
                        txtEmail.Text = cliente.Email;
                        txtTelefone.Text = cliente.Telefone;
                        txtEndereco.Text = cliente.Endereco;
                        txtRendaFamiliar.Text = cliente.RendaFamiliar.ToString();
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
            Cliente cliente = BD.Clientes.Consultar(id);
            if (cliente != null)
            {
                cliente.Nome = txtNome.Text;
                cliente.Cpf = txtCpf.Text;
                cliente.Email = txtEmail.Text;
                cliente.Telefone = txtTelefone.Text;
                cliente.Endereco = txtEndereco.Text;
                cliente.RendaFamiliar = Convert.ToDecimal(txtRendaFamiliar.Text);
                cliente.DataAlteracao = DateTime.Now;
                lblMenssagen.Text = "Dados alterados com sucesso";
            }
        }
    }
}