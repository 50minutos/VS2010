<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="_145_CrossJoin.WebForm1" %>

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
                <asp:BoundField HeaderText="Homem" DataField="NomeHomem" ItemStyle-Width="100" />
                <asp:BoundField HeaderText="Mulher" DataField="NomeMulher" ItemStyle-Width="100" />
                <asp:CheckBoxField HeaderText="Namorados" DataField="Namora" ItemStyle-HorizontalAlign="Center" />
            </Columns>
        </asp:GridView>
    </div>
    </form>
</body>
</html>
