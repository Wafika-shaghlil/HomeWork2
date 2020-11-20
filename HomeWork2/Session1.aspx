<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Session1.aspx.cs" Inherits="HomeWork2.Session1" %>

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
        <div style="font-size: large; font-weight: bold; color: #000080;">
            <asp:Label ID="Label1" runat="server" Text="This Is Session1 " Font-Bold="True" Font-Italic="True" Font-Size="20pt" Font-Strikeout="False" Font-Underline="False" BorderStyle="Groove" ForeColor="#CC0000"></asp:Label>
            <br />
            <br />
            Name :<asp:TextBox ID="txtname" runat="server"></asp:TextBox>
            <br />
            <br />
            E-mail :<asp:TextBox ID="txtemail" runat="server" Width="128px"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="Button1" runat="server" Text="Go To Session2" Width="179px" OnClick="Button1_Click" BorderStyle="Double" Font-Bold="True" Font-Italic="False" Font-Size="16pt" ForeColor="#FF5050" />
        
        </div>
    </form>
</body>
</html>
