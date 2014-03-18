<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="SimpleConsumer.aspx.vb" Inherits="RESTConsumer.SimpleConsumer" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Label ID="Label1" Text="Enter something to send to the service: " runat="server"></asp:Label>
        <asp:TextBox ID="txtParm" runat="server"></asp:TextBox>
        <br />
        <asp:Button ID="btnCallService" runat="server" Text="Call Service" />
        <br /><hr />
        <asp:Label ID="Label2" Text="The XML service says:" runat="server"></asp:Label> <br />
        <asp:Label ID="lblXMLResponse" Text="" runat="server"></asp:Label>
         <br /><hr />
        <asp:Label ID="Label3" Text="The JSON service says:" runat="server"></asp:Label> <br />
        <asp:Label ID="lblJSONResponse" Text="" runat="server"></asp:Label>
    </div>
    </form>
</body>
</html>
