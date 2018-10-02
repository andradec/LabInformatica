<%@ Page Title="" Language="C#" MasterPageFile="~/Index.Master" AutoEventWireup="true" CodeBehind="Cadastro2.aspx.cs" Inherits="LaboratorioInformatica.Cadastro2" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder" runat="server">
    <form id="form1" runat="server">

        <asp:Label ID="lblnome" runat="server" Text="Nome"></asp:Label>
        <asp:TextBox ID="txtnome" runat="server" Width="250px" MaxLength="3"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="lblQtdComputadores" runat="server" Text="Qtd. Computadores"></asp:Label>
        <asp:TextBox ID="txtQtdComputadores" runat="server" Width="250px"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="lblQtdAlunos" runat="server" Text="Qtd. Alunos"></asp:Label>
        <asp:TextBox ID="txtQtdAlunos" runat="server" Width="250px"></asp:TextBox>



        <br />
        <br />
        <asp:Label ID="lblsoftware1" runat="server" Text="Software 1"></asp:Label>
        &nbsp;
            <asp:TextBox ID="txtsoftware1" runat="server" Width="250px" required="true"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="lblsoftware2" runat="server" Text="Software 2"></asp:Label>
        &nbsp;
            <asp:TextBox ID="txtsoftware2" runat="server" Width="250px" required="true"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="lblsoftware3" runat="server" Text="Software 3"></asp:Label>
        &nbsp;
            <asp:TextBox ID="txtsoftware3" runat="server" Width="250px" required="true"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="lblSO" runat="server" Text="Sistema Operacional"></asp:Label>
        <asp:TextBox ID="txtSO" runat="server" Width="250px"></asp:TextBox>

        <br />
        <br />
        <asp:Label ID="lblProjetor" runat="server" Text="Projetor"></asp:Label>
        <asp:CheckBox ID="chbox" runat="server" />
        <br />
        <br />
        &nbsp;<asp:Button class="btn btn-primary" ID="Button1" runat="server" OnClick="Button1_Click" Text="Enviar" />
        <br />
        <br />
        <asp:Label ID="MsgErro" runat="server" Text=""></asp:Label>


    </form>
</asp:Content>

