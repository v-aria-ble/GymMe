<%@ Page Title="" Language="C#" MasterPageFile="~/Views/NavBar.Master" AutoEventWireup="true" CodeBehind="HomePage.aspx.cs" Inherits="PSD_LabProject_GymMe.Controllers.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h3 id="GreetingsText" runat ="server">Hello, </h3>
    <div>
        <asp:GridView ID="UserList" runat="server" AutoGenerateColumns="false">
            <Columns>
                <asp:BoundField DataField="UserId" HeaderText="ID" SortExpression="UserId" />
                <asp:BoundField DataField="UserName" HeaderText="Username" SortExpression="UserName" />
                <asp:BoundField DataField="UserEmail" HeaderText="Email" SortExpression="UserEmail" />
                <asp:BoundField DataField="UserDOB" HeaderText="Date of Birth" SortExpression="UserDOB" />
                <asp:BoundField DataField="UserGender" HeaderText="Gender" SortExpression="UserGender" />
                <asp:BoundField DataField="UserRole" HeaderText="Role" SortExpression="UserRole" />
                <asp:BoundField DataField="UserPassword" HeaderText="Password" SortExpression="UserPassword" />
            </Columns>
        </asp:GridView>
        <asp:EntityDataSource runat="server" ID="LocalDatabaseEntities"></asp:EntityDataSource>
        <asp:SqlDataSource runat="server" ID="SqlDataSource1"></asp:SqlDataSource>
    </div>
</asp:Content>
