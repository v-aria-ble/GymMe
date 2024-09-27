<%@ Page Title="" Language="C#" MasterPageFile="~/Views/NavBar.Master" AutoEventWireup="true" CodeBehind="OrderSupplementPage.aspx.cs" Inherits="PSD_LabProject_GymMe.Views.WebForm3" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h3>Order Supplements</h3>
    <asp:GridView ID="SupplementOrderList" runat="server" AutoGenerateColumns ="False" OnRowUpdating="SupplementOrderList_RowUpdating" >
        <Columns>
            <asp:BoundField DataField="SupplementId" HeaderText="ID" SortExpression="SupplementId" />
            <asp:BoundField DataField="SupplementName" HeaderText="Supplement Name" SortExpression="SupplementName" />
            <asp:BoundField DataField="SupplementExpiryDate" HeaderText="Expiry Date" SortExpression="SupplementExpiryDate" />
            <asp:BoundField DataField="SupplementPrice" HeaderText="Price" SortExpression="SupplementPrice" />
            <asp:BoundField DataField="SupplementTypeId" HeaderText="Type ID" SortExpression="SupplementTypeId" />
            <asp:BoundField DataField="SupplementTypeName" HeaderText="Supplement Type" SortExpression="SupplementTypeName" />
            <asp:TemplateField HeaderText="Quantity">
                <ItemTemplate>
                    <asp:TextBox ID="QuantityTb" runat="server"></asp:TextBox>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Action">
                <ItemTemplate>
                    <asp:Button ID="AddCartBtn" runat="server" Text="Add to Cart" UseSubmitBehavior="false"  CommandName="Update" />
                </ItemTemplate>
            </asp:TemplateField>
        </Columns>

    </asp:GridView>
    <div>
        <asp:Label ID="ErrorLbl" runat="server" Text=""></asp:Label>
    </div>
    <div>
        <h3>My Cart:</h3>
        <asp:GridView ID="MyCartList" runat="server" AutoGenerateColumns="False" OnSelectedIndexChanged="GridView1_SelectedIndexChanged">
            <Columns>
                <asp:BoundField DataField="SupplementId" HeaderText="ID" SortExpression="SupplementId" />
                <asp:BoundField DataField="SupplementName" HeaderText="Supplement Name" SortExpression="SupplementName" />
                <asp:BoundField DataField="SupplementPrice" HeaderText="Price" SortExpression="SupplementPrice" />
                <asp:BoundField DataField="Quantity" HeaderText="Quantity" SortExpression="Quantity" />
            </Columns>

        </asp:GridView>
    </div>
    <div>
    <asp:Label ID="ErrorLbl2" runat="server" Text=""></asp:Label>
    </div>
    <div>
        <asp:Button ID="ClearCartBtn" runat="server" Text="Clear Cart" OnClick="ClearCartBtn_Click" />
        <asp:Button ID="CheckoutBtn" runat="server" Text="Check out" OnClick="CheckoutBtn_Click" />
    </div>
    
</asp:Content>
