<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="List.aspx.cs" Inherits="Loja.web.Produtos.List" %>
<asp:Content ID="formList" ContentPlaceHolderID="conteudo" runat="server">
    <h2>Lista de produtos</h2>
    <a href="Add.aspx">Adicionar Item</a><br />
&nbsp;<asp:GridView ID="Lista" runat="server" AutoGenerateColumns="False">
        <Columns>
            <asp:HyperLinkField DataTextField="Descricao" HeaderText="Produto" />
            <asp:BoundField DataField="Categoria" HeaderText="Categoria" />
        </Columns>
    </asp:GridView>
</asp:Content>
