﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" UnobtrusiveValidationMode="None"  AutoEventWireup="true" CodeBehind="Charge.aspx.cs" Inherits="GymProject.Charge" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

<link href="//netdna.bootstrapcdn.com/twitter-bootstrap/2.3.2/css/bootstrap-combined.min.css" rel="stylesheet" id="bootstrap-css">
<script src="//netdna.bootstrapcdn.com/twitter-bootstrap/2.3.2/js/bootstrap.min.js"></script>
<script src="//code.jquery.com/jquery-1.11.1.min.js"></script>
   

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

<div class="container">
  <div class="row">
    <div class="span12">
      <form class="form-horizontal span6" runat="server">
        <fieldset>
          <legend>Payment</legend>

       
          <div class="control-group">
              <asp:Label ID="Label1" class="control-label" runat="server" Text="Card Number"></asp:Label>  
              
            
            <div class="controls">
             <asp:TextBox ID="CardNumber" runat="server"  type="FreightCompany" class="form-control"  placeholder="Card Number"></asp:TextBox>
          <asp:RequiredFieldValidator ID="RequiredUsername1" runat="server" ErrorMessage="**שדה זה לא יכול להיות ריק" ControlToValidate="CardNumber" ForeColor="Red"></asp:RequiredFieldValidator>	
	       <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" CssClass="vStyle" ErrorMessage="**מספר כרטיס לא תקני" ValidationExpression="\d{16}"  ForeColor="Red" ControlToValidate="CardNumber"></asp:RegularExpressionValidator>
            </div>
       
          <div class="control-group">
              <asp:Label ID="Label2" class="control-label" runat="server" Text="Card Expiry Date"></asp:Label>

            <div class="controls">
              <div class="row-fluid">
                <div class="span9">
                    <select id="Select1" class="input-block-level">
                       <option>01</option>
                      <option>02</option>
                      <option>03</option>
                      <option>04</option>
                      <option>05</option>
                      <option>06</option>
                      <option>07</option>
                      <option>08</option>
                      <option>09</option>
                      <option>10</option>
                      <option>11</option>
                      <option>12</option>
                    </select>
                </div>
                <div class="span3">
                      <select id="Select2"  class="input-block-level">                       
                      <option>2021</option>
                      <option>2022</option>
                      <option>2023</option>
                      <option>2024</option>
                      <option>2025</option>
                      <option>2026</option>
                      <option>2027</option>
                      <option>2028</option>
                      <option>2029</option>
                        </select>
                </div>
              </div>
            </div>
          </div>
       
          <div class="control-group">
             <asp:Label ID="Label3" class="control-label" runat="server" Text="Card CVV"></asp:Label>
            <div class="controls">
              <div class="row-fluid">
                <div class="span3">
                   <asp:TextBox ID="TextBox5" type="text" class="input-block-level" autocomplete="off" maxlength="3" pattern="\d{3}" title="Three digits at back of your card" runat="server"></asp:TextBox>
                   <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ErrorMessage="**שדה זה לא יכול להיות ריק" ControlToValidate="TextBox5" ForeColor="Red"></asp:RequiredFieldValidator>

                </div>

           <div class="control-group">
              <asp:Label ID="Label4" class="control-label" runat="server" Text="number of classes"></asp:Label>

                  <div class="span4">
                      <select id="numClass"  class="input-block-level">                       
                      <option>1</option>
                      <option>2</option>
                      <option>3</option>
                      <option>4</option>
                      <option>5</option>
                      <option>6</option>
                      <option>7</option>
                      <option>8</option>
                      <option>9</option>
                      <option>10</option>
                        </select>

                                </div>



              </div>
            </div>
          </div>
       
          <div class="form-actions">
            <asp:Button ID="Button1" type="submit" class="btn btn-primary" runat="server" Text="Next" OnClick="Button1_Click1" />
             <a href="Calander.aspx" class="tColor">Back</a>
          </div>
        </fieldset>
      </form>
    </div>
  </div>
</div>
</asp:Content>
