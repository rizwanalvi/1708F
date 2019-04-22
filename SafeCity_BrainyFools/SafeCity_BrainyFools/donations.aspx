<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="donations.aspx.cs" Inherits="_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">



    <!-- Full Body Container -->
  <div id="container">





       <!-- Start Page Banner -->
      <div class="page-banner" style="height:200px; background: url(image/do.jpg); background-repeat: no-repeat;width: 100%; background-size: cover">
        <div class="container">
          <div class="row">
            <div class="col-md-6">
             
            </div>
            <div class="col-md-6">
              <ul  class="breadcrumbs">
                <li><a href="#">Home</a></li>
                <li>Donation</li>
              </ul>
            </div>
          </div>
        </div>
      </div>
      <!-- End Page Banner -->
<br>
      <div class="container">
      <h4 class="classic-title" style="margin-bottom: 50px; margin-top: 50px"><span>PERSONAL INFORMATION</span></h4>
                    
                            <div class="form-group">
                                <div class="col-xs-12">
                                    <input type="text" class="form-control" name="firstName" placeholder="First name" required data-error="Write your message" />
                                </div>
                                <div class="col-xs-4">
                                </div>
                            </div>
                        
                            <div class="form-group">
                                <div class="col-xs-12">
                                    <input type="number" class="form-control" placeholder="mobile" name="phoneNumber" required data-error="Write your message" />
                                </div>
                            </div>
                        
                            <div class="form-group">
                                 <div class="col-xs-12">
                                    <input type="text" class="form-control" name="email" placeholder="Email" required data-error="Write your message" />
                                </div>
                            </div>
                        
                            <div class="form-group">
                                <label class="col-xs-3 control-label">Message</label>
                                <div class="col-xs-5">
                                    <textarea class="form-control" name="message" rows="10" required data-error="Write your message"></textarea>
                                </div>
                            </div>
                        
                            <div class="form-group"> 
                                <label class="col-xs-3 control-label" id="captchaOperation">money</label>

                                <div class="col-xs-5">

                                    <input type="number" class="form-control" name="phoneNumber" required data-error="Write your message" />
                              
                                </div>
                            </div>
                        
                            <div class="form-group">
                                <div class="col-xs-9 col-xs-offset-3">
                                    <button type="submit" class="btn btn-primary">Submit</button>
                                </div>
                            </div>
                        
            </div>
        </div>
      </div>











      </div>

    <!--end of dull body tag-->


</asp:Content>

