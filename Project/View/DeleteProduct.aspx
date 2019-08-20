<%@ Page Title="" Language="C#" MasterPageFile="~/View/Main.Master" AutoEventWireup="true" CodeBehind="DeleteProduct.aspx.cs" Inherits="Project.View.DeleteProduct" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>Delete Shoe</h1>
    <div>
        Shoe Database:
        <asp:GridView ID="shoeDGV" runat="server">
            <Columns>
                <asp:TemplateField HeaderText="">
                    <ItemTemplate>
                        <asp:Image ID="ShoeImage" ImageUrl='<%# "~/Uploads/"+Eval("ShoeImage") %>' runat="server" Height="50"></asp:Image>
                    </ItemTemplate>
                </asp:TemplateField>
            </Columns>
        </asp:GridView>
    </div>

    <div>
        <asp:TextBox ID="delShoeID" runat="server" placeholder="Delete Shoe ID"></asp:TextBox>
        <br />
        <asp:Button ID="DeleteBtn" runat="server" Text="Delete" OnClick="DeleteBtn_Click" />
    </div>
</asp:Content>
