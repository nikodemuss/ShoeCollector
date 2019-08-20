<%@ Page Title="" Language="C#" MasterPageFile="~/View/Main.Master" AutoEventWireup="true" CodeBehind="ViewProduct.aspx.cs" Inherits="Project.View.ViewProduct" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
        <h1>View Product</h1>
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

    <br />
    <div>
        <h1>Search</h1>
        <asp:TextBox ID="Txt_Search" runat="server"></asp:TextBox>
        <br />
        <asp:Button ID="Btn_Search" runat="server" Text="Button" OnClick="Btn_Search_Click" />
        <br />
        Result:
        <asp:GridView ID="shoeSearch" runat="server">
            <Columns>
            </Columns>
        </asp:GridView>
    </div>
    <br />
    <div id="Member">
        <asp:Button ID="Btn_AddToCart" runat="server" Text="Add to Cart" Visible="false" OnClick="Btn_AddToCart_Click" />
    </div>

    <div id="Admin">
        <asp:Button ID="Btn_AddProduct" runat="server" Text="Add Product" Visible="false" OnClick="Btn_AddProduct_Click" />
        <br />
        <asp:Button ID="Btn_UpdateProduct" runat="server" Text="Update Product" Visible="false" OnClick="Btn_UpdateProduct_Click" />
        <br />
        <asp:Button ID="Btn_DeleteProduct" runat="server" Text="Delete Product" Visible="false" OnClick="Btn_DeleteProduct_Click" />
    </div>
</asp:Content>
