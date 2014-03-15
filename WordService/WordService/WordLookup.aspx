<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="WordLookup.aspx.vb" Inherits="WordService.WordLookup" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Label ID="lblVersion" runat="server"></asp:Label>
        <br /><hr />
        <asp:TextBox ID="txtWord" runat="server"></asp:TextBox>
        <br />
        <asp:Button ID="btnGetDef" runat="server" Text="Get Defintion" />
        <br />
        <asp:Label ID="lblDefinition" Text="Definition will be here" runat="server"></asp:Label>
    </div>
    </form>
</body>
</html>
