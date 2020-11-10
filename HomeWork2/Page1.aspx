<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Page1.aspx.cs" Inherits="HomeWork2.Page1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style>
         body{
            background-color:burlywood;
            font-size:xx-large;
            text-align:center;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        <asp:TextBox ID="TextBox1" runat="server" Height="48px" Width="211px"></asp:TextBox>
        &nbsp;&nbsp;
        <asp:Button ID="Button1" runat="server" Text="Move" OnClick="Button1_Click"  BackColor="#999966" BorderColor="#336600" ForeColor="White" Height="48px" Width="111px" />
        &nbsp;
        <asp:TextBox ID="TextBox2" runat="server" Height="48px" Width="211px"></asp:TextBox>

        </div>
    </form>
</body>
</html>
