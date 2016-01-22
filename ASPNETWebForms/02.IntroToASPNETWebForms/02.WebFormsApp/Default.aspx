<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebFormsApp._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        <h2>Web Forms App </h2>
        <asp:Label ID="Label2" runat="server" Text=""></asp:Label>
        <br />
        <asp:Label ID="Label1" runat="server" Text="Hello, ASP.NET from the from the aspx code"></asp:Label>
    </div>

    <div class="row">
        <p>
            <strong>"Code behind" </strong>It contains the C# code behind pages. It is called if e.g. a button is clicked and an event is trigered
        </p>
    </div>

    <div class="row">
        <strong>Current assembly location:</strong>
        <br />
        <asp:Label ID="Label3" runat="server" Text=""></asp:Label>
        <br />
    </div>
    <br />
    <div class="row">
        <p>
            <strong>BundleConfig.cs </strong>Combines and optimizes CSS and JS files
        </p>
        <p>
            <strong>FilterConfig.cs </strong>Configures filters in MVC / Web API apps. 
            Configures pre-action and post-action behavior to the controller's action methods
        </p>
        <p>
            <strong>RouteConfig.cs </strong>Configures URL patterns and their handlers. 
            Maps user-friendly URLs to certain page / controller
        </p>
        <p>
            <strong>IdentityConfig.cs / Startup.Auth.cs </strong>Configures the membership authentication. 
             Users, roles, login, logout, user management OAuth login (cross-sites login, read more) Facebook / Twitter / Microsoft / Google login
        </p>
        <p>
            <strong>App_Data </strong>directory holds the local data files of the Web application
        </p>
        <p>
            <strong>Content </strong>Contains the boothstrap themes 
        </p>
        <p>
            <strong>Bundle.config</strong> combines the css files in one files
        </p>
        <p>
            <strong>packages.config</strong>contains the nuget packages
        </p>
        <p>
            <strong>Site.Master</strong>web pages template
        </p>
        <p>
            <strong>Site.Mobile.Master</strong>page template for mobile app
        </p>
        <p>
            <strong>Startup.cs</strong>entry point of the program
        </p>
         <p>
            <strong>ViewSwitcher.ascx</strong>switch betwen web and mobile app
        </p>

        <p>
            <strong>Web.config </strong>is web app's configuration file. Holds settings like DB connection strings, HTTP handlers, modules, assembly bindings.
            Can hold custom application settings, e.g. credentials for external services. Changes in Web.config do not require rebuild.
        </p>
        <p>
            <strong>Web.Debug.config </strong>Local settings for debugging. E.g. local database instance for testing
        </p>
        <p>
            <strong>Web.Release.config </strong>Production settings for real world deployment
        </p>
        <p>
            <strong>Global.asax </strong>defines the HTTP application.Defines global application events like<br />
            Application_Start<br />
            Application_BeginRequest<br />
            Application_EndRequest<br />
            Application_Error<br />
        </p>
    </div>

</asp:Content>
