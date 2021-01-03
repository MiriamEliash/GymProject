<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="ClassTime.aspx.cs" Inherits="GymProject.ClassTime" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">



</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<center>
    <form runat="server">

        <br />

    <asp:DropDownList ID="codeClass" runat="server" OnSelectedIndexChanged="codeClass_SelectedIndexChanged"></asp:DropDownList>
        <br />
        <br />
    <asp:DropDownList ID="fullName" runat="server" OnSelectedIndexChanged="fullName_SelectedIndexChanged"></asp:DropDownList>
           <br />
           <br />
    <asp:DropDownList ID="Day" runat="server"></asp:DropDownList>
           <br />
           <br />
    <asp:DropDownList ID="Hour" runat="server"></asp:DropDownList>
           <br />

        <br />
       <asp:Button ID="Button1"  class="btn btn-sm btn-outline-secondary"  runat="server" Text="save" OnClick="Button1_Click"></asp:Button>
        <br />
        <br />
    </form>
</center> 
</asp:Content>
