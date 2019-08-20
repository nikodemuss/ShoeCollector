<%@ Page Title="" Language="C#" MasterPageFile="~/View/Main.Master" AutoEventWireup="true" CodeBehind="ViewMember.aspx.cs" Inherits="Project.View.ViewMember" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    
     <h1>View Member</h1>
   <div>
        Member Database:
        <asp:GridView ID="userDGV" runat="server">
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
        <h1>Set as Admin</h1>
        <asp:TextBox ID="setAdminUserID" runat="server" placeholder="Enter User ID"></asp:TextBox>
         <br />
        <asp:Button ID="setAdminID" runat="server" Text="Set As Admin" OnClick="setAdminID_Click" />
        <asp:Label ID="setAdminErrorLabel" runat="server" Text=""></asp:Label>
    </div>

    <div>
        <h1>Delete User</h1>
        <asp:TextBox ID="delUserID" runat="server" placeholder="Delete User ID"></asp:TextBox>
        <br />
        <asp:Button ID="DeleteBtn" runat="server" Text="Delete" OnClick="DeleteBtn_Click" />
        <asp:Label ID="deleteUserErrorLabel" runat="server" Text=""></asp:Label>
    </div>
</asp:Content>
