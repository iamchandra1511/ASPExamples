<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Calendar.aspx.cs" Inherits="MyPracticeExamples.Calendar" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Calendar ID="cal" runat="server" OnSelectionChanged="cal_SelectionChanged">

            </asp:Calendar>
            Selected Date:<asp:Label ID="label" runat="server"></asp:Label>

        </div>
    </form>
</body>
</html>
