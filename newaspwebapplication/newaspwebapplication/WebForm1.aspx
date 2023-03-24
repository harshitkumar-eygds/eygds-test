<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="newaspwebapplication.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:GridView ID="main_gridview" runat="server">
        </asp:GridView>
        <br />
        <br />
        <asp:Button ID="main_display" runat="server" OnClick="main_display_Click" Text="Display" />
&nbsp;&nbsp;&nbsp;
        <asp:Button ID="main_insert" runat="server" Text="Insert" OnClick="main_insert_Click" />
&nbsp;&nbsp;&nbsp;
        <asp:Button ID="main_update" runat="server" Text="Update" OnClick="main_update_Click" />
&nbsp;&nbsp;&nbsp;
        <asp:Button ID="main_delete" runat="server" Text="Delete" OnClick="main_delete_Click" />
        <br />
        <br />
        <div>
        </div>
        <asp:Panel ID="panel_insert" runat="server" Visible="False">
            Student Name :&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="insert_studname_textbox" runat="server"></asp:TextBox>
            <br />
            <br />
            Subject Name :&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="insert_subname_textbox" runat="server"></asp:TextBox>
            <br />
            <br />
            Marks :&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="insert_marks_textbox" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="insert_button" runat="server" Text="Insert" OnClick="insert_button_Click" />
            &nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="insert_display_label" runat="server" Text="Label" Visible="False"></asp:Label>
        </asp:Panel>
        <br />
        <asp:Panel ID="panel_update" runat="server" Visible="False">
            ID :&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="update_id_textbox" runat="server"></asp:TextBox>
            <br />
            <br />
            Student Name :&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="update_studname_textbox" runat="server"></asp:TextBox>
            <br />
            <br />
            Subject Name :&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="update_subname_textbox" runat="server"></asp:TextBox>
            <br />
            <br />
            Marks :&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="update_marks_textbox" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="update_button" runat="server" Text="Update" OnClick="update_button_Click" />
            &nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="update_display_label" runat="server" Text="Label" Visible="False"></asp:Label>
        </asp:Panel>
        <br />
        <asp:Panel ID="panel_delete" runat="server" Visible="False">
            ID :&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="delete_id_textbox" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="delete_button" runat="server" Text="Delete" OnClick="delete_button_Click" />
            &nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="delete_display_label" runat="server" Text="Label" Visible="False"></asp:Label>
        </asp:Panel>
    </form>
</body>
</html>
