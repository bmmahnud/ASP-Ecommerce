<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="CustomerNew.aspx.cs" Inherits="ASPDemo.CustomerNew" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <p>
        &nbsp;</p>
    <asp:UpdateProgress ID="UpdateProgress1" runat="server">
        <ProgressTemplate>
<img alt="" src="Images/3MA_processingbar.gif" style="width: 145px; height: 15px" />
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
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtName" ErrorMessage="RequiredFieldValidator" Font-Bold="True" ForeColor="Red">Required JS</asp:RequiredFieldValidator>
            <asp:Label ID="lblEName" runat="server" Font-Bold="True" ForeColor="Red"></asp:Label>
            <br />
            <br />
            <asp:Label ID="Label1" runat="server" Text="Contact"></asp:Label>
            <br />
            <asp:TextBox ID="txtContact" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtName" ErrorMessage="RequiredFieldValidator" Font-Bold="True" ForeColor="Red">Required JS</asp:RequiredFieldValidator>
            <asp:Label ID="lblEContact" runat="server" Font-Bold="True" ForeColor="Red"></asp:Label>
            <br />
            <asp:Label ID="Label2" runat="server" Text="Email"></asp:Label>
            <br />
            <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="txtName" ErrorMessage="RequiredFieldValidator" Font-Bold="True" ForeColor="Red">Required JS</asp:RequiredFieldValidator>
            <asp:Label ID="lblEEmail" runat="server" Font-Bold="True" ForeColor="Red"></asp:Label>
            <br />
            <asp:Label ID="Label3" runat="server" Text="Gender"></asp:Label>
            <br />
            <asp:DropDownList ID="ddlGender" runat="server">
            </asp:DropDownList>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="txtName" ErrorMessage="RequiredFieldValidator" Font-Bold="True" ForeColor="Red">Required JS</asp:RequiredFieldValidator>
            <asp:Label ID="lblEGender" runat="server" Font-Bold="True" ForeColor="Red"></asp:Label>
            <br />
            <br />
            <asp:Label ID="Label6" runat="server" Text="Address"></asp:Label>
            <br />
            <asp:TextBox ID="txtAddress" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" ControlToValidate="txtName" ErrorMessage="RequiredFieldValidator" Font-Bold="True" ForeColor="Red">Required JS</asp:RequiredFieldValidator>
            <asp:Label ID="lblEAddress" runat="server" Font-Bold="True" ForeColor="Red"></asp:Label>
            <br />
            <br />
            <asp:Label ID="Label5" runat="server" Text="City"></asp:Label>
            <br />
            <asp:DropDownList ID="ddlCity" runat="server">
                <asp:ListItem>Male</asp:ListItem>
                <asp:ListItem>Femail</asp:ListItem>
            </asp:DropDownList>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ControlToValidate="txtName" ErrorMessage="RequiredFieldValidator" Font-Bold="True" ForeColor="Red">Required JS</asp:RequiredFieldValidator>
            <asp:Label ID="lblECity" runat="server" Font-Bold="True" ForeColor="Red"></asp:Label>
            <br />
            <br />
            <asp:Button ID="btnSave" runat="server" OnClick="btnSave_Click" Text="Save" />
            &nbsp;<asp:Button ID="btnReset" runat="server" OnClick="btnReset_Click" Text="Rerset" />
            <br />
        </ContentTemplate>
    </asp:UpdatePanel>
</asp:Content>
