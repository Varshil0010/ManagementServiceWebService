<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Performance.aspx.cs" Inherits="ManagementServiceUIWebService.Performance" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder" runat="server">

    <h2> Welcome to Management Service Solutions!!</h2>

    <br /><br />
    <%--<h1><span class="badge badge-success btn-lg btn-block">Existing Orders</span></h1>--%>

    <asp:Label ID="Label1" runat="server" Text="" ForeColor="Red"></asp:Label>
    <div class="form-group row">
        <label for="performanceID" class="col-sm-2 col-form-label">Performance ID</label>
        <div class="col-sm-10">
            <asp:TextBox class="form-control" ID="performanceID" runat="server" placeholder="Performance Id" ></asp:TextBox>
        </div>
    </div>
    <div class="form-group row">
        <label for="employeeID" class="col-sm-2 col-form-label">Employee ID</label>
        <div class="col-sm-10">
            <asp:TextBox class="form-control" ID="txtEmployee" runat="server" placeholder="Employee ID"></asp:TextBox>
        </div>
    </div>
    <div class="form-group row">
        <label for="date" class="col-sm-2 col-form-label">Review Date</label>
        <div class="col-sm-10">
           <asp:TextBox class="form-control" ID="txtDate" TextMode="Date" runat="server" placeholder="Date"></asp:TextBox>
        </div>
    </div>
    <div class="form-group row">
        <label for="goal" class="col-sm-2 col-form-label">Goal</label>
        <div class="col-sm-10">
            <asp:TextBox class="form-control" ID="txtGoal" runat="server" placeholder="Goal"></asp:TextBox>
        </div>
    </div>
    <div class="form-group row">
        <label for="review" class="col-sm-2 col-form-label">Review</label>
        <div class="col-sm-10">
            <asp:TextBox class="form-control" ID="txtReview" runat="server" placeholder="Review"></asp:TextBox>
        </div>
    </div>

     <asp:Label ID="lblPerformance" runat="server" ForeColor="Red"></asp:Label>

     <div class="form-group row">
        <div class="col-sm-10">
            <asp:Button CssClass="btn btn-primary" ID="btnSubmit" runat="server" Text="Submit Performance" OnClick="btnSubmit_Click"></asp:Button>&nbsp;&nbsp;
            <%--<asp:Button CssClass="btn btn-secondary" ID="btnUpdate" runat="server" Text="Update Customer" OnClick="btnUpdate_Click"></asp:Button>&nbsp;&nbsp;
            <asp:Button CssClass="btn btn-danger" ID="btnDelete" runat="server" Text="Delete Customer" OnClick="btnDelete_Click"></asp:Button>&nbsp;&nbsp;
        </div>--%>
    </div>
    <asp:GridView ID="gvOrders" runat="server"></asp:GridView>

</div>
</asp:Content>
