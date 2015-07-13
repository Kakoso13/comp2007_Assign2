<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Edit.aspx.cs" Inherits="Loja.web.Produtos.Edit" %>
<asp:Content ID="formEdit" ContentPlaceHolderID="conteudo" runat="server">
    <h2>Editar produto</h2>
    <table>
        <tr>
            <td>Id: </td>
            <td>
                <asp:Label ID="lblId" runat="server" Text=""></asp:Label>
            </td>
        </tr>
        <tr>
            <td>Descricao: </td>
            <td>
                <asp:TextBox ID="txtDescricao" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>Quantidade: </td>
            <td>
                <asp:TextBox ID="txtQuantidade" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>Valor: </td>
            <td>
                <asp:TextBox ID="txtValor" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>Categoria: </td>
            <td>
                <asp:TextBox ID="txtCategoria" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td></td>
            <td></td>
        </tr>
        <tr>
            <td></td>
            <td>
                <asp:Button ID="btnSalvar" runat="server" Text="Salvar Produto" />
                <asp:Button ID="btnNovo" runat="server" Text="Novo Produto" OnClick="btnNovo_Click" />
            </td>
        </tr>
    </table>
    <p>
        <asp:Label ID="lblMenssagen" runat="server" Text="Label"></asp:Label>
    </p>
</asp:Content>
