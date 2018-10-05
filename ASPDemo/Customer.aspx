<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Customer.aspx.cs" Inherits="ASPDemo.Customer" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <br />
    <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="CustomerNew.aspx">New Customer</asp:HyperLink>
    <br />
    <br />
    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" BackColor="White" BorderColor="#DEDFDE" BorderStyle="None" BorderWidth="1px" CellPadding="4" ForeColor="Black" GridLines="Vertical" Width="555px">
        <AlternatingRowStyle BackColor="White" />
        <Columns>
            <asp:BoundField DataField="id" HeaderText="ID" Visible="False" />
            <asp:BoundField DataField="name" HeaderText="Name" />
            <asp:BoundField DataField="contact" HeaderText="Contact" />
            <asp:BoundField DataField="email" HeaderText="Email" />
            <asp:BoundField DataField="gender" HeaderText="Gender" />
            <asp:BoundField DataField="joinDate" HeaderText="Join Date" />
            <asp:BoundField DataField="address" HeaderText="Address" />
            <asp:BoundField DataField="cityId" HeaderText="City" />
        </Columns>
        <FooterStyle BackColor="#CCCC99" />
        <HeaderStyle BackColor="#6B696B" Font-Bold="True" ForeColor="White" />
        <PagerStyle BackColor="#F7F7DE" ForeColor="Black" HorizontalAlign="Right" />
        <RowStyle BackColor="#F7F7DE" />
        <SelectedRowStyle BackColor="#CE5D5A" Font-Bold="True" ForeColor="White" />
        <SortedAscendingCellStyle BackColor="#FBFBF2" />
        <SortedAscendingHeaderStyle BackColor="#848384" />
        <SortedDescendingCellStyle BackColor="#EAEAD3" />
        <SortedDescendingHeaderStyle BackColor="#575357" />
    </asp:GridView>
</asp:Content>
