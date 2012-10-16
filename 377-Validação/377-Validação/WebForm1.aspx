<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="_377_Validação.WebForm1" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <h1>Cadastro de usuário</h1>
    <asp:MultiView ID="MultiView1" runat="server" ActiveViewIndex="0">
        <asp:View ID="View1" runat="server">

            <p>
                Nome:<br />
                <asp:TextBox ID="Nome" runat="server" Width="300px" EnableViewState="False"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                    ControlToValidate="Nome" Display="None" ErrorMessage="Preencha o nome" 
                    SetFocusOnError="True"></asp:RequiredFieldValidator>
            </p>
            <p>
                E-mail:<br />
                <asp:TextBox ID="Email" runat="server" Width="300px"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
                    ControlToValidate="Email" Display="None" ErrorMessage="Preencha o e-mail" 
                    SetFocusOnError="True"></asp:RequiredFieldValidator>
                <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" 
                    ControlToValidate="Email" Display="None" ErrorMessage="Digite um e-mail VÁLIDO" 
                    SetFocusOnError="True" 
                    ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
            </p>
            <p>
                Obs:<br />
                <asp:TextBox ID="Obs" runat="server" Height="150px" TextMode="MultiLine" 
                    Width="300px"></asp:TextBox>
            </p>
            <p>
                Senha:<br />
                <asp:TextBox ID="Senha" runat="server" Width="150px" TextMode="Password"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" 
                    ControlToValidate="Senha" Display="None" 
                    ErrorMessage="Informe a senha que você usará" SetFocusOnError="True"></asp:RequiredFieldValidator>
                <asp:CompareValidator ID="CompareValidator1" runat="server" 
                    ControlToValidate="Senha" Display="None" ErrorMessage="Digite somente números" 
                    Operator="DataTypeCheck" SetFocusOnError="True" Type="Integer"></asp:CompareValidator>
            </p>
            <p>
                Confirme a senha:<br />
                <asp:TextBox ID="ConfirmacaoSenha" runat="server" Width="150px" 
                    TextMode="Password"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" 
                    ControlToValidate="ConfirmacaoSenha" Display="None" 
                    ErrorMessage="Informe a senha que você usará" SetFocusOnError="True"></asp:RequiredFieldValidator>
                <asp:CompareValidator ID="CompareValidator2" runat="server" 
                    ControlToCompare="Senha" ControlToValidate="ConfirmacaoSenha" Display="None" 
                    ErrorMessage="As senhas não batem - digite novamente" SetFocusOnError="True"></asp:CompareValidator>
            </p>
            <p>
                <asp:Button ID="Button1" runat="server" Text="Enviar" onclick="Button1_Click" />
            </p>

            <asp:ValidationSummary ID="ValidationSummary1" runat="server" 
                ShowMessageBox="True" ShowSummary="False" />

        </asp:View>
        <asp:View ID="View2" runat="server">
     
            <h1>
                Sucesso</h1>
            <p>
                Nome:
                <asp:Label ID="Label1" runat="server" Font-Bold="True"></asp:Label>
            </p>
            <p>
                E-mail:
                <asp:Label ID="Label2" runat="server" Font-Bold="True"></asp:Label>
            </p>
            <p>
                Observação:<br />
                <asp:Label ID="Label3" runat="server" Font-Bold="True"></asp:Label>
            </p>
            <p>
                Senha:
                <asp:Label ID="Label4" runat="server" Font-Bold="True"></asp:Label>
            </p>
     
        </asp:View>
    </asp:MultiView>
    </form>
</body>
</html>
