<%@ Page Title="" Language="C#" MasterPageFile="~/View/Main.Master" AutoEventWireup="true" CodeBehind="AddProduct.aspx.cs" Inherits="Project.View.AddProduct" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
        <h1>Add Product</h1>
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

    <div style="background: green;">
        Insert Shoe: 
          <br />
        <asp:TextBox ID="shoeNameTxt" runat="server" placeholder="Shoe Name"></asp:TextBox>
        <br />
        <asp:TextBox ID="shoePriceTxt" runat="server" placeholder="Shoe Price"></asp:TextBox>
        <br />
        <asp:TextBox ID="shoeStockTxt" runat="server" placeholder="Shoe Stock"></asp:TextBox>
        <br />
        <asp:FileUpload ID="shoeImageUpload" runat="server" />
        <br />
        <asp:Button ID="InsertBtn" runat="server" Text="Insert" OnClick="InsertBtn_Click" />
        <br />
        <asp:Label ID="Label_Error" runat="server" Text=""></asp:Label>
    </div>
</asp:Content>
