<%@ Page Title="" Language="C#" MasterPageFile="~/Views/NavBar.Master" AutoEventWireup="true" CodeBehind="ManageSupplementPage.aspx.cs" Inherits="PSD_LabProject_GymMe.Views.ManageSupplementPage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h3>Manage Supplements</h3>
    <asp:GridView ID="SupplementManageList" runat="server" AutoGenerateColumns ="False" OnRowDeleting="SupplementOrderList_RowDeleting" OnRowUpdating="SupplementOrderList_RowUpdating">
        <Columns>
            <asp:BoundField DataField="SupplementId" HeaderText="ID" SortExpression="SupplementId" />
            <asp:BoundField DataField="SupplementName" HeaderText="Supplement Name" SortExpression="SupplementName" />
            <asp:BoundField DataField="SupplementExpiryDate" HeaderText="Expiry Date" SortExpression="SupplementExpiryDate" />
            <asp:BoundField DataField="SupplementPrice" HeaderText="Price" SortExpression="SupplementPrice" />
            <asp:BoundField DataField="SupplementTypeId" HeaderText="Type ID" SortExpression="SupplementTypeId" />
            <asp:BoundField DataField="SupplementTypeName" HeaderText="Supplement Type" SortExpression="SupplementTypeName" />
            <asp:TemplateField HeaderText="Actions">
                <ItemTemplate>
                    <asp:Button ID="UpdateBtn" runat="server" Text="Update" UseSubmitBehavior="false" CommandName ="Update"/>
                    <asp:Button ID="Delete" runat="server" Text="Delete" UseSubmitBehavior="false" CommandName ="Delete" />
                </ItemTemplate>
            </asp:TemplateField>
        </Columns>

    </asp:GridView>
    <div>
        <asp:Button ID="InsertBtn" runat="server" Text="Insert..."  OnClick="InsertBtn_Click"/>
    </div>
</asp:Content>
