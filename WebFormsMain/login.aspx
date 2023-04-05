<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="WebFormsMain.login" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="card">
        <div class="card-header">
            Login
        </div>
        <div class="card-body">
            <div class="form-group">
                <asp:Label ID="Label1" runat="server" Text="Username"></asp:Label>
                <asp:TextBox ID="txtUsername" runat="server" Width="249px"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtUsername" ErrorMessage="Username required"></asp:RequiredFieldValidator>
            </div>
            <div class="form-group">
                <asp:Label ID="Label2" runat="server" Text="Password"></asp:Label>
                <asp:TextBox ID="txtPassword" runat="server" Width="248px"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtPassword" ErrorMessage="Password required"></asp:RequiredFieldValidator>
            </div>
            <div class="form-group">
                <asp:Label ID="Label3" runat="server" Text="Persist Cookie?"></asp:Label>
                <asp:CheckBox ID="chkCookie" runat="server" autopostback="false"/>
            </div>
        </div>
        <div class="card-footer">
            <asp:Button ID="BtnLogin" runat="server" Text="Login" OnClick="BtnLogin_Click1" />
            <asp:Label ID="lblError" runat="server" Text="Label"></asp:Label>
        </div>
    </div>
</asp:Content>
