<%@ Page Title="" Async="false" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="ShortUrl.Default" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">



</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="inputform" runat="server">
    <div class="input-group" id="inputblock">
       
            <div class="row">
                <div class="col-md-8">
                    <input type="text" name="url_text" id="url_text" class="form-control input-lg" placeholder="Enter your url"/></div>
                <div class="col-md-4">
                    <input type="button" id="generate_btn" class="btn btn-primary btn-block btn-lg" onclick="Validation()" value="Generate Short" /></div>

            </div>
   </div>
    <div class="modal fade" id="myModal" tabindex="-1" role="dialog" aria-labelledby="myModalLabel" aria-hidden="true">
  <div class="modal-dialog">
    <div class="modal-content">
      <div class="modal-body">
          <div class="panel panel-default" id="panel">
              <div class="panel-heading">
                  <h3 class="panel-title">Your url</h3>
              </div>
              <div class="panel-body" >
                    <b id="data"></b>
              </div>
          </div>
      </div>
      <div class="modal-footer">
        <button type="button" class="btn btn-default btn-danger" data-dismiss="modal">Close</button>
        
      </div>
    </div>
  </div>
</div>
</asp:Content>
