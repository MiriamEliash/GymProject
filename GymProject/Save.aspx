<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Save.aspx.cs" Inherits="GymProject.Save" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">




</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<form runat="server">

     <div class="jumbotron p-3 p-md-5 text-black rounded" " style="background-color: beige" >
        <div class="col-md-6 px-0">
        
           <asp:Label ID="Label1" runat="server" Text="" ForeColor="black" ></asp:Label>
       

            </div>
        </div>

      <br />
        <asp:Label ID="Label2" runat="server" Text="" ForeColor="black" ></asp:Label>
      <asp:Button ID="Button1" runat="server" Text="Save" class="btn btn-sm btn-outline-secondary" OnClick="Button1_Click"/>
            <br />
      <a href="Calander.aspx" class="tColor">Back</a>
</form>
</asp:Content>
