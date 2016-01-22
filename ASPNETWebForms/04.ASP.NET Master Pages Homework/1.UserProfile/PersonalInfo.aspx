<%@ Page Language="C#"
    AutoEventWireup="true"
    CodeBehind="PersonalInfo.aspx.cs"
    Inherits="_1.UserProfile.PersonalInfo"
    MasterPageFile="~/Site.Master" %>


<asp:Content ID="ContentMain" runat="server" ContentPlaceHolderID="ContentPlaceHolderMain">
    <div class="row">
        <div class="jumbotron col-md-offset-1 col-md-10">
            <div class="row">
                <div class="col-md-1"></div>
                <div class="col-md-3">
                    <img src="http://cdn2.hubspot.net/hub/245562/file-306538470-png/v3/ninja2.png?t=1453057863505" width="200px" /></div>
                <div class="col-md-7">
                    <div>
                        <label>Name: </label>
                        <span>Pesho Peshev</span>
                    </div>
                    <div>
                        <label>Age: </label>
                        <span>12</span>
                    </div>
                    <div>
                        <label>Address: </label>
                        <span>Sofia, Mladost, bl.2222, et.55</span>
                    </div>
                </div>
            </div>

        </div>
    </div>


</asp:Content>
