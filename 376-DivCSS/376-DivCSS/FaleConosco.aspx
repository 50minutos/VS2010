<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="FaleConosco.aspx.cs" Inherits="_376_DivCSS.FaleConosco" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>
        Fale conosco</h1>
    <p>
        Digite o seu nome:<br />
        <asp:TextBox ID="TextBox1" runat="server" Width="300px"></asp:TextBox>
    </p>
    <p>
        Digite o seu e-mail:<br />
        <asp:TextBox ID="TextBox2" runat="server" Width="300px"></asp:TextBox>
    </p>
    <p>
        Assunto:<br />
        <asp:TextBox ID="TextBox3" runat="server" Width="300px"></asp:TextBox>
    </p>
    <p>
        Mensagem:<br />
        <asp:TextBox ID="TextBox4" runat="server" Height="100px" TextMode="MultiLine" 
            Width="300px"></asp:TextBox>
    </p>
    <p>
        <asp:Button ID="Button1" runat="server" onclick="Button1_Click" Text="Enviar" />
    </p>
</asp:Content>
