<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="View.aspx.cs" Inherits="Loja.web.Produtos.view" %>
<asp:Content ID="formView" ContentPlaceHolderID="conteudo" runat="server">
    <h2>Vizualisar produto</h2>
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
                <asp:Label ID="lblDescricao" runat="server" Text=""></asp:Label>
            </td>
        </tr>
        <tr>
            <td>Quantidade: </td>
            <td>
                <asp:Label ID="lblQuantidade" runat="server" Text=""></asp:Label>
            </td>
        </tr>
        <tr>
            <td>Valor: </td>
            <td>
                <asp:Label ID="lblValor" runat="server" Text=""></asp:Label>
            </td>
        </tr>
        <tr>
            <td>Categoria: </td>
            <td>
                <asp:Label ID="lblCategoria" runat="server" Text=""></asp:Label>
            </td>
        </tr>
        <tr>
            <td>Data de cadastro: </td>
            <td>
                <asp:Label ID="lblDataCadastro" runat="server" Text=""></asp:Label>
            </td>
        </tr>
        <tr>
            <td>Data de Alteracao: </td>
            <td>
                <asp:Label ID="lblDataAlteracao" runat="server" Text=""></asp:Label>
            </td>
        </tr>
        <tr>
            <td></td>
            <td></td>
        </tr>
        <tr>
            <td></td>
            <td>
                <asp:Button ID="btnEditar" runat="server" Text="Editar Produto" OnClick="btnEditar_Click" />
                <asp:Button ID="btnExcluir" runat="server" Text="Excluir Produto" />
            </td>
        </tr>
    </table>
     <p>
        <asp:Label ID="lblMenssagen" runat="server" Text="Label"></asp:Label>
    </p>
</asp:Content>
