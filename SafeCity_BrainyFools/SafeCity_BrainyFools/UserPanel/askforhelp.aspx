<%@ Page Title="" Language="C#" MasterPageFile="~/UserPanel/userhome.master" AutoEventWireup="true" CodeFile="askforhelp.aspx.cs" Inherits="UserPanel_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

   
      

    <!--main content start-->
    <section id="main-content">
      <section class="wrapper">
          
          <h1> If you have any problem Ask for Help  </h1>

           <div class="row">

              <div class="col-lg-6" style="border:0px solid red;">
                  <br /><br />
                   <div class="form-group">
    <label for="email">Your UserId :</label>
     <asp:TextBox ID="TextBox1"  Cssclass="form-control" runat="server"></asp:TextBox>

  </div>
  <div class="form-group">
    <label for="pwd">Your Complain:</label>

      <asp:TextBox ID="TextBox2" style="resize:none;" Cssclass="form-control" runat="server" height="150px" TextMode="MultiLine"></asp:TextBox>
  </div>



                  
                  <br/><br/>
          <asp:Button ID="Button1" Cssclass="btn btn-default" runat="server" Text="Send" OnClick="Button1_Click" />
                   
                       
                  <asp:Label ID="Label1" runat="server" Text="Latitude"></asp:Label>
        <asp:Label ID="Label2" runat="server" Text="Longitude"></asp:Label>
        

              </div>

              <div class="col-lg-6" style="border:0px solid red;">               

              </div>
          </div>    
      </section>
    </section>
    <!--main content end-->

   
     <script type="text/javascript">
if (navigator.geolocation) {
    navigator.geolocation.getCurrentPosition(function (p) {
        
        document.getElementById("Label1").textContent = p.coords.latitude;

        document.getElementById("Label2").innerHTML = p.coords.longitude;
        var LatLng = new google.maps.LatLng(p.coords.latitude, p.coords.longitude);
        var mapOptions = {
            center: LatLng,
            zoom: 13,
            mapTypeId: google.maps.MapTypeId.ROADMAP
        };
    
        
        var map = new google.maps.Map(document.getElementById("dvMap"), mapOptions);
        var marker = new google.maps.Marker({
            position: LatLng,
            map: map,
            title: "<div style = 'height:60px;width:200px'><b>Your location:</b><br />Latitude: " + p.coords.latitude + "<br />Longitude: " + p.coords.longitude
        });
        google.maps.event.addListener(marker, "click", function (e) {
            var infoWindow = new google.maps.InfoWindow();
            infoWindow.setContent(marker.title);
            infoWindow.open(map, marker);
        });
    });
} else {
    alert('Geo Location feature is not supported in this browser.');
}
</script>



</asp:Content>

