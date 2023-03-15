<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm2.aspx.cs" Inherits="WebApplication_EY.WebForm2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            width: 229px;
        }
        .auto-style3 {
            height: 631px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="auto-style3">
            <asp:GridView ID="GridView1" runat="server">
            </asp:GridView>
            <br />
            <br />
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Button" />
            <br />
            <br />
            <table class="auto-style1">
                <tr>
                    <td>
                        <asp:DropDownList ID="DropDownList1" runat="server">
                        </asp:DropDownList>
                    </td>
                    <td>
                        <asp:CheckBoxList ID="CheckBoxList1" runat="server">
                        </asp:CheckBoxList>
                    </td>
                    <td class="auto-style2">
                        <asp:RadioButtonList ID="RadioButtonList1" runat="server">
                        </asp:RadioButtonList>
                    </td>
                </tr>
            </table>
            <br />
            adrorator<br />
            <asp:AdRotator ID="AdRotator1" runat="server" AdvertisementFile="~/XMLFile1.xml" />
            <br />
            <br />
            <br />
            <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
            <asp:Calendar ID="Calendar1" runat="server" BackColor="White" BorderColor="White" BorderWidth="1px" Font-Names="Verdana" Font-Size="9pt" ForeColor="Black" Height="190px" NextPrevFormat="FullMonth" OnSelectionChanged="Calendar1_SelectionChanged" Width="350px">
                <DayHeaderStyle Font-Bold="True" Font-Size="8pt" />
                <NextPrevStyle Font-Bold="True" Font-Size="8pt" ForeColor="#333333" VerticalAlign="Bottom" />
                <OtherMonthDayStyle ForeColor="#999999" />
                <SelectedDayStyle BackColor="#333399" ForeColor="White" />
                <TitleStyle BackColor="White" BorderColor="Black" BorderWidth="4px" Font-Bold="True" Font-Size="12pt" ForeColor="#333399" />
                <TodayDayStyle BackColor="#CCCCCC" />
            </asp:Calendar>
            <br />
            <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>
            </div>
        <p>
            WAP checkin checkout</p>
        <table class="auto-style1">
            <tr>
                <td>Check IN date:</td>
                <td>
                    <asp:TextBox ID="TextBox1" runat="server" AutoPostBack="True" OnTextChanged="TextBox1_TextChanged"></asp:TextBox>
                    <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Display Calender" />
                </td>
                <td>
                    <asp:Calendar ID="Calendar2" runat="server" OnSelectionChanged="Calendar2_SelectionChanged" Visible="False"></asp:Calendar>
                </td>
            </tr>
            <tr>
                <td>Check OUT date:</td>
                <td>
                    <asp:TextBox ID="TextBox2" runat="server" AutoPostBack="True" OnTextChanged="TextBox2_TextChanged"></asp:TextBox>
                    <asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="Display Calender" />
                </td>
                <td>
                    <asp:Calendar ID="Calendar3" runat="server" OnSelectionChanged="Calendar3_SelectionChanged" Visible="False"></asp:Calendar>
                </td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td>
                    <asp:Button ID="Button4" runat="server" OnClick="Button4_Click" Text="Calculate Bill" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <br />
                    <br />
                    <asp:Label ID="Label6" runat="server" Text="Label"></asp:Label>
                </td>
                <td>&nbsp;</td>
            </tr>
        </table>
        <p>
            <asp:Label ID="Label5" runat="server" Text="Label"></asp:Label>
        </p>
    <p>
        <asp:GridView ID="GridView2" runat="server">
        </asp:GridView>
        </p>
        <asp:Button ID="displayall" runat="server" OnClick="displayall_Click" Text="Display all" />
        <br />
        <br />
        <asp:Button ID="ins_panel_button" runat="server" OnClick="ins_panel_Click" Text="Insert" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="del_panel_button" runat="server" OnClick="del_panel_button_Click" Text="Delete" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="upd_panel_button" runat="server" OnClick="upd_panel_button_Click" Text="Update" />
        <br />
        <br />
        <br />
&nbsp;<asp:Panel ID="inspanel" runat="server" Visible="False">
            Enter Student ID :
            <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
            <br />
            <br />
            Enter Subject Name :
            <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
            <br />
            <br />
            Enter Marks :
            <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="ins_data_button" runat="server" OnClick="ins_data_button_Click" Text="Insert Data" />
            <asp:Button ID="Button5" runat="server" OnClick="Button5_Click" Text="Insert Hard Coded" />
            <br />
            <asp:Label ID="Label7" runat="server" Text="Label" Visible="False"></asp:Label>
        </asp:Panel>
        <br />
        <br />
        <asp:Panel ID="delpanel" runat="server" Visible="False">
            Enter Student ID to delete :
            <asp:TextBox ID="TextBox6" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="del_data_button" runat="server" Text="Delete Data" OnClick="del_data_button_Click" />
            <asp:Button ID="Button6" runat="server" OnClick="Button6_Click" Text="Delete Hard Coded" />
            <br />
            <asp:Label ID="Label8" runat="server" Text="Label" Visible="False"></asp:Label>
        </asp:Panel>
        <br />
        <br />
        <asp:Panel ID="updpanel" runat="server" Visible="False">
            Enter Student ID to update :
            <asp:TextBox ID="TextBox7" runat="server"></asp:TextBox>
            <br />
            <br />
            Enter Subject Name to update :
            <asp:TextBox ID="TextBox8" runat="server"></asp:TextBox>
            <br />
            <br />
            Enter updated marks :
            <asp:TextBox ID="TextBox9" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="upd_data_button" runat="server" Text="Update Data" OnClick="upd_data_button_Click" />
            <asp:Button ID="Button7" runat="server" OnClick="Button7_Click" Text="Upadate Hard Coded" />
            <br />
            <asp:Label ID="Label9" runat="server" Text="Label" Visible="False"></asp:Label>
        </asp:Panel>
        <p>
            &nbsp;</p>
        <p>
            <asp:Button ID="sql_reader_button" runat="server" OnClick="sql_reader_button_Click" Text="SQL Reader" />
        </p>
        <p>
            <asp:Label ID="sqlrdr_label" runat="server" Text="Label" Visible="False"></asp:Label>
        </p>
    </form>
    </body>
</html>
