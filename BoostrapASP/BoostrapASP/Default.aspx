<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/BoostrapASP.Master"
    CodeBehind="Default.aspx.vb" Inherits="BoostrapASP._Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="detailsGoHere" runat="server">
    <h1>
        Welcome to the site, you must log in to enter
    </h1>
    <div class="row">
        <div class="span6 offset3">
            <label for="inputEmail">
                Email</label>
            <input type="text" id="inputEmail" placeholder="Email"></input>
            <label for="inputPassword">Password</label>
            <input type="password" id="inputPassword" placeholder="Password"></input>
            <label class="checkbox">
                <input type="checkbox">Remember me</input>
            </label>
            <button type="submit" class="btn btn-large btn-primary">Sign in</button>
        </div>
    </div>
</asp:Content>
