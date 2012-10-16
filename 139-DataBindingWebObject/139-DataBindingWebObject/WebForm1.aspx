<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="_139_DataBindingWebObject.WebForm1" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="false">
            <Columns>
                <asp:BoundField HeaderText="Título" DataField="Titulo" />
                <asp:BoundField HeaderText="Preço (R$)" DataField="Preco" DataFormatString="{0:n}"
                    ItemStyle-HorizontalAlign="Right" />
            </Columns>
        </asp:GridView>
    </div>
    </form>
</body>
</html>
