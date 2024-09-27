<%@ Page Title="" Language="C#" MasterPageFile="~/Views/NavBar.Master" AutoEventWireup="true" CodeBehind="LoginPage.aspx.cs" Inherits="PSD_LabProject_GymMe.Views.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>Log-In Page</h1>
    <div>
        <asp:Label ID="UsernameLbl" runat="server" Text="Username:"></asp:Label>
        <asp:TextBox ID="UsernameTb" runat="server"></asp:TextBox>
    </div>
    <div>
        <asp:Label ID="PasswordLbl" runat="server" Text="Password   :"></asp:Label>
        <asp:TextBox ID="PasswordTb" runat="server"></asp:TextBox>
    </div>
    <div>
        <asp:Label ID="ErrorLbl" runat="server" Text=""></asp:Label>
    </div>
    <div>
        <asp:CheckBox ID="RememberCheck" runat="server" />
        <asp:Label ID="RememberLbl" runat="server" Text="Remember Me"></asp:Label>
    </div>
    <asp:Button ID="LoginBtn" runat="server" Text="Login" OnClick="LoginBtn_Click"/>
    <asp:Button ID="RegisterBtn" runat="server" Text="Register" OnClick="RegisterBtn_Click" />
</asp:Content>
