<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="demo_3._0.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:GridView ID="GridView1" runat="server" AllowSorting="True" AutoGenerateColumns="False" DataSourceID="SqlDataSource1">
                <Columns>
                    <asp:BoundField DataField="ordered_by" HeaderText="ordered_by" SortExpression="ordered_by" />
                    <asp:BoundField DataField="unloading_location" HeaderText="unloading_location" SortExpression="unloading_location" />
                    <asp:BoundField DataField="type_of_verhicle" HeaderText="type_of_verhicle" SortExpression="type_of_verhicle" />
                    <asp:BoundField DataField="arrival_time" HeaderText="arrival_time" SortExpression="arrival_time" />
                    <asp:BoundField DataField="dur" HeaderText="dur" SortExpression="dur" />
                    <asp:BoundField DataField="supplier" HeaderText="supplier" SortExpression="supplier" />
                    <asp:BoundField DataField="qty" HeaderText="qty" SortExpression="qty" />
                    <asp:BoundField DataField="uom" HeaderText="uom" SortExpression="uom" />
                    <asp:BoundField DataField="material" HeaderText="material" SortExpression="material" />
                    <asp:BoundField DataField="start_time" HeaderText="start_time" SortExpression="start_time" />
                    <asp:BoundField DataField="duration" HeaderText="duration" SortExpression="duration" />
                    <asp:BoundField DataField="transport_typ" HeaderText="transport_typ" SortExpression="transport_typ" />
                    <asp:BoundField DataField="state" HeaderText="state" SortExpression="state" />
                    <asp:BoundField DataField="unloading" HeaderText="unloading" SortExpression="unloading" />
                    <asp:BoundField DataField="status" HeaderText="status" SortExpression="status" />
                </Columns>
            </asp:GridView>
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:inGravureConnectionString %>" SelectCommand="SELECT * FROM [avise_new]"></asp:SqlDataSource>
        </div>
    </form>
</body>
</html>
