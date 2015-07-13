<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="sobre.aspx.cs" Inherits="Loja.web.sobre" %>
<asp:Content ID="formSobre" ContentPlaceHolderID="conteudo" runat="server">
    <h2>
        Sobre o meu projeto
    </h2>
    <p>
        Essa pagina serve como exemplo para uma possivel implantacao a um sistema no Brasil
    </p>
    <p>
        <asp:Button ID="btnGravar" runat="server" Text="Gravar banco de dados" OnClick="btnGravar_Click" />
    </p>
</asp:Content>
