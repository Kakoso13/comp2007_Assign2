using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Loja.BO;

namespace Loja.web.Clientes
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
                if(Request.QueryString["Id"] != null)
                {
                    int id = Convert.ToInt32(Request.QueryString["Id"]);
                    Cliente cliente = BD.Clientes.Consultar(id);
                    if (cliente != null)
                    {
                        lblId.Text = cliente.Id.ToString();
                        lblNome.Text = cliente.Nome;
                        lblCpf.Text = cliente.Cpf;
                        lblEmail.Text = cliente.Email;
                        lblTelefone.Text = cliente.Telefone;
                        lblEndereco.Text = cliente.Endereco;
                        lblRendaFamiliar.Text = cliente.RendaFamiliar.ToString();
                        lblDataCadastro.Text = cliente.DataCadastro.ToString("dd/MM/yyyy HH:mm:ss");
                        lblDataAlteracao.Text = cliente.DataAlteracao.ToString("dd/MM/yyyy HH:mm:ss");
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
            if (BD.Clientes.Excluir(id))
            {
                Response.Redirect("List.aspx");
            }
        }
    }
}