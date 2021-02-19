 <%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="GymProject.Home" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

     <form runat="server">
    

 <div class="container">
      <header class="blog-header py-3">
        <div class="row flex-nowrap justify-content-between align-items-center">
          <div class="col-4 pt-1">
            
          </div>
 
          <div class="col-4 d-flex justify-content-end align-items-center">
            <a class="text-muted" href="#">
              
            </a>
            <a class="btn btn-sm btn-outline-secondary" href="Register.aspx">Sign up</a>
          </div>
        </div>
      </header>

      <div class="nav-scroller py-1 mb-2">
        <nav class="nav d-flex justify-content-between"> 
          <a class="p-2 text-muted" href="Corona.aspx" spellcheckker="false"
              style="color: black; background-color:#e2ecef;">Corona regulations</a>
          
          <a class="p-2 text-muted" href="SportsClubs.aspx">List of sports clubs</a>
       
          <a class="p-2 text-muted" href="#" spellcheckker="false"
              style="color: #ccc;background-color:  #e2ecef;">List of devices</a>
        
          
        </nav>
      </div>

      <div class="jumbotron p-3 p-md-5 text-black rounded" " style="background-color: beige">
        <div class="col-md-6 px-0">
          <h2 class="display-4 font-italic" style="line-height: 41px;">Welcome</h2>
          <p class="lead my-3">to the place that will make you not give up!</p>
            <br />

        </div>
       <div> 
      
         <asp:Button ID="Button1" runat="server" Text="Sign in" class="btn btn-sm btn-outline-secondary" OnClick="Button1_Click" />
               
          </div>
           <br />

      <div class="row mb-2">
        <div class="col-md-6">
          <div class="card flex-md-row mb-4 box-shadow h-md-250">
            <div class="card-body d-flex flex-column align-items-start" style="height: 100px; padding-top: 19px; text-decoration-color: rgb(255, 255, 255);">
              
              <h3 class="mb-0">
                <a class="text-dark" style="padding-top: 0px; margin-top: 0px; min-width: 0px; padding-bottom: 64px; padding-right: 0px; line-height: 2px;">Why you sould join?</a>
              </h3>
          
              <p class="card-text mb-auto" style="height: 90px;">THE GYM offers you a variety of sports classes with experienced instructors and range of special facilities.</p>
              
            </div>
         <img src="Photos/woman.img.jpg"  style="width: 200px; height: 200px;"  data-holder-rendered="true">
          </div>
        </div>
        <div class="col-md-6">
          <div class="card flex-md-row mb-4 box-shadow h-md-250">
            <div class="card-body d-flex flex-column align-items-start">
              <strong class="d-inline-block mb-2 text-success">So..? Are you ready?</strong>
              <h3 class="mb-0">
                <a class="text-dark"> How to join?</a>
              </h3>
             <br />
              <p class="card-text mb-auto" style="margin-bottom: 64px; padding-bottom: 0px; height: 65px;">Click the button above, enter your details and that's it, <u>welcome!</u></p>
              
            </div>
             <img src="Photos/together.img.jpg"   data-holder-rendered="true" style="width: 200px; height: 200px;"/>
          </div>
            
        </div>
      </div>
    </div>
        

    <main role="main" class="container">
      <div class="row">
        <!-- /.blog-main -->

        <aside class="col-md-4 blog-sidebar">
          <div class="p-3 mb-3 bg-light rounded" style="background-color: rgb(206, 199, 199); height: 200px; margin-right: 0px;">
            <h4 class="font-italic">Where?</h4>
            <p class="mb-0">You can find us in Tel Aviv,<div><div>&nbsp;Menachem Begin 53.<div>Also, you can look at our instegram page and facebok.<br><div><div align="center" data-component-instagram="" style="">			

          </div>

          

          
        </aside><!-- /.blog-sidebar -->

      </div><!-- /.row -->

    </main><!-- /.container -->

      <br />

   </form>

</asp:Content>
