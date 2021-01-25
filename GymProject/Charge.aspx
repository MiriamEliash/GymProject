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
  <div class="container">
    <div class="row">
        <div class="col-xs-12 col-md-4">
            <div class="panel panel-default">
                <div class="panel-heading">
                    <h3 class="panel-title">Payment Details </h3>
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
                                <asp:Label ID="Label2" for="expityMonth" runat="server" Text="EXPIRY DATE"></asp:Label>
                            
                                <div class="col-xs-6 col-lg-6 pl-ziro">
                                    <asp:TextBox ID="expityMonth"  type="text" class="form-control" placeholder="MM" runat="server"></asp:TextBox>
                                </div>
                                <div class="col-xs-6 col-lg-6 pl-ziro"> 
                                    <asp:TextBox ID="expityYear"  type="text" class="form-control" placeholder="YY" runat="server"></asp:TextBox>
                            </div>
                        </div>
                        <div class="col-xs-5 col-md-5 pull-right">
                            <div class="form-group">
                                <asp:Label ID="Label3" for="cvCode" runat="server" Text=" CV CODE"></asp:Label>
                                <asp:TextBox ID="cvCode" type="password" class="form-control" placeholder="CV" runat="server"></asp:TextBox>
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
            <asp:Button ID="Button1"  class="btn btn-success btn-lg btn-block" runat="server" Text="Pay" OnClick="Button1_Click" />
        </div>
    </div>
</div>

</form>
    
</asp:Content>
