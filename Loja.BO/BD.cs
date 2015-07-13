using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loja.BO
{
    public class BD
    {
        private string diretorio;

        public Colecao<Produto> Produtos { get; set; }

        public Colecao<Vendedor> Vendedores { get; set; }

        public Colecao<Cliente> Clientes { get; set; }

        public BD(string diretorio)
        {
            Produtos = new Colecao<Produto>();
            Vendedores = new Colecao<Vendedor>();
            Clientes = new Colecao<Cliente>();
            this.diretorio = diretorio;
            Recuperar();
        }

        public void Gravar()
        {
            Produtos.Gravar(diretorio);
            Vendedores.Gravar(diretorio);
            Clientes.Gravar(diretorio);
        }

        public void Recuperar()
        {
            Produtos.Recuperar(diretorio);
            Vendedores.Recuperar(diretorio);
            Clientes.Recuperar(diretorio);
        }
    }
}
