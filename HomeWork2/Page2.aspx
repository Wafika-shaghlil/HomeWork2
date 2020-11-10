<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Page2.aspx.cs" Inherits="HomeWork2.Page2" %>

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
            <asp:CheckBox ID="CheckBox1" runat="server" Text="Wafika Shaghlil" ForeColor="#CC3300" />
            &nbsp;&nbsp;&nbsp;
            <asp:Button ID="Button1" runat="server" Text="Check" OnClick="Button1_Click" BackColor="#999966" BorderColor="#336600" ForeColor="White" Height="48px" Width="111px" />
        </div>
    </form>
</body>
</html>
