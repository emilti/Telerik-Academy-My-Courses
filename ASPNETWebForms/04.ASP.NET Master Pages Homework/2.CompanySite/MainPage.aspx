<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MainPage.aspx.cs" Inherits="_2.CompanySite.MainPage" MasterPageFile="~/Site.Master" %>

<asp:Content ID="ContentPage" runat="server"
    ContentPlaceHolderID="ContentPlaceHolderPageContent"> 
    <div class="row">
        <div class="col-md-offset-3 col-md-3 text-center">
            <asp:HyperLink runat="server" NavigateUrl="~/Bulgaria/HomeBulgaria.aspx"
                Text="Bulgaria" CssClass="users-icon" />
        </div>
        <div class="col-md-3 text-center">
            <asp:HyperLink runat="server" NavigateUrl="~/England/HomeEngland.aspx"
                Text="England" CssClass="users-icon" />
        </div>
    </div>

</asp:Content>

