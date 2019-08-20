<%@ Page Title="" Language="C#" MasterPageFile="~/View/Main.Master" AutoEventWireup="true" CodeBehind="UpdateProduct.aspx.cs" Inherits="Project.View.UpdateProduct" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
      <h1>Update Product</h1>
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

    <div style="background: blue;">
        Update Shoe:
            <br />
        <asp:TextBox ID="updateShoeID" runat="server" placeholder="updateShoeID"></asp:TextBox>
        <br />
        <asp:TextBox ID="updateShoeName" runat="server" placeholder="updateShoeName"></asp:TextBox>
        <br />
        <asp:TextBox ID="updateShoePrice" runat="server" placeholder="updateShoePrice"></asp:TextBox>
        <br />
        <asp:TextBox ID="updateShoeStock" runat="server" placeholder="updateShoeStock"></asp:TextBox>
        <br />
        <asp:FileUpload ID="updateShoeImage" runat="server" />
        <br />
        <asp:Button ID="updateBtn" runat="server" Text="Update" OnClick="updateBtn_Click" />
        <br />
        <asp:Label ID="Label_Error" runat="server" Text=""></asp:Label>
    </div>
</asp:Content>
