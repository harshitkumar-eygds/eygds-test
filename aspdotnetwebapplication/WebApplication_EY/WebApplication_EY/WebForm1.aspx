<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebApplication_EY.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="height: 999px">
            Calculator<br />
            <br />
            <br />
            Enter 1st number:&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <br />
            <br />
            <br />
            Enter 2nd number:&nbsp;
            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
            <br />
            <br />
            <br />
            <asp:Button ID="Button1" runat="server" Text="Submit" OnClick="Button1_Click" />
            <br />
            <br />
            <br />
            <asp:Image ID="Image1" runat="server" Height="109px" ImageUrl="~/Images/download.jpg" Width="293px" />
            <br />
            <br />
            <br />
            <asp:ListBox ID="ListBox1" runat="server">
                <asp:ListItem>Delhi</asp:ListItem>
                <asp:ListItem>Delhi2</asp:ListItem>
                <asp:ListItem>Chennai</asp:ListItem>
                <asp:ListItem>Chennai2</asp:ListItem>
            </asp:ListBox>
            <asp:DropDownList ID="DropDownList1" runat="server">
                <asp:ListItem>DElhi</asp:ListItem>
                <asp:ListItem>DElhi2</asp:ListItem>
                <asp:ListItem>DElhi3</asp:ListItem>
                <asp:ListItem>DElhi4</asp:ListItem>
            </asp:DropDownList>
            <br />
            <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Select city" />
            <br />
            <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
            <br />
            <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>
            <br />
            <br />
            <br />
            <asp:ImageButton ID="ImageButton1" runat="server" ImageUrl="~/Images/download.jpg" PostBackUrl="https://www.google.com" />
            <br />
            <br />
            <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="https://www.google.com/">HyperLink</asp:HyperLink>
            <br />
            <br />
            <br />
            database<br />
            <asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="database button" />
            <br />
            <br />
            <br />
            <br />
        </div>
    </form>
</body>
</html>
