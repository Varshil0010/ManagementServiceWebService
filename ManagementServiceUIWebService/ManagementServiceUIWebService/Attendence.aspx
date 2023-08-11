<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Attendence.aspx.cs" Inherits="ManagementServiceUIWebService.Attendence" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder" runat="server">

    <h2> Welcome to Management Service Solutions!!</h2>

    <br /><br />
    <%--<h1><span class="badge badge-success btn-lg btn-block">Existing Orders</span></h1>--%>

    <asp:Label ID="Label1" runat="server" Text="" ForeColor="Red"></asp:Label>
    <div class="form-group row">
        <label for="attendenceID" class="col-sm-2 col-form-label">Attendence ID</label>
        <div class="col-sm-10">
            <asp:TextBox class="form-control" ID="attendenceID" runat="server" placeholder="Attendence Id" ></asp:TextBox>
        </div>
    </div>
    <div class="form-group row">
        <label for="employeeID" class="col-sm-2 col-form-label">Employee ID</label>
        <div class="col-sm-10">
            <asp:TextBox class="form-control" ID="txtEmployee" runat="server" placeholder="Employee ID"></asp:TextBox>
        </div>
    </div>
    <div class="form-group row">
        <label for="date" class="col-sm-2 col-form-label">Date</label>
        <div class="col-sm-10">
           <asp:TextBox class="form-control" ID="txtDate" TextMode="Date" runat="server" placeholder="Date"></asp:TextBox>
        </div>
    </div>
    <div class="form-group row">
        <label for="reason" class="col-sm-2 col-form-label">Reason</label>
        <div class="col-sm-10">
            <asp:TextBox class="form-control" ID="txtReason" runat="server" placeholder="Reason"></asp:TextBox>
        </div>
    </div>

     <asp:Label ID="lblAttendence" runat="server" ForeColor="Red"></asp:Label>

     <div class="form-group row">
        <div class="col-sm-10">
            <asp:Button CssClass="btn btn-primary" ID="btnSubmit" runat="server" Text="Submit Request" OnClick="btnSubmit_Click"></asp:Button>&nbsp;&nbsp;
            <%--<asp:Button CssClass="btn btn-secondary" ID="btnUpdate" runat="server" Text="Update Customer" OnClick="btnUpdate_Click"></asp:Button>&nbsp;&nbsp;
            <asp:Button CssClass="btn btn-danger" ID="btnDelete" runat="server" Text="Delete Customer" OnClick="btnDelete_Click"></asp:Button>&nbsp;&nbsp;
        </div>--%>
    </div>
    <asp:GridView ID="gvOrders" runat="server"></asp:GridView>

    </div>
</asp:Content>
