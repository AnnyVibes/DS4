﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Laboratorio15_4.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="height: 66px">
            Suma de dos Númeross:<br />
            <asp:TextBox ID="txt1" runat="server"></asp:TextBox>
            <asp:Label ID="Label1" runat="server" Text="+"></asp:Label>
            <asp:TextBox ID="txt2" runat="server"></asp:TextBox>
            <asp:Label ID="Label2" runat="server" Text="="></asp:Label>
            <asp:TextBox ID="txt3" runat="server"></asp:TextBox>
        </div>
        <p>
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Suma" />
        </p>
    </form>
</body>
</html>
