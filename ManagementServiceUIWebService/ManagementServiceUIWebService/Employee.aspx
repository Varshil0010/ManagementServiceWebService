<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Employee.aspx.cs" Inherits="ManagementServiceUIWebService.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder" runat="server">

    <h2> Welcome to Management Service Solutions!!</h2>

    <br /><br />
    <%--<h1><span class="badge badge-success btn-lg btn-block">Existing Orders</span></h1>--%>

    <asp:Label ID="Label1" runat="server" Text="" ForeColor="Red"></asp:Label>
    <div class="form-group row">
        <label for="employeeNo" class="col-sm-2 col-form-label">Employee NO</label>
        <div class="col-sm-10">
            <asp:TextBox class="form-control" ID="employeeID" runat="server" placeholder="id" ></asp:TextBox>
        </div>
    </div>
    <div class="form-group row">
        <label for="firstName" class="col-sm-2 col-form-label">First Name</label>
        <div class="col-sm-10">
            <asp:TextBox class="form-control" ID="txtFName" runat="server" placeholder="FirstName"></asp:TextBox>
        </div>
    </div>
    <div class="form-group row">
        <label for="lastName" class="col-sm-2 col-form-label">Last Name</label>
        <div class="col-sm-10">
           <asp:TextBox class="form-control" ID="txtLName" runat="server" placeholder="LastName"></asp:TextBox>
        </div>
    </div>
    <div class="form-group row">
        <label for="Title" class="col-sm-2 col-form-label">Job Title</label>
        <div class="col-sm-10">
            <asp:TextBox class="form-control" ID="txtJob" runat="server" placeholder="JobTitle"></asp:TextBox>
        </div>
    </div>

    <div class="form-group row">
        <label for="department" class="col-sm-2 col-form-label">Department</label>
        <div class="col-sm-10">
            <asp:TextBox class="form-control" ID="txtDepartment" runat="server" placeholder="Department"></asp:TextBox>
        </div>
    </div>

     <div class="form-group row">
        <label for="email" class="col-sm-2 col-form-label">Email</label>
        <div class="col-sm-10">
            <asp:TextBox class="form-control" ID="txtEmail" runat="server" placeholder="Email"></asp:TextBox>
        </div>
    </div>

     <asp:Label ID="lblEmployee" runat="server" ForeColor="Red"></asp:Label>

     <div class="form-group row">
        <div class="col-sm-10">
            <asp:Button CssClass="btn btn-primary" ID="btnSubmit" runat="server" Text="Enter Customer" OnClick="btnSubmit_Click"></asp:Button>&nbsp;&nbsp;
            <asp:Button CssClass="btn btn-secondary" ID="btnUpdate" runat="server" Text="Update Customer" OnClick="btnUpdate_Click"></asp:Button>&nbsp;&nbsp;
            <asp:Button CssClass="btn btn-danger" ID="btnDelete" runat="server" Text="Delete Customer" OnClick="btnDelete_Click"></asp:Button>&nbsp;&nbsp;
        </div>
    </div>

    <h1><span class="badge badge-success btn-lg btn-block">Existing Employee</span></h1>

    <asp:GridView ID="gvOrders" runat="server"></asp:GridView>

</asp:Content>
