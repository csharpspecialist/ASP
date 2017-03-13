<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PageLifeCycleWithControls.aspx.cs" Inherits="PageLifeCycle.PageLifeCycleWithControls" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Button ID="btnSubmit" runat="server" Text="Submit" OnClick="btnSubmit_Click" />
        <asp:Label ID="lblName" runat="server" Text=""></asp:Label>
    </div>
    </form>
</body>
</html>
