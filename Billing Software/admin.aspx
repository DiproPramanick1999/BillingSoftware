<%@ Page Title="" Language="C#" MasterPageFile="~/BillAndStock.Master" AutoEventWireup="true" CodeBehind="admin.aspx.cs" Inherits="Billing_Software.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <script src="admin.js" type="text/javascript"></script>

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">


   <!--main content start-->
    <section id="main-content">
      <section class="wrapper">
        <div class="row">
          <div class="col-lg-12">
            <h3 class="page-header"><i class="fa fa-table"></i> Table</h3>
            <ol class="breadcrumb">
              <li><i class="fa fa-home"></i><a href="index.html">Home</a></li>
              <li><i class="fa fa-table"></i>Table</li>
              <li><i class="fa fa-th-list"></i>Basic Table</li>
            </ol>
          </div>
        </div>
        <!-- page start-->
       
          
<!--above is isertig directly part-->         
          <div class="row">
          <div class="col-lg-12">
            <section class="panel">
              <header class="panel-heading">
                Advanced Table
              </header>

              <table class="table table-striped table-advance table-hover">
                <thead>
                  <tr>
                    <th><i class="icon_profile"></i> OrderId</th>
                    <th style="text-align:center;"><i class="icon_calendar"></i> Product</th>
                    <th style="padding-right:150px;"><i class="icon_mail_alt"></i> Price</th>
                    <th>Modify</th>
                  </tr>
                </thead>
                <tbody data-bind="foreach: productList">
                    <tr>
                        <td data-bind="text: orderId">12738002</td>
                        <td data-bind="text: product" style="text-align:center">Washing Machine</td>
                        <td style="padding-right:150px;"><span>₹</span><span data-bind="text: price"style="text-align:right;padding-right:50px;"></span></td>
                        <td>
                      <div class="btn-group">
                        <a class="btn btn-primary" href="#"><i class="icon_plus_alt2"></i></a>
                        <a class="btn btn-success" href="#"><i class="icon_check_alt2"></i></a>
                        <a class="btn btn-danger" data-bind="click: cdelete" ><i class="icon_close_alt2"></i></a>
                      </div>
                        </td>
                        
                    </tr>
                </tbody>
               
              </table>
            </section>
          </div>
        </div>
        <!-- page end-->
      </section>
    </section>


</asp:Content>
