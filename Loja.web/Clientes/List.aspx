<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="List.aspx.cs" Inherits="Loja.web.Clientes.List" %>
<asp:Content ID="formList" ContentPlaceHolderID="conteudo" runat="server">
    <h2>Lista de Clientes</h2>
    <a href="Add.aspx">Adicionar Cliente</a>
    <asp:GridView ID="Lista" runat="server"></asp:GridView>
</asp:Content>
