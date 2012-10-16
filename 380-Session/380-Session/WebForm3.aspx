<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm3.aspx.cs" Inherits="_380_Session.WebForm3" %>

<%@ Register src="Header.ascx" tagname="Header" tagprefix="uc1" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <uc1:Header ID="Header1" runat="server" />
        <h1>WebForm3</h1>
    <p><asp:Label ID="Label1" runat="server"></asp:Label></p>
        <p>
            <asp:Button ID="Button1" runat="server" onclick="Button1_Click" 
                Text="Remover NOME" />
&nbsp;&nbsp;
            <asp:Button ID="Button2" runat="server" onclick="Button2_Click" 
                Text="Abandonar a sessão" />
        </p>
    </div>
    </form>
</body>
</html>
