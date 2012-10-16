<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="_380_Session.WebForm1"
    Trace="true" %>

<%@ Register Src="Header.ascx" TagName="Header" TagPrefix="uc1" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <uc1:Header ID="Header1" runat="server" />
        <h1>
            WebForm1</h1>
        <p>
            Session ID:
            <asp:Label ID="Label1" runat="server"></asp:Label>
        </p>
        <p>
            Nome:
            <br />
            <asp:TextBox ID="TextBox1" runat="server" Width="494px"></asp:TextBox>
        </p>
        <p>
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Enviar" />
            &nbsp;&nbsp;
            <asp:Button ID="Button2" runat="server" Text="Faz nada" />
        </p>
    </div>
    </form>
</body>
</html>
