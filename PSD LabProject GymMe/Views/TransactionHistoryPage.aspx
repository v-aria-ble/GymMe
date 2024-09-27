<%@ Page Title="" Language="C#" MasterPageFile="~/Views/NavBar.Master" AutoEventWireup="true" CodeBehind="TransactionHistoryPage.aspx.cs" Inherits="PSD_LabProject_GymMe.Views.TransactionHistoryPage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h3>Transaction History</h3>
    <asp:GridView ID="TransHistoryGV" runat="server" AutoGenerateColumns="False" OnSelectedIndexChanged="TransHistoryGV_SelectedIndexChanged" OnRowUpdating="TransHistoryGV_RowUpdating">
        <Columns>
            <asp:BoundField DataField="TransactionId" HeaderText="ID" SortExpression="TransactionId" />
            <asp:BoundField DataField="UserId" HeaderText="User ID" SortExpression="UserId" />
            <asp:BoundField DataField="TransactionDate" HeaderText="Date" SortExpression="TransactionDate" />
            <asp:BoundField DataField="Status" HeaderText="Status" SortExpression="Status" />
            <asp:TemplateField HeaderText="Actions">
                <ItemTemplate>
                    <asp:Button ID="DetailBtn" runat="server" Text="Details" CommandName="Update"/>
                </ItemTemplate>
            </asp:TemplateField>
        </Columns>
    </asp:GridView>
</asp:Content>
