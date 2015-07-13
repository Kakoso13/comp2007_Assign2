<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Edit.aspx.cs" Inherits="Loja.web.Clientes.Edit" %>
<asp:Content ID="formEdit" ContentPlaceHolderID="conteudo" runat="server">
    <h2>Editar Cliente</h2>
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
                <asp:TextBox ID="txtNome" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>CPF: </td>
            <td>
                <asp:TextBox ID="txtCpf" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>Telefone: </td>
            <td>
                <asp:TextBox ID="txtTelefone" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>Email: </td>
            <td>
                <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>Endereco: </td>
            <td>
                <asp:TextBox ID="txtEndereco" runat="server"></asp:TextBox>
            </td>
        </tr>
         <tr>
            <td>Renda Familiar: </td>
            <td>
                <asp:TextBox ID="txtRendaFamiliar" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td></td>
            <td></td>
        </tr>
        <tr>
            <td></td>
            <td>
                <asp:Button ID="btnSalvar" runat="server" Text="Salvar Cliente" OnClick="btnSalvar_Click" />
                <asp:Button ID="btnNovo" runat="server" Text="Novo Cliente" OnClick="btnNovo_Click" />
            </td>
        </tr>
    </table>
    <p>
        <asp:Label ID="lblMenssagen" runat="server" Text="Label"></asp:Label>
    </p>
</asp:Content>
