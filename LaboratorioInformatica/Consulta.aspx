<%@ Page Title="" Language="C#" MasterPageFile="~/Index.Master" AutoEventWireup="true" CodeBehind="Consulta.aspx.cs" Inherits="LaboratorioInformatica.cadastro" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder" runat="server">
    <form id="FormConsulta" runat="server">
        <br />
        <asp:Button CssClass="btn btn-primary" ID="btnNovo" runat="server" Text="Novo" OnClick="btnNovo_Click" />
        <br />
        <br />
        <asp:GridView ID="GdvlabInformatica" runat="server">
        </asp:GridView>
        <br />
        <br />
        &nbsp;</form>
</asp:Content>


