<%@ Page Title="" Language="C#" MasterPageFile="~/Views/NavBar.Master" AutoEventWireup="true" CodeBehind="RegisterPage.aspx.cs" Inherits="PSD_LabProject_GymMe.Views.WebForm2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>Register Page</h1>
    <div>
        <asp:Label ID="UsernameLbl" runat="server" Text="Username:"></asp:Label>
        <asp:TextBox ID="UsernameTb" runat="server"></asp:TextBox>
    </div>
    <div>
        <asp:Label ID="EmailLbl" runat="server" Text="Email :"></asp:Label>
        <asp:TextBox ID="EmailTb" runat="server"></asp:TextBox>
    </div>
    <div>
        <asp:Label ID="DobLbl" runat="server" Text="Date Of Birth:"></asp:Label>
        <asp:TextBox ID="DobTb" runat="server" type="date"></asp:TextBox>
    </div>
    <div>
        <asp:Label ID="GenderLbl" runat="server" Text="Gender:"></asp:Label>
        <asp:DropDownList ID="GenderList" runat="server" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
            <asp:ListItem Text ="Choose..."/>
            <asp:ListItem Text ="Male"/>
            <asp:ListItem Text ="Female"/>
        </asp:DropDownList>
    </div>
    <div>
        <asp:Label ID="PasswordLbl" runat="server" Text="Password   :"></asp:Label>
        <asp:TextBox ID="PasswordTb" runat="server"></asp:TextBox>
    </div>
    <div>
        <asp:Label ID="ConfirmPwLbl" runat="server" Text="Confirm Password   :"></asp:Label>
        <asp:TextBox ID="ConfirmPwTb" runat="server"></asp:TextBox>
    </div>
    <div>
        <asp:Label ID="ErrorLbl" runat="server" Text=""></asp:Label>
    </div>
    
    <asp:Button ID="RegisterBtn" runat="server" Text="Register" OnClick="RegisterBtn_Click" />
    <asp:Button ID="LoginBtn" runat="server" Text="Login" OnClick="LoginBtn_Click"/>
</asp:Content>
