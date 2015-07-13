using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Loja.BO;

namespace Loja.web.Clientes
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
            Cliente cliente = new Cliente();
            cliente.Id = Convert.ToInt32(txtId.Text);
            cliente.Nome = txtNome.Text;
            cliente.Cpf = txtCpf.Text;
            cliente.Email = txtEmail.Text;
            cliente.Telefone = txtTelefone.Text;
            cliente.Endereco = txtEndereco.Text;
            cliente.RendaFamiliar = Convert.ToDecimal(txtRendaFamiliar.Text);
            cliente.DataCadastro = DateTime.Now;
            cliente.DataAlteracao = DateTime.Now;

            if (BD.Clientes.Adicionar(cliente))
            {
                lblMenssagen.Text = "Cliente adicionado com sucesso!";
            }
            else
            {
                lblMenssagen.Text = "Cliente nao adicionado!";
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
            txtRendaFamiliar.Text = "";
            lblMenssagen.Text = "";
        }
    }
}