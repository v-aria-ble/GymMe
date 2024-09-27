<%@ Page Title="" Language="C#" MasterPageFile="~/Views/NavBar.Master" AutoEventWireup="true" CodeBehind="TransactionDetailPage.aspx.cs" Inherits="PSD_LabProject_GymMe.Views.WebForm6" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <h3>Transaction Details</h3>
    <div>
        <asp:GridView ID="TransactionDetailGV" runat="server" AutoGenerateColumns="false">
            <Columns>
                <asp:BoundField DataField="TransactionId" HeaderText="ID" SortExpression="TransactionId"></asp:BoundField>
                <asp:BoundField DataField="TransactionDate" HeaderText="Date" SortExpression="TransactionDate"></asp:BoundField>
                <asp:BoundField DataField="SupplementId" HeaderText="Supplement ID" SortExpression="SupplementId"></asp:BoundField>
                <asp:BoundField DataField="SupplementName" HeaderText="Supplement" SortExpression="SupplementName"></asp:BoundField>
                <asp:BoundField DataField="Quantity" HeaderText="Quantity" SortExpression="Quantity"></asp:BoundField>
                <asp:BoundField DataField="Status" HeaderText="Status" SortExpression="Status"></asp:BoundField>
            </Columns>
        </asp:GridView>
    </div>
</asp:Content>
