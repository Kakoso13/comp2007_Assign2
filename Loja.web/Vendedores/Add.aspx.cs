using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Loja.BO;

namespace Loja.web.Vendedores
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
            Vendedor vendedor = new Vendedor();
            vendedor.Id = Convert.ToInt32(txtId.Text);
            vendedor.Nome = txtNome.Text;
            vendedor.Cpf = txtCpf.Text;
            vendedor.Email = txtEmail.Text;
            vendedor.Telefone = txtTelefone.Text;
            vendedor.Endereco = txtEndereco.Text;
            vendedor.DataCadastro = DateTime.Now;
            vendedor.DataAlteracao = DateTime.Now;

            if (BD.Vendedores.Adicionar(vendedor))
            {
                lblMenssagen.Text = "Vendedor adicionado com sucesso!";
            }
            else
            {
                lblMenssagen.Text = "Vendedor nao adicionado!";
            }
        }

        protected void btnNovo_Click(object sender, EventArgs e)
        {
            txtId.Text = "";
            txtNome.Text = "";
            txtCpf.Text = "";
            txtEmail.Text = "";
            txtTelefone.Text = "";
            txtEndereco.Text = "";
            lblMenssagen.Text = "";
        }
    }
}