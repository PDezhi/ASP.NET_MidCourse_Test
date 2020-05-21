<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DogsList.aspx.cs" Inherits="PetStoreWeb.DogsList" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:GridView ID="PetGridView" runat="server" AllowPaging="True" AllowSorting="True" AutoGenerateColumns="False" DataKeyNames="Id" DataSourceID="SqlDataSourcePets">
                <Columns>
                    <asp:BoundField DataField="Id" HeaderText="Id" InsertVisible="False" ReadOnly="True" SortExpression="Id" />
                    <asp:BoundField DataField="Name" HeaderText="Name" SortExpression="Name" />
                    <asp:BoundField DataField="Gender" HeaderText="Gender" SortExpression="Gender" />
                    <asp:BoundField DataField="Color" HeaderText="Color" SortExpression="Color" />
                    <asp:BoundField DataField="Age" HeaderText="Age" SortExpression="Age" />
                </Columns>
            </asp:GridView>
            <asp:SqlDataSource ID="SqlDataSourcePets" runat="server" ConnectionString="<%$ ConnectionStrings:PetStoreDBConnectionString %>" SelectCommand="SELECT [Id], [Name], [Gender], [Color], [Age] FROM [Dogs]"></asp:SqlDataSource>
        </div>
    </form>
</body>
</html>
