<%@ Page Title="" Language="C#" MasterPageFile="~/View/Main.Master" AutoEventWireup="true" CodeBehind="ChangePassword.aspx.cs" Inherits="Project.View.ChangePasssword" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>Change Password</h1>
        <asp:Label ID="Label2" runat="server" Text="Enter old password"></asp:Label>
    <br />
    <asp:TextBox ID="oldPassword" runat="server"></asp:TextBox>
    <br />
    <asp:Label ID="Label1" runat="server" Text="Enter new password"></asp:Label>
    <br />
    <asp:TextBox ID="newPassword" runat="server"></asp:TextBox>
    <br />
        <asp:Label ID="Label3" runat="server" Text="Confirm new password"></asp:Label>
    <br />
    <asp:TextBox ID="confirmPassword" runat="server"></asp:TextBox>
    <br />
    <asp:Button ID="submitBtn" runat="server" Text="Button" OnClick="submitBtn_Click"/>
    <br />
    <asp:Label ID="errorLabel" runat="server" Text="Label"></asp:Label>
</asp:Content>
