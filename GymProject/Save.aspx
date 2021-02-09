<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Save.aspx.cs" Inherits="GymProject.Save" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">




</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<form runat="server">
     <div class="jumbotron p-3 p-md-5 text-black rounded" " style="background-color: beige" >
        <div class="col-md-6 px-0">
          <p class="lead my-3">Do you want to sign up to</p>
           <asp:Label ID="Label1" runat="server" Text="" ForeColor="black" ></asp:Label>

            <p class="lead my-3">, with-</p>
              <asp:Label ID="Label2" runat="server" Text="" ForeColor="black" ></asp:Label>

            <p class="lead my-3">, at-</p>
              <asp:Label ID="Label3" runat="server" Text="" ForeColor="black" ></asp:Label>
            <asp:Label ID="Label4" runat="server" Text="" ForeColor="black" ></asp:Label>
            </div>
        </div>

      <br />
      <asp:Button ID="Button1" runat="server" Text="Save" class="btn btn-sm btn-outline-secondary" />
            <br />
      <a href="Calander.aspx" class="tColor">Back</a>
</form>
</asp:Content>
