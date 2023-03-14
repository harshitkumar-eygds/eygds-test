<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebApplication_EY.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
    </style>
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
            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataSourceID="SqlDataSource1ey">
            </asp:GridView>
            <asp:SqlDataSource ID="SqlDataSource1ey" runat="server" ConnectionString="<%$ ConnectionStrings:EYdatabaseConnectionString %>" SelectCommand="SELECT * FROM [student2]"></asp:SqlDataSource>
            <br />
            WAP to show student with marks&gt;70<br />
            <asp:GridView ID="GridView2" runat="server" AllowSorting="True" AutoGenerateColumns="False" DataSourceID="SqlDataSource2ey">
                <Columns>
                    <asp:CommandField ShowSelectButton="True" />
                    <asp:BoundField DataField="studid" HeaderText="studid" SortExpression="studid" />
                    <asp:BoundField DataField="sub_name" HeaderText="sub_name" SortExpression="sub_name" />
                    <asp:BoundField DataField="marks" HeaderText="marks" SortExpression="marks" />
                </Columns>
            </asp:GridView>
            <asp:SqlDataSource ID="SqlDataSource2ey" runat="server" ConnectionString="<%$ ConnectionStrings:EYdatabaseConnectionString %>" SelectCommand="SELECT * FROM [subject2] WHERE ([marks] &gt;= @marks)">
                <SelectParameters>
                    <asp:Parameter DefaultValue="70" Name="marks" Type="Int32" />
                </SelectParameters>
            </asp:SqlDataSource>
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <table class="auto-style1">
                <tr>
                    <td>DataBound control</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td>
            <asp:ListBox ID="ListBox2" runat="server" DataSourceID="SqlDataSource3bound" DataTextField="name" DataValueField="studid"></asp:ListBox>
            <asp:SqlDataSource ID="SqlDataSource3bound" runat="server" ConnectionString="<%$ ConnectionStrings:EYdatabaseConnectionString %>" SelectCommand="SELECT * FROM [student2]"></asp:SqlDataSource>
                    </td>
                    <td>
            <asp:DropDownList ID="DropDownList2" runat="server" DataSourceID="SqlDataSource3bound" DataTextField="name" DataValueField="studid">
            </asp:DropDownList>
                    </td>
                    <td>
            <asp:CheckBoxList ID="CheckBoxList1" runat="server" DataSourceID="SqlDataSource3bound" DataTextField="city" DataValueField="studid">
            </asp:CheckBoxList>
                    </td>
                    <td>
            <asp:RadioButtonList ID="RadioButtonList1" runat="server" DataSourceID="SqlDataSource2ey" DataTextField="sub_name" DataValueField="studid">
            </asp:RadioButtonList>
                    </td>
                </tr>
                <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
            </table>
            <br />
            <br />
            <br />
            <br />
        </div>
    </form>
</body>
</html>
