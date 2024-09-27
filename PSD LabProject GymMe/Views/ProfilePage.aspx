<%@ Page Title="" Language="C#" MasterPageFile="~/Views/NavBar.Master" AutoEventWireup="true" CodeBehind="ProfilePage.aspx.cs" Inherits="PSD_LabProject_GymMe.Views.WebForm4" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h3>Profile Page</h3>
    <div>
        <asp:Label ID="UsernameLbl" runat="server" Text="Username:"></asp:Label>
        <asp:TextBox ID="UsernameTb" runat="server"></asp:TextBox>
    </div>
    <div>
        <asp:Label ID="EmailLbl" runat="server" Text="Email :"></asp:Label>
        <asp:TextBox ID="EmailTb" runat="server"></asp:TextBox>
    </div>
    <div>
        <asp:Label ID="CurrDobLbl" runat="server" Text="Current Date of Birth: "></asp:Label>
    </div>
    <div>
        <asp:Label ID="DobLbl" runat="server" Text="Date Of Birth:"></asp:Label>
        <asp:TextBox ID="DobTb" runat="server" type="date"></asp:TextBox>
    </div>
    <asp:Label ID="CurrentGenderLbl" runat="server" Text="Current Gender:"></asp:Label>
    <div>
        <asp:Label ID="GenderLbl" runat="server" Text="Gender:"></asp:Label>
        <asp:DropDownList ID="GenderList" runat="server">
            <asp:ListItem Text ="Choose..."/>
            <asp:ListItem Text ="Male"/>
            <asp:ListItem Text ="Female"/>
        </asp:DropDownList>
    </div>
    <div>
        <asp:Label ID="ErrorLbl" runat="server" Text=""></asp:Label>
    </div>
    <asp:Button ID="UpdateProfileBtn" runat="server" Text="Update Profile" OnClick="UpdateProfileBtn_Click" />
    <div>
        <asp:Label ID="OldPasswordLbl" runat="server" Text="Old Password:"></asp:Label>
        <asp:TextBox ID="OldPasswordTb" runat="server"></asp:TextBox>
    </div>
    <div>
        <asp:Label ID="NewPwLbl" runat="server" Text="New Password   :"></asp:Label>
        <asp:TextBox ID="NewPwTb" runat="server"></asp:TextBox>
    </div>
    <div>
        <asp:Label ID="ErrorLbl2" runat="server" Text=""></asp:Label>
    </div>
    <asp:Button ID="ChangePasswordBtn" runat="server" Text="Change Password" OnClick="ChangePasswordBtn_Click" />
    
</asp:Content>
