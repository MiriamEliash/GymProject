<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="HomeSubscribers.aspx.cs" Inherits="GymProject.HomeSubscribers" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

     <form runat="server">
    

 <div class="container">
      <header class="blog-header py-3">
        <div class="row flex-nowrap justify-content-between align-items-center">
          <div class="col-4 pt-1" </div>
 
          <div class="col-4 d-flex justify-content-end align-items-center">
            <a class="text-muted" href="#">
              
            </a>
       
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

            <a class="p-2 text-muted" href="CalanderOfClasses.aspx">Calander</a>
        
          
        </nav>
      </div>

      <div class="jumbotron p-3 p-md-5 text-black rounded" " style="background-color: beige">
        <div class="col-md-6 px-0">
          <h2 class="display-4 font-italic" style="line-height: 41px;">Welcome</h2>
          <p class="lead my-3">to the place that will make you not give up!</p>


        </div>
       <div> 
           <br />
           <asp:Button ID="Button1" runat="server" Text="Calander" class="btn btn-sm btn-outline-secondary"  OnClick="Button1_Click" />
  </div>
   <br />

      <div class="row mb-2">
        <div class="col-md-6">
          <div class="card flex-md-row mb-4 box-shadow h-md-250">
            <div class="card-body d-flex flex-column align-items-start" style="height: 100px; padding-top: 19px; text-decoration-color: rgb(255, 255, 255);">
              
              <h3 class="mb-0">
                <a class="text-dark" style="padding-top: 0px; margin-top: 0px; min-width: 0px; padding-bottom: 64px; padding-right: 0px; line-height: 2px;">Why sport is important?</a>
              </h3>
          
              <p class="card-text mb-auto" style="height: 90px;">Exercise helps prevent many types of diseases, raises concentration and energy and strengthens the body.</p>
              
            </div>
              
         <img src="Photos/spinning.jpeg"  style="width: 200px; height: 200px;"  data-holder-rendered="true">
          </div>
        </div>
        <div class="col-md-6">
          <div class="card flex-md-row mb-4 box-shadow h-md-250">
            <div class="card-body d-flex flex-column align-items-start">
             
              <h3 class="mb-0">
                <a class="text-dark"> Tips to help you not give up</a>
              </h3>
         
              <p class="card-text mb-auto" style="margin-bottom: 64px; padding-bottom: 0px; height: 65px;">Stick to sports three times a week at first.Find a sport that you love and someone who will encourage you. </p>
              
            </div>
              
             <img src="Photos/yoga.jpeg"   data-holder-rendered="true" style="width: 200px; height: 200px;"/>
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
