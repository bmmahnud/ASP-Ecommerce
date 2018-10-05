<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="CountryNew.aspx.cs" Inherits="ASPDemo.CountryNew" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <asp:UpdateProgress ID="UpdateProgress1" runat="server">
        <ProgressTemplate>
<img alt="" src="Images/special.gif" style="width: 280px; height: 13px" />
        </ProgressTemplate>
    </asp:UpdateProgress>
    <br />
    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
        <ContentTemplate>
            <asp:Label ID="lblMessage" runat="server"></asp:Label>
            <br />
            <asp:Label ID="lblName" runat="server" Text="Name"></asp:Label>
            <br />
            <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
            &nbsp;<asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtName" ErrorMessage="RequiredFieldValidator">Required JS</asp:RequiredFieldValidator>
            <asp:Label ID="lblEName" runat="server" Font-Bold="True" ForeColor="Red"></asp:Label>
            <br />
            <br />
            <asp:Button ID="btnSave" runat="server" OnClick="btnSave_Click" Text="Save" />
        </ContentTemplate>
    </asp:UpdatePanel>
    <br />
    </asp:Content>
