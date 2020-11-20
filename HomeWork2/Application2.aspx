<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Application2.aspx.cs" Inherits="HomeWork2.Application2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style>
        body{
            text-align:center;
        }
        form{
            border:dotted;
            margin:20px;
            padding:20px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="This Is Application2 " Font-Bold="True" Font-Italic="True" Font-Size="20pt" Font-Strikeout="False" Font-Underline="False"  BorderStyle="Groove" ForeColor="#00CC00"></asp:Label>

            <br />

            <br />
            Name:&nbsp;
            <asp:Label ID="lblname" runat="server" Text="null" ForeColor="Black"></asp:Label>
            <br />
&nbsp;<br />
            E-mail:&nbsp;
            <asp:Label ID="lblEmail" runat="server" Text="null" ForeColor="Black"></asp:Label>
        </div>
    </form>
</body>
</html>
