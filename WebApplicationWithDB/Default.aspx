<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebApplicationWithDB.Default" %>
<!DOCTYPE html>
<head runat="server">
    <title></title>
</head>
<html xmlns="http://www.w3.org/1999/xhtml">
<body><br />

    <form id="form1" runat="server">
        <asp:DropDownList ID="DropDownListParti" runat="server">
            <asp:ListItem Value="1">H</asp:ListItem>
            <asp:ListItem Value="2">V</asp:ListItem>
            <asp:ListItem Value="3">Pp</asp:ListItem>
            <asp:ListItem></asp:ListItem>
            <asp:ListItem></asp:ListItem>
        </asp:DropDownList>
        <asp:Button ID="ButtonStem" runat="server" Text="stem" OnClick="ButtonStem_Click" />
        <br />
        <asp:Button ID="ButtonTestValg" runat="server" Text="Valg" OnClick="ButtonTestValg_Click" />
        <br />
        <br />
        <br />
        <asp:Label ID="LabelUserMsg" runat="server" Text="Label" Visible="false"></asp:Label>
    <br /><br />

        <asp:GridView ID="GridView1" runat="server" CssClass=""></asp:GridView>
        <style>

table {
  border-collapse: collapse;
  width: 100%;
}

th, td {
  text-align: left;
  padding: 8px;
}

tr:nth-child(even){background-color: #f2f2f2}

th {
  background-color: #04AA6D;
  color: white;
}
</style>

    </form>
</body>
</html>
