<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SignUp.aspx.cs" Inherits="ICS321.SignUp" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>

    <style type="text/css">
        .auto-style1 {
            width: 92%;
        }

        .auto-style2 {
            width: 122px;
        }
    </style>

</head>
<body>
    <form id="form1" runat="server">
        <div>

            <table cellpadding="2" class="auto-style1">
                <tr>
                    <td class="auto-style2">
                        <asp:Label ID="Label1" runat="server" Text="User Name"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="txtUserName" runat="server" Width="168px"></asp:TextBox>
                    </td>

                </tr>

                <tr>
                    <td class="auto-style2">
                        <asp:Label ID="Label2" runat="server" Text="Password"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="txtPassword" TextMode="Password" runat="server" Width="168px"></asp:TextBox>
                    </td>

                    <tr>
                        <td class="auto-style2">
                            <asp:Label ID="Label3" runat="server" Text="Phone Number"></asp:Label>
                        </td>
                        <td>
                            <asp:TextBox ID="txtPhone" runat="server" Width="168px"></asp:TextBox>
                        </td>

                    </tr>



                    <tr>
                        <td class="auto-style2">
                            <asp:Label ID="Label5" runat="server" Text="Use as"></asp:Label>
                        </td>
                        <td>

                            <asp:RadioButton ID="RadioButton1" runat="server" Text="Customer"  GroupName="k" />
                            <asp:RadioButton ID="RadioButton2" runat="server" Text="Employee" GroupName="k" />
                        
                        </td>
                    </tr>

                <tr>
                    <td class="auto-style2">
                        <asp:Label ID="lblmsg" runat="server"></asp:Label>
                    </td>
                    <td>
                        <asp:Button ID="Regiester" runat="server" Text="Regiester" Width="90px" OnClick="Regiester_Click" />
                        <%--                        <asp:Button ID="Login" runat="server" Text="Login" Width="90px" OnClick="Login_Click" /> --%>
                    </td>

                </tr>
            </table>


        </div>
        <asp:Label ID="lblmsg1" runat="server" Text=""></asp:Label>
    </form>
</body>
</html>
