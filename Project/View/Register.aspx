<%@ Page Title="" Language="C#" MasterPageFile="~/View/Main.Master" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="Project.View.Register" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Label Text="Register" runat="server"></asp:Label>
    <asp:Table runat="server">
        <asp:TableRow>
            <asp:TableCell>
                <asp:Label Text="Name" runat="server"></asp:Label>
            </asp:TableCell>
            <asp:TableCell>
                <asp:TextBox ID="Txt_Name" runat="server"></asp:TextBox>
            </asp:TableCell>
        </asp:TableRow>

        <asp:TableRow>
            <asp:TableCell>
                <asp:Label Text="Email" runat="server"></asp:Label>
            </asp:TableCell>
            <asp:TableCell>
                <asp:TextBox ID="Txt_Email" runat="server" TextMode="Email"></asp:TextBox>
            </asp:TableCell>
        </asp:TableRow>

        <asp:TableRow>
            <asp:TableCell>
                <asp:Label Text="Password" runat="server"></asp:Label>
            </asp:TableCell>
            <asp:TableCell>
                <asp:TextBox ID="Txt_Password" runat="server" TextMode="Password"></asp:TextBox>
            </asp:TableCell>
        </asp:TableRow>

        <asp:TableRow>
            <asp:TableCell>
                <asp:Label Text="Confirm Password" runat="server"></asp:Label>
            </asp:TableCell>
            <asp:TableCell>
                <asp:TextBox ID="Txt_ConfirmPassword" runat="server" TextMode="Password"></asp:TextBox>
            </asp:TableCell>
        </asp:TableRow>

        <asp:TableRow>
            <asp:TableCell>
                <asp:Label Text="Gender" runat="server"></asp:Label>
            </asp:TableCell>
            <asp:TableCell>
                <asp:RadioButtonList ID="Gender" runat="server">
                    <asp:ListItem Text="Male" Value="1"></asp:ListItem>
                    <asp:ListItem Text="Female" Value="2"></asp:ListItem>
                </asp:RadioButtonList>
            </asp:TableCell>
        </asp:TableRow>

        <asp:TableRow>
            <asp:TableCell>
                <asp:Label Text="Birth Date" runat="server"></asp:Label>
            </asp:TableCell>
            <asp:TableCell>
                <asp:Calendar ID="Calendar_BirthDate" runat="server"></asp:Calendar>
            </asp:TableCell>
        </asp:TableRow>

          <asp:TableRow>
            <asp:TableCell>
                <asp:Label Text="Phone Number" runat="server"></asp:Label>
            </asp:TableCell>
            <asp:TableCell>
                <asp:TextBox ID="Txt_Phone" runat="server"></asp:TextBox>
            </asp:TableCell>
        </asp:TableRow>

          <asp:TableRow>
            <asp:TableCell>
                <asp:Label Text="Address" runat="server"></asp:Label>
            </asp:TableCell>
            <asp:TableCell>
                <asp:TextBox ID="Txt_Address" runat="server"></asp:TextBox>
            </asp:TableCell>
        </asp:TableRow>

          <asp:TableRow>
            <asp:TableCell>
                <asp:Label Text="Profile Picture" runat="server"></asp:Label>
            </asp:TableCell>
            <asp:TableCell>
                <asp:FileUpload ID="File_ProfilePicture" runat="server" />
            </asp:TableCell>
        </asp:TableRow>

        <asp:TableRow>
            <asp:TableCell>
                <asp:Button ID="Btn_Register" Text="Register" runat="server" OnClick="Btn_Register_Click" />
            </asp:TableCell>
        </asp:TableRow>

        <asp:TableRow>
            <asp:TableCell>
                <asp:Label ID="Label_Error" runat="server" Text=""></asp:Label>
            </asp:TableCell>
        </asp:TableRow>
    </asp:Table>
</asp:Content>
