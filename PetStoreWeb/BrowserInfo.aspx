<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="BrowserInfo.aspx.cs" Inherits="PetStoreWeb.BrowserInfo" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Panel ID="WebBrowerInInfoPanel" runat="server">
                <asp:Label ID="lblBrowerInInfo" runat="server" Text="Label"></asp:Label>

            </asp:Panel>

            <asp:Panel ID="WebBrowerOutInfoPanel" runat="server">
                <asp:Label ID="lblBrowerOutInfo" runat="server" Text="Label"></asp:Label>

            </asp:Panel>
        </div>
    </form>
</body>
</html>
