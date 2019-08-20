<%@ Page Title="" Language="C#" MasterPageFile="~/View/Main.Master" AutoEventWireup="true" CodeBehind="Profile.aspx.cs" Inherits="Project.View.Profile" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>Profile</h1>
     <div>
        Profile Database:
        <asp:GridView ID="profileDGV" runat="server">
            <Columns>
                <asp:TemplateField HeaderText="">
                    <ItemTemplate>
                        <asp:Image ID="ShoeImage" ImageUrl='<%# "~/UploadsProfile/"+Eval("Profile") %>' runat="server" Height="50"></asp:Image>
                    </ItemTemplate>
                </asp:TemplateField>

            </Columns>
        </asp:GridView>

        
    </div>

    <div>
        <asp:Button ID="changePassBtn" runat="server" Text="Change Password" OnClick="changePassBtn_Click"  Visible="true" />
    </div>
</asp:Content>
