<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Demo_4._0.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
<script type="text/javascript">
function PrintGridData() {
var prtGrid = document.getElementById('<%=GridView1.ClientID %>');
prtGrid.border = 0;
var prtwin = window.open('', 'PrintGridViewData', 'left=100,top=100,width=1000,height=1000,tollbar=0,scrollbars=1,status=0,resizable=1');
prtwin.document.write(prtGrid.outerHTML);
prtwin.document.close();
prtwin.focus();
prtwin.print();
prtwin.close();
}
</script>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Avisierung</h1>
        </div>
        <asp:GridView ID="GridView1" runat="server" AllowSorting="True" AutoGenerateColumns="False" DataSourceID ="SqlDataSource1" BackColor="White" BorderColor="#999999" BorderStyle="None" BorderWidth="1px" CellPadding="3" GridLines="Vertical" Height="576px" Width="1343px">
            <AlternatingRowStyle BackColor="#DCDCDC" />
            <Columns>
                <asp:BoundField DataField="material" HeaderText="material" SortExpression="material" />
                <asp:BoundField DataField="supplier" HeaderText="supplier" SortExpression="supplier" />
                <asp:BoundField DataField="qty" HeaderText="qty" SortExpression="qty" />
                <asp:BoundField DataField="uom" HeaderText="uom" SortExpression="uom" />
                <asp:BoundField DataField="unloading" HeaderText="unloading" SortExpression="unloading" />
                <asp:BoundField DataField="duration" HeaderText="duration" SortExpression="duration" />
                <asp:BoundField DataField="transport_typ" HeaderText="transport_typ" SortExpression="transport_typ" />
                <asp:BoundField DataField="ordered_by" HeaderText="ordered_by" SortExpression="ordered_by" />
                <asp:BoundField DataField="unloading_location" HeaderText="unloading_location" SortExpression="unloading_location" />
                <asp:BoundField DataField="type_of_verhicle" HeaderText="type_of_verhicle" SortExpression="type_of_verhicle" />
                <asp:BoundField DataField="status" HeaderText="status" SortExpression="status" />
                <asp:BoundField DataField="start_time" HeaderText="start_time" SortExpression="start_time" />
                
                <asp:ButtonField ButtonType="Button" CommandName="Select" Text="Print" />
                
            </Columns>
            <FooterStyle BackColor="#CCCCCC" ForeColor="Black" />
            <HeaderStyle BackColor="#000084" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#999999" ForeColor="Black" HorizontalAlign="Center" />
            <RowStyle BackColor="#EEEEEE" ForeColor="Black" />
            <SelectedRowStyle BackColor="#008A8C" Font-Bold="True" ForeColor="White" />
            <SortedAscendingCellStyle BackColor="#F1F1F1" />
            <SortedAscendingHeaderStyle BackColor="#0000A9" />
            <SortedDescendingCellStyle BackColor="#CAC9C9" />
            <SortedDescendingHeaderStyle BackColor="#000065" />
        </asp:GridView>
        <input type="button" id="btnPrint" value="Print" onclick="PrintGridData()" />

        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:inGravureConnectionString %>" SelectCommand="SELECT * FROM [po_avise_view]"></asp:SqlDataSource>
    </form>
</body>
</html>
