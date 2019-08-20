<%@ Page Title="" Language="C#" MasterPageFile="~/View/Main.Master" AutoEventWireup="true" CodeBehind="AddToCart.aspx.cs" Inherits="Project.View.AddToCart" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <h1>Add to Cart Page</h1>

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
        Cart Data Raw:
        <asp:GridView ID="cartDGV" runat="server">
            <Columns>
            </Columns>
        </asp:GridView>
    </div>

    <div>
        Cart Data:
        <asp:GridView ID="productCart" runat="server">
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
        <asp:TextBox ID="Txt_AddToCart" runat="server" Visible="true" placeholder="Insert ShoeID"></asp:TextBox>
        <asp:TextBox ID="itemQuantityTextBox" runat="server" placeholder="Enter The Quantity"></asp:TextBox>
        <asp:Button ID="addToCartBtn" runat="server" Text="Add To Cart" OnClick="addToCartBtn_Click" />
    </div>
</asp:Content>
