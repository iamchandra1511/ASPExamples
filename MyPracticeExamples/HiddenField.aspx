<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="HiddenField.aspx.cs" Inherits="MyPracticeExamples.HiddenField" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Button ID="button" runat="server" Text="HitCount" OnClick="button_click"/>
            <asp:Button ID="button1" runat="server" Text="OpenNewPage"  PostBackUrl="~/Hidden2.aspx" />
            <asp:HiddenField ID="hidden" Value="0" runat="server" />
        </div>
    </form>
</body>
</html>
