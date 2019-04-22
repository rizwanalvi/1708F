<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="signin.aspx.cs" Inherits="_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">



         
   <div class="mid-class">
         <div class="art-right-w3ls">
            <h2>Sign In and Sign Up</h2>
            <form action="#" method="post">
               <div class="main">
                  <div class="form-left-to-w3l">
                     <input type="text" name="name" placeholder="Username" required>
                  </div>
                  <div class="form-left-to-w3l ">
                     <input type="password" name="password" placeholder="Password" required>
                     <div class="clear"></div>
                  </div>
               </div>
               <div class="left-side-forget">
                  <input type="checkbox" class="checked">
                  <span class="remenber-me">Remember me </span>
               </div>
               <div class="right-side-forget">
                  <a href="#" class="for">Forgot password...?</a>
               </div>
               <div class="clear"></div>
               <ul>
                   <li>
               <div class="btnn">
                  <button type="submit">Sign In</button>
               </div>
               
            </form>
            <div class="w3layouts_more-buttn">
               <h3>Don't Have an account..?
                  <a href="#content1" style="color: #ED2C3A;">Sign Up Here
                  </a>
               </h3>
            </div>
            <!-- popup-->
            <div id="content1" class="popup-effect">
               <div class="popup">
                  <!--login form-->
                  <div class="letter-w3ls">
                     <form action="#" method="post">
                        <div class="form-left-to-w3l">
                           <input type="text" name="name" placeholder="Username" required>
                        </div>
                        <div class="form-left-to-w3l">
                           <input type="text" name="name" placeholder="Phone" required>
                        </div>
                        <div class="form-left-to-w3l">
                           <input type="email" name="email" placeholder="Email" required>
                        </div>
                        <div class="form-left-to-w3l">
                           <input type="password" name="password" placeholder="Password" required>
                        </div>
                        <div class="form-left-to-w3l margin-zero">
                           <input type="password" name="password" placeholder="Confirm Password" required>
                        </div>
                        <div class="btnn">
                           <button type="submit">Sign Up</button>
                           <br>
                        </div>
                     </form>
                     <div class="clear"></div>
                  </div>
                  <!--//login form-->
                  <a class="close" href="#">&times;</a>
               </div>
            </div>
            <!-- //popup -->
         </div>
         <div class="art-left-w3ls">
             
                <img alt="" style="margin-top: -20px" src="image/logo png log.png">
            <h1 class="header-w3ls">
               Welcome To Safe City
            </h1>
            <div class="btnn" style="text-align: right; margin-top: 15px; margin-right: 15px">
                    <button type="button" class="btn btn-default btn-sm">
                            <a href="index.html"><span class="glyphicon glyphicon-home"></span> Back to home</a>
                    </button>
             </div>
         </div>
      </div>




</asp:Content>

