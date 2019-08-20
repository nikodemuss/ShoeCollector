<%@ Page Title="" Language="C#" MasterPageFile="~/View/Main.Master" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="Project.View.Home" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>Homepage</h1>
    <br />
    <h2>Top Product</h2>
    <div>
        Shoe Database:
        <asp:GridView ID="topDGV" runat="server">
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
        <p>
            Shoe Collector, the best shoes shop in Indonesia. Lots of shoes model are available here!
        </p>
    </div>

    <div>
        <asp:Button ID="HomeBtn" runat="server" Text="HomeBtn" OnClick="HomeBtn_Click" />
        <asp:Button ID="LoginBtn" runat="server" Text="LoginBtn" OnClick="LoginBtn_Click" />
        <asp:Button ID="ViewProductsBtn" runat="server" Text="ViewProductsBtn" OnClick="ViewProductsBtn_Click"/>


        <div id="guest">
            <asp:Button ID="RegisterBtn" runat="server" Text="RegisterBtn"  Visible="false" OnClick="RegisterBtn_Click"/>
        </div>

        <div>
            <asp:Button ID="ProfileBtn" runat="server" Text="ProfileBtn" Visible="false" OnClick="ProfileBtn_Click" />
            <asp:Button ID="ChangePasswordBtn" runat="server" Text="ChangePasswordBtn" Visible="false" OnClick="ChangePasswordBtn_Click"/>
            <asp:Button ID="AddToCartBtn" runat="server" Text="AddToCartBtn" Visible="false" OnClick="AddToCartBtn_Click"/>
            <asp:Button ID="CartBtn" runat="server" Text="CartBtn" Visible="false" OnClick="CartBtn_Click"/>
            <asp:Button ID="ViewTransactionsBtn" runat="server" Text="ViewTransactionsBtn" Visible="false" OnClick="ViewTransactionsBtn_Click"/>
            <asp:Button ID="AddProductBtn" runat="server" Text="AddProductBtn" Visible="false" OnClick="AddProductBtn_Click"/>
            <asp:Button ID="UpdateProductBtn" runat="server" Text="UpdateProductBtn" Visible="false" OnClick="UpdateProductBtn_Click"/>
            <asp:Button ID="TransactionReportBtn" runat="server" Text="TransactionReportBtn" Visible="false" OnClick="TransactionReportBtn_Click"/>
            <asp:Button ID="LogoutBtn" runat="server" Text="LogoutBtn" Visible="false" OnClick="LogoutBtn_Click"/>
            <asp:Button ID="ViewMemberBtn" runat="server" Text="LogoutBtn" Visible="false" OnClick="LogoutBtn_Click"/>

        </div>
    </div>
</asp:Content>
