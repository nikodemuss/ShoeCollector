<%@ Page Title="" Language="C#" MasterPageFile="~/View/Main.Master" AutoEventWireup="true" CodeBehind="Cart.aspx.cs" Inherits="Project.View.Cart" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>Cart</h1>
    <br />
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
        Cart Grand Total:
        <asp:Label ID="grandTotal" runat="server" Text=""></asp:Label>
    </div>

    <div>
        <asp:Label ID="delProdLabel" runat="server" Text="Delete Product"></asp:Label>
        <asp:TextBox ID="deleteProductId" runat="server" placeholder="Insert Cart Id"></asp:TextBox>
        <asp:Button ID="delProductBtn" runat="server" Text="Delete Product From Cart" OnClick="delProductBtn_Click"/>
    </div>

    <div>
        <asp:Button ID="checkout" runat="server" Text="Checkout" OnClick="checkout_Click"/>
    </div>
</asp:Content>
