<%@ Page Title="Busqueda" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Busqueda.aspx.cs" Inherits="WebApplication.About" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h4> &nbsp;</h4>
    <div>

        <table style="width:68%; height: 55px;">
            <tr>
                <td style="width: 470px">
        <asp:Button ID="Buscar" runat="server" Text="Buscar" OnClick="Buscar_Click" BorderColor="White" BorderStyle="Solid" />
        <asp:TextBox ID="txtEmail" runat="server" OnTextChanged="txtEmail_TextChanged"></asp:TextBox>
                </td>
                <td style="width: 756px">
                    &nbsp;</td>
            </tr>
            <tr>
                <td style="width: 470px">&nbsp;</td>
                <td style="width: 756px">&nbsp;</td>
            </tr>
            <tr>
                <td style="text-align:right; width: 470px">Nombre:</td>
                <td style="width: 756px">
                    <asp:TextBox ID="txtNombre" runat="server" Width="221px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td style="text-align:right; width: 470px">Apellidos:</td>
                <td style="width: 756px">
                    <asp:TextBox ID="txtApellidos" runat="server" Width="228px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td style="text-align:right; width: 470px">Fecha de Nacimiento:</td>
                <td style="width: 756px">
                    <asp:TextBox ID="txtFechaNac" runat="server" Width="222px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td style="text-align:right; width: 470px">&nbsp;</td>
                <td style="width: 756px">&nbsp;</td>
            </tr>
        </table>

   </div>
    <p></p>
</asp:Content>
