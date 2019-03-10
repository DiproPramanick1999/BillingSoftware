<%@ Page Title="" Language="C#" MasterPageFile="~/BillAndStock.Master" AutoEventWireup="true" CodeBehind="insert.aspx.cs" Inherits="Billing_Software.WebForm2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <script src="insert.js" type="text/javascript"></script> 
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
              <div class ="insert">
              <p data-bind="text: name">hello</p>
              <p><h3>Order Id &nbsp; &nbsp;</h3> <input data-bind="textInput: order"  type="number" /></p>
              <p><h3>Product &nbsp; &nbsp;</h3> <input data-bind="textInput: product"  type="text" /></p>
              <p><h3>Price &nbsp; &nbsp;</h3> <input data-bind="textInput:  price"  type="number"/></p>
              <p><button data-bind ="click: send" class="btn btn-primary btn-lg">Submit</button></p>
          </div>
            </section>
          </div>
        </div>
        <!-- page end-->
      </section>
    </section>



</asp:Content>
