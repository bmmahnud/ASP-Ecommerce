<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="CityNew.aspx.cs" Inherits="ASPDemo.CityNew" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <br />
    <asp:UpdateProgress ID="UpdateProgress1" runat="server">
        <ProgressTemplate>
<img alt="" src="Images/3MA_processingbar.gif" style="width: 145px; height: 15px" />
        </ProgressTemplate>
    </asp:UpdateProgress>
    <br />
    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
        <ContentTemplate>
            <asp:Label ID="lblMessage" runat="server" Font-Bold="True"></asp:Label>
            <br />
            <asp:Label ID="lblName" runat="server" Text="Name"></asp:Label>
            <br />
            <br />
            <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtName" ErrorMessage="Required JS" ForeColor="Red"></asp:RequiredFieldValidator>
            <asp:Label ID="lblEName" runat="server" Font-Bold="True" ForeColor="Red"></asp:Label>
            <br />
            <br />
            <asp:Label ID="lable" runat="server" Text="Country"></asp:Label>
            &nbsp;&nbsp;
            <asp:DropDownList ID="ddlCountry" runat="server" AppendDataBoundItems="True">
                <asp:ListItem Value="0">Select</asp:ListItem>
            </asp:DropDownList>
            &nbsp;<asp:CompareValidator ID="CompareValidator1" runat="server" ControlToValidate="ddlCountry" ErrorMessage="Required" ForeColor="Red" Operator="NotEqual" ValueToCompare="0"></asp:CompareValidator>
            <asp:Label ID="lblECountry" runat="server" Font-Bold="True" ForeColor="Red"></asp:Label>
            <br />
            <br />
            <asp:Button ID="btnSave" runat="server" OnClick="btnSave_Click" Text="Save" />
            &nbsp;
            <asp:Button ID="btnReset" runat="server" OnClick="btnReset_Click" Text="Rerset" />
        </ContentTemplate>
    </asp:UpdatePanel>
    <br />
    </asp:Content>
