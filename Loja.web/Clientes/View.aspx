<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="View.aspx.cs" Inherits="Loja.web.Clientes.view" %>
<asp:Content ID="formView" ContentPlaceHolderID="conteudo" runat="server">
    <h2>Vizualisar Cliente</h2>
    <table>
        <tr>
            <td>Id: </td>
            <td>
                <asp:Label ID="lblId" runat="server" Text=""></asp:Label>
            </td>
        </tr>
        <tr>
            <td>Nome: </td>
            <td>
                <asp:Label ID="lblNome" runat="server" Text=""></asp:Label>
            </td>
        </tr>
        <tr>
            <td>CPF: </td>
            <td>
                <asp:Label ID="lblCpf" runat="server" Text=""></asp:Label>
            </td>
        </tr>
        <tr>
            <td>Telefone: </td>
            <td>
                <asp:Label ID="lblTelefone" runat="server" Text=""></asp:Label>
            </td>
        </tr>
        <tr>
            <td>Email: </td>
            <td>
                <asp:Label ID="lblEmail" runat="server" Text=""></asp:Label>
            </td>
        </tr>
        <tr>
            <td>Endereco: </td>
            <td>
                <asp:Label ID="lblEndereco" runat="server" Text=""></asp:Label>
            </td>
        </tr>
         <tr>
            <td>Renda Familiar: </td>
            <td>
                <asp:Label ID="lblRendaFamiliar" runat="server" Text=""></asp:Label>
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
                <asp:Button ID="btnEditar" runat="server" Text="Editar Cliente" OnClick="btnEditar_Click" />
                <asp:Button ID="btnExcluir" runat="server" Text="Excluir Cliente" OnClick="btnExcluir_Click" />
            </td>
        </tr>
    </table>
     <p>
        <asp:Label ID="lblMenssagen" runat="server" Text="Label"></asp:Label>
    </p>
</asp:Content>
