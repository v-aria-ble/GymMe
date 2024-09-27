<%@ Page Title="" Language="C#" MasterPageFile="~/Views/NavBar.Master" AutoEventWireup="true" CodeBehind="TransactionQueue.aspx.cs" Inherits="PSD_LabProject_GymMe.Views.TransactionQueue" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h3>Transaction Queue</h3>
    <div>
        <asp:GridView ID="TransQueueGV" runat="server" AutoGenerateColumns="False">
            <Columns>
                <asp:BoundField DataField="TransactionId" HeaderText="ID" SortExpression="TransactionId" />
                <asp:BoundField DataField="UserId" HeaderText="User ID" SortExpression="UserId" />
                <asp:BoundField DataField="TransactionDate" HeaderText="Date" SortExpression="TransactionDate" />
                <asp:BoundField DataField="Status" HeaderText="Status" SortExpression="Status" />
            </Columns>
        </asp:GridView>
    </div>
    <div>
        <asp:Label ID="ErrorLbl" runat="server" Text=""></asp:Label>
    </div>
    <asp:Button ID="HandleBtn" runat="server" Text="Handle Transactions" OnClick="HandleBtn_Click" />
</asp:Content>
