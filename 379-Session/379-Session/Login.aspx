<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="_379_Session.WebForm2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>
        Login</h1>
    <p>
        <asp:MultiView ID="MultiView1" runat="server" ActiveViewIndex="0">
            <asp:View ID="View1" runat="server">
                <p>Nome:<br />
                    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                </p>
                <p>
                    Senha:<br />
                    <asp:TextBox ID="TextBox2" runat="server" TextMode="Password"></asp:TextBox>
                </p>
                <p>
                    <asp:Button ID="Button1" runat="server" onclick="Button1_Click" Text="Logar" />
                </p>
            </asp:View>
            <asp:View ID="View2" runat="server">
                <h1>Você está logado.</h1>
            </asp:View>
        </asp:MultiView>
    </p>
</asp:Content>
