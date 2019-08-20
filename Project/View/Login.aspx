<%@ Page Title="" Language="C#" MasterPageFile="~/View/Main.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Project.View.Login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Table runat="server">
        <asp:TableRow>
            <asp:TableCell>
                <asp:Label Text="Email" runat="server"></asp:Label>
            </asp:TableCell>
            <asp:TableCell>
                <asp:TextBox ID="Txt_Email" TextMode="Email" runat="server"></asp:TextBox>
            </asp:TableCell>
        </asp:TableRow>

        <asp:TableRow>
            <asp:TableCell>
                <asp:Label Text="Password" runat="server"></asp:Label>
            </asp:TableCell>
            <asp:TableCell>
                <asp:TextBox ID="Txt_Password" TextMode="Password" runat="server"></asp:TextBox>
            </asp:TableCell>
        </asp:TableRow>

        <asp:TableRow>
            <asp:TableCell>
                <asp:Label Text="Remember Me" runat="server"></asp:Label>                
            </asp:TableCell>
            <asp:TableCell>
                <asp:CheckBox ID="Check_RememberMe" runat="server" />
            </asp:TableCell>
        </asp:TableRow>

        <asp:TableRow>
            <asp:TableCell>
                <asp:Button ID="Btn_Login" Text="Login" runat="server" OnClick="Btn_Login_Click" />
            </asp:TableCell>
        </asp:TableRow>

          <asp:TableRow>
            <asp:TableCell>
                <asp:Label ID="Label_Error" Text="" runat="server"></asp:Label>                
            </asp:TableCell>
        </asp:TableRow>
    </asp:Table>

    <div id="Guest">
        <asp:Button ID="Btn_LoginRedirect" runat="server" Text="Login Page" Visible="false" OnClick="Btn_LoginRedirect_Click" />
        <br />
        <asp:Button ID="Btn_RegisterRedirect" runat="server" Text="Register Page" Visible="false" OnClick="Btn_RegisterRedirect_Click" />
        <br />
        <asp:Button ID="Btn_ProductRedirect" runat="server" Text="Product Page" Visible="false" OnClick="Btn_ProductRedirect_Click" />
        <br />
        <asp:Button ID="Btn_HomeRedirect" runat="server" Text="Homepage" Visible="false" OnClick="Btn_HomeRedirect_Click" />
    </div>
</asp:Content>
