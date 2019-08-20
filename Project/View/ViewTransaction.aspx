<%@ Page Title="" Language="C#" MasterPageFile="~/View/Main.Master" AutoEventWireup="true" CodeBehind="ViewTransaction.aspx.cs" Inherits="Project.View.ViewTransaction" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>View Transaction</h1>
    <br />
    <div>
        Transaction Data:
        <asp:GridView ID="productTransaction" runat="server">
            <Columns>
                <asp:TemplateField HeaderText="">
                    <ItemTemplate>
                        <%--<asp:Image ID="ShoeImage" ImageUrl='<%# "~/Uploads/"+Eval("ShoeImage") %>' runat="server" Height="50"></asp:Image>--%>
                        <asp:Button ID="changeToApprovedBtn" runat="server" Text="Change to Approved" OnClick="changeToApprovedBtn_Click"/>
                    </ItemTemplate>
                </asp:TemplateField>
            </Columns>
        </asp:GridView>
    </div>

    <div>
        <asp:TextBox ID="approveId" runat="server" placeholder="Change to Approved Id"></asp:TextBox>
        <asp:Button ID="approvedBtn" runat="server" Text="changeToApprovedBtn" OnClick="approvedBtn_Click"/>
    </div>

    <div>
        <asp:Button ID="generateTransactionBtn" runat="server" Text="Generate Transaction Report" OnClick="generateTransactionBtn_Click" />
    </div>
</asp:Content>
