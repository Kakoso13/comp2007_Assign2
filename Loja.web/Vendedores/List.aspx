<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="List.aspx.cs" Inherits="Loja.web.Vendedores.List" %>
<asp:Content ID="formList" ContentPlaceHolderID="conteudo" runat="server">
    <h2>Lista de Vendedores</h2>
    <a href="Add.aspx">Adicionar Vendedor</a><br />
&nbsp;<asp:GridView ID="Lista" runat="server" AutoGenerateColumns="False">
        <Columns>
            <asp:HyperLinkField DataTextField="Cpf" HeaderText="CPF" />
            <asp:BoundField DataField="Nome" HeaderText="Nome" />
        </Columns>
    </asp:GridView>
</asp:Content>
