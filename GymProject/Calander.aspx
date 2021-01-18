<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Calander.aspx.cs" Inherits="GymProject.Calanser" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

<style>
    table 
    { 
       margin: 0px auto; 
      border: 1px solid black;
      border-style:ridge;
      text-align: center;
        height: 600px;
        width: 900px;
    }
th 
{ 
    background-color: beige;
    color: black;
    padding: 5px;
}
td 
{ 
    border: 1 solid black;
    padding: 5px;
}
</style>

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <form runat="server">
   <br />

    <asp:Label ID="codeT" runat="server" Text='<%#Eval("1") %>'></asp:Label>
    <asp:Label ID="day" runat="server" Text='<%#Eval("1") %>'></asp:Label>
    <asp:Label ID="hour" runat="server"  Text='<%#Eval("8:00") %>'></asp:Label>

    <asp:Button ID="Button1" runat="server" Text="הבא" CommandName='<%#Eval("code") %>'  OnClick="Button1_Click" />


        <asp:Repeater ID="Repeater1" runat="server"></asp:Repeater>

     <div class="jumbotron p-3 p-md-5 text-black rounded" " style="background-color: beige">
        <div class="col-md-6 px-0">
          <h2 class="display-4 font-italic" style="line-height: 41px;">Welcome</h2>
          <p class="lead my-3">to the place that will make you not give up!</p>

            </div>
        </div>

    <table border="1">
         <tr>
    <th> </th>
    <th>Sunday </th>
    <th>Monday </th>
    <th>Tuesday </th>
    <th>Wednesday </th>
    <th>Thursday </th>
    <th>Friday </th>
    <th>Saturday </th>
  </tr>
  <tr>
    <th>8:00</th>
    <td>שורה 1, תא 1</td>
    <td>שורה 1, תא 2</td>
    <td>שורה 1, תא 3</td>
    <td>שורה 1, תא 4</td>
    <td>שורה 1, תא 5</td>
    <td>שורה 1, תא 6</td>
    <td>שורה 1, תא 7</td>
  </tr>
  <tr>
    <th> 10:00</th>
    <td>שורה 2, תא 1</td>
    <td>שורה 2, תא 2</td>
    <td>שורה 2, תא 3</td>
    <td>שורה 2, תא 4</td>
    <td>שורה 2, תא 5</td>
    <td>שורה 2, תא 6</td>
    <td>שורה 2, תא 7</td>
  </tr>
  <tr>
    <th>15:00 </th>
    <td>שורה 3, תא 1</td>
    <td>שורה 3, תא 2</td>
    <td>שורה 3, תא 3</td>
    <td>שורה 3, תא 4</td>
    <td>שורה 3, תא 5</td>
    <td>שורה 3, תא 6</td>
    <td>שורה 3, תא 7</td>
  </tr>
 <tr>
    <th>16:00 </th>
    <td>שורה 4, תא 1</td>
    <td>שורה 4, תא 2</td>
    <td>שורה 4, תא 3</td>
    <td>שורה 4, תא 4</td>
    <td>שורה 4, תא 5</td>
    <td>שורה 4, תא 6</td>
    <td>שורה 4, תא 7</td>
  </tr>
 <tr>
    <th>20:00 </th>
    <td>שורה 5, תא 1</td>
    <td>שורה 5, תא 2</td>
    <td>שורה 5, תא 3</td>
    <td>שורה 5, תא 4</td>
    <td>שורה 5, תא 5</td>
    <td>שורה 5, תא 6</td>
    <td>שורה 5, תא 7</td>
  </tr>
 <tr>
    <th>21:00 </th>
    <td>שורה 6, תא 1</td>
    <td>שורה 6, תא 2</td>
    <td>שורה 6, תא 3</td>
    <td>שורה 6, תא 4</td>
    <td>שורה 6, תא 5</td>
    <td>שורה 6, תא 6</td>
    <td>שורה 6, תא 7</td>
  </tr>
</table>
    <br />
    </form>
</asp:Content>
