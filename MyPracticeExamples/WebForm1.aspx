<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="MyPracticeExamples.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:TextBox id="TextBox1" runat="server"/>
            <asp:Button ID="Button1" runat="server" Text="Button1" OnClick="Button1_Click"/>
            <br />
            <input type="text" name="TextBox2" />
            <input type="button" value="ClickMe" />
        </div>
    </form>
</body>
</html>
