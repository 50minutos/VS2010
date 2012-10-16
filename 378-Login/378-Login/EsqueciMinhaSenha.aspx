<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="EsqueciMinhaSenha.aspx.cs" Inherits="_378_Login.EsqueciMinhaSenha" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:PasswordRecovery ID="PasswordRecovery1" runat="server" BackColor="#FFFBD6" 
    BorderColor="#FFDFAD" BorderPadding="4" BorderStyle="Solid" BorderWidth="1px" 
    Font-Names="Verdana" Font-Size="0.8em">
    <SubmitButtonStyle BackColor="White" BorderColor="#CC9966" BorderStyle="Solid" 
        BorderWidth="1px" Font-Names="Verdana" Font-Size="0.8em" ForeColor="#990000" />
    <InstructionTextStyle Font-Italic="True" ForeColor="Black" />
    <SuccessTextStyle Font-Bold="True" ForeColor="#990000" />
    <TextBoxStyle Font-Size="0.8em" />
    <TitleTextStyle BackColor="#990000" Font-Bold="True" Font-Size="0.9em" 
        ForeColor="White" />
</asp:PasswordRecovery>
</asp:Content>
