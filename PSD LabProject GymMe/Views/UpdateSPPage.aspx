<%@ Page Title="" Language="C#" MasterPageFile="~/Views/NavBar.Master" AutoEventWireup="true" CodeBehind="UpdateSPPage.aspx.cs" Inherits="PSD_LabProject_GymMe.Views.UpdateSPPage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h3>Update Supplement</h3>
    <asp:Label ID="EditLbl" runat="server" Text="Editing Supplement Id: "></asp:Label>
    <div>
        <asp:Label ID="SupplementNameLbl" runat="server" Text="Supplement Name:"></asp:Label>
        <asp:TextBox ID="SupplementNameTb" runat="server"></asp:TextBox>
    </div>
<div>
    <asp:Label ID="CurrentExpLbl" runat="server" Text="Current Expiry Date: "></asp:Label>
</div>
    <div>
    <asp:Label ID="SupplementExpiryDateLbl" runat="server" Text="Expiry Date:"></asp:Label>
    <asp:TextBox ID="SupplementExpiryDateTb" runat="server" type="date"></asp:TextBox>
</div>
    <div>
    <asp:Label ID="SupplementPriceLbl" runat="server" Text="Price:"></asp:Label>
    <asp:TextBox ID="SupplementPriceTb" runat="server"></asp:TextBox>
</div>
    <div>
    <asp:Label ID="TypeIdLbl" runat="server" Text="Supplement Type Id:"></asp:Label>
    <asp:TextBox ID="TypeIdTb" runat="server"></asp:TextBox>
</div>
<div>
    <asp:Label ID="ErrorLbl" runat="server" Text=""></asp:Label>
</div>
    <asp:Button ID="BackBtn" runat="server" Text="Back" OnClick="BackBtn_Click" />
    <asp:Button ID="UpdateBtn" runat="server" Text="Update" OnClick="UpdateBtn_Click" />
</asp:Content>
