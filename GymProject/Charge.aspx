<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Charge.aspx.cs" Inherits="GymProject.Charge" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

<link href="//netdna.bootstrapcdn.com/bootstrap/3.0.0/css/bootstrap.min.css" rel="stylesheet" id="bootstrap-css">
<script src="//netdna.bootstrapcdn.com/bootstrap/3.0.0/js/bootstrap.min.js"></script>
<script src="//code.jquery.com/jquery-1.11.1.min.js"></script>
    <style>

        body 
        { 
            margin-top:20px; 

        }
.panel-title 
{
    display: inline;
    font-weight: bold;

}
.checkbox.pull-right 
{ 
    margin: 0; 

}
.pl-ziro 
{ 
    padding-left: 0px; 
}

    </style>

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<form runat="server">

    <asp:Label ID="Label2" runat="server" Text="nameClass"></asp:Label>
    <asp:Label ID="Label3" runat="server" Text="NameInstructor"></asp:Label>
    <asp:Label ID="Label4" runat="server" Text="day"></asp:Label>
    <asp:Label ID="Label5" runat="server" Text="hour"></asp:Label>

           

  <div class="container">
    <div class="row">
        <div class="col-xs-12 col-md-4">
            <div class="panel panel-default">
                <div class="panel-heading">
                    <h3 class="panel-title">Payment Details </h3>
                    <div class="checkbox pull-right">
                             <asp:CheckBox ID="CheckBox1" runat="server" type="checkbox" Text=" Remember" />

                    </div>
                </div>
                <div class="panel-body">
                    <form role="form">
                    <div class="form-group">
                        <asp:Label ID="Label1" runat="server" Text=" CARD NUMBER"></asp:Label>
                        <div class="input-group">
                            <asp:TextBox ID="cardNumber"  class="form-control" runat="server" placeholder="Valid Card Number"></asp:TextBox>
 
                            <span class="input-group-addon"><span class="glyphicon glyphicon-lock"></span></span>
                        </div>
                    </div>
                    <div class="row">
                        <div class="col-xs-7 col-md-7">
                            <div class="form-group">
                                 
                                <label for="expityMonth"> EXPIRY DATE</label>
                                <div class="col-xs-6 col-lg-6 pl-ziro">
                                    <input type="text" class="form-control" id="expityMonth" placeholder="MM" required />
                                </div>
                                <div class="col-xs-6 col-lg-6 pl-ziro">
                                    <input type="text" class="form-control" id="expityYear" placeholder="YY" required /></div>
                            </div>
                        </div>
                        <div class="col-xs-5 col-md-5 pull-right">
                            <div class="form-group">
                                <label for="cvCode">
                                    CV CODE</label>
                                <input type="password" class="form-control" id="cvCode" placeholder="CV" required />
                            </div>
                        </div>
                    </div>
                    </form>
                </div>
            </div>
            <ul class="nav nav-pills nav-stacked">
                <li class="active"><a href="#"><span class="badge pull-right"><span class="glyphicon glyphicon-usd"></span>59.90</span> Final Payment</a>
                </li>
            </ul>
            <br/>
            <a href=" " class="btn btn-success btn-lg btn-block" role="button">Pay</a>
        </div>
    </div>
</div>

</form>
</asp:Content>
