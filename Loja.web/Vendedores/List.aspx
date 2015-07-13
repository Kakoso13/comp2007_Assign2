<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="List.aspx.cs" Inherits="Loja.web.Vendedores.List" %>
<asp:Content ID="formList" ContentPlaceHolderID="conteudo" runat="server">
    <h2>Lista de Vendedores</h2>
    <a href="Add.aspx">Adicionar Vendedor</a>
    <asp:GridView ID="Lista" runat="server"></asp:GridView>
</asp:Content>
