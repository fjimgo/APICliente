<%@ Page Title="About" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Consulta.aspx.cs" Inherits="WebApplication.About" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h4>
        <asp:Button ID="Button1" runat="server" Text="Buscar" />
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
    </h4>
    <p>Consumiendo API por email.</p>
</asp:Content>
