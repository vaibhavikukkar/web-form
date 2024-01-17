<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MyProject.aspx.cs" Inherits="WebApplication3.MyProject" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
<style>
td{
    color:#2f3c7e;
}
</style>
</head>
<body style="background-color:#fbeaeb; height: 292px;">
    <h1 style="color:#2f3c7e;text-align:center;">Student Data</h1>
    <form id="form1" runat="server">
        <div>
            <table align="center">
                <tr>
                    <td>ID</td>
                    <td>
                        <asp:TextBox ID="txtID" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>Name</td>
                    <td>
                        <asp:TextBox ID="txtName" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>Phone</td>
                    <td>
                        <asp:TextBox ID="txtPhone" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>Address</td>
                    <td>
                        <asp:TextBox ID="txtAdd" runat="server"></asp:TextBox></td>
                </tr>
                <br />
                <tr>
                    <td>
                        <asp:Button style="background-color:#2f3c7e;color:#fbeaeb;box-shadow:2px 2px 5px #2f3c7e;" ID="btnInsert" runat="server" Text="Insert" OnClick="btnInsert_Click" /></td>
                    <td>
                        <asp:Button style="background-color:#2f3c7e;color:#fbeaeb;box-shadow:2px 2px 5px #2f3c7e;" ID="btnDelete" runat="server" Text="Delete" OnClick="btnDelete_Click" />    
                        <asp:Button style="background-color:#2f3c7e;color:#fbeaeb;box-shadow:2px 2px 5px #2f3c7e;" ID="btnUpdate" runat="server" Text="Update" OnClick="btnupdate_Click" /></td>
                    <td>
    <asp:Button style="background-color:#2f3c7e;color:#fbeaeb;box-shadow:2px 2px 5px #2f3c7e;" ID="btnFetchAll" runat="server" Text="Fetch All" OnClick="btnfetchall_Click" Width="94px" Height="33px" /></td>
                                    <td>
<asp:Button style="background-color:#2f3c7e;color:#fbeaeb;box-shadow:2px 2px 5px #2f3c7e;" ID="btnGo" runat="server" Text="Go" OnClick="btngo_Click" Width="94px" Height="33px" /></td>
                </tr>
            </table>
        </div>
        <asp:GridView ID="GridView1" runat="server" BorderStyle="Ridge" BorderWidth="3px" HorizontalAlign="Center" style="margin-top: 53px" Width="1197px">
        </asp:GridView>
    </form>
</body>
</html>
