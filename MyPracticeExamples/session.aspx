<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="session.aspx.cs" Inherits="MyPracticeExamples.session" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
             <table align="center">
                <tr>
                    <td>Enter UserName:</td>
                    <td><asp:TextBox Id="username" runat="server" Width="150px"></asp:TextBox></td></tr>
                    <tr>
                        <td>Enter Password:</td>
                    <td><asp:TextBox Id="password" runat="server" TextMode="Password" Width="150px"></asp:TextBox></td>
                        </tr>
                <tr>
                    <td><asp:Button ID="submit" Text="submit" runat="server" OnClick="submit_Click" /></td>

                </tr>
            </table>
        </div>
    </form>
</body>
</html>
